// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ApplyAddShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The total budget, including domestic flights, domestic hotels, train tickets, and car service.</para>
        /// <list type="bullet">
        /// <item><description>Currency unit: CNY, in cents.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>4000</para>
        /// </summary>
        [NameInMap("budget")]
        [Validation(Required=false)]
        public long? Budget { get; set; }

        /// <summary>
        /// <para>Specifies whether to merge budgets of multiple business trip approval forms.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("budget_merge")]
        [Validation(Required=false)]
        public int? BudgetMerge { get; set; }

        /// <summary>
        /// <para>The business travel car service rule.</para>
        /// </summary>
        [NameInMap("car_rule")]
        [Validation(Required=false)]
        public string CarRuleShrink { get; set; }

        /// <summary>
        /// <para>The enterprise name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>阿里巴巴</para>
        /// </summary>
        [NameInMap("corp_name")]
        [Validation(Required=false)]
        public string CorpName { get; set; }

        /// <summary>
        /// <para>The default travel standard for the approval form.</para>
        /// <para>If the travelers are not determined when the approval form is submitted but you need to control the travel standard for subsequently added travelers, set the default travel standard for the approval form.</para>
        /// </summary>
        [NameInMap("default_standard")]
        [Validation(Required=false)]
        public string DefaultStandardShrink { get; set; }

        /// <summary>
        /// <para>The department ID.</para>
        /// <list type="bullet">
        /// <item><description>If not specified, the system retrieves the department information based on the user information.</description></item>
        /// <item><description>Ensure that the correct department ID is passed. Otherwise, the cost attribution of the employee\&quot;s travel expenses may be affected.</description></item>
        /// <item><description>The department ID must be numeric.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("depart_id")]
        [Validation(Required=false)]
        public string DepartId { get; set; }

        /// <summary>
        /// <para>The department name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>采购部</para>
        /// </summary>
        [NameInMap("depart_name")]
        [Validation(Required=false)]
        public string DepartName { get; set; }

        /// <summary>
        /// <para>The extension information.</para>
        /// <list type="bullet">
        /// <item><description>Pass supplementary descriptions in this field. The corresponding content is displayed in the bill. This is typically used for enterprise travel statistics and reconciliation.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;cost_center&quot;:&quot;成本中心&quot;}</para>
        /// </summary>
        [NameInMap("extend_field")]
        [Validation(Required=false)]
        public string ExtendField { get; set; }

        /// <summary>
        /// <para>The external traveler list.</para>
        /// </summary>
        [NameInMap("external_traveler_list")]
        [Validation(Required=false)]
        public string ExternalTravelerListShrink { get; set; }

        /// <summary>
        /// <para>The travel standard for external travelers.</para>
        /// </summary>
        [NameInMap("external_traveler_standard")]
        [Validation(Required=false)]
        public string ExternalTravelerStandardShrink { get; set; }

        /// <summary>
        /// <para>The domestic flight budget.</para>
        /// <list type="bullet">
        /// <item><description>Currency unit: CNY, in cents.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("flight_budget")]
        [Validation(Required=false)]
        public long? FlightBudget { get; set; }

        /// <summary>
        /// <para>The domestic hotel budget.</para>
        /// <list type="bullet">
        /// <item><description>Currency unit: CNY, in cents.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Warning: Miscellaneous charges incurred by specially authorized guests during their stay (such as meals and in-room products) are deducted at checkout and paid by the enterprise.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("hotel_budget")]
        [Validation(Required=false)]
        public long? HotelBudget { get; set; }

        /// <summary>
        /// <para>The travel standard calculation rule for hotel room-sharing scenarios.</para>
        /// </summary>
        [NameInMap("hotel_share")]
        [Validation(Required=false)]
        public string HotelShareShrink { get; set; }

        /// <summary>
        /// <para>Deprecated field.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("international_flight_cabins")]
        [Validation(Required=false)]
        public string InternationalFlightCabins { get; set; }

        /// <summary>
        /// <para>The international/Hong Kong, Macao, Taiwan (China) flight budget of the approval form (in cents).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("intl_flight_budget")]
        [Validation(Required=false)]
        public long? IntlFlightBudget { get; set; }

        /// <summary>
        /// <para>The international hotel budget of the approval form (in cents).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("intl_hotel_budget")]
        [Validation(Required=false)]
        public long? IntlHotelBudget { get; set; }

        /// <summary>
        /// <para>The itinerary list.</para>
        /// </summary>
        [NameInMap("itinerary_list")]
        [Validation(Required=false)]
        public string ItineraryListShrink { get; set; }

        /// <summary>
        /// <para>The city rule for the approval form.</para>
        /// <list type="bullet">
        /// <item><description>When set to 0, the <c>itinerary_list</c> field is required.</description></item>
        /// <item><description>When set to 1, the <c>itinerary_set_list</c> field is required.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("itinerary_rule")]
        [Validation(Required=false)]
        public int? ItineraryRule { get; set; }

        /// <summary>
        /// <para>The city set itinerary list.</para>
        /// </summary>
        [NameInMap("itinerary_set_list")]
        [Validation(Required=false)]
        public string ItinerarySetListShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether to restrict travelers.</para>
        /// <remarks>
        /// <para>Warning: If the approval form does not restrict travelers and no default travel standard (default_standard) is passed, the traveler information passed in the approval form is not stored, and actual travelers are not subject to travel standard restrictions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("limit_traveler")]
        [Validation(Required=false)]
        public int? LimitTraveler { get; set; }

        /// <summary>
        /// <para>The meal budget of the approval form (in cents).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("meal_budget")]
        [Validation(Required=false)]
        public long? MealBudget { get; set; }

        /// <summary>
        /// <para>The cost attribution department ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>41155</para>
        /// </summary>
        [NameInMap("payment_department_id")]
        [Validation(Required=false)]
        public string PaymentDepartmentId { get; set; }

        /// <summary>
        /// <para>The cost attribution department name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>产品部</para>
        /// </summary>
        [NameInMap("payment_department_name")]
        [Validation(Required=false)]
        public string PaymentDepartmentName { get; set; }

        /// <summary>
        /// <para>The approval form status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para><b>Deprecated</b>. The enterprise ID. Use <a href="/#/document/server/groupcorptoken-group-enterprise-certificate?handbookId=development-support">Group enterprise credential</a> instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>btrip123</para>
        /// </summary>
        [NameInMap("sub_corp_id")]
        [Validation(Required=false)]
        public string SubCorpId { get; set; }

        /// <summary>
        /// <para>The external approval form ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("thirdpart_apply_id")]
        [Validation(Required=false)]
        public string ThirdpartApplyId { get; set; }

        /// <summary>
        /// <para>The external approval form ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00714131</para>
        /// </summary>
        [NameInMap("thirdpart_business_id")]
        [Validation(Required=false)]
        public string ThirdpartBusinessId { get; set; }

        /// <summary>
        /// <para>The third-party department ID.</para>
        /// <list type="bullet">
        /// <item><description>Specify either the third-party department ID or the department ID.</description></item>
        /// <item><description>If both are specified, the third-party department ID takes precedence.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>三方部门id</para>
        /// </summary>
        [NameInMap("thirdpart_depart_id")]
        [Validation(Required=false)]
        public string ThirdpartDepartId { get; set; }

        /// <summary>
        /// <para>The simultaneous booking (flight &amp; train) rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("together_book_rule")]
        [Validation(Required=false)]
        public int? TogetherBookRule { get; set; }

        /// <summary>
        /// <para>The train ticket budget.</para>
        /// <list type="bullet">
        /// <item><description>Currency unit: CNY, in cents.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Warning: For example, when the seat class is &quot;hard sleeper&quot;, upper/middle/lower berths have different prices. The budget balance is validated against the highest price.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("train_budget")]
        [Validation(Required=false)]
        public long? TrainBudget { get; set; }

        /// <summary>
        /// <para>The traveler list.</para>
        /// </summary>
        [NameInMap("traveler_list")]
        [Validation(Required=false)]
        public string TravelerListShrink { get; set; }

        /// <summary>
        /// <para>The list of internal personnel travel standards.</para>
        /// </summary>
        [NameInMap("traveler_standard")]
        [Validation(Required=false)]
        public string TravelerStandardShrink { get; set; }

        /// <summary>
        /// <para>The reason for the business trip.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>客服培训</para>
        /// </summary>
        [NameInMap("trip_cause")]
        [Validation(Required=false)]
        public string TripCause { get; set; }

        /// <summary>
        /// <para>The number of business trip days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("trip_day")]
        [Validation(Required=false)]
        public int? TripDay { get; set; }

        /// <summary>
        /// <para>The title of the approval form.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>客服培训</para>
        /// </summary>
        [NameInMap("trip_title")]
        [Validation(Required=false)]
        public string TripTitle { get; set; }

        /// <summary>
        /// <para>The applicant type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        /// <summary>
        /// <para>The associated order number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>union001</para>
        /// </summary>
        [NameInMap("union_no")]
        [Validation(Required=false)]
        public string UnionNo { get; set; }

        /// <summary>
        /// <para>The applicant ID (third-party user ID).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>thridpart12138</para>
        /// </summary>
        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The username.</para>
        /// <list type="bullet">
        /// <item><description>Pass the real name of the employee.</description></item>
        /// <item><description>If not specified, the system uses the name corresponding to the current userId for booking.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("user_name")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// <para>The car service budget.</para>
        /// <list type="bullet">
        /// <item><description>Currency unit: CNY, in cents.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Ride-hailing scenarios involve uncontrollable factors that may exceed the original estimated price:</para>
        /// <list type="bullet">
        /// <item><description>The passenger changes the destination offline.</description></item>
        /// <item><description>Traffic congestion or other road incidents. </description></item>
        /// <item><description>The driver adds surcharges such as tolls, highway fees, or waiting fees.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("vehicle_budget")]
        [Validation(Required=false)]
        public long? VehicleBudget { get; set; }

    }

}
