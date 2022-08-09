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
            this._signatureAlgorithm = "v2";
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

        public AccessTokenResponse AccessTokenWithOptions(AccessTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["app_key"] = request.AppKey;
            }
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
                AuthType = "Anonymous",
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["app_key"] = request.AppKey;
            }
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
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AccessTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddressGetResponse AddressGet(AddressGetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddressGetWithOptions(request, headers, runtime);
        }

        public async Task<AddressGetResponse> AddressGetAsync(AddressGetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddressGetWithOptionsAsync(request, headers, runtime);
        }

        public AddressGetResponse AddressGetWithOptions(AddressGetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionType))
            {
                query["action_type"] = request.ActionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItineraryId))
            {
                query["itinerary_id"] = request.ItineraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                query["phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["user_id"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public async Task<AddressGetResponse> AddressGetWithOptionsAsync(AddressGetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionType))
            {
                query["action_type"] = request.ActionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItineraryId))
            {
                query["itinerary_id"] = request.ItineraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                query["phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["user_id"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public ApplyAddResponse ApplyAdd(ApplyAddRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ApplyAddWithOptions(request, headers, runtime);
        }

        public async Task<ApplyAddResponse> ApplyAddAsync(ApplyAddRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ApplyAddWithOptionsAsync(request, headers, runtime);
        }

        public ApplyAddResponse ApplyAddWithOptions(ApplyAddRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ApplyAddShrinkRequest request = new ApplyAddShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExternalTravelerList))
            {
                request.ExternalTravelerListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExternalTravelerList, "external_traveler_list", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExternalTravelerStandard.ToMap()))
            {
                request.ExternalTravelerStandardShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExternalTravelerStandard.ToMap(), "external_traveler_standard", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HotelShare.ToMap()))
            {
                request.HotelShareShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HotelShare.ToMap(), "hotel_share", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ItineraryList))
            {
                request.ItineraryListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ItineraryList, "itinerary_list", "json");
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LimitTraveler))
            {
                body["limit_traveler"] = request.LimitTraveler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartApplyId))
            {
                body["thirdpart_apply_id"] = request.ThirdpartApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartBusinessId))
            {
                body["thirdpart_business_id"] = request.ThirdpartBusinessId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public async Task<ApplyAddResponse> ApplyAddWithOptionsAsync(ApplyAddRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ApplyAddShrinkRequest request = new ApplyAddShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExternalTravelerList))
            {
                request.ExternalTravelerListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExternalTravelerList, "external_traveler_list", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExternalTravelerStandard.ToMap()))
            {
                request.ExternalTravelerStandardShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExternalTravelerStandard.ToMap(), "external_traveler_standard", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HotelShare.ToMap()))
            {
                request.HotelShareShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HotelShare.ToMap(), "hotel_share", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ItineraryList))
            {
                request.ItineraryListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ItineraryList, "itinerary_list", "json");
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LimitTraveler))
            {
                body["limit_traveler"] = request.LimitTraveler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartApplyId))
            {
                body["thirdpart_apply_id"] = request.ThirdpartApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartBusinessId))
            {
                body["thirdpart_business_id"] = request.ThirdpartBusinessId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public ApplyListQueryResponse ApplyListQuery(ApplyListQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ApplyListQueryWithOptions(request, headers, runtime);
        }

        public async Task<ApplyListQueryResponse> ApplyListQueryAsync(ApplyListQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ApplyListQueryWithOptionsAsync(request, headers, runtime);
        }

        public ApplyListQueryResponse ApplyListQueryWithOptions(ApplyListQueryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public async Task<ApplyListQueryResponse> ApplyListQueryWithOptionsAsync(ApplyListQueryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public ApplyModifyResponse ApplyModify(ApplyModifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ApplyModifyWithOptions(request, headers, runtime);
        }

        public async Task<ApplyModifyResponse> ApplyModifyAsync(ApplyModifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ApplyModifyWithOptionsAsync(request, headers, runtime);
        }

        public ApplyModifyResponse ApplyModifyWithOptions(ApplyModifyRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ApplyModifyShrinkRequest request = new ApplyModifyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExternalTravelerList))
            {
                request.ExternalTravelerListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExternalTravelerList, "external_traveler_list", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExternalTravelerStandard.ToMap()))
            {
                request.ExternalTravelerStandardShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExternalTravelerStandard.ToMap(), "external_traveler_standard", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HotelShare.ToMap()))
            {
                request.HotelShareShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HotelShare.ToMap(), "hotel_share", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ItineraryList))
            {
                request.ItineraryListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ItineraryList, "itinerary_list", "json");
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LimitTraveler))
            {
                body["limit_traveler"] = request.LimitTraveler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartApplyId))
            {
                body["thirdpart_apply_id"] = request.ThirdpartApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartBusinessId))
            {
                body["thirdpart_business_id"] = request.ThirdpartBusinessId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public async Task<ApplyModifyResponse> ApplyModifyWithOptionsAsync(ApplyModifyRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ApplyModifyShrinkRequest request = new ApplyModifyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExternalTravelerList))
            {
                request.ExternalTravelerListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExternalTravelerList, "external_traveler_list", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExternalTravelerStandard.ToMap()))
            {
                request.ExternalTravelerStandardShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExternalTravelerStandard.ToMap(), "external_traveler_standard", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HotelShare.ToMap()))
            {
                request.HotelShareShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HotelShare.ToMap(), "hotel_share", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ItineraryList))
            {
                request.ItineraryListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ItineraryList, "itinerary_list", "json");
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LimitTraveler))
            {
                body["limit_traveler"] = request.LimitTraveler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartApplyId))
            {
                body["thirdpart_apply_id"] = request.ThirdpartApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartBusinessId))
            {
                body["thirdpart_business_id"] = request.ThirdpartBusinessId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public ApplyQueryResponse ApplyQuery(ApplyQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ApplyQueryWithOptions(request, headers, runtime);
        }

        public async Task<ApplyQueryResponse> ApplyQueryAsync(ApplyQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ApplyQueryWithOptionsAsync(request, headers, runtime);
        }

        public ApplyQueryResponse ApplyQueryWithOptions(ApplyQueryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartApplyId))
            {
                query["thirdpart_apply_id"] = request.ThirdpartApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public async Task<ApplyQueryResponse> ApplyQueryWithOptionsAsync(ApplyQueryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartApplyId))
            {
                query["thirdpart_apply_id"] = request.ThirdpartApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public CarApplyAddResponse CarApplyAdd(CarApplyAddRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CarApplyAddWithOptions(request, headers, runtime);
        }

        public async Task<CarApplyAddResponse> CarApplyAddAsync(CarApplyAddRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CarApplyAddWithOptionsAsync(request, headers, runtime);
        }

        public CarApplyAddResponse CarApplyAddWithOptions(CarApplyAddRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cause))
            {
                body["cause"] = request.Cause;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                body["city"] = request.City;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public async Task<CarApplyAddResponse> CarApplyAddWithOptionsAsync(CarApplyAddRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cause))
            {
                body["cause"] = request.Cause;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                body["city"] = request.City;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public CarApplyModifyResponse CarApplyModify(CarApplyModifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CarApplyModifyWithOptions(request, headers, runtime);
        }

        public async Task<CarApplyModifyResponse> CarApplyModifyAsync(CarApplyModifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CarApplyModifyWithOptionsAsync(request, headers, runtime);
        }

        public CarApplyModifyResponse CarApplyModifyWithOptions(CarApplyModifyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corp_id"] = request.CorpId;
            }
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public async Task<CarApplyModifyResponse> CarApplyModifyWithOptionsAsync(CarApplyModifyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corp_id"] = request.CorpId;
            }
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public CarApplyQueryResponse CarApplyQuery(CarApplyQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CarApplyQueryWithOptions(request, headers, runtime);
        }

        public async Task<CarApplyQueryResponse> CarApplyQueryAsync(CarApplyQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CarApplyQueryWithOptionsAsync(request, headers, runtime);
        }

        public CarApplyQueryResponse CarApplyQueryWithOptions(CarApplyQueryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corp_id"] = request.CorpId;
            }
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public async Task<CarApplyQueryResponse> CarApplyQueryWithOptionsAsync(CarApplyQueryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corp_id"] = request.CorpId;
            }
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public CarBillSettlementQueryResponse CarBillSettlementQuery(CarBillSettlementQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CarBillSettlementQueryWithOptions(request, headers, runtime);
        }

        public async Task<CarBillSettlementQueryResponse> CarBillSettlementQueryAsync(CarBillSettlementQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CarBillSettlementQueryWithOptionsAsync(request, headers, runtime);
        }

        public CarBillSettlementQueryResponse CarBillSettlementQueryWithOptions(CarBillSettlementQueryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public async Task<CarBillSettlementQueryResponse> CarBillSettlementQueryWithOptionsAsync(CarBillSettlementQueryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public CarOrderListQueryResponse CarOrderListQuery(CarOrderListQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CarOrderListQueryWithOptions(request, headers, runtime);
        }

        public async Task<CarOrderListQueryResponse> CarOrderListQueryAsync(CarOrderListQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CarOrderListQueryWithOptionsAsync(request, headers, runtime);
        }

        public CarOrderListQueryResponse CarOrderListQueryWithOptions(CarOrderListQueryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public async Task<CarOrderListQueryResponse> CarOrderListQueryWithOptionsAsync(CarOrderListQueryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public CommonApplyQueryResponse CommonApplyQuery(CommonApplyQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CommonApplyQueryWithOptions(request, headers, runtime);
        }

        public async Task<CommonApplyQueryResponse> CommonApplyQueryAsync(CommonApplyQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CommonApplyQueryWithOptionsAsync(request, headers, runtime);
        }

        public CommonApplyQueryResponse CommonApplyQueryWithOptions(CommonApplyQueryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corp_id"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["user_id"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public async Task<CommonApplyQueryResponse> CommonApplyQueryWithOptionsAsync(CommonApplyQueryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corp_id"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["user_id"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public CommonApplySyncResponse CommonApplySync(CommonApplySyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CommonApplySyncWithOptions(request, headers, runtime);
        }

        public async Task<CommonApplySyncResponse> CommonApplySyncAsync(CommonApplySyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CommonApplySyncWithOptionsAsync(request, headers, runtime);
        }

        public CommonApplySyncResponse CommonApplySyncWithOptions(CommonApplySyncRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public async Task<CommonApplySyncResponse> CommonApplySyncWithOptionsAsync(CommonApplySyncRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public CorpTokenResponse CorpToken(CorpTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CorpTokenWithOptions(request, headers, runtime);
        }

        public async Task<CorpTokenResponse> CorpTokenAsync(CorpTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CorpTokenWithOptionsAsync(request, headers, runtime);
        }

        public CorpTokenResponse CorpTokenWithOptions(CorpTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corp_id"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public async Task<CorpTokenResponse> CorpTokenWithOptionsAsync(CorpTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corp_id"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public CostCenterDeleteResponse CostCenterDelete(CostCenterDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CostCenterDeleteWithOptions(request, headers, runtime);
        }

        public async Task<CostCenterDeleteResponse> CostCenterDeleteAsync(CostCenterDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CostCenterDeleteWithOptionsAsync(request, headers, runtime);
        }

        public CostCenterDeleteResponse CostCenterDeleteWithOptions(CostCenterDeleteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartId))
            {
                query["thirdpart_id"] = request.ThirdpartId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public async Task<CostCenterDeleteResponse> CostCenterDeleteWithOptionsAsync(CostCenterDeleteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartId))
            {
                query["thirdpart_id"] = request.ThirdpartId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public CostCenterModifyResponse CostCenterModify(CostCenterModifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CostCenterModifyWithOptions(request, headers, runtime);
        }

        public async Task<CostCenterModifyResponse> CostCenterModifyAsync(CostCenterModifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CostCenterModifyWithOptionsAsync(request, headers, runtime);
        }

        public CostCenterModifyResponse CostCenterModifyWithOptions(CostCenterModifyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlipayNo))
            {
                body["alipay_no"] = request.AlipayNo;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public async Task<CostCenterModifyResponse> CostCenterModifyWithOptionsAsync(CostCenterModifyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlipayNo))
            {
                body["alipay_no"] = request.AlipayNo;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public CostCenterQueryResponse CostCenterQuery(CostCenterQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CostCenterQueryWithOptions(request, headers, runtime);
        }

        public async Task<CostCenterQueryResponse> CostCenterQueryAsync(CostCenterQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CostCenterQueryWithOptionsAsync(request, headers, runtime);
        }

        public CostCenterQueryResponse CostCenterQueryWithOptions(CostCenterQueryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corp_id"] = request.CorpId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedOrgEntity))
            {
                body["need_org_entity"] = request.NeedOrgEntity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartId))
            {
                body["thirdpart_id"] = request.ThirdpartId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CostCenterQueryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CostCenterQueryResponse> CostCenterQueryWithOptionsAsync(CostCenterQueryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corp_id"] = request.CorpId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedOrgEntity))
            {
                body["need_org_entity"] = request.NeedOrgEntity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartId))
            {
                body["thirdpart_id"] = request.ThirdpartId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CostCenterQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CostCenterSaveResponse CostCenterSave(CostCenterSaveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CostCenterSaveWithOptions(request, headers, runtime);
        }

        public async Task<CostCenterSaveResponse> CostCenterSaveAsync(CostCenterSaveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CostCenterSaveWithOptionsAsync(request, headers, runtime);
        }

        public CostCenterSaveResponse CostCenterSaveWithOptions(CostCenterSaveRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlipayNo))
            {
                body["alipay_no"] = request.AlipayNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corp_id"] = request.CorpId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public async Task<CostCenterSaveResponse> CostCenterSaveWithOptionsAsync(CostCenterSaveRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlipayNo))
            {
                body["alipay_no"] = request.AlipayNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corp_id"] = request.CorpId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public DepartmentSaveResponse DepartmentSave(DepartmentSaveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DepartmentSaveWithOptions(request, headers, runtime);
        }

        public async Task<DepartmentSaveResponse> DepartmentSaveAsync(DepartmentSaveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DepartmentSaveWithOptionsAsync(request, headers, runtime);
        }

        public DepartmentSaveResponse DepartmentSaveWithOptions(DepartmentSaveRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public async Task<DepartmentSaveResponse> DepartmentSaveWithOptionsAsync(DepartmentSaveRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public EntityAddResponse EntityAdd(EntityAddRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return EntityAddWithOptions(request, headers, runtime);
        }

        public async Task<EntityAddResponse> EntityAddAsync(EntityAddRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await EntityAddWithOptionsAsync(request, headers, runtime);
        }

        public EntityAddResponse EntityAddWithOptions(EntityAddRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public async Task<EntityAddResponse> EntityAddWithOptionsAsync(EntityAddRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public EntityDeleteResponse EntityDelete(EntityDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return EntityDeleteWithOptions(request, headers, runtime);
        }

        public async Task<EntityDeleteResponse> EntityDeleteAsync(EntityDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await EntityDeleteWithOptionsAsync(request, headers, runtime);
        }

        public EntityDeleteResponse EntityDeleteWithOptions(EntityDeleteRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public async Task<EntityDeleteResponse> EntityDeleteWithOptionsAsync(EntityDeleteRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public EntitySetResponse EntitySet(EntitySetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return EntitySetWithOptions(request, headers, runtime);
        }

        public async Task<EntitySetResponse> EntitySetAsync(EntitySetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await EntitySetWithOptionsAsync(request, headers, runtime);
        }

        public EntitySetResponse EntitySetWithOptions(EntitySetRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public async Task<EntitySetResponse> EntitySetWithOptionsAsync(EntitySetRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public ExceedApplySyncResponse ExceedApplySync(ExceedApplySyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ExceedApplySyncWithOptions(request, headers, runtime);
        }

        public async Task<ExceedApplySyncResponse> ExceedApplySyncAsync(ExceedApplySyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ExceedApplySyncWithOptionsAsync(request, headers, runtime);
        }

        public ExceedApplySyncResponse ExceedApplySyncWithOptions(ExceedApplySyncRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corp_id"] = request.CorpId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public async Task<ExceedApplySyncResponse> ExceedApplySyncWithOptionsAsync(ExceedApplySyncRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corp_id"] = request.CorpId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public FlightBillSettlementQueryResponse FlightBillSettlementQuery(FlightBillSettlementQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return FlightBillSettlementQueryWithOptions(request, headers, runtime);
        }

        public async Task<FlightBillSettlementQueryResponse> FlightBillSettlementQueryAsync(FlightBillSettlementQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await FlightBillSettlementQueryWithOptionsAsync(request, headers, runtime);
        }

        public FlightBillSettlementQueryResponse FlightBillSettlementQueryWithOptions(FlightBillSettlementQueryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public async Task<FlightBillSettlementQueryResponse> FlightBillSettlementQueryWithOptionsAsync(FlightBillSettlementQueryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public FlightExceedApplyQueryResponse FlightExceedApplyQuery(FlightExceedApplyQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return FlightExceedApplyQueryWithOptions(request, headers, runtime);
        }

        public async Task<FlightExceedApplyQueryResponse> FlightExceedApplyQueryAsync(FlightExceedApplyQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await FlightExceedApplyQueryWithOptionsAsync(request, headers, runtime);
        }

        public FlightExceedApplyQueryResponse FlightExceedApplyQueryWithOptions(FlightExceedApplyQueryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyId))
            {
                query["apply_id"] = request.ApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corp_id"] = request.CorpId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public async Task<FlightExceedApplyQueryResponse> FlightExceedApplyQueryWithOptionsAsync(FlightExceedApplyQueryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyId))
            {
                query["apply_id"] = request.ApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corp_id"] = request.CorpId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public FlightOrderListQueryResponse FlightOrderListQuery(FlightOrderListQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return FlightOrderListQueryWithOptions(request, headers, runtime);
        }

        public async Task<FlightOrderListQueryResponse> FlightOrderListQueryAsync(FlightOrderListQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await FlightOrderListQueryWithOptionsAsync(request, headers, runtime);
        }

        public FlightOrderListQueryResponse FlightOrderListQueryWithOptions(FlightOrderListQueryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public async Task<FlightOrderListQueryResponse> FlightOrderListQueryWithOptionsAsync(FlightOrderListQueryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public FlightOrderQueryResponse FlightOrderQuery(FlightOrderQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return FlightOrderQueryWithOptions(request, headers, runtime);
        }

        public async Task<FlightOrderQueryResponse> FlightOrderQueryAsync(FlightOrderQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await FlightOrderQueryWithOptionsAsync(request, headers, runtime);
        }

        public FlightOrderQueryResponse FlightOrderQueryWithOptions(FlightOrderQueryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public async Task<FlightOrderQueryResponse> FlightOrderQueryWithOptionsAsync(FlightOrderQueryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public HotelBillSettlementQueryResponse HotelBillSettlementQuery(HotelBillSettlementQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return HotelBillSettlementQueryWithOptions(request, headers, runtime);
        }

        public async Task<HotelBillSettlementQueryResponse> HotelBillSettlementQueryAsync(HotelBillSettlementQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await HotelBillSettlementQueryWithOptionsAsync(request, headers, runtime);
        }

        public HotelBillSettlementQueryResponse HotelBillSettlementQueryWithOptions(HotelBillSettlementQueryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public async Task<HotelBillSettlementQueryResponse> HotelBillSettlementQueryWithOptionsAsync(HotelBillSettlementQueryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public HotelExceedApplyQueryResponse HotelExceedApplyQuery(HotelExceedApplyQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return HotelExceedApplyQueryWithOptions(request, headers, runtime);
        }

        public async Task<HotelExceedApplyQueryResponse> HotelExceedApplyQueryAsync(HotelExceedApplyQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await HotelExceedApplyQueryWithOptionsAsync(request, headers, runtime);
        }

        public HotelExceedApplyQueryResponse HotelExceedApplyQueryWithOptions(HotelExceedApplyQueryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyId))
            {
                query["apply_id"] = request.ApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corp_id"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["user_id"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public async Task<HotelExceedApplyQueryResponse> HotelExceedApplyQueryWithOptionsAsync(HotelExceedApplyQueryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyId))
            {
                query["apply_id"] = request.ApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corp_id"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["user_id"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public HotelOrderListQueryResponse HotelOrderListQuery(HotelOrderListQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return HotelOrderListQueryWithOptions(request, headers, runtime);
        }

        public async Task<HotelOrderListQueryResponse> HotelOrderListQueryAsync(HotelOrderListQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await HotelOrderListQueryWithOptionsAsync(request, headers, runtime);
        }

        public HotelOrderListQueryResponse HotelOrderListQueryWithOptions(HotelOrderListQueryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public async Task<HotelOrderListQueryResponse> HotelOrderListQueryWithOptionsAsync(HotelOrderListQueryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public InvoiceAddResponse InvoiceAdd(InvoiceAddRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return InvoiceAddWithOptions(request, headers, runtime);
        }

        public async Task<InvoiceAddResponse> InvoiceAddAsync(InvoiceAddRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await InvoiceAddWithOptionsAsync(request, headers, runtime);
        }

        public InvoiceAddResponse InvoiceAddWithOptions(InvoiceAddRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public async Task<InvoiceAddResponse> InvoiceAddWithOptionsAsync(InvoiceAddRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public InvoiceDeleteResponse InvoiceDelete(InvoiceDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return InvoiceDeleteWithOptions(request, headers, runtime);
        }

        public async Task<InvoiceDeleteResponse> InvoiceDeleteAsync(InvoiceDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await InvoiceDeleteWithOptionsAsync(request, headers, runtime);
        }

        public InvoiceDeleteResponse InvoiceDeleteWithOptions(InvoiceDeleteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartId))
            {
                query["third_part_id"] = request.ThirdPartId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public async Task<InvoiceDeleteResponse> InvoiceDeleteWithOptionsAsync(InvoiceDeleteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartId))
            {
                query["third_part_id"] = request.ThirdPartId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public InvoiceModifyResponse InvoiceModify(InvoiceModifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return InvoiceModifyWithOptions(request, headers, runtime);
        }

        public async Task<InvoiceModifyResponse> InvoiceModifyAsync(InvoiceModifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await InvoiceModifyWithOptionsAsync(request, headers, runtime);
        }

        public InvoiceModifyResponse InvoiceModifyWithOptions(InvoiceModifyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public async Task<InvoiceModifyResponse> InvoiceModifyWithOptionsAsync(InvoiceModifyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public InvoiceRuleSaveResponse InvoiceRuleSave(InvoiceRuleSaveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return InvoiceRuleSaveWithOptions(request, headers, runtime);
        }

        public async Task<InvoiceRuleSaveResponse> InvoiceRuleSaveAsync(InvoiceRuleSaveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await InvoiceRuleSaveWithOptionsAsync(request, headers, runtime);
        }

        public InvoiceRuleSaveResponse InvoiceRuleSaveWithOptions(InvoiceRuleSaveRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartId))
            {
                body["third_part_id"] = request.ThirdPartId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public async Task<InvoiceRuleSaveResponse> InvoiceRuleSaveWithOptionsAsync(InvoiceRuleSaveRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartId))
            {
                body["third_part_id"] = request.ThirdPartId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public InvoiceSearchResponse InvoiceSearch(InvoiceSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return InvoiceSearchWithOptions(request, headers, runtime);
        }

        public async Task<InvoiceSearchResponse> InvoiceSearchAsync(InvoiceSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await InvoiceSearchWithOptionsAsync(request, headers, runtime);
        }

        public InvoiceSearchResponse InvoiceSearchWithOptions(InvoiceSearchRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public async Task<InvoiceSearchResponse> InvoiceSearchWithOptionsAsync(InvoiceSearchRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public IsvUserSaveResponse IsvUserSave(IsvUserSaveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return IsvUserSaveWithOptions(request, headers, runtime);
        }

        public async Task<IsvUserSaveResponse> IsvUserSaveAsync(IsvUserSaveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await IsvUserSaveWithOptionsAsync(request, headers, runtime);
        }

        public IsvUserSaveResponse IsvUserSaveWithOptions(IsvUserSaveRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public async Task<IsvUserSaveResponse> IsvUserSaveWithOptionsAsync(IsvUserSaveRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public MonthBillGetResponse MonthBillGet(MonthBillGetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return MonthBillGetWithOptions(request, headers, runtime);
        }

        public async Task<MonthBillGetResponse> MonthBillGetAsync(MonthBillGetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await MonthBillGetWithOptionsAsync(request, headers, runtime);
        }

        public MonthBillGetResponse MonthBillGetWithOptions(MonthBillGetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillMonth))
            {
                query["bill_month"] = request.BillMonth;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public async Task<MonthBillGetResponse> MonthBillGetWithOptionsAsync(MonthBillGetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillMonth))
            {
                query["bill_month"] = request.BillMonth;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public ProjectAddResponse ProjectAdd(ProjectAddRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ProjectAddWithOptions(request, headers, runtime);
        }

        public async Task<ProjectAddResponse> ProjectAddAsync(ProjectAddRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ProjectAddWithOptionsAsync(request, headers, runtime);
        }

        public ProjectAddResponse ProjectAddWithOptions(ProjectAddRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corp_id"] = request.CorpId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public async Task<ProjectAddResponse> ProjectAddWithOptionsAsync(ProjectAddRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corp_id"] = request.CorpId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public ProjectDeleteResponse ProjectDelete(ProjectDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ProjectDeleteWithOptions(request, headers, runtime);
        }

        public async Task<ProjectDeleteResponse> ProjectDeleteAsync(ProjectDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ProjectDeleteWithOptionsAsync(request, headers, runtime);
        }

        public ProjectDeleteResponse ProjectDeleteWithOptions(ProjectDeleteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartId))
            {
                query["third_part_id"] = request.ThirdPartId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public async Task<ProjectDeleteResponse> ProjectDeleteWithOptionsAsync(ProjectDeleteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartId))
            {
                query["third_part_id"] = request.ThirdPartId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public ProjectModifyResponse ProjectModify(ProjectModifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ProjectModifyWithOptions(request, headers, runtime);
        }

        public async Task<ProjectModifyResponse> ProjectModifyAsync(ProjectModifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ProjectModifyWithOptionsAsync(request, headers, runtime);
        }

        public ProjectModifyResponse ProjectModifyWithOptions(ProjectModifyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corp_id"] = request.CorpId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public async Task<ProjectModifyResponse> ProjectModifyWithOptionsAsync(ProjectModifyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corp_id"] = request.CorpId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public TrainBillSettlementQueryResponse TrainBillSettlementQuery(TrainBillSettlementQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TrainBillSettlementQueryWithOptions(request, headers, runtime);
        }

        public async Task<TrainBillSettlementQueryResponse> TrainBillSettlementQueryAsync(TrainBillSettlementQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TrainBillSettlementQueryWithOptionsAsync(request, headers, runtime);
        }

        public TrainBillSettlementQueryResponse TrainBillSettlementQueryWithOptions(TrainBillSettlementQueryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public async Task<TrainBillSettlementQueryResponse> TrainBillSettlementQueryWithOptionsAsync(TrainBillSettlementQueryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public TrainExceedApplyQueryResponse TrainExceedApplyQuery(TrainExceedApplyQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TrainExceedApplyQueryWithOptions(request, headers, runtime);
        }

        public async Task<TrainExceedApplyQueryResponse> TrainExceedApplyQueryAsync(TrainExceedApplyQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TrainExceedApplyQueryWithOptionsAsync(request, headers, runtime);
        }

        public TrainExceedApplyQueryResponse TrainExceedApplyQueryWithOptions(TrainExceedApplyQueryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyId))
            {
                query["apply_id"] = request.ApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corp_id"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["user_id"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public async Task<TrainExceedApplyQueryResponse> TrainExceedApplyQueryWithOptionsAsync(TrainExceedApplyQueryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyId))
            {
                query["apply_id"] = request.ApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corp_id"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["user_id"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public TrainOrderListQueryResponse TrainOrderListQuery(TrainOrderListQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TrainOrderListQueryWithOptions(request, headers, runtime);
        }

        public async Task<TrainOrderListQueryResponse> TrainOrderListQueryAsync(TrainOrderListQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TrainOrderListQueryWithOptionsAsync(request, headers, runtime);
        }

        public TrainOrderListQueryResponse TrainOrderListQueryWithOptions(TrainOrderListQueryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public async Task<TrainOrderListQueryResponse> TrainOrderListQueryWithOptionsAsync(TrainOrderListQueryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public TrainOrderQueryResponse TrainOrderQuery(TrainOrderQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TrainOrderQueryWithOptions(request, headers, runtime);
        }

        public async Task<TrainOrderQueryResponse> TrainOrderQueryAsync(TrainOrderQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TrainOrderQueryWithOptionsAsync(request, headers, runtime);
        }

        public TrainOrderQueryResponse TrainOrderQueryWithOptions(TrainOrderQueryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public async Task<TrainOrderQueryResponse> TrainOrderQueryWithOptionsAsync(TrainOrderQueryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public UserQueryResponse UserQuery(UserQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UserQueryWithOptions(request, headers, runtime);
        }

        public async Task<UserQueryResponse> UserQueryAsync(UserQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UserQueryWithOptionsAsync(request, headers, runtime);
        }

        public UserQueryResponse UserQueryWithOptions(UserQueryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifiedTimeGreaterOrEqualThan))
            {
                query["modified_time_greater_or_equal_than"] = request.ModifiedTimeGreaterOrEqualThan;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartCorpId))
            {
                query["third_part_corp_id"] = request.ThirdPartCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartJobNo))
            {
                query["third_part_job_no"] = request.ThirdPartJobNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

        public async Task<UserQueryResponse> UserQueryWithOptionsAsync(UserQueryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifiedTimeGreaterOrEqualThan))
            {
                query["modified_time_greater_or_equal_than"] = request.ModifiedTimeGreaterOrEqualThan;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartCorpId))
            {
                query["third_part_corp_id"] = request.ThirdPartCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartJobNo))
            {
                query["third_part_job_no"] = request.ThirdPartJobNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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

    }
}
