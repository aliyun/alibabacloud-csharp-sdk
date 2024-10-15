// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ApplyAddShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>4000</para>
        /// </summary>
        [NameInMap("budget")]
        [Validation(Required=false)]
        public long? Budget { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("budget_merge")]
        [Validation(Required=false)]
        public int? BudgetMerge { get; set; }

        [NameInMap("car_rule")]
        [Validation(Required=false)]
        public string CarRuleShrink { get; set; }

        [NameInMap("corp_name")]
        [Validation(Required=false)]
        public string CorpName { get; set; }

        [NameInMap("default_standard")]
        [Validation(Required=false)]
        public string DefaultStandardShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>departId01</para>
        /// </summary>
        [NameInMap("depart_id")]
        [Validation(Required=false)]
        public string DepartId { get; set; }

        [NameInMap("depart_name")]
        [Validation(Required=false)]
        public string DepartName { get; set; }

        /// <summary>
        /// <para>可将补充描述传入此字段，账单中将会体现此字段的值。可以用于企业的统计和对账</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;cost_center&quot;:&quot;成本中心&quot;}</para>
        /// </summary>
        [NameInMap("extend_field")]
        [Validation(Required=false)]
        public string ExtendField { get; set; }

        [NameInMap("external_traveler_list")]
        [Validation(Required=false)]
        public string ExternalTravelerListShrink { get; set; }

        [NameInMap("external_traveler_standard")]
        [Validation(Required=false)]
        public string ExternalTravelerStandardShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("flight_budget")]
        [Validation(Required=false)]
        public long? FlightBudget { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("hotel_budget")]
        [Validation(Required=false)]
        public long? HotelBudget { get; set; }

        [NameInMap("hotel_share")]
        [Validation(Required=false)]
        public string HotelShareShrink { get; set; }

        [NameInMap("international_flight_cabins")]
        [Validation(Required=false)]
        public string InternationalFlightCabins { get; set; }

        [NameInMap("itinerary_list")]
        [Validation(Required=false)]
        public string ItineraryListShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("itinerary_rule")]
        [Validation(Required=false)]
        public int? ItineraryRule { get; set; }

        [NameInMap("itinerary_set_list")]
        [Validation(Required=false)]
        public string ItinerarySetListShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("limit_traveler")]
        [Validation(Required=false)]
        public int? LimitTraveler { get; set; }

        [NameInMap("payment_department_id")]
        [Validation(Required=false)]
        public string PaymentDepartmentId { get; set; }

        [NameInMap("payment_department_name")]
        [Validation(Required=false)]
        public string PaymentDepartmentName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("sub_corp_id")]
        [Validation(Required=false)]
        public string SubCorpId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("thirdpart_apply_id")]
        [Validation(Required=false)]
        public string ThirdpartApplyId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>00714131</para>
        /// </summary>
        [NameInMap("thirdpart_business_id")]
        [Validation(Required=false)]
        public string ThirdpartBusinessId { get; set; }

        [NameInMap("thirdpart_depart_id")]
        [Validation(Required=false)]
        public string ThirdpartDepartId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("together_book_rule")]
        [Validation(Required=false)]
        public int? TogetherBookRule { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("train_budget")]
        [Validation(Required=false)]
        public long? TrainBudget { get; set; }

        [NameInMap("traveler_list")]
        [Validation(Required=false)]
        public string TravelerListShrink { get; set; }

        [NameInMap("traveler_standard")]
        [Validation(Required=false)]
        public string TravelerStandardShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("trip_cause")]
        [Validation(Required=false)]
        public string TripCause { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("trip_day")]
        [Validation(Required=false)]
        public int? TripDay { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("trip_title")]
        [Validation(Required=false)]
        public string TripTitle { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>union001</para>
        /// </summary>
        [NameInMap("union_no")]
        [Validation(Required=false)]
        public string UnionNo { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>thridpart12138</para>
        /// </summary>
        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("user_name")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("vehicle_budget")]
        [Validation(Required=false)]
        public long? VehicleBudget { get; set; }

    }

}
