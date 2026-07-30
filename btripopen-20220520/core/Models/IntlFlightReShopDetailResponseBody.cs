// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightReShopDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public IntlFlightReShopDetailResponseBodyModule Module { get; set; }
        public class IntlFlightReShopDetailResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The baggage allowance information.</para>
            /// </summary>
            [NameInMap("baggage_rule")]
            [Validation(Required=false)]
            public IntlFlightReShopDetailResponseBodyModuleBaggageRule BaggageRule { get; set; }
            public class IntlFlightReShopDetailResponseBodyModuleBaggageRule : TeaModel {
                /// <summary>
                /// <para>The baggage rule description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>以航司规定为准</para>
                /// </summary>
                [NameInMap("baggage_rule_desc")]
                [Validation(Required=false)]
                public string BaggageRuleDesc { get; set; }

            }

            /// <summary>
            /// <para>The order close reason.</para>
            /// 
            /// <b>Example:</b>
            /// <para>卖家拒绝，改签单已关闭</para>
            /// </summary>
            [NameInMap("close_reason")]
            [Validation(Required=false)]
            public string CloseReason { get; set; }

            /// <summary>
            /// <para>The order close time, in the format of yyyy-MM-dd HH:mm:ss. This field has a value only after the order is closed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-03-06 15:00:35</para>
            /// </summary>
            [NameInMap("close_time")]
            [Validation(Required=false)]
            public string CloseTime { get; set; }

            /// <summary>
            /// <para>The close type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: Canceled by user.</description></item>
            /// <item><description>2: Closed by system.</description></item>
            /// <item><description>3: Closed by seller.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("close_type")]
            [Validation(Required=false)]
            public int? CloseType { get; set; }

            /// <summary>
            /// <para>The journey information after rebooking.</para>
            /// <remarks>
            /// <para>Notice: This field has a value after the rebooking plan is confirmed.</notice></para>
            /// </remarks>
            /// </summary>
            [NameInMap("journey_list")]
            [Validation(Required=false)]
            public List<IntlFlightReShopDetailResponseBodyModuleJourneyList> JourneyList { get; set; }
            public class IntlFlightReShopDetailResponseBodyModuleJourneyList : TeaModel {
                /// <summary>
                /// <para>The three-letter code of the arrival city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HKG</para>
                /// </summary>
                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                /// <summary>
                /// <para>The arrival city name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>中国香港</para>
                /// </summary>
                [NameInMap("arr_city_name")]
                [Validation(Required=false)]
                public string ArrCityName { get; set; }

                /// <summary>
                /// <para>The arrival time, in the format of yyyy-MM-dd HH:mm.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-01-01 02:00</para>
                /// </summary>
                [NameInMap("arr_time")]
                [Validation(Required=false)]
                public string ArrTime { get; set; }

                /// <summary>
                /// <para>The three-letter code of the departure city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BJS</para>
                /// </summary>
                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                /// <summary>
                /// <para>The departure city name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>北京</para>
                /// </summary>
                [NameInMap("dep_city_name")]
                [Validation(Required=false)]
                public string DepCityName { get; set; }

                /// <summary>
                /// <para>The departure time, in the format of yyyy-MM-dd HH:mm.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-01-01 01:00</para>
                /// </summary>
                [NameInMap("dep_time")]
                [Validation(Required=false)]
                public string DepTime { get; set; }

                /// <summary>
                /// <para>The total duration, in minutes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                /// <summary>
                /// <para>The flight segment information.</para>
                /// </summary>
                [NameInMap("flight_segment_infos")]
                [Validation(Required=false)]
                public List<IntlFlightReShopDetailResponseBodyModuleJourneyListFlightSegmentInfos> FlightSegmentInfos { get; set; }
                public class IntlFlightReShopDetailResponseBodyModuleJourneyListFlightSegmentInfos : TeaModel {
                    /// <summary>
                    /// <para>The marketing airline information.</para>
                    /// </summary>
                    [NameInMap("airline_info")]
                    [Validation(Required=false)]
                    public IntlFlightReShopDetailResponseBodyModuleJourneyListFlightSegmentInfosAirlineInfo AirlineInfo { get; set; }
                    public class IntlFlightReShopDetailResponseBodyModuleJourneyListFlightSegmentInfosAirlineInfo : TeaModel {
                        /// <summary>
                        /// <para>The airline code.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>NS</para>
                        /// </summary>
                        [NameInMap("airline_code")]
                        [Validation(Required=false)]
                        public string AirlineCode { get; set; }

                        /// <summary>
                        /// <para>The airline name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>河北航空</para>
                        /// </summary>
                        [NameInMap("airline_name")]
                        [Validation(Required=false)]
                        public string AirlineName { get; set; }

                        /// <summary>
                        /// <para>The airline short name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>河北航空</para>
                        /// </summary>
                        [NameInMap("short_name")]
                        [Validation(Required=false)]
                        public string ShortName { get; set; }

                    }

                    /// <summary>
                    /// <para>The arrival airport information.</para>
                    /// </summary>
                    [NameInMap("arr_airport_info")]
                    [Validation(Required=false)]
                    public IntlFlightReShopDetailResponseBodyModuleJourneyListFlightSegmentInfosArrAirportInfo ArrAirportInfo { get; set; }
                    public class IntlFlightReShopDetailResponseBodyModuleJourneyListFlightSegmentInfosArrAirportInfo : TeaModel {
                        /// <summary>
                        /// <para>The airport code.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>DLC</para>
                        /// </summary>
                        [NameInMap("airport_code")]
                        [Validation(Required=false)]
                        public string AirportCode { get; set; }

                        /// <summary>
                        /// <para>The airport name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>大连周水子国际机场</para>
                        /// </summary>
                        [NameInMap("airport_name")]
                        [Validation(Required=false)]
                        public string AirportName { get; set; }

                        /// <summary>
                        /// <para>The airport short name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>大连机场</para>
                        /// </summary>
                        [NameInMap("airport_short_name")]
                        [Validation(Required=false)]
                        public string AirportShortName { get; set; }

                        /// <summary>
                        /// <para>The terminal.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>T1</para>
                        /// </summary>
                        [NameInMap("terminal")]
                        [Validation(Required=false)]
                        public string Terminal { get; set; }

                    }

                    /// <summary>
                    /// <para>The three-letter code of the arrival city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HKG</para>
                    /// </summary>
                    [NameInMap("arr_city_code")]
                    [Validation(Required=false)]
                    public string ArrCityCode { get; set; }

                    /// <summary>
                    /// <para>The arrival city name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>中国香港</para>
                    /// </summary>
                    [NameInMap("arr_city_name")]
                    [Validation(Required=false)]
                    public string ArrCityName { get; set; }

                    /// <summary>
                    /// <para>The arrival time, in the format of yyyy-MM-dd HH:mm.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2025-01-01 02:00</para>
                    /// </summary>
                    [NameInMap("arr_time")]
                    [Validation(Required=false)]
                    public string ArrTime { get; set; }

                    /// <summary>
                    /// <para>The departure airport information.</para>
                    /// </summary>
                    [NameInMap("dep_airport_info")]
                    [Validation(Required=false)]
                    public IntlFlightReShopDetailResponseBodyModuleJourneyListFlightSegmentInfosDepAirportInfo DepAirportInfo { get; set; }
                    public class IntlFlightReShopDetailResponseBodyModuleJourneyListFlightSegmentInfosDepAirportInfo : TeaModel {
                        /// <summary>
                        /// <para>The airport code.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>PEK</para>
                        /// </summary>
                        [NameInMap("airport_code")]
                        [Validation(Required=false)]
                        public string AirportCode { get; set; }

                        /// <summary>
                        /// <para>The airport name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>首都国际机场</para>
                        /// </summary>
                        [NameInMap("airport_name")]
                        [Validation(Required=false)]
                        public string AirportName { get; set; }

                        /// <summary>
                        /// <para>The airport short name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>首都</para>
                        /// </summary>
                        [NameInMap("airport_short_name")]
                        [Validation(Required=false)]
                        public string AirportShortName { get; set; }

                        /// <summary>
                        /// <para>The terminal.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>T1</para>
                        /// </summary>
                        [NameInMap("terminal")]
                        [Validation(Required=false)]
                        public string Terminal { get; set; }

                    }

                    /// <summary>
                    /// <para>The three-letter code of the departure city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>BJS</para>
                    /// </summary>
                    [NameInMap("dep_city_code")]
                    [Validation(Required=false)]
                    public string DepCityCode { get; set; }

                    /// <summary>
                    /// <para>The departure city name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>北京</para>
                    /// </summary>
                    [NameInMap("dep_city_name")]
                    [Validation(Required=false)]
                    public string DepCityName { get; set; }

                    /// <summary>
                    /// <para>The departure time, in the format of yyyy-MM-dd HH:mm.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2025-01-01 01:00</para>
                    /// </summary>
                    [NameInMap("dep_time")]
                    [Validation(Required=false)]
                    public string DepTime { get; set; }

                    /// <summary>
                    /// <para>The total duration of the flight segment in minutes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>130</para>
                    /// </summary>
                    [NameInMap("duration")]
                    [Validation(Required=false)]
                    public int? Duration { get; set; }

                    /// <summary>
                    /// <para>The flight number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>NS8210</para>
                    /// </summary>
                    [NameInMap("flight_no")]
                    [Validation(Required=false)]
                    public string FlightNo { get; set; }

                    /// <summary>
                    /// <para>The codeshare flight information.</para>
                    /// </summary>
                    [NameInMap("flight_share_info")]
                    [Validation(Required=false)]
                    public IntlFlightReShopDetailResponseBodyModuleJourneyListFlightSegmentInfosFlightShareInfo FlightShareInfo { get; set; }
                    public class IntlFlightReShopDetailResponseBodyModuleJourneyListFlightSegmentInfosFlightShareInfo : TeaModel {
                        /// <summary>
                        /// <para>The operating airline information.</para>
                        /// </summary>
                        [NameInMap("operating_airline_info")]
                        [Validation(Required=false)]
                        public IntlFlightReShopDetailResponseBodyModuleJourneyListFlightSegmentInfosFlightShareInfoOperatingAirlineInfo OperatingAirlineInfo { get; set; }
                        public class IntlFlightReShopDetailResponseBodyModuleJourneyListFlightSegmentInfosFlightShareInfoOperatingAirlineInfo : TeaModel {
                            /// <summary>
                            /// <para>The airline code.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>CA</para>
                            /// </summary>
                            [NameInMap("airline_code")]
                            [Validation(Required=false)]
                            public string AirlineCode { get; set; }

                            /// <summary>
                            /// <para>The airline name.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>中国国际航空</para>
                            /// </summary>
                            [NameInMap("airline_name")]
                            [Validation(Required=false)]
                            public string AirlineName { get; set; }

                            /// <summary>
                            /// <para>The airline short name.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>中国国航</para>
                            /// </summary>
                            [NameInMap("short_name")]
                            [Validation(Required=false)]
                            public string ShortName { get; set; }

                        }

                        /// <summary>
                        /// <para>The operating flight number. This field has a value only for codeshare flights.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CA1234</para>
                        /// </summary>
                        [NameInMap("operating_flight_no")]
                        [Validation(Required=false)]
                        public string OperatingFlightNo { get; set; }

                    }

                    /// <summary>
                    /// <para>The aircraft size name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>中型机</para>
                    /// </summary>
                    [NameInMap("flight_size")]
                    [Validation(Required=false)]
                    public string FlightSize { get; set; }

                    /// <summary>
                    /// <para>The flight stopover list.</para>
                    /// </summary>
                    [NameInMap("flight_stop_info_list")]
                    [Validation(Required=false)]
                    public List<IntlFlightReShopDetailResponseBodyModuleJourneyListFlightSegmentInfosFlightStopInfoList> FlightStopInfoList { get; set; }
                    public class IntlFlightReShopDetailResponseBodyModuleJourneyListFlightSegmentInfosFlightStopInfoList : TeaModel {
                        /// <summary>
                        /// <para>The stopover airport.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>PEK</para>
                        /// </summary>
                        [NameInMap("stop_airport")]
                        [Validation(Required=false)]
                        public string StopAirport { get; set; }

                        /// <summary>
                        /// <para>The name of the stopover airport.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>北京首都机场</para>
                        /// </summary>
                        [NameInMap("stop_airport_name")]
                        [Validation(Required=false)]
                        public string StopAirportName { get; set; }

                        /// <summary>
                        /// <para>The arrival terminal at the stopover.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>T3</para>
                        /// </summary>
                        [NameInMap("stop_arr_term")]
                        [Validation(Required=false)]
                        public string StopArrTerm { get; set; }

                        /// <summary>
                        /// <para>The arrival time at the stopover, in the format of yyyy-MM-dd HH:mm.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2024-01-01 05:00</para>
                        /// </summary>
                        [NameInMap("stop_arr_time")]
                        [Validation(Required=false)]
                        public string StopArrTime { get; set; }

                        /// <summary>
                        /// <para>The three-letter code of the stopover city.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>BJS</para>
                        /// </summary>
                        [NameInMap("stop_city_code")]
                        [Validation(Required=false)]
                        public string StopCityCode { get; set; }

                        /// <summary>
                        /// <para>The name of the stopover city.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>北京</para>
                        /// </summary>
                        [NameInMap("stop_city_name")]
                        [Validation(Required=false)]
                        public string StopCityName { get; set; }

                        /// <summary>
                        /// <para>The departure terminal at the stopover.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>T2</para>
                        /// </summary>
                        [NameInMap("stop_dep_term")]
                        [Validation(Required=false)]
                        public string StopDepTerm { get; set; }

                        /// <summary>
                        /// <para>The departure time from the stopover, in the format of yyyy-MM-dd HH:mm.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2024-01-01 07:00</para>
                        /// </summary>
                        [NameInMap("stop_dep_time")]
                        [Validation(Required=false)]
                        public string StopDepTime { get; set; }

                        /// <summary>
                        /// <para>The stopover duration, in minutes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>120</para>
                        /// </summary>
                        [NameInMap("stop_time")]
                        [Validation(Required=false)]
                        public string StopTime { get; set; }

                    }

                    /// <summary>
                    /// <para>The aircraft type code, such as 738.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>737</para>
                    /// </summary>
                    [NameInMap("flight_type")]
                    [Validation(Required=false)]
                    public string FlightType { get; set; }

                    /// <summary>
                    /// <para>The journey index.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("journey_index")]
                    [Validation(Required=false)]
                    public int? JourneyIndex { get; set; }

                    /// <summary>
                    /// <para>Indicates whether luggage is through-checked for the current segment.</para>
                    /// </summary>
                    [NameInMap("luggage_direct_info")]
                    [Validation(Required=false)]
                    public IntlFlightReShopDetailResponseBodyModuleJourneyListFlightSegmentInfosLuggageDirectInfo LuggageDirectInfo { get; set; }
                    public class IntlFlightReShopDetailResponseBodyModuleJourneyListFlightSegmentInfosLuggageDirectInfo : TeaModel {
                        /// <summary>
                        /// <para>Indicates whether luggage is through-checked. Valid values: 0 (re-check required), 1 (through-checked), null (unknown).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("dep_city_luggage_direct")]
                        [Validation(Required=false)]
                        public int? DepCityLuggageDirect { get; set; }

                        /// <summary>
                        /// <para>Indicates whether luggage is through-checked. Valid values: 0 (re-check required), 1 (through-checked), null (unknown).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("stop_city_luggage_direct")]
                        [Validation(Required=false)]
                        public int? StopCityLuggageDirect { get; set; }

                    }

                    /// <summary>
                    /// <para>The manufacturer.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>波音</para>
                    /// </summary>
                    [NameInMap("manufacturer")]
                    [Validation(Required=false)]
                    public string Manufacturer { get; set; }

                    /// <summary>
                    /// <para>The meal description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>正餐</para>
                    /// </summary>
                    [NameInMap("meal_desc")]
                    [Validation(Required=false)]
                    public string MealDesc { get; set; }

                    /// <summary>
                    /// <para>The number of days crossed. For example, 1 means the flight crosses 1 day.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("one_more")]
                    [Validation(Required=false)]
                    public int? OneMore { get; set; }

                    /// <summary>
                    /// <para>The day-crossing display text.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <list type="bullet">
                    /// <item><description></description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("one_more_show")]
                    [Validation(Required=false)]
                    public string OneMoreShow { get; set; }

                    /// <summary>
                    /// <para>The segment index, starting from 0 within the same journey.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("segment_index")]
                    [Validation(Required=false)]
                    public int? SegmentIndex { get; set; }

                    /// <summary>
                    /// <para>The unique key of the segment, in the format of flight number + departure airport + arrival airport + departure date (MMdd).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>NS8210XIYHGH0501</para>
                    /// </summary>
                    [NameInMap("segment_key")]
                    [Validation(Required=false)]
                    public string SegmentKey { get; set; }

                    /// <summary>
                    /// <para>The transit visa information for the current segment.</para>
                    /// </summary>
                    [NameInMap("segment_visa_remark")]
                    [Validation(Required=false)]
                    public IntlFlightReShopDetailResponseBodyModuleJourneyListFlightSegmentInfosSegmentVisaRemark SegmentVisaRemark { get; set; }
                    public class IntlFlightReShopDetailResponseBodyModuleJourneyListFlightSegmentInfosSegmentVisaRemark : TeaModel {
                        /// <summary>
                        /// <para>The transit visa information for the departure city.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>首尔--签证提示:中国大陆籍旅客需持有护照及中转国签证，请确认证件无误后再购票。</para>
                        /// </summary>
                        [NameInMap("dep_city_visa_remark")]
                        [Validation(Required=false)]
                        public string DepCityVisaRemark { get; set; }

                        /// <summary>
                        /// <para>The transit visa type for the departure city. Valid values: NO_TRANSIT_VISA(0, &quot;No transit visa required&quot;), NEED_TRANSIT_VISA(1, &quot;Transit visa required&quot;).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("dep_city_visa_type")]
                        [Validation(Required=false)]
                        public int? DepCityVisaType { get; set; }

                        /// <summary>
                        /// <para>The transit visa information for stopover cities. One entry corresponds to each stopover city.</para>
                        /// </summary>
                        [NameInMap("stop_city_visa_remarks")]
                        [Validation(Required=false)]
                        public List<string> StopCityVisaRemarks { get; set; }

                        /// <summary>
                        /// <para>The transit visa types for stopover cities. One entry corresponds to each stopover city.</para>
                        /// </summary>
                        [NameInMap("stop_city_visa_types")]
                        [Validation(Required=false)]
                        public List<int?> StopCityVisaTypes { get; set; }

                    }

                    /// <summary>
                    /// <para>Indicates whether this is a codeshare flight.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("share")]
                    [Validation(Required=false)]
                    public bool? Share { get; set; }

                    /// <summary>
                    /// <para>The aircraft size abbreviation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>中</para>
                    /// </summary>
                    [NameInMap("short_flight_size")]
                    [Validation(Required=false)]
                    public string ShortFlightSize { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the flight has a stopover.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("stop")]
                    [Validation(Required=false)]
                    public bool? Stop { get; set; }

                    /// <summary>
                    /// <para>The total duration of the flight segment.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2小时10分</para>
                    /// </summary>
                    [NameInMap("total_time")]
                    [Validation(Required=false)]
                    public string TotalTime { get; set; }

                }

                /// <summary>
                /// <para>The journey index, starting from 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("journey_index")]
                [Validation(Required=false)]
                public int? JourneyIndex { get; set; }

                /// <summary>
                /// <para>The transfer duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("transfer_time")]
                [Validation(Required=false)]
                public int? TransferTime { get; set; }

            }

            /// <summary>
            /// <para>The business travel order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1017124195788186048</para>
            /// </summary>
            [NameInMap("order_id")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

            /// <summary>
            /// <para>The original journey information before the change.</para>
            /// </summary>
            [NameInMap("origin_journey_list")]
            [Validation(Required=false)]
            public List<IntlFlightReShopDetailResponseBodyModuleOriginJourneyList> OriginJourneyList { get; set; }
            public class IntlFlightReShopDetailResponseBodyModuleOriginJourneyList : TeaModel {
                /// <summary>
                /// <para>The three-letter code of the arrival city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HKG</para>
                /// </summary>
                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                /// <summary>
                /// <para>The arrival city name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>香港</para>
                /// </summary>
                [NameInMap("arr_city_name")]
                [Validation(Required=false)]
                public string ArrCityName { get; set; }

                /// <summary>
                /// <para>The arrival time, in the format of yyyy-MM-dd HH:mm.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-01-01 02:00</para>
                /// </summary>
                [NameInMap("arr_time")]
                [Validation(Required=false)]
                public string ArrTime { get; set; }

                /// <summary>
                /// <para>The three-letter code of the departure city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BJS</para>
                /// </summary>
                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                /// <summary>
                /// <para>The departure city name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>北京</para>
                /// </summary>
                [NameInMap("dep_city_name")]
                [Validation(Required=false)]
                public string DepCityName { get; set; }

                /// <summary>
                /// <para>The departure time, in the format of yyyy-MM-dd HH:mm.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-01-01 01:00</para>
                /// </summary>
                [NameInMap("dep_time")]
                [Validation(Required=false)]
                public string DepTime { get; set; }

                /// <summary>
                /// <para>The total duration, in minutes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                /// <summary>
                /// <para>The flight segment information.</para>
                /// </summary>
                [NameInMap("flight_segment_infos")]
                [Validation(Required=false)]
                public List<IntlFlightReShopDetailResponseBodyModuleOriginJourneyListFlightSegmentInfos> FlightSegmentInfos { get; set; }
                public class IntlFlightReShopDetailResponseBodyModuleOriginJourneyListFlightSegmentInfos : TeaModel {
                    /// <summary>
                    /// <para>The marketing airline information.</para>
                    /// </summary>
                    [NameInMap("airline_info")]
                    [Validation(Required=false)]
                    public IntlFlightReShopDetailResponseBodyModuleOriginJourneyListFlightSegmentInfosAirlineInfo AirlineInfo { get; set; }
                    public class IntlFlightReShopDetailResponseBodyModuleOriginJourneyListFlightSegmentInfosAirlineInfo : TeaModel {
                        /// <summary>
                        /// <para>The airline code.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CA</para>
                        /// </summary>
                        [NameInMap("airline_code")]
                        [Validation(Required=false)]
                        public string AirlineCode { get; set; }

                        /// <summary>
                        /// <para>The airline name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>中国国际航空</para>
                        /// </summary>
                        [NameInMap("airline_name")]
                        [Validation(Required=false)]
                        public string AirlineName { get; set; }

                        /// <summary>
                        /// <para>The airline short name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>国航</para>
                        /// </summary>
                        [NameInMap("short_name")]
                        [Validation(Required=false)]
                        public string ShortName { get; set; }

                    }

                    /// <summary>
                    /// <para>The arrival airport information.</para>
                    /// </summary>
                    [NameInMap("arr_airport_info")]
                    [Validation(Required=false)]
                    public IntlFlightReShopDetailResponseBodyModuleOriginJourneyListFlightSegmentInfosArrAirportInfo ArrAirportInfo { get; set; }
                    public class IntlFlightReShopDetailResponseBodyModuleOriginJourneyListFlightSegmentInfosArrAirportInfo : TeaModel {
                        /// <summary>
                        /// <para>The airport code.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>HKG</para>
                        /// </summary>
                        [NameInMap("airport_code")]
                        [Validation(Required=false)]
                        public string AirportCode { get; set; }

                        /// <summary>
                        /// <para>The airport name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>香港国际机场</para>
                        /// </summary>
                        [NameInMap("airport_name")]
                        [Validation(Required=false)]
                        public string AirportName { get; set; }

                        /// <summary>
                        /// <para>The airport short name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>香港</para>
                        /// </summary>
                        [NameInMap("airport_short_name")]
                        [Validation(Required=false)]
                        public string AirportShortName { get; set; }

                        /// <summary>
                        /// <para>The terminal.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>T3</para>
                        /// </summary>
                        [NameInMap("terminal")]
                        [Validation(Required=false)]
                        public string Terminal { get; set; }

                    }

                    /// <summary>
                    /// <para>The three-letter code of the arrival city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HKG</para>
                    /// </summary>
                    [NameInMap("arr_city_code")]
                    [Validation(Required=false)]
                    public string ArrCityCode { get; set; }

                    /// <summary>
                    /// <para>The arrival city name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>香港</para>
                    /// </summary>
                    [NameInMap("arr_city_name")]
                    [Validation(Required=false)]
                    public string ArrCityName { get; set; }

                    /// <summary>
                    /// <para>The arrival time, in the format of yyyy-MM-dd HH:mm.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2023-08-13 09:25</para>
                    /// </summary>
                    [NameInMap("arr_time")]
                    [Validation(Required=false)]
                    public string ArrTime { get; set; }

                    /// <summary>
                    /// <para>The departure airport information.</para>
                    /// </summary>
                    [NameInMap("dep_airport_info")]
                    [Validation(Required=false)]
                    public IntlFlightReShopDetailResponseBodyModuleOriginJourneyListFlightSegmentInfosDepAirportInfo DepAirportInfo { get; set; }
                    public class IntlFlightReShopDetailResponseBodyModuleOriginJourneyListFlightSegmentInfosDepAirportInfo : TeaModel {
                        /// <summary>
                        /// <para>The airport code.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>PEK</para>
                        /// </summary>
                        [NameInMap("airport_code")]
                        [Validation(Required=false)]
                        public string AirportCode { get; set; }

                        /// <summary>
                        /// <para>The airport name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>首都国际机场</para>
                        /// </summary>
                        [NameInMap("airport_name")]
                        [Validation(Required=false)]
                        public string AirportName { get; set; }

                        /// <summary>
                        /// <para>The airport short name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>首都</para>
                        /// </summary>
                        [NameInMap("airport_short_name")]
                        [Validation(Required=false)]
                        public string AirportShortName { get; set; }

                        /// <summary>
                        /// <para>The terminal.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>T1</para>
                        /// </summary>
                        [NameInMap("terminal")]
                        [Validation(Required=false)]
                        public string Terminal { get; set; }

                    }

                    /// <summary>
                    /// <para>The three-letter code of the departure city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>BJS</para>
                    /// </summary>
                    [NameInMap("dep_city_code")]
                    [Validation(Required=false)]
                    public string DepCityCode { get; set; }

                    /// <summary>
                    /// <para>The departure city name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>北京</para>
                    /// </summary>
                    [NameInMap("dep_city_name")]
                    [Validation(Required=false)]
                    public string DepCityName { get; set; }

                    /// <summary>
                    /// <para>The departure time, in the format of yyyy-MM-dd HH:mm.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2023-08-13 07:25</para>
                    /// </summary>
                    [NameInMap("dep_time")]
                    [Validation(Required=false)]
                    public string DepTime { get; set; }

                    /// <summary>
                    /// <para>The total duration of the flight segment in minutes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>120</para>
                    /// </summary>
                    [NameInMap("duration")]
                    [Validation(Required=false)]
                    public int? Duration { get; set; }

                    /// <summary>
                    /// <para>The flight number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>NS8210</para>
                    /// </summary>
                    [NameInMap("flight_no")]
                    [Validation(Required=false)]
                    public string FlightNo { get; set; }

                    /// <summary>
                    /// <para>The codeshare flight information.</para>
                    /// </summary>
                    [NameInMap("flight_share_info")]
                    [Validation(Required=false)]
                    public IntlFlightReShopDetailResponseBodyModuleOriginJourneyListFlightSegmentInfosFlightShareInfo FlightShareInfo { get; set; }
                    public class IntlFlightReShopDetailResponseBodyModuleOriginJourneyListFlightSegmentInfosFlightShareInfo : TeaModel {
                        /// <summary>
                        /// <para>The operating airline information.</para>
                        /// </summary>
                        [NameInMap("operating_airline_info")]
                        [Validation(Required=false)]
                        public IntlFlightReShopDetailResponseBodyModuleOriginJourneyListFlightSegmentInfosFlightShareInfoOperatingAirlineInfo OperatingAirlineInfo { get; set; }
                        public class IntlFlightReShopDetailResponseBodyModuleOriginJourneyListFlightSegmentInfosFlightShareInfoOperatingAirlineInfo : TeaModel {
                            /// <summary>
                            /// <para>The airline code.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>MU</para>
                            /// </summary>
                            [NameInMap("airline_code")]
                            [Validation(Required=false)]
                            public string AirlineCode { get; set; }

                            /// <summary>
                            /// <para>The airline name.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>中国东方航空</para>
                            /// </summary>
                            [NameInMap("airline_name")]
                            [Validation(Required=false)]
                            public string AirlineName { get; set; }

                            /// <summary>
                            /// <para>The airline short name.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>东航</para>
                            /// </summary>
                            [NameInMap("short_name")]
                            [Validation(Required=false)]
                            public string ShortName { get; set; }

                        }

                        /// <summary>
                        /// <para>The operating flight number. This field has a value only for codeshare flights.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CA0001</para>
                        /// </summary>
                        [NameInMap("operating_flight_no")]
                        [Validation(Required=false)]
                        public string OperatingFlightNo { get; set; }

                    }

                    /// <summary>
                    /// <para>The aircraft size name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>中型机</para>
                    /// </summary>
                    [NameInMap("flight_size")]
                    [Validation(Required=false)]
                    public string FlightSize { get; set; }

                    /// <summary>
                    /// <para>The flight stopover list.</para>
                    /// </summary>
                    [NameInMap("flight_stop_info_list")]
                    [Validation(Required=false)]
                    public List<IntlFlightReShopDetailResponseBodyModuleOriginJourneyListFlightSegmentInfosFlightStopInfoList> FlightStopInfoList { get; set; }
                    public class IntlFlightReShopDetailResponseBodyModuleOriginJourneyListFlightSegmentInfosFlightStopInfoList : TeaModel {
                        /// <summary>
                        /// <para>The stopover airport.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>HGH</para>
                        /// </summary>
                        [NameInMap("stop_airport")]
                        [Validation(Required=false)]
                        public string StopAirport { get; set; }

                        /// <summary>
                        /// <para>The name of the stopover airport.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>萧山国际机场</para>
                        /// </summary>
                        [NameInMap("stop_airport_name")]
                        [Validation(Required=false)]
                        public string StopAirportName { get; set; }

                        /// <summary>
                        /// <para>The arrival terminal at the stopover.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>T1</para>
                        /// </summary>
                        [NameInMap("stop_arr_term")]
                        [Validation(Required=false)]
                        public string StopArrTerm { get; set; }

                        /// <summary>
                        /// <para>The arrival time at the stopover, in the format of yyyy-MM-dd HH:mm.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2023-08-13 07:25</para>
                        /// </summary>
                        [NameInMap("stop_arr_time")]
                        [Validation(Required=false)]
                        public string StopArrTime { get; set; }

                        /// <summary>
                        /// <para>The three-letter code of the stopover city.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>HGH</para>
                        /// </summary>
                        [NameInMap("stop_city_code")]
                        [Validation(Required=false)]
                        public string StopCityCode { get; set; }

                        /// <summary>
                        /// <para>The name of the stopover city.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>杭州</para>
                        /// </summary>
                        [NameInMap("stop_city_name")]
                        [Validation(Required=false)]
                        public string StopCityName { get; set; }

                        /// <summary>
                        /// <para>The departure terminal at the stopover.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>T1</para>
                        /// </summary>
                        [NameInMap("stop_dep_term")]
                        [Validation(Required=false)]
                        public string StopDepTerm { get; set; }

                        /// <summary>
                        /// <para>The departure time from the stopover, in the format of yyyy-MM-dd HH:mm.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2023-08-13 09:25</para>
                        /// </summary>
                        [NameInMap("stop_dep_time")]
                        [Validation(Required=false)]
                        public string StopDepTime { get; set; }

                        /// <summary>
                        /// <para>The stopover duration, in minutes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>20</para>
                        /// </summary>
                        [NameInMap("stop_time")]
                        [Validation(Required=false)]
                        public string StopTime { get; set; }

                    }

                    /// <summary>
                    /// <para>The aircraft type code, such as 738.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>738</para>
                    /// </summary>
                    [NameInMap("flight_type")]
                    [Validation(Required=false)]
                    public string FlightType { get; set; }

                    /// <summary>
                    /// <para>The journey index.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("journey_index")]
                    [Validation(Required=false)]
                    public int? JourneyIndex { get; set; }

                    /// <summary>
                    /// <para>Indicates whether luggage is through-checked for the current segment.</para>
                    /// </summary>
                    [NameInMap("luggage_direct_info")]
                    [Validation(Required=false)]
                    public IntlFlightReShopDetailResponseBodyModuleOriginJourneyListFlightSegmentInfosLuggageDirectInfo LuggageDirectInfo { get; set; }
                    public class IntlFlightReShopDetailResponseBodyModuleOriginJourneyListFlightSegmentInfosLuggageDirectInfo : TeaModel {
                        /// <summary>
                        /// <para>Indicates whether luggage is through-checked. Valid values: 0 (re-check required), 1 (through-checked), null (unknown).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("dep_city_luggage_direct")]
                        [Validation(Required=false)]
                        public int? DepCityLuggageDirect { get; set; }

                        /// <summary>
                        /// <para>Indicates whether luggage is through-checked. Valid values: 0 (re-check required), 1 (through-checked), null (unknown).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("stop_city_luggage_direct")]
                        [Validation(Required=false)]
                        public int? StopCityLuggageDirect { get; set; }

                    }

                    /// <summary>
                    /// <para>The manufacturer.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>波音</para>
                    /// </summary>
                    [NameInMap("manufacturer")]
                    [Validation(Required=false)]
                    public string Manufacturer { get; set; }

                    /// <summary>
                    /// <para>The meal description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>无餐食</para>
                    /// </summary>
                    [NameInMap("meal_desc")]
                    [Validation(Required=false)]
                    public string MealDesc { get; set; }

                    /// <summary>
                    /// <para>The number of days crossed. For example, 1 means the flight crosses 1 day.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("one_more")]
                    [Validation(Required=false)]
                    public int? OneMore { get; set; }

                    /// <summary>
                    /// <para>The day-crossing display text.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>+1天</para>
                    /// </summary>
                    [NameInMap("one_more_show")]
                    [Validation(Required=false)]
                    public string OneMoreShow { get; set; }

                    /// <summary>
                    /// <para>The segment index, starting from 0 within the same journey.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("segment_index")]
                    [Validation(Required=false)]
                    public int? SegmentIndex { get; set; }

                    /// <summary>
                    /// <para>The unique key of the segment, in the format of flight number + departure airport + arrival airport + departure date (MMdd).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>NS8210XIYHGH0501</para>
                    /// </summary>
                    [NameInMap("segment_key")]
                    [Validation(Required=false)]
                    public string SegmentKey { get; set; }

                    /// <summary>
                    /// <para>The transit visa information for the current segment.</para>
                    /// </summary>
                    [NameInMap("segment_visa_remark")]
                    [Validation(Required=false)]
                    public IntlFlightReShopDetailResponseBodyModuleOriginJourneyListFlightSegmentInfosSegmentVisaRemark SegmentVisaRemark { get; set; }
                    public class IntlFlightReShopDetailResponseBodyModuleOriginJourneyListFlightSegmentInfosSegmentVisaRemark : TeaModel {
                        /// <summary>
                        /// <para>The transit visa information for the departure city.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>首尔--签证提示:中国大陆籍旅客需持有护照及中转国签证，请确认证件无误后再购票。</para>
                        /// </summary>
                        [NameInMap("dep_city_visa_remark")]
                        [Validation(Required=false)]
                        public string DepCityVisaRemark { get; set; }

                        /// <summary>
                        /// <para>The transit visa type for the departure city. Valid values: NO_TRANSIT_VISA(0, &quot;No transit visa required&quot;), NEED_TRANSIT_VISA(1, &quot;Transit visa required&quot;).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("dep_city_visa_type")]
                        [Validation(Required=false)]
                        public int? DepCityVisaType { get; set; }

                        /// <summary>
                        /// <para>The transit visa information for stopover cities. One entry corresponds to each stopover city.</para>
                        /// </summary>
                        [NameInMap("stop_city_visa_remarks")]
                        [Validation(Required=false)]
                        public List<string> StopCityVisaRemarks { get; set; }

                        /// <summary>
                        /// <para>The transit visa types for stopover cities. One entry corresponds to each stopover city.</para>
                        /// </summary>
                        [NameInMap("stop_city_visa_types")]
                        [Validation(Required=false)]
                        public List<int?> StopCityVisaTypes { get; set; }

                    }

                    /// <summary>
                    /// <para>Indicates whether this is a codeshare flight.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("share")]
                    [Validation(Required=false)]
                    public bool? Share { get; set; }

                    /// <summary>
                    /// <para>The aircraft size abbreviation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>中</para>
                    /// </summary>
                    [NameInMap("short_flight_size")]
                    [Validation(Required=false)]
                    public string ShortFlightSize { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the flight has a stopover.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("stop")]
                    [Validation(Required=false)]
                    public bool? Stop { get; set; }

                    /// <summary>
                    /// <para>The total duration of the flight segment.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2小时</para>
                    /// </summary>
                    [NameInMap("total_time")]
                    [Validation(Required=false)]
                    public string TotalTime { get; set; }

                }

                /// <summary>
                /// <para>The journey index, starting from 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("journey_index")]
                [Validation(Required=false)]
                public int? JourneyIndex { get; set; }

                /// <summary>
                /// <para>The transfer duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("transfer_time")]
                [Validation(Required=false)]
                public int? TransferTime { get; set; }

            }

            /// <summary>
            /// <para>The external order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>F11552194294228713472</para>
            /// </summary>
            [NameInMap("out_order_id")]
            [Validation(Required=false)]
            public string OutOrderId { get; set; }

            /// <summary>
            /// <para>The external change application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>JPM20241024354</para>
            /// </summary>
            [NameInMap("out_re_shop_apply_id")]
            [Validation(Required=false)]
            public string OutReShopApplyId { get; set; }

            /// <summary>
            /// <para>The passenger list.</para>
            /// </summary>
            [NameInMap("passenger_list")]
            [Validation(Required=false)]
            public List<IntlFlightReShopDetailResponseBodyModulePassengerList> PassengerList { get; set; }
            public class IntlFlightReShopDetailResponseBodyModulePassengerList : TeaModel {
                /// <summary>
                /// <para>The passenger name. This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ZHANG/SAN</para>
                /// </summary>
                [NameInMap("full_name")]
                [Validation(Required=false)]
                public string FullName { get; set; }

                /// <summary>
                /// <para>The gender. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: male</description></item>
                /// <item><description>1: female</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("gender")]
                [Validation(Required=false)]
                public int? Gender { get; set; }

                /// <summary>
                /// <para>The employee ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>76230022</para>
                /// </summary>
                [NameInMap("job_no")]
                [Validation(Required=false)]
                public string JobNo { get; set; }

                /// <summary>
                /// <para>The nationality name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>中国大陆</para>
                /// </summary>
                [NameInMap("nationality")]
                [Validation(Required=false)]
                public string Nationality { get; set; }

                /// <summary>
                /// <para>The two-letter nationality code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CN</para>
                /// </summary>
                [NameInMap("nationality_code")]
                [Validation(Required=false)]
                public string NationalityCode { get; set; }

                /// <summary>
                /// <para>The passenger ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8432002</para>
                /// </summary>
                [NameInMap("passenger_id")]
                [Validation(Required=false)]
                public long? PassengerId { get; set; }

                /// <summary>
                /// <para>The passenger type. Valid values: ADT (0: adult), CHD (1: child).</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

                /// <summary>
                /// <para>The unique ID of the business travel user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>btrip8432002</para>
                /// </summary>
                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The employee type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: Internal employee.</description></item>
                /// <item><description>1: External employee.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("user_type")]
                [Validation(Required=false)]
                public int? UserType { get; set; }

            }

            /// <summary>
            /// <para>The list of passenger change price information.</para>
            /// <remarks>
            /// <para>This field has a value only after the change fee is confirmed.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("passenger_price_info_list")]
            [Validation(Required=false)]
            public List<IntlFlightReShopDetailResponseBodyModulePassengerPriceInfoList> PassengerPriceInfoList { get; set; }
            public class IntlFlightReShopDetailResponseBodyModulePassengerPriceInfoList : TeaModel {
                /// <summary>
                /// <para>The passenger ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100001</para>
                /// </summary>
                [NameInMap("passenger_id")]
                [Validation(Required=false)]
                public long? PassengerId { get; set; }

                /// <summary>
                /// <para>The price information.</para>
                /// </summary>
                [NameInMap("price_info")]
                [Validation(Required=false)]
                public IntlFlightReShopDetailResponseBodyModulePassengerPriceInfoListPriceInfo PriceInfo { get; set; }
                public class IntlFlightReShopDetailResponseBodyModulePassengerPriceInfoListPriceInfo : TeaModel {
                    /// <summary>
                    /// <para>The handling fee, in cents. -1 indicates the price is pending confirmation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4000</para>
                    /// </summary>
                    [NameInMap("handling_amount")]
                    [Validation(Required=false)]
                    public long? HandlingAmount { get; set; }

                    /// <summary>
                    /// <para>The tax difference amount, in cents. -1 indicates the price is pending confirmation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("tax_diff_amount")]
                    [Validation(Required=false)]
                    public long? TaxDiffAmount { get; set; }

                    /// <summary>
                    /// <para>The total amount, in cents. -1 indicates the price is pending confirmation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>125000</para>
                    /// </summary>
                    [NameInMap("total_amount")]
                    [Validation(Required=false)]
                    public long? TotalAmount { get; set; }

                    /// <summary>
                    /// <para>The cabin upgrade fee, in cents. -1 indicates the price is pending confirmation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2000</para>
                    /// </summary>
                    [NameInMap("upgrade_amount")]
                    [Validation(Required=false)]
                    public long? UpgradeAmount { get; set; }

                }

            }

            /// <summary>
            /// <para>The passenger ticket information. This field has a value only after the change ticket is issued.</para>
            /// </summary>
            [NameInMap("passenger_ticket_list")]
            [Validation(Required=false)]
            public List<IntlFlightReShopDetailResponseBodyModulePassengerTicketList> PassengerTicketList { get; set; }
            public class IntlFlightReShopDetailResponseBodyModulePassengerTicketList : TeaModel {
                /// <summary>
                /// <para>The passenger ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2345678</para>
                /// </summary>
                [NameInMap("passenger_id")]
                [Validation(Required=false)]
                public long? PassengerId { get; set; }

                /// <summary>
                /// <para>The passenger ticket list. This field has a value only after the order ticket is issued.</para>
                /// </summary>
                [NameInMap("ticket_list")]
                [Validation(Required=false)]
                public List<IntlFlightReShopDetailResponseBodyModulePassengerTicketListTicketList> TicketList { get; set; }
                public class IntlFlightReShopDetailResponseBodyModulePassengerTicketListTicketList : TeaModel {
                    /// <summary>
                    /// <para>The ticketing time, in the format of yyyy-MM-dd HH:mm:ss.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2025-01-01 00:00:09</para>
                    /// </summary>
                    [NameInMap("issue_time")]
                    [Validation(Required=false)]
                    public string IssueTime { get; set; }

                    /// <summary>
                    /// <para>The PNR encoding.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>P123456</para>
                    /// </summary>
                    [NameInMap("pnr_no")]
                    [Validation(Required=false)]
                    public string PnrNo { get; set; }

                    /// <summary>
                    /// <para>The list of ticket segment keys.</para>
                    /// </summary>
                    [NameInMap("segment_key_list")]
                    [Validation(Required=false)]
                    public List<string> SegmentKeyList { get; set; }

                    /// <summary>
                    /// <para>The ticket number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>781-9574833593</para>
                    /// </summary>
                    [NameInMap("ticket_no")]
                    [Validation(Required=false)]
                    public string TicketNo { get; set; }

                    /// <summary>
                    /// <para>The ticket segment information.</para>
                    /// </summary>
                    [NameInMap("ticket_segment_list")]
                    [Validation(Required=false)]
                    public List<IntlFlightReShopDetailResponseBodyModulePassengerTicketListTicketListTicketSegmentList> TicketSegmentList { get; set; }
                    public class IntlFlightReShopDetailResponseBodyModulePassengerTicketListTicketListTicketSegmentList : TeaModel {
                        /// <summary>
                        /// <para>The cabin code.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>G</para>
                        /// </summary>
                        [NameInMap("cabin")]
                        [Validation(Required=false)]
                        public string Cabin { get; set; }

                        /// <summary>
                        /// <para>The cabin class. Valid values: FIRST, BUSINESS, COMMON, PREMIUMECONOMY.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Y</para>
                        /// </summary>
                        [NameInMap("cabin_class")]
                        [Validation(Required=false)]
                        public string CabinClass { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the ticket segment is changed.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("modified")]
                        [Validation(Required=false)]
                        public bool? Modified { get; set; }

                        /// <summary>
                        /// <para>The ticket status. Valid values: OPEN, OPEN_FOR_USE, USED_FLOWN, REFUNDED, VOID, CHECKED_IN, EXCHANGED, FIM_EXCH, SUSPENDED, LIFT_BOARDED, UNAVAILABLE, PRINT, AIRPORT_CNT, CPN_NOTE, UNKNOWN.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>OPEN_FOR_USE</para>
                        /// </summary>
                        [NameInMap("open_ticket_status")]
                        [Validation(Required=false)]
                        public string OpenTicketStatus { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the ticket segment is refunded.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("refunded")]
                        [Validation(Required=false)]
                        public bool? Refunded { get; set; }

                        /// <summary>
                        /// <para>The unique key of the segment, in the format of flight number + departure airport + arrival airport + departure date (MMdd).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>HX236HKGPVG0509</para>
                        /// </summary>
                        [NameInMap("segment_key")]
                        [Validation(Required=false)]
                        public string SegmentKey { get; set; }

                    }

                }

            }

            /// <summary>
            /// <para>The payment deadline for the change order. The order is automatically closed if payment is not made before this time. Format: yyyy-MM-dd HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-03-06 15:35:00</para>
            /// </summary>
            [NameInMap("pay_latest_time")]
            [Validation(Required=false)]
            public string PayLatestTime { get; set; }

            /// <summary>
            /// <para>The payment status (0: initialized, 1: paid, 9: paying, 3: paid and closed, 4: unpaid and closed, 10: transaction successful (ticketing successful)). PayStatusEnum[INIT,PAID,PAYING,CLOSE,PAID_CLOSED,NO_PAY_CLOSED,TRANSFER_SUCCESS,code,name]</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("pay_status")]
            [Validation(Required=false)]
            public int? PayStatus { get; set; }

            /// <summary>
            /// <para>The change price information.</para>
            /// <remarks>
            /// <para>This field has a value only after the change fee is confirmed.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("price_info")]
            [Validation(Required=false)]
            public IntlFlightReShopDetailResponseBodyModulePriceInfo PriceInfo { get; set; }
            public class IntlFlightReShopDetailResponseBodyModulePriceInfo : TeaModel {
                /// <summary>
                /// <para>The handling fee, in cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4000</para>
                /// </summary>
                [NameInMap("handling_amount")]
                [Validation(Required=false)]
                public long? HandlingAmount { get; set; }

                /// <summary>
                /// <para>The tax difference amount, in cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("tax_diff_amount")]
                [Validation(Required=false)]
                public long? TaxDiffAmount { get; set; }

                /// <summary>
                /// <para>The total amount, in cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>125000</para>
                /// </summary>
                [NameInMap("total_amount")]
                [Validation(Required=false)]
                public long? TotalAmount { get; set; }

                /// <summary>
                /// <para>The cabin upgrade fee, in cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2000</para>
                /// </summary>
                [NameInMap("upgrade_amount")]
                [Validation(Required=false)]
                public long? UpgradeAmount { get; set; }

            }

            /// <summary>
            /// <para>The change application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1017035199374643191</para>
            /// </summary>
            [NameInMap("re_shop_apply_id")]
            [Validation(Required=false)]
            public long? ReShopApplyId { get; set; }

            /// <summary>
            /// <para>The reason code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("re_shop_reason_code")]
            [Validation(Required=false)]
            public string ReShopReasonCode { get; set; }

            /// <summary>
            /// <para>The reason details.</para>
            /// 
            /// <b>Example:</b>
            /// <para>因乘客自身原因需变更航班</para>
            /// </summary>
            [NameInMap("re_shop_reason_desc")]
            [Validation(Required=false)]
            public string ReShopReasonDesc { get; set; }

            /// <summary>
            /// <para>The refund and change rules.</para>
            /// </summary>
            [NameInMap("refund_change_rule")]
            [Validation(Required=false)]
            public IntlFlightReShopDetailResponseBodyModuleRefundChangeRule RefundChangeRule { get; set; }
            public class IntlFlightReShopDetailResponseBodyModuleRefundChangeRule : TeaModel {
                /// <summary>
                /// <para>The refund and change rule description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>以航司规定为准</para>
                /// </summary>
                [NameInMap("refund_change_rule_desc")]
                [Validation(Required=false)]
                public string RefundChangeRuleDesc { get; set; }

            }

            /// <summary>
            /// <para>The change order status (-1: invisible, 0: initial, 1: pending payment, 2: payment successful, 3: change successful, 4: change closed). ReShopApplyStatusEnum[NO_ENABLE,INIT,NO_PAY,PAY_SUCCESS,ORDER_SUCCESS,CLOSE,code,name]</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The ticketing success time, in the format of yyyy-MM-dd HH:mm:ss. This field has a value only after ticketing is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-03-06 15:01:35</para>
            /// </summary>
            [NameInMap("success_time")]
            [Validation(Required=false)]
            public string SuccessTime { get; set; }

            /// <summary>
            /// <para>The user-submitted change intention remarks, such as acceptable price range and preferred departure/arrival airports.</para>
            /// 
            /// <b>Example:</b>
            /// <para>少中转优先,落地当地时间为白天优先</para>
            /// </summary>
            [NameInMap("user_intention_memo")]
            [Validation(Required=false)]
            public string UserIntentionMemo { get; set; }

        }

        /// <summary>
        /// <para>The unique identity of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>407543AF-2BD9-5890-BD92-9D1AB7218B27</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The global identity for tracing the request, typically used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>210bc4b116835992457938931db4de</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
