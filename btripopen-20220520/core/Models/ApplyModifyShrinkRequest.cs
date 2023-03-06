// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ApplyModifyShrinkRequest : TeaModel {
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

        [NameInMap("extend_field")]
        [Validation(Required=false)]
        public string ExtendField { get; set; }

        [NameInMap("external_traveler_list")]
        [Validation(Required=false)]
        public string ExternalTravelerListShrink { get; set; }

        [NameInMap("external_traveler_standard")]
        [Validation(Required=false)]
        public string ExternalTravelerStandardShrink { get; set; }

        [NameInMap("flight_budget")]
        [Validation(Required=false)]
        public long? FlightBudget { get; set; }

        [NameInMap("hotel_budget")]
        [Validation(Required=false)]
        public long? HotelBudget { get; set; }

        [NameInMap("hotel_share")]
        [Validation(Required=false)]
        public string HotelShareShrink { get; set; }

        [NameInMap("itinerary_list")]
        [Validation(Required=false)]
        public string ItineraryListShrink { get; set; }

        [NameInMap("itinerary_rule")]
        [Validation(Required=false)]
        public int? ItineraryRule { get; set; }

        [NameInMap("itinerary_set_list")]
        [Validation(Required=false)]
        public string ItinerarySetListShrink { get; set; }

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

        [NameInMap("thirdpart_depart_id")]
        [Validation(Required=false)]
        public string ThirdpartDepartId { get; set; }

        [NameInMap("together_book_rule")]
        [Validation(Required=false)]
        public int? TogetherBookRule { get; set; }

        [NameInMap("train_budget")]
        [Validation(Required=false)]
        public long? TrainBudget { get; set; }

        [NameInMap("traveler_list")]
        [Validation(Required=false)]
        public string TravelerListShrink { get; set; }

        [NameInMap("traveler_standard")]
        [Validation(Required=false)]
        public string TravelerStandardShrink { get; set; }

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
