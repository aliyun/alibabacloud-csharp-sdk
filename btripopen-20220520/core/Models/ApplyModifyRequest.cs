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

        [NameInMap("car_rule")]
        [Validation(Required=false)]
        public ApplyModifyRequestCarRule CarRule { get; set; }
        public class ApplyModifyRequestCarRule : TeaModel {
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
        public ApplyModifyRequestDefaultStandard DefaultStandard { get; set; }
        public class ApplyModifyRequestDefaultStandard : TeaModel {
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
            public List<ApplyModifyRequestDefaultStandardHotelCitys> HotelCitys { get; set; }
            public class ApplyModifyRequestDefaultStandardHotelCitys : TeaModel {
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
            public List<ApplyModifyRequestDefaultStandardHotelIntlCitys> HotelIntlCitys { get; set; }
            public class ApplyModifyRequestDefaultStandardHotelIntlCitys : TeaModel {
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
        public List<ApplyModifyRequestExternalTravelerList> ExternalTravelerList { get; set; }
        public class ApplyModifyRequestExternalTravelerList : TeaModel {
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

            [NameInMap("flight_intl_rule_code")]
            [Validation(Required=false)]
            public long? FlightIntlRuleCode { get; set; }

            [NameInMap("flight_rule_code")]
            [Validation(Required=false)]
            public long? FlightRuleCode { get; set; }

            [NameInMap("hotel_citys")]
            [Validation(Required=false)]
            public List<ApplyModifyRequestExternalTravelerStandardHotelCitys> HotelCitys { get; set; }
            public class ApplyModifyRequestExternalTravelerStandardHotelCitys : TeaModel {
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
            public List<ApplyModifyRequestExternalTravelerStandardHotelIntlCitys> HotelIntlCitys { get; set; }
            public class ApplyModifyRequestExternalTravelerStandardHotelIntlCitys : TeaModel {
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
        public ApplyModifyRequestHotelShare HotelShare { get; set; }
        public class ApplyModifyRequestHotelShare : TeaModel {
            [NameInMap("param")]
            [Validation(Required=false)]
            public string Param { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("intl_flight_budget")]
        [Validation(Required=false)]
        public long? IntlFlightBudget { get; set; }

        [NameInMap("intl_hotel_budget")]
        [Validation(Required=false)]
        public long? IntlHotelBudget { get; set; }

        [NameInMap("itinerary_list")]
        [Validation(Required=false)]
        public List<ApplyModifyRequestItineraryList> ItineraryList { get; set; }
        public class ApplyModifyRequestItineraryList : TeaModel {
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
            public ApplyModifyRequestItineraryListItineraryTravelStandard ItineraryTravelStandard { get; set; }
            public class ApplyModifyRequestItineraryListItineraryTravelStandard : TeaModel {
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
        public List<ApplyModifyRequestItinerarySetList> ItinerarySetList { get; set; }
        public class ApplyModifyRequestItinerarySetList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2017-01-01 00:00:00</para>
            /// </summary>
            [NameInMap("arr_date")]
            [Validation(Required=false)]
            public string ArrDate { get; set; }

            [NameInMap("attribute")]
            [Validation(Required=false)]
            public string Attribute { get; set; }

            [NameInMap("city_code_set")]
            [Validation(Required=false)]
            public string CityCodeSet { get; set; }

            [NameInMap("city_set")]
            [Validation(Required=false)]
            public string CitySet { get; set; }

            [NameInMap("cost_center_id")]
            [Validation(Required=false)]
            public long? CostCenterId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2017-01-01 00:00:00</para>
            /// </summary>
            [NameInMap("dep_date")]
            [Validation(Required=false)]
            public string DepDate { get; set; }

            [NameInMap("invoice_id")]
            [Validation(Required=false)]
            public long? InvoiceId { get; set; }

            [NameInMap("itinerary_id")]
            [Validation(Required=false)]
            public string ItineraryId { get; set; }

            [NameInMap("itinerary_travel_standard")]
            [Validation(Required=false)]
            public ApplyModifyRequestItinerarySetListItineraryTravelStandard ItineraryTravelStandard { get; set; }
            public class ApplyModifyRequestItinerarySetListItineraryTravelStandard : TeaModel {
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
        public List<ApplyModifyRequestTravelerList> TravelerList { get; set; }
        public class ApplyModifyRequestTravelerList : TeaModel {
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
        public List<ApplyModifyRequestTravelerStandard> TravelerStandard { get; set; }
        public class ApplyModifyRequestTravelerStandard : TeaModel {
            [NameInMap("business_discount")]
            [Validation(Required=false)]
            public int? BusinessDiscount { get; set; }

            [NameInMap("car_city_set")]
            [Validation(Required=false)]
            public List<ApplyModifyRequestTravelerStandardCarCitySet> CarCitySet { get; set; }
            public class ApplyModifyRequestTravelerStandardCarCitySet : TeaModel {
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
            public ApplyModifyRequestTravelerStandardCarStandard CarStandard { get; set; }
            public class ApplyModifyRequestTravelerStandardCarStandard : TeaModel {
                [NameInMap("book_allow_info")]
                [Validation(Required=false)]
                public ApplyModifyRequestTravelerStandardCarStandardBookAllowInfo BookAllowInfo { get; set; }
                public class ApplyModifyRequestTravelerStandardCarStandardBookAllowInfo : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("book_allow")]
                    [Validation(Required=false)]
                    public bool? BookAllow { get; set; }

                }

                [NameInMap("car_helper")]
                [Validation(Required=false)]
                public ApplyModifyRequestTravelerStandardCarStandardCarHelper CarHelper { get; set; }
                public class ApplyModifyRequestTravelerStandardCarStandardCarHelper : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("car_helper_type")]
                    [Validation(Required=false)]
                    public string CarHelperType { get; set; }

                }

                [NameInMap("car_time_control")]
                [Validation(Required=false)]
                public ApplyModifyRequestTravelerStandardCarStandardCarTimeControl CarTimeControl { get; set; }
                public class ApplyModifyRequestTravelerStandardCarStandardCarTimeControl : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("time_limit")]
                    [Validation(Required=false)]
                    public List<ApplyModifyRequestTravelerStandardCarStandardCarTimeControlTimeLimit> TimeLimit { get; set; }
                    public class ApplyModifyRequestTravelerStandardCarStandardCarTimeControlTimeLimit : TeaModel {
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
                public ApplyModifyRequestTravelerStandardCarStandardCityControlInfo CityControlInfo { get; set; }
                public class ApplyModifyRequestTravelerStandardCarStandardCityControlInfo : TeaModel {
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
                    public List<ApplyModifyRequestTravelerStandardCarStandardCityControlInfoCityInfos> CityInfos { get; set; }
                    public class ApplyModifyRequestTravelerStandardCarStandardCityControlInfoCityInfos : TeaModel {
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
                public ApplyModifyRequestTravelerStandardCarStandardCrossCityInfo CrossCityInfo { get; set; }
                public class ApplyModifyRequestTravelerStandardCarStandardCrossCityInfo : TeaModel {
                    [NameInMap("cross_city_list")]
                    [Validation(Required=false)]
                    public List<ApplyModifyRequestTravelerStandardCarStandardCrossCityInfoCrossCityList> CrossCityList { get; set; }
                    public class ApplyModifyRequestTravelerStandardCarStandardCrossCityInfoCrossCityList : TeaModel {
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
                public ApplyModifyRequestTravelerStandardCarStandardElectronicFenceInfo ElectronicFenceInfo { get; set; }
                public class ApplyModifyRequestTravelerStandardCarStandardElectronicFenceInfo : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("electronic_fence_locations_from")]
                    [Validation(Required=false)]
                    public List<ApplyModifyRequestTravelerStandardCarStandardElectronicFenceInfoElectronicFenceLocationsFrom> ElectronicFenceLocationsFrom { get; set; }
                    public class ApplyModifyRequestTravelerStandardCarStandardElectronicFenceInfoElectronicFenceLocationsFrom : TeaModel {
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
                    public List<ApplyModifyRequestTravelerStandardCarStandardElectronicFenceInfoElectronicFenceLocationsTo> ElectronicFenceLocationsTo { get; set; }
                    public class ApplyModifyRequestTravelerStandardCarStandardElectronicFenceInfoElectronicFenceLocationsTo : TeaModel {
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
                public ApplyModifyRequestTravelerStandardCarStandardModifyDestinationInfo ModifyDestinationInfo { get; set; }
                public class ApplyModifyRequestTravelerStandardCarStandardModifyDestinationInfo : TeaModel {
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

            [NameInMap("hotel_intl_citys")]
            [Validation(Required=false)]
            public List<ApplyModifyRequestTravelerStandardHotelIntlCitys> HotelIntlCitys { get; set; }
            public class ApplyModifyRequestTravelerStandardHotelIntlCitys : TeaModel {
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
