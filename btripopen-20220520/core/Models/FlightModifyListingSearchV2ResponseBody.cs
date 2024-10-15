// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightModifyListingSearchV2ResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>module</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public FlightModifyListingSearchV2ResponseBodyModule Module { get; set; }
        public class FlightModifyListingSearchV2ResponseBodyModule : TeaModel {
            [NameInMap("direct_flight_list")]
            [Validation(Required=false)]
            public List<FlightModifyListingSearchV2ResponseBodyModuleDirectFlightList> DirectFlightList { get; set; }
            public class FlightModifyListingSearchV2ResponseBodyModuleDirectFlightList : TeaModel {
                [NameInMap("airline_info")]
                [Validation(Required=false)]
                public FlightModifyListingSearchV2ResponseBodyModuleDirectFlightListAirlineInfo AirlineInfo { get; set; }
                public class FlightModifyListingSearchV2ResponseBodyModuleDirectFlightListAirlineInfo : TeaModel {
                    [NameInMap("airline_chinese_name")]
                    [Validation(Required=false)]
                    public string AirlineChineseName { get; set; }

                    [NameInMap("airline_chinese_short_name")]
                    [Validation(Required=false)]
                    public string AirlineChineseShortName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>CA</para>
                    /// </summary>
                    [NameInMap("airline_code")]
                    [Validation(Required=false)]
                    public string AirlineCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>//gw.alicdn.com/tfs/TB12fJAFHr1gK0jSZR0XXbP8XXa-450-450.png_80x80.jpg</para>
                    /// </summary>
                    [NameInMap("airline_icon")]
                    [Validation(Required=false)]
                    public string AirlineIcon { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("cheap_flight")]
                    [Validation(Required=false)]
                    public bool? CheapFlight { get; set; }

                }

                [NameInMap("arr_airport_info")]
                [Validation(Required=false)]
                public FlightModifyListingSearchV2ResponseBodyModuleDirectFlightListArrAirportInfo ArrAirportInfo { get; set; }
                public class FlightModifyListingSearchV2ResponseBodyModuleDirectFlightListArrAirportInfo : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>XIL</para>
                    /// </summary>
                    [NameInMap("airport_code")]
                    [Validation(Required=false)]
                    public string AirportCode { get; set; }

                    [NameInMap("airport_name")]
                    [Validation(Required=false)]
                    public string AirportName { get; set; }

                    [NameInMap("airport_short_name")]
                    [Validation(Required=false)]
                    public string AirportShortName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>T3</para>
                    /// </summary>
                    [NameInMap("terminal")]
                    [Validation(Required=false)]
                    public string Terminal { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>BJS</para>
                /// </summary>
                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-09-18 10:25:00</para>
                /// </summary>
                [NameInMap("arr_time")]
                [Validation(Required=false)]
                public string ArrTime { get; set; }

                [NameInMap("cabinClass")]
                [Validation(Required=false)]
                public string CabinClass { get; set; }

                [NameInMap("cabinClassName")]
                [Validation(Required=false)]
                public string CabinClassName { get; set; }

                [NameInMap("dep_airport_info")]
                [Validation(Required=false)]
                public FlightModifyListingSearchV2ResponseBodyModuleDirectFlightListDepAirportInfo DepAirportInfo { get; set; }
                public class FlightModifyListingSearchV2ResponseBodyModuleDirectFlightListDepAirportInfo : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>PEK</para>
                    /// </summary>
                    [NameInMap("airport_code")]
                    [Validation(Required=false)]
                    public string AirportCode { get; set; }

                    [NameInMap("airport_name")]
                    [Validation(Required=false)]
                    public string AirportName { get; set; }

                    [NameInMap("airport_short_name")]
                    [Validation(Required=false)]
                    public string AirportShortName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>T2</para>
                    /// </summary>
                    [NameInMap("terminal")]
                    [Validation(Required=false)]
                    public string Terminal { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>XIL</para>
                /// </summary>
                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-09-18 09:10:00</para>
                /// </summary>
                [NameInMap("dep_time")]
                [Validation(Required=false)]
                public string DepTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>240</para>
                /// </summary>
                [NameInMap("duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CA1110</para>
                /// </summary>
                [NameInMap("flight_no")]
                [Validation(Required=false)]
                public string FlightNo { get; set; }

                [NameInMap("flight_share_info")]
                [Validation(Required=false)]
                public FlightModifyListingSearchV2ResponseBodyModuleDirectFlightListFlightShareInfo FlightShareInfo { get; set; }
                public class FlightModifyListingSearchV2ResponseBodyModuleDirectFlightListFlightShareInfo : TeaModel {
                    [NameInMap("operating_airline_info")]
                    [Validation(Required=false)]
                    public FlightModifyListingSearchV2ResponseBodyModuleDirectFlightListFlightShareInfoOperatingAirlineInfo OperatingAirlineInfo { get; set; }
                    public class FlightModifyListingSearchV2ResponseBodyModuleDirectFlightListFlightShareInfoOperatingAirlineInfo : TeaModel {
                        [NameInMap("airline_chinese_name")]
                        [Validation(Required=false)]
                        public string AirlineChineseName { get; set; }

                        [NameInMap("airline_chinese_short_name")]
                        [Validation(Required=false)]
                        public string AirlineChineseShortName { get; set; }

                        [NameInMap("airline_code")]
                        [Validation(Required=false)]
                        public string AirlineCode { get; set; }

                        [NameInMap("airline_icon")]
                        [Validation(Required=false)]
                        public string AirlineIcon { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("cheap_flight")]
                        [Validation(Required=false)]
                        public bool? CheapFlight { get; set; }

                    }

                    [NameInMap("operating_flight_no")]
                    [Validation(Required=false)]
                    public string OperatingFlightNo { get; set; }

                }

                [NameInMap("flight_size")]
                [Validation(Required=false)]
                public string FlightSize { get; set; }

                [NameInMap("flight_stop_info")]
                [Validation(Required=false)]
                public FlightModifyListingSearchV2ResponseBodyModuleDirectFlightListFlightStopInfo FlightStopInfo { get; set; }
                public class FlightModifyListingSearchV2ResponseBodyModuleDirectFlightListFlightStopInfo : TeaModel {
                    [NameInMap("stop_airport")]
                    [Validation(Required=false)]
                    public string StopAirport { get; set; }

                    [NameInMap("stop_arr_term")]
                    [Validation(Required=false)]
                    public string StopArrTerm { get; set; }

                    [NameInMap("stop_arr_time")]
                    [Validation(Required=false)]
                    public string StopArrTime { get; set; }

                    [NameInMap("stop_city_code")]
                    [Validation(Required=false)]
                    public string StopCityCode { get; set; }

                    [NameInMap("stop_city_name")]
                    [Validation(Required=false)]
                    public string StopCityName { get; set; }

                    [NameInMap("stop_dep_term")]
                    [Validation(Required=false)]
                    public string StopDepTerm { get; set; }

                    [NameInMap("stop_dep_time")]
                    [Validation(Required=false)]
                    public string StopDepTime { get; set; }

                }

                [NameInMap("flight_transfer_info")]
                [Validation(Required=false)]
                public FlightModifyListingSearchV2ResponseBodyModuleDirectFlightListFlightTransferInfo FlightTransferInfo { get; set; }
                public class FlightModifyListingSearchV2ResponseBodyModuleDirectFlightListFlightTransferInfo : TeaModel {
                    [NameInMap("transfer_airline_info")]
                    [Validation(Required=false)]
                    public FlightModifyListingSearchV2ResponseBodyModuleDirectFlightListFlightTransferInfoTransferAirlineInfo TransferAirlineInfo { get; set; }
                    public class FlightModifyListingSearchV2ResponseBodyModuleDirectFlightListFlightTransferInfoTransferAirlineInfo : TeaModel {
                        [NameInMap("airline_chinese_name")]
                        [Validation(Required=false)]
                        public string AirlineChineseName { get; set; }

                        [NameInMap("airline_chinese_short_name")]
                        [Validation(Required=false)]
                        public string AirlineChineseShortName { get; set; }

                        [NameInMap("airline_code")]
                        [Validation(Required=false)]
                        public string AirlineCode { get; set; }

                        [NameInMap("airline_icon")]
                        [Validation(Required=false)]
                        public string AirlineIcon { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("cheap_flight")]
                        [Validation(Required=false)]
                        public bool? CheapFlight { get; set; }

                    }

                    [NameInMap("transfer_city_code")]
                    [Validation(Required=false)]
                    public string TransferCityCode { get; set; }

                    [NameInMap("transfer_city_name")]
                    [Validation(Required=false)]
                    public string TransferCityName { get; set; }

                    [NameInMap("transfer_dep_time")]
                    [Validation(Required=false)]
                    public string TransferDepTime { get; set; }

                    [NameInMap("transfer_flight_no")]
                    [Validation(Required=false)]
                    public string TransferFlightNo { get; set; }

                    [NameInMap("transfer_flight_size")]
                    [Validation(Required=false)]
                    public string TransferFlightSize { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("transfer_share")]
                    [Validation(Required=false)]
                    public bool? TransferShare { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>60</para>
                    /// </summary>
                    [NameInMap("transfer_stop_time")]
                    [Validation(Required=false)]
                    public int? TransferStopTime { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ARJ</para>
                /// </summary>
                [NameInMap("flight_type")]
                [Validation(Required=false)]
                public string FlightType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("journey_seq")]
                [Validation(Required=false)]
                public int? JourneySeq { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("left_num")]
                [Validation(Required=false)]
                public string LeftNum { get; set; }

                [NameInMap("manufacturer")]
                [Validation(Required=false)]
                public string Manufacturer { get; set; }

                [NameInMap("meal_desc")]
                [Validation(Required=false)]
                public string MealDesc { get; set; }

                [NameInMap("price_info_d_t_o")]
                [Validation(Required=false)]
                public FlightModifyListingSearchV2ResponseBodyModuleDirectFlightListPriceInfoDTO PriceInfoDTO { get; set; }
                public class FlightModifyListingSearchV2ResponseBodyModuleDirectFlightListPriceInfoDTO : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>126000</para>
                    /// </summary>
                    [NameInMap("adult_price")]
                    [Validation(Required=false)]
                    public int? AdultPrice { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>11000</para>
                    /// </summary>
                    [NameInMap("adult_tax")]
                    [Validation(Required=false)]
                    public int? AdultTax { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>137000</para>
                    /// </summary>
                    [NameInMap("adult_total_price")]
                    [Validation(Required=false)]
                    public int? AdultTotalPrice { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>126000</para>
                    /// </summary>
                    [NameInMap("before_control_price")]
                    [Validation(Required=false)]
                    public int? BeforeControlPrice { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>64000</para>
                    /// </summary>
                    [NameInMap("child_price")]
                    [Validation(Required=false)]
                    public int? ChildPrice { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2000</para>
                    /// </summary>
                    [NameInMap("child_tax")]
                    [Validation(Required=false)]
                    public int? ChildTax { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>66000</para>
                    /// </summary>
                    [NameInMap("child_total_price")]
                    [Validation(Required=false)]
                    public int? ChildTotalPrice { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>12000</para>
                    /// </summary>
                    [NameInMap("infant_price")]
                    [Validation(Required=false)]
                    public int? InfantPrice { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("infant_tax")]
                    [Validation(Required=false)]
                    public int? InfantTax { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>12000</para>
                    /// </summary>
                    [NameInMap("infant_total_price")]
                    [Validation(Required=false)]
                    public int? InfantTotalPrice { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1300</para>
                    /// </summary>
                    [NameInMap("original_adult_price")]
                    [Validation(Required=false)]
                    public int? OriginalAdultPrice { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>12300</para>
                    /// </summary>
                    [NameInMap("original_adult_total_price")]
                    [Validation(Required=false)]
                    public int? OriginalAdultTotalPrice { get; set; }

                    [NameInMap("re_shop_price_info_d_t_o")]
                    [Validation(Required=false)]
                    public FlightModifyListingSearchV2ResponseBodyModuleDirectFlightListPriceInfoDTOReShopPriceInfoDTO ReShopPriceInfoDTO { get; set; }
                    public class FlightModifyListingSearchV2ResponseBodyModuleDirectFlightListPriceInfoDTOReShopPriceInfoDTO : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_adult_change_fee")]
                        [Validation(Required=false)]
                        public int? ReShopAdultChangeFee { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_adult_price")]
                        [Validation(Required=false)]
                        public int? ReShopAdultPrice { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_adult_price_gap")]
                        [Validation(Required=false)]
                        public int? ReShopAdultPriceGap { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_child_change_fee")]
                        [Validation(Required=false)]
                        public int? ReShopChildChangeFee { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_child_price")]
                        [Validation(Required=false)]
                        public int? ReShopChildPrice { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_child_price_gap")]
                        [Validation(Required=false)]
                        public int? ReShopChildPriceGap { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_inf_change_fee")]
                        [Validation(Required=false)]
                        public int? ReShopInfChangeFee { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_inf_price")]
                        [Validation(Required=false)]
                        public int? ReShopInfPrice { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_inf_price_gap")]
                        [Validation(Required=false)]
                        public int? ReShopInfPriceGap { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("segment_seq")]
                [Validation(Required=false)]
                public int? SegmentSeq { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("share")]
                [Validation(Required=false)]
                public bool? Share { get; set; }

                [NameInMap("short_flight_size")]
                [Validation(Required=false)]
                public string ShortFlightSize { get; set; }

                [NameInMap("span_day")]
                [Validation(Required=false)]
                public string SpanDay { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("stop")]
                [Validation(Required=false)]
                public bool? Stop { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("transfer")]
                [Validation(Required=false)]
                public bool? Transfer { get; set; }

            }

            [NameInMap("next_req_wait_time")]
            [Validation(Required=false)]
            public long? NextReqWaitTime { get; set; }

            [NameInMap("retry")]
            [Validation(Required=false)]
            public bool? Retry { get; set; }

            [NameInMap("search_retry_token")]
            [Validation(Required=false)]
            public string SearchRetryToken { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>a2ffebfe733742aab5c491d960ba3d59</para>
            /// </summary>
            [NameInMap("session_id")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            [NameInMap("transfer_flight_list")]
            [Validation(Required=false)]
            public List<FlightModifyListingSearchV2ResponseBodyModuleTransferFlightList> TransferFlightList { get; set; }
            public class FlightModifyListingSearchV2ResponseBodyModuleTransferFlightList : TeaModel {
                [NameInMap("airline_info")]
                [Validation(Required=false)]
                public FlightModifyListingSearchV2ResponseBodyModuleTransferFlightListAirlineInfo AirlineInfo { get; set; }
                public class FlightModifyListingSearchV2ResponseBodyModuleTransferFlightListAirlineInfo : TeaModel {
                    [NameInMap("airline_chinese_name")]
                    [Validation(Required=false)]
                    public string AirlineChineseName { get; set; }

                    [NameInMap("airline_chinese_short_name")]
                    [Validation(Required=false)]
                    public string AirlineChineseShortName { get; set; }

                    [NameInMap("airline_code")]
                    [Validation(Required=false)]
                    public string AirlineCode { get; set; }

                    [NameInMap("airline_icon")]
                    [Validation(Required=false)]
                    public string AirlineIcon { get; set; }

                    [NameInMap("cheap_flight")]
                    [Validation(Required=false)]
                    public bool? CheapFlight { get; set; }

                }

                [NameInMap("arr_airport_info")]
                [Validation(Required=false)]
                public FlightModifyListingSearchV2ResponseBodyModuleTransferFlightListArrAirportInfo ArrAirportInfo { get; set; }
                public class FlightModifyListingSearchV2ResponseBodyModuleTransferFlightListArrAirportInfo : TeaModel {
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

                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                [NameInMap("arr_time")]
                [Validation(Required=false)]
                public string ArrTime { get; set; }

                [NameInMap("cabinClass")]
                [Validation(Required=false)]
                public string CabinClass { get; set; }

                [NameInMap("cabinClassName")]
                [Validation(Required=false)]
                public string CabinClassName { get; set; }

                [NameInMap("dep_airport_info")]
                [Validation(Required=false)]
                public FlightModifyListingSearchV2ResponseBodyModuleTransferFlightListDepAirportInfo DepAirportInfo { get; set; }
                public class FlightModifyListingSearchV2ResponseBodyModuleTransferFlightListDepAirportInfo : TeaModel {
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

                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                [NameInMap("dep_time")]
                [Validation(Required=false)]
                public string DepTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>240</para>
                /// </summary>
                [NameInMap("duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                [NameInMap("flight_no")]
                [Validation(Required=false)]
                public string FlightNo { get; set; }

                [NameInMap("flight_share_info")]
                [Validation(Required=false)]
                public FlightModifyListingSearchV2ResponseBodyModuleTransferFlightListFlightShareInfo FlightShareInfo { get; set; }
                public class FlightModifyListingSearchV2ResponseBodyModuleTransferFlightListFlightShareInfo : TeaModel {
                    [NameInMap("operating_airline_info")]
                    [Validation(Required=false)]
                    public FlightModifyListingSearchV2ResponseBodyModuleTransferFlightListFlightShareInfoOperatingAirlineInfo OperatingAirlineInfo { get; set; }
                    public class FlightModifyListingSearchV2ResponseBodyModuleTransferFlightListFlightShareInfoOperatingAirlineInfo : TeaModel {
                        [NameInMap("airline_chinese_name")]
                        [Validation(Required=false)]
                        public string AirlineChineseName { get; set; }

                        [NameInMap("airline_chinese_short_name")]
                        [Validation(Required=false)]
                        public string AirlineChineseShortName { get; set; }

                        [NameInMap("airline_code")]
                        [Validation(Required=false)]
                        public string AirlineCode { get; set; }

                        [NameInMap("airline_icon")]
                        [Validation(Required=false)]
                        public string AirlineIcon { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("cheap_flight")]
                        [Validation(Required=false)]
                        public bool? CheapFlight { get; set; }

                    }

                    [NameInMap("operating_flight_no")]
                    [Validation(Required=false)]
                    public string OperatingFlightNo { get; set; }

                }

                [NameInMap("flight_size")]
                [Validation(Required=false)]
                public string FlightSize { get; set; }

                [NameInMap("flight_stop_info")]
                [Validation(Required=false)]
                public FlightModifyListingSearchV2ResponseBodyModuleTransferFlightListFlightStopInfo FlightStopInfo { get; set; }
                public class FlightModifyListingSearchV2ResponseBodyModuleTransferFlightListFlightStopInfo : TeaModel {
                    [NameInMap("stop_airport")]
                    [Validation(Required=false)]
                    public string StopAirport { get; set; }

                    [NameInMap("stop_arr_term")]
                    [Validation(Required=false)]
                    public string StopArrTerm { get; set; }

                    [NameInMap("stop_arr_time")]
                    [Validation(Required=false)]
                    public string StopArrTime { get; set; }

                    [NameInMap("stop_city_code")]
                    [Validation(Required=false)]
                    public string StopCityCode { get; set; }

                    [NameInMap("stop_city_name")]
                    [Validation(Required=false)]
                    public string StopCityName { get; set; }

                    [NameInMap("stop_dep_term")]
                    [Validation(Required=false)]
                    public string StopDepTerm { get; set; }

                    [NameInMap("stop_dep_time")]
                    [Validation(Required=false)]
                    public string StopDepTime { get; set; }

                }

                [NameInMap("flight_transfer_info")]
                [Validation(Required=false)]
                public FlightModifyListingSearchV2ResponseBodyModuleTransferFlightListFlightTransferInfo FlightTransferInfo { get; set; }
                public class FlightModifyListingSearchV2ResponseBodyModuleTransferFlightListFlightTransferInfo : TeaModel {
                    [NameInMap("transfer_airline_info")]
                    [Validation(Required=false)]
                    public FlightModifyListingSearchV2ResponseBodyModuleTransferFlightListFlightTransferInfoTransferAirlineInfo TransferAirlineInfo { get; set; }
                    public class FlightModifyListingSearchV2ResponseBodyModuleTransferFlightListFlightTransferInfoTransferAirlineInfo : TeaModel {
                        [NameInMap("airline_chinese_name")]
                        [Validation(Required=false)]
                        public string AirlineChineseName { get; set; }

                        [NameInMap("airline_chinese_short_name")]
                        [Validation(Required=false)]
                        public string AirlineChineseShortName { get; set; }

                        [NameInMap("airline_code")]
                        [Validation(Required=false)]
                        public string AirlineCode { get; set; }

                        [NameInMap("airline_icon")]
                        [Validation(Required=false)]
                        public string AirlineIcon { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("cheap_flight")]
                        [Validation(Required=false)]
                        public bool? CheapFlight { get; set; }

                    }

                    [NameInMap("transfer_city_code")]
                    [Validation(Required=false)]
                    public string TransferCityCode { get; set; }

                    [NameInMap("transfer_city_name")]
                    [Validation(Required=false)]
                    public string TransferCityName { get; set; }

                    [NameInMap("transfer_dep_time")]
                    [Validation(Required=false)]
                    public string TransferDepTime { get; set; }

                    [NameInMap("transfer_flight_no")]
                    [Validation(Required=false)]
                    public string TransferFlightNo { get; set; }

                    [NameInMap("transfer_flight_size")]
                    [Validation(Required=false)]
                    public string TransferFlightSize { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("transfer_share")]
                    [Validation(Required=false)]
                    public bool? TransferShare { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("transfer_stop_time")]
                    [Validation(Required=false)]
                    public int? TransferStopTime { get; set; }

                }

                [NameInMap("flight_type")]
                [Validation(Required=false)]
                public string FlightType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("journey_seq")]
                [Validation(Required=false)]
                public int? JourneySeq { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("left_num")]
                [Validation(Required=false)]
                public string LeftNum { get; set; }

                [NameInMap("manufacturer")]
                [Validation(Required=false)]
                public string Manufacturer { get; set; }

                [NameInMap("meal_desc")]
                [Validation(Required=false)]
                public string MealDesc { get; set; }

                [NameInMap("price_info_d_t_o")]
                [Validation(Required=false)]
                public FlightModifyListingSearchV2ResponseBodyModuleTransferFlightListPriceInfoDTO PriceInfoDTO { get; set; }
                public class FlightModifyListingSearchV2ResponseBodyModuleTransferFlightListPriceInfoDTO : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("adult_price")]
                    [Validation(Required=false)]
                    public int? AdultPrice { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("adult_tax")]
                    [Validation(Required=false)]
                    public int? AdultTax { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("adult_total_price")]
                    [Validation(Required=false)]
                    public int? AdultTotalPrice { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("before_control_price")]
                    [Validation(Required=false)]
                    public int? BeforeControlPrice { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("child_price")]
                    [Validation(Required=false)]
                    public int? ChildPrice { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("child_tax")]
                    [Validation(Required=false)]
                    public int? ChildTax { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("child_total_price")]
                    [Validation(Required=false)]
                    public int? ChildTotalPrice { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("infant_price")]
                    [Validation(Required=false)]
                    public int? InfantPrice { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("infant_tax")]
                    [Validation(Required=false)]
                    public int? InfantTax { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("infant_total_price")]
                    [Validation(Required=false)]
                    public int? InfantTotalPrice { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("original_adult_price")]
                    [Validation(Required=false)]
                    public int? OriginalAdultPrice { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("original_adult_total_price")]
                    [Validation(Required=false)]
                    public int? OriginalAdultTotalPrice { get; set; }

                    [NameInMap("re_shop_price_info_d_t_o")]
                    [Validation(Required=false)]
                    public FlightModifyListingSearchV2ResponseBodyModuleTransferFlightListPriceInfoDTOReShopPriceInfoDTO ReShopPriceInfoDTO { get; set; }
                    public class FlightModifyListingSearchV2ResponseBodyModuleTransferFlightListPriceInfoDTOReShopPriceInfoDTO : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_adult_change_fee")]
                        [Validation(Required=false)]
                        public int? ReShopAdultChangeFee { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_adult_price")]
                        [Validation(Required=false)]
                        public int? ReShopAdultPrice { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_adult_price_gap")]
                        [Validation(Required=false)]
                        public int? ReShopAdultPriceGap { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_child_change_fee")]
                        [Validation(Required=false)]
                        public int? ReShopChildChangeFee { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_child_price")]
                        [Validation(Required=false)]
                        public int? ReShopChildPrice { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_child_price_gap")]
                        [Validation(Required=false)]
                        public int? ReShopChildPriceGap { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_inf_change_fee")]
                        [Validation(Required=false)]
                        public int? ReShopInfChangeFee { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_inf_price")]
                        [Validation(Required=false)]
                        public int? ReShopInfPrice { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_inf_price_gap")]
                        [Validation(Required=false)]
                        public int? ReShopInfPriceGap { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("segment_seq")]
                [Validation(Required=false)]
                public int? SegmentSeq { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("share")]
                [Validation(Required=false)]
                public bool? Share { get; set; }

                [NameInMap("short_flight_size")]
                [Validation(Required=false)]
                public string ShortFlightSize { get; set; }

                [NameInMap("span_day")]
                [Validation(Required=false)]
                public string SpanDay { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("stop")]
                [Validation(Required=false)]
                public bool? Stop { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("transfer")]
                [Validation(Required=false)]
                public bool? Transfer { get; set; }

            }

            [NameInMap("transfer_title")]
            [Validation(Required=false)]
            public string TransferTitle { get; set; }

        }

        /// <summary>
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>A5009956-1077-52FB-B520-EA8C7E91D722</para>
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
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>2136019116915615924561621e06ee</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
