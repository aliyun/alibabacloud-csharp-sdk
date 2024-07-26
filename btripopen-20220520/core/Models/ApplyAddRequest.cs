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

        /// <summary>
        /// 可将补充描述传入此字段，账单中将会体现此字段的值。可以用于企业的统计和对账
        /// </summary>
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

        [NameInMap("itinerary_list")]
        [Validation(Required=false)]
        public List<ApplyAddRequestItineraryList> ItineraryList { get; set; }
        public class ApplyAddRequestItineraryList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("arr_city")]
            [Validation(Required=false)]
            public string ArrCity { get; set; }

            [NameInMap("arr_city_code")]
            [Validation(Required=false)]
            public string ArrCityCode { get; set; }

            /// <summary>
            /// This parameter is required.
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
            /// This parameter is required.
            /// </summary>
            [NameInMap("dep_city")]
            [Validation(Required=false)]
            public string DepCity { get; set; }

            [NameInMap("dep_city_code")]
            [Validation(Required=false)]
            public string DepCityCode { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("dep_date")]
            [Validation(Required=false)]
            public string DepDate { get; set; }

            [NameInMap("invoice_id")]
            [Validation(Required=false)]
            public long? InvoiceId { get; set; }

            /// <summary>
            /// This parameter is required.
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
            /// This parameter is required.
            /// </summary>
            [NameInMap("traffic_type")]
            [Validation(Required=false)]
            public int? TrafficType { get; set; }

            /// <summary>
            /// This parameter is required.
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
            /// This parameter is required.
            /// </summary>
            [NameInMap("arr_date")]
            [Validation(Required=false)]
            public string ArrDate { get; set; }

            [NameInMap("attribute")]
            [Validation(Required=false)]
            public string Attribute { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("city_code_set")]
            [Validation(Required=false)]
            public string CityCodeSet { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("city_set")]
            [Validation(Required=false)]
            public string CitySet { get; set; }

            [NameInMap("cost_center_id")]
            [Validation(Required=false)]
            public long? CostCenterId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("dep_date")]
            [Validation(Required=false)]
            public string DepDate { get; set; }

            [NameInMap("invoice_id")]
            [Validation(Required=false)]
            public long? InvoiceId { get; set; }

            /// <summary>
            /// This parameter is required.
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
            /// This parameter is required.
            /// </summary>
            [NameInMap("traffic_type")]
            [Validation(Required=false)]
            public int? TrafficType { get; set; }

        }

        [NameInMap("limit_traveler")]
        [Validation(Required=false)]
        public int? LimitTraveler { get; set; }

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
        /// This parameter is required.
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
                /// This parameter is required.
                /// </summary>
                [NameInMap("city_code")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("city_name")]
                [Validation(Required=false)]
                public string CityName { get; set; }

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
        /// This parameter is required.
        /// </summary>
        [NameInMap("trip_cause")]
        [Validation(Required=false)]
        public string TripCause { get; set; }

        [NameInMap("trip_day")]
        [Validation(Required=false)]
        public int? TripDay { get; set; }

        /// <summary>
        /// This parameter is required.
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
        /// This parameter is required.
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
