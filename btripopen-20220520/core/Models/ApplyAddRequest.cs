// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ApplyAddRequest : TeaModel {
        [NameInMap("budget")]
        [Validation(Required=false)]
        public long? Budget { get; set; }

        [NameInMap("budget_merge")]
        [Validation(Required=false)]
        public int? BudgetMerge { get; set; }

        [NameInMap("car_rule")]
        [Validation(Required=false)]
        public ApplyAddRequestCarRule CarRule { get; set; }
        public class ApplyAddRequestCarRule : TeaModel {
            [NameInMap("scenario_template_id")]
            [Validation(Required=false)]
            public string ScenarioTemplateId { get; set; }

            [NameInMap("scenario_template_name")]
            [Validation(Required=false)]
            public string ScenarioTemplateName { get; set; }

        }

        [NameInMap("corp_name")]
        [Validation(Required=false)]
        public string CorpName { get; set; }

        [NameInMap("default_standard")]
        [Validation(Required=false)]
        public ApplyAddRequestDefaultStandard DefaultStandard { get; set; }
        public class ApplyAddRequestDefaultStandard : TeaModel {
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

            [NameInMap("flight_intl_rule_code")]
            [Validation(Required=false)]
            public long? FlightIntlRuleCode { get; set; }

            [NameInMap("flight_rule_code")]
            [Validation(Required=false)]
            public long? FlightRuleCode { get; set; }

            [NameInMap("hotel_citys")]
            [Validation(Required=false)]
            public List<ApplyAddRequestDefaultStandardHotelCitys> HotelCitys { get; set; }
            public class ApplyAddRequestDefaultStandardHotelCitys : TeaModel {
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

            [NameInMap("hotel_intl_citys")]
            [Validation(Required=false)]
            public List<ApplyAddRequestDefaultStandardHotelIntlCitys> HotelIntlCitys { get; set; }
            public class ApplyAddRequestDefaultStandardHotelIntlCitys : TeaModel {
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

            [NameInMap("hotel_intl_rule_code")]
            [Validation(Required=false)]
            public long? HotelIntlRuleCode { get; set; }

            [NameInMap("hotel_rule_code")]
            [Validation(Required=false)]
            public long? HotelRuleCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>F</para>
            /// </summary>
            [NameInMap("international_flight_cabins")]
            [Validation(Required=false)]
            public string InternationalFlightCabins { get; set; }

            [NameInMap("premium_economy_discount")]
            [Validation(Required=false)]
            public int? PremiumEconomyDiscount { get; set; }

            [NameInMap("reserve_type")]
            [Validation(Required=false)]
            public int? ReserveType { get; set; }

            [NameInMap("train_rule_code")]
            [Validation(Required=false)]
            public long? TrainRuleCode { get; set; }

            [NameInMap("train_seats")]
            [Validation(Required=false)]
            public string TrainSeats { get; set; }

        }

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
        public List<ApplyAddRequestExternalTravelerList> ExternalTravelerList { get; set; }
        public class ApplyAddRequestExternalTravelerList : TeaModel {
            [NameInMap("attribute")]
            [Validation(Required=false)]
            public string Attribute { get; set; }

            [NameInMap("cost_center_id")]
            [Validation(Required=false)]
            public long? CostCenterId { get; set; }

            [NameInMap("external_user_id")]
            [Validation(Required=false)]
            public string ExternalUserId { get; set; }

            [NameInMap("invoice_id")]
            [Validation(Required=false)]
            public long? InvoiceId { get; set; }

            [NameInMap("payment_department_id")]
            [Validation(Required=false)]
            public string PaymentDepartmentId { get; set; }

            [NameInMap("payment_department_name")]
            [Validation(Required=false)]
            public string PaymentDepartmentName { get; set; }

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

            [NameInMap("thirdpart_depart_id")]
            [Validation(Required=false)]
            public string ThirdpartDepartId { get; set; }

            [NameInMap("user_name")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            [NameInMap("user_name_en")]
            [Validation(Required=false)]
            public string UserNameEn { get; set; }

        }

        [NameInMap("external_traveler_standard")]
        [Validation(Required=false)]
        public ApplyAddRequestExternalTravelerStandard ExternalTravelerStandard { get; set; }
        public class ApplyAddRequestExternalTravelerStandard : TeaModel {
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

            [NameInMap("flight_intl_rule_code")]
            [Validation(Required=false)]
            public long? FlightIntlRuleCode { get; set; }

            [NameInMap("flight_rule_code")]
            [Validation(Required=false)]
            public long? FlightRuleCode { get; set; }

            [NameInMap("hotel_citys")]
            [Validation(Required=false)]
            public List<ApplyAddRequestExternalTravelerStandardHotelCitys> HotelCitys { get; set; }
            public class ApplyAddRequestExternalTravelerStandardHotelCitys : TeaModel {
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

            [NameInMap("hotel_intl_citys")]
            [Validation(Required=false)]
            public List<ApplyAddRequestExternalTravelerStandardHotelIntlCitys> HotelIntlCitys { get; set; }
            public class ApplyAddRequestExternalTravelerStandardHotelIntlCitys : TeaModel {
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

            [NameInMap("hotel_intl_rule_code")]
            [Validation(Required=false)]
            public long? HotelIntlRuleCode { get; set; }

            [NameInMap("hotel_rule_code")]
            [Validation(Required=false)]
            public long? HotelRuleCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>F</para>
            /// </summary>
            [NameInMap("international_flight_cabins")]
            [Validation(Required=false)]
            public string InternationalFlightCabins { get; set; }

            [NameInMap("premium_economy_discount")]
            [Validation(Required=false)]
            public int? PremiumEconomyDiscount { get; set; }

            [NameInMap("reserve_type")]
            [Validation(Required=false)]
            public int? ReserveType { get; set; }

            [NameInMap("train_rule_code")]
            [Validation(Required=false)]
            public long? TrainRuleCode { get; set; }

            [NameInMap("train_seats")]
            [Validation(Required=false)]
            public string TrainSeats { get; set; }

        }

        [NameInMap("flight_budget")]
        [Validation(Required=false)]
        public long? FlightBudget { get; set; }

        [NameInMap("hotel_budget")]
        [Validation(Required=false)]
        public long? HotelBudget { get; set; }

        [NameInMap("hotel_share")]
        [Validation(Required=false)]
        public ApplyAddRequestHotelShare HotelShare { get; set; }
        public class ApplyAddRequestHotelShare : TeaModel {
            [NameInMap("param")]
            [Validation(Required=false)]
            public string Param { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("international_flight_cabins")]
        [Validation(Required=false)]
        public string InternationalFlightCabins { get; set; }

        [NameInMap("intl_flight_budget")]
        [Validation(Required=false)]
        public long? IntlFlightBudget { get; set; }

        [NameInMap("intl_hotel_budget")]
        [Validation(Required=false)]
        public long? IntlHotelBudget { get; set; }

        [NameInMap("itinerary_list")]
        [Validation(Required=false)]
        public List<ApplyAddRequestItineraryList> ItineraryList { get; set; }
        public class ApplyAddRequestItineraryList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("arr_city")]
            [Validation(Required=false)]
            public string ArrCity { get; set; }

            [NameInMap("arr_city_code")]
            [Validation(Required=false)]
            public string ArrCityCode { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("arr_date")]
            [Validation(Required=false)]
            public string ArrDate { get; set; }

            [NameInMap("attribute")]
            [Validation(Required=false)]
            public string Attribute { get; set; }

            [NameInMap("cost_center_id")]
            [Validation(Required=false)]
            public long? CostCenterId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("dep_city")]
            [Validation(Required=false)]
            public string DepCity { get; set; }

            [NameInMap("dep_city_code")]
            [Validation(Required=false)]
            public string DepCityCode { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("dep_date")]
            [Validation(Required=false)]
            public string DepDate { get; set; }

            [NameInMap("invoice_id")]
            [Validation(Required=false)]
            public long? InvoiceId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("itinerary_id")]
            [Validation(Required=false)]
            public string ItineraryId { get; set; }

            [NameInMap("itinerary_travel_standard")]
            [Validation(Required=false)]
            public ApplyAddRequestItineraryListItineraryTravelStandard ItineraryTravelStandard { get; set; }
            public class ApplyAddRequestItineraryListItineraryTravelStandard : TeaModel {
                [NameInMap("hotel_available_nights_per_day")]
                [Validation(Required=false)]
                public int? HotelAvailableNightsPerDay { get; set; }

            }

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

            [NameInMap("province_travel_city_adcodes")]
            [Validation(Required=false)]
            public List<string> ProvinceTravelCityAdcodes { get; set; }

            [NameInMap("third_part_invoice_id")]
            [Validation(Required=false)]
            public string ThirdPartInvoiceId { get; set; }

            [NameInMap("thirdpart_cost_center_id")]
            [Validation(Required=false)]
            public string ThirdpartCostCenterId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("traffic_type")]
            [Validation(Required=false)]
            public int? TrafficType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("trip_way")]
            [Validation(Required=false)]
            public int? TripWay { get; set; }

        }

        [NameInMap("itinerary_rule")]
        [Validation(Required=false)]
        public int? ItineraryRule { get; set; }

        [NameInMap("itinerary_set_list")]
        [Validation(Required=false)]
        public List<ApplyAddRequestItinerarySetList> ItinerarySetList { get; set; }
        public class ApplyAddRequestItinerarySetList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-01-01 00:00:00</para>
            /// </summary>
            [NameInMap("arr_date")]
            [Validation(Required=false)]
            public string ArrDate { get; set; }

            [NameInMap("attribute")]
            [Validation(Required=false)]
            public string Attribute { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("city_code_set")]
            [Validation(Required=false)]
            public string CityCodeSet { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("city_set")]
            [Validation(Required=false)]
            public string CitySet { get; set; }

            [NameInMap("cost_center_id")]
            [Validation(Required=false)]
            public long? CostCenterId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-01-01 00:00:00</para>
            /// </summary>
            [NameInMap("dep_date")]
            [Validation(Required=false)]
            public string DepDate { get; set; }

            [NameInMap("invoice_id")]
            [Validation(Required=false)]
            public long? InvoiceId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("itinerary_id")]
            [Validation(Required=false)]
            public string ItineraryId { get; set; }

            [NameInMap("itinerary_travel_standard")]
            [Validation(Required=false)]
            public ApplyAddRequestItinerarySetListItineraryTravelStandard ItineraryTravelStandard { get; set; }
            public class ApplyAddRequestItinerarySetListItineraryTravelStandard : TeaModel {
                [NameInMap("hotel_available_nights_per_day")]
                [Validation(Required=false)]
                public int? HotelAvailableNightsPerDay { get; set; }

            }

            [NameInMap("project_code")]
            [Validation(Required=false)]
            public string ProjectCode { get; set; }

            [NameInMap("project_title")]
            [Validation(Required=false)]
            public string ProjectTitle { get; set; }

            [NameInMap("province_travel_city_adcodes")]
            [Validation(Required=false)]
            public List<string> ProvinceTravelCityAdcodes { get; set; }

            [NameInMap("third_part_invoice_id")]
            [Validation(Required=false)]
            public string ThirdPartInvoiceId { get; set; }

            [NameInMap("thirdpart_cost_center_id")]
            [Validation(Required=false)]
            public string ThirdpartCostCenterId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("traffic_type")]
            [Validation(Required=false)]
            public int? TrafficType { get; set; }

        }

        [NameInMap("limit_traveler")]
        [Validation(Required=false)]
        public int? LimitTraveler { get; set; }

        [NameInMap("meal_budget")]
        [Validation(Required=false)]
        public long? MealBudget { get; set; }

        [NameInMap("payment_department_id")]
        [Validation(Required=false)]
        public string PaymentDepartmentId { get; set; }

        [NameInMap("payment_department_name")]
        [Validation(Required=false)]
        public string PaymentDepartmentName { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("sub_corp_id")]
        [Validation(Required=false)]
        public string SubCorpId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
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
        public List<ApplyAddRequestTravelerList> TravelerList { get; set; }
        public class ApplyAddRequestTravelerList : TeaModel {
            [NameInMap("attribute")]
            [Validation(Required=false)]
            public string Attribute { get; set; }

            [NameInMap("cost_center_id")]
            [Validation(Required=false)]
            public long? CostCenterId { get; set; }

            [NameInMap("invoice_id")]
            [Validation(Required=false)]
            public long? InvoiceId { get; set; }

            [NameInMap("payment_department_id")]
            [Validation(Required=false)]
            public string PaymentDepartmentId { get; set; }

            [NameInMap("payment_department_name")]
            [Validation(Required=false)]
            public string PaymentDepartmentName { get; set; }

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

            [NameInMap("thirdpart_depart_id")]
            [Validation(Required=false)]
            public string ThirdpartDepartId { get; set; }

            [NameInMap("user_id")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("user_name")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        [NameInMap("traveler_standard")]
        [Validation(Required=false)]
        public List<ApplyAddRequestTravelerStandard> TravelerStandard { get; set; }
        public class ApplyAddRequestTravelerStandard : TeaModel {
            [NameInMap("business_discount")]
            [Validation(Required=false)]
            public int? BusinessDiscount { get; set; }

            [NameInMap("car_city_set")]
            [Validation(Required=false)]
            public List<ApplyAddRequestTravelerStandardCarCitySet> CarCitySet { get; set; }
            public class ApplyAddRequestTravelerStandardCarCitySet : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("city_code")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("city_name")]
                [Validation(Required=false)]
                public string CityName { get; set; }

            }

            [NameInMap("car_standard")]
            [Validation(Required=false)]
            public ApplyAddRequestTravelerStandardCarStandard CarStandard { get; set; }
            public class ApplyAddRequestTravelerStandardCarStandard : TeaModel {
                [NameInMap("book_allow_info")]
                [Validation(Required=false)]
                public ApplyAddRequestTravelerStandardCarStandardBookAllowInfo BookAllowInfo { get; set; }
                public class ApplyAddRequestTravelerStandardCarStandardBookAllowInfo : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("book_allow")]
                    [Validation(Required=false)]
                    public bool? BookAllow { get; set; }

                }

                [NameInMap("car_helper")]
                [Validation(Required=false)]
                public ApplyAddRequestTravelerStandardCarStandardCarHelper CarHelper { get; set; }
                public class ApplyAddRequestTravelerStandardCarStandardCarHelper : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("car_helper_type")]
                    [Validation(Required=false)]
                    public string CarHelperType { get; set; }

                }

                [NameInMap("car_time_control")]
                [Validation(Required=false)]
                public ApplyAddRequestTravelerStandardCarStandardCarTimeControl CarTimeControl { get; set; }
                public class ApplyAddRequestTravelerStandardCarStandardCarTimeControl : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("time_limit")]
                    [Validation(Required=false)]
                    public List<ApplyAddRequestTravelerStandardCarStandardCarTimeControlTimeLimit> TimeLimit { get; set; }
                    public class ApplyAddRequestTravelerStandardCarStandardCarTimeControlTimeLimit : TeaModel {
                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("end_time")]
                        [Validation(Required=false)]
                        public string EndTime { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("start_time")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                    }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("time_switch")]
                    [Validation(Required=false)]
                    public bool? TimeSwitch { get; set; }

                }

                [NameInMap("city_control_info")]
                [Validation(Required=false)]
                public ApplyAddRequestTravelerStandardCarStandardCityControlInfo CityControlInfo { get; set; }
                public class ApplyAddRequestTravelerStandardCarStandardCityControlInfo : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("city_control_type")]
                    [Validation(Required=false)]
                    public int? CityControlType { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("city_infos")]
                    [Validation(Required=false)]
                    public List<ApplyAddRequestTravelerStandardCarStandardCityControlInfoCityInfos> CityInfos { get; set; }
                    public class ApplyAddRequestTravelerStandardCarStandardCityControlInfoCityInfos : TeaModel {
                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("adcode")]
                        [Validation(Required=false)]
                        public string Adcode { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("city_code")]
                        [Validation(Required=false)]
                        public string CityCode { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("city_name")]
                        [Validation(Required=false)]
                        public string CityName { get; set; }

                    }

                }

                [NameInMap("cross_city_info")]
                [Validation(Required=false)]
                public ApplyAddRequestTravelerStandardCarStandardCrossCityInfo CrossCityInfo { get; set; }
                public class ApplyAddRequestTravelerStandardCarStandardCrossCityInfo : TeaModel {
                    [NameInMap("cross_city_list")]
                    [Validation(Required=false)]
                    public List<ApplyAddRequestTravelerStandardCarStandardCrossCityInfoCrossCityList> CrossCityList { get; set; }
                    public class ApplyAddRequestTravelerStandardCarStandardCrossCityInfoCrossCityList : TeaModel {
                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("from_adcode")]
                        [Validation(Required=false)]
                        public string FromAdcode { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("from_city_code")]
                        [Validation(Required=false)]
                        public string FromCityCode { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("from_city_name")]
                        [Validation(Required=false)]
                        public string FromCityName { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("to_adcode")]
                        [Validation(Required=false)]
                        public string ToAdcode { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("to_city_code")]
                        [Validation(Required=false)]
                        public string ToCityCode { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("to_city_name")]
                        [Validation(Required=false)]
                        public string ToCityName { get; set; }

                    }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("cross_city_type")]
                    [Validation(Required=false)]
                    public int? CrossCityType { get; set; }

                }

                [NameInMap("electronic_fence_info")]
                [Validation(Required=false)]
                public ApplyAddRequestTravelerStandardCarStandardElectronicFenceInfo ElectronicFenceInfo { get; set; }
                public class ApplyAddRequestTravelerStandardCarStandardElectronicFenceInfo : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("electronic_fence_locations_from")]
                    [Validation(Required=false)]
                    public List<ApplyAddRequestTravelerStandardCarStandardElectronicFenceInfoElectronicFenceLocationsFrom> ElectronicFenceLocationsFrom { get; set; }
                    public class ApplyAddRequestTravelerStandardCarStandardElectronicFenceInfoElectronicFenceLocationsFrom : TeaModel {
                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("address")]
                        [Validation(Required=false)]
                        public string Address { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("latitude")]
                        [Validation(Required=false)]
                        public string Latitude { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("longitude")]
                        [Validation(Required=false)]
                        public string Longitude { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("radius")]
                        [Validation(Required=false)]
                        public int? Radius { get; set; }

                    }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("electronic_fence_locations_to")]
                    [Validation(Required=false)]
                    public List<ApplyAddRequestTravelerStandardCarStandardElectronicFenceInfoElectronicFenceLocationsTo> ElectronicFenceLocationsTo { get; set; }
                    public class ApplyAddRequestTravelerStandardCarStandardElectronicFenceInfoElectronicFenceLocationsTo : TeaModel {
                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("address")]
                        [Validation(Required=false)]
                        public string Address { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("latitude")]
                        [Validation(Required=false)]
                        public string Latitude { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("longitude")]
                        [Validation(Required=false)]
                        public string Longitude { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("radius")]
                        [Validation(Required=false)]
                        public int? Radius { get; set; }

                    }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("electronic_fence_type")]
                    [Validation(Required=false)]
                    public int? ElectronicFenceType { get; set; }

                }

                [NameInMap("level_codes")]
                [Validation(Required=false)]
                public string LevelCodes { get; set; }

                [NameInMap("modify_destination_info")]
                [Validation(Required=false)]
                public ApplyAddRequestTravelerStandardCarStandardModifyDestinationInfo ModifyDestinationInfo { get; set; }
                public class ApplyAddRequestTravelerStandardCarStandardModifyDestinationInfo : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("modify_destination")]
                    [Validation(Required=false)]
                    public bool? ModifyDestination { get; set; }

                }

                [NameInMap("times_total")]
                [Validation(Required=false)]
                public int? TimesTotal { get; set; }

                [NameInMap("times_type")]
                [Validation(Required=false)]
                public int? TimesType { get; set; }

            }

            [NameInMap("economy_discount")]
            [Validation(Required=false)]
            public int? EconomyDiscount { get; set; }

            [NameInMap("first_discount")]
            [Validation(Required=false)]
            public int? FirstDiscount { get; set; }

            [NameInMap("flight_cabins")]
            [Validation(Required=false)]
            public string FlightCabins { get; set; }

            [NameInMap("flight_intl_rule_code")]
            [Validation(Required=false)]
            public long? FlightIntlRuleCode { get; set; }

            [NameInMap("flight_rule_code")]
            [Validation(Required=false)]
            public long? FlightRuleCode { get; set; }

            [NameInMap("hotel_citys")]
            [Validation(Required=false)]
            public List<ApplyAddRequestTravelerStandardHotelCitys> HotelCitys { get; set; }
            public class ApplyAddRequestTravelerStandardHotelCitys : TeaModel {
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

            [NameInMap("hotel_intl_citys")]
            [Validation(Required=false)]
            public List<ApplyAddRequestTravelerStandardHotelIntlCitys> HotelIntlCitys { get; set; }
            public class ApplyAddRequestTravelerStandardHotelIntlCitys : TeaModel {
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

            [NameInMap("hotel_intl_rule_code")]
            [Validation(Required=false)]
            public long? HotelIntlRuleCode { get; set; }

            [NameInMap("hotel_rule_code")]
            [Validation(Required=false)]
            public long? HotelRuleCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>F</para>
            /// </summary>
            [NameInMap("international_flight_cabins")]
            [Validation(Required=false)]
            public string InternationalFlightCabins { get; set; }

            [NameInMap("premium_economy_discount")]
            [Validation(Required=false)]
            public int? PremiumEconomyDiscount { get; set; }

            [NameInMap("reserve_type")]
            [Validation(Required=false)]
            public int? ReserveType { get; set; }

            [NameInMap("train_rule_code")]
            [Validation(Required=false)]
            public long? TrainRuleCode { get; set; }

            [NameInMap("train_seats")]
            [Validation(Required=false)]
            public string TrainSeats { get; set; }

            [NameInMap("user_id")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("trip_cause")]
        [Validation(Required=false)]
        public string TripCause { get; set; }

        [NameInMap("trip_day")]
        [Validation(Required=false)]
        public int? TripDay { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("trip_title")]
        [Validation(Required=false)]
        public string TripTitle { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        [NameInMap("union_no")]
        [Validation(Required=false)]
        public string UnionNo { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
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
