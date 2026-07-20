// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ApplyQueryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public ApplyQueryResponseBodyModule Module { get; set; }
        public class ApplyQueryResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>201710111505000464651</para>
            /// </summary>
            [NameInMap("apply_show_id")]
            [Validation(Required=false)]
            public string ApplyShowId { get; set; }

            [NameInMap("approver_list")]
            [Validation(Required=false)]
            public List<ApplyQueryResponseBodyModuleApproverList> ApproverList { get; set; }
            public class ApplyQueryResponseBodyModuleApproverList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>同意</para>
                /// </summary>
                [NameInMap("note")]
                [Validation(Required=false)]
                public string Note { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2018-09-19T14:03Z</para>
                /// </summary>
                [NameInMap("operate_time")]
                [Validation(Required=false)]
                public string OperateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("order")]
                [Validation(Required=false)]
                public int? Order { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>同意</para>
                /// </summary>
                [NameInMap("status_desc")]
                [Validation(Required=false)]
                public string StatusDesc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>user1</para>
                /// </summary>
                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("user_name")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100000</para>
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
            public ApplyQueryResponseBodyModuleCarRule CarRule { get; set; }
            public class ApplyQueryResponseBodyModuleCarRule : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("scenario_template_id")]
                [Validation(Required=false)]
                public string ScenarioTemplateId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>测试场景模板</para>
                /// </summary>
                [NameInMap("scenario_template_name")]
                [Validation(Required=false)]
                public string ScenarioTemplateName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>corpid</para>
            /// </summary>
            [NameInMap("corp_id")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>阿里巴巴</para>
            /// </summary>
            [NameInMap("corp_name")]
            [Validation(Required=false)]
            public string CorpName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dept1</para>
            /// </summary>
            [NameInMap("depart_id")]
            [Validation(Required=false)]
            public string DepartId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>adv</para>
            /// </summary>
            [NameInMap("depart_name")]
            [Validation(Required=false)]
            public string DepartName { get; set; }

            /// <summary>
            /// <para>补充描述，账单中将会体现此字段的值。可以用于企业的统计和对账</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;cost_center&quot;:&quot;成本中心&quot;}</para>
            /// </summary>
            [NameInMap("extend_field")]
            [Validation(Required=false)]
            public string ExtendField { get; set; }

            [NameInMap("external_traveler_list")]
            [Validation(Required=false)]
            public List<ApplyQueryResponseBodyModuleExternalTravelerList> ExternalTravelerList { get; set; }
            public class ApplyQueryResponseBodyModuleExternalTravelerList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>“{&quot;name&quot;:&quot;张三&quot;}”</para>
                /// </summary>
                [NameInMap("attribute")]
                [Validation(Required=false)]
                public string Attribute { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("business_discount")]
                [Validation(Required=false)]
                public int? BusinessDiscount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>费用成本中心</para>
                /// </summary>
                [NameInMap("cost_center_name")]
                [Validation(Required=false)]
                public string CostCenterName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>650307003103</para>
                /// </summary>
                [NameInMap("depart_id")]
                [Validation(Required=false)]
                public string DepartId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("economy_discount")]
                [Validation(Required=false)]
                public int? EconomyDiscount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>371164</para>
                /// </summary>
                [NameInMap("external_user_id")]
                [Validation(Required=false)]
                public string ExternalUserId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("first_discount")]
                [Validation(Required=false)]
                public int? FirstDiscount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>F</para>
                /// </summary>
                [NameInMap("flight_cabins")]
                [Validation(Required=false)]
                public string FlightCabins { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10032</para>
                /// </summary>
                [NameInMap("flight_intl_rule_code")]
                [Validation(Required=false)]
                public long? FlightIntlRuleCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10032</para>
                /// </summary>
                [NameInMap("flight_rule_code")]
                [Validation(Required=false)]
                public long? FlightRuleCode { get; set; }

                [NameInMap("hotel_citys")]
                [Validation(Required=false)]
                public List<ApplyQueryResponseBodyModuleExternalTravelerListHotelCitys> HotelCitys { get; set; }
                public class ApplyQueryResponseBodyModuleExternalTravelerListHotelCitys : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("city_code")]
                    [Validation(Required=false)]
                    public string CityCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>北京</para>
                    /// </summary>
                    [NameInMap("city_name")]
                    [Validation(Required=false)]
                    public string CityName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>100000</para>
                    /// </summary>
                    [NameInMap("fee")]
                    [Validation(Required=false)]
                    public long? Fee { get; set; }

                }

                [NameInMap("hotel_intl_citys")]
                [Validation(Required=false)]
                public List<ApplyQueryResponseBodyModuleExternalTravelerListHotelIntlCitys> HotelIntlCitys { get; set; }
                public class ApplyQueryResponseBodyModuleExternalTravelerListHotelIntlCitys : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>320100</para>
                    /// </summary>
                    [NameInMap("city_code")]
                    [Validation(Required=false)]
                    public string CityCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>杭州</para>
                    /// </summary>
                    [NameInMap("city_name")]
                    [Validation(Required=false)]
                    public string CityName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1009</para>
                    /// </summary>
                    [NameInMap("fee")]
                    [Validation(Required=false)]
                    public long? Fee { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10032</para>
                /// </summary>
                [NameInMap("hotel_intl_rule_code")]
                [Validation(Required=false)]
                public long? HotelIntlRuleCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10032</para>
                /// </summary>
                [NameInMap("hotel_rule_code")]
                [Validation(Required=false)]
                public long? HotelRuleCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>HD1000412256</para>
                /// </summary>
                [NameInMap("invoice_name")]
                [Validation(Required=false)]
                public string InvoiceName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>11003</para>
                /// </summary>
                [NameInMap("payment_department_id")]
                [Validation(Required=false)]
                public string PaymentDepartmentId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>一级事业部</para>
                /// </summary>
                [NameInMap("payment_department_name")]
                [Validation(Required=false)]
                public string PaymentDepartmentName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("premium_economy_discount")]
                [Validation(Required=false)]
                public int? PremiumEconomyDiscount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>acs</para>
                /// </summary>
                [NameInMap("project_code")]
                [Validation(Required=false)]
                public string ProjectCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>访问项目</para>
                /// </summary>
                [NameInMap("project_title")]
                [Validation(Required=false)]
                public string ProjectTitle { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("reserve_type")]
                [Validation(Required=false)]
                public int? ReserveType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>91310118MA1JMJ0P2E</para>
                /// </summary>
                [NameInMap("third_part_invoice_id")]
                [Validation(Required=false)]
                public string ThirdPartInvoiceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>HX10002442</para>
                /// </summary>
                [NameInMap("thirdpart_cost_center_id")]
                [Validation(Required=false)]
                public string ThirdpartCostCenterId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>7faf5393-8a70-11ec-89d2-6a0616dfdee4</para>
                /// </summary>
                [NameInMap("thirdpart_depart_id")]
                [Validation(Required=false)]
                public string ThirdpartDepartId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10032</para>
                /// </summary>
                [NameInMap("train_rule_code")]
                [Validation(Required=false)]
                public long? TrainRuleCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("train_seats")]
                [Validation(Required=false)]
                public string TrainSeats { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("user_name")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("flight_budget")]
            [Validation(Required=false)]
            public long? FlightBudget { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2018-09-19T14:03Z</para>
            /// </summary>
            [NameInMap("gmt_create")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2018-09-19T14:03Z</para>
            /// </summary>
            [NameInMap("gmt_modified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100000</para>
            /// </summary>
            [NameInMap("hotel_budget")]
            [Validation(Required=false)]
            public long? HotelBudget { get; set; }

            [NameInMap("hotel_share")]
            [Validation(Required=false)]
            public ApplyQueryResponseBodyModuleHotelShare HotelShare { get; set; }
            public class ApplyQueryResponseBodyModuleHotelShare : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>70</para>
                /// </summary>
                [NameInMap("param")]
                [Validation(Required=false)]
                public string Param { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3298</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("intl_flight_budget")]
            [Validation(Required=false)]
            public long? IntlFlightBudget { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("intl_hotel_budget")]
            [Validation(Required=false)]
            public long? IntlHotelBudget { get; set; }

            [NameInMap("itinerary_list")]
            [Validation(Required=false)]
            public List<ApplyQueryResponseBodyModuleItineraryList> ItineraryList { get; set; }
            public class ApplyQueryResponseBodyModuleItineraryList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>北京</para>
                /// </summary>
                [NameInMap("arr_city")]
                [Validation(Required=false)]
                public string ArrCity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>330100</para>
                /// </summary>
                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2018-09-19T14:03Z</para>
                /// </summary>
                [NameInMap("arr_date")]
                [Validation(Required=false)]
                public string ArrDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>“{&quot;name&quot;:&quot;张三&quot;}”</para>
                /// </summary>
                [NameInMap("attribute")]
                [Validation(Required=false)]
                public string Attribute { get; set; }

                [NameInMap("can_order_type_list")]
                [Validation(Required=false)]
                public List<string> CanOrderTypeList { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>accac</para>
                /// </summary>
                [NameInMap("cost_center_name")]
                [Validation(Required=false)]
                public string CostCenterName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>杭州</para>
                /// </summary>
                [NameInMap("dep_city")]
                [Validation(Required=false)]
                public string DepCity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>330100</para>
                /// </summary>
                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2018-09-19T14:03Z</para>
                /// </summary>
                [NameInMap("dep_date")]
                [Validation(Required=false)]
                public string DepDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>阿里巴巴</para>
                /// </summary>
                [NameInMap("invoice_name")]
                [Validation(Required=false)]
                public string InvoiceName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{行程单号}</para>
                /// </summary>
                [NameInMap("itinerary_id")]
                [Validation(Required=false)]
                public string ItineraryId { get; set; }

                [NameInMap("itinerary_no")]
                [Validation(Required=false)]
                public string ItineraryNo { get; set; }

                [NameInMap("itinerary_travel_standard")]
                [Validation(Required=false)]
                public ApplyQueryResponseBodyModuleItineraryListItineraryTravelStandard ItineraryTravelStandard { get; set; }
                public class ApplyQueryResponseBodyModuleItineraryListItineraryTravelStandard : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("hotel_available_nights_per_day")]
                    [Validation(Required=false)]
                    public int? HotelAvailableNightsPerDay { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xm1</para>
                /// </summary>
                [NameInMap("project_code")]
                [Validation(Required=false)]
                public string ProjectCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>项目1</para>
                /// </summary>
                [NameInMap("project_title")]
                [Validation(Required=false)]
                public string ProjectTitle { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("thirdpart_cost_center_id")]
                [Validation(Required=false)]
                public string ThirdpartCostCenterId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("thirdpart_invoice_id")]
                [Validation(Required=false)]
                public string ThirdpartInvoiceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>thirdpart1234</para>
                /// </summary>
                [NameInMap("thirdpart_itinerary_id")]
                [Validation(Required=false)]
                public string ThirdpartItineraryId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("traffic_type")]
                [Validation(Required=false)]
                public int? TrafficType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("trip_way")]
                [Validation(Required=false)]
                public int? TripWay { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("itinerary_rule")]
            [Validation(Required=false)]
            public int? ItineraryRule { get; set; }

            [NameInMap("itinerary_set_list")]
            [Validation(Required=false)]
            public List<ApplyQueryResponseBodyModuleItinerarySetList> ItinerarySetList { get; set; }
            public class ApplyQueryResponseBodyModuleItinerarySetList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2018-09-19T14:03Z</para>
                /// </summary>
                [NameInMap("arr_date")]
                [Validation(Required=false)]
                public string ArrDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>“{&quot;name&quot;:&quot;张三&quot;}”</para>
                /// </summary>
                [NameInMap("attribute")]
                [Validation(Required=false)]
                public string Attribute { get; set; }

                [NameInMap("can_order_type_list")]
                [Validation(Required=false)]
                public List<string> CanOrderTypeList { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>BJS，HGH</para>
                /// </summary>
                [NameInMap("city_code_set")]
                [Validation(Required=false)]
                public string CityCodeSet { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>北京，杭州</para>
                /// </summary>
                [NameInMap("city_set")]
                [Validation(Required=false)]
                public string CitySet { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>成本中心名称</para>
                /// </summary>
                [NameInMap("cost_center_name")]
                [Validation(Required=false)]
                public string CostCenterName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2018-09-19T14:03Z</para>
                /// </summary>
                [NameInMap("dep_date")]
                [Validation(Required=false)]
                public string DepDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>发票抬头</para>
                /// </summary>
                [NameInMap("invoice_name")]
                [Validation(Required=false)]
                public string InvoiceName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("itinerary_id")]
                [Validation(Required=false)]
                public string ItineraryId { get; set; }

                [NameInMap("itinerary_no")]
                [Validation(Required=false)]
                public string ItineraryNo { get; set; }

                [NameInMap("itinerary_travel_standard")]
                [Validation(Required=false)]
                public ApplyQueryResponseBodyModuleItinerarySetListItineraryTravelStandard ItineraryTravelStandard { get; set; }
                public class ApplyQueryResponseBodyModuleItinerarySetListItineraryTravelStandard : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("hotel_available_nights_per_day")]
                    [Validation(Required=false)]
                    public int? HotelAvailableNightsPerDay { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>projecttow</para>
                /// </summary>
                [NameInMap("project_code")]
                [Validation(Required=false)]
                public string ProjectCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>项目1</para>
                /// </summary>
                [NameInMap("project_title")]
                [Validation(Required=false)]
                public string ProjectTitle { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("thirdpart_cost_center_id")]
                [Validation(Required=false)]
                public string ThirdpartCostCenterId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("thirdpart_invoice_id")]
                [Validation(Required=false)]
                public string ThirdpartInvoiceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>thirdpart1234</para>
                /// </summary>
                [NameInMap("thirdpart_itinerary_id")]
                [Validation(Required=false)]
                public string ThirdpartItineraryId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("traffic_type")]
                [Validation(Required=false)]
                public int? TrafficType { get; set; }

            }

            [NameInMap("job_no")]
            [Validation(Required=false)]
            public string JobNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("limit_traveler")]
            [Validation(Required=false)]
            public int? LimitTraveler { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("meal_budget")]
            [Validation(Required=false)]
            public long? MealBudget { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10002</para>
            /// </summary>
            [NameInMap("payment_department_id")]
            [Validation(Required=false)]
            public string PaymentDepartmentId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>一级事业部</para>
            /// </summary>
            [NameInMap("payment_department_name")]
            [Validation(Required=false)]
            public string PaymentDepartmentName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>同意</para>
            /// </summary>
            [NameInMap("status_desc")]
            [Validation(Required=false)]
            public string StatusDesc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1213</para>
            /// </summary>
            [NameInMap("thirdpart_business_id")]
            [Validation(Required=false)]
            public string ThirdpartBusinessId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1214254</para>
            /// </summary>
            [NameInMap("thirdpart_id")]
            [Validation(Required=false)]
            public string ThirdpartId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("together_book_rule")]
            [Validation(Required=false)]
            public int? TogetherBookRule { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("train_budget")]
            [Validation(Required=false)]
            public long? TrainBudget { get; set; }

            [NameInMap("traveler_list")]
            [Validation(Required=false)]
            public List<ApplyQueryResponseBodyModuleTravelerList> TravelerList { get; set; }
            public class ApplyQueryResponseBodyModuleTravelerList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>“{&quot;name&quot;:&quot;张三&quot;}”</para>
                /// </summary>
                [NameInMap("attribute")]
                [Validation(Required=false)]
                public string Attribute { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("business_discount")]
                [Validation(Required=false)]
                public int? BusinessDiscount { get; set; }

                [NameInMap("car_city_set")]
                [Validation(Required=false)]
                public List<ApplyQueryResponseBodyModuleTravelerListCarCitySet> CarCitySet { get; set; }
                public class ApplyQueryResponseBodyModuleTravelerListCarCitySet : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>110100，330100</para>
                    /// </summary>
                    [NameInMap("city_code")]
                    [Validation(Required=false)]
                    public string CityCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>北京，杭州</para>
                    /// </summary>
                    [NameInMap("city_name")]
                    [Validation(Required=false)]
                    public string CityName { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>市场成本中心</para>
                /// </summary>
                [NameInMap("cost_center_name")]
                [Validation(Required=false)]
                public string CostCenterName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>330902003106</para>
                /// </summary>
                [NameInMap("depart_id")]
                [Validation(Required=false)]
                public string DepartId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("economy_discount")]
                [Validation(Required=false)]
                public int? EconomyDiscount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("first_discount")]
                [Validation(Required=false)]
                public int? FirstDiscount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>F</para>
                /// </summary>
                [NameInMap("flight_cabins")]
                [Validation(Required=false)]
                public string FlightCabins { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10032</para>
                /// </summary>
                [NameInMap("flight_intl_rule_code")]
                [Validation(Required=false)]
                public long? FlightIntlRuleCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10032</para>
                /// </summary>
                [NameInMap("flight_rule_code")]
                [Validation(Required=false)]
                public long? FlightRuleCode { get; set; }

                [NameInMap("hotel_citys")]
                [Validation(Required=false)]
                public List<ApplyQueryResponseBodyModuleTravelerListHotelCitys> HotelCitys { get; set; }
                public class ApplyQueryResponseBodyModuleTravelerListHotelCitys : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("city_code")]
                    [Validation(Required=false)]
                    public string CityCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>北京</para>
                    /// </summary>
                    [NameInMap("city_name")]
                    [Validation(Required=false)]
                    public string CityName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>100000</para>
                    /// </summary>
                    [NameInMap("fee")]
                    [Validation(Required=false)]
                    public long? Fee { get; set; }

                }

                [NameInMap("hotel_intl_citys")]
                [Validation(Required=false)]
                public List<ApplyQueryResponseBodyModuleTravelerListHotelIntlCitys> HotelIntlCitys { get; set; }
                public class ApplyQueryResponseBodyModuleTravelerListHotelIntlCitys : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>330200</para>
                    /// </summary>
                    [NameInMap("city_code")]
                    [Validation(Required=false)]
                    public string CityCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>杭州</para>
                    /// </summary>
                    [NameInMap("city_name")]
                    [Validation(Required=false)]
                    public string CityName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1009</para>
                    /// </summary>
                    [NameInMap("fee")]
                    [Validation(Required=false)]
                    public long? Fee { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10032</para>
                /// </summary>
                [NameInMap("hotel_intl_rule_code")]
                [Validation(Required=false)]
                public long? HotelIntlRuleCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10032</para>
                /// </summary>
                [NameInMap("hotel_rule_code")]
                [Validation(Required=false)]
                public long? HotelRuleCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>HD1000241</para>
                /// </summary>
                [NameInMap("invoice_name")]
                [Validation(Required=false)]
                public string InvoiceName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10032</para>
                /// </summary>
                [NameInMap("payment_department_id")]
                [Validation(Required=false)]
                public string PaymentDepartmentId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>一级事业部</para>
                /// </summary>
                [NameInMap("payment_department_name")]
                [Validation(Required=false)]
                public string PaymentDepartmentName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("premium_economy_discount")]
                [Validation(Required=false)]
                public int? PremiumEconomyDiscount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>acs</para>
                /// </summary>
                [NameInMap("project_code")]
                [Validation(Required=false)]
                public string ProjectCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>访问项目</para>
                /// </summary>
                [NameInMap("project_title")]
                [Validation(Required=false)]
                public string ProjectTitle { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("reserve_type")]
                [Validation(Required=false)]
                public int? ReserveType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>91330109MA2GKYEE0X</para>
                /// </summary>
                [NameInMap("third_part_invoice_id")]
                [Validation(Required=false)]
                public string ThirdPartInvoiceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>HX00001250</para>
                /// </summary>
                [NameInMap("thirdpart_cost_center_id")]
                [Validation(Required=false)]
                public string ThirdpartCostCenterId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>DHDI2208051REIO6BK</para>
                /// </summary>
                [NameInMap("thirdpart_depart_id")]
                [Validation(Required=false)]
                public string ThirdpartDepartId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10032</para>
                /// </summary>
                [NameInMap("train_rule_code")]
                [Validation(Required=false)]
                public long? TrainRuleCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("train_seats")]
                [Validation(Required=false)]
                public string TrainSeats { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3423</para>
                /// </summary>
                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("user_name")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>北京出差</para>
            /// </summary>
            [NameInMap("trip_cause")]
            [Validation(Required=false)]
            public string TripCause { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("trip_day")]
            [Validation(Required=false)]
            public int? TripDay { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>北京出差</para>
            /// </summary>
            [NameInMap("trip_title")]
            [Validation(Required=false)]
            public string TripTitle { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>abd123</para>
            /// </summary>
            [NameInMap("union_no")]
            [Validation(Required=false)]
            public string UnionNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>user1</para>
            /// </summary>
            [NameInMap("user_id")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("user_name")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("vehicle_budget")]
            [Validation(Required=false)]
            public long? VehicleBudget { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>B72B39C8-32DE-558D-AD1C-D53F11F6ADFE</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
