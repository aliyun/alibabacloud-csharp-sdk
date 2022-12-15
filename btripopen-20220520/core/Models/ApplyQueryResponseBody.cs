// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ApplyQueryResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public ApplyQueryResponseBodyModule Module { get; set; }
        public class ApplyQueryResponseBodyModule : TeaModel {
            [NameInMap("apply_show_id")]
            [Validation(Required=false)]
            public string ApplyShowId { get; set; }

            [NameInMap("approver_list")]
            [Validation(Required=false)]
            public List<ApplyQueryResponseBodyModuleApproverList> ApproverList { get; set; }
            public class ApplyQueryResponseBodyModuleApproverList : TeaModel {
                [NameInMap("note")]
                [Validation(Required=false)]
                public string Note { get; set; }

                [NameInMap("operate_time")]
                [Validation(Required=false)]
                public string OperateTime { get; set; }

                [NameInMap("order")]
                [Validation(Required=false)]
                public int? Order { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("status_desc")]
                [Validation(Required=false)]
                public string StatusDesc { get; set; }

                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("user_name")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            [NameInMap("budget")]
            [Validation(Required=false)]
            public long? Budget { get; set; }

            [NameInMap("budget_merge")]
            [Validation(Required=false)]
            public int? BudgetMerge { get; set; }

            [NameInMap("corp_id")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("corp_name")]
            [Validation(Required=false)]
            public string CorpName { get; set; }

            [NameInMap("depart_id")]
            [Validation(Required=false)]
            public string DepartId { get; set; }

            [NameInMap("depart_name")]
            [Validation(Required=false)]
            public string DepartName { get; set; }

            [NameInMap("external_traveler_list")]
            [Validation(Required=false)]
            public List<ApplyQueryResponseBodyModuleExternalTravelerList> ExternalTravelerList { get; set; }
            public class ApplyQueryResponseBodyModuleExternalTravelerList : TeaModel {
                [NameInMap("business_discount")]
                [Validation(Required=false)]
                public int? BusinessDiscount { get; set; }

                [NameInMap("economy_discount")]
                [Validation(Required=false)]
                public int? EconomyDiscount { get; set; }

                [NameInMap("first_discount")]
                [Validation(Required=false)]
                public int? FirstDiscount { get; set; }

                [NameInMap("flight_cabins")]
                [Validation(Required=false)]
                public string FlightCabins { get; set; }

                [NameInMap("hotel_citys")]
                [Validation(Required=false)]
                public List<ApplyQueryResponseBodyModuleExternalTravelerListHotelCitys> HotelCitys { get; set; }
                public class ApplyQueryResponseBodyModuleExternalTravelerListHotelCitys : TeaModel {
                    [NameInMap("city_code")]
                    [Validation(Required=false)]
                    public string CityCode { get; set; }

                    [NameInMap("city_name")]
                    [Validation(Required=false)]
                    public string CityName { get; set; }

                    [NameInMap("fee")]
                    [Validation(Required=false)]
                    public long? Fee { get; set; }

                }

                [NameInMap("premium_economy_discount")]
                [Validation(Required=false)]
                public int? PremiumEconomyDiscount { get; set; }

                [NameInMap("reserve_type")]
                [Validation(Required=false)]
                public int? ReserveType { get; set; }

                [NameInMap("train_seats")]
                [Validation(Required=false)]
                public string TrainSeats { get; set; }

                [NameInMap("user_name")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            [NameInMap("flight_budget")]
            [Validation(Required=false)]
            public long? FlightBudget { get; set; }

            [NameInMap("gmt_create")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("gmt_modified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("hotel_budget")]
            [Validation(Required=false)]
            public long? HotelBudget { get; set; }

            [NameInMap("hotel_share")]
            [Validation(Required=false)]
            public ApplyQueryResponseBodyModuleHotelShare HotelShare { get; set; }
            public class ApplyQueryResponseBodyModuleHotelShare : TeaModel {
                [NameInMap("param")]
                [Validation(Required=false)]
                public string Param { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("itinerary_list")]
            [Validation(Required=false)]
            public List<ApplyQueryResponseBodyModuleItineraryList> ItineraryList { get; set; }
            public class ApplyQueryResponseBodyModuleItineraryList : TeaModel {
                [NameInMap("arr_city")]
                [Validation(Required=false)]
                public string ArrCity { get; set; }

                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                [NameInMap("arr_date")]
                [Validation(Required=false)]
                public string ArrDate { get; set; }

                [NameInMap("cost_center_name")]
                [Validation(Required=false)]
                public string CostCenterName { get; set; }

                [NameInMap("dep_city")]
                [Validation(Required=false)]
                public string DepCity { get; set; }

                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                [NameInMap("dep_date")]
                [Validation(Required=false)]
                public string DepDate { get; set; }

                [NameInMap("invoice_name")]
                [Validation(Required=false)]
                public string InvoiceName { get; set; }

                [NameInMap("itinerary_id")]
                [Validation(Required=false)]
                public string ItineraryId { get; set; }

                [NameInMap("project_code")]
                [Validation(Required=false)]
                public string ProjectCode { get; set; }

                [NameInMap("project_title")]
                [Validation(Required=false)]
                public string ProjectTitle { get; set; }

                [NameInMap("traffic_type")]
                [Validation(Required=false)]
                public int? TrafficType { get; set; }

                [NameInMap("trip_way")]
                [Validation(Required=false)]
                public int? TripWay { get; set; }

            }

            [NameInMap("itinerary_rule")]
            [Validation(Required=false)]
            public int? ItineraryRule { get; set; }

            [NameInMap("itinerary_set_list")]
            [Validation(Required=false)]
            public List<ApplyQueryResponseBodyModuleItinerarySetList> ItinerarySetList { get; set; }
            public class ApplyQueryResponseBodyModuleItinerarySetList : TeaModel {
                [NameInMap("arr_date")]
                [Validation(Required=false)]
                public string ArrDate { get; set; }

                [NameInMap("city_code_set")]
                [Validation(Required=false)]
                public string CityCodeSet { get; set; }

                [NameInMap("city_set")]
                [Validation(Required=false)]
                public string CitySet { get; set; }

                [NameInMap("cost_center_name")]
                [Validation(Required=false)]
                public string CostCenterName { get; set; }

                [NameInMap("dep_date")]
                [Validation(Required=false)]
                public string DepDate { get; set; }

                [NameInMap("invoice_name")]
                [Validation(Required=false)]
                public string InvoiceName { get; set; }

                [NameInMap("itinerary_id")]
                [Validation(Required=false)]
                public string ItineraryId { get; set; }

                [NameInMap("project_code")]
                [Validation(Required=false)]
                public string ProjectCode { get; set; }

                [NameInMap("project_title")]
                [Validation(Required=false)]
                public string ProjectTitle { get; set; }

                [NameInMap("traffic_type")]
                [Validation(Required=false)]
                public int? TrafficType { get; set; }

            }

            [NameInMap("limit_traveler")]
            [Validation(Required=false)]
            public int? LimitTraveler { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("status_desc")]
            [Validation(Required=false)]
            public string StatusDesc { get; set; }

            [NameInMap("thirdpart_business_id")]
            [Validation(Required=false)]
            public string ThirdpartBusinessId { get; set; }

            [NameInMap("thirdpart_id")]
            [Validation(Required=false)]
            public string ThirdpartId { get; set; }

            [NameInMap("together_book_rule")]
            [Validation(Required=false)]
            public int? TogetherBookRule { get; set; }

            [NameInMap("train_budget")]
            [Validation(Required=false)]
            public long? TrainBudget { get; set; }

            [NameInMap("traveler_list")]
            [Validation(Required=false)]
            public List<ApplyQueryResponseBodyModuleTravelerList> TravelerList { get; set; }
            public class ApplyQueryResponseBodyModuleTravelerList : TeaModel {
                [NameInMap("business_discount")]
                [Validation(Required=false)]
                public int? BusinessDiscount { get; set; }

                [NameInMap("economy_discount")]
                [Validation(Required=false)]
                public int? EconomyDiscount { get; set; }

                [NameInMap("first_discount")]
                [Validation(Required=false)]
                public int? FirstDiscount { get; set; }

                [NameInMap("flight_cabins")]
                [Validation(Required=false)]
                public string FlightCabins { get; set; }

                [NameInMap("hotel_citys")]
                [Validation(Required=false)]
                public List<ApplyQueryResponseBodyModuleTravelerListHotelCitys> HotelCitys { get; set; }
                public class ApplyQueryResponseBodyModuleTravelerListHotelCitys : TeaModel {
                    [NameInMap("city_code")]
                    [Validation(Required=false)]
                    public string CityCode { get; set; }

                    [NameInMap("city_name")]
                    [Validation(Required=false)]
                    public string CityName { get; set; }

                    [NameInMap("fee")]
                    [Validation(Required=false)]
                    public long? Fee { get; set; }

                }

                [NameInMap("premium_economy_discount")]
                [Validation(Required=false)]
                public int? PremiumEconomyDiscount { get; set; }

                [NameInMap("reserve_type")]
                [Validation(Required=false)]
                public int? ReserveType { get; set; }

                [NameInMap("train_seats")]
                [Validation(Required=false)]
                public string TrainSeats { get; set; }

                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("user_name")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            [NameInMap("trip_cause")]
            [Validation(Required=false)]
            public string TripCause { get; set; }

            [NameInMap("trip_day")]
            [Validation(Required=false)]
            public int? TripDay { get; set; }

            [NameInMap("trip_title")]
            [Validation(Required=false)]
            public string TripTitle { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            [NameInMap("union_no")]
            [Validation(Required=false)]
            public string UnionNo { get; set; }

            [NameInMap("user_id")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("user_name")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            [NameInMap("vehicle_budget")]
            [Validation(Required=false)]
            public long? VehicleBudget { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
