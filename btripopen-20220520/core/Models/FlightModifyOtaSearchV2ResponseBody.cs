// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightModifyOtaSearchV2ResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// module
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public FlightModifyOtaSearchV2ResponseBodyModule Module { get; set; }
        public class FlightModifyOtaSearchV2ResponseBodyModule : TeaModel {
            [NameInMap("agentInfos")]
            [Validation(Required=false)]
            public List<FlightModifyOtaSearchV2ResponseBodyModuleAgentInfos> AgentInfos { get; set; }
            public class FlightModifyOtaSearchV2ResponseBodyModuleAgentInfos : TeaModel {
                [NameInMap("attribute_show_info_map")]
                [Validation(Required=false)]
                public Dictionary<string, List<ModuleAgentInfosAttributeShowInfoMapValue>> AttributeShowInfoMap { get; set; }

                [NameInMap("best_discount")]
                [Validation(Required=false)]
                public double? BestDiscount { get; set; }

                [NameInMap("cabin_class_info")]
                [Validation(Required=false)]
                public FlightModifyOtaSearchV2ResponseBodyModuleAgentInfosCabinClassInfo CabinClassInfo { get; set; }
                public class FlightModifyOtaSearchV2ResponseBodyModuleAgentInfosCabinClassInfo : TeaModel {
                    [NameInMap("cabin_class")]
                    [Validation(Required=false)]
                    public string CabinClass { get; set; }

                    [NameInMap("class_name")]
                    [Validation(Required=false)]
                    public string ClassName { get; set; }

                    [NameInMap("inner_cabin_class")]
                    [Validation(Required=false)]
                    public int? InnerCabinClass { get; set; }

                    [NameInMap("quantity")]
                    [Validation(Required=false)]
                    public string Quantity { get; set; }

                }

                [NameInMap("cabin_code")]
                [Validation(Required=false)]
                public int? CabinCode { get; set; }

                [NameInMap("cabin_name")]
                [Validation(Required=false)]
                public string CabinName { get; set; }

                [NameInMap("item_id")]
                [Validation(Required=false)]
                public string ItemId { get; set; }

                [NameInMap("modify_type_desc")]
                [Validation(Required=false)]
                public string ModifyTypeDesc { get; set; }

                [NameInMap("modify_type_name")]
                [Validation(Required=false)]
                public string ModifyTypeName { get; set; }

                [NameInMap("price_info_d_t_o")]
                [Validation(Required=false)]
                public FlightModifyOtaSearchV2ResponseBodyModuleAgentInfosPriceInfoDTO PriceInfoDTO { get; set; }
                public class FlightModifyOtaSearchV2ResponseBodyModuleAgentInfosPriceInfoDTO : TeaModel {
                    [NameInMap("adult_price")]
                    [Validation(Required=false)]
                    public int? AdultPrice { get; set; }

                    [NameInMap("adult_tax")]
                    [Validation(Required=false)]
                    public int? AdultTax { get; set; }

                    [NameInMap("adult_total_price")]
                    [Validation(Required=false)]
                    public int? AdultTotalPrice { get; set; }

                    [NameInMap("before_control_price")]
                    [Validation(Required=false)]
                    public int? BeforeControlPrice { get; set; }

                    [NameInMap("child_price")]
                    [Validation(Required=false)]
                    public int? ChildPrice { get; set; }

                    [NameInMap("child_tax")]
                    [Validation(Required=false)]
                    public int? ChildTax { get; set; }

                    [NameInMap("child_total_price")]
                    [Validation(Required=false)]
                    public int? ChildTotalPrice { get; set; }

                    [NameInMap("infant_price")]
                    [Validation(Required=false)]
                    public int? InfantPrice { get; set; }

                    [NameInMap("infant_tax")]
                    [Validation(Required=false)]
                    public int? InfantTax { get; set; }

                    [NameInMap("infant_total_price")]
                    [Validation(Required=false)]
                    public int? InfantTotalPrice { get; set; }

                    [NameInMap("original_adult_price")]
                    [Validation(Required=false)]
                    public int? OriginalAdultPrice { get; set; }

                    [NameInMap("original_adult_total_price")]
                    [Validation(Required=false)]
                    public int? OriginalAdultTotalPrice { get; set; }

                    [NameInMap("re_shop_price_info_d_t_o")]
                    [Validation(Required=false)]
                    public FlightModifyOtaSearchV2ResponseBodyModuleAgentInfosPriceInfoDTOReShopPriceInfoDTO ReShopPriceInfoDTO { get; set; }
                    public class FlightModifyOtaSearchV2ResponseBodyModuleAgentInfosPriceInfoDTOReShopPriceInfoDTO : TeaModel {
                        [NameInMap("re_shop_adult_change_fee")]
                        [Validation(Required=false)]
                        public int? ReShopAdultChangeFee { get; set; }

                        [NameInMap("re_shop_adult_price")]
                        [Validation(Required=false)]
                        public int? ReShopAdultPrice { get; set; }

                        [NameInMap("re_shop_adult_price_gap")]
                        [Validation(Required=false)]
                        public int? ReShopAdultPriceGap { get; set; }

                        [NameInMap("re_shop_child_change_fee")]
                        [Validation(Required=false)]
                        public int? ReShopChildChangeFee { get; set; }

                        [NameInMap("re_shop_child_price")]
                        [Validation(Required=false)]
                        public int? ReShopChildPrice { get; set; }

                        [NameInMap("re_shop_child_price_gap")]
                        [Validation(Required=false)]
                        public int? ReShopChildPriceGap { get; set; }

                        [NameInMap("re_shop_inf_change_fee")]
                        [Validation(Required=false)]
                        public int? ReShopInfChangeFee { get; set; }

                        [NameInMap("re_shop_inf_price")]
                        [Validation(Required=false)]
                        public int? ReShopInfPrice { get; set; }

                        [NameInMap("re_shop_inf_price_gap")]
                        [Validation(Required=false)]
                        public int? ReShopInfPriceGap { get; set; }

                    }

                }

                [NameInMap("quantity")]
                [Validation(Required=false)]
                public int? Quantity { get; set; }

                [NameInMap("support_child_ticket")]
                [Validation(Required=false)]
                public bool? SupportChildTicket { get; set; }

            }

            [NameInMap("agent_info")]
            [Validation(Required=false)]
            public FlightModifyOtaSearchV2ResponseBodyModuleAgentInfo AgentInfo { get; set; }
            public class FlightModifyOtaSearchV2ResponseBodyModuleAgentInfo : TeaModel {
                [NameInMap("attribute_show_info_map")]
                [Validation(Required=false)]
                public Dictionary<string, List<ModuleAgentInfoAttributeShowInfoMapValue>> AttributeShowInfoMap { get; set; }

                [NameInMap("best_discount")]
                [Validation(Required=false)]
                public double? BestDiscount { get; set; }

                [NameInMap("cabin_class_info")]
                [Validation(Required=false)]
                public FlightModifyOtaSearchV2ResponseBodyModuleAgentInfoCabinClassInfo CabinClassInfo { get; set; }
                public class FlightModifyOtaSearchV2ResponseBodyModuleAgentInfoCabinClassInfo : TeaModel {
                    [NameInMap("cabin_class")]
                    [Validation(Required=false)]
                    public string CabinClass { get; set; }

                    [NameInMap("class_name")]
                    [Validation(Required=false)]
                    public string ClassName { get; set; }

                    /// <summary>
                    /// inner_cabin_class
                    /// </summary>
                    [NameInMap("inner_cabin_class")]
                    [Validation(Required=false)]
                    public int? InnerCabinClass { get; set; }

                    [NameInMap("quantity")]
                    [Validation(Required=false)]
                    public string Quantity { get; set; }

                }

                [NameInMap("cabin_code")]
                [Validation(Required=false)]
                public int? CabinCode { get; set; }

                [NameInMap("cabin_name")]
                [Validation(Required=false)]
                public string CabinName { get; set; }

                /// <summary>
                /// item_id
                /// </summary>
                [NameInMap("item_id")]
                [Validation(Required=false)]
                public string ItemId { get; set; }

                [NameInMap("modify_type_desc")]
                [Validation(Required=false)]
                public string ModifyTypeDesc { get; set; }

                [NameInMap("modify_type_name")]
                [Validation(Required=false)]
                public string ModifyTypeName { get; set; }

                [NameInMap("price_info_d_t_o")]
                [Validation(Required=false)]
                public FlightModifyOtaSearchV2ResponseBodyModuleAgentInfoPriceInfoDTO PriceInfoDTO { get; set; }
                public class FlightModifyOtaSearchV2ResponseBodyModuleAgentInfoPriceInfoDTO : TeaModel {
                    [NameInMap("adult_price")]
                    [Validation(Required=false)]
                    public int? AdultPrice { get; set; }

                    [NameInMap("adult_tax")]
                    [Validation(Required=false)]
                    public int? AdultTax { get; set; }

                    [NameInMap("adult_total_price")]
                    [Validation(Required=false)]
                    public int? AdultTotalPrice { get; set; }

                    [NameInMap("before_control_price")]
                    [Validation(Required=false)]
                    public int? BeforeControlPrice { get; set; }

                    [NameInMap("child_price")]
                    [Validation(Required=false)]
                    public int? ChildPrice { get; set; }

                    [NameInMap("child_tax")]
                    [Validation(Required=false)]
                    public int? ChildTax { get; set; }

                    [NameInMap("child_total_price")]
                    [Validation(Required=false)]
                    public int? ChildTotalPrice { get; set; }

                    [NameInMap("infant_price")]
                    [Validation(Required=false)]
                    public int? InfantPrice { get; set; }

                    [NameInMap("infant_tax")]
                    [Validation(Required=false)]
                    public int? InfantTax { get; set; }

                    [NameInMap("infant_total_price")]
                    [Validation(Required=false)]
                    public int? InfantTotalPrice { get; set; }

                    [NameInMap("original_adult_price")]
                    [Validation(Required=false)]
                    public int? OriginalAdultPrice { get; set; }

                    [NameInMap("original_adult_total_price")]
                    [Validation(Required=false)]
                    public int? OriginalAdultTotalPrice { get; set; }

                    [NameInMap("re_shop_price_info_d_t_o")]
                    [Validation(Required=false)]
                    public FlightModifyOtaSearchV2ResponseBodyModuleAgentInfoPriceInfoDTOReShopPriceInfoDTO ReShopPriceInfoDTO { get; set; }
                    public class FlightModifyOtaSearchV2ResponseBodyModuleAgentInfoPriceInfoDTOReShopPriceInfoDTO : TeaModel {
                        [NameInMap("re_shop_adult_change_fee")]
                        [Validation(Required=false)]
                        public int? ReShopAdultChangeFee { get; set; }

                        [NameInMap("re_shop_adult_price")]
                        [Validation(Required=false)]
                        public int? ReShopAdultPrice { get; set; }

                        [NameInMap("re_shop_adult_price_gap")]
                        [Validation(Required=false)]
                        public int? ReShopAdultPriceGap { get; set; }

                        [NameInMap("re_shop_child_change_fee")]
                        [Validation(Required=false)]
                        public int? ReShopChildChangeFee { get; set; }

                        [NameInMap("re_shop_child_price")]
                        [Validation(Required=false)]
                        public int? ReShopChildPrice { get; set; }

                        [NameInMap("re_shop_child_price_gap")]
                        [Validation(Required=false)]
                        public int? ReShopChildPriceGap { get; set; }

                        [NameInMap("re_shop_inf_change_fee")]
                        [Validation(Required=false)]
                        public int? ReShopInfChangeFee { get; set; }

                        [NameInMap("re_shop_inf_price")]
                        [Validation(Required=false)]
                        public int? ReShopInfPrice { get; set; }

                        [NameInMap("re_shop_inf_price_gap")]
                        [Validation(Required=false)]
                        public int? ReShopInfPriceGap { get; set; }

                    }

                }

                [NameInMap("quantity")]
                [Validation(Required=false)]
                public int? Quantity { get; set; }

                [NameInMap("support_child_ticket")]
                [Validation(Required=false)]
                public bool? SupportChildTicket { get; set; }

            }

            [NameInMap("cache_key")]
            [Validation(Required=false)]
            public string CacheKey { get; set; }

            [NameInMap("flight_segment_infos")]
            [Validation(Required=false)]
            public List<List<FlightModifyOtaSearchV2ResponseBodyModuleFlightSegmentInfos>> FlightSegmentInfos { get; set; }
            public class FlightModifyOtaSearchV2ResponseBodyModuleFlightSegmentInfos : TeaModel {
                [NameInMap("journey_seq")]
                [Validation(Required=false)]
                public int? JourneySeq { get; set; }

                [NameInMap("segment_seq")]
                [Validation(Required=false)]
                public int? SegmentSeq { get; set; }

                [NameInMap("flight_no")]
                [Validation(Required=false)]
                public string FlightNo { get; set; }

                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                [NameInMap("dep_city_name")]
                [Validation(Required=false)]
                public string DepCityName { get; set; }

                [NameInMap("arr_city_name")]
                [Validation(Required=false)]
                public string ArrCityName { get; set; }

                [NameInMap("dep_airport_info")]
                [Validation(Required=false)]
                public FlightModifyOtaSearchV2ResponseBodyModuleFlightSegmentInfosDepAirportInfo DepAirportInfo { get; set; }
                public class FlightModifyOtaSearchV2ResponseBodyModuleFlightSegmentInfosDepAirportInfo : TeaModel {
                    [NameInMap("airport_code")]
                    [Validation(Required=false)]
                    public string AirportCode { get; set; }

                    [NameInMap("airport_name")]
                    [Validation(Required=false)]
                    public string AirportName { get; set; }

                    [NameInMap("airport_short_name")]
                    [Validation(Required=false)]
                    public string AirportShortName { get; set; }

                    [NameInMap("terminal")]
                    [Validation(Required=false)]
                    public string Terminal { get; set; }

                }

                [NameInMap("arr_airport_info")]
                [Validation(Required=false)]
                public FlightModifyOtaSearchV2ResponseBodyModuleFlightSegmentInfosArrAirportInfo ArrAirportInfo { get; set; }
                public class FlightModifyOtaSearchV2ResponseBodyModuleFlightSegmentInfosArrAirportInfo : TeaModel {
                    [NameInMap("airport_code")]
                    [Validation(Required=false)]
                    public string AirportCode { get; set; }

                    [NameInMap("airport_name")]
                    [Validation(Required=false)]
                    public string AirportName { get; set; }

                    [NameInMap("airport_short_name")]
                    [Validation(Required=false)]
                    public string AirportShortName { get; set; }

                    [NameInMap("terminal")]
                    [Validation(Required=false)]
                    public string Terminal { get; set; }

                }

                [NameInMap("dep_time")]
                [Validation(Required=false)]
                public string DepTime { get; set; }

                [NameInMap("arr_time")]
                [Validation(Required=false)]
                public string ArrTime { get; set; }

                [NameInMap("airline_info")]
                [Validation(Required=false)]
                public FlightModifyOtaSearchV2ResponseBodyModuleFlightSegmentInfosAirlineInfo AirlineInfo { get; set; }
                public class FlightModifyOtaSearchV2ResponseBodyModuleFlightSegmentInfosAirlineInfo : TeaModel {
                    [NameInMap("airline_code")]
                    [Validation(Required=false)]
                    public string AirlineCode { get; set; }

                    [NameInMap("airline_chinese_name")]
                    [Validation(Required=false)]
                    public string AirlineChineseName { get; set; }

                    [NameInMap("airline_chinese_short_name")]
                    [Validation(Required=false)]
                    public string AirlineChineseShortName { get; set; }

                    [NameInMap("airline_icon")]
                    [Validation(Required=false)]
                    public string AirlineIcon { get; set; }

                    [NameInMap("cheap_flight")]
                    [Validation(Required=false)]
                    public bool? CheapFlight { get; set; }

                }

                [NameInMap("share")]
                [Validation(Required=false)]
                public bool? Share { get; set; }

                [NameInMap("flight_shared_info")]
                [Validation(Required=false)]
                public FlightModifyOtaSearchV2ResponseBodyModuleFlightSegmentInfosFlightSharedInfo FlightSharedInfo { get; set; }
                public class FlightModifyOtaSearchV2ResponseBodyModuleFlightSegmentInfosFlightSharedInfo : TeaModel {
                    [NameInMap("operating_flight_no")]
                    [Validation(Required=false)]
                    public string OperatingFlightNo { get; set; }

                    [NameInMap("operating_airline_info")]
                    [Validation(Required=false)]
                    public FlightModifyOtaSearchV2ResponseBodyModuleFlightSegmentInfosFlightSharedInfoOperatingAirlineInfo OperatingAirlineInfo { get; set; }
                    public class FlightModifyOtaSearchV2ResponseBodyModuleFlightSegmentInfosFlightSharedInfoOperatingAirlineInfo : TeaModel {
                        [NameInMap("airline_code")]
                        [Validation(Required=false)]
                        public string AirlineCode { get; set; }

                        [NameInMap("airline_chinese_name")]
                        [Validation(Required=false)]
                        public string AirlineChineseName { get; set; }

                        [NameInMap("airline_chinese_short_name")]
                        [Validation(Required=false)]
                        public string AirlineChineseShortName { get; set; }

                        [NameInMap("airline_icon")]
                        [Validation(Required=false)]
                        public string AirlineIcon { get; set; }

                        [NameInMap("cheap_flight")]
                        [Validation(Required=false)]
                        public bool? CheapFlight { get; set; }

                    }

                }

                [NameInMap("stop")]
                [Validation(Required=false)]
                public bool? Stop { get; set; }

                [NameInMap("flight_stop_info")]
                [Validation(Required=false)]
                public FlightModifyOtaSearchV2ResponseBodyModuleFlightSegmentInfosFlightStopInfo FlightStopInfo { get; set; }
                public class FlightModifyOtaSearchV2ResponseBodyModuleFlightSegmentInfosFlightStopInfo : TeaModel {
                    [NameInMap("stop_city_name")]
                    [Validation(Required=false)]
                    public string StopCityName { get; set; }

                    [NameInMap("stop_arr_time")]
                    [Validation(Required=false)]
                    public string StopArrTime { get; set; }

                    [NameInMap("stop_dep_time")]
                    [Validation(Required=false)]
                    public string StopDepTime { get; set; }

                    [NameInMap("stop_city_code")]
                    [Validation(Required=false)]
                    public string StopCityCode { get; set; }

                    [NameInMap("stop_airport")]
                    [Validation(Required=false)]
                    public string StopAirport { get; set; }

                    [NameInMap("stop_arr_term")]
                    [Validation(Required=false)]
                    public string StopArrTerm { get; set; }

                    [NameInMap("stop_dep_term")]
                    [Validation(Required=false)]
                    public string StopDepTerm { get; set; }

                }

                [NameInMap("transfer_time")]
                [Validation(Required=false)]
                public int? TransferTime { get; set; }

                [NameInMap("duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                [NameInMap("manufacturer")]
                [Validation(Required=false)]
                public string Manufacturer { get; set; }

                [NameInMap("flight_type")]
                [Validation(Required=false)]
                public string FlightType { get; set; }

                [NameInMap("flight_size")]
                [Validation(Required=false)]
                public string FlightSize { get; set; }

                [NameInMap("meal_desc")]
                [Validation(Required=false)]
                public string MealDesc { get; set; }

                [NameInMap("on_time_rate")]
                [Validation(Required=false)]
                public string OnTimeRate { get; set; }

            }

            [NameInMap("passenger_count")]
            [Validation(Required=false)]
            public FlightModifyOtaSearchV2ResponseBodyModulePassengerCount PassengerCount { get; set; }
            public class FlightModifyOtaSearchV2ResponseBodyModulePassengerCount : TeaModel {
                [NameInMap("adult_passenger_num")]
                [Validation(Required=false)]
                public int? AdultPassengerNum { get; set; }

                [NameInMap("child_passenger_num")]
                [Validation(Required=false)]
                public int? ChildPassengerNum { get; set; }

                [NameInMap("infant_passenger_num")]
                [Validation(Required=false)]
                public int? InfantPassengerNum { get; set; }

            }

            [NameInMap("session_id")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

        }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// traceId
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
