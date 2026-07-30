// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ApplyModifyShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The total budget.</para>
        /// <para>Includes domestic flights, domestic hotels, train tickets, and car service.</para>
        /// <para>Currency unit: CNY, in cents.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4000</para>
        /// </summary>
        [NameInMap("budget")]
        [Validation(Required=false)]
        public long? Budget { get; set; }

        /// <summary>
        /// <para>Specifies whether to merge budgets of multiple business trip approval forms.</para>
        /// <para>Multiple approval forms with the same union_no can have their budgets merged and used interchangeably.</para>
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
        /// <para>The default travel standards for the approval form.</para>
        /// <para>If the travelers are not determined when the approval form is submitted but you need to control the travel standards for subsequently added travelers, set the default travel standards for the approval form.</para>
        /// </summary>
        [NameInMap("default_standard")]
        [Validation(Required=false)]
        public string DefaultStandardShrink { get; set; }

        /// <summary>
        /// <para>The department ID. If not specified, the system retrieves the department information based on the user information. If an incorrect department ID is specified, cost allocation to the department cannot be performed. The department ID must be numeric.</para>
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
        /// <para>Pass supplementary descriptions in this field. The value appears in bills and can be used for enterprise statistics and reconciliation.</para>
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
        /// <para>The external traveler travel standard.</para>
        /// </summary>
        [NameInMap("external_traveler_standard")]
        [Validation(Required=false)]
        public string ExternalTravelerStandardShrink { get; set; }

        /// <summary>
        /// <para>The domestic flight budget.</para>
        /// <para>Currency unit: CNY, in cents.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("flight_budget")]
        [Validation(Required=false)]
        public long? FlightBudget { get; set; }

        /// <summary>
        /// <para>The domestic hotel budget.</para>
        /// <para>Currency unit: CNY, in cents.</para>
        /// <remarks>
        /// <para>Warning: Miscellaneous charges incurred by specially authorized guests during their stay (meals, in-room items, etc.) are deducted at checkout and paid by the enterprise.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("hotel_budget")]
        [Validation(Required=false)]
        public long? HotelBudget { get; set; }

        /// <summary>
        /// <para>The hotel room-sharing rule.</para>
        /// </summary>
        [NameInMap("hotel_share")]
        [Validation(Required=false)]
        public string HotelShareShrink { get; set; }

        /// <summary>
        /// <para>The international/Hong Kong (China), Macao (China), Taiwan (China) flight budget (in cents).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("intl_flight_budget")]
        [Validation(Required=false)]
        public long? IntlFlightBudget { get; set; }

        /// <summary>
        /// <para>The international hotel budget (in cents).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("intl_hotel_budget")]
        [Validation(Required=false)]
        public long? IntlHotelBudget { get; set; }

        /// <summary>
        /// <para>The itinerary list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("itinerary_list")]
        [Validation(Required=false)]
        public string ItineraryListShrink { get; set; }

        /// <summary>
        /// <para>The approval form city rule:
        /// 0: One-to-one departure and destination, pass itineraries as a list. 
        /// 1: Select N cities, city set itinerary.
        /// Default value: 0.
        /// When the approval form city rule is 0, itinerary_list is required.</para>
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
        /// <para>0: Do not restrict travelers. 1: Restrict to travelers on the approval form.</para>
        /// <remarks>
        /// <para>Warning: If the approval form does not restrict travelers and no default travel standard (default_standard) is passed, the traveler information on the approval form is not stored, and actual travelers are not subject to travel standard restrictions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("limit_traveler")]
        [Validation(Required=false)]
        public int? LimitTraveler { get; set; }

        /// <summary>
        /// <para>The meal budget (in cents).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("meal_budget")]
        [Validation(Required=false)]
        public long? MealBudget { get; set; }

        /// <summary>
        /// <para>The cost allocation department ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>141125</para>
        /// </summary>
        [NameInMap("payment_department_id")]
        [Validation(Required=false)]
        public string PaymentDepartmentId { get; set; }

        /// <summary>
        /// <para>The cost allocation department name.</para>
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
        /// <para>1</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para><del>Sub-enterprise ID</del>
        /// Deprecated. Use <a href="/#/document/server/groupcorptoken-group-enterprise-certificate?handbookId=development-support">Group Enterprise Credential</a> instead.</para>
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
        /// <para>0001A1100000007EX08O</para>
        /// </summary>
        [NameInMap("thirdpart_apply_id")]
        [Validation(Required=false)]
        public string ThirdpartApplyId { get; set; }

        /// <summary>
        /// <para>The external approval form ID displayed to users.</para>
        /// 
        /// <b>Example:</b>
        /// <para>202201413141</para>
        /// </summary>
        [NameInMap("thirdpart_business_id")]
        [Validation(Required=false)]
        public string ThirdpartBusinessId { get; set; }

        /// <summary>
        /// <para>The third-party department ID.</para>
        /// <para>If either the third-party department ID or the department ID is specified, the specified field takes precedence.</para>
        /// <para>If both are specified, the third-party department ID takes precedence.</para>
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
        /// <para>Currency unit: CNY, in cents.</para>
        /// <remarks>
        /// <para>Warning: For the same seat class such as &quot;hard sleeper&quot;, upper/middle/lower berths have price differences. During booking, the budget balance is validated against the highest price.</para>
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
        /// <para>The list of travel standards for internal personnel.</para>
        /// </summary>
        [NameInMap("traveler_standard")]
        [Validation(Required=false)]
        public string TravelerStandardShrink { get; set; }

        /// <summary>
        /// <para>The reason for the business trip.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>访问客户</para>
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
        /// <para>访问客户</para>
        /// </summary>
        [NameInMap("trip_title")]
        [Validation(Required=false)]
        public string TripTitle { get; set; }

        /// <summary>
        /// <para>The associated order number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>union51415</para>
        /// </summary>
        [NameInMap("union_no")]
        [Validation(Required=false)]
        public string UnionNo { get; set; }

        /// <summary>
        /// <para>The applicant ID (third-party user ID).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>thirdpart12138</para>
        /// </summary>
        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The username. If specified, it must be the real name. If not specified, the system uses the name associated with the current userId for booking.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("user_name")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// <para>The car service budget.</para>
        /// <para>Currency unit: CNY, in cents.</para>
        /// <remarks>
        /// <para>Warning: Uncontrollable factors in ride-hailing scenarios may cause the actual price to exceed the estimated price: 1. The passenger changes the destination offline. 2. Traffic congestion or other road incidents. 3. The driver adds surcharges such as tolls, highway fees, or waiting fees.</para>
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
