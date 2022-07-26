// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ApplyModifyRequest : TeaModel {
        [NameInMap("budget")]
        [Validation(Required=false)]
        public long? Budget { get; set; }

        [NameInMap("budget_merge")]
        [Validation(Required=false)]
        public int? BudgetMerge { get; set; }

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
        public List<ApplyModifyRequestExternalTravelerList> ExternalTravelerList { get; set; }
        public class ApplyModifyRequestExternalTravelerList : TeaModel {
            [NameInMap("user_name")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        [NameInMap("external_traveler_standard")]
        [Validation(Required=false)]
        public ApplyModifyRequestExternalTravelerStandard ExternalTravelerStandard { get; set; }
        public class ApplyModifyRequestExternalTravelerStandard : TeaModel {
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
            public List<ApplyModifyRequestExternalTravelerStandardHotelCitys> HotelCitys { get; set; }
            public class ApplyModifyRequestExternalTravelerStandardHotelCitys : TeaModel {
                public string CityCode { get; set; }
                public string CityName { get; set; }
                public long? Fee { get; set; }
            }
            [NameInMap("reserve_type")]
            [Validation(Required=false)]
            public int? ReserveType { get; set; }
            [NameInMap("train_seats")]
            [Validation(Required=false)]
            public string TrainSeats { get; set; }
        };

        [NameInMap("flight_budget")]
        [Validation(Required=false)]
        public long? FlightBudget { get; set; }

        [NameInMap("hotel_budget")]
        [Validation(Required=false)]
        public long? HotelBudget { get; set; }

        [NameInMap("hotel_share")]
        [Validation(Required=false)]
        public ApplyModifyRequestHotelShare HotelShare { get; set; }
        public class ApplyModifyRequestHotelShare : TeaModel {
            [NameInMap("param")]
            [Validation(Required=false)]
            public string Param { get; set; }
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }
        };

        [NameInMap("itinerary_list")]
        [Validation(Required=false)]
        public List<ApplyModifyRequestItineraryList> ItineraryList { get; set; }
        public class ApplyModifyRequestItineraryList : TeaModel {
            [NameInMap("arr_city")]
            [Validation(Required=false)]
            public string ArrCity { get; set; }

            [NameInMap("arr_city_code")]
            [Validation(Required=false)]
            public string ArrCityCode { get; set; }

            [NameInMap("arr_date")]
            [Validation(Required=false)]
            public string ArrDate { get; set; }

            [NameInMap("cost_center_id")]
            [Validation(Required=false)]
            public long? CostCenterId { get; set; }

            [NameInMap("dep_city")]
            [Validation(Required=false)]
            public string DepCity { get; set; }

            [NameInMap("dep_city_code")]
            [Validation(Required=false)]
            public string DepCityCode { get; set; }

            [NameInMap("dep_date")]
            [Validation(Required=false)]
            public string DepDate { get; set; }

            [NameInMap("invoice_id")]
            [Validation(Required=false)]
            public long? InvoiceId { get; set; }

            [NameInMap("itinerary_id")]
            [Validation(Required=false)]
            public string ItineraryId { get; set; }

            [NameInMap("need_hotel")]
            [Validation(Required=false)]
            public bool? NeedHotel { get; set; }

            [NameInMap("need_traffic")]
            [Validation(Required=false)]
            public bool? NeedTraffic { get; set; }

            [NameInMap("project_code")]
            [Validation(Required=false)]
            public string ProjectCode { get; set; }

            [NameInMap("project_title")]
            [Validation(Required=false)]
            public string ProjectTitle { get; set; }

            [NameInMap("third_part_invoice_id")]
            [Validation(Required=false)]
            public string ThirdPartInvoiceId { get; set; }

            [NameInMap("thirdpart_cost_center_id")]
            [Validation(Required=false)]
            public string ThirdpartCostCenterId { get; set; }

            [NameInMap("traffic_type")]
            [Validation(Required=false)]
            public int? TrafficType { get; set; }

            [NameInMap("trip_way")]
            [Validation(Required=false)]
            public int? TripWay { get; set; }

        }

        [NameInMap("limit_traveler")]
        [Validation(Required=false)]
        public int? LimitTraveler { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("thirdpart_apply_id")]
        [Validation(Required=false)]
        public string ThirdpartApplyId { get; set; }

        [NameInMap("thirdpart_business_id")]
        [Validation(Required=false)]
        public string ThirdpartBusinessId { get; set; }

        [NameInMap("together_book_rule")]
        [Validation(Required=false)]
        public int? TogetherBookRule { get; set; }

        [NameInMap("train_budget")]
        [Validation(Required=false)]
        public long? TrainBudget { get; set; }

        [NameInMap("traveler_list")]
        [Validation(Required=false)]
        public List<ApplyModifyRequestTravelerList> TravelerList { get; set; }
        public class ApplyModifyRequestTravelerList : TeaModel {
            [NameInMap("user_id")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("user_name")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        [NameInMap("traveler_standard")]
        [Validation(Required=false)]
        public List<ApplyModifyRequestTravelerStandard> TravelerStandard { get; set; }
        public class ApplyModifyRequestTravelerStandard : TeaModel {
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
            public List<ApplyModifyRequestTravelerStandardHotelCitys> HotelCitys { get; set; }
            public class ApplyModifyRequestTravelerStandardHotelCitys : TeaModel {
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

            [NameInMap("reserve_type")]
            [Validation(Required=false)]
            public int? ReserveType { get; set; }

            [NameInMap("train_seats")]
            [Validation(Required=false)]
            public string TrainSeats { get; set; }

            [NameInMap("user_id")]
            [Validation(Required=false)]
            public string UserId { get; set; }

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

}
