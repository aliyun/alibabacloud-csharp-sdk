// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ApplyQueryResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
                public string Note { get; set; }
                public string OperateTime { get; set; }
                public int? Order { get; set; }
                public int? Status { get; set; }
                public string StatusDesc { get; set; }
                public string UserId { get; set; }
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
                public int? BusinessDiscount { get; set; }
                public int? EconomyDiscount { get; set; }
                public int? FirstDiscount { get; set; }
                public string FlightCabins { get; set; }
                public List<ApplyQueryResponseBodyModuleExternalTravelerListHotelCitys> HotelCitys { get; set; }
                public class ApplyQueryResponseBodyModuleExternalTravelerListHotelCitys : TeaModel {
                    public string CityCode { get; set; }
                    public string CityName { get; set; }
                    public long? Fee { get; set; }
                }
                public int? ReserveType { get; set; }
                public string TrainSeats { get; set; }
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
                public string ArrCity { get; set; }
                public string ArrCityCode { get; set; }
                public string ArrDate { get; set; }
                public string CostCenterName { get; set; }
                public string DepCity { get; set; }
                public string DepCityCode { get; set; }
                public string DepDate { get; set; }
                public string InvoiceName { get; set; }
                public string ItineraryId { get; set; }
                public string ProjectCode { get; set; }
                public string ProjectTitle { get; set; }
                public int? TrafficType { get; set; }
                public int? TripWay { get; set; }
            }
            [NameInMap("itinerary_rule")]
            [Validation(Required=false)]
            public int? ItineraryRule { get; set; }
            [NameInMap("itinerary_set_list")]
            [Validation(Required=false)]
            public List<ApplyQueryResponseBodyModuleItinerarySetList> ItinerarySetList { get; set; }
            public class ApplyQueryResponseBodyModuleItinerarySetList : TeaModel {
                public string ArrDate { get; set; }
                public string CityCodeSet { get; set; }
                public string CitySet { get; set; }
                public string CostCenterName { get; set; }
                public string DepDate { get; set; }
                public string InvoiceName { get; set; }
                public string ItineraryId { get; set; }
                public string ProjectCode { get; set; }
                public string ProjectTitle { get; set; }
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
                public int? BusinessDiscount { get; set; }
                public int? EconomyDiscount { get; set; }
                public int? FirstDiscount { get; set; }
                public string FlightCabins { get; set; }
                public List<ApplyQueryResponseBodyModuleTravelerListHotelCitys> HotelCitys { get; set; }
                public class ApplyQueryResponseBodyModuleTravelerListHotelCitys : TeaModel {
                    public string CityCode { get; set; }
                    public string CityName { get; set; }
                    public long? Fee { get; set; }
                }
                public int? ReserveType { get; set; }
                public string TrainSeats { get; set; }
                public string UserId { get; set; }
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
        };

        [NameInMap("result_code")]
        [Validation(Required=false)]
        public int? ResultCode { get; set; }

        [NameInMap("result_msg")]
        [Validation(Required=false)]
        public string ResultMsg { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
