// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.BtripOpen20220520.Models;

namespace AlibabaCloud.SDK.BtripOpen20220520
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("btripopen", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AccessTokenResponse AccessTokenWithOptions(AccessTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppSecret))
            {
                query["app_secret"] = request.AppSecret;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AccessToken",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/btrip-open-auth/v1/access-token/action/take",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AccessTokenResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AccessTokenResponse> AccessTokenWithOptionsAsync(AccessTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppSecret))
            {
                query["app_secret"] = request.AppSecret;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AccessToken",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/btrip-open-auth/v1/access-token/action/take",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AccessTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AccessTokenResponse AccessToken(AccessTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AccessTokenWithOptions(request, headers, runtime);
        }

        public async Task<AccessTokenResponse> AccessTokenAsync(AccessTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AccessTokenWithOptionsAsync(request, headers, runtime);
        }

        public AddInvoiceEntityResponse AddInvoiceEntityWithOptions(AddInvoiceEntityRequest tmpReq, AddInvoiceEntityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddInvoiceEntityShrinkRequest request = new AddInvoiceEntityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Entities))
            {
                request.EntitiesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Entities, "entities", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntitiesShrink))
            {
                body["entities"] = request.EntitiesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartId))
            {
                body["third_part_id"] = request.ThirdPartId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddInvoiceEntity",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/invoice/v1/entities",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddInvoiceEntityResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddInvoiceEntityResponse> AddInvoiceEntityWithOptionsAsync(AddInvoiceEntityRequest tmpReq, AddInvoiceEntityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddInvoiceEntityShrinkRequest request = new AddInvoiceEntityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Entities))
            {
                request.EntitiesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Entities, "entities", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntitiesShrink))
            {
                body["entities"] = request.EntitiesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartId))
            {
                body["third_part_id"] = request.ThirdPartId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddInvoiceEntity",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/invoice/v1/entities",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddInvoiceEntityResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddInvoiceEntityResponse AddInvoiceEntity(AddInvoiceEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddInvoiceEntityHeaders headers = new AddInvoiceEntityHeaders();
            return AddInvoiceEntityWithOptions(request, headers, runtime);
        }

        public async Task<AddInvoiceEntityResponse> AddInvoiceEntityAsync(AddInvoiceEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddInvoiceEntityHeaders headers = new AddInvoiceEntityHeaders();
            return await AddInvoiceEntityWithOptionsAsync(request, headers, runtime);
        }

        public AddressGetResponse AddressGetWithOptions(AddressGetRequest request, AddressGetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionType))
            {
                query["action_type"] = request.ActionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArrCityCode))
            {
                query["arr_city_code"] = request.ArrCityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArrCityName))
            {
                query["arr_city_name"] = request.ArrCityName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CarScenesCode))
            {
                query["car_scenes_code"] = request.CarScenesCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepCityCode))
            {
                query["dep_city_code"] = request.DepCityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepCityName))
            {
                query["dep_city_name"] = request.DepCityName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepDate))
            {
                query["dep_date"] = request.DepDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItineraryId))
            {
                query["itinerary_id"] = request.ItineraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["order_Id"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                query["phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                query["sub_corp_id"] = request.SubCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaobaoCallbackUrl))
            {
                query["taobao_callback_url"] = request.TaobaoCallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["user_id"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddressGet",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/open/v1/address",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddressGetResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddressGetResponse> AddressGetWithOptionsAsync(AddressGetRequest request, AddressGetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionType))
            {
                query["action_type"] = request.ActionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArrCityCode))
            {
                query["arr_city_code"] = request.ArrCityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArrCityName))
            {
                query["arr_city_name"] = request.ArrCityName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CarScenesCode))
            {
                query["car_scenes_code"] = request.CarScenesCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepCityCode))
            {
                query["dep_city_code"] = request.DepCityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepCityName))
            {
                query["dep_city_name"] = request.DepCityName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepDate))
            {
                query["dep_date"] = request.DepDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItineraryId))
            {
                query["itinerary_id"] = request.ItineraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["order_Id"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                query["phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                query["sub_corp_id"] = request.SubCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaobaoCallbackUrl))
            {
                query["taobao_callback_url"] = request.TaobaoCallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["user_id"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddressGet",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/open/v1/address",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddressGetResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddressGetResponse AddressGet(AddressGetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddressGetHeaders headers = new AddressGetHeaders();
            return AddressGetWithOptions(request, headers, runtime);
        }

        public async Task<AddressGetResponse> AddressGetAsync(AddressGetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddressGetHeaders headers = new AddressGetHeaders();
            return await AddressGetWithOptionsAsync(request, headers, runtime);
        }

        public AirportSearchResponse AirportSearchWithOptions(AirportSearchRequest request, AirportSearchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AirportSearch",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/city/v1/airport",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AirportSearchResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AirportSearchResponse> AirportSearchWithOptionsAsync(AirportSearchRequest request, AirportSearchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AirportSearch",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/city/v1/airport",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AirportSearchResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AirportSearchResponse AirportSearch(AirportSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AirportSearchHeaders headers = new AirportSearchHeaders();
            return AirportSearchWithOptions(request, headers, runtime);
        }

        public async Task<AirportSearchResponse> AirportSearchAsync(AirportSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AirportSearchHeaders headers = new AirportSearchHeaders();
            return await AirportSearchWithOptionsAsync(request, headers, runtime);
        }

        public AllBaseCityInfoQueryResponse AllBaseCityInfoQueryWithOptions(AllBaseCityInfoQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripAccessToken))
            {
                realHeaders["x-acs-btrip-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AllBaseCityInfoQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/city/v1/code",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AllBaseCityInfoQueryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AllBaseCityInfoQueryResponse> AllBaseCityInfoQueryWithOptionsAsync(AllBaseCityInfoQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripAccessToken))
            {
                realHeaders["x-acs-btrip-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AllBaseCityInfoQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/city/v1/code",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AllBaseCityInfoQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AllBaseCityInfoQueryResponse AllBaseCityInfoQuery()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AllBaseCityInfoQueryHeaders headers = new AllBaseCityInfoQueryHeaders();
            return AllBaseCityInfoQueryWithOptions(headers, runtime);
        }

        public async Task<AllBaseCityInfoQueryResponse> AllBaseCityInfoQueryAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AllBaseCityInfoQueryHeaders headers = new AllBaseCityInfoQueryHeaders();
            return await AllBaseCityInfoQueryWithOptionsAsync(headers, runtime);
        }

        public ApplyAddResponse ApplyAddWithOptions(ApplyAddRequest tmpReq, ApplyAddHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ApplyAddShrinkRequest request = new ApplyAddShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CarRule))
            {
                request.CarRuleShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CarRule, "car_rule", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExternalTravelerList))
            {
                request.ExternalTravelerListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExternalTravelerList, "external_traveler_list", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExternalTravelerStandard))
            {
                request.ExternalTravelerStandardShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExternalTravelerStandard, "external_traveler_standard", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HotelShare))
            {
                request.HotelShareShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HotelShare, "hotel_share", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ItineraryList))
            {
                request.ItineraryListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ItineraryList, "itinerary_list", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ItinerarySetList))
            {
                request.ItinerarySetListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ItinerarySetList, "itinerary_set_list", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TravelerList))
            {
                request.TravelerListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TravelerList, "traveler_list", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TravelerStandard))
            {
                request.TravelerStandardShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TravelerStandard, "traveler_standard", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Budget))
            {
                body["budget"] = request.Budget;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BudgetMerge))
            {
                body["budget_merge"] = request.BudgetMerge;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CarRuleShrink))
            {
                body["car_rule"] = request.CarRuleShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpName))
            {
                body["corp_name"] = request.CorpName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartId))
            {
                body["depart_id"] = request.DepartId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartName))
            {
                body["depart_name"] = request.DepartName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendField))
            {
                body["extend_field"] = request.ExtendField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalTravelerListShrink))
            {
                body["external_traveler_list"] = request.ExternalTravelerListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalTravelerStandardShrink))
            {
                body["external_traveler_standard"] = request.ExternalTravelerStandardShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlightBudget))
            {
                body["flight_budget"] = request.FlightBudget;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelBudget))
            {
                body["hotel_budget"] = request.HotelBudget;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelShareShrink))
            {
                body["hotel_share"] = request.HotelShareShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternationalFlightCabins))
            {
                body["international_flight_cabins"] = request.InternationalFlightCabins;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItineraryListShrink))
            {
                body["itinerary_list"] = request.ItineraryListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItineraryRule))
            {
                body["itinerary_rule"] = request.ItineraryRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItinerarySetListShrink))
            {
                body["itinerary_set_list"] = request.ItinerarySetListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LimitTraveler))
            {
                body["limit_traveler"] = request.LimitTraveler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                body["sub_corp_id"] = request.SubCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartApplyId))
            {
                body["thirdpart_apply_id"] = request.ThirdpartApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartBusinessId))
            {
                body["thirdpart_business_id"] = request.ThirdpartBusinessId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartDepartId))
            {
                body["thirdpart_depart_id"] = request.ThirdpartDepartId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TogetherBookRule))
            {
                body["together_book_rule"] = request.TogetherBookRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrainBudget))
            {
                body["train_budget"] = request.TrainBudget;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TravelerListShrink))
            {
                body["traveler_list"] = request.TravelerListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TravelerStandardShrink))
            {
                body["traveler_standard"] = request.TravelerStandardShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TripCause))
            {
                body["trip_cause"] = request.TripCause;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TripDay))
            {
                body["trip_day"] = request.TripDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TripTitle))
            {
                body["trip_title"] = request.TripTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionNo))
            {
                body["union_no"] = request.UnionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["user_name"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VehicleBudget))
            {
                body["vehicle_budget"] = request.VehicleBudget;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyAdd",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/apply/v1/biz-trip",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyAddResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ApplyAddResponse> ApplyAddWithOptionsAsync(ApplyAddRequest tmpReq, ApplyAddHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ApplyAddShrinkRequest request = new ApplyAddShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CarRule))
            {
                request.CarRuleShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CarRule, "car_rule", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExternalTravelerList))
            {
                request.ExternalTravelerListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExternalTravelerList, "external_traveler_list", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExternalTravelerStandard))
            {
                request.ExternalTravelerStandardShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExternalTravelerStandard, "external_traveler_standard", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HotelShare))
            {
                request.HotelShareShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HotelShare, "hotel_share", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ItineraryList))
            {
                request.ItineraryListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ItineraryList, "itinerary_list", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ItinerarySetList))
            {
                request.ItinerarySetListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ItinerarySetList, "itinerary_set_list", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TravelerList))
            {
                request.TravelerListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TravelerList, "traveler_list", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TravelerStandard))
            {
                request.TravelerStandardShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TravelerStandard, "traveler_standard", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Budget))
            {
                body["budget"] = request.Budget;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BudgetMerge))
            {
                body["budget_merge"] = request.BudgetMerge;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CarRuleShrink))
            {
                body["car_rule"] = request.CarRuleShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpName))
            {
                body["corp_name"] = request.CorpName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartId))
            {
                body["depart_id"] = request.DepartId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartName))
            {
                body["depart_name"] = request.DepartName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendField))
            {
                body["extend_field"] = request.ExtendField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalTravelerListShrink))
            {
                body["external_traveler_list"] = request.ExternalTravelerListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalTravelerStandardShrink))
            {
                body["external_traveler_standard"] = request.ExternalTravelerStandardShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlightBudget))
            {
                body["flight_budget"] = request.FlightBudget;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelBudget))
            {
                body["hotel_budget"] = request.HotelBudget;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelShareShrink))
            {
                body["hotel_share"] = request.HotelShareShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternationalFlightCabins))
            {
                body["international_flight_cabins"] = request.InternationalFlightCabins;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItineraryListShrink))
            {
                body["itinerary_list"] = request.ItineraryListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItineraryRule))
            {
                body["itinerary_rule"] = request.ItineraryRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItinerarySetListShrink))
            {
                body["itinerary_set_list"] = request.ItinerarySetListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LimitTraveler))
            {
                body["limit_traveler"] = request.LimitTraveler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                body["sub_corp_id"] = request.SubCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartApplyId))
            {
                body["thirdpart_apply_id"] = request.ThirdpartApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartBusinessId))
            {
                body["thirdpart_business_id"] = request.ThirdpartBusinessId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartDepartId))
            {
                body["thirdpart_depart_id"] = request.ThirdpartDepartId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TogetherBookRule))
            {
                body["together_book_rule"] = request.TogetherBookRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrainBudget))
            {
                body["train_budget"] = request.TrainBudget;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TravelerListShrink))
            {
                body["traveler_list"] = request.TravelerListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TravelerStandardShrink))
            {
                body["traveler_standard"] = request.TravelerStandardShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TripCause))
            {
                body["trip_cause"] = request.TripCause;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TripDay))
            {
                body["trip_day"] = request.TripDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TripTitle))
            {
                body["trip_title"] = request.TripTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionNo))
            {
                body["union_no"] = request.UnionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["user_name"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VehicleBudget))
            {
                body["vehicle_budget"] = request.VehicleBudget;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyAdd",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/apply/v1/biz-trip",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyAddResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ApplyAddResponse ApplyAdd(ApplyAddRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ApplyAddHeaders headers = new ApplyAddHeaders();
            return ApplyAddWithOptions(request, headers, runtime);
        }

        public async Task<ApplyAddResponse> ApplyAddAsync(ApplyAddRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ApplyAddHeaders headers = new ApplyAddHeaders();
            return await ApplyAddWithOptionsAsync(request, headers, runtime);
        }

        public ApplyApproveResponse ApplyApproveWithOptions(ApplyApproveRequest request, ApplyApproveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyId))
            {
                body["apply_id"] = request.ApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Note))
            {
                body["note"] = request.Note;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateTime))
            {
                body["operate_time"] = request.OperateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                body["sub_corp_id"] = request.SubCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["user_name"] = request.UserName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyApprove",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/apply/v1/biz-trip/action/approve",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyApproveResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ApplyApproveResponse> ApplyApproveWithOptionsAsync(ApplyApproveRequest request, ApplyApproveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyId))
            {
                body["apply_id"] = request.ApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Note))
            {
                body["note"] = request.Note;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateTime))
            {
                body["operate_time"] = request.OperateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                body["sub_corp_id"] = request.SubCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["user_name"] = request.UserName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyApprove",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/apply/v1/biz-trip/action/approve",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyApproveResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ApplyApproveResponse ApplyApprove(ApplyApproveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ApplyApproveHeaders headers = new ApplyApproveHeaders();
            return ApplyApproveWithOptions(request, headers, runtime);
        }

        public async Task<ApplyApproveResponse> ApplyApproveAsync(ApplyApproveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ApplyApproveHeaders headers = new ApplyApproveHeaders();
            return await ApplyApproveWithOptionsAsync(request, headers, runtime);
        }

        public ApplyExternalNodeStatusUpdateResponse ApplyExternalNodeStatusUpdateWithOptions(ApplyExternalNodeStatusUpdateRequest tmpReq, ApplyExternalNodeStatusUpdateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ApplyExternalNodeStatusUpdateShrinkRequest request = new ApplyExternalNodeStatusUpdateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OperationRecords))
            {
                request.OperationRecordsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OperationRecords, "operation_records", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["node_id"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationRecordsShrink))
            {
                body["operation_records"] = request.OperationRecordsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessActionResult))
            {
                body["process_action_result"] = request.ProcessActionResult;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyExternalNodeStatusUpdate",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/apply/v1/external-nodes/action/status-update",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyExternalNodeStatusUpdateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ApplyExternalNodeStatusUpdateResponse> ApplyExternalNodeStatusUpdateWithOptionsAsync(ApplyExternalNodeStatusUpdateRequest tmpReq, ApplyExternalNodeStatusUpdateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ApplyExternalNodeStatusUpdateShrinkRequest request = new ApplyExternalNodeStatusUpdateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OperationRecords))
            {
                request.OperationRecordsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OperationRecords, "operation_records", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["node_id"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationRecordsShrink))
            {
                body["operation_records"] = request.OperationRecordsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessActionResult))
            {
                body["process_action_result"] = request.ProcessActionResult;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyExternalNodeStatusUpdate",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/apply/v1/external-nodes/action/status-update",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyExternalNodeStatusUpdateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ApplyExternalNodeStatusUpdateResponse ApplyExternalNodeStatusUpdate(ApplyExternalNodeStatusUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ApplyExternalNodeStatusUpdateHeaders headers = new ApplyExternalNodeStatusUpdateHeaders();
            return ApplyExternalNodeStatusUpdateWithOptions(request, headers, runtime);
        }

        public async Task<ApplyExternalNodeStatusUpdateResponse> ApplyExternalNodeStatusUpdateAsync(ApplyExternalNodeStatusUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ApplyExternalNodeStatusUpdateHeaders headers = new ApplyExternalNodeStatusUpdateHeaders();
            return await ApplyExternalNodeStatusUpdateWithOptionsAsync(request, headers, runtime);
        }

        public ApplyInvoiceTaskResponse ApplyInvoiceTaskWithOptions(ApplyInvoiceTaskRequest tmpReq, ApplyInvoiceTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ApplyInvoiceTaskShrinkRequest request = new ApplyInvoiceTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InvoiceTaskList))
            {
                request.InvoiceTaskListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InvoiceTaskList, "invoice_task_list", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillDate))
            {
                body["bill_date"] = request.BillDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceTaskListShrink))
            {
                body["invoice_task_list"] = request.InvoiceTaskListShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyInvoiceTask",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/invoice/v1/apply-invoice-task",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyInvoiceTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ApplyInvoiceTaskResponse> ApplyInvoiceTaskWithOptionsAsync(ApplyInvoiceTaskRequest tmpReq, ApplyInvoiceTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ApplyInvoiceTaskShrinkRequest request = new ApplyInvoiceTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InvoiceTaskList))
            {
                request.InvoiceTaskListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InvoiceTaskList, "invoice_task_list", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillDate))
            {
                body["bill_date"] = request.BillDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceTaskListShrink))
            {
                body["invoice_task_list"] = request.InvoiceTaskListShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyInvoiceTask",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/invoice/v1/apply-invoice-task",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyInvoiceTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ApplyInvoiceTaskResponse ApplyInvoiceTask(ApplyInvoiceTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ApplyInvoiceTaskHeaders headers = new ApplyInvoiceTaskHeaders();
            return ApplyInvoiceTaskWithOptions(request, headers, runtime);
        }

        public async Task<ApplyInvoiceTaskResponse> ApplyInvoiceTaskAsync(ApplyInvoiceTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ApplyInvoiceTaskHeaders headers = new ApplyInvoiceTaskHeaders();
            return await ApplyInvoiceTaskWithOptionsAsync(request, headers, runtime);
        }

        public ApplyListQueryResponse ApplyListQueryWithOptions(ApplyListQueryRequest request, ApplyListQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllApply))
            {
                query["all_apply"] = request.AllApply;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartId))
            {
                query["depart_id"] = request.DepartId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["end_time"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtModified))
            {
                query["gmt_modified"] = request.GmtModified;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlyShangLvApply))
            {
                query["only_shang_lv_apply"] = request.OnlyShangLvApply;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["start_time"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                query["sub_corp_id"] = request.SubCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionNo))
            {
                query["union_no"] = request.UnionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["user_id"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyListQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/apply/v1/biz-trips",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyListQueryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ApplyListQueryResponse> ApplyListQueryWithOptionsAsync(ApplyListQueryRequest request, ApplyListQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllApply))
            {
                query["all_apply"] = request.AllApply;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartId))
            {
                query["depart_id"] = request.DepartId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["end_time"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtModified))
            {
                query["gmt_modified"] = request.GmtModified;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlyShangLvApply))
            {
                query["only_shang_lv_apply"] = request.OnlyShangLvApply;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["start_time"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                query["sub_corp_id"] = request.SubCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionNo))
            {
                query["union_no"] = request.UnionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["user_id"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyListQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/apply/v1/biz-trips",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyListQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ApplyListQueryResponse ApplyListQuery(ApplyListQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ApplyListQueryHeaders headers = new ApplyListQueryHeaders();
            return ApplyListQueryWithOptions(request, headers, runtime);
        }

        public async Task<ApplyListQueryResponse> ApplyListQueryAsync(ApplyListQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ApplyListQueryHeaders headers = new ApplyListQueryHeaders();
            return await ApplyListQueryWithOptionsAsync(request, headers, runtime);
        }

        public ApplyModifyResponse ApplyModifyWithOptions(ApplyModifyRequest tmpReq, ApplyModifyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ApplyModifyShrinkRequest request = new ApplyModifyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CarRule))
            {
                request.CarRuleShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CarRule, "car_rule", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExternalTravelerList))
            {
                request.ExternalTravelerListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExternalTravelerList, "external_traveler_list", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExternalTravelerStandard))
            {
                request.ExternalTravelerStandardShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExternalTravelerStandard, "external_traveler_standard", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HotelShare))
            {
                request.HotelShareShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HotelShare, "hotel_share", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ItineraryList))
            {
                request.ItineraryListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ItineraryList, "itinerary_list", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ItinerarySetList))
            {
                request.ItinerarySetListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ItinerarySetList, "itinerary_set_list", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TravelerList))
            {
                request.TravelerListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TravelerList, "traveler_list", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TravelerStandard))
            {
                request.TravelerStandardShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TravelerStandard, "traveler_standard", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Budget))
            {
                body["budget"] = request.Budget;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BudgetMerge))
            {
                body["budget_merge"] = request.BudgetMerge;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CarRuleShrink))
            {
                body["car_rule"] = request.CarRuleShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpName))
            {
                body["corp_name"] = request.CorpName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartId))
            {
                body["depart_id"] = request.DepartId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartName))
            {
                body["depart_name"] = request.DepartName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendField))
            {
                body["extend_field"] = request.ExtendField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalTravelerListShrink))
            {
                body["external_traveler_list"] = request.ExternalTravelerListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalTravelerStandardShrink))
            {
                body["external_traveler_standard"] = request.ExternalTravelerStandardShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlightBudget))
            {
                body["flight_budget"] = request.FlightBudget;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelBudget))
            {
                body["hotel_budget"] = request.HotelBudget;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelShareShrink))
            {
                body["hotel_share"] = request.HotelShareShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItineraryListShrink))
            {
                body["itinerary_list"] = request.ItineraryListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItineraryRule))
            {
                body["itinerary_rule"] = request.ItineraryRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItinerarySetListShrink))
            {
                body["itinerary_set_list"] = request.ItinerarySetListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LimitTraveler))
            {
                body["limit_traveler"] = request.LimitTraveler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                body["sub_corp_id"] = request.SubCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartApplyId))
            {
                body["thirdpart_apply_id"] = request.ThirdpartApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartBusinessId))
            {
                body["thirdpart_business_id"] = request.ThirdpartBusinessId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartDepartId))
            {
                body["thirdpart_depart_id"] = request.ThirdpartDepartId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TogetherBookRule))
            {
                body["together_book_rule"] = request.TogetherBookRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrainBudget))
            {
                body["train_budget"] = request.TrainBudget;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TravelerListShrink))
            {
                body["traveler_list"] = request.TravelerListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TravelerStandardShrink))
            {
                body["traveler_standard"] = request.TravelerStandardShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TripCause))
            {
                body["trip_cause"] = request.TripCause;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TripDay))
            {
                body["trip_day"] = request.TripDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TripTitle))
            {
                body["trip_title"] = request.TripTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionNo))
            {
                body["union_no"] = request.UnionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["user_name"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VehicleBudget))
            {
                body["vehicle_budget"] = request.VehicleBudget;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyModify",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/apply/v1/biz-trip",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyModifyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ApplyModifyResponse> ApplyModifyWithOptionsAsync(ApplyModifyRequest tmpReq, ApplyModifyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ApplyModifyShrinkRequest request = new ApplyModifyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CarRule))
            {
                request.CarRuleShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CarRule, "car_rule", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExternalTravelerList))
            {
                request.ExternalTravelerListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExternalTravelerList, "external_traveler_list", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExternalTravelerStandard))
            {
                request.ExternalTravelerStandardShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExternalTravelerStandard, "external_traveler_standard", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HotelShare))
            {
                request.HotelShareShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HotelShare, "hotel_share", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ItineraryList))
            {
                request.ItineraryListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ItineraryList, "itinerary_list", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ItinerarySetList))
            {
                request.ItinerarySetListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ItinerarySetList, "itinerary_set_list", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TravelerList))
            {
                request.TravelerListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TravelerList, "traveler_list", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TravelerStandard))
            {
                request.TravelerStandardShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TravelerStandard, "traveler_standard", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Budget))
            {
                body["budget"] = request.Budget;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BudgetMerge))
            {
                body["budget_merge"] = request.BudgetMerge;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CarRuleShrink))
            {
                body["car_rule"] = request.CarRuleShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpName))
            {
                body["corp_name"] = request.CorpName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartId))
            {
                body["depart_id"] = request.DepartId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartName))
            {
                body["depart_name"] = request.DepartName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendField))
            {
                body["extend_field"] = request.ExtendField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalTravelerListShrink))
            {
                body["external_traveler_list"] = request.ExternalTravelerListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalTravelerStandardShrink))
            {
                body["external_traveler_standard"] = request.ExternalTravelerStandardShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlightBudget))
            {
                body["flight_budget"] = request.FlightBudget;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelBudget))
            {
                body["hotel_budget"] = request.HotelBudget;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelShareShrink))
            {
                body["hotel_share"] = request.HotelShareShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItineraryListShrink))
            {
                body["itinerary_list"] = request.ItineraryListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItineraryRule))
            {
                body["itinerary_rule"] = request.ItineraryRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItinerarySetListShrink))
            {
                body["itinerary_set_list"] = request.ItinerarySetListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LimitTraveler))
            {
                body["limit_traveler"] = request.LimitTraveler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                body["sub_corp_id"] = request.SubCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartApplyId))
            {
                body["thirdpart_apply_id"] = request.ThirdpartApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartBusinessId))
            {
                body["thirdpart_business_id"] = request.ThirdpartBusinessId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartDepartId))
            {
                body["thirdpart_depart_id"] = request.ThirdpartDepartId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TogetherBookRule))
            {
                body["together_book_rule"] = request.TogetherBookRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrainBudget))
            {
                body["train_budget"] = request.TrainBudget;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TravelerListShrink))
            {
                body["traveler_list"] = request.TravelerListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TravelerStandardShrink))
            {
                body["traveler_standard"] = request.TravelerStandardShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TripCause))
            {
                body["trip_cause"] = request.TripCause;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TripDay))
            {
                body["trip_day"] = request.TripDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TripTitle))
            {
                body["trip_title"] = request.TripTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionNo))
            {
                body["union_no"] = request.UnionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["user_name"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VehicleBudget))
            {
                body["vehicle_budget"] = request.VehicleBudget;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyModify",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/apply/v1/biz-trip",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyModifyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ApplyModifyResponse ApplyModify(ApplyModifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ApplyModifyHeaders headers = new ApplyModifyHeaders();
            return ApplyModifyWithOptions(request, headers, runtime);
        }

        public async Task<ApplyModifyResponse> ApplyModifyAsync(ApplyModifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ApplyModifyHeaders headers = new ApplyModifyHeaders();
            return await ApplyModifyWithOptionsAsync(request, headers, runtime);
        }

        public ApplyQueryResponse ApplyQueryWithOptions(ApplyQueryRequest request, ApplyQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyId))
            {
                query["apply_id"] = request.ApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyShowId))
            {
                query["apply_show_id"] = request.ApplyShowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                query["sub_corp_id"] = request.SubCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartApplyId))
            {
                query["thirdpart_apply_id"] = request.ThirdpartApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/apply/v1/biz-trip",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyQueryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ApplyQueryResponse> ApplyQueryWithOptionsAsync(ApplyQueryRequest request, ApplyQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyId))
            {
                query["apply_id"] = request.ApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyShowId))
            {
                query["apply_show_id"] = request.ApplyShowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                query["sub_corp_id"] = request.SubCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartApplyId))
            {
                query["thirdpart_apply_id"] = request.ThirdpartApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/apply/v1/biz-trip",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ApplyQueryResponse ApplyQuery(ApplyQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ApplyQueryHeaders headers = new ApplyQueryHeaders();
            return ApplyQueryWithOptions(request, headers, runtime);
        }

        public async Task<ApplyQueryResponse> ApplyQueryAsync(ApplyQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ApplyQueryHeaders headers = new ApplyQueryHeaders();
            return await ApplyQueryWithOptionsAsync(request, headers, runtime);
        }

        public BaseCityInfoSearchResponse BaseCityInfoSearchWithOptions(BaseCityInfoSearchRequest request, BaseCityInfoSearchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripAccessToken))
            {
                realHeaders["x-acs-btrip-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BaseCityInfoSearch",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/city/v1/cities/action/search",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BaseCityInfoSearchResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BaseCityInfoSearchResponse> BaseCityInfoSearchWithOptionsAsync(BaseCityInfoSearchRequest request, BaseCityInfoSearchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripAccessToken))
            {
                realHeaders["x-acs-btrip-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BaseCityInfoSearch",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/city/v1/cities/action/search",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BaseCityInfoSearchResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BaseCityInfoSearchResponse BaseCityInfoSearch(BaseCityInfoSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BaseCityInfoSearchHeaders headers = new BaseCityInfoSearchHeaders();
            return BaseCityInfoSearchWithOptions(request, headers, runtime);
        }

        public async Task<BaseCityInfoSearchResponse> BaseCityInfoSearchAsync(BaseCityInfoSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BaseCityInfoSearchHeaders headers = new BaseCityInfoSearchHeaders();
            return await BaseCityInfoSearchWithOptionsAsync(request, headers, runtime);
        }

        public BtripBillInfoAdjustResponse BtripBillInfoAdjustWithOptions(BtripBillInfoAdjustRequest request, BtripBillInfoAdjustHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimaryId))
            {
                body["primary_id"] = request.PrimaryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartCostCenterId))
            {
                body["third_part_cost_center_id"] = request.ThirdPartCostCenterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartDepartmentId))
            {
                body["third_part_department_id"] = request.ThirdPartDepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartInvoiceId))
            {
                body["third_part_invoice_id"] = request.ThirdPartInvoiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartProjectId))
            {
                body["third_part_project_id"] = request.ThirdPartProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BtripBillInfoAdjust",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/bill/v1/info/action/adjust",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BtripBillInfoAdjustResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BtripBillInfoAdjustResponse> BtripBillInfoAdjustWithOptionsAsync(BtripBillInfoAdjustRequest request, BtripBillInfoAdjustHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimaryId))
            {
                body["primary_id"] = request.PrimaryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartCostCenterId))
            {
                body["third_part_cost_center_id"] = request.ThirdPartCostCenterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartDepartmentId))
            {
                body["third_part_department_id"] = request.ThirdPartDepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartInvoiceId))
            {
                body["third_part_invoice_id"] = request.ThirdPartInvoiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartProjectId))
            {
                body["third_part_project_id"] = request.ThirdPartProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BtripBillInfoAdjust",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/bill/v1/info/action/adjust",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BtripBillInfoAdjustResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BtripBillInfoAdjustResponse BtripBillInfoAdjust(BtripBillInfoAdjustRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BtripBillInfoAdjustHeaders headers = new BtripBillInfoAdjustHeaders();
            return BtripBillInfoAdjustWithOptions(request, headers, runtime);
        }

        public async Task<BtripBillInfoAdjustResponse> BtripBillInfoAdjustAsync(BtripBillInfoAdjustRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BtripBillInfoAdjustHeaders headers = new BtripBillInfoAdjustHeaders();
            return await BtripBillInfoAdjustWithOptionsAsync(request, headers, runtime);
        }

        public CarApplyAddResponse CarApplyAddWithOptions(CarApplyAddRequest tmpReq, CarApplyAddHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CarApplyAddShrinkRequest request = new CarApplyAddShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TravelerStandard))
            {
                request.TravelerStandardShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TravelerStandard, "traveler_standard", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cause))
            {
                body["cause"] = request.Cause;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                body["city"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CityCodeSet))
            {
                body["city_code_set"] = request.CityCodeSet;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Date))
            {
                body["date"] = request.Date;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FinishedDate))
            {
                body["finished_date"] = request.FinishedDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectCode))
            {
                body["project_code"] = request.ProjectCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["project_name"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartApplyId))
            {
                body["third_part_apply_id"] = request.ThirdPartApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartCostCenterId))
            {
                body["third_part_cost_center_id"] = request.ThirdPartCostCenterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartInvoiceId))
            {
                body["third_part_invoice_id"] = request.ThirdPartInvoiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimesTotal))
            {
                body["times_total"] = request.TimesTotal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimesType))
            {
                body["times_type"] = request.TimesType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimesUsed))
            {
                body["times_used"] = request.TimesUsed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TravelerStandardShrink))
            {
                body["traveler_standard"] = request.TravelerStandardShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CarApplyAdd",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/apply/v1/car",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CarApplyAddResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CarApplyAddResponse> CarApplyAddWithOptionsAsync(CarApplyAddRequest tmpReq, CarApplyAddHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CarApplyAddShrinkRequest request = new CarApplyAddShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TravelerStandard))
            {
                request.TravelerStandardShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TravelerStandard, "traveler_standard", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cause))
            {
                body["cause"] = request.Cause;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                body["city"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CityCodeSet))
            {
                body["city_code_set"] = request.CityCodeSet;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Date))
            {
                body["date"] = request.Date;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FinishedDate))
            {
                body["finished_date"] = request.FinishedDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectCode))
            {
                body["project_code"] = request.ProjectCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["project_name"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartApplyId))
            {
                body["third_part_apply_id"] = request.ThirdPartApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartCostCenterId))
            {
                body["third_part_cost_center_id"] = request.ThirdPartCostCenterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartInvoiceId))
            {
                body["third_part_invoice_id"] = request.ThirdPartInvoiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimesTotal))
            {
                body["times_total"] = request.TimesTotal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimesType))
            {
                body["times_type"] = request.TimesType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimesUsed))
            {
                body["times_used"] = request.TimesUsed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TravelerStandardShrink))
            {
                body["traveler_standard"] = request.TravelerStandardShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CarApplyAdd",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/apply/v1/car",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CarApplyAddResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CarApplyAddResponse CarApplyAdd(CarApplyAddRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CarApplyAddHeaders headers = new CarApplyAddHeaders();
            return CarApplyAddWithOptions(request, headers, runtime);
        }

        public async Task<CarApplyAddResponse> CarApplyAddAsync(CarApplyAddRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CarApplyAddHeaders headers = new CarApplyAddHeaders();
            return await CarApplyAddWithOptionsAsync(request, headers, runtime);
        }

        public CarApplyModifyResponse CarApplyModifyWithOptions(CarApplyModifyRequest request, CarApplyModifyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateTime))
            {
                body["operate_time"] = request.OperateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartApplyId))
            {
                body["third_part_apply_id"] = request.ThirdPartApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CarApplyModify",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/apply/v1/car",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CarApplyModifyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CarApplyModifyResponse> CarApplyModifyWithOptionsAsync(CarApplyModifyRequest request, CarApplyModifyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateTime))
            {
                body["operate_time"] = request.OperateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartApplyId))
            {
                body["third_part_apply_id"] = request.ThirdPartApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CarApplyModify",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/apply/v1/car",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CarApplyModifyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CarApplyModifyResponse CarApplyModify(CarApplyModifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CarApplyModifyHeaders headers = new CarApplyModifyHeaders();
            return CarApplyModifyWithOptions(request, headers, runtime);
        }

        public async Task<CarApplyModifyResponse> CarApplyModifyAsync(CarApplyModifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CarApplyModifyHeaders headers = new CarApplyModifyHeaders();
            return await CarApplyModifyWithOptionsAsync(request, headers, runtime);
        }

        public CarApplyQueryResponse CarApplyQueryWithOptions(CarApplyQueryRequest request, CarApplyQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedEndAt))
            {
                query["created_end_at"] = request.CreatedEndAt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedStartAt))
            {
                query["created_start_at"] = request.CreatedStartAt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["page_number"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartApplyId))
            {
                query["third_part_apply_id"] = request.ThirdPartApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["user_id"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CarApplyQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/apply/v1/car",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CarApplyQueryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CarApplyQueryResponse> CarApplyQueryWithOptionsAsync(CarApplyQueryRequest request, CarApplyQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedEndAt))
            {
                query["created_end_at"] = request.CreatedEndAt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedStartAt))
            {
                query["created_start_at"] = request.CreatedStartAt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["page_number"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartApplyId))
            {
                query["third_part_apply_id"] = request.ThirdPartApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["user_id"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CarApplyQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/apply/v1/car",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CarApplyQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CarApplyQueryResponse CarApplyQuery(CarApplyQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CarApplyQueryHeaders headers = new CarApplyQueryHeaders();
            return CarApplyQueryWithOptions(request, headers, runtime);
        }

        public async Task<CarApplyQueryResponse> CarApplyQueryAsync(CarApplyQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CarApplyQueryHeaders headers = new CarApplyQueryHeaders();
            return await CarApplyQueryWithOptionsAsync(request, headers, runtime);
        }

        public CarBillSettlementQueryResponse CarBillSettlementQueryWithOptions(CarBillSettlementQueryRequest request, CarBillSettlementQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["page_no"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodEnd))
            {
                query["period_end"] = request.PeriodEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodStart))
            {
                query["period_start"] = request.PeriodStart;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CarBillSettlementQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/car/v1/bill-settlement",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CarBillSettlementQueryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CarBillSettlementQueryResponse> CarBillSettlementQueryWithOptionsAsync(CarBillSettlementQueryRequest request, CarBillSettlementQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["page_no"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodEnd))
            {
                query["period_end"] = request.PeriodEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodStart))
            {
                query["period_start"] = request.PeriodStart;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CarBillSettlementQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/car/v1/bill-settlement",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CarBillSettlementQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CarBillSettlementQueryResponse CarBillSettlementQuery(CarBillSettlementQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CarBillSettlementQueryHeaders headers = new CarBillSettlementQueryHeaders();
            return CarBillSettlementQueryWithOptions(request, headers, runtime);
        }

        public async Task<CarBillSettlementQueryResponse> CarBillSettlementQueryAsync(CarBillSettlementQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CarBillSettlementQueryHeaders headers = new CarBillSettlementQueryHeaders();
            return await CarBillSettlementQueryWithOptionsAsync(request, headers, runtime);
        }

        public CarOrderListQueryResponse CarOrderListQueryWithOptions(CarOrderListQueryRequest request, CarOrderListQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllApply))
            {
                query["all_apply"] = request.AllApply;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyId))
            {
                query["apply_id"] = request.ApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartId))
            {
                query["depart_id"] = request.DepartId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["end_time"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["start_time"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartApplyId))
            {
                query["thirdpart_apply_id"] = request.ThirdpartApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateEndTime))
            {
                query["update_end_time"] = request.UpdateEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateStartTime))
            {
                query["update_start_time"] = request.UpdateStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["user_id"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CarOrderListQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/car/v1/order-list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CarOrderListQueryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CarOrderListQueryResponse> CarOrderListQueryWithOptionsAsync(CarOrderListQueryRequest request, CarOrderListQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllApply))
            {
                query["all_apply"] = request.AllApply;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyId))
            {
                query["apply_id"] = request.ApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartId))
            {
                query["depart_id"] = request.DepartId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["end_time"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["start_time"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartApplyId))
            {
                query["thirdpart_apply_id"] = request.ThirdpartApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateEndTime))
            {
                query["update_end_time"] = request.UpdateEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateStartTime))
            {
                query["update_start_time"] = request.UpdateStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["user_id"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CarOrderListQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/car/v1/order-list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CarOrderListQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CarOrderListQueryResponse CarOrderListQuery(CarOrderListQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CarOrderListQueryHeaders headers = new CarOrderListQueryHeaders();
            return CarOrderListQueryWithOptions(request, headers, runtime);
        }

        public async Task<CarOrderListQueryResponse> CarOrderListQueryAsync(CarOrderListQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CarOrderListQueryHeaders headers = new CarOrderListQueryHeaders();
            return await CarOrderListQueryWithOptionsAsync(request, headers, runtime);
        }

        public CarOrderQueryResponse CarOrderQueryWithOptions(CarOrderQueryRequest request, CarOrderQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["order_id"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubOrderId))
            {
                query["sub_order_id"] = request.SubOrderId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CarOrderQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/car/v1/order",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CarOrderQueryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CarOrderQueryResponse> CarOrderQueryWithOptionsAsync(CarOrderQueryRequest request, CarOrderQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["order_id"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubOrderId))
            {
                query["sub_order_id"] = request.SubOrderId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CarOrderQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/car/v1/order",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CarOrderQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CarOrderQueryResponse CarOrderQuery(CarOrderQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CarOrderQueryHeaders headers = new CarOrderQueryHeaders();
            return CarOrderQueryWithOptions(request, headers, runtime);
        }

        public async Task<CarOrderQueryResponse> CarOrderQueryAsync(CarOrderQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CarOrderQueryHeaders headers = new CarOrderQueryHeaders();
            return await CarOrderQueryWithOptionsAsync(request, headers, runtime);
        }

        public CarSceneQueryResponse CarSceneQueryWithOptions(CarSceneQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CarSceneQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/car/v1/scenes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CarSceneQueryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CarSceneQueryResponse> CarSceneQueryWithOptionsAsync(CarSceneQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CarSceneQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/car/v1/scenes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CarSceneQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CarSceneQueryResponse CarSceneQuery()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CarSceneQueryHeaders headers = new CarSceneQueryHeaders();
            return CarSceneQueryWithOptions(headers, runtime);
        }

        public async Task<CarSceneQueryResponse> CarSceneQueryAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CarSceneQueryHeaders headers = new CarSceneQueryHeaders();
            return await CarSceneQueryWithOptionsAsync(headers, runtime);
        }

        public CitySearchResponse CitySearchWithOptions(CitySearchRequest request, CitySearchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CitySearch",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/city/v1/city",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CitySearchResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CitySearchResponse> CitySearchWithOptionsAsync(CitySearchRequest request, CitySearchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CitySearch",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/city/v1/city",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CitySearchResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CitySearchResponse CitySearch(CitySearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CitySearchHeaders headers = new CitySearchHeaders();
            return CitySearchWithOptions(request, headers, runtime);
        }

        public async Task<CitySearchResponse> CitySearchAsync(CitySearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CitySearchHeaders headers = new CitySearchHeaders();
            return await CitySearchWithOptionsAsync(request, headers, runtime);
        }

        public CommonApplyQueryResponse CommonApplyQueryWithOptions(CommonApplyQueryRequest request, CommonApplyQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyId))
            {
                query["apply_id"] = request.ApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCategory))
            {
                query["biz_category"] = request.BizCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["user_id"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CommonApplyQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/apply/v1/common",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CommonApplyQueryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CommonApplyQueryResponse> CommonApplyQueryWithOptionsAsync(CommonApplyQueryRequest request, CommonApplyQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyId))
            {
                query["apply_id"] = request.ApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCategory))
            {
                query["biz_category"] = request.BizCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["user_id"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CommonApplyQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/apply/v1/common",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CommonApplyQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CommonApplyQueryResponse CommonApplyQuery(CommonApplyQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CommonApplyQueryHeaders headers = new CommonApplyQueryHeaders();
            return CommonApplyQueryWithOptions(request, headers, runtime);
        }

        public async Task<CommonApplyQueryResponse> CommonApplyQueryAsync(CommonApplyQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CommonApplyQueryHeaders headers = new CommonApplyQueryHeaders();
            return await CommonApplyQueryWithOptionsAsync(request, headers, runtime);
        }

        public CommonApplySyncResponse CommonApplySyncWithOptions(CommonApplySyncRequest request, CommonApplySyncHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyId))
            {
                query["apply_id"] = request.ApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCategory))
            {
                query["biz_category"] = request.BizCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartyFlowId))
            {
                query["thirdparty_flow_id"] = request.ThirdpartyFlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["user_id"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CommonApplySync",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/apply/v1/syn-common",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CommonApplySyncResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CommonApplySyncResponse> CommonApplySyncWithOptionsAsync(CommonApplySyncRequest request, CommonApplySyncHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyId))
            {
                query["apply_id"] = request.ApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCategory))
            {
                query["biz_category"] = request.BizCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartyFlowId))
            {
                query["thirdparty_flow_id"] = request.ThirdpartyFlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["user_id"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CommonApplySync",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/apply/v1/syn-common",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CommonApplySyncResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CommonApplySyncResponse CommonApplySync(CommonApplySyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CommonApplySyncHeaders headers = new CommonApplySyncHeaders();
            return CommonApplySyncWithOptions(request, headers, runtime);
        }

        public async Task<CommonApplySyncResponse> CommonApplySyncAsync(CommonApplySyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CommonApplySyncHeaders headers = new CommonApplySyncHeaders();
            return await CommonApplySyncWithOptionsAsync(request, headers, runtime);
        }

        public CooperatorFlightBillSettlementQueryResponse CooperatorFlightBillSettlementQueryWithOptions(CooperatorFlightBillSettlementQueryRequest request, CooperatorFlightBillSettlementQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CooperatorId))
            {
                query["cooperator_id"] = request.CooperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["page_no"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodEnd))
            {
                query["period_end"] = request.PeriodEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodStart))
            {
                query["period_start"] = request.PeriodStart;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CooperatorFlightBillSettlementQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/cooperator-flight/v1/bill-settlement",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CooperatorFlightBillSettlementQueryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CooperatorFlightBillSettlementQueryResponse> CooperatorFlightBillSettlementQueryWithOptionsAsync(CooperatorFlightBillSettlementQueryRequest request, CooperatorFlightBillSettlementQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CooperatorId))
            {
                query["cooperator_id"] = request.CooperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["page_no"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodEnd))
            {
                query["period_end"] = request.PeriodEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodStart))
            {
                query["period_start"] = request.PeriodStart;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CooperatorFlightBillSettlementQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/cooperator-flight/v1/bill-settlement",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CooperatorFlightBillSettlementQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CooperatorFlightBillSettlementQueryResponse CooperatorFlightBillSettlementQuery(CooperatorFlightBillSettlementQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CooperatorFlightBillSettlementQueryHeaders headers = new CooperatorFlightBillSettlementQueryHeaders();
            return CooperatorFlightBillSettlementQueryWithOptions(request, headers, runtime);
        }

        public async Task<CooperatorFlightBillSettlementQueryResponse> CooperatorFlightBillSettlementQueryAsync(CooperatorFlightBillSettlementQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CooperatorFlightBillSettlementQueryHeaders headers = new CooperatorFlightBillSettlementQueryHeaders();
            return await CooperatorFlightBillSettlementQueryWithOptionsAsync(request, headers, runtime);
        }

        public CooperatorHotelBillSettlementQueryResponse CooperatorHotelBillSettlementQueryWithOptions(CooperatorHotelBillSettlementQueryRequest request, CooperatorHotelBillSettlementQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CooperatorId))
            {
                query["cooperator_id"] = request.CooperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["page_no"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodEnd))
            {
                query["period_end"] = request.PeriodEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodStart))
            {
                query["period_start"] = request.PeriodStart;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CooperatorHotelBillSettlementQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/cooperator-hotel/v1/bill-settlement",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CooperatorHotelBillSettlementQueryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CooperatorHotelBillSettlementQueryResponse> CooperatorHotelBillSettlementQueryWithOptionsAsync(CooperatorHotelBillSettlementQueryRequest request, CooperatorHotelBillSettlementQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CooperatorId))
            {
                query["cooperator_id"] = request.CooperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["page_no"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodEnd))
            {
                query["period_end"] = request.PeriodEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodStart))
            {
                query["period_start"] = request.PeriodStart;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CooperatorHotelBillSettlementQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/cooperator-hotel/v1/bill-settlement",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CooperatorHotelBillSettlementQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CooperatorHotelBillSettlementQueryResponse CooperatorHotelBillSettlementQuery(CooperatorHotelBillSettlementQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CooperatorHotelBillSettlementQueryHeaders headers = new CooperatorHotelBillSettlementQueryHeaders();
            return CooperatorHotelBillSettlementQueryWithOptions(request, headers, runtime);
        }

        public async Task<CooperatorHotelBillSettlementQueryResponse> CooperatorHotelBillSettlementQueryAsync(CooperatorHotelBillSettlementQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CooperatorHotelBillSettlementQueryHeaders headers = new CooperatorHotelBillSettlementQueryHeaders();
            return await CooperatorHotelBillSettlementQueryWithOptionsAsync(request, headers, runtime);
        }

        public CorpAuthLinkInfoQueryResponse CorpAuthLinkInfoQueryWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CorpAuthLinkInfoQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/corp-authority-link/v1/info",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CorpAuthLinkInfoQueryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CorpAuthLinkInfoQueryResponse> CorpAuthLinkInfoQueryWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CorpAuthLinkInfoQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/corp-authority-link/v1/info",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CorpAuthLinkInfoQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CorpAuthLinkInfoQueryResponse CorpAuthLinkInfoQuery()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CorpAuthLinkInfoQueryWithOptions(headers, runtime);
        }

        public async Task<CorpAuthLinkInfoQueryResponse> CorpAuthLinkInfoQueryAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CorpAuthLinkInfoQueryWithOptionsAsync(headers, runtime);
        }

        public CorpTokenResponse CorpTokenWithOptions(CorpTokenRequest request, CorpTokenHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppSecret))
            {
                query["app_secret"] = request.AppSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corp_id"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripAccessToken))
            {
                realHeaders["x-acs-btrip-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CorpToken",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/btrip-open-auth/v1/corp-token/action/take",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CorpTokenResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CorpTokenResponse> CorpTokenWithOptionsAsync(CorpTokenRequest request, CorpTokenHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppSecret))
            {
                query["app_secret"] = request.AppSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corp_id"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripAccessToken))
            {
                realHeaders["x-acs-btrip-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CorpToken",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/btrip-open-auth/v1/corp-token/action/take",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CorpTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CorpTokenResponse CorpToken(CorpTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CorpTokenHeaders headers = new CorpTokenHeaders();
            return CorpTokenWithOptions(request, headers, runtime);
        }

        public async Task<CorpTokenResponse> CorpTokenAsync(CorpTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CorpTokenHeaders headers = new CorpTokenHeaders();
            return await CorpTokenWithOptionsAsync(request, headers, runtime);
        }

        public CostCenterDeleteResponse CostCenterDeleteWithOptions(CostCenterDeleteRequest request, CostCenterDeleteHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartId))
            {
                query["thirdpart_id"] = request.ThirdpartId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CostCenterDelete",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/costcenter/v1/delete-costcenter",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CostCenterDeleteResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CostCenterDeleteResponse> CostCenterDeleteWithOptionsAsync(CostCenterDeleteRequest request, CostCenterDeleteHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartId))
            {
                query["thirdpart_id"] = request.ThirdpartId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CostCenterDelete",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/costcenter/v1/delete-costcenter",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CostCenterDeleteResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CostCenterDeleteResponse CostCenterDelete(CostCenterDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CostCenterDeleteHeaders headers = new CostCenterDeleteHeaders();
            return CostCenterDeleteWithOptions(request, headers, runtime);
        }

        public async Task<CostCenterDeleteResponse> CostCenterDeleteAsync(CostCenterDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CostCenterDeleteHeaders headers = new CostCenterDeleteHeaders();
            return await CostCenterDeleteWithOptionsAsync(request, headers, runtime);
        }

        public CostCenterModifyResponse CostCenterModifyWithOptions(CostCenterModifyRequest request, CostCenterModifyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlipayNo))
            {
                body["alipay_no"] = request.AlipayNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Disable))
            {
                body["disable"] = request.Disable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Number))
            {
                body["number"] = request.Number;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartId))
            {
                body["thirdpart_id"] = request.ThirdpartId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CostCenterModify",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/costcenter/v1/modify-costcenter",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CostCenterModifyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CostCenterModifyResponse> CostCenterModifyWithOptionsAsync(CostCenterModifyRequest request, CostCenterModifyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlipayNo))
            {
                body["alipay_no"] = request.AlipayNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Disable))
            {
                body["disable"] = request.Disable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Number))
            {
                body["number"] = request.Number;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartId))
            {
                body["thirdpart_id"] = request.ThirdpartId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CostCenterModify",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/costcenter/v1/modify-costcenter",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CostCenterModifyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CostCenterModifyResponse CostCenterModify(CostCenterModifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CostCenterModifyHeaders headers = new CostCenterModifyHeaders();
            return CostCenterModifyWithOptions(request, headers, runtime);
        }

        public async Task<CostCenterModifyResponse> CostCenterModifyAsync(CostCenterModifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CostCenterModifyHeaders headers = new CostCenterModifyHeaders();
            return await CostCenterModifyWithOptionsAsync(request, headers, runtime);
        }

        public CostCenterQueryResponse CostCenterQueryWithOptions(CostCenterQueryRequest request, CostCenterQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Disable))
            {
                query["disable"] = request.Disable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedOrgEntity))
            {
                query["need_org_entity"] = request.NeedOrgEntity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartId))
            {
                query["thirdpart_id"] = request.ThirdpartId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["user_id"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CostCenterQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/costcenter/v1/costcenter",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CostCenterQueryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CostCenterQueryResponse> CostCenterQueryWithOptionsAsync(CostCenterQueryRequest request, CostCenterQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Disable))
            {
                query["disable"] = request.Disable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedOrgEntity))
            {
                query["need_org_entity"] = request.NeedOrgEntity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartId))
            {
                query["thirdpart_id"] = request.ThirdpartId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["user_id"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CostCenterQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/costcenter/v1/costcenter",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CostCenterQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CostCenterQueryResponse CostCenterQuery(CostCenterQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CostCenterQueryHeaders headers = new CostCenterQueryHeaders();
            return CostCenterQueryWithOptions(request, headers, runtime);
        }

        public async Task<CostCenterQueryResponse> CostCenterQueryAsync(CostCenterQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CostCenterQueryHeaders headers = new CostCenterQueryHeaders();
            return await CostCenterQueryWithOptionsAsync(request, headers, runtime);
        }

        public CostCenterSaveResponse CostCenterSaveWithOptions(CostCenterSaveRequest request, CostCenterSaveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlipayNo))
            {
                body["alipay_no"] = request.AlipayNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Disable))
            {
                body["disable"] = request.Disable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Number))
            {
                body["number"] = request.Number;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartId))
            {
                body["thirdpart_id"] = request.ThirdpartId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CostCenterSave",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/costcenter/v1/save-costcenter",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CostCenterSaveResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CostCenterSaveResponse> CostCenterSaveWithOptionsAsync(CostCenterSaveRequest request, CostCenterSaveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlipayNo))
            {
                body["alipay_no"] = request.AlipayNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Disable))
            {
                body["disable"] = request.Disable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Number))
            {
                body["number"] = request.Number;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartId))
            {
                body["thirdpart_id"] = request.ThirdpartId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CostCenterSave",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/costcenter/v1/save-costcenter",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CostCenterSaveResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CostCenterSaveResponse CostCenterSave(CostCenterSaveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CostCenterSaveHeaders headers = new CostCenterSaveHeaders();
            return CostCenterSaveWithOptions(request, headers, runtime);
        }

        public async Task<CostCenterSaveResponse> CostCenterSaveAsync(CostCenterSaveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CostCenterSaveHeaders headers = new CostCenterSaveHeaders();
            return await CostCenterSaveWithOptionsAsync(request, headers, runtime);
        }

        public CreateSubCorpResponse CreateSubCorpWithOptions(CreateSubCorpRequest request, CreateSubCorpHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterCorpId))
            {
                body["outer_corp_id"] = request.OuterCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterCorpName))
            {
                body["outer_corp_name"] = request.OuterCorpName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSubCorp",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/sub_corps/v1/corps",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSubCorpResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateSubCorpResponse> CreateSubCorpWithOptionsAsync(CreateSubCorpRequest request, CreateSubCorpHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterCorpId))
            {
                body["outer_corp_id"] = request.OuterCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterCorpName))
            {
                body["outer_corp_name"] = request.OuterCorpName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSubCorp",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/sub_corps/v1/corps",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSubCorpResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateSubCorpResponse CreateSubCorp(CreateSubCorpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSubCorpHeaders headers = new CreateSubCorpHeaders();
            return CreateSubCorpWithOptions(request, headers, runtime);
        }

        public async Task<CreateSubCorpResponse> CreateSubCorpAsync(CreateSubCorpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSubCorpHeaders headers = new CreateSubCorpHeaders();
            return await CreateSubCorpWithOptionsAsync(request, headers, runtime);
        }

        public DeleteInvoiceEntityResponse DeleteInvoiceEntityWithOptions(DeleteInvoiceEntityRequest tmpReq, DeleteInvoiceEntityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteInvoiceEntityShrinkRequest request = new DeleteInvoiceEntityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Entities))
            {
                request.EntitiesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Entities, "entities", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelAll))
            {
                query["del_all"] = request.DelAll;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntitiesShrink))
            {
                query["entities"] = request.EntitiesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartId))
            {
                query["third_part_id"] = request.ThirdPartId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInvoiceEntity",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/invoice/v1/entities",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInvoiceEntityResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteInvoiceEntityResponse> DeleteInvoiceEntityWithOptionsAsync(DeleteInvoiceEntityRequest tmpReq, DeleteInvoiceEntityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteInvoiceEntityShrinkRequest request = new DeleteInvoiceEntityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Entities))
            {
                request.EntitiesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Entities, "entities", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelAll))
            {
                query["del_all"] = request.DelAll;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntitiesShrink))
            {
                query["entities"] = request.EntitiesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartId))
            {
                query["third_part_id"] = request.ThirdPartId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInvoiceEntity",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/invoice/v1/entities",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInvoiceEntityResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteInvoiceEntityResponse DeleteInvoiceEntity(DeleteInvoiceEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteInvoiceEntityHeaders headers = new DeleteInvoiceEntityHeaders();
            return DeleteInvoiceEntityWithOptions(request, headers, runtime);
        }

        public async Task<DeleteInvoiceEntityResponse> DeleteInvoiceEntityAsync(DeleteInvoiceEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteInvoiceEntityHeaders headers = new DeleteInvoiceEntityHeaders();
            return await DeleteInvoiceEntityWithOptionsAsync(request, headers, runtime);
        }

        public DepartmentSaveResponse DepartmentSaveWithOptions(DepartmentSaveRequest tmpReq, DepartmentSaveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DepartmentSaveShrinkRequest request = new DepartmentSaveShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepartList))
            {
                request.DepartListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepartList, "depart_list", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartListShrink))
            {
                body["depart_list"] = request.DepartListShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DepartmentSave",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/department/v1/department",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DepartmentSaveResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DepartmentSaveResponse> DepartmentSaveWithOptionsAsync(DepartmentSaveRequest tmpReq, DepartmentSaveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DepartmentSaveShrinkRequest request = new DepartmentSaveShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepartList))
            {
                request.DepartListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepartList, "depart_list", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartListShrink))
            {
                body["depart_list"] = request.DepartListShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DepartmentSave",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/department/v1/department",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DepartmentSaveResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DepartmentSaveResponse DepartmentSave(DepartmentSaveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DepartmentSaveHeaders headers = new DepartmentSaveHeaders();
            return DepartmentSaveWithOptions(request, headers, runtime);
        }

        public async Task<DepartmentSaveResponse> DepartmentSaveAsync(DepartmentSaveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DepartmentSaveHeaders headers = new DepartmentSaveHeaders();
            return await DepartmentSaveWithOptionsAsync(request, headers, runtime);
        }

        public EntityAddResponse EntityAddWithOptions(EntityAddRequest tmpReq, EntityAddHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            EntityAddShrinkRequest request = new EntityAddShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EntityDOList))
            {
                request.EntityDOListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EntityDOList, "entity_d_o_list", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityDOListShrink))
            {
                body["entity_d_o_list"] = request.EntityDOListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartId))
            {
                body["thirdpart_id"] = request.ThirdpartId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EntityAdd",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/costcenter/v1/add-entity",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EntityAddResponse>(CallApi(params_, req, runtime));
        }

        public async Task<EntityAddResponse> EntityAddWithOptionsAsync(EntityAddRequest tmpReq, EntityAddHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            EntityAddShrinkRequest request = new EntityAddShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EntityDOList))
            {
                request.EntityDOListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EntityDOList, "entity_d_o_list", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityDOListShrink))
            {
                body["entity_d_o_list"] = request.EntityDOListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartId))
            {
                body["thirdpart_id"] = request.ThirdpartId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EntityAdd",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/costcenter/v1/add-entity",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EntityAddResponse>(await CallApiAsync(params_, req, runtime));
        }

        public EntityAddResponse EntityAdd(EntityAddRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EntityAddHeaders headers = new EntityAddHeaders();
            return EntityAddWithOptions(request, headers, runtime);
        }

        public async Task<EntityAddResponse> EntityAddAsync(EntityAddRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EntityAddHeaders headers = new EntityAddHeaders();
            return await EntityAddWithOptionsAsync(request, headers, runtime);
        }

        public EntityDeleteResponse EntityDeleteWithOptions(EntityDeleteRequest tmpReq, EntityDeleteHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            EntityDeleteShrinkRequest request = new EntityDeleteShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EntityDOList))
            {
                request.EntityDOListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EntityDOList, "entity_d_o_list", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelAll))
            {
                query["del_all"] = request.DelAll;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartId))
            {
                query["thirdpart_id"] = request.ThirdpartId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityDOListShrink))
            {
                body["entity_d_o_list"] = request.EntityDOListShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EntityDelete",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/costcenter/v1/entity/action/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EntityDeleteResponse>(CallApi(params_, req, runtime));
        }

        public async Task<EntityDeleteResponse> EntityDeleteWithOptionsAsync(EntityDeleteRequest tmpReq, EntityDeleteHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            EntityDeleteShrinkRequest request = new EntityDeleteShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EntityDOList))
            {
                request.EntityDOListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EntityDOList, "entity_d_o_list", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelAll))
            {
                query["del_all"] = request.DelAll;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartId))
            {
                query["thirdpart_id"] = request.ThirdpartId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityDOListShrink))
            {
                body["entity_d_o_list"] = request.EntityDOListShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EntityDelete",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/costcenter/v1/entity/action/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EntityDeleteResponse>(await CallApiAsync(params_, req, runtime));
        }

        public EntityDeleteResponse EntityDelete(EntityDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EntityDeleteHeaders headers = new EntityDeleteHeaders();
            return EntityDeleteWithOptions(request, headers, runtime);
        }

        public async Task<EntityDeleteResponse> EntityDeleteAsync(EntityDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EntityDeleteHeaders headers = new EntityDeleteHeaders();
            return await EntityDeleteWithOptionsAsync(request, headers, runtime);
        }

        public EntitySetResponse EntitySetWithOptions(EntitySetRequest tmpReq, EntitySetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            EntitySetShrinkRequest request = new EntitySetShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EntityDOList))
            {
                request.EntityDOListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EntityDOList, "entity_d_o_list", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityDOListShrink))
            {
                body["entity_d_o_list"] = request.EntityDOListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartId))
            {
                body["thirdpart_id"] = request.ThirdpartId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EntitySet",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/costcenter/v1/set-entity",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EntitySetResponse>(CallApi(params_, req, runtime));
        }

        public async Task<EntitySetResponse> EntitySetWithOptionsAsync(EntitySetRequest tmpReq, EntitySetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            EntitySetShrinkRequest request = new EntitySetShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EntityDOList))
            {
                request.EntityDOListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EntityDOList, "entity_d_o_list", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityDOListShrink))
            {
                body["entity_d_o_list"] = request.EntityDOListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartId))
            {
                body["thirdpart_id"] = request.ThirdpartId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EntitySet",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/costcenter/v1/set-entity",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EntitySetResponse>(await CallApiAsync(params_, req, runtime));
        }

        public EntitySetResponse EntitySet(EntitySetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EntitySetHeaders headers = new EntitySetHeaders();
            return EntitySetWithOptions(request, headers, runtime);
        }

        public async Task<EntitySetResponse> EntitySetAsync(EntitySetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EntitySetHeaders headers = new EntitySetHeaders();
            return await EntitySetWithOptionsAsync(request, headers, runtime);
        }

        public EstimatedPriceQueryResponse EstimatedPriceQueryWithOptions(EstimatedPriceQueryRequest request, EstimatedPriceQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArrCity))
            {
                query["arr_city"] = request.ArrCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepCity))
            {
                query["dep_city"] = request.DepCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["end_time"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItineraryId))
            {
                query["itinerary_id"] = request.ItineraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["start_time"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                query["sub_corp_id"] = request.SubCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["user_id"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EstimatedPriceQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/costcenter/v1/estimated-price",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EstimatedPriceQueryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<EstimatedPriceQueryResponse> EstimatedPriceQueryWithOptionsAsync(EstimatedPriceQueryRequest request, EstimatedPriceQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArrCity))
            {
                query["arr_city"] = request.ArrCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepCity))
            {
                query["dep_city"] = request.DepCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["end_time"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItineraryId))
            {
                query["itinerary_id"] = request.ItineraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["start_time"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                query["sub_corp_id"] = request.SubCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["user_id"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EstimatedPriceQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/costcenter/v1/estimated-price",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EstimatedPriceQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public EstimatedPriceQueryResponse EstimatedPriceQuery(EstimatedPriceQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EstimatedPriceQueryHeaders headers = new EstimatedPriceQueryHeaders();
            return EstimatedPriceQueryWithOptions(request, headers, runtime);
        }

        public async Task<EstimatedPriceQueryResponse> EstimatedPriceQueryAsync(EstimatedPriceQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EstimatedPriceQueryHeaders headers = new EstimatedPriceQueryHeaders();
            return await EstimatedPriceQueryWithOptionsAsync(request, headers, runtime);
        }

        public ExceedApplySyncResponse ExceedApplySyncWithOptions(ExceedApplySyncRequest request, ExceedApplySyncHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyId))
            {
                query["apply_id"] = request.ApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCategory))
            {
                query["biz_category"] = request.BizCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartyFlowId))
            {
                query["thirdparty_flow_id"] = request.ThirdpartyFlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["user_id"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExceedApplySync",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/apply/v1/syn-exceed",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExceedApplySyncResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ExceedApplySyncResponse> ExceedApplySyncWithOptionsAsync(ExceedApplySyncRequest request, ExceedApplySyncHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyId))
            {
                query["apply_id"] = request.ApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCategory))
            {
                query["biz_category"] = request.BizCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartyFlowId))
            {
                query["thirdparty_flow_id"] = request.ThirdpartyFlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["user_id"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExceedApplySync",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/apply/v1/syn-exceed",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExceedApplySyncResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ExceedApplySyncResponse ExceedApplySync(ExceedApplySyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExceedApplySyncHeaders headers = new ExceedApplySyncHeaders();
            return ExceedApplySyncWithOptions(request, headers, runtime);
        }

        public async Task<ExceedApplySyncResponse> ExceedApplySyncAsync(ExceedApplySyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExceedApplySyncHeaders headers = new ExceedApplySyncHeaders();
            return await ExceedApplySyncWithOptionsAsync(request, headers, runtime);
        }

        public FlightBillSettlementQueryResponse FlightBillSettlementQueryWithOptions(FlightBillSettlementQueryRequest request, FlightBillSettlementQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["page_no"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodEnd))
            {
                query["period_end"] = request.PeriodEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodStart))
            {
                query["period_start"] = request.PeriodStart;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightBillSettlementQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/flight/v1/bill-settlement",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightBillSettlementQueryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<FlightBillSettlementQueryResponse> FlightBillSettlementQueryWithOptionsAsync(FlightBillSettlementQueryRequest request, FlightBillSettlementQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["page_no"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodEnd))
            {
                query["period_end"] = request.PeriodEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodStart))
            {
                query["period_start"] = request.PeriodStart;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightBillSettlementQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/flight/v1/bill-settlement",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightBillSettlementQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public FlightBillSettlementQueryResponse FlightBillSettlementQuery(FlightBillSettlementQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightBillSettlementQueryHeaders headers = new FlightBillSettlementQueryHeaders();
            return FlightBillSettlementQueryWithOptions(request, headers, runtime);
        }

        public async Task<FlightBillSettlementQueryResponse> FlightBillSettlementQueryAsync(FlightBillSettlementQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightBillSettlementQueryHeaders headers = new FlightBillSettlementQueryHeaders();
            return await FlightBillSettlementQueryWithOptionsAsync(request, headers, runtime);
        }

        public FlightCancelOrderResponse FlightCancelOrderWithOptions(FlightCancelOrderRequest request, FlightCancelOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisOrderId))
            {
                query["dis_order_id"] = request.DisOrderId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightCancelOrder",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v1/order/action/cancel",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightCancelOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<FlightCancelOrderResponse> FlightCancelOrderWithOptionsAsync(FlightCancelOrderRequest request, FlightCancelOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisOrderId))
            {
                query["dis_order_id"] = request.DisOrderId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightCancelOrder",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v1/order/action/cancel",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightCancelOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public FlightCancelOrderResponse FlightCancelOrder(FlightCancelOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightCancelOrderHeaders headers = new FlightCancelOrderHeaders();
            return FlightCancelOrderWithOptions(request, headers, runtime);
        }

        public async Task<FlightCancelOrderResponse> FlightCancelOrderAsync(FlightCancelOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightCancelOrderHeaders headers = new FlightCancelOrderHeaders();
            return await FlightCancelOrderWithOptionsAsync(request, headers, runtime);
        }

        public FlightCancelOrderV2Response FlightCancelOrderV2WithOptions(FlightCancelOrderV2Request request, FlightCancelOrderV2Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                query["isv_name"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["order_id"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutOrderId))
            {
                query["out_order_id"] = request.OutOrderId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightCancelOrderV2",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v2/order/action/cancel",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightCancelOrderV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<FlightCancelOrderV2Response> FlightCancelOrderV2WithOptionsAsync(FlightCancelOrderV2Request request, FlightCancelOrderV2Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                query["isv_name"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["order_id"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutOrderId))
            {
                query["out_order_id"] = request.OutOrderId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightCancelOrderV2",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v2/order/action/cancel",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightCancelOrderV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public FlightCancelOrderV2Response FlightCancelOrderV2(FlightCancelOrderV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightCancelOrderV2Headers headers = new FlightCancelOrderV2Headers();
            return FlightCancelOrderV2WithOptions(request, headers, runtime);
        }

        public async Task<FlightCancelOrderV2Response> FlightCancelOrderV2Async(FlightCancelOrderV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightCancelOrderV2Headers headers = new FlightCancelOrderV2Headers();
            return await FlightCancelOrderV2WithOptionsAsync(request, headers, runtime);
        }

        public FlightCreateOrderResponse FlightCreateOrderWithOptions(FlightCreateOrderRequest tmpReq, FlightCreateOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            FlightCreateOrderShrinkRequest request = new FlightCreateOrderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ContactInfo))
            {
                request.ContactInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ContactInfo, "contact_info", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OrderAttr))
            {
                request.OrderAttrShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OrderAttr, "order_attr", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TravelerInfoList))
            {
                request.TravelerInfoListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TravelerInfoList, "traveler_info_list", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArrAirportCode))
            {
                body["arr_airport_code"] = request.ArrAirportCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArrCityCode))
            {
                body["arr_city_code"] = request.ArrCityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                body["auto_pay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyerName))
            {
                body["buyer_name"] = request.BuyerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyerUniqueKey))
            {
                body["buyer_unique_key"] = request.BuyerUniqueKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactInfoShrink))
            {
                body["contact_info"] = request.ContactInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepAirportCode))
            {
                body["dep_airport_code"] = request.DepAirportCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepCityCode))
            {
                body["dep_city_code"] = request.DepCityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepDate))
            {
                body["dep_date"] = request.DepDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisOrderId))
            {
                body["dis_order_id"] = request.DisOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderAttrShrink))
            {
                body["order_attr"] = request.OrderAttrShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderParams))
            {
                body["order_params"] = request.OrderParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtaItemId))
            {
                body["ota_item_id"] = request.OtaItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Price))
            {
                body["price"] = request.Price;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiptAddress))
            {
                body["receipt_address"] = request.ReceiptAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiptTarget))
            {
                body["receipt_target"] = request.ReceiptTarget;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiptTitle))
            {
                body["receipt_title"] = request.ReceiptTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TravelerInfoListShrink))
            {
                body["traveler_info_list"] = request.TravelerInfoListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TripType))
            {
                body["trip_type"] = request.TripType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightCreateOrder",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v1/order/action/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightCreateOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<FlightCreateOrderResponse> FlightCreateOrderWithOptionsAsync(FlightCreateOrderRequest tmpReq, FlightCreateOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            FlightCreateOrderShrinkRequest request = new FlightCreateOrderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ContactInfo))
            {
                request.ContactInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ContactInfo, "contact_info", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OrderAttr))
            {
                request.OrderAttrShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OrderAttr, "order_attr", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TravelerInfoList))
            {
                request.TravelerInfoListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TravelerInfoList, "traveler_info_list", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArrAirportCode))
            {
                body["arr_airport_code"] = request.ArrAirportCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArrCityCode))
            {
                body["arr_city_code"] = request.ArrCityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                body["auto_pay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyerName))
            {
                body["buyer_name"] = request.BuyerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyerUniqueKey))
            {
                body["buyer_unique_key"] = request.BuyerUniqueKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactInfoShrink))
            {
                body["contact_info"] = request.ContactInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepAirportCode))
            {
                body["dep_airport_code"] = request.DepAirportCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepCityCode))
            {
                body["dep_city_code"] = request.DepCityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepDate))
            {
                body["dep_date"] = request.DepDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisOrderId))
            {
                body["dis_order_id"] = request.DisOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderAttrShrink))
            {
                body["order_attr"] = request.OrderAttrShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderParams))
            {
                body["order_params"] = request.OrderParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtaItemId))
            {
                body["ota_item_id"] = request.OtaItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Price))
            {
                body["price"] = request.Price;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiptAddress))
            {
                body["receipt_address"] = request.ReceiptAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiptTarget))
            {
                body["receipt_target"] = request.ReceiptTarget;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiptTitle))
            {
                body["receipt_title"] = request.ReceiptTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TravelerInfoListShrink))
            {
                body["traveler_info_list"] = request.TravelerInfoListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TripType))
            {
                body["trip_type"] = request.TripType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightCreateOrder",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v1/order/action/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightCreateOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public FlightCreateOrderResponse FlightCreateOrder(FlightCreateOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightCreateOrderHeaders headers = new FlightCreateOrderHeaders();
            return FlightCreateOrderWithOptions(request, headers, runtime);
        }

        public async Task<FlightCreateOrderResponse> FlightCreateOrderAsync(FlightCreateOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightCreateOrderHeaders headers = new FlightCreateOrderHeaders();
            return await FlightCreateOrderWithOptionsAsync(request, headers, runtime);
        }

        public FlightCreateOrderV2Response FlightCreateOrderV2WithOptions(FlightCreateOrderV2Request tmpReq, FlightCreateOrderV2Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            FlightCreateOrderV2ShrinkRequest request = new FlightCreateOrderV2ShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ContactInfo))
            {
                request.ContactInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ContactInfo, "contact_info", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Travelers))
            {
                request.TravelersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Travelers, "travelers", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsyncCreateOrderKey))
            {
                body["async_create_order_key"] = request.AsyncCreateOrderKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsyncCreateOrderMode))
            {
                body["async_create_order_mode"] = request.AsyncCreateOrderMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BtripUserId))
            {
                body["btrip_user_id"] = request.BtripUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyerName))
            {
                body["buyer_name"] = request.BuyerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactInfoShrink))
            {
                body["contact_info"] = request.ContactInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                body["isv_name"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtaItemId))
            {
                body["ota_item_id"] = request.OtaItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutOrderId))
            {
                body["out_order_id"] = request.OutOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalPriceCent))
            {
                body["total_price_cent"] = request.TotalPriceCent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TravelersShrink))
            {
                body["travelers"] = request.TravelersShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightCreateOrderV2",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v2/order/action/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightCreateOrderV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<FlightCreateOrderV2Response> FlightCreateOrderV2WithOptionsAsync(FlightCreateOrderV2Request tmpReq, FlightCreateOrderV2Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            FlightCreateOrderV2ShrinkRequest request = new FlightCreateOrderV2ShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ContactInfo))
            {
                request.ContactInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ContactInfo, "contact_info", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Travelers))
            {
                request.TravelersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Travelers, "travelers", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsyncCreateOrderKey))
            {
                body["async_create_order_key"] = request.AsyncCreateOrderKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsyncCreateOrderMode))
            {
                body["async_create_order_mode"] = request.AsyncCreateOrderMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BtripUserId))
            {
                body["btrip_user_id"] = request.BtripUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyerName))
            {
                body["buyer_name"] = request.BuyerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactInfoShrink))
            {
                body["contact_info"] = request.ContactInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                body["isv_name"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtaItemId))
            {
                body["ota_item_id"] = request.OtaItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutOrderId))
            {
                body["out_order_id"] = request.OutOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalPriceCent))
            {
                body["total_price_cent"] = request.TotalPriceCent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TravelersShrink))
            {
                body["travelers"] = request.TravelersShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightCreateOrderV2",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v2/order/action/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightCreateOrderV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public FlightCreateOrderV2Response FlightCreateOrderV2(FlightCreateOrderV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightCreateOrderV2Headers headers = new FlightCreateOrderV2Headers();
            return FlightCreateOrderV2WithOptions(request, headers, runtime);
        }

        public async Task<FlightCreateOrderV2Response> FlightCreateOrderV2Async(FlightCreateOrderV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightCreateOrderV2Headers headers = new FlightCreateOrderV2Headers();
            return await FlightCreateOrderV2WithOptionsAsync(request, headers, runtime);
        }

        public FlightExceedApplyQueryResponse FlightExceedApplyQueryWithOptions(FlightExceedApplyQueryRequest request, FlightExceedApplyQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyId))
            {
                query["apply_id"] = request.ApplyId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightExceedApplyQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/apply/v1/flight-exceed",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightExceedApplyQueryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<FlightExceedApplyQueryResponse> FlightExceedApplyQueryWithOptionsAsync(FlightExceedApplyQueryRequest request, FlightExceedApplyQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyId))
            {
                query["apply_id"] = request.ApplyId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightExceedApplyQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/apply/v1/flight-exceed",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightExceedApplyQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public FlightExceedApplyQueryResponse FlightExceedApplyQuery(FlightExceedApplyQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightExceedApplyQueryHeaders headers = new FlightExceedApplyQueryHeaders();
            return FlightExceedApplyQueryWithOptions(request, headers, runtime);
        }

        public async Task<FlightExceedApplyQueryResponse> FlightExceedApplyQueryAsync(FlightExceedApplyQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightExceedApplyQueryHeaders headers = new FlightExceedApplyQueryHeaders();
            return await FlightExceedApplyQueryWithOptionsAsync(request, headers, runtime);
        }

        public FlightItineraryScanQueryResponse FlightItineraryScanQueryWithOptions(FlightItineraryScanQueryRequest request, FlightItineraryScanQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillDate))
            {
                query["bill_date"] = request.BillDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillId))
            {
                query["bill_id"] = request.BillId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceSubTaskId))
            {
                query["invoice_sub_task_id"] = request.InvoiceSubTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItineraryNum))
            {
                query["itinerary_num"] = request.ItineraryNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["page_no"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketNo))
            {
                query["ticket_no"] = request.TicketNo;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightItineraryScanQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/scan/v1/flight-itinerary",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightItineraryScanQueryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<FlightItineraryScanQueryResponse> FlightItineraryScanQueryWithOptionsAsync(FlightItineraryScanQueryRequest request, FlightItineraryScanQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillDate))
            {
                query["bill_date"] = request.BillDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillId))
            {
                query["bill_id"] = request.BillId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceSubTaskId))
            {
                query["invoice_sub_task_id"] = request.InvoiceSubTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItineraryNum))
            {
                query["itinerary_num"] = request.ItineraryNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["page_no"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketNo))
            {
                query["ticket_no"] = request.TicketNo;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightItineraryScanQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/scan/v1/flight-itinerary",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightItineraryScanQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public FlightItineraryScanQueryResponse FlightItineraryScanQuery(FlightItineraryScanQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightItineraryScanQueryHeaders headers = new FlightItineraryScanQueryHeaders();
            return FlightItineraryScanQueryWithOptions(request, headers, runtime);
        }

        public async Task<FlightItineraryScanQueryResponse> FlightItineraryScanQueryAsync(FlightItineraryScanQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightItineraryScanQueryHeaders headers = new FlightItineraryScanQueryHeaders();
            return await FlightItineraryScanQueryWithOptionsAsync(request, headers, runtime);
        }

        public FlightListingSearchResponse FlightListingSearchWithOptions(FlightListingSearchRequest request, FlightListingSearchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AirlineCode))
            {
                query["airline_code"] = request.AirlineCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArrCityCode))
            {
                query["arr_city_code"] = request.ArrCityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CabinClass))
            {
                query["cabin_class"] = request.CabinClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepCityCode))
            {
                query["dep_city_code"] = request.DepCityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepDate))
            {
                query["dep_date"] = request.DepDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightListingSearch",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v1/flight/action/listing-search",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightListingSearchResponse>(CallApi(params_, req, runtime));
        }

        public async Task<FlightListingSearchResponse> FlightListingSearchWithOptionsAsync(FlightListingSearchRequest request, FlightListingSearchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AirlineCode))
            {
                query["airline_code"] = request.AirlineCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArrCityCode))
            {
                query["arr_city_code"] = request.ArrCityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CabinClass))
            {
                query["cabin_class"] = request.CabinClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepCityCode))
            {
                query["dep_city_code"] = request.DepCityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepDate))
            {
                query["dep_date"] = request.DepDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightListingSearch",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v1/flight/action/listing-search",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightListingSearchResponse>(await CallApiAsync(params_, req, runtime));
        }

        public FlightListingSearchResponse FlightListingSearch(FlightListingSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightListingSearchHeaders headers = new FlightListingSearchHeaders();
            return FlightListingSearchWithOptions(request, headers, runtime);
        }

        public async Task<FlightListingSearchResponse> FlightListingSearchAsync(FlightListingSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightListingSearchHeaders headers = new FlightListingSearchHeaders();
            return await FlightListingSearchWithOptionsAsync(request, headers, runtime);
        }

        public FlightListingSearchV2Response FlightListingSearchV2WithOptions(FlightListingSearchV2Request tmpReq, FlightListingSearchV2Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            FlightListingSearchV2ShrinkRequest request = new FlightListingSearchV2ShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CabinTypeList))
            {
                request.CabinTypeListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CabinTypeList, "cabin_type_list", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SearchJourneys))
            {
                request.SearchJourneysShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SearchJourneys, "search_journeys", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AirlineCode))
            {
                query["airline_code"] = request.AirlineCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CabinTypeListShrink))
            {
                query["cabin_type_list"] = request.CabinTypeListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectOnly))
            {
                query["direct_only"] = request.DirectOnly;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                query["isv_name"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedMultiClassPrice))
            {
                query["need_multi_class_price"] = request.NeedMultiClassPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedQueryServiceFee))
            {
                query["need_query_service_fee"] = request.NeedQueryServiceFee;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedShareFlight))
            {
                query["need_share_flight"] = request.NeedShareFlight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedYCBestPrice))
            {
                query["need_y_c_best_price"] = request.NeedYCBestPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchJourneysShrink))
            {
                query["search_journeys"] = request.SearchJourneysShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchMode))
            {
                query["search_mode"] = request.SearchMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TripType))
            {
                query["trip_type"] = request.TripType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightListingSearchV2",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v2/flight/action/listing-search",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightListingSearchV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<FlightListingSearchV2Response> FlightListingSearchV2WithOptionsAsync(FlightListingSearchV2Request tmpReq, FlightListingSearchV2Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            FlightListingSearchV2ShrinkRequest request = new FlightListingSearchV2ShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CabinTypeList))
            {
                request.CabinTypeListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CabinTypeList, "cabin_type_list", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SearchJourneys))
            {
                request.SearchJourneysShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SearchJourneys, "search_journeys", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AirlineCode))
            {
                query["airline_code"] = request.AirlineCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CabinTypeListShrink))
            {
                query["cabin_type_list"] = request.CabinTypeListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectOnly))
            {
                query["direct_only"] = request.DirectOnly;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                query["isv_name"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedMultiClassPrice))
            {
                query["need_multi_class_price"] = request.NeedMultiClassPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedQueryServiceFee))
            {
                query["need_query_service_fee"] = request.NeedQueryServiceFee;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedShareFlight))
            {
                query["need_share_flight"] = request.NeedShareFlight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedYCBestPrice))
            {
                query["need_y_c_best_price"] = request.NeedYCBestPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchJourneysShrink))
            {
                query["search_journeys"] = request.SearchJourneysShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchMode))
            {
                query["search_mode"] = request.SearchMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TripType))
            {
                query["trip_type"] = request.TripType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightListingSearchV2",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v2/flight/action/listing-search",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightListingSearchV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public FlightListingSearchV2Response FlightListingSearchV2(FlightListingSearchV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightListingSearchV2Headers headers = new FlightListingSearchV2Headers();
            return FlightListingSearchV2WithOptions(request, headers, runtime);
        }

        public async Task<FlightListingSearchV2Response> FlightListingSearchV2Async(FlightListingSearchV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightListingSearchV2Headers headers = new FlightListingSearchV2Headers();
            return await FlightListingSearchV2WithOptionsAsync(request, headers, runtime);
        }

        public FlightModifyApplyV2Response FlightModifyApplyV2WithOptions(FlightModifyApplyV2Request tmpReq, FlightModifyApplyV2Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            FlightModifyApplyV2ShrinkRequest request = new FlightModifyApplyV2ShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PassengerSegmentRelations))
            {
                request.PassengerSegmentRelationsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PassengerSegmentRelations, "passenger_segment_relations", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CacheKey))
            {
                body["cache_key"] = request.CacheKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactPhone))
            {
                body["contact_phone"] = request.ContactPhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                body["isv_name"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                body["item_id"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                body["order_id"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutOrderId))
            {
                body["out_order_id"] = request.OutOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutSubOrderId))
            {
                body["out_sub_order_id"] = request.OutSubOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PassengerSegmentRelationsShrink))
            {
                body["passenger_segment_relations"] = request.PassengerSegmentRelationsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reason))
            {
                body["reason"] = request.Reason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["session_id"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Voluntary))
            {
                body["voluntary"] = request.Voluntary;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightModifyApplyV2",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v2/modify/action/apply",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightModifyApplyV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<FlightModifyApplyV2Response> FlightModifyApplyV2WithOptionsAsync(FlightModifyApplyV2Request tmpReq, FlightModifyApplyV2Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            FlightModifyApplyV2ShrinkRequest request = new FlightModifyApplyV2ShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PassengerSegmentRelations))
            {
                request.PassengerSegmentRelationsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PassengerSegmentRelations, "passenger_segment_relations", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CacheKey))
            {
                body["cache_key"] = request.CacheKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactPhone))
            {
                body["contact_phone"] = request.ContactPhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                body["isv_name"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                body["item_id"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                body["order_id"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutOrderId))
            {
                body["out_order_id"] = request.OutOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutSubOrderId))
            {
                body["out_sub_order_id"] = request.OutSubOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PassengerSegmentRelationsShrink))
            {
                body["passenger_segment_relations"] = request.PassengerSegmentRelationsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reason))
            {
                body["reason"] = request.Reason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["session_id"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Voluntary))
            {
                body["voluntary"] = request.Voluntary;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightModifyApplyV2",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v2/modify/action/apply",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightModifyApplyV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public FlightModifyApplyV2Response FlightModifyApplyV2(FlightModifyApplyV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightModifyApplyV2Headers headers = new FlightModifyApplyV2Headers();
            return FlightModifyApplyV2WithOptions(request, headers, runtime);
        }

        public async Task<FlightModifyApplyV2Response> FlightModifyApplyV2Async(FlightModifyApplyV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightModifyApplyV2Headers headers = new FlightModifyApplyV2Headers();
            return await FlightModifyApplyV2WithOptionsAsync(request, headers, runtime);
        }

        public FlightModifyCancelV2Response FlightModifyCancelV2WithOptions(FlightModifyCancelV2Request request, FlightModifyCancelV2Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                query["isv_name"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["order_id"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutOrderId))
            {
                query["out_order_id"] = request.OutOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutSubOrderId))
            {
                query["out_sub_order_id"] = request.OutSubOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubOrderId))
            {
                query["sub_order_id"] = request.SubOrderId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightModifyCancelV2",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v2/modify/action/cancel",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightModifyCancelV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<FlightModifyCancelV2Response> FlightModifyCancelV2WithOptionsAsync(FlightModifyCancelV2Request request, FlightModifyCancelV2Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                query["isv_name"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["order_id"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutOrderId))
            {
                query["out_order_id"] = request.OutOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutSubOrderId))
            {
                query["out_sub_order_id"] = request.OutSubOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubOrderId))
            {
                query["sub_order_id"] = request.SubOrderId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightModifyCancelV2",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v2/modify/action/cancel",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightModifyCancelV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public FlightModifyCancelV2Response FlightModifyCancelV2(FlightModifyCancelV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightModifyCancelV2Headers headers = new FlightModifyCancelV2Headers();
            return FlightModifyCancelV2WithOptions(request, headers, runtime);
        }

        public async Task<FlightModifyCancelV2Response> FlightModifyCancelV2Async(FlightModifyCancelV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightModifyCancelV2Headers headers = new FlightModifyCancelV2Headers();
            return await FlightModifyCancelV2WithOptionsAsync(request, headers, runtime);
        }

        public FlightModifyListingSearchV2Response FlightModifyListingSearchV2WithOptions(FlightModifyListingSearchV2Request tmpReq, FlightModifyListingSearchV2Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            FlightModifyListingSearchV2ShrinkRequest request = new FlightModifyListingSearchV2ShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CabinClass))
            {
                request.CabinClassShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CabinClass, "cabin_class", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepDate))
            {
                request.DepDateShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepDate, "dep_date", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PassengerSegmentRelations))
            {
                request.PassengerSegmentRelationsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PassengerSegmentRelations, "passenger_segment_relations", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SelectedSegments))
            {
                request.SelectedSegmentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SelectedSegments, "selected_segments", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CabinClassShrink))
            {
                query["cabin_class"] = request.CabinClassShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepDateShrink))
            {
                query["dep_date"] = request.DepDateShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                query["isv_name"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["order_id"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutOrderId))
            {
                query["out_order_id"] = request.OutOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PassengerSegmentRelationsShrink))
            {
                query["passenger_segment_relations"] = request.PassengerSegmentRelationsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchMode))
            {
                query["search_mode"] = request.SearchMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelectedSegmentsShrink))
            {
                query["selected_segments"] = request.SelectedSegmentsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["session_id"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Voluntary))
            {
                query["voluntary"] = request.Voluntary;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightModifyListingSearchV2",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v2/modify/action/listing-search",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightModifyListingSearchV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<FlightModifyListingSearchV2Response> FlightModifyListingSearchV2WithOptionsAsync(FlightModifyListingSearchV2Request tmpReq, FlightModifyListingSearchV2Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            FlightModifyListingSearchV2ShrinkRequest request = new FlightModifyListingSearchV2ShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CabinClass))
            {
                request.CabinClassShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CabinClass, "cabin_class", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepDate))
            {
                request.DepDateShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepDate, "dep_date", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PassengerSegmentRelations))
            {
                request.PassengerSegmentRelationsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PassengerSegmentRelations, "passenger_segment_relations", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SelectedSegments))
            {
                request.SelectedSegmentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SelectedSegments, "selected_segments", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CabinClassShrink))
            {
                query["cabin_class"] = request.CabinClassShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepDateShrink))
            {
                query["dep_date"] = request.DepDateShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                query["isv_name"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["order_id"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutOrderId))
            {
                query["out_order_id"] = request.OutOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PassengerSegmentRelationsShrink))
            {
                query["passenger_segment_relations"] = request.PassengerSegmentRelationsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchMode))
            {
                query["search_mode"] = request.SearchMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelectedSegmentsShrink))
            {
                query["selected_segments"] = request.SelectedSegmentsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["session_id"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Voluntary))
            {
                query["voluntary"] = request.Voluntary;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightModifyListingSearchV2",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v2/modify/action/listing-search",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightModifyListingSearchV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public FlightModifyListingSearchV2Response FlightModifyListingSearchV2(FlightModifyListingSearchV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightModifyListingSearchV2Headers headers = new FlightModifyListingSearchV2Headers();
            return FlightModifyListingSearchV2WithOptions(request, headers, runtime);
        }

        public async Task<FlightModifyListingSearchV2Response> FlightModifyListingSearchV2Async(FlightModifyListingSearchV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightModifyListingSearchV2Headers headers = new FlightModifyListingSearchV2Headers();
            return await FlightModifyListingSearchV2WithOptionsAsync(request, headers, runtime);
        }

        public FlightModifyOrderDetailV2Response FlightModifyOrderDetailV2WithOptions(FlightModifyOrderDetailV2Request request, FlightModifyOrderDetailV2Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                query["isv_name"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyApplyId))
            {
                query["modify_apply_id"] = request.ModifyApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedQueryServiceFee))
            {
                query["need_query_service_fee"] = request.NeedQueryServiceFee;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["order_id"] = request.OrderId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightModifyOrderDetailV2",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v2/modify/action/detail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightModifyOrderDetailV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<FlightModifyOrderDetailV2Response> FlightModifyOrderDetailV2WithOptionsAsync(FlightModifyOrderDetailV2Request request, FlightModifyOrderDetailV2Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                query["isv_name"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyApplyId))
            {
                query["modify_apply_id"] = request.ModifyApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedQueryServiceFee))
            {
                query["need_query_service_fee"] = request.NeedQueryServiceFee;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["order_id"] = request.OrderId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightModifyOrderDetailV2",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v2/modify/action/detail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightModifyOrderDetailV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public FlightModifyOrderDetailV2Response FlightModifyOrderDetailV2(FlightModifyOrderDetailV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightModifyOrderDetailV2Headers headers = new FlightModifyOrderDetailV2Headers();
            return FlightModifyOrderDetailV2WithOptions(request, headers, runtime);
        }

        public async Task<FlightModifyOrderDetailV2Response> FlightModifyOrderDetailV2Async(FlightModifyOrderDetailV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightModifyOrderDetailV2Headers headers = new FlightModifyOrderDetailV2Headers();
            return await FlightModifyOrderDetailV2WithOptionsAsync(request, headers, runtime);
        }

        public FlightModifyOtaSearchV2Response FlightModifyOtaSearchV2WithOptions(FlightModifyOtaSearchV2Request tmpReq, FlightModifyOtaSearchV2Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            FlightModifyOtaSearchV2ShrinkRequest request = new FlightModifyOtaSearchV2ShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CabinClass))
            {
                request.CabinClassShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CabinClass, "cabin_class", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepDate))
            {
                request.DepDateShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepDate, "dep_date", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PassengerSegmentRelations))
            {
                request.PassengerSegmentRelationsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PassengerSegmentRelations, "passenger_segment_relations", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SelectedSegments))
            {
                request.SelectedSegmentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SelectedSegments, "selected_segments", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CabinClassShrink))
            {
                query["cabin_class"] = request.CabinClassShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepDateShrink))
            {
                query["dep_date"] = request.DepDateShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                query["isv_name"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["order_id"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutOrderId))
            {
                query["out_order_id"] = request.OutOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PassengerSegmentRelationsShrink))
            {
                query["passenger_segment_relations"] = request.PassengerSegmentRelationsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelectedSegmentsShrink))
            {
                query["selected_segments"] = request.SelectedSegmentsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["session_id"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Voluntary))
            {
                query["voluntary"] = request.Voluntary;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightModifyOtaSearchV2",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v2/modify/action/ota-search",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightModifyOtaSearchV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<FlightModifyOtaSearchV2Response> FlightModifyOtaSearchV2WithOptionsAsync(FlightModifyOtaSearchV2Request tmpReq, FlightModifyOtaSearchV2Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            FlightModifyOtaSearchV2ShrinkRequest request = new FlightModifyOtaSearchV2ShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CabinClass))
            {
                request.CabinClassShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CabinClass, "cabin_class", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepDate))
            {
                request.DepDateShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepDate, "dep_date", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PassengerSegmentRelations))
            {
                request.PassengerSegmentRelationsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PassengerSegmentRelations, "passenger_segment_relations", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SelectedSegments))
            {
                request.SelectedSegmentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SelectedSegments, "selected_segments", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CabinClassShrink))
            {
                query["cabin_class"] = request.CabinClassShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepDateShrink))
            {
                query["dep_date"] = request.DepDateShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                query["isv_name"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["order_id"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutOrderId))
            {
                query["out_order_id"] = request.OutOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PassengerSegmentRelationsShrink))
            {
                query["passenger_segment_relations"] = request.PassengerSegmentRelationsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelectedSegmentsShrink))
            {
                query["selected_segments"] = request.SelectedSegmentsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["session_id"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Voluntary))
            {
                query["voluntary"] = request.Voluntary;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightModifyOtaSearchV2",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v2/modify/action/ota-search",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightModifyOtaSearchV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public FlightModifyOtaSearchV2Response FlightModifyOtaSearchV2(FlightModifyOtaSearchV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightModifyOtaSearchV2Headers headers = new FlightModifyOtaSearchV2Headers();
            return FlightModifyOtaSearchV2WithOptions(request, headers, runtime);
        }

        public async Task<FlightModifyOtaSearchV2Response> FlightModifyOtaSearchV2Async(FlightModifyOtaSearchV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightModifyOtaSearchV2Headers headers = new FlightModifyOtaSearchV2Headers();
            return await FlightModifyOtaSearchV2WithOptionsAsync(request, headers, runtime);
        }

        public FlightModifyPayV2Response FlightModifyPayV2WithOptions(FlightModifyPayV2Request tmpReq, FlightModifyPayV2Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            FlightModifyPayV2ShrinkRequest request = new FlightModifyPayV2ShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExtParams))
            {
                request.ExtParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExtParams, "ext_params", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtParamsShrink))
            {
                body["ext_params"] = request.ExtParamsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                body["isv_name"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyPayAmount))
            {
                body["modify_pay_amount"] = request.ModifyPayAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                body["order_id"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutOrderId))
            {
                body["out_order_id"] = request.OutOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutSubOrderId))
            {
                body["out_sub_order_id"] = request.OutSubOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubOrderId))
            {
                body["sub_order_id"] = request.SubOrderId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightModifyPayV2",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v2/modify/action/pay",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightModifyPayV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<FlightModifyPayV2Response> FlightModifyPayV2WithOptionsAsync(FlightModifyPayV2Request tmpReq, FlightModifyPayV2Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            FlightModifyPayV2ShrinkRequest request = new FlightModifyPayV2ShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExtParams))
            {
                request.ExtParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExtParams, "ext_params", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtParamsShrink))
            {
                body["ext_params"] = request.ExtParamsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                body["isv_name"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyPayAmount))
            {
                body["modify_pay_amount"] = request.ModifyPayAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                body["order_id"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutOrderId))
            {
                body["out_order_id"] = request.OutOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutSubOrderId))
            {
                body["out_sub_order_id"] = request.OutSubOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubOrderId))
            {
                body["sub_order_id"] = request.SubOrderId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightModifyPayV2",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v2/modify/action/pay",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightModifyPayV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public FlightModifyPayV2Response FlightModifyPayV2(FlightModifyPayV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightModifyPayV2Headers headers = new FlightModifyPayV2Headers();
            return FlightModifyPayV2WithOptions(request, headers, runtime);
        }

        public async Task<FlightModifyPayV2Response> FlightModifyPayV2Async(FlightModifyPayV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightModifyPayV2Headers headers = new FlightModifyPayV2Headers();
            return await FlightModifyPayV2WithOptionsAsync(request, headers, runtime);
        }

        public FlightOrderDetailInfoResponse FlightOrderDetailInfoWithOptions(FlightOrderDetailInfoRequest request, FlightOrderDetailInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisOrderId))
            {
                query["dis_order_id"] = request.DisOrderId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightOrderDetailInfo",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v1/order/action/detail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightOrderDetailInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<FlightOrderDetailInfoResponse> FlightOrderDetailInfoWithOptionsAsync(FlightOrderDetailInfoRequest request, FlightOrderDetailInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisOrderId))
            {
                query["dis_order_id"] = request.DisOrderId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightOrderDetailInfo",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v1/order/action/detail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightOrderDetailInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public FlightOrderDetailInfoResponse FlightOrderDetailInfo(FlightOrderDetailInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightOrderDetailInfoHeaders headers = new FlightOrderDetailInfoHeaders();
            return FlightOrderDetailInfoWithOptions(request, headers, runtime);
        }

        public async Task<FlightOrderDetailInfoResponse> FlightOrderDetailInfoAsync(FlightOrderDetailInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightOrderDetailInfoHeaders headers = new FlightOrderDetailInfoHeaders();
            return await FlightOrderDetailInfoWithOptionsAsync(request, headers, runtime);
        }

        public FlightOrderDetailV2Response FlightOrderDetailV2WithOptions(FlightOrderDetailV2Request request, FlightOrderDetailV2Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                query["isv_name"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["order_id"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutOrderId))
            {
                query["out_order_id"] = request.OutOrderId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightOrderDetailV2",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v2/order/action/detail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightOrderDetailV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<FlightOrderDetailV2Response> FlightOrderDetailV2WithOptionsAsync(FlightOrderDetailV2Request request, FlightOrderDetailV2Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                query["isv_name"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["order_id"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutOrderId))
            {
                query["out_order_id"] = request.OutOrderId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightOrderDetailV2",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v2/order/action/detail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightOrderDetailV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public FlightOrderDetailV2Response FlightOrderDetailV2(FlightOrderDetailV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightOrderDetailV2Headers headers = new FlightOrderDetailV2Headers();
            return FlightOrderDetailV2WithOptions(request, headers, runtime);
        }

        public async Task<FlightOrderDetailV2Response> FlightOrderDetailV2Async(FlightOrderDetailV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightOrderDetailV2Headers headers = new FlightOrderDetailV2Headers();
            return await FlightOrderDetailV2WithOptionsAsync(request, headers, runtime);
        }

        public FlightOrderListQueryResponse FlightOrderListQueryWithOptions(FlightOrderListQueryRequest request, FlightOrderListQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllApply))
            {
                query["all_apply"] = request.AllApply;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyId))
            {
                query["apply_id"] = request.ApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartId))
            {
                query["depart_id"] = request.DepartId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["end_time"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["start_time"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartApplyId))
            {
                query["thirdpart_apply_id"] = request.ThirdpartApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateEndTime))
            {
                query["update_end_time"] = request.UpdateEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateStartTime))
            {
                query["update_start_time"] = request.UpdateStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["user_id"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightOrderListQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/flight/v1/order-list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightOrderListQueryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<FlightOrderListQueryResponse> FlightOrderListQueryWithOptionsAsync(FlightOrderListQueryRequest request, FlightOrderListQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllApply))
            {
                query["all_apply"] = request.AllApply;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyId))
            {
                query["apply_id"] = request.ApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartId))
            {
                query["depart_id"] = request.DepartId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["end_time"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["start_time"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartApplyId))
            {
                query["thirdpart_apply_id"] = request.ThirdpartApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateEndTime))
            {
                query["update_end_time"] = request.UpdateEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateStartTime))
            {
                query["update_start_time"] = request.UpdateStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["user_id"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightOrderListQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/flight/v1/order-list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightOrderListQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public FlightOrderListQueryResponse FlightOrderListQuery(FlightOrderListQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightOrderListQueryHeaders headers = new FlightOrderListQueryHeaders();
            return FlightOrderListQueryWithOptions(request, headers, runtime);
        }

        public async Task<FlightOrderListQueryResponse> FlightOrderListQueryAsync(FlightOrderListQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightOrderListQueryHeaders headers = new FlightOrderListQueryHeaders();
            return await FlightOrderListQueryWithOptionsAsync(request, headers, runtime);
        }

        public FlightOrderQueryResponse FlightOrderQueryWithOptions(FlightOrderQueryRequest request, FlightOrderQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["order_id"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["user_id"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightOrderQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/flight/v1/order",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightOrderQueryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<FlightOrderQueryResponse> FlightOrderQueryWithOptionsAsync(FlightOrderQueryRequest request, FlightOrderQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["order_id"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["user_id"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightOrderQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/flight/v1/order",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightOrderQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public FlightOrderQueryResponse FlightOrderQuery(FlightOrderQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightOrderQueryHeaders headers = new FlightOrderQueryHeaders();
            return FlightOrderQueryWithOptions(request, headers, runtime);
        }

        public async Task<FlightOrderQueryResponse> FlightOrderQueryAsync(FlightOrderQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightOrderQueryHeaders headers = new FlightOrderQueryHeaders();
            return await FlightOrderQueryWithOptionsAsync(request, headers, runtime);
        }

        public FlightOtaItemDetailResponse FlightOtaItemDetailWithOptions(FlightOtaItemDetailRequest request, FlightOtaItemDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                query["isv_name"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtaItemId))
            {
                query["ota_item_id"] = request.OtaItemId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightOtaItemDetail",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v1/flight/action/ota-item-detail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightOtaItemDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<FlightOtaItemDetailResponse> FlightOtaItemDetailWithOptionsAsync(FlightOtaItemDetailRequest request, FlightOtaItemDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                query["isv_name"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtaItemId))
            {
                query["ota_item_id"] = request.OtaItemId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightOtaItemDetail",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v1/flight/action/ota-item-detail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightOtaItemDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public FlightOtaItemDetailResponse FlightOtaItemDetail(FlightOtaItemDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightOtaItemDetailHeaders headers = new FlightOtaItemDetailHeaders();
            return FlightOtaItemDetailWithOptions(request, headers, runtime);
        }

        public async Task<FlightOtaItemDetailResponse> FlightOtaItemDetailAsync(FlightOtaItemDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightOtaItemDetailHeaders headers = new FlightOtaItemDetailHeaders();
            return await FlightOtaItemDetailWithOptionsAsync(request, headers, runtime);
        }

        public FlightOtaSearchResponse FlightOtaSearchWithOptions(FlightOtaSearchRequest request, FlightOtaSearchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AirlineCode))
            {
                query["airline_code"] = request.AirlineCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArrCityCode))
            {
                query["arr_city_code"] = request.ArrCityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CabinClass))
            {
                query["cabin_class"] = request.CabinClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CarrierFlightNo))
            {
                query["carrier_flight_no"] = request.CarrierFlightNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepCityCode))
            {
                query["dep_city_code"] = request.DepCityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepDate))
            {
                query["dep_date"] = request.DepDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlightNo))
            {
                query["flight_no"] = request.FlightNo;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightOtaSearch",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v1/flight/action/ota-search",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightOtaSearchResponse>(CallApi(params_, req, runtime));
        }

        public async Task<FlightOtaSearchResponse> FlightOtaSearchWithOptionsAsync(FlightOtaSearchRequest request, FlightOtaSearchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AirlineCode))
            {
                query["airline_code"] = request.AirlineCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArrCityCode))
            {
                query["arr_city_code"] = request.ArrCityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CabinClass))
            {
                query["cabin_class"] = request.CabinClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CarrierFlightNo))
            {
                query["carrier_flight_no"] = request.CarrierFlightNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepCityCode))
            {
                query["dep_city_code"] = request.DepCityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepDate))
            {
                query["dep_date"] = request.DepDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlightNo))
            {
                query["flight_no"] = request.FlightNo;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightOtaSearch",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v1/flight/action/ota-search",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightOtaSearchResponse>(await CallApiAsync(params_, req, runtime));
        }

        public FlightOtaSearchResponse FlightOtaSearch(FlightOtaSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightOtaSearchHeaders headers = new FlightOtaSearchHeaders();
            return FlightOtaSearchWithOptions(request, headers, runtime);
        }

        public async Task<FlightOtaSearchResponse> FlightOtaSearchAsync(FlightOtaSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightOtaSearchHeaders headers = new FlightOtaSearchHeaders();
            return await FlightOtaSearchWithOptionsAsync(request, headers, runtime);
        }

        public FlightOtaSearchV2Response FlightOtaSearchV2WithOptions(FlightOtaSearchV2Request tmpReq, FlightOtaSearchV2Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            FlightOtaSearchV2ShrinkRequest request = new FlightOtaSearchV2ShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CabinTypeList))
            {
                request.CabinTypeListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CabinTypeList, "cabin_type_list", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SearchJourneys))
            {
                request.SearchJourneysShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SearchJourneys, "search_journeys", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CabinTypeListShrink))
            {
                query["cabin_type_list"] = request.CabinTypeListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectOnly))
            {
                query["direct_only"] = request.DirectOnly;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                query["isv_name"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedShareFlight))
            {
                query["need_share_flight"] = request.NeedShareFlight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchJourneysShrink))
            {
                query["search_journeys"] = request.SearchJourneysShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchMode))
            {
                query["search_mode"] = request.SearchMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TripType))
            {
                query["trip_type"] = request.TripType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightOtaSearchV2",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v2/flight/action/ota-search",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightOtaSearchV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<FlightOtaSearchV2Response> FlightOtaSearchV2WithOptionsAsync(FlightOtaSearchV2Request tmpReq, FlightOtaSearchV2Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            FlightOtaSearchV2ShrinkRequest request = new FlightOtaSearchV2ShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CabinTypeList))
            {
                request.CabinTypeListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CabinTypeList, "cabin_type_list", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SearchJourneys))
            {
                request.SearchJourneysShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SearchJourneys, "search_journeys", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CabinTypeListShrink))
            {
                query["cabin_type_list"] = request.CabinTypeListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectOnly))
            {
                query["direct_only"] = request.DirectOnly;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                query["isv_name"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedShareFlight))
            {
                query["need_share_flight"] = request.NeedShareFlight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchJourneysShrink))
            {
                query["search_journeys"] = request.SearchJourneysShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchMode))
            {
                query["search_mode"] = request.SearchMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TripType))
            {
                query["trip_type"] = request.TripType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightOtaSearchV2",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v2/flight/action/ota-search",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightOtaSearchV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public FlightOtaSearchV2Response FlightOtaSearchV2(FlightOtaSearchV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightOtaSearchV2Headers headers = new FlightOtaSearchV2Headers();
            return FlightOtaSearchV2WithOptions(request, headers, runtime);
        }

        public async Task<FlightOtaSearchV2Response> FlightOtaSearchV2Async(FlightOtaSearchV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightOtaSearchV2Headers headers = new FlightOtaSearchV2Headers();
            return await FlightOtaSearchV2WithOptionsAsync(request, headers, runtime);
        }

        public FlightPayOrderResponse FlightPayOrderWithOptions(FlightPayOrderRequest tmpReq, FlightPayOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            FlightPayOrderShrinkRequest request = new FlightPayOrderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Extra))
            {
                request.ExtraShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Extra, "extra", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpPayPrice))
            {
                body["corp_pay_price"] = request.CorpPayPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisOrderId))
            {
                body["dis_order_id"] = request.DisOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraShrink))
            {
                body["extra"] = request.ExtraShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersonalPayPrice))
            {
                body["personal_pay_price"] = request.PersonalPayPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalPayPrice))
            {
                body["total_pay_price"] = request.TotalPayPrice;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightPayOrder",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v1/order/action/pay",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightPayOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<FlightPayOrderResponse> FlightPayOrderWithOptionsAsync(FlightPayOrderRequest tmpReq, FlightPayOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            FlightPayOrderShrinkRequest request = new FlightPayOrderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Extra))
            {
                request.ExtraShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Extra, "extra", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpPayPrice))
            {
                body["corp_pay_price"] = request.CorpPayPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisOrderId))
            {
                body["dis_order_id"] = request.DisOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraShrink))
            {
                body["extra"] = request.ExtraShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersonalPayPrice))
            {
                body["personal_pay_price"] = request.PersonalPayPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalPayPrice))
            {
                body["total_pay_price"] = request.TotalPayPrice;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightPayOrder",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v1/order/action/pay",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightPayOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public FlightPayOrderResponse FlightPayOrder(FlightPayOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightPayOrderHeaders headers = new FlightPayOrderHeaders();
            return FlightPayOrderWithOptions(request, headers, runtime);
        }

        public async Task<FlightPayOrderResponse> FlightPayOrderAsync(FlightPayOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightPayOrderHeaders headers = new FlightPayOrderHeaders();
            return await FlightPayOrderWithOptionsAsync(request, headers, runtime);
        }

        public FlightPayOrderV2Response FlightPayOrderV2WithOptions(FlightPayOrderV2Request request, FlightPayOrderV2Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                body["isv_name"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                body["order_id"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutOrderId))
            {
                body["out_order_id"] = request.OutOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalPrice))
            {
                body["total_price"] = request.TotalPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalServiceFeePrice))
            {
                body["total_service_fee_price"] = request.TotalServiceFeePrice;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightPayOrderV2",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v2/order/action/pay",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightPayOrderV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<FlightPayOrderV2Response> FlightPayOrderV2WithOptionsAsync(FlightPayOrderV2Request request, FlightPayOrderV2Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                body["isv_name"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                body["order_id"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutOrderId))
            {
                body["out_order_id"] = request.OutOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalPrice))
            {
                body["total_price"] = request.TotalPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalServiceFeePrice))
            {
                body["total_service_fee_price"] = request.TotalServiceFeePrice;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightPayOrderV2",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v2/order/action/pay",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightPayOrderV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public FlightPayOrderV2Response FlightPayOrderV2(FlightPayOrderV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightPayOrderV2Headers headers = new FlightPayOrderV2Headers();
            return FlightPayOrderV2WithOptions(request, headers, runtime);
        }

        public async Task<FlightPayOrderV2Response> FlightPayOrderV2Async(FlightPayOrderV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightPayOrderV2Headers headers = new FlightPayOrderV2Headers();
            return await FlightPayOrderV2WithOptionsAsync(request, headers, runtime);
        }

        public FlightRefundApplyResponse FlightRefundApplyWithOptions(FlightRefundApplyRequest tmpReq, FlightRefundApplyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            FlightRefundApplyShrinkRequest request = new FlightRefundApplyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Extra))
            {
                request.ExtraShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Extra, "extra", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PassengerSegmentInfoList))
            {
                request.PassengerSegmentInfoListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PassengerSegmentInfoList, "passenger_segment_info_list", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RefundVoucherInfo))
            {
                request.RefundVoucherInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RefundVoucherInfo, "refund_voucher_info", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpRefundPrice))
            {
                body["corp_refund_price"] = request.CorpRefundPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisOrderId))
            {
                body["dis_order_id"] = request.DisOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisSubOrderId))
            {
                body["dis_sub_order_id"] = request.DisSubOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayRefundMoney))
            {
                body["display_refund_money"] = request.DisplayRefundMoney;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraShrink))
            {
                body["extra"] = request.ExtraShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsVoluntary))
            {
                body["is_voluntary"] = request.IsVoluntary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemUnitIds))
            {
                body["item_unit_ids"] = request.ItemUnitIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PassengerSegmentInfoListShrink))
            {
                body["passenger_segment_info_list"] = request.PassengerSegmentInfoListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersonalRefundPrice))
            {
                body["personal_refund_price"] = request.PersonalRefundPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReasonDetail))
            {
                body["reason_detail"] = request.ReasonDetail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReasonType))
            {
                body["reason_type"] = request.ReasonType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundVoucherInfoShrink))
            {
                body["refund_voucher_info"] = request.RefundVoucherInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["session_id"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalRefundPrice))
            {
                body["total_refund_price"] = request.TotalRefundPrice;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightRefundApply",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v1/refund/action/apply",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightRefundApplyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<FlightRefundApplyResponse> FlightRefundApplyWithOptionsAsync(FlightRefundApplyRequest tmpReq, FlightRefundApplyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            FlightRefundApplyShrinkRequest request = new FlightRefundApplyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Extra))
            {
                request.ExtraShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Extra, "extra", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PassengerSegmentInfoList))
            {
                request.PassengerSegmentInfoListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PassengerSegmentInfoList, "passenger_segment_info_list", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RefundVoucherInfo))
            {
                request.RefundVoucherInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RefundVoucherInfo, "refund_voucher_info", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpRefundPrice))
            {
                body["corp_refund_price"] = request.CorpRefundPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisOrderId))
            {
                body["dis_order_id"] = request.DisOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisSubOrderId))
            {
                body["dis_sub_order_id"] = request.DisSubOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayRefundMoney))
            {
                body["display_refund_money"] = request.DisplayRefundMoney;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraShrink))
            {
                body["extra"] = request.ExtraShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsVoluntary))
            {
                body["is_voluntary"] = request.IsVoluntary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemUnitIds))
            {
                body["item_unit_ids"] = request.ItemUnitIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PassengerSegmentInfoListShrink))
            {
                body["passenger_segment_info_list"] = request.PassengerSegmentInfoListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersonalRefundPrice))
            {
                body["personal_refund_price"] = request.PersonalRefundPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReasonDetail))
            {
                body["reason_detail"] = request.ReasonDetail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReasonType))
            {
                body["reason_type"] = request.ReasonType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundVoucherInfoShrink))
            {
                body["refund_voucher_info"] = request.RefundVoucherInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["session_id"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalRefundPrice))
            {
                body["total_refund_price"] = request.TotalRefundPrice;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightRefundApply",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v1/refund/action/apply",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightRefundApplyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public FlightRefundApplyResponse FlightRefundApply(FlightRefundApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightRefundApplyHeaders headers = new FlightRefundApplyHeaders();
            return FlightRefundApplyWithOptions(request, headers, runtime);
        }

        public async Task<FlightRefundApplyResponse> FlightRefundApplyAsync(FlightRefundApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightRefundApplyHeaders headers = new FlightRefundApplyHeaders();
            return await FlightRefundApplyWithOptionsAsync(request, headers, runtime);
        }

        public FlightRefundApplyV2Response FlightRefundApplyV2WithOptions(FlightRefundApplyV2Request tmpReq, FlightRefundApplyV2Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            FlightRefundApplyV2ShrinkRequest request = new FlightRefundApplyV2ShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PassengerSegmentRelations))
            {
                request.PassengerSegmentRelationsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PassengerSegmentRelations, "passenger_segment_relations", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TicketNos))
            {
                request.TicketNosShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TicketNos, "ticket_nos", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                body["isv_name"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                body["order_id"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutOrderId))
            {
                body["out_order_id"] = request.OutOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutSubOrderId))
            {
                body["out_sub_order_id"] = request.OutSubOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PassengerSegmentRelationsShrink))
            {
                body["passenger_segment_relations"] = request.PassengerSegmentRelationsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreCalType))
            {
                body["pre_cal_type"] = request.PreCalType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundReason))
            {
                body["refund_reason"] = request.RefundReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundReasonType))
            {
                body["refund_reason_type"] = request.RefundReasonType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketNosShrink))
            {
                body["ticket_nos"] = request.TicketNosShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalRefundPrice))
            {
                body["total_refund_price"] = request.TotalRefundPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadPictUrls))
            {
                body["upload_pict_urls"] = request.UploadPictUrls;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Voluntary))
            {
                body["voluntary"] = request.Voluntary;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightRefundApplyV2",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v2/refund/action/apply",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightRefundApplyV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<FlightRefundApplyV2Response> FlightRefundApplyV2WithOptionsAsync(FlightRefundApplyV2Request tmpReq, FlightRefundApplyV2Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            FlightRefundApplyV2ShrinkRequest request = new FlightRefundApplyV2ShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PassengerSegmentRelations))
            {
                request.PassengerSegmentRelationsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PassengerSegmentRelations, "passenger_segment_relations", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TicketNos))
            {
                request.TicketNosShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TicketNos, "ticket_nos", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                body["isv_name"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                body["order_id"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutOrderId))
            {
                body["out_order_id"] = request.OutOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutSubOrderId))
            {
                body["out_sub_order_id"] = request.OutSubOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PassengerSegmentRelationsShrink))
            {
                body["passenger_segment_relations"] = request.PassengerSegmentRelationsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreCalType))
            {
                body["pre_cal_type"] = request.PreCalType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundReason))
            {
                body["refund_reason"] = request.RefundReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundReasonType))
            {
                body["refund_reason_type"] = request.RefundReasonType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketNosShrink))
            {
                body["ticket_nos"] = request.TicketNosShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalRefundPrice))
            {
                body["total_refund_price"] = request.TotalRefundPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadPictUrls))
            {
                body["upload_pict_urls"] = request.UploadPictUrls;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Voluntary))
            {
                body["voluntary"] = request.Voluntary;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightRefundApplyV2",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v2/refund/action/apply",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightRefundApplyV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public FlightRefundApplyV2Response FlightRefundApplyV2(FlightRefundApplyV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightRefundApplyV2Headers headers = new FlightRefundApplyV2Headers();
            return FlightRefundApplyV2WithOptions(request, headers, runtime);
        }

        public async Task<FlightRefundApplyV2Response> FlightRefundApplyV2Async(FlightRefundApplyV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightRefundApplyV2Headers headers = new FlightRefundApplyV2Headers();
            return await FlightRefundApplyV2WithOptionsAsync(request, headers, runtime);
        }

        public FlightRefundDetailResponse FlightRefundDetailWithOptions(FlightRefundDetailRequest request, FlightRefundDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisOrderId))
            {
                query["dis_order_id"] = request.DisOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisSubOrderId))
            {
                query["dis_sub_order_id"] = request.DisSubOrderId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightRefundDetail",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v1/refund/action/detail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightRefundDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<FlightRefundDetailResponse> FlightRefundDetailWithOptionsAsync(FlightRefundDetailRequest request, FlightRefundDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisOrderId))
            {
                query["dis_order_id"] = request.DisOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisSubOrderId))
            {
                query["dis_sub_order_id"] = request.DisSubOrderId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightRefundDetail",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v1/refund/action/detail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightRefundDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public FlightRefundDetailResponse FlightRefundDetail(FlightRefundDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightRefundDetailHeaders headers = new FlightRefundDetailHeaders();
            return FlightRefundDetailWithOptions(request, headers, runtime);
        }

        public async Task<FlightRefundDetailResponse> FlightRefundDetailAsync(FlightRefundDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightRefundDetailHeaders headers = new FlightRefundDetailHeaders();
            return await FlightRefundDetailWithOptionsAsync(request, headers, runtime);
        }

        public FlightRefundDetailV2Response FlightRefundDetailV2WithOptions(FlightRefundDetailV2Request request, FlightRefundDetailV2Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                query["isv_name"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["order_id"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundApplyId))
            {
                query["refund_apply_id"] = request.RefundApplyId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightRefundDetailV2",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v2/refund/action/detail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightRefundDetailV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<FlightRefundDetailV2Response> FlightRefundDetailV2WithOptionsAsync(FlightRefundDetailV2Request request, FlightRefundDetailV2Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                query["isv_name"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["order_id"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundApplyId))
            {
                query["refund_apply_id"] = request.RefundApplyId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightRefundDetailV2",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v2/refund/action/detail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightRefundDetailV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public FlightRefundDetailV2Response FlightRefundDetailV2(FlightRefundDetailV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightRefundDetailV2Headers headers = new FlightRefundDetailV2Headers();
            return FlightRefundDetailV2WithOptions(request, headers, runtime);
        }

        public async Task<FlightRefundDetailV2Response> FlightRefundDetailV2Async(FlightRefundDetailV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightRefundDetailV2Headers headers = new FlightRefundDetailV2Headers();
            return await FlightRefundDetailV2WithOptionsAsync(request, headers, runtime);
        }

        public FlightRefundPreCalResponse FlightRefundPreCalWithOptions(FlightRefundPreCalRequest tmpReq, FlightRefundPreCalHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            FlightRefundPreCalShrinkRequest request = new FlightRefundPreCalShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PassengerSegmentInfoList))
            {
                request.PassengerSegmentInfoListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PassengerSegmentInfoList, "passenger_segment_info_list", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisOrderId))
            {
                query["dis_order_id"] = request.DisOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsVoluntary))
            {
                query["is_voluntary"] = request.IsVoluntary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PassengerSegmentInfoListShrink))
            {
                query["passenger_segment_info_list"] = request.PassengerSegmentInfoListShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightRefundPreCal",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v1/refund/action/pre-cal",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightRefundPreCalResponse>(CallApi(params_, req, runtime));
        }

        public async Task<FlightRefundPreCalResponse> FlightRefundPreCalWithOptionsAsync(FlightRefundPreCalRequest tmpReq, FlightRefundPreCalHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            FlightRefundPreCalShrinkRequest request = new FlightRefundPreCalShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PassengerSegmentInfoList))
            {
                request.PassengerSegmentInfoListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PassengerSegmentInfoList, "passenger_segment_info_list", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisOrderId))
            {
                query["dis_order_id"] = request.DisOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsVoluntary))
            {
                query["is_voluntary"] = request.IsVoluntary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PassengerSegmentInfoListShrink))
            {
                query["passenger_segment_info_list"] = request.PassengerSegmentInfoListShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightRefundPreCal",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v1/refund/action/pre-cal",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightRefundPreCalResponse>(await CallApiAsync(params_, req, runtime));
        }

        public FlightRefundPreCalResponse FlightRefundPreCal(FlightRefundPreCalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightRefundPreCalHeaders headers = new FlightRefundPreCalHeaders();
            return FlightRefundPreCalWithOptions(request, headers, runtime);
        }

        public async Task<FlightRefundPreCalResponse> FlightRefundPreCalAsync(FlightRefundPreCalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightRefundPreCalHeaders headers = new FlightRefundPreCalHeaders();
            return await FlightRefundPreCalWithOptionsAsync(request, headers, runtime);
        }

        public FlightRefundPreCalV2Response FlightRefundPreCalV2WithOptions(FlightRefundPreCalV2Request tmpReq, FlightRefundPreCalV2Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            FlightRefundPreCalV2ShrinkRequest request = new FlightRefundPreCalV2ShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PassengerSegmentRelations))
            {
                request.PassengerSegmentRelationsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PassengerSegmentRelations, "passenger_segment_relations", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TicketNos))
            {
                request.TicketNosShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TicketNos, "ticket_nos", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                query["isv_name"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["order_id"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutOrderId))
            {
                query["out_order_id"] = request.OutOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PassengerSegmentRelationsShrink))
            {
                query["passenger_segment_relations"] = request.PassengerSegmentRelationsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreCalType))
            {
                query["pre_cal_type"] = request.PreCalType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketNosShrink))
            {
                query["ticket_nos"] = request.TicketNosShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Voluntary))
            {
                query["voluntary"] = request.Voluntary;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightRefundPreCalV2",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v2/refund/action/pre-cal",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightRefundPreCalV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<FlightRefundPreCalV2Response> FlightRefundPreCalV2WithOptionsAsync(FlightRefundPreCalV2Request tmpReq, FlightRefundPreCalV2Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            FlightRefundPreCalV2ShrinkRequest request = new FlightRefundPreCalV2ShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PassengerSegmentRelations))
            {
                request.PassengerSegmentRelationsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PassengerSegmentRelations, "passenger_segment_relations", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TicketNos))
            {
                request.TicketNosShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TicketNos, "ticket_nos", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                query["isv_name"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["order_id"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutOrderId))
            {
                query["out_order_id"] = request.OutOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PassengerSegmentRelationsShrink))
            {
                query["passenger_segment_relations"] = request.PassengerSegmentRelationsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreCalType))
            {
                query["pre_cal_type"] = request.PreCalType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketNosShrink))
            {
                query["ticket_nos"] = request.TicketNosShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Voluntary))
            {
                query["voluntary"] = request.Voluntary;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightRefundPreCalV2",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v2/refund/action/pre-cal",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightRefundPreCalV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public FlightRefundPreCalV2Response FlightRefundPreCalV2(FlightRefundPreCalV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightRefundPreCalV2Headers headers = new FlightRefundPreCalV2Headers();
            return FlightRefundPreCalV2WithOptions(request, headers, runtime);
        }

        public async Task<FlightRefundPreCalV2Response> FlightRefundPreCalV2Async(FlightRefundPreCalV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightRefundPreCalV2Headers headers = new FlightRefundPreCalV2Headers();
            return await FlightRefundPreCalV2WithOptionsAsync(request, headers, runtime);
        }

        public FlightSearchListResponse FlightSearchListWithOptions(FlightSearchListRequest request, FlightSearchListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AirlineCode))
            {
                query["airline_code"] = request.AirlineCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArrCityCode))
            {
                query["arr_city_code"] = request.ArrCityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArrCityName))
            {
                query["arr_city_name"] = request.ArrCityName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArrDate))
            {
                query["arr_date"] = request.ArrDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CabinClass))
            {
                query["cabin_class"] = request.CabinClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepCityCode))
            {
                query["dep_city_code"] = request.DepCityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepCityName))
            {
                query["dep_city_name"] = request.DepCityName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepDate))
            {
                query["dep_date"] = request.DepDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlightNo))
            {
                query["flight_no"] = request.FlightNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedMultiClassPrice))
            {
                query["need_multi_class_price"] = request.NeedMultiClassPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransferCityCode))
            {
                query["transfer_city_code"] = request.TransferCityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransferFlightNo))
            {
                query["transfer_flight_no"] = request.TransferFlightNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransferLeaveDate))
            {
                query["transfer_leave_date"] = request.TransferLeaveDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TripType))
            {
                query["trip_type"] = request.TripType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightSearchList",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/huge/dtb-flight/v1/flight/action/search-list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightSearchListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<FlightSearchListResponse> FlightSearchListWithOptionsAsync(FlightSearchListRequest request, FlightSearchListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AirlineCode))
            {
                query["airline_code"] = request.AirlineCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArrCityCode))
            {
                query["arr_city_code"] = request.ArrCityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArrCityName))
            {
                query["arr_city_name"] = request.ArrCityName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArrDate))
            {
                query["arr_date"] = request.ArrDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CabinClass))
            {
                query["cabin_class"] = request.CabinClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepCityCode))
            {
                query["dep_city_code"] = request.DepCityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepCityName))
            {
                query["dep_city_name"] = request.DepCityName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepDate))
            {
                query["dep_date"] = request.DepDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlightNo))
            {
                query["flight_no"] = request.FlightNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedMultiClassPrice))
            {
                query["need_multi_class_price"] = request.NeedMultiClassPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransferCityCode))
            {
                query["transfer_city_code"] = request.TransferCityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransferFlightNo))
            {
                query["transfer_flight_no"] = request.TransferFlightNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransferLeaveDate))
            {
                query["transfer_leave_date"] = request.TransferLeaveDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TripType))
            {
                query["trip_type"] = request.TripType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightSearchList",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/huge/dtb-flight/v1/flight/action/search-list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightSearchListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public FlightSearchListResponse FlightSearchList(FlightSearchListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightSearchListHeaders headers = new FlightSearchListHeaders();
            return FlightSearchListWithOptions(request, headers, runtime);
        }

        public async Task<FlightSearchListResponse> FlightSearchListAsync(FlightSearchListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightSearchListHeaders headers = new FlightSearchListHeaders();
            return await FlightSearchListWithOptionsAsync(request, headers, runtime);
        }

        public GroupCorpTokenResponse GroupCorpTokenWithOptions(GroupCorpTokenRequest request, GroupCorpTokenHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppSecret))
            {
                query["app_secret"] = request.AppSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corp_id"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                query["sub_corp_id"] = request.SubCorpId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripAccessToken))
            {
                realHeaders["x-acs-btrip-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GroupCorpToken",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/btrip-open-auth/v1/group-corp-token/action/take",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GroupCorpTokenResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GroupCorpTokenResponse> GroupCorpTokenWithOptionsAsync(GroupCorpTokenRequest request, GroupCorpTokenHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppSecret))
            {
                query["app_secret"] = request.AppSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corp_id"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                query["sub_corp_id"] = request.SubCorpId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripAccessToken))
            {
                realHeaders["x-acs-btrip-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GroupCorpToken",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/btrip-open-auth/v1/group-corp-token/action/take",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GroupCorpTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GroupCorpTokenResponse GroupCorpToken(GroupCorpTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GroupCorpTokenHeaders headers = new GroupCorpTokenHeaders();
            return GroupCorpTokenWithOptions(request, headers, runtime);
        }

        public async Task<GroupCorpTokenResponse> GroupCorpTokenAsync(GroupCorpTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GroupCorpTokenHeaders headers = new GroupCorpTokenHeaders();
            return await GroupCorpTokenWithOptionsAsync(request, headers, runtime);
        }

        public GroupDepartSaveResponse GroupDepartSaveWithOptions(GroupDepartSaveRequest tmpReq, GroupDepartSaveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GroupDepartSaveShrinkRequest request = new GroupDepartSaveShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SubCorpIdList))
            {
                request.SubCorpIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SubCorpIdList, "sub_corp_id_list", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptName))
            {
                body["dept_name"] = request.DeptName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagerIds))
            {
                body["manager_ids"] = request.ManagerIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterDeptId))
            {
                body["outer_dept_id"] = request.OuterDeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterDeptPid))
            {
                body["outer_dept_pid"] = request.OuterDeptPid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpIdListShrink))
            {
                body["sub_corp_id_list"] = request.SubCorpIdListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncGroup))
            {
                body["sync_group"] = request.SyncGroup;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GroupDepartSave",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/sub_corps/v1/departs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GroupDepartSaveResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GroupDepartSaveResponse> GroupDepartSaveWithOptionsAsync(GroupDepartSaveRequest tmpReq, GroupDepartSaveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GroupDepartSaveShrinkRequest request = new GroupDepartSaveShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SubCorpIdList))
            {
                request.SubCorpIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SubCorpIdList, "sub_corp_id_list", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptName))
            {
                body["dept_name"] = request.DeptName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagerIds))
            {
                body["manager_ids"] = request.ManagerIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterDeptId))
            {
                body["outer_dept_id"] = request.OuterDeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterDeptPid))
            {
                body["outer_dept_pid"] = request.OuterDeptPid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpIdListShrink))
            {
                body["sub_corp_id_list"] = request.SubCorpIdListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncGroup))
            {
                body["sync_group"] = request.SyncGroup;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GroupDepartSave",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/sub_corps/v1/departs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GroupDepartSaveResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GroupDepartSaveResponse GroupDepartSave(GroupDepartSaveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GroupDepartSaveHeaders headers = new GroupDepartSaveHeaders();
            return GroupDepartSaveWithOptions(request, headers, runtime);
        }

        public async Task<GroupDepartSaveResponse> GroupDepartSaveAsync(GroupDepartSaveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GroupDepartSaveHeaders headers = new GroupDepartSaveHeaders();
            return await GroupDepartSaveWithOptionsAsync(request, headers, runtime);
        }

        public GroupUserSaveResponse GroupUserSaveWithOptions(GroupUserSaveRequest tmpReq, GroupUserSaveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GroupUserSaveShrinkRequest request = new GroupUserSaveShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CertList))
            {
                request.CertListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CertList, "cert_list", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SubCorpIdList))
            {
                request.SubCorpIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SubCorpIdList, "sub_corp_id_list", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseCityCode))
            {
                body["base_city_code"] = request.BaseCityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Birthday))
            {
                body["birthday"] = request.Birthday;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertListShrink))
            {
                body["cert_list"] = request.CertListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Gender))
            {
                body["gender"] = request.Gender;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobNo))
            {
                body["job_no"] = request.JobNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                body["phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealNameEn))
            {
                body["real_name_en"] = request.RealNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpIdListShrink))
            {
                body["sub_corp_id_list"] = request.SubCorpIdListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["user_name"] = request.UserName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GroupUserSave",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/sub_corps/v1/users",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GroupUserSaveResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GroupUserSaveResponse> GroupUserSaveWithOptionsAsync(GroupUserSaveRequest tmpReq, GroupUserSaveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GroupUserSaveShrinkRequest request = new GroupUserSaveShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CertList))
            {
                request.CertListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CertList, "cert_list", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SubCorpIdList))
            {
                request.SubCorpIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SubCorpIdList, "sub_corp_id_list", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseCityCode))
            {
                body["base_city_code"] = request.BaseCityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Birthday))
            {
                body["birthday"] = request.Birthday;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertListShrink))
            {
                body["cert_list"] = request.CertListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Gender))
            {
                body["gender"] = request.Gender;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobNo))
            {
                body["job_no"] = request.JobNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                body["phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealNameEn))
            {
                body["real_name_en"] = request.RealNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpIdListShrink))
            {
                body["sub_corp_id_list"] = request.SubCorpIdListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["user_name"] = request.UserName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GroupUserSave",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/sub_corps/v1/users",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GroupUserSaveResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GroupUserSaveResponse GroupUserSave(GroupUserSaveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GroupUserSaveHeaders headers = new GroupUserSaveHeaders();
            return GroupUserSaveWithOptions(request, headers, runtime);
        }

        public async Task<GroupUserSaveResponse> GroupUserSaveAsync(GroupUserSaveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GroupUserSaveHeaders headers = new GroupUserSaveHeaders();
            return await GroupUserSaveWithOptionsAsync(request, headers, runtime);
        }

        public HotelAskingPriceResponse HotelAskingPriceWithOptions(HotelAskingPriceRequest tmpReq, HotelAskingPriceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            HotelAskingPriceShrinkRequest request = new HotelAskingPriceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Shids))
            {
                request.ShidsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Shids, "shids", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdultNum))
            {
                query["adult_num"] = request.AdultNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BtripUserId))
            {
                query["btrip_user_id"] = request.BtripUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckInDate))
            {
                query["check_in_date"] = request.CheckInDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckOutDate))
            {
                query["check_out_date"] = request.CheckOutDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CityCode))
            {
                query["city_code"] = request.CityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CityName))
            {
                query["city_name"] = request.CityName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dir))
            {
                query["dir"] = request.Dir;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelStar))
            {
                query["hotel_star"] = request.HotelStar;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsProtocol))
            {
                query["is_protocol"] = request.IsProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentType))
            {
                query["payment_type"] = request.PaymentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShidsShrink))
            {
                query["shids"] = request.ShidsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortCode))
            {
                query["sort_code"] = request.SortCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HotelAskingPrice",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-hotel/v1/hotels/action/asking-price",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<HotelAskingPriceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<HotelAskingPriceResponse> HotelAskingPriceWithOptionsAsync(HotelAskingPriceRequest tmpReq, HotelAskingPriceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            HotelAskingPriceShrinkRequest request = new HotelAskingPriceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Shids))
            {
                request.ShidsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Shids, "shids", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdultNum))
            {
                query["adult_num"] = request.AdultNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BtripUserId))
            {
                query["btrip_user_id"] = request.BtripUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckInDate))
            {
                query["check_in_date"] = request.CheckInDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckOutDate))
            {
                query["check_out_date"] = request.CheckOutDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CityCode))
            {
                query["city_code"] = request.CityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CityName))
            {
                query["city_name"] = request.CityName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dir))
            {
                query["dir"] = request.Dir;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelStar))
            {
                query["hotel_star"] = request.HotelStar;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsProtocol))
            {
                query["is_protocol"] = request.IsProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentType))
            {
                query["payment_type"] = request.PaymentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShidsShrink))
            {
                query["shids"] = request.ShidsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortCode))
            {
                query["sort_code"] = request.SortCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HotelAskingPrice",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-hotel/v1/hotels/action/asking-price",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<HotelAskingPriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public HotelAskingPriceResponse HotelAskingPrice(HotelAskingPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HotelAskingPriceHeaders headers = new HotelAskingPriceHeaders();
            return HotelAskingPriceWithOptions(request, headers, runtime);
        }

        public async Task<HotelAskingPriceResponse> HotelAskingPriceAsync(HotelAskingPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HotelAskingPriceHeaders headers = new HotelAskingPriceHeaders();
            return await HotelAskingPriceWithOptionsAsync(request, headers, runtime);
        }

        public HotelBillSettlementQueryResponse HotelBillSettlementQueryWithOptions(HotelBillSettlementQueryRequest request, HotelBillSettlementQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["page_no"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodEnd))
            {
                query["period_end"] = request.PeriodEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodStart))
            {
                query["period_start"] = request.PeriodStart;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HotelBillSettlementQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/hotel/v1/bill-settlement",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<HotelBillSettlementQueryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<HotelBillSettlementQueryResponse> HotelBillSettlementQueryWithOptionsAsync(HotelBillSettlementQueryRequest request, HotelBillSettlementQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["page_no"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodEnd))
            {
                query["period_end"] = request.PeriodEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodStart))
            {
                query["period_start"] = request.PeriodStart;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HotelBillSettlementQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/hotel/v1/bill-settlement",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<HotelBillSettlementQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public HotelBillSettlementQueryResponse HotelBillSettlementQuery(HotelBillSettlementQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HotelBillSettlementQueryHeaders headers = new HotelBillSettlementQueryHeaders();
            return HotelBillSettlementQueryWithOptions(request, headers, runtime);
        }

        public async Task<HotelBillSettlementQueryResponse> HotelBillSettlementQueryAsync(HotelBillSettlementQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HotelBillSettlementQueryHeaders headers = new HotelBillSettlementQueryHeaders();
            return await HotelBillSettlementQueryWithOptionsAsync(request, headers, runtime);
        }

        public HotelCityCodeListResponse HotelCityCodeListWithOptions(HotelCityCodeListRequest request, HotelCityCodeListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CountryCode))
            {
                query["country_code"] = request.CountryCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HotelCityCodeList",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-hotel/v1/city-codes/action/search",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<HotelCityCodeListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<HotelCityCodeListResponse> HotelCityCodeListWithOptionsAsync(HotelCityCodeListRequest request, HotelCityCodeListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CountryCode))
            {
                query["country_code"] = request.CountryCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HotelCityCodeList",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-hotel/v1/city-codes/action/search",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<HotelCityCodeListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public HotelCityCodeListResponse HotelCityCodeList(HotelCityCodeListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HotelCityCodeListHeaders headers = new HotelCityCodeListHeaders();
            return HotelCityCodeListWithOptions(request, headers, runtime);
        }

        public async Task<HotelCityCodeListResponse> HotelCityCodeListAsync(HotelCityCodeListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HotelCityCodeListHeaders headers = new HotelCityCodeListHeaders();
            return await HotelCityCodeListWithOptionsAsync(request, headers, runtime);
        }

        public HotelExceedApplyQueryResponse HotelExceedApplyQueryWithOptions(HotelExceedApplyQueryRequest request, HotelExceedApplyQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyId))
            {
                query["apply_id"] = request.ApplyId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HotelExceedApplyQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/apply/v1/hotel-exceed",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<HotelExceedApplyQueryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<HotelExceedApplyQueryResponse> HotelExceedApplyQueryWithOptionsAsync(HotelExceedApplyQueryRequest request, HotelExceedApplyQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyId))
            {
                query["apply_id"] = request.ApplyId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HotelExceedApplyQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/apply/v1/hotel-exceed",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<HotelExceedApplyQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public HotelExceedApplyQueryResponse HotelExceedApplyQuery(HotelExceedApplyQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HotelExceedApplyQueryHeaders headers = new HotelExceedApplyQueryHeaders();
            return HotelExceedApplyQueryWithOptions(request, headers, runtime);
        }

        public async Task<HotelExceedApplyQueryResponse> HotelExceedApplyQueryAsync(HotelExceedApplyQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HotelExceedApplyQueryHeaders headers = new HotelExceedApplyQueryHeaders();
            return await HotelExceedApplyQueryWithOptionsAsync(request, headers, runtime);
        }

        public HotelGoodsQueryResponse HotelGoodsQueryWithOptions(HotelGoodsQueryRequest request, HotelGoodsQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdultNum))
            {
                query["adult_num"] = request.AdultNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgreementPrice))
            {
                query["agreement_price"] = request.AgreementPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginDate))
            {
                query["begin_date"] = request.BeginDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BreakfastIncluded))
            {
                query["breakfast_included"] = request.BreakfastIncluded;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BtripUserId))
            {
                query["btrip_user_id"] = request.BtripUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CityCode))
            {
                query["city_code"] = request.CityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["end_date"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                query["hotel_id"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayOverType))
            {
                query["pay_over_type"] = request.PayOverType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentType))
            {
                query["payment_type"] = request.PaymentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecialInvoice))
            {
                query["special_invoice"] = request.SpecialInvoice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuperMan))
            {
                query["super_man"] = request.SuperMan;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HotelGoodsQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-hotel/v1/hotel-goods",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<HotelGoodsQueryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<HotelGoodsQueryResponse> HotelGoodsQueryWithOptionsAsync(HotelGoodsQueryRequest request, HotelGoodsQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdultNum))
            {
                query["adult_num"] = request.AdultNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgreementPrice))
            {
                query["agreement_price"] = request.AgreementPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginDate))
            {
                query["begin_date"] = request.BeginDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BreakfastIncluded))
            {
                query["breakfast_included"] = request.BreakfastIncluded;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BtripUserId))
            {
                query["btrip_user_id"] = request.BtripUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CityCode))
            {
                query["city_code"] = request.CityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["end_date"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                query["hotel_id"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayOverType))
            {
                query["pay_over_type"] = request.PayOverType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentType))
            {
                query["payment_type"] = request.PaymentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecialInvoice))
            {
                query["special_invoice"] = request.SpecialInvoice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuperMan))
            {
                query["super_man"] = request.SuperMan;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HotelGoodsQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-hotel/v1/hotel-goods",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<HotelGoodsQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public HotelGoodsQueryResponse HotelGoodsQuery(HotelGoodsQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HotelGoodsQueryHeaders headers = new HotelGoodsQueryHeaders();
            return HotelGoodsQueryWithOptions(request, headers, runtime);
        }

        public async Task<HotelGoodsQueryResponse> HotelGoodsQueryAsync(HotelGoodsQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HotelGoodsQueryHeaders headers = new HotelGoodsQueryHeaders();
            return await HotelGoodsQueryWithOptionsAsync(request, headers, runtime);
        }

        public HotelIndexInfoResponse HotelIndexInfoWithOptions(HotelIndexInfoRequest request, HotelIndexInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CityCode))
            {
                query["city_code"] = request.CityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelStatus))
            {
                query["hotel_status"] = request.HotelStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["page_token"] = request.PageToken;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HotelIndexInfo",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-hotel/v1/index-infos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<HotelIndexInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<HotelIndexInfoResponse> HotelIndexInfoWithOptionsAsync(HotelIndexInfoRequest request, HotelIndexInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CityCode))
            {
                query["city_code"] = request.CityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelStatus))
            {
                query["hotel_status"] = request.HotelStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["page_token"] = request.PageToken;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HotelIndexInfo",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-hotel/v1/index-infos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<HotelIndexInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public HotelIndexInfoResponse HotelIndexInfo(HotelIndexInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HotelIndexInfoHeaders headers = new HotelIndexInfoHeaders();
            return HotelIndexInfoWithOptions(request, headers, runtime);
        }

        public async Task<HotelIndexInfoResponse> HotelIndexInfoAsync(HotelIndexInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HotelIndexInfoHeaders headers = new HotelIndexInfoHeaders();
            return await HotelIndexInfoWithOptionsAsync(request, headers, runtime);
        }

        public HotelOrderCancelResponse HotelOrderCancelWithOptions(HotelOrderCancelRequest request, HotelOrderCancelHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BtripOrderId))
            {
                query["btrip_order_id"] = request.BtripOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisOrderId))
            {
                query["dis_order_id"] = request.DisOrderId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HotelOrderCancel",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-hotel/v1/orders/action/cancel",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<HotelOrderCancelResponse>(CallApi(params_, req, runtime));
        }

        public async Task<HotelOrderCancelResponse> HotelOrderCancelWithOptionsAsync(HotelOrderCancelRequest request, HotelOrderCancelHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BtripOrderId))
            {
                query["btrip_order_id"] = request.BtripOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisOrderId))
            {
                query["dis_order_id"] = request.DisOrderId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HotelOrderCancel",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-hotel/v1/orders/action/cancel",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<HotelOrderCancelResponse>(await CallApiAsync(params_, req, runtime));
        }

        public HotelOrderCancelResponse HotelOrderCancel(HotelOrderCancelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HotelOrderCancelHeaders headers = new HotelOrderCancelHeaders();
            return HotelOrderCancelWithOptions(request, headers, runtime);
        }

        public async Task<HotelOrderCancelResponse> HotelOrderCancelAsync(HotelOrderCancelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HotelOrderCancelHeaders headers = new HotelOrderCancelHeaders();
            return await HotelOrderCancelWithOptionsAsync(request, headers, runtime);
        }

        public HotelOrderCreateResponse HotelOrderCreateWithOptions(HotelOrderCreateRequest tmpReq, HotelOrderCreateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            HotelOrderCreateShrinkRequest request = new HotelOrderCreateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InvoiceInfo))
            {
                request.InvoiceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InvoiceInfo, "invoice_info", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OccupantInfoList))
            {
                request.OccupantInfoListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OccupantInfoList, "occupant_info_list", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PromotionInfo))
            {
                request.PromotionInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PromotionInfo, "promotion_info", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BtripUserId))
            {
                body["btrip_user_id"] = request.BtripUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckIn))
            {
                body["check_in"] = request.CheckIn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckOut))
            {
                body["check_out"] = request.CheckOut;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractEmail))
            {
                body["contract_email"] = request.ContractEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractName))
            {
                body["contract_name"] = request.ContractName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractPhone))
            {
                body["contract_phone"] = request.ContractPhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpPayPrice))
            {
                body["corp_pay_price"] = request.CorpPayPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisOrderId))
            {
                body["dis_order_id"] = request.DisOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extra))
            {
                body["extra"] = request.Extra;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceInfoShrink))
            {
                body["invoice_info"] = request.InvoiceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                body["item_id"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItineraryNo))
            {
                body["itinerary_no"] = request.ItineraryNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OccupantInfoListShrink))
            {
                body["occupant_info_list"] = request.OccupantInfoListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersonPayPrice))
            {
                body["person_pay_price"] = request.PersonPayPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionInfoShrink))
            {
                body["promotion_info"] = request.PromotionInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RatePlanId))
            {
                body["rate_plan_id"] = request.RatePlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomId))
            {
                body["room_id"] = request.RoomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomNum))
            {
                body["room_num"] = request.RoomNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SellerId))
            {
                body["seller_id"] = request.SellerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Shid))
            {
                body["shid"] = request.Shid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalOrderPrice))
            {
                body["total_order_price"] = request.TotalOrderPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidateResKey))
            {
                body["validate_res_key"] = request.ValidateResKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HotelOrderCreate",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-hotel/v1/orders/action/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<HotelOrderCreateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<HotelOrderCreateResponse> HotelOrderCreateWithOptionsAsync(HotelOrderCreateRequest tmpReq, HotelOrderCreateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            HotelOrderCreateShrinkRequest request = new HotelOrderCreateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InvoiceInfo))
            {
                request.InvoiceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InvoiceInfo, "invoice_info", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OccupantInfoList))
            {
                request.OccupantInfoListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OccupantInfoList, "occupant_info_list", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PromotionInfo))
            {
                request.PromotionInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PromotionInfo, "promotion_info", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BtripUserId))
            {
                body["btrip_user_id"] = request.BtripUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckIn))
            {
                body["check_in"] = request.CheckIn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckOut))
            {
                body["check_out"] = request.CheckOut;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractEmail))
            {
                body["contract_email"] = request.ContractEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractName))
            {
                body["contract_name"] = request.ContractName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractPhone))
            {
                body["contract_phone"] = request.ContractPhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpPayPrice))
            {
                body["corp_pay_price"] = request.CorpPayPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisOrderId))
            {
                body["dis_order_id"] = request.DisOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extra))
            {
                body["extra"] = request.Extra;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceInfoShrink))
            {
                body["invoice_info"] = request.InvoiceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                body["item_id"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItineraryNo))
            {
                body["itinerary_no"] = request.ItineraryNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OccupantInfoListShrink))
            {
                body["occupant_info_list"] = request.OccupantInfoListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersonPayPrice))
            {
                body["person_pay_price"] = request.PersonPayPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionInfoShrink))
            {
                body["promotion_info"] = request.PromotionInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RatePlanId))
            {
                body["rate_plan_id"] = request.RatePlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomId))
            {
                body["room_id"] = request.RoomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomNum))
            {
                body["room_num"] = request.RoomNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SellerId))
            {
                body["seller_id"] = request.SellerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Shid))
            {
                body["shid"] = request.Shid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalOrderPrice))
            {
                body["total_order_price"] = request.TotalOrderPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidateResKey))
            {
                body["validate_res_key"] = request.ValidateResKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HotelOrderCreate",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-hotel/v1/orders/action/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<HotelOrderCreateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public HotelOrderCreateResponse HotelOrderCreate(HotelOrderCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HotelOrderCreateHeaders headers = new HotelOrderCreateHeaders();
            return HotelOrderCreateWithOptions(request, headers, runtime);
        }

        public async Task<HotelOrderCreateResponse> HotelOrderCreateAsync(HotelOrderCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HotelOrderCreateHeaders headers = new HotelOrderCreateHeaders();
            return await HotelOrderCreateWithOptionsAsync(request, headers, runtime);
        }

        public HotelOrderDetailInfoResponse HotelOrderDetailInfoWithOptions(HotelOrderDetailInfoRequest request, HotelOrderDetailInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BtripOrderId))
            {
                query["btrip_order_id"] = request.BtripOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisOrderId))
            {
                query["dis_order_id"] = request.DisOrderId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HotelOrderDetailInfo",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-hotel/v1/orders/action/detail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<HotelOrderDetailInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<HotelOrderDetailInfoResponse> HotelOrderDetailInfoWithOptionsAsync(HotelOrderDetailInfoRequest request, HotelOrderDetailInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BtripOrderId))
            {
                query["btrip_order_id"] = request.BtripOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisOrderId))
            {
                query["dis_order_id"] = request.DisOrderId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HotelOrderDetailInfo",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-hotel/v1/orders/action/detail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<HotelOrderDetailInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public HotelOrderDetailInfoResponse HotelOrderDetailInfo(HotelOrderDetailInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HotelOrderDetailInfoHeaders headers = new HotelOrderDetailInfoHeaders();
            return HotelOrderDetailInfoWithOptions(request, headers, runtime);
        }

        public async Task<HotelOrderDetailInfoResponse> HotelOrderDetailInfoAsync(HotelOrderDetailInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HotelOrderDetailInfoHeaders headers = new HotelOrderDetailInfoHeaders();
            return await HotelOrderDetailInfoWithOptionsAsync(request, headers, runtime);
        }

        public HotelOrderListQueryResponse HotelOrderListQueryWithOptions(HotelOrderListQueryRequest request, HotelOrderListQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllApply))
            {
                query["all_apply"] = request.AllApply;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyId))
            {
                query["apply_id"] = request.ApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartId))
            {
                query["depart_id"] = request.DepartId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["end_time"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["start_time"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartApplyId))
            {
                query["thirdpart_apply_id"] = request.ThirdpartApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateEndTime))
            {
                query["update_end_time"] = request.UpdateEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateStartTime))
            {
                query["update_start_time"] = request.UpdateStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["user_id"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HotelOrderListQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/hotel/v1/order-list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<HotelOrderListQueryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<HotelOrderListQueryResponse> HotelOrderListQueryWithOptionsAsync(HotelOrderListQueryRequest request, HotelOrderListQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllApply))
            {
                query["all_apply"] = request.AllApply;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyId))
            {
                query["apply_id"] = request.ApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartId))
            {
                query["depart_id"] = request.DepartId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["end_time"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["start_time"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartApplyId))
            {
                query["thirdpart_apply_id"] = request.ThirdpartApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateEndTime))
            {
                query["update_end_time"] = request.UpdateEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateStartTime))
            {
                query["update_start_time"] = request.UpdateStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["user_id"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HotelOrderListQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/hotel/v1/order-list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<HotelOrderListQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public HotelOrderListQueryResponse HotelOrderListQuery(HotelOrderListQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HotelOrderListQueryHeaders headers = new HotelOrderListQueryHeaders();
            return HotelOrderListQueryWithOptions(request, headers, runtime);
        }

        public async Task<HotelOrderListQueryResponse> HotelOrderListQueryAsync(HotelOrderListQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HotelOrderListQueryHeaders headers = new HotelOrderListQueryHeaders();
            return await HotelOrderListQueryWithOptionsAsync(request, headers, runtime);
        }

        public HotelOrderPayResponse HotelOrderPayWithOptions(HotelOrderPayRequest request, HotelOrderPayHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BtripOrderId))
            {
                body["btrip_order_id"] = request.BtripOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BtripUserId))
            {
                body["btrip_user_id"] = request.BtripUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyPayFee))
            {
                body["company_pay_fee"] = request.CompanyPayFee;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersonPayFee))
            {
                body["person_pay_fee"] = request.PersonPayFee;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPayAccount))
            {
                body["third_pay_account"] = request.ThirdPayAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdTradeNo))
            {
                body["third_trade_no"] = request.ThirdTradeNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalPrice))
            {
                body["total_price"] = request.TotalPrice;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HotelOrderPay",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-hotel/v1/orders/action/pay",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<HotelOrderPayResponse>(CallApi(params_, req, runtime));
        }

        public async Task<HotelOrderPayResponse> HotelOrderPayWithOptionsAsync(HotelOrderPayRequest request, HotelOrderPayHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BtripOrderId))
            {
                body["btrip_order_id"] = request.BtripOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BtripUserId))
            {
                body["btrip_user_id"] = request.BtripUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyPayFee))
            {
                body["company_pay_fee"] = request.CompanyPayFee;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersonPayFee))
            {
                body["person_pay_fee"] = request.PersonPayFee;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPayAccount))
            {
                body["third_pay_account"] = request.ThirdPayAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdTradeNo))
            {
                body["third_trade_no"] = request.ThirdTradeNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalPrice))
            {
                body["total_price"] = request.TotalPrice;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HotelOrderPay",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-hotel/v1/orders/action/pay",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<HotelOrderPayResponse>(await CallApiAsync(params_, req, runtime));
        }

        public HotelOrderPayResponse HotelOrderPay(HotelOrderPayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HotelOrderPayHeaders headers = new HotelOrderPayHeaders();
            return HotelOrderPayWithOptions(request, headers, runtime);
        }

        public async Task<HotelOrderPayResponse> HotelOrderPayAsync(HotelOrderPayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HotelOrderPayHeaders headers = new HotelOrderPayHeaders();
            return await HotelOrderPayWithOptionsAsync(request, headers, runtime);
        }

        public HotelOrderPreValidateResponse HotelOrderPreValidateWithOptions(HotelOrderPreValidateRequest tmpReq, HotelOrderPreValidateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            HotelOrderPreValidateShrinkRequest request = new HotelOrderPreValidateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DailyList))
            {
                request.DailyListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DailyList, "daily_list", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OccupantInfoList))
            {
                request.OccupantInfoListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OccupantInfoList, "occupant_info_list", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BtripUserId))
            {
                query["btrip_user_id"] = request.BtripUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckIn))
            {
                query["check_in"] = request.CheckIn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckOut))
            {
                query["check_out"] = request.CheckOut;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DailyListShrink))
            {
                query["daily_list"] = request.DailyListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                query["item_id"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumberOfAdultsPerRoom))
            {
                query["number_of_adults_per_room"] = request.NumberOfAdultsPerRoom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OccupantInfoListShrink))
            {
                query["occupant_info_list"] = request.OccupantInfoListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RatePlanId))
            {
                query["rate_plan_id"] = request.RatePlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomId))
            {
                query["room_id"] = request.RoomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomNum))
            {
                query["room_num"] = request.RoomNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchRoomPrice))
            {
                query["search_room_price"] = request.SearchRoomPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SellerId))
            {
                query["seller_id"] = request.SellerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Shid))
            {
                query["shid"] = request.Shid;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HotelOrderPreValidate",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-hotel/v1/orders/action/pre-validate",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<HotelOrderPreValidateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<HotelOrderPreValidateResponse> HotelOrderPreValidateWithOptionsAsync(HotelOrderPreValidateRequest tmpReq, HotelOrderPreValidateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            HotelOrderPreValidateShrinkRequest request = new HotelOrderPreValidateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DailyList))
            {
                request.DailyListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DailyList, "daily_list", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OccupantInfoList))
            {
                request.OccupantInfoListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OccupantInfoList, "occupant_info_list", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BtripUserId))
            {
                query["btrip_user_id"] = request.BtripUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckIn))
            {
                query["check_in"] = request.CheckIn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckOut))
            {
                query["check_out"] = request.CheckOut;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DailyListShrink))
            {
                query["daily_list"] = request.DailyListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                query["item_id"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumberOfAdultsPerRoom))
            {
                query["number_of_adults_per_room"] = request.NumberOfAdultsPerRoom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OccupantInfoListShrink))
            {
                query["occupant_info_list"] = request.OccupantInfoListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RatePlanId))
            {
                query["rate_plan_id"] = request.RatePlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomId))
            {
                query["room_id"] = request.RoomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomNum))
            {
                query["room_num"] = request.RoomNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchRoomPrice))
            {
                query["search_room_price"] = request.SearchRoomPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SellerId))
            {
                query["seller_id"] = request.SellerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Shid))
            {
                query["shid"] = request.Shid;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HotelOrderPreValidate",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-hotel/v1/orders/action/pre-validate",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<HotelOrderPreValidateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public HotelOrderPreValidateResponse HotelOrderPreValidate(HotelOrderPreValidateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HotelOrderPreValidateHeaders headers = new HotelOrderPreValidateHeaders();
            return HotelOrderPreValidateWithOptions(request, headers, runtime);
        }

        public async Task<HotelOrderPreValidateResponse> HotelOrderPreValidateAsync(HotelOrderPreValidateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HotelOrderPreValidateHeaders headers = new HotelOrderPreValidateHeaders();
            return await HotelOrderPreValidateWithOptionsAsync(request, headers, runtime);
        }

        public HotelOrderQueryResponse HotelOrderQueryWithOptions(HotelOrderQueryRequest request, HotelOrderQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["order_id"] = request.OrderId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HotelOrderQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/hotel/v1/order",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<HotelOrderQueryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<HotelOrderQueryResponse> HotelOrderQueryWithOptionsAsync(HotelOrderQueryRequest request, HotelOrderQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["order_id"] = request.OrderId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HotelOrderQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/hotel/v1/order",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<HotelOrderQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public HotelOrderQueryResponse HotelOrderQuery(HotelOrderQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HotelOrderQueryHeaders headers = new HotelOrderQueryHeaders();
            return HotelOrderQueryWithOptions(request, headers, runtime);
        }

        public async Task<HotelOrderQueryResponse> HotelOrderQueryAsync(HotelOrderQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HotelOrderQueryHeaders headers = new HotelOrderQueryHeaders();
            return await HotelOrderQueryWithOptionsAsync(request, headers, runtime);
        }

        public HotelPricePullResponse HotelPricePullWithOptions(HotelPricePullRequest tmpReq, HotelPricePullHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            HotelPricePullShrinkRequest request = new HotelPricePullShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HotelIds))
            {
                request.HotelIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HotelIds, "hotel_ids", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BtripUserId))
            {
                query["btrip_user_id"] = request.BtripUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckIn))
            {
                query["check_in"] = request.CheckIn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckOut))
            {
                query["check_out"] = request.CheckOut;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CityCode))
            {
                query["city_code"] = request.CityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelIdsShrink))
            {
                query["hotel_ids"] = request.HotelIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentType))
            {
                query["payment_type"] = request.PaymentType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HotelPricePull",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-hotel/v1/prices/action/pull",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<HotelPricePullResponse>(CallApi(params_, req, runtime));
        }

        public async Task<HotelPricePullResponse> HotelPricePullWithOptionsAsync(HotelPricePullRequest tmpReq, HotelPricePullHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            HotelPricePullShrinkRequest request = new HotelPricePullShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HotelIds))
            {
                request.HotelIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HotelIds, "hotel_ids", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BtripUserId))
            {
                query["btrip_user_id"] = request.BtripUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckIn))
            {
                query["check_in"] = request.CheckIn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckOut))
            {
                query["check_out"] = request.CheckOut;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CityCode))
            {
                query["city_code"] = request.CityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelIdsShrink))
            {
                query["hotel_ids"] = request.HotelIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentType))
            {
                query["payment_type"] = request.PaymentType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HotelPricePull",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-hotel/v1/prices/action/pull",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<HotelPricePullResponse>(await CallApiAsync(params_, req, runtime));
        }

        public HotelPricePullResponse HotelPricePull(HotelPricePullRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HotelPricePullHeaders headers = new HotelPricePullHeaders();
            return HotelPricePullWithOptions(request, headers, runtime);
        }

        public async Task<HotelPricePullResponse> HotelPricePullAsync(HotelPricePullRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HotelPricePullHeaders headers = new HotelPricePullHeaders();
            return await HotelPricePullWithOptionsAsync(request, headers, runtime);
        }

        public HotelRoomInfoResponse HotelRoomInfoWithOptions(HotelRoomInfoRequest tmpReq, HotelRoomInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            HotelRoomInfoShrinkRequest request = new HotelRoomInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RoomIds))
            {
                request.RoomIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RoomIds, "room_ids", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomIdsShrink))
            {
                query["room_ids"] = request.RoomIdsShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HotelRoomInfo",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-hotel/v1/room-infos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<HotelRoomInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<HotelRoomInfoResponse> HotelRoomInfoWithOptionsAsync(HotelRoomInfoRequest tmpReq, HotelRoomInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            HotelRoomInfoShrinkRequest request = new HotelRoomInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RoomIds))
            {
                request.RoomIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RoomIds, "room_ids", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomIdsShrink))
            {
                query["room_ids"] = request.RoomIdsShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HotelRoomInfo",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-hotel/v1/room-infos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<HotelRoomInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public HotelRoomInfoResponse HotelRoomInfo(HotelRoomInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HotelRoomInfoHeaders headers = new HotelRoomInfoHeaders();
            return HotelRoomInfoWithOptions(request, headers, runtime);
        }

        public async Task<HotelRoomInfoResponse> HotelRoomInfoAsync(HotelRoomInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HotelRoomInfoHeaders headers = new HotelRoomInfoHeaders();
            return await HotelRoomInfoWithOptionsAsync(request, headers, runtime);
        }

        public HotelSearchResponse HotelSearchWithOptions(HotelSearchRequest tmpReq, HotelSearchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            HotelSearchShrinkRequest request = new HotelSearchShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.BrandCode))
            {
                request.BrandCodeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.BrandCode, "brand_code", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Shids))
            {
                request.ShidsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Shids, "shids", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdultNum))
            {
                query["adult_num"] = request.AdultNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BrandCodeShrink))
            {
                query["brand_code"] = request.BrandCodeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BtripUserId))
            {
                query["btrip_user_id"] = request.BtripUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckInDate))
            {
                query["check_in_date"] = request.CheckInDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckOutDate))
            {
                query["check_out_date"] = request.CheckOutDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CityCode))
            {
                query["city_code"] = request.CityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dir))
            {
                query["dir"] = request.Dir;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Distance))
            {
                query["distance"] = request.Distance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistrictCode))
            {
                query["district_code"] = request.DistrictCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelStar))
            {
                query["hotel_star"] = request.HotelStar;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsProtocol))
            {
                query["is_protocol"] = request.IsProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWords))
            {
                query["key_words"] = request.KeyWords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                query["location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxPrice))
            {
                query["max_price"] = request.MaxPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinPrice))
            {
                query["min_price"] = request.MinPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["page_no"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayOverType))
            {
                query["pay_over_type"] = request.PayOverType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentType))
            {
                query["payment_type"] = request.PaymentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShidsShrink))
            {
                query["shids"] = request.ShidsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortCode))
            {
                query["sort_code"] = request.SortCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuperMan))
            {
                query["super_man"] = request.SuperMan;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HotelSearch",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-hotel/v1/hotels/action/search",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<HotelSearchResponse>(CallApi(params_, req, runtime));
        }

        public async Task<HotelSearchResponse> HotelSearchWithOptionsAsync(HotelSearchRequest tmpReq, HotelSearchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            HotelSearchShrinkRequest request = new HotelSearchShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.BrandCode))
            {
                request.BrandCodeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.BrandCode, "brand_code", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Shids))
            {
                request.ShidsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Shids, "shids", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdultNum))
            {
                query["adult_num"] = request.AdultNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BrandCodeShrink))
            {
                query["brand_code"] = request.BrandCodeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BtripUserId))
            {
                query["btrip_user_id"] = request.BtripUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckInDate))
            {
                query["check_in_date"] = request.CheckInDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckOutDate))
            {
                query["check_out_date"] = request.CheckOutDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CityCode))
            {
                query["city_code"] = request.CityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dir))
            {
                query["dir"] = request.Dir;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Distance))
            {
                query["distance"] = request.Distance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistrictCode))
            {
                query["district_code"] = request.DistrictCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelStar))
            {
                query["hotel_star"] = request.HotelStar;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsProtocol))
            {
                query["is_protocol"] = request.IsProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWords))
            {
                query["key_words"] = request.KeyWords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                query["location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxPrice))
            {
                query["max_price"] = request.MaxPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinPrice))
            {
                query["min_price"] = request.MinPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["page_no"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayOverType))
            {
                query["pay_over_type"] = request.PayOverType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentType))
            {
                query["payment_type"] = request.PaymentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShidsShrink))
            {
                query["shids"] = request.ShidsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortCode))
            {
                query["sort_code"] = request.SortCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuperMan))
            {
                query["super_man"] = request.SuperMan;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HotelSearch",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-hotel/v1/hotels/action/search",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<HotelSearchResponse>(await CallApiAsync(params_, req, runtime));
        }

        public HotelSearchResponse HotelSearch(HotelSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HotelSearchHeaders headers = new HotelSearchHeaders();
            return HotelSearchWithOptions(request, headers, runtime);
        }

        public async Task<HotelSearchResponse> HotelSearchAsync(HotelSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HotelSearchHeaders headers = new HotelSearchHeaders();
            return await HotelSearchWithOptionsAsync(request, headers, runtime);
        }

        public HotelStaticInfoResponse HotelStaticInfoWithOptions(HotelStaticInfoRequest tmpReq, HotelStaticInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            HotelStaticInfoShrinkRequest request = new HotelStaticInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HotelIds))
            {
                request.HotelIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HotelIds, "hotel_ids", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelIdsShrink))
            {
                query["hotel_ids"] = request.HotelIdsShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HotelStaticInfo",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-hotel/v1/static-infos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<HotelStaticInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<HotelStaticInfoResponse> HotelStaticInfoWithOptionsAsync(HotelStaticInfoRequest tmpReq, HotelStaticInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            HotelStaticInfoShrinkRequest request = new HotelStaticInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HotelIds))
            {
                request.HotelIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HotelIds, "hotel_ids", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelIdsShrink))
            {
                query["hotel_ids"] = request.HotelIdsShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HotelStaticInfo",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-hotel/v1/static-infos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<HotelStaticInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public HotelStaticInfoResponse HotelStaticInfo(HotelStaticInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HotelStaticInfoHeaders headers = new HotelStaticInfoHeaders();
            return HotelStaticInfoWithOptions(request, headers, runtime);
        }

        public async Task<HotelStaticInfoResponse> HotelStaticInfoAsync(HotelStaticInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HotelStaticInfoHeaders headers = new HotelStaticInfoHeaders();
            return await HotelStaticInfoWithOptionsAsync(request, headers, runtime);
        }

        public IeFlightBillSettlementQueryResponse IeFlightBillSettlementQueryWithOptions(IeFlightBillSettlementQueryRequest request, IeFlightBillSettlementQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["page_no"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodEnd))
            {
                query["period_end"] = request.PeriodEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodStart))
            {
                query["period_start"] = request.PeriodStart;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IeFlightBillSettlementQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/ie-flight/v1/bill-settlement",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<IeFlightBillSettlementQueryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<IeFlightBillSettlementQueryResponse> IeFlightBillSettlementQueryWithOptionsAsync(IeFlightBillSettlementQueryRequest request, IeFlightBillSettlementQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["page_no"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodEnd))
            {
                query["period_end"] = request.PeriodEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodStart))
            {
                query["period_start"] = request.PeriodStart;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IeFlightBillSettlementQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/ie-flight/v1/bill-settlement",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<IeFlightBillSettlementQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public IeFlightBillSettlementQueryResponse IeFlightBillSettlementQuery(IeFlightBillSettlementQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IeFlightBillSettlementQueryHeaders headers = new IeFlightBillSettlementQueryHeaders();
            return IeFlightBillSettlementQueryWithOptions(request, headers, runtime);
        }

        public async Task<IeFlightBillSettlementQueryResponse> IeFlightBillSettlementQueryAsync(IeFlightBillSettlementQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IeFlightBillSettlementQueryHeaders headers = new IeFlightBillSettlementQueryHeaders();
            return await IeFlightBillSettlementQueryWithOptionsAsync(request, headers, runtime);
        }

        public IeHotelBillSettlementQueryResponse IeHotelBillSettlementQueryWithOptions(IeHotelBillSettlementQueryRequest request, IeHotelBillSettlementQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["page_no"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodEnd))
            {
                query["period_end"] = request.PeriodEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodStart))
            {
                query["period_start"] = request.PeriodStart;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IeHotelBillSettlementQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/ie-hotel/v1/bill-settlement",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<IeHotelBillSettlementQueryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<IeHotelBillSettlementQueryResponse> IeHotelBillSettlementQueryWithOptionsAsync(IeHotelBillSettlementQueryRequest request, IeHotelBillSettlementQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["page_no"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodEnd))
            {
                query["period_end"] = request.PeriodEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodStart))
            {
                query["period_start"] = request.PeriodStart;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IeHotelBillSettlementQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/ie-hotel/v1/bill-settlement",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<IeHotelBillSettlementQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public IeHotelBillSettlementQueryResponse IeHotelBillSettlementQuery(IeHotelBillSettlementQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IeHotelBillSettlementQueryHeaders headers = new IeHotelBillSettlementQueryHeaders();
            return IeHotelBillSettlementQueryWithOptions(request, headers, runtime);
        }

        public async Task<IeHotelBillSettlementQueryResponse> IeHotelBillSettlementQueryAsync(IeHotelBillSettlementQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IeHotelBillSettlementQueryHeaders headers = new IeHotelBillSettlementQueryHeaders();
            return await IeHotelBillSettlementQueryWithOptionsAsync(request, headers, runtime);
        }

        public InsInvoiceScanQueryResponse InsInvoiceScanQueryWithOptions(InsInvoiceScanQueryRequest request, InsInvoiceScanQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillDate))
            {
                query["bill_date"] = request.BillDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillId))
            {
                query["bill_id"] = request.BillId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceSubTaskId))
            {
                query["invoice_sub_task_id"] = request.InvoiceSubTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["page_no"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsInvoiceScanQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/scan/v1/ins-invoice",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsInvoiceScanQueryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InsInvoiceScanQueryResponse> InsInvoiceScanQueryWithOptionsAsync(InsInvoiceScanQueryRequest request, InsInvoiceScanQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillDate))
            {
                query["bill_date"] = request.BillDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillId))
            {
                query["bill_id"] = request.BillId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceSubTaskId))
            {
                query["invoice_sub_task_id"] = request.InvoiceSubTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["page_no"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsInvoiceScanQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/scan/v1/ins-invoice",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsInvoiceScanQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public InsInvoiceScanQueryResponse InsInvoiceScanQuery(InsInvoiceScanQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsInvoiceScanQueryHeaders headers = new InsInvoiceScanQueryHeaders();
            return InsInvoiceScanQueryWithOptions(request, headers, runtime);
        }

        public async Task<InsInvoiceScanQueryResponse> InsInvoiceScanQueryAsync(InsInvoiceScanQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsInvoiceScanQueryHeaders headers = new InsInvoiceScanQueryHeaders();
            return await InsInvoiceScanQueryWithOptionsAsync(request, headers, runtime);
        }

        public InsureOrderApplyResponse InsureOrderApplyWithOptions(InsureOrderApplyRequest request, InsureOrderApplyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BtripUserId))
            {
                body["btrip_user_id"] = request.BtripUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyerName))
            {
                body["buyer_name"] = request.BuyerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InsOrderId))
            {
                body["ins_order_id"] = request.InsOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                body["isv_name"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutOrderId))
            {
                body["out_order_id"] = request.OutOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutSubOrderId))
            {
                body["out_sub_order_id"] = request.OutSubOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplierCode))
            {
                body["supplier_code"] = request.SupplierCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsureOrderApply",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v1/insurances/action/apply",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsureOrderApplyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InsureOrderApplyResponse> InsureOrderApplyWithOptionsAsync(InsureOrderApplyRequest request, InsureOrderApplyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BtripUserId))
            {
                body["btrip_user_id"] = request.BtripUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyerName))
            {
                body["buyer_name"] = request.BuyerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InsOrderId))
            {
                body["ins_order_id"] = request.InsOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                body["isv_name"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutOrderId))
            {
                body["out_order_id"] = request.OutOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutSubOrderId))
            {
                body["out_sub_order_id"] = request.OutSubOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplierCode))
            {
                body["supplier_code"] = request.SupplierCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsureOrderApply",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v1/insurances/action/apply",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsureOrderApplyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public InsureOrderApplyResponse InsureOrderApply(InsureOrderApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsureOrderApplyHeaders headers = new InsureOrderApplyHeaders();
            return InsureOrderApplyWithOptions(request, headers, runtime);
        }

        public async Task<InsureOrderApplyResponse> InsureOrderApplyAsync(InsureOrderApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsureOrderApplyHeaders headers = new InsureOrderApplyHeaders();
            return await InsureOrderApplyWithOptionsAsync(request, headers, runtime);
        }

        public InsureOrderCancelResponse InsureOrderCancelWithOptions(string insOrderId, InsureOrderCancelRequest request, InsureOrderCancelHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BtripUserId))
            {
                query["btrip_user_id"] = request.BtripUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyerName))
            {
                query["buyer_name"] = request.BuyerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                query["isv_name"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplierCode))
            {
                query["supplier_code"] = request.SupplierCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsureOrderCancel",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v1/insurances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(insOrderId) + "/action/cancel",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsureOrderCancelResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InsureOrderCancelResponse> InsureOrderCancelWithOptionsAsync(string insOrderId, InsureOrderCancelRequest request, InsureOrderCancelHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BtripUserId))
            {
                query["btrip_user_id"] = request.BtripUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyerName))
            {
                query["buyer_name"] = request.BuyerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                query["isv_name"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplierCode))
            {
                query["supplier_code"] = request.SupplierCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsureOrderCancel",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v1/insurances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(insOrderId) + "/action/cancel",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsureOrderCancelResponse>(await CallApiAsync(params_, req, runtime));
        }

        public InsureOrderCancelResponse InsureOrderCancel(string insOrderId, InsureOrderCancelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsureOrderCancelHeaders headers = new InsureOrderCancelHeaders();
            return InsureOrderCancelWithOptions(insOrderId, request, headers, runtime);
        }

        public async Task<InsureOrderCancelResponse> InsureOrderCancelAsync(string insOrderId, InsureOrderCancelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsureOrderCancelHeaders headers = new InsureOrderCancelHeaders();
            return await InsureOrderCancelWithOptionsAsync(insOrderId, request, headers, runtime);
        }

        public InsureOrderCreateResponse InsureOrderCreateWithOptions(InsureOrderCreateRequest tmpReq, InsureOrderCreateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InsureOrderCreateShrinkRequest request = new InsureOrderCreateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Applicant))
            {
                request.ApplicantShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Applicant, "applicant", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InsPersonAndSegmentList))
            {
                request.InsPersonAndSegmentListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InsPersonAndSegmentList, "ins_person_and_segment_list", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantShrink))
            {
                body["applicant"] = request.ApplicantShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BtripUserId))
            {
                body["btrip_user_id"] = request.BtripUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyerName))
            {
                body["buyer_name"] = request.BuyerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InsPersonAndSegmentListShrink))
            {
                body["ins_person_and_segment_list"] = request.InsPersonAndSegmentListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                body["isv_name"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutInsOrderId))
            {
                body["out_ins_order_id"] = request.OutInsOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutOrderId))
            {
                body["out_order_id"] = request.OutOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutSubOrderId))
            {
                body["out_sub_order_id"] = request.OutSubOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplierCode))
            {
                body["supplier_code"] = request.SupplierCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsureOrderCreate",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v1/insurances/action/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsureOrderCreateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InsureOrderCreateResponse> InsureOrderCreateWithOptionsAsync(InsureOrderCreateRequest tmpReq, InsureOrderCreateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InsureOrderCreateShrinkRequest request = new InsureOrderCreateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Applicant))
            {
                request.ApplicantShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Applicant, "applicant", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InsPersonAndSegmentList))
            {
                request.InsPersonAndSegmentListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InsPersonAndSegmentList, "ins_person_and_segment_list", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantShrink))
            {
                body["applicant"] = request.ApplicantShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BtripUserId))
            {
                body["btrip_user_id"] = request.BtripUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyerName))
            {
                body["buyer_name"] = request.BuyerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InsPersonAndSegmentListShrink))
            {
                body["ins_person_and_segment_list"] = request.InsPersonAndSegmentListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                body["isv_name"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutInsOrderId))
            {
                body["out_ins_order_id"] = request.OutInsOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutOrderId))
            {
                body["out_order_id"] = request.OutOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutSubOrderId))
            {
                body["out_sub_order_id"] = request.OutSubOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplierCode))
            {
                body["supplier_code"] = request.SupplierCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsureOrderCreate",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v1/insurances/action/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsureOrderCreateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public InsureOrderCreateResponse InsureOrderCreate(InsureOrderCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsureOrderCreateHeaders headers = new InsureOrderCreateHeaders();
            return InsureOrderCreateWithOptions(request, headers, runtime);
        }

        public async Task<InsureOrderCreateResponse> InsureOrderCreateAsync(InsureOrderCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsureOrderCreateHeaders headers = new InsureOrderCreateHeaders();
            return await InsureOrderCreateWithOptionsAsync(request, headers, runtime);
        }

        public InsureOrderDetailResponse InsureOrderDetailWithOptions(InsureOrderDetailRequest request, InsureOrderDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BtripUserId))
            {
                query["btrip_user_id"] = request.BtripUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyerName))
            {
                query["buyer_name"] = request.BuyerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InsOrderId))
            {
                query["ins_order_id"] = request.InsOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                query["isv_name"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplierCode))
            {
                query["supplier_code"] = request.SupplierCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsureOrderDetail",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v1/insurances/action/detail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsureOrderDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InsureOrderDetailResponse> InsureOrderDetailWithOptionsAsync(InsureOrderDetailRequest request, InsureOrderDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BtripUserId))
            {
                query["btrip_user_id"] = request.BtripUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyerName))
            {
                query["buyer_name"] = request.BuyerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InsOrderId))
            {
                query["ins_order_id"] = request.InsOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                query["isv_name"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplierCode))
            {
                query["supplier_code"] = request.SupplierCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsureOrderDetail",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v1/insurances/action/detail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsureOrderDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public InsureOrderDetailResponse InsureOrderDetail(InsureOrderDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsureOrderDetailHeaders headers = new InsureOrderDetailHeaders();
            return InsureOrderDetailWithOptions(request, headers, runtime);
        }

        public async Task<InsureOrderDetailResponse> InsureOrderDetailAsync(InsureOrderDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsureOrderDetailHeaders headers = new InsureOrderDetailHeaders();
            return await InsureOrderDetailWithOptionsAsync(request, headers, runtime);
        }

        public InsureOrderPayResponse InsureOrderPayWithOptions(string insOrderId, InsureOrderPayRequest request, InsureOrderPayHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BtripUserId))
            {
                body["btrip_user_id"] = request.BtripUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyerName))
            {
                body["buyer_name"] = request.BuyerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                body["isv_name"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutOrderId))
            {
                body["out_order_id"] = request.OutOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutSubOrderId))
            {
                body["out_sub_order_id"] = request.OutSubOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentAmount))
            {
                body["payment_amount"] = request.PaymentAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplierCode))
            {
                body["supplier_code"] = request.SupplierCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsureOrderPay",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v1/insurances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(insOrderId) + "/action/pay",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsureOrderPayResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InsureOrderPayResponse> InsureOrderPayWithOptionsAsync(string insOrderId, InsureOrderPayRequest request, InsureOrderPayHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BtripUserId))
            {
                body["btrip_user_id"] = request.BtripUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyerName))
            {
                body["buyer_name"] = request.BuyerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                body["isv_name"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutOrderId))
            {
                body["out_order_id"] = request.OutOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutSubOrderId))
            {
                body["out_sub_order_id"] = request.OutSubOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentAmount))
            {
                body["payment_amount"] = request.PaymentAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplierCode))
            {
                body["supplier_code"] = request.SupplierCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsureOrderPay",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v1/insurances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(insOrderId) + "/action/pay",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsureOrderPayResponse>(await CallApiAsync(params_, req, runtime));
        }

        public InsureOrderPayResponse InsureOrderPay(string insOrderId, InsureOrderPayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsureOrderPayHeaders headers = new InsureOrderPayHeaders();
            return InsureOrderPayWithOptions(insOrderId, request, headers, runtime);
        }

        public async Task<InsureOrderPayResponse> InsureOrderPayAsync(string insOrderId, InsureOrderPayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsureOrderPayHeaders headers = new InsureOrderPayHeaders();
            return await InsureOrderPayWithOptionsAsync(insOrderId, request, headers, runtime);
        }

        public InsureOrderRefundResponse InsureOrderRefundWithOptions(string insOrderId, InsureOrderRefundRequest tmpReq, InsureOrderRefundHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InsureOrderRefundShrinkRequest request = new InsureOrderRefundShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PolicyNoList))
            {
                request.PolicyNoListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PolicyNoList, "policy_no_list", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SubInsOrderIds))
            {
                request.SubInsOrderIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SubInsOrderIds, "sub_ins_order_ids", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BtripUserId))
            {
                body["btrip_user_id"] = request.BtripUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyerName))
            {
                body["buyer_name"] = request.BuyerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                body["isv_name"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutApplyId))
            {
                body["out_apply_id"] = request.OutApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyNoListShrink))
            {
                body["policy_no_list"] = request.PolicyNoListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInsOrderIdsShrink))
            {
                body["sub_ins_order_ids"] = request.SubInsOrderIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplierCode))
            {
                body["supplier_code"] = request.SupplierCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsureOrderRefund",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v1/insurances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(insOrderId) + "/action/refund",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsureOrderRefundResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InsureOrderRefundResponse> InsureOrderRefundWithOptionsAsync(string insOrderId, InsureOrderRefundRequest tmpReq, InsureOrderRefundHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InsureOrderRefundShrinkRequest request = new InsureOrderRefundShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PolicyNoList))
            {
                request.PolicyNoListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PolicyNoList, "policy_no_list", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SubInsOrderIds))
            {
                request.SubInsOrderIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SubInsOrderIds, "sub_ins_order_ids", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BtripUserId))
            {
                body["btrip_user_id"] = request.BtripUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyerName))
            {
                body["buyer_name"] = request.BuyerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                body["isv_name"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutApplyId))
            {
                body["out_apply_id"] = request.OutApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyNoListShrink))
            {
                body["policy_no_list"] = request.PolicyNoListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInsOrderIdsShrink))
            {
                body["sub_ins_order_ids"] = request.SubInsOrderIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplierCode))
            {
                body["supplier_code"] = request.SupplierCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsureOrderRefund",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v1/insurances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(insOrderId) + "/action/refund",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsureOrderRefundResponse>(await CallApiAsync(params_, req, runtime));
        }

        public InsureOrderRefundResponse InsureOrderRefund(string insOrderId, InsureOrderRefundRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsureOrderRefundHeaders headers = new InsureOrderRefundHeaders();
            return InsureOrderRefundWithOptions(insOrderId, request, headers, runtime);
        }

        public async Task<InsureOrderRefundResponse> InsureOrderRefundAsync(string insOrderId, InsureOrderRefundRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsureOrderRefundHeaders headers = new InsureOrderRefundHeaders();
            return await InsureOrderRefundWithOptionsAsync(insOrderId, request, headers, runtime);
        }

        public InsureOrderUrlDetailResponse InsureOrderUrlDetailWithOptions(string insOrderId, InsureOrderUrlDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsureOrderUrlDetail",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v1/insurances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(insOrderId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsureOrderUrlDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InsureOrderUrlDetailResponse> InsureOrderUrlDetailWithOptionsAsync(string insOrderId, InsureOrderUrlDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsureOrderUrlDetail",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v1/insurances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(insOrderId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsureOrderUrlDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public InsureOrderUrlDetailResponse InsureOrderUrlDetail(string insOrderId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsureOrderUrlDetailHeaders headers = new InsureOrderUrlDetailHeaders();
            return InsureOrderUrlDetailWithOptions(insOrderId, headers, runtime);
        }

        public async Task<InsureOrderUrlDetailResponse> InsureOrderUrlDetailAsync(string insOrderId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsureOrderUrlDetailHeaders headers = new InsureOrderUrlDetailHeaders();
            return await InsureOrderUrlDetailWithOptionsAsync(insOrderId, headers, runtime);
        }

        public InsureRefundDetailResponse InsureRefundDetailWithOptions(InsureRefundDetailRequest request, InsureRefundDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyId))
            {
                query["apply_id"] = request.ApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BtripUserId))
            {
                query["btrip_user_id"] = request.BtripUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyerName))
            {
                query["buyer_name"] = request.BuyerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InsOrderId))
            {
                query["ins_order_id"] = request.InsOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                query["isv_name"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutApplyId))
            {
                query["out_apply_id"] = request.OutApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplierCode))
            {
                query["supplier_code"] = request.SupplierCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsureRefundDetail",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v1/insurances/action/refund-detail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsureRefundDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InsureRefundDetailResponse> InsureRefundDetailWithOptionsAsync(InsureRefundDetailRequest request, InsureRefundDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyId))
            {
                query["apply_id"] = request.ApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BtripUserId))
            {
                query["btrip_user_id"] = request.BtripUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyerName))
            {
                query["buyer_name"] = request.BuyerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InsOrderId))
            {
                query["ins_order_id"] = request.InsOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                query["isv_name"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutApplyId))
            {
                query["out_apply_id"] = request.OutApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplierCode))
            {
                query["supplier_code"] = request.SupplierCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsureRefundDetail",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v1/insurances/action/refund-detail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsureRefundDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public InsureRefundDetailResponse InsureRefundDetail(InsureRefundDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsureRefundDetailHeaders headers = new InsureRefundDetailHeaders();
            return InsureRefundDetailWithOptions(request, headers, runtime);
        }

        public async Task<InsureRefundDetailResponse> InsureRefundDetailAsync(InsureRefundDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsureRefundDetailHeaders headers = new InsureRefundDetailHeaders();
            return await InsureRefundDetailWithOptionsAsync(request, headers, runtime);
        }

        public IntlFlightListingSearchResponse IntlFlightListingSearchWithOptions(IntlFlightListingSearchRequest tmpReq, IntlFlightListingSearchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            IntlFlightListingSearchShrinkRequest request = new IntlFlightListingSearchShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SearchJourneys))
            {
                request.SearchJourneysShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SearchJourneys, "search_journeys", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SearchPassengerList))
            {
                request.SearchPassengerListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SearchPassengerList, "search_passenger_list", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BtripUserId))
            {
                query["btrip_user_id"] = request.BtripUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyerName))
            {
                query["buyer_name"] = request.BuyerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CabinType))
            {
                query["cabin_type"] = request.CabinType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectOnly))
            {
                query["direct_only"] = request.DirectOnly;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                query["isv_name"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedShareFlight))
            {
                query["need_share_flight"] = request.NeedShareFlight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutWheelSearch))
            {
                query["out_wheel_search"] = request.OutWheelSearch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryRecordId))
            {
                query["query_record_id"] = request.QueryRecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchJourneysShrink))
            {
                query["search_journeys"] = request.SearchJourneysShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchMode))
            {
                query["search_mode"] = request.SearchMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchPassengerListShrink))
            {
                query["search_passenger_list"] = request.SearchPassengerListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplierCode))
            {
                query["supplier_code"] = request.SupplierCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TripType))
            {
                query["trip_type"] = request.TripType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IntlFlightListingSearch",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/intl-flight/v1/flights/action/listing-search",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<IntlFlightListingSearchResponse>(CallApi(params_, req, runtime));
        }

        public async Task<IntlFlightListingSearchResponse> IntlFlightListingSearchWithOptionsAsync(IntlFlightListingSearchRequest tmpReq, IntlFlightListingSearchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            IntlFlightListingSearchShrinkRequest request = new IntlFlightListingSearchShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SearchJourneys))
            {
                request.SearchJourneysShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SearchJourneys, "search_journeys", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SearchPassengerList))
            {
                request.SearchPassengerListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SearchPassengerList, "search_passenger_list", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BtripUserId))
            {
                query["btrip_user_id"] = request.BtripUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyerName))
            {
                query["buyer_name"] = request.BuyerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CabinType))
            {
                query["cabin_type"] = request.CabinType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectOnly))
            {
                query["direct_only"] = request.DirectOnly;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                query["isv_name"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedShareFlight))
            {
                query["need_share_flight"] = request.NeedShareFlight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutWheelSearch))
            {
                query["out_wheel_search"] = request.OutWheelSearch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryRecordId))
            {
                query["query_record_id"] = request.QueryRecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchJourneysShrink))
            {
                query["search_journeys"] = request.SearchJourneysShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchMode))
            {
                query["search_mode"] = request.SearchMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchPassengerListShrink))
            {
                query["search_passenger_list"] = request.SearchPassengerListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplierCode))
            {
                query["supplier_code"] = request.SupplierCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TripType))
            {
                query["trip_type"] = request.TripType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IntlFlightListingSearch",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/intl-flight/v1/flights/action/listing-search",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<IntlFlightListingSearchResponse>(await CallApiAsync(params_, req, runtime));
        }

        public IntlFlightListingSearchResponse IntlFlightListingSearch(IntlFlightListingSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IntlFlightListingSearchHeaders headers = new IntlFlightListingSearchHeaders();
            return IntlFlightListingSearchWithOptions(request, headers, runtime);
        }

        public async Task<IntlFlightListingSearchResponse> IntlFlightListingSearchAsync(IntlFlightListingSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IntlFlightListingSearchHeaders headers = new IntlFlightListingSearchHeaders();
            return await IntlFlightListingSearchWithOptionsAsync(request, headers, runtime);
        }

        public IntlFlightOtaItemDetailResponse IntlFlightOtaItemDetailWithOptions(string otaItemId, IntlFlightOtaItemDetailRequest request, IntlFlightOtaItemDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BtripUserId))
            {
                query["btrip_user_id"] = request.BtripUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyerName))
            {
                query["buyer_name"] = request.BuyerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                query["isv_name"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplierCode))
            {
                query["supplier_code"] = request.SupplierCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IntlFlightOtaItemDetail",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/intl-flight/v1/items/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(otaItemId) + "/action/ota-get",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<IntlFlightOtaItemDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<IntlFlightOtaItemDetailResponse> IntlFlightOtaItemDetailWithOptionsAsync(string otaItemId, IntlFlightOtaItemDetailRequest request, IntlFlightOtaItemDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BtripUserId))
            {
                query["btrip_user_id"] = request.BtripUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyerName))
            {
                query["buyer_name"] = request.BuyerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                query["isv_name"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplierCode))
            {
                query["supplier_code"] = request.SupplierCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IntlFlightOtaItemDetail",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/intl-flight/v1/items/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(otaItemId) + "/action/ota-get",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<IntlFlightOtaItemDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public IntlFlightOtaItemDetailResponse IntlFlightOtaItemDetail(string otaItemId, IntlFlightOtaItemDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IntlFlightOtaItemDetailHeaders headers = new IntlFlightOtaItemDetailHeaders();
            return IntlFlightOtaItemDetailWithOptions(otaItemId, request, headers, runtime);
        }

        public async Task<IntlFlightOtaItemDetailResponse> IntlFlightOtaItemDetailAsync(string otaItemId, IntlFlightOtaItemDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IntlFlightOtaItemDetailHeaders headers = new IntlFlightOtaItemDetailHeaders();
            return await IntlFlightOtaItemDetailWithOptionsAsync(otaItemId, request, headers, runtime);
        }

        public IntlFlightOtaSearchResponse IntlFlightOtaSearchWithOptions(IntlFlightOtaSearchRequest tmpReq, IntlFlightOtaSearchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            IntlFlightOtaSearchShrinkRequest request = new IntlFlightOtaSearchShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SearchJourneys))
            {
                request.SearchJourneysShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SearchJourneys, "search_journeys", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SearchPassengerList))
            {
                request.SearchPassengerListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SearchPassengerList, "search_passenger_list", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BtripUserId))
            {
                query["btrip_user_id"] = request.BtripUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyerName))
            {
                query["buyer_name"] = request.BuyerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CabinType))
            {
                query["cabin_type"] = request.CabinType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectOnly))
            {
                query["direct_only"] = request.DirectOnly;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                query["isv_name"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedShareFlight))
            {
                query["need_share_flight"] = request.NeedShareFlight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchJourneysShrink))
            {
                query["search_journeys"] = request.SearchJourneysShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchPassengerListShrink))
            {
                query["search_passenger_list"] = request.SearchPassengerListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplierCode))
            {
                query["supplier_code"] = request.SupplierCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TripType))
            {
                query["trip_type"] = request.TripType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IntlFlightOtaSearch",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/intl-flight/v1/flights/action/ota-search",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<IntlFlightOtaSearchResponse>(CallApi(params_, req, runtime));
        }

        public async Task<IntlFlightOtaSearchResponse> IntlFlightOtaSearchWithOptionsAsync(IntlFlightOtaSearchRequest tmpReq, IntlFlightOtaSearchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            IntlFlightOtaSearchShrinkRequest request = new IntlFlightOtaSearchShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SearchJourneys))
            {
                request.SearchJourneysShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SearchJourneys, "search_journeys", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SearchPassengerList))
            {
                request.SearchPassengerListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SearchPassengerList, "search_passenger_list", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BtripUserId))
            {
                query["btrip_user_id"] = request.BtripUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyerName))
            {
                query["buyer_name"] = request.BuyerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CabinType))
            {
                query["cabin_type"] = request.CabinType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectOnly))
            {
                query["direct_only"] = request.DirectOnly;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                query["isv_name"] = request.IsvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedShareFlight))
            {
                query["need_share_flight"] = request.NeedShareFlight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchJourneysShrink))
            {
                query["search_journeys"] = request.SearchJourneysShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchPassengerListShrink))
            {
                query["search_passenger_list"] = request.SearchPassengerListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplierCode))
            {
                query["supplier_code"] = request.SupplierCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TripType))
            {
                query["trip_type"] = request.TripType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IntlFlightOtaSearch",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/intl-flight/v1/flights/action/ota-search",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<IntlFlightOtaSearchResponse>(await CallApiAsync(params_, req, runtime));
        }

        public IntlFlightOtaSearchResponse IntlFlightOtaSearch(IntlFlightOtaSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IntlFlightOtaSearchHeaders headers = new IntlFlightOtaSearchHeaders();
            return IntlFlightOtaSearchWithOptions(request, headers, runtime);
        }

        public async Task<IntlFlightOtaSearchResponse> IntlFlightOtaSearchAsync(IntlFlightOtaSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IntlFlightOtaSearchHeaders headers = new IntlFlightOtaSearchHeaders();
            return await IntlFlightOtaSearchWithOptionsAsync(request, headers, runtime);
        }

        public InvoiceAddResponse InvoiceAddWithOptions(InvoiceAddRequest request, InvoiceAddHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                body["address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BankName))
            {
                body["bank_name"] = request.BankName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BankNo))
            {
                body["bank_no"] = request.BankNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaxNo))
            {
                body["tax_no"] = request.TaxNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tel))
            {
                body["tel"] = request.Tel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartId))
            {
                body["third_part_id"] = request.ThirdPartId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnitType))
            {
                body["unit_type"] = request.UnitType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InvoiceAdd",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/invoice/v1/add-invoice",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InvoiceAddResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InvoiceAddResponse> InvoiceAddWithOptionsAsync(InvoiceAddRequest request, InvoiceAddHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                body["address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BankName))
            {
                body["bank_name"] = request.BankName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BankNo))
            {
                body["bank_no"] = request.BankNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaxNo))
            {
                body["tax_no"] = request.TaxNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tel))
            {
                body["tel"] = request.Tel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartId))
            {
                body["third_part_id"] = request.ThirdPartId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnitType))
            {
                body["unit_type"] = request.UnitType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InvoiceAdd",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/invoice/v1/add-invoice",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InvoiceAddResponse>(await CallApiAsync(params_, req, runtime));
        }

        public InvoiceAddResponse InvoiceAdd(InvoiceAddRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InvoiceAddHeaders headers = new InvoiceAddHeaders();
            return InvoiceAddWithOptions(request, headers, runtime);
        }

        public async Task<InvoiceAddResponse> InvoiceAddAsync(InvoiceAddRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InvoiceAddHeaders headers = new InvoiceAddHeaders();
            return await InvoiceAddWithOptionsAsync(request, headers, runtime);
        }

        public InvoiceDeleteResponse InvoiceDeleteWithOptions(InvoiceDeleteRequest request, InvoiceDeleteHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartId))
            {
                query["third_part_id"] = request.ThirdPartId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InvoiceDelete",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/invoice/v1/invoice",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InvoiceDeleteResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InvoiceDeleteResponse> InvoiceDeleteWithOptionsAsync(InvoiceDeleteRequest request, InvoiceDeleteHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartId))
            {
                query["third_part_id"] = request.ThirdPartId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InvoiceDelete",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/invoice/v1/invoice",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InvoiceDeleteResponse>(await CallApiAsync(params_, req, runtime));
        }

        public InvoiceDeleteResponse InvoiceDelete(InvoiceDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InvoiceDeleteHeaders headers = new InvoiceDeleteHeaders();
            return InvoiceDeleteWithOptions(request, headers, runtime);
        }

        public async Task<InvoiceDeleteResponse> InvoiceDeleteAsync(InvoiceDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InvoiceDeleteHeaders headers = new InvoiceDeleteHeaders();
            return await InvoiceDeleteWithOptionsAsync(request, headers, runtime);
        }

        public InvoiceModifyResponse InvoiceModifyWithOptions(InvoiceModifyRequest request, InvoiceModifyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                body["address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BankName))
            {
                body["bank_name"] = request.BankName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BankNo))
            {
                body["bank_no"] = request.BankNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaxNo))
            {
                body["tax_no"] = request.TaxNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tel))
            {
                body["tel"] = request.Tel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartId))
            {
                body["third_part_id"] = request.ThirdPartId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnitType))
            {
                body["unit_type"] = request.UnitType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InvoiceModify",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/invoice/v1/invoice",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InvoiceModifyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InvoiceModifyResponse> InvoiceModifyWithOptionsAsync(InvoiceModifyRequest request, InvoiceModifyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                body["address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BankName))
            {
                body["bank_name"] = request.BankName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BankNo))
            {
                body["bank_no"] = request.BankNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaxNo))
            {
                body["tax_no"] = request.TaxNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tel))
            {
                body["tel"] = request.Tel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartId))
            {
                body["third_part_id"] = request.ThirdPartId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnitType))
            {
                body["unit_type"] = request.UnitType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InvoiceModify",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/invoice/v1/invoice",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InvoiceModifyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public InvoiceModifyResponse InvoiceModify(InvoiceModifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InvoiceModifyHeaders headers = new InvoiceModifyHeaders();
            return InvoiceModifyWithOptions(request, headers, runtime);
        }

        public async Task<InvoiceModifyResponse> InvoiceModifyAsync(InvoiceModifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InvoiceModifyHeaders headers = new InvoiceModifyHeaders();
            return await InvoiceModifyWithOptionsAsync(request, headers, runtime);
        }

        public InvoiceRuleAddResponse InvoiceRuleAddWithOptions(InvoiceRuleAddRequest tmpReq, InvoiceRuleAddHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InvoiceRuleAddShrinkRequest request = new InvoiceRuleAddShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Entities))
            {
                request.EntitiesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Entities, "entities", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntitiesShrink))
            {
                body["entities"] = request.EntitiesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartId))
            {
                body["third_part_id"] = request.ThirdPartId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InvoiceRuleAdd",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/invoice/v1/invoice-rule",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InvoiceRuleAddResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InvoiceRuleAddResponse> InvoiceRuleAddWithOptionsAsync(InvoiceRuleAddRequest tmpReq, InvoiceRuleAddHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InvoiceRuleAddShrinkRequest request = new InvoiceRuleAddShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Entities))
            {
                request.EntitiesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Entities, "entities", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntitiesShrink))
            {
                body["entities"] = request.EntitiesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartId))
            {
                body["third_part_id"] = request.ThirdPartId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InvoiceRuleAdd",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/invoice/v1/invoice-rule",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InvoiceRuleAddResponse>(await CallApiAsync(params_, req, runtime));
        }

        public InvoiceRuleAddResponse InvoiceRuleAdd(InvoiceRuleAddRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InvoiceRuleAddHeaders headers = new InvoiceRuleAddHeaders();
            return InvoiceRuleAddWithOptions(request, headers, runtime);
        }

        public async Task<InvoiceRuleAddResponse> InvoiceRuleAddAsync(InvoiceRuleAddRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InvoiceRuleAddHeaders headers = new InvoiceRuleAddHeaders();
            return await InvoiceRuleAddWithOptionsAsync(request, headers, runtime);
        }

        public InvoiceRuleDeleteResponse InvoiceRuleDeleteWithOptions(InvoiceRuleDeleteRequest tmpReq, InvoiceRuleDeleteHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InvoiceRuleDeleteShrinkRequest request = new InvoiceRuleDeleteShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Entities))
            {
                request.EntitiesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Entities, "entities", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelAll))
            {
                query["del_all"] = request.DelAll;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntitiesShrink))
            {
                query["entities"] = request.EntitiesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartId))
            {
                query["third_part_id"] = request.ThirdPartId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InvoiceRuleDelete",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/invoice/v1/invoice-rule",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InvoiceRuleDeleteResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InvoiceRuleDeleteResponse> InvoiceRuleDeleteWithOptionsAsync(InvoiceRuleDeleteRequest tmpReq, InvoiceRuleDeleteHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InvoiceRuleDeleteShrinkRequest request = new InvoiceRuleDeleteShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Entities))
            {
                request.EntitiesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Entities, "entities", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelAll))
            {
                query["del_all"] = request.DelAll;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntitiesShrink))
            {
                query["entities"] = request.EntitiesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartId))
            {
                query["third_part_id"] = request.ThirdPartId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InvoiceRuleDelete",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/invoice/v1/invoice-rule",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InvoiceRuleDeleteResponse>(await CallApiAsync(params_, req, runtime));
        }

        public InvoiceRuleDeleteResponse InvoiceRuleDelete(InvoiceRuleDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InvoiceRuleDeleteHeaders headers = new InvoiceRuleDeleteHeaders();
            return InvoiceRuleDeleteWithOptions(request, headers, runtime);
        }

        public async Task<InvoiceRuleDeleteResponse> InvoiceRuleDeleteAsync(InvoiceRuleDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InvoiceRuleDeleteHeaders headers = new InvoiceRuleDeleteHeaders();
            return await InvoiceRuleDeleteWithOptionsAsync(request, headers, runtime);
        }

        public InvoiceRuleSaveResponse InvoiceRuleSaveWithOptions(InvoiceRuleSaveRequest tmpReq, InvoiceRuleSaveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InvoiceRuleSaveShrinkRequest request = new InvoiceRuleSaveShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Entities))
            {
                request.EntitiesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Entities, "entities", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllEmploye))
            {
                body["all_employe"] = request.AllEmploye;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntitiesShrink))
            {
                body["entities"] = request.EntitiesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartId))
            {
                body["third_part_id"] = request.ThirdPartId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InvoiceRuleSave",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/invoice/v1/invoice-rule",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InvoiceRuleSaveResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InvoiceRuleSaveResponse> InvoiceRuleSaveWithOptionsAsync(InvoiceRuleSaveRequest tmpReq, InvoiceRuleSaveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InvoiceRuleSaveShrinkRequest request = new InvoiceRuleSaveShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Entities))
            {
                request.EntitiesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Entities, "entities", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllEmploye))
            {
                body["all_employe"] = request.AllEmploye;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntitiesShrink))
            {
                body["entities"] = request.EntitiesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartId))
            {
                body["third_part_id"] = request.ThirdPartId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InvoiceRuleSave",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/invoice/v1/invoice-rule",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InvoiceRuleSaveResponse>(await CallApiAsync(params_, req, runtime));
        }

        public InvoiceRuleSaveResponse InvoiceRuleSave(InvoiceRuleSaveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InvoiceRuleSaveHeaders headers = new InvoiceRuleSaveHeaders();
            return InvoiceRuleSaveWithOptions(request, headers, runtime);
        }

        public async Task<InvoiceRuleSaveResponse> InvoiceRuleSaveAsync(InvoiceRuleSaveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InvoiceRuleSaveHeaders headers = new InvoiceRuleSaveHeaders();
            return await InvoiceRuleSaveWithOptionsAsync(request, headers, runtime);
        }

        public InvoiceSearchResponse InvoiceSearchWithOptions(InvoiceSearchRequest request, InvoiceSearchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["user_id"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InvoiceSearch",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/invoice/v1/invoice",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InvoiceSearchResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InvoiceSearchResponse> InvoiceSearchWithOptionsAsync(InvoiceSearchRequest request, InvoiceSearchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["user_id"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InvoiceSearch",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/invoice/v1/invoice",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InvoiceSearchResponse>(await CallApiAsync(params_, req, runtime));
        }

        public InvoiceSearchResponse InvoiceSearch(InvoiceSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InvoiceSearchHeaders headers = new InvoiceSearchHeaders();
            return InvoiceSearchWithOptions(request, headers, runtime);
        }

        public async Task<InvoiceSearchResponse> InvoiceSearchAsync(InvoiceSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InvoiceSearchHeaders headers = new InvoiceSearchHeaders();
            return await InvoiceSearchWithOptionsAsync(request, headers, runtime);
        }

        public IsvRuleSaveResponse IsvRuleSaveWithOptions(IsvRuleSaveRequest tmpReq, IsvRuleSaveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            IsvRuleSaveShrinkRequest request = new IsvRuleSaveShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.BookuserList))
            {
                request.BookuserListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.BookuserList, "bookuser_list", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyNeed))
            {
                body["apply_need"] = request.ApplyNeed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BookType))
            {
                body["book_type"] = request.BookType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BookuserListShrink))
            {
                body["bookuser_list"] = request.BookuserListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleNeed))
            {
                body["rule_need"] = request.RuleNeed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IsvRuleSave",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/user/v1/rule",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<IsvRuleSaveResponse>(CallApi(params_, req, runtime));
        }

        public async Task<IsvRuleSaveResponse> IsvRuleSaveWithOptionsAsync(IsvRuleSaveRequest tmpReq, IsvRuleSaveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            IsvRuleSaveShrinkRequest request = new IsvRuleSaveShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.BookuserList))
            {
                request.BookuserListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.BookuserList, "bookuser_list", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyNeed))
            {
                body["apply_need"] = request.ApplyNeed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BookType))
            {
                body["book_type"] = request.BookType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BookuserListShrink))
            {
                body["bookuser_list"] = request.BookuserListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleNeed))
            {
                body["rule_need"] = request.RuleNeed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IsvRuleSave",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/user/v1/rule",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<IsvRuleSaveResponse>(await CallApiAsync(params_, req, runtime));
        }

        public IsvRuleSaveResponse IsvRuleSave(IsvRuleSaveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IsvRuleSaveHeaders headers = new IsvRuleSaveHeaders();
            return IsvRuleSaveWithOptions(request, headers, runtime);
        }

        public async Task<IsvRuleSaveResponse> IsvRuleSaveAsync(IsvRuleSaveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IsvRuleSaveHeaders headers = new IsvRuleSaveHeaders();
            return await IsvRuleSaveWithOptionsAsync(request, headers, runtime);
        }

        public IsvUserSaveResponse IsvUserSaveWithOptions(IsvUserSaveRequest tmpReq, IsvUserSaveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            IsvUserSaveShrinkRequest request = new IsvUserSaveShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserList))
            {
                request.UserListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserList, "user_list", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserListShrink))
            {
                body["user_list"] = request.UserListShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IsvUserSave",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/isvuser/v1/isvuser",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<IsvUserSaveResponse>(CallApi(params_, req, runtime));
        }

        public async Task<IsvUserSaveResponse> IsvUserSaveWithOptionsAsync(IsvUserSaveRequest tmpReq, IsvUserSaveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            IsvUserSaveShrinkRequest request = new IsvUserSaveShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserList))
            {
                request.UserListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserList, "user_list", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserListShrink))
            {
                body["user_list"] = request.UserListShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IsvUserSave",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/isvuser/v1/isvuser",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<IsvUserSaveResponse>(await CallApiAsync(params_, req, runtime));
        }

        public IsvUserSaveResponse IsvUserSave(IsvUserSaveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IsvUserSaveHeaders headers = new IsvUserSaveHeaders();
            return IsvUserSaveWithOptions(request, headers, runtime);
        }

        public async Task<IsvUserSaveResponse> IsvUserSaveAsync(IsvUserSaveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IsvUserSaveHeaders headers = new IsvUserSaveHeaders();
            return await IsvUserSaveWithOptionsAsync(request, headers, runtime);
        }

        public MonthBillConfirmResponse MonthBillConfirmWithOptions(MonthBillConfirmRequest request, MonthBillConfirmHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MailBillDate))
            {
                body["mail_bill_date"] = request.MailBillDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MonthBillConfirm",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/bill/v1/status/action/confirm",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MonthBillConfirmResponse>(CallApi(params_, req, runtime));
        }

        public async Task<MonthBillConfirmResponse> MonthBillConfirmWithOptionsAsync(MonthBillConfirmRequest request, MonthBillConfirmHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MailBillDate))
            {
                body["mail_bill_date"] = request.MailBillDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MonthBillConfirm",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/bill/v1/status/action/confirm",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MonthBillConfirmResponse>(await CallApiAsync(params_, req, runtime));
        }

        public MonthBillConfirmResponse MonthBillConfirm(MonthBillConfirmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MonthBillConfirmHeaders headers = new MonthBillConfirmHeaders();
            return MonthBillConfirmWithOptions(request, headers, runtime);
        }

        public async Task<MonthBillConfirmResponse> MonthBillConfirmAsync(MonthBillConfirmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MonthBillConfirmHeaders headers = new MonthBillConfirmHeaders();
            return await MonthBillConfirmWithOptionsAsync(request, headers, runtime);
        }

        public MonthBillGetResponse MonthBillGetWithOptions(MonthBillGetRequest request, MonthBillGetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillMonth))
            {
                query["bill_month"] = request.BillMonth;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MonthBillGet",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/open/v1/month-bill",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<MonthBillGetResponse>(CallApi(params_, req, runtime));
        }

        public async Task<MonthBillGetResponse> MonthBillGetWithOptionsAsync(MonthBillGetRequest request, MonthBillGetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillMonth))
            {
                query["bill_month"] = request.BillMonth;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MonthBillGet",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/open/v1/month-bill",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<MonthBillGetResponse>(await CallApiAsync(params_, req, runtime));
        }

        public MonthBillGetResponse MonthBillGet(MonthBillGetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MonthBillGetHeaders headers = new MonthBillGetHeaders();
            return MonthBillGetWithOptions(request, headers, runtime);
        }

        public async Task<MonthBillGetResponse> MonthBillGetAsync(MonthBillGetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MonthBillGetHeaders headers = new MonthBillGetHeaders();
            return await MonthBillGetWithOptionsAsync(request, headers, runtime);
        }

        public ProjectAddResponse ProjectAddWithOptions(ProjectAddRequest request, ProjectAddHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["project_name"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartCostCenterId))
            {
                body["third_part_cost_center_id"] = request.ThirdPartCostCenterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartId))
            {
                body["third_part_id"] = request.ThirdPartId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartInvoiceId))
            {
                body["third_part_invoice_id"] = request.ThirdPartInvoiceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ProjectAdd",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/cost/v1/project",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ProjectAddResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ProjectAddResponse> ProjectAddWithOptionsAsync(ProjectAddRequest request, ProjectAddHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["project_name"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartCostCenterId))
            {
                body["third_part_cost_center_id"] = request.ThirdPartCostCenterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartId))
            {
                body["third_part_id"] = request.ThirdPartId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartInvoiceId))
            {
                body["third_part_invoice_id"] = request.ThirdPartInvoiceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ProjectAdd",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/cost/v1/project",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ProjectAddResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ProjectAddResponse ProjectAdd(ProjectAddRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ProjectAddHeaders headers = new ProjectAddHeaders();
            return ProjectAddWithOptions(request, headers, runtime);
        }

        public async Task<ProjectAddResponse> ProjectAddAsync(ProjectAddRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ProjectAddHeaders headers = new ProjectAddHeaders();
            return await ProjectAddWithOptionsAsync(request, headers, runtime);
        }

        public ProjectDeleteResponse ProjectDeleteWithOptions(ProjectDeleteRequest request, ProjectDeleteHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartId))
            {
                query["third_part_id"] = request.ThirdPartId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ProjectDelete",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/cost/v1/project",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ProjectDeleteResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ProjectDeleteResponse> ProjectDeleteWithOptionsAsync(ProjectDeleteRequest request, ProjectDeleteHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartId))
            {
                query["third_part_id"] = request.ThirdPartId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ProjectDelete",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/cost/v1/project",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ProjectDeleteResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ProjectDeleteResponse ProjectDelete(ProjectDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ProjectDeleteHeaders headers = new ProjectDeleteHeaders();
            return ProjectDeleteWithOptions(request, headers, runtime);
        }

        public async Task<ProjectDeleteResponse> ProjectDeleteAsync(ProjectDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ProjectDeleteHeaders headers = new ProjectDeleteHeaders();
            return await ProjectDeleteWithOptionsAsync(request, headers, runtime);
        }

        public ProjectModifyResponse ProjectModifyWithOptions(ProjectModifyRequest request, ProjectModifyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["project_name"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartCostCenterId))
            {
                body["third_part_cost_center_id"] = request.ThirdPartCostCenterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartId))
            {
                body["third_part_id"] = request.ThirdPartId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartInvoiceId))
            {
                body["third_part_invoice_id"] = request.ThirdPartInvoiceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ProjectModify",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/cost/v1/project",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ProjectModifyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ProjectModifyResponse> ProjectModifyWithOptionsAsync(ProjectModifyRequest request, ProjectModifyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["project_name"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartCostCenterId))
            {
                body["third_part_cost_center_id"] = request.ThirdPartCostCenterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartId))
            {
                body["third_part_id"] = request.ThirdPartId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartInvoiceId))
            {
                body["third_part_invoice_id"] = request.ThirdPartInvoiceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ProjectModify",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/cost/v1/project",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ProjectModifyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ProjectModifyResponse ProjectModify(ProjectModifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ProjectModifyHeaders headers = new ProjectModifyHeaders();
            return ProjectModifyWithOptions(request, headers, runtime);
        }

        public async Task<ProjectModifyResponse> ProjectModifyAsync(ProjectModifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ProjectModifyHeaders headers = new ProjectModifyHeaders();
            return await ProjectModifyWithOptionsAsync(request, headers, runtime);
        }

        public QueryReimbursementOrderResponse QueryReimbursementOrderWithOptions(QueryReimbursementOrderRequest request, QueryReimbursementOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReimbOrderNo))
            {
                query["reimb_order_no"] = request.ReimbOrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                query["sub_corp_id"] = request.SubCorpId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryReimbursementOrder",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/reimbursement/v1/order",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryReimbursementOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryReimbursementOrderResponse> QueryReimbursementOrderWithOptionsAsync(QueryReimbursementOrderRequest request, QueryReimbursementOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReimbOrderNo))
            {
                query["reimb_order_no"] = request.ReimbOrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                query["sub_corp_id"] = request.SubCorpId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryReimbursementOrder",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/reimbursement/v1/order",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryReimbursementOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryReimbursementOrderResponse QueryReimbursementOrder(QueryReimbursementOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryReimbursementOrderHeaders headers = new QueryReimbursementOrderHeaders();
            return QueryReimbursementOrderWithOptions(request, headers, runtime);
        }

        public async Task<QueryReimbursementOrderResponse> QueryReimbursementOrderAsync(QueryReimbursementOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryReimbursementOrderHeaders headers = new QueryReimbursementOrderHeaders();
            return await QueryReimbursementOrderWithOptionsAsync(request, headers, runtime);
        }

        public SyncSingleUserResponse SyncSingleUserWithOptions(SyncSingleUserRequest tmpReq, SyncSingleUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SyncSingleUserShrinkRequest request = new SyncSingleUserShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ThirdDepartIdList))
            {
                request.ThirdDepartIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ThirdDepartIdList, "third_depart_id_list", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                body["email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobNo))
            {
                body["job_no"] = request.JobNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaveStatus))
            {
                body["leave_status"] = request.LeaveStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagerUserId))
            {
                body["manager_user_id"] = request.ManagerUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                body["phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Position))
            {
                body["position"] = request.Position;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PositionLevel))
            {
                body["position_level"] = request.PositionLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealNameEn))
            {
                body["real_name_en"] = request.RealNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdDepartIdListShrink))
            {
                body["third_depart_id_list"] = request.ThirdDepartIdListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["user_name"] = request.UserName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncSingleUser",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/user/v1/single-user/action/sync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncSingleUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SyncSingleUserResponse> SyncSingleUserWithOptionsAsync(SyncSingleUserRequest tmpReq, SyncSingleUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SyncSingleUserShrinkRequest request = new SyncSingleUserShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ThirdDepartIdList))
            {
                request.ThirdDepartIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ThirdDepartIdList, "third_depart_id_list", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                body["email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobNo))
            {
                body["job_no"] = request.JobNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaveStatus))
            {
                body["leave_status"] = request.LeaveStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagerUserId))
            {
                body["manager_user_id"] = request.ManagerUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                body["phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Position))
            {
                body["position"] = request.Position;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PositionLevel))
            {
                body["position_level"] = request.PositionLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealNameEn))
            {
                body["real_name_en"] = request.RealNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdDepartIdListShrink))
            {
                body["third_depart_id_list"] = request.ThirdDepartIdListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["user_name"] = request.UserName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncSingleUser",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/user/v1/single-user/action/sync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncSingleUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SyncSingleUserResponse SyncSingleUser(SyncSingleUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncSingleUserHeaders headers = new SyncSingleUserHeaders();
            return SyncSingleUserWithOptions(request, headers, runtime);
        }

        public async Task<SyncSingleUserResponse> SyncSingleUserAsync(SyncSingleUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncSingleUserHeaders headers = new SyncSingleUserHeaders();
            return await SyncSingleUserWithOptionsAsync(request, headers, runtime);
        }

        public SyncThirdUserMappingResponse SyncThirdUserMappingWithOptions(SyncThirdUserMappingRequest request, SyncThirdUserMappingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdChannelType))
            {
                body["third_channel_type"] = request.ThirdChannelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdUserId))
            {
                body["third_user_id"] = request.ThirdUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncThirdUserMapping",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/user/v1/third-users/action/mapping",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncThirdUserMappingResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SyncThirdUserMappingResponse> SyncThirdUserMappingWithOptionsAsync(SyncThirdUserMappingRequest request, SyncThirdUserMappingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdChannelType))
            {
                body["third_channel_type"] = request.ThirdChannelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdUserId))
            {
                body["third_user_id"] = request.ThirdUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncThirdUserMapping",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/user/v1/third-users/action/mapping",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncThirdUserMappingResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SyncThirdUserMappingResponse SyncThirdUserMapping(SyncThirdUserMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncThirdUserMappingHeaders headers = new SyncThirdUserMappingHeaders();
            return SyncThirdUserMappingWithOptions(request, headers, runtime);
        }

        public async Task<SyncThirdUserMappingResponse> SyncThirdUserMappingAsync(SyncThirdUserMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncThirdUserMappingHeaders headers = new SyncThirdUserMappingHeaders();
            return await SyncThirdUserMappingWithOptionsAsync(request, headers, runtime);
        }

        public TBAccountInfoQueryResponse TBAccountInfoQueryWithOptions(string userId, TBAccountInfoQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TBAccountInfoQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/account/v1/tb-accounts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TBAccountInfoQueryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TBAccountInfoQueryResponse> TBAccountInfoQueryWithOptionsAsync(string userId, TBAccountInfoQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TBAccountInfoQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/account/v1/tb-accounts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TBAccountInfoQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TBAccountInfoQueryResponse TBAccountInfoQuery(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TBAccountInfoQueryHeaders headers = new TBAccountInfoQueryHeaders();
            return TBAccountInfoQueryWithOptions(userId, headers, runtime);
        }

        public async Task<TBAccountInfoQueryResponse> TBAccountInfoQueryAsync(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TBAccountInfoQueryHeaders headers = new TBAccountInfoQueryHeaders();
            return await TBAccountInfoQueryWithOptionsAsync(userId, headers, runtime);
        }

        public TBAccountUnbindResponse TBAccountUnbindWithOptions(string userId, TBAccountUnbindHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TBAccountUnbind",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/account/v1/tb-accounts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId) + "/action/unbind",
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TBAccountUnbindResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TBAccountUnbindResponse> TBAccountUnbindWithOptionsAsync(string userId, TBAccountUnbindHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TBAccountUnbind",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/account/v1/tb-accounts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId) + "/action/unbind",
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TBAccountUnbindResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TBAccountUnbindResponse TBAccountUnbind(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TBAccountUnbindHeaders headers = new TBAccountUnbindHeaders();
            return TBAccountUnbindWithOptions(userId, headers, runtime);
        }

        public async Task<TBAccountUnbindResponse> TBAccountUnbindAsync(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TBAccountUnbindHeaders headers = new TBAccountUnbindHeaders();
            return await TBAccountUnbindWithOptionsAsync(userId, headers, runtime);
        }

        public TicketChangingApplyResponse TicketChangingApplyWithOptions(TicketChangingApplyRequest tmpReq, TicketChangingApplyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            TicketChangingApplyShrinkRequest request = new TicketChangingApplyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ModifyFlightInfoList))
            {
                request.ModifyFlightInfoListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ModifyFlightInfoList, "modify_flight_info_list", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisOrderId))
            {
                body["dis_order_id"] = request.DisOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisSubOrderId))
            {
                body["dis_sub_order_id"] = request.DisSubOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsVoluntary))
            {
                body["is_voluntary"] = request.IsVoluntary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyFlightInfoListShrink))
            {
                body["modify_flight_info_list"] = request.ModifyFlightInfoListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtaItemId))
            {
                body["ota_item_id"] = request.OtaItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reason))
            {
                body["reason"] = request.Reason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["session_id"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhetherRetry))
            {
                body["whether_retry"] = request.WhetherRetry;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TicketChangingApply",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v1/ticket-changing/action/apply",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TicketChangingApplyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TicketChangingApplyResponse> TicketChangingApplyWithOptionsAsync(TicketChangingApplyRequest tmpReq, TicketChangingApplyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            TicketChangingApplyShrinkRequest request = new TicketChangingApplyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ModifyFlightInfoList))
            {
                request.ModifyFlightInfoListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ModifyFlightInfoList, "modify_flight_info_list", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisOrderId))
            {
                body["dis_order_id"] = request.DisOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisSubOrderId))
            {
                body["dis_sub_order_id"] = request.DisSubOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsVoluntary))
            {
                body["is_voluntary"] = request.IsVoluntary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyFlightInfoListShrink))
            {
                body["modify_flight_info_list"] = request.ModifyFlightInfoListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtaItemId))
            {
                body["ota_item_id"] = request.OtaItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reason))
            {
                body["reason"] = request.Reason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["session_id"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhetherRetry))
            {
                body["whether_retry"] = request.WhetherRetry;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TicketChangingApply",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v1/ticket-changing/action/apply",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TicketChangingApplyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TicketChangingApplyResponse TicketChangingApply(TicketChangingApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TicketChangingApplyHeaders headers = new TicketChangingApplyHeaders();
            return TicketChangingApplyWithOptions(request, headers, runtime);
        }

        public async Task<TicketChangingApplyResponse> TicketChangingApplyAsync(TicketChangingApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TicketChangingApplyHeaders headers = new TicketChangingApplyHeaders();
            return await TicketChangingApplyWithOptionsAsync(request, headers, runtime);
        }

        public TicketChangingCancelResponse TicketChangingCancelWithOptions(TicketChangingCancelRequest request, TicketChangingCancelHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisOrderId))
            {
                query["dis_order_id"] = request.DisOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisSubOrderId))
            {
                query["dis_sub_order_id"] = request.DisSubOrderId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TicketChangingCancel",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v1/ticket-changing/action/cancel",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TicketChangingCancelResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TicketChangingCancelResponse> TicketChangingCancelWithOptionsAsync(TicketChangingCancelRequest request, TicketChangingCancelHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisOrderId))
            {
                query["dis_order_id"] = request.DisOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisSubOrderId))
            {
                query["dis_sub_order_id"] = request.DisSubOrderId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TicketChangingCancel",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v1/ticket-changing/action/cancel",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TicketChangingCancelResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TicketChangingCancelResponse TicketChangingCancel(TicketChangingCancelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TicketChangingCancelHeaders headers = new TicketChangingCancelHeaders();
            return TicketChangingCancelWithOptions(request, headers, runtime);
        }

        public async Task<TicketChangingCancelResponse> TicketChangingCancelAsync(TicketChangingCancelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TicketChangingCancelHeaders headers = new TicketChangingCancelHeaders();
            return await TicketChangingCancelWithOptionsAsync(request, headers, runtime);
        }

        public TicketChangingDetailResponse TicketChangingDetailWithOptions(TicketChangingDetailRequest request, TicketChangingDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisOrderId))
            {
                query["dis_order_id"] = request.DisOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisSubOrderId))
            {
                query["dis_sub_order_id"] = request.DisSubOrderId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TicketChangingDetail",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v1/ticket-changing/action/detail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TicketChangingDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TicketChangingDetailResponse> TicketChangingDetailWithOptionsAsync(TicketChangingDetailRequest request, TicketChangingDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisOrderId))
            {
                query["dis_order_id"] = request.DisOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisSubOrderId))
            {
                query["dis_sub_order_id"] = request.DisSubOrderId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TicketChangingDetail",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v1/ticket-changing/action/detail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TicketChangingDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TicketChangingDetailResponse TicketChangingDetail(TicketChangingDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TicketChangingDetailHeaders headers = new TicketChangingDetailHeaders();
            return TicketChangingDetailWithOptions(request, headers, runtime);
        }

        public async Task<TicketChangingDetailResponse> TicketChangingDetailAsync(TicketChangingDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TicketChangingDetailHeaders headers = new TicketChangingDetailHeaders();
            return await TicketChangingDetailWithOptionsAsync(request, headers, runtime);
        }

        public TicketChangingEnquiryResponse TicketChangingEnquiryWithOptions(TicketChangingEnquiryRequest request, TicketChangingEnquiryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArrCity))
            {
                query["arr_city"] = request.ArrCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepCity))
            {
                query["dep_city"] = request.DepCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisOrderId))
            {
                query["dis_order_id"] = request.DisOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsVoluntary))
            {
                query["is_voluntary"] = request.IsVoluntary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyDepartDate))
            {
                query["modify_depart_date"] = request.ModifyDepartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyFlightNo))
            {
                query["modify_flight_no"] = request.ModifyFlightNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["session_id"] = request.SessionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TicketChangingEnquiry",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v1/ticket-changing/action/enquiry",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TicketChangingEnquiryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TicketChangingEnquiryResponse> TicketChangingEnquiryWithOptionsAsync(TicketChangingEnquiryRequest request, TicketChangingEnquiryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArrCity))
            {
                query["arr_city"] = request.ArrCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepCity))
            {
                query["dep_city"] = request.DepCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisOrderId))
            {
                query["dis_order_id"] = request.DisOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsVoluntary))
            {
                query["is_voluntary"] = request.IsVoluntary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyDepartDate))
            {
                query["modify_depart_date"] = request.ModifyDepartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyFlightNo))
            {
                query["modify_flight_no"] = request.ModifyFlightNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["session_id"] = request.SessionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TicketChangingEnquiry",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v1/ticket-changing/action/enquiry",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TicketChangingEnquiryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TicketChangingEnquiryResponse TicketChangingEnquiry(TicketChangingEnquiryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TicketChangingEnquiryHeaders headers = new TicketChangingEnquiryHeaders();
            return TicketChangingEnquiryWithOptions(request, headers, runtime);
        }

        public async Task<TicketChangingEnquiryResponse> TicketChangingEnquiryAsync(TicketChangingEnquiryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TicketChangingEnquiryHeaders headers = new TicketChangingEnquiryHeaders();
            return await TicketChangingEnquiryWithOptionsAsync(request, headers, runtime);
        }

        public TicketChangingFlightListResponse TicketChangingFlightListWithOptions(TicketChangingFlightListRequest tmpReq, TicketChangingFlightListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            TicketChangingFlightListShrinkRequest request = new TicketChangingFlightListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TravelerInfoList))
            {
                request.TravelerInfoListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TravelerInfoList, "traveler_info_list", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArrCity))
            {
                query["arr_city"] = request.ArrCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepCity))
            {
                query["dep_city"] = request.DepCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepDate))
            {
                query["dep_date"] = request.DepDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisOrderId))
            {
                query["dis_order_id"] = request.DisOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsVoluntary))
            {
                query["is_voluntary"] = request.IsVoluntary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TravelerInfoListShrink))
            {
                query["traveler_info_list"] = request.TravelerInfoListShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TicketChangingFlightList",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/huge/dtb-flight/v1/ticket-changing-flight/action/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TicketChangingFlightListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TicketChangingFlightListResponse> TicketChangingFlightListWithOptionsAsync(TicketChangingFlightListRequest tmpReq, TicketChangingFlightListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            TicketChangingFlightListShrinkRequest request = new TicketChangingFlightListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TravelerInfoList))
            {
                request.TravelerInfoListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TravelerInfoList, "traveler_info_list", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArrCity))
            {
                query["arr_city"] = request.ArrCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepCity))
            {
                query["dep_city"] = request.DepCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepDate))
            {
                query["dep_date"] = request.DepDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisOrderId))
            {
                query["dis_order_id"] = request.DisOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsVoluntary))
            {
                query["is_voluntary"] = request.IsVoluntary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TravelerInfoListShrink))
            {
                query["traveler_info_list"] = request.TravelerInfoListShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TicketChangingFlightList",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/huge/dtb-flight/v1/ticket-changing-flight/action/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TicketChangingFlightListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TicketChangingFlightListResponse TicketChangingFlightList(TicketChangingFlightListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TicketChangingFlightListHeaders headers = new TicketChangingFlightListHeaders();
            return TicketChangingFlightListWithOptions(request, headers, runtime);
        }

        public async Task<TicketChangingFlightListResponse> TicketChangingFlightListAsync(TicketChangingFlightListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TicketChangingFlightListHeaders headers = new TicketChangingFlightListHeaders();
            return await TicketChangingFlightListWithOptionsAsync(request, headers, runtime);
        }

        public TicketChangingPayResponse TicketChangingPayWithOptions(TicketChangingPayRequest tmpReq, TicketChangingPayHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            TicketChangingPayShrinkRequest request = new TicketChangingPayShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Extra))
            {
                request.ExtraShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Extra, "extra", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpPayPrice))
            {
                body["corp_pay_price"] = request.CorpPayPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisOrderId))
            {
                body["dis_order_id"] = request.DisOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisSubOrderId))
            {
                body["dis_sub_order_id"] = request.DisSubOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraShrink))
            {
                body["extra"] = request.ExtraShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersonalPayPrice))
            {
                body["personal_pay_price"] = request.PersonalPayPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalPayPrice))
            {
                body["total_pay_price"] = request.TotalPayPrice;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TicketChangingPay",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v1/ticket-changing/action/pay",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TicketChangingPayResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TicketChangingPayResponse> TicketChangingPayWithOptionsAsync(TicketChangingPayRequest tmpReq, TicketChangingPayHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            TicketChangingPayShrinkRequest request = new TicketChangingPayShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Extra))
            {
                request.ExtraShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Extra, "extra", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpPayPrice))
            {
                body["corp_pay_price"] = request.CorpPayPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisOrderId))
            {
                body["dis_order_id"] = request.DisOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisSubOrderId))
            {
                body["dis_sub_order_id"] = request.DisSubOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraShrink))
            {
                body["extra"] = request.ExtraShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersonalPayPrice))
            {
                body["personal_pay_price"] = request.PersonalPayPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalPayPrice))
            {
                body["total_pay_price"] = request.TotalPayPrice;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TicketChangingPay",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/dtb-flight/v1/ticket-changing/action/pay",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TicketChangingPayResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TicketChangingPayResponse TicketChangingPay(TicketChangingPayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TicketChangingPayHeaders headers = new TicketChangingPayHeaders();
            return TicketChangingPayWithOptions(request, headers, runtime);
        }

        public async Task<TicketChangingPayResponse> TicketChangingPayAsync(TicketChangingPayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TicketChangingPayHeaders headers = new TicketChangingPayHeaders();
            return await TicketChangingPayWithOptionsAsync(request, headers, runtime);
        }

        public TrainBillSettlementQueryResponse TrainBillSettlementQueryWithOptions(TrainBillSettlementQueryRequest request, TrainBillSettlementQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["page_no"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodEnd))
            {
                query["period_end"] = request.PeriodEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodStart))
            {
                query["period_start"] = request.PeriodStart;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TrainBillSettlementQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/train/v1/bill-settlement",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TrainBillSettlementQueryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TrainBillSettlementQueryResponse> TrainBillSettlementQueryWithOptionsAsync(TrainBillSettlementQueryRequest request, TrainBillSettlementQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["page_no"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodEnd))
            {
                query["period_end"] = request.PeriodEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodStart))
            {
                query["period_start"] = request.PeriodStart;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TrainBillSettlementQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/train/v1/bill-settlement",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TrainBillSettlementQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TrainBillSettlementQueryResponse TrainBillSettlementQuery(TrainBillSettlementQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TrainBillSettlementQueryHeaders headers = new TrainBillSettlementQueryHeaders();
            return TrainBillSettlementQueryWithOptions(request, headers, runtime);
        }

        public async Task<TrainBillSettlementQueryResponse> TrainBillSettlementQueryAsync(TrainBillSettlementQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TrainBillSettlementQueryHeaders headers = new TrainBillSettlementQueryHeaders();
            return await TrainBillSettlementQueryWithOptionsAsync(request, headers, runtime);
        }

        public TrainExceedApplyQueryResponse TrainExceedApplyQueryWithOptions(TrainExceedApplyQueryRequest request, TrainExceedApplyQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyId))
            {
                query["apply_id"] = request.ApplyId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TrainExceedApplyQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/apply/v1/train-exceed",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TrainExceedApplyQueryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TrainExceedApplyQueryResponse> TrainExceedApplyQueryWithOptionsAsync(TrainExceedApplyQueryRequest request, TrainExceedApplyQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyId))
            {
                query["apply_id"] = request.ApplyId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TrainExceedApplyQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/apply/v1/train-exceed",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TrainExceedApplyQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TrainExceedApplyQueryResponse TrainExceedApplyQuery(TrainExceedApplyQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TrainExceedApplyQueryHeaders headers = new TrainExceedApplyQueryHeaders();
            return TrainExceedApplyQueryWithOptions(request, headers, runtime);
        }

        public async Task<TrainExceedApplyQueryResponse> TrainExceedApplyQueryAsync(TrainExceedApplyQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TrainExceedApplyQueryHeaders headers = new TrainExceedApplyQueryHeaders();
            return await TrainExceedApplyQueryWithOptionsAsync(request, headers, runtime);
        }

        public TrainOrderListQueryResponse TrainOrderListQueryWithOptions(TrainOrderListQueryRequest request, TrainOrderListQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllApply))
            {
                query["all_apply"] = request.AllApply;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyId))
            {
                query["apply_id"] = request.ApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartId))
            {
                query["depart_id"] = request.DepartId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["end_time"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["start_time"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartApplyId))
            {
                query["thirdpart_apply_id"] = request.ThirdpartApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateEndTime))
            {
                query["update_end_time"] = request.UpdateEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateStartTime))
            {
                query["update_start_time"] = request.UpdateStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["user_id"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TrainOrderListQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/train/v1/order-list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TrainOrderListQueryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TrainOrderListQueryResponse> TrainOrderListQueryWithOptionsAsync(TrainOrderListQueryRequest request, TrainOrderListQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllApply))
            {
                query["all_apply"] = request.AllApply;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyId))
            {
                query["apply_id"] = request.ApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartId))
            {
                query["depart_id"] = request.DepartId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["end_time"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["start_time"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartApplyId))
            {
                query["thirdpart_apply_id"] = request.ThirdpartApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateEndTime))
            {
                query["update_end_time"] = request.UpdateEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateStartTime))
            {
                query["update_start_time"] = request.UpdateStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["user_id"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TrainOrderListQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/train/v1/order-list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TrainOrderListQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TrainOrderListQueryResponse TrainOrderListQuery(TrainOrderListQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TrainOrderListQueryHeaders headers = new TrainOrderListQueryHeaders();
            return TrainOrderListQueryWithOptions(request, headers, runtime);
        }

        public async Task<TrainOrderListQueryResponse> TrainOrderListQueryAsync(TrainOrderListQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TrainOrderListQueryHeaders headers = new TrainOrderListQueryHeaders();
            return await TrainOrderListQueryWithOptionsAsync(request, headers, runtime);
        }

        public TrainOrderQueryResponse TrainOrderQueryWithOptions(TrainOrderQueryRequest request, TrainOrderQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["order_id"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["user_id"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TrainOrderQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/train/v1/order",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TrainOrderQueryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TrainOrderQueryResponse> TrainOrderQueryWithOptionsAsync(TrainOrderQueryRequest request, TrainOrderQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["order_id"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["user_id"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TrainOrderQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/train/v1/order",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TrainOrderQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TrainOrderQueryResponse TrainOrderQuery(TrainOrderQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TrainOrderQueryHeaders headers = new TrainOrderQueryHeaders();
            return TrainOrderQueryWithOptions(request, headers, runtime);
        }

        public async Task<TrainOrderQueryResponse> TrainOrderQueryAsync(TrainOrderQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TrainOrderQueryHeaders headers = new TrainOrderQueryHeaders();
            return await TrainOrderQueryWithOptionsAsync(request, headers, runtime);
        }

        public TrainOrderQueryV2Response TrainOrderQueryV2WithOptions(TrainOrderQueryV2Request request, TrainOrderQueryV2Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["order_id"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["user_id"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TrainOrderQueryV2",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/train/v2/order",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TrainOrderQueryV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<TrainOrderQueryV2Response> TrainOrderQueryV2WithOptionsAsync(TrainOrderQueryV2Request request, TrainOrderQueryV2Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["order_id"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["user_id"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripCorpToken))
            {
                realHeaders["x-acs-btrip-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TrainOrderQueryV2",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/train/v2/order",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TrainOrderQueryV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public TrainOrderQueryV2Response TrainOrderQueryV2(TrainOrderQueryV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TrainOrderQueryV2Headers headers = new TrainOrderQueryV2Headers();
            return TrainOrderQueryV2WithOptions(request, headers, runtime);
        }

        public async Task<TrainOrderQueryV2Response> TrainOrderQueryV2Async(TrainOrderQueryV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TrainOrderQueryV2Headers headers = new TrainOrderQueryV2Headers();
            return await TrainOrderQueryV2WithOptionsAsync(request, headers, runtime);
        }

        public TrainStationSearchResponse TrainStationSearchWithOptions(TrainStationSearchRequest request, TrainStationSearchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TrainStationSearch",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/city/v1/train",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TrainStationSearchResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TrainStationSearchResponse> TrainStationSearchWithOptionsAsync(TrainStationSearchRequest request, TrainStationSearchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TrainStationSearch",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/city/v1/train",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TrainStationSearchResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TrainStationSearchResponse TrainStationSearch(TrainStationSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TrainStationSearchHeaders headers = new TrainStationSearchHeaders();
            return TrainStationSearchWithOptions(request, headers, runtime);
        }

        public async Task<TrainStationSearchResponse> TrainStationSearchAsync(TrainStationSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TrainStationSearchHeaders headers = new TrainStationSearchHeaders();
            return await TrainStationSearchWithOptionsAsync(request, headers, runtime);
        }

        public TrainTicketScanQueryResponse TrainTicketScanQueryWithOptions(TrainTicketScanQueryRequest request, TrainTicketScanQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillDate))
            {
                query["bill_date"] = request.BillDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillId))
            {
                query["bill_id"] = request.BillId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceSubTaskId))
            {
                query["invoice_sub_task_id"] = request.InvoiceSubTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["page_no"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumber))
            {
                query["serial_number"] = request.SerialNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketNo))
            {
                query["ticket_no"] = request.TicketNo;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TrainTicketScanQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/scan/v1/train-ticket",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TrainTicketScanQueryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TrainTicketScanQueryResponse> TrainTicketScanQueryWithOptionsAsync(TrainTicketScanQueryRequest request, TrainTicketScanQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillDate))
            {
                query["bill_date"] = request.BillDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillId))
            {
                query["bill_id"] = request.BillId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceSubTaskId))
            {
                query["invoice_sub_task_id"] = request.InvoiceSubTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["page_no"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumber))
            {
                query["serial_number"] = request.SerialNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketNo))
            {
                query["ticket_no"] = request.TicketNo;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TrainTicketScanQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/scan/v1/train-ticket",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TrainTicketScanQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TrainTicketScanQueryResponse TrainTicketScanQuery(TrainTicketScanQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TrainTicketScanQueryHeaders headers = new TrainTicketScanQueryHeaders();
            return TrainTicketScanQueryWithOptions(request, headers, runtime);
        }

        public async Task<TrainTicketScanQueryResponse> TrainTicketScanQueryAsync(TrainTicketScanQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TrainTicketScanQueryHeaders headers = new TrainTicketScanQueryHeaders();
            return await TrainTicketScanQueryWithOptionsAsync(request, headers, runtime);
        }

        public UserQueryResponse UserQueryWithOptions(UserQueryRequest request, UserQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifiedTimeGreaterOrEqualThan))
            {
                query["modified_time_greater_or_equal_than"] = request.ModifiedTimeGreaterOrEqualThan;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["page_token"] = request.PageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartJobNo))
            {
                query["third_part_job_no"] = request.ThirdPartJobNo;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UserQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/user/v1/user",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UserQueryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UserQueryResponse> UserQueryWithOptionsAsync(UserQueryRequest request, UserQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifiedTimeGreaterOrEqualThan))
            {
                query["modified_time_greater_or_equal_than"] = request.ModifiedTimeGreaterOrEqualThan;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["page_token"] = request.PageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartJobNo))
            {
                query["third_part_job_no"] = request.ThirdPartJobNo;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UserQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/user/v1/user",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UserQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UserQueryResponse UserQuery(UserQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UserQueryHeaders headers = new UserQueryHeaders();
            return UserQueryWithOptions(request, headers, runtime);
        }

        public async Task<UserQueryResponse> UserQueryAsync(UserQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UserQueryHeaders headers = new UserQueryHeaders();
            return await UserQueryWithOptionsAsync(request, headers, runtime);
        }

        public VatInvoiceScanQueryResponse VatInvoiceScanQueryWithOptions(VatInvoiceScanQueryRequest request, VatInvoiceScanQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillDate))
            {
                query["bill_date"] = request.BillDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillId))
            {
                query["bill_id"] = request.BillId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceSubTaskId))
            {
                query["invoice_sub_task_id"] = request.InvoiceSubTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["page_no"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VatInvoiceScanQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/scan/v1/vat-invoice",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<VatInvoiceScanQueryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<VatInvoiceScanQueryResponse> VatInvoiceScanQueryWithOptionsAsync(VatInvoiceScanQueryRequest request, VatInvoiceScanQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillDate))
            {
                query["bill_date"] = request.BillDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillId))
            {
                query["bill_id"] = request.BillId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceSubTaskId))
            {
                query["invoice_sub_task_id"] = request.InvoiceSubTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["page_no"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VatInvoiceScanQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/scan/v1/vat-invoice",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<VatInvoiceScanQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public VatInvoiceScanQueryResponse VatInvoiceScanQuery(VatInvoiceScanQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            VatInvoiceScanQueryHeaders headers = new VatInvoiceScanQueryHeaders();
            return VatInvoiceScanQueryWithOptions(request, headers, runtime);
        }

        public async Task<VatInvoiceScanQueryResponse> VatInvoiceScanQueryAsync(VatInvoiceScanQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            VatInvoiceScanQueryHeaders headers = new VatInvoiceScanQueryHeaders();
            return await VatInvoiceScanQueryWithOptionsAsync(request, headers, runtime);
        }

        public WaitApplyInvoiceTaskDetailQueryResponse WaitApplyInvoiceTaskDetailQueryWithOptions(WaitApplyInvoiceTaskDetailQueryRequest request, WaitApplyInvoiceTaskDetailQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillDate))
            {
                query["bill_date"] = request.BillDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WaitApplyInvoiceTaskDetailQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/invoice/v1/wait-apply-task",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<WaitApplyInvoiceTaskDetailQueryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<WaitApplyInvoiceTaskDetailQueryResponse> WaitApplyInvoiceTaskDetailQueryWithOptionsAsync(WaitApplyInvoiceTaskDetailQueryRequest request, WaitApplyInvoiceTaskDetailQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillDate))
            {
                query["bill_date"] = request.BillDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsBtripSoCorpToken))
            {
                realHeaders["x-acs-btrip-so-corp-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsBtripSoCorpToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WaitApplyInvoiceTaskDetailQuery",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/invoice/v1/wait-apply-task",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<WaitApplyInvoiceTaskDetailQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public WaitApplyInvoiceTaskDetailQueryResponse WaitApplyInvoiceTaskDetailQuery(WaitApplyInvoiceTaskDetailQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            WaitApplyInvoiceTaskDetailQueryHeaders headers = new WaitApplyInvoiceTaskDetailQueryHeaders();
            return WaitApplyInvoiceTaskDetailQueryWithOptions(request, headers, runtime);
        }

        public async Task<WaitApplyInvoiceTaskDetailQueryResponse> WaitApplyInvoiceTaskDetailQueryAsync(WaitApplyInvoiceTaskDetailQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            WaitApplyInvoiceTaskDetailQueryHeaders headers = new WaitApplyInvoiceTaskDetailQueryHeaders();
            return await WaitApplyInvoiceTaskDetailQueryWithOptionsAsync(request, headers, runtime);
        }

    }
}
