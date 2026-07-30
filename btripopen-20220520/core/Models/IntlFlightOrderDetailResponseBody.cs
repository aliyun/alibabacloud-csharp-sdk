// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightOrderDetailResponseBody : TeaModel {
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
        /// <para>The response data. Returns null if no result is found or an exception occurs.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public IntlFlightOrderDetailResponseBodyModule Module { get; set; }
        public class IntlFlightOrderDetailResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The booker user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>jobno001</para>
            /// </summary>
            [NameInMap("booker_user_id")]
            [Validation(Required=false)]
            public string BookerUserId { get; set; }

            /// <summary>
            /// <para>The booker name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("booker_user_name")]
            [Validation(Required=false)]
            public string BookerUserName { get; set; }

            /// <summary>
            /// <para>The order close reason.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>Available only after the order is closed.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>订单关闭原因</para>
            /// </summary>
            [NameInMap("close_reason")]
            [Validation(Required=false)]
            public string CloseReason { get; set; }

            /// <summary>
            /// <para>The order close time. Format: yyyy-MM-dd HH:mm:ss.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>Available only after the order is closed.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2024-03-06 15:00:35</para>
            /// </summary>
            [NameInMap("close_time")]
            [Validation(Required=false)]
            public string CloseTime { get; set; }

            /// <summary>
            /// <para>The contact information.</para>
            /// </summary>
            [NameInMap("contact_info")]
            [Validation(Required=false)]
            public IntlFlightOrderDetailResponseBodyModuleContactInfo ContactInfo { get; set; }
            public class IntlFlightOrderDetailResponseBodyModuleContactInfo : TeaModel {
                /// <summary>
                /// <para>The contact name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>销售部测试二</para>
                /// </summary>
                [NameInMap("contact_name")]
                [Validation(Required=false)]
                public string ContactName { get; set; }

            }

            /// <summary>
            /// <para>The journey information.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>Returns an empty array when no data is available.</description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("journey_list")]
            [Validation(Required=false)]
            public List<IntlFlightOrderDetailResponseBodyModuleJourneyList> JourneyList { get; set; }
            public class IntlFlightOrderDetailResponseBodyModuleJourneyList : TeaModel {
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
                /// <para>The arrival city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>中国香港</para>
                /// </summary>
                [NameInMap("arr_city_name")]
                [Validation(Required=false)]
                public string ArrCityName { get; set; }

                /// <summary>
                /// <para>The arrival time. Format: yyyy-MM-dd HH:mm.</para>
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
                /// <para>SHA</para>
                /// </summary>
                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                /// <summary>
                /// <para>The departure city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>上海</para>
                /// </summary>
                [NameInMap("dep_city_name")]
                [Validation(Required=false)]
                public string DepCityName { get; set; }

                /// <summary>
                /// <para>The departure time. Format: yyyy-MM-dd HH:mm.</para>
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
                public List<IntlFlightOrderDetailResponseBodyModuleJourneyListFlightSegmentInfos> FlightSegmentInfos { get; set; }
                public class IntlFlightOrderDetailResponseBodyModuleJourneyListFlightSegmentInfos : TeaModel {
                    /// <summary>
                    /// <para>The marketing airline information.</para>
                    /// </summary>
                    [NameInMap("airline_info")]
                    [Validation(Required=false)]
                    public IntlFlightOrderDetailResponseBodyModuleJourneyListFlightSegmentInfosAirlineInfo AirlineInfo { get; set; }
                    public class IntlFlightOrderDetailResponseBodyModuleJourneyListFlightSegmentInfosAirlineInfo : TeaModel {
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
                    public IntlFlightOrderDetailResponseBodyModuleJourneyListFlightSegmentInfosArrAirportInfo ArrAirportInfo { get; set; }
                    public class IntlFlightOrderDetailResponseBodyModuleJourneyListFlightSegmentInfosArrAirportInfo : TeaModel {
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
                    /// <para>DLC</para>
                    /// </summary>
                    [NameInMap("arr_city_code")]
                    [Validation(Required=false)]
                    public string ArrCityCode { get; set; }

                    /// <summary>
                    /// <para>The arrival city name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>大连</para>
                    /// </summary>
                    [NameInMap("arr_city_name")]
                    [Validation(Required=false)]
                    public string ArrCityName { get; set; }

                    /// <summary>
                    /// <para>The arrival time. Format: yyyy-MM-dd HH:mm.</para>
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
                    public IntlFlightOrderDetailResponseBodyModuleJourneyListFlightSegmentInfosDepAirportInfo DepAirportInfo { get; set; }
                    public class IntlFlightOrderDetailResponseBodyModuleJourneyListFlightSegmentInfosDepAirportInfo : TeaModel {
                        /// <summary>
                        /// <para>The airport code.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TSN</para>
                        /// </summary>
                        [NameInMap("airport_code")]
                        [Validation(Required=false)]
                        public string AirportCode { get; set; }

                        /// <summary>
                        /// <para>The airport name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>天津滨海国际机场</para>
                        /// </summary>
                        [NameInMap("airport_name")]
                        [Validation(Required=false)]
                        public string AirportName { get; set; }

                        /// <summary>
                        /// <para>The airport short name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>滨海机场</para>
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
                    /// <para>TSN</para>
                    /// </summary>
                    [NameInMap("dep_city_code")]
                    [Validation(Required=false)]
                    public string DepCityCode { get; set; }

                    /// <summary>
                    /// <para>The departure city name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>天津</para>
                    /// </summary>
                    [NameInMap("dep_city_name")]
                    [Validation(Required=false)]
                    public string DepCityName { get; set; }

                    /// <summary>
                    /// <para>The departure time. Format: yyyy-MM-dd HH:mm.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2025-01-01 01:00</para>
                    /// </summary>
                    [NameInMap("dep_time")]
                    [Validation(Required=false)]
                    public string DepTime { get; set; }

                    /// <summary>
                    /// <para>The total duration of this segment, in minutes.</para>
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
                    /// <para>The code-share flight information.</para>
                    /// </summary>
                    [NameInMap("flight_share_info")]
                    [Validation(Required=false)]
                    public IntlFlightOrderDetailResponseBodyModuleJourneyListFlightSegmentInfosFlightShareInfo FlightShareInfo { get; set; }
                    public class IntlFlightOrderDetailResponseBodyModuleJourneyListFlightSegmentInfosFlightShareInfo : TeaModel {
                        /// <summary>
                        /// <para>The operating airline information.</para>
                        /// </summary>
                        [NameInMap("operating_airline_info")]
                        [Validation(Required=false)]
                        public IntlFlightOrderDetailResponseBodyModuleJourneyListFlightSegmentInfosFlightShareInfoOperatingAirlineInfo OperatingAirlineInfo { get; set; }
                        public class IntlFlightOrderDetailResponseBodyModuleJourneyListFlightSegmentInfosFlightShareInfoOperatingAirlineInfo : TeaModel {
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
                        /// <para>The operating flight number. This field has a value only for code-share flights.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CA1234</para>
                        /// </summary>
                        [NameInMap("operating_flight_no")]
                        [Validation(Required=false)]
                        public string OperatingFlightNo { get; set; }

                    }

                    /// <summary>
                    /// <para>The aircraft type name.</para>
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
                    public List<IntlFlightOrderDetailResponseBodyModuleJourneyListFlightSegmentInfosFlightStopInfoList> FlightStopInfoList { get; set; }
                    public class IntlFlightOrderDetailResponseBodyModuleJourneyListFlightSegmentInfosFlightStopInfoList : TeaModel {
                        /// <summary>
                        /// <para>The stopover airport code.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>PEK</para>
                        /// </summary>
                        [NameInMap("stop_airport")]
                        [Validation(Required=false)]
                        public string StopAirport { get; set; }

                        /// <summary>
                        /// <para>The stopover airport name.</para>
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
                        /// <para>The arrival time at the stopover. Format: yyyy-MM-dd HH:mm.</para>
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
                        /// <para>The stopover city name.</para>
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
                        /// <para>The departure time from the stopover. Format: yyyy-MM-dd HH:mm.</para>
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
                    /// <para>The luggage through-check information for this segment.</para>
                    /// </summary>
                    [NameInMap("luggage_direct_info")]
                    [Validation(Required=false)]
                    public IntlFlightOrderDetailResponseBodyModuleJourneyListFlightSegmentInfosLuggageDirectInfo LuggageDirectInfo { get; set; }
                    public class IntlFlightOrderDetailResponseBodyModuleJourneyListFlightSegmentInfosLuggageDirectInfo : TeaModel {
                        /// <summary>
                        /// <para>Valid values: 0 (re-check required), 1 (through-checked), null (unknown).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("dep_city_luggage_direct")]
                        [Validation(Required=false)]
                        public int? DepCityLuggageDirect { get; set; }

                        /// <summary>
                        /// <para>Valid values: 0 (re-check required), 1 (through-checked), null (unknown).</para>
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
                    /// <para>The display text for days crossed, such as &quot;+1 day&quot;.</para>
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
                    /// <para>The unique key of the segment. Format: flight number + departure airport + arrival airport + departure date (MMdd).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>NS8210XIYHGH0501</para>
                    /// </summary>
                    [NameInMap("segment_key")]
                    [Validation(Required=false)]
                    public string SegmentKey { get; set; }

                    /// <summary>
                    /// <para>The transit visa information for this segment.</para>
                    /// </summary>
                    [NameInMap("segment_visa_remark")]
                    [Validation(Required=false)]
                    public IntlFlightOrderDetailResponseBodyModuleJourneyListFlightSegmentInfosSegmentVisaRemark SegmentVisaRemark { get; set; }
                    public class IntlFlightOrderDetailResponseBodyModuleJourneyListFlightSegmentInfosSegmentVisaRemark : TeaModel {
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
                        /// <para>The transit visa type for the departure city. Valid values: NO_TRANSIT_VISA (0, &quot;No transit visa required&quot;), NEED_TRANSIT_VISA (1, &quot;Transit visa required&quot;).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("dep_city_visa_type")]
                        [Validation(Required=false)]
                        public int? DepCityVisaType { get; set; }

                        /// <summary>
                        /// <para>The transit visa information for stopover cities. One entry per stopover city.</para>
                        /// </summary>
                        [NameInMap("stop_city_visa_remarks")]
                        [Validation(Required=false)]
                        public List<string> StopCityVisaRemarks { get; set; }

                        /// <summary>
                        /// <para>The transit visa types for stopover cities. One entry per stopover city.</para>
                        /// </summary>
                        [NameInMap("stop_city_visa_types")]
                        [Validation(Required=false)]
                        public List<int?> StopCityVisaTypes { get; set; }

                    }

                    /// <summary>
                    /// <para>Indicates whether the flight is a code-share flight.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("share")]
                    [Validation(Required=false)]
                    public bool? Share { get; set; }

                    /// <summary>
                    /// <para>The aircraft type short name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>中型机</para>
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
                    /// <para>The total duration of this segment.</para>
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
                /// <para>The total transfer time, in minutes.</para>
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
            /// <para>1012000000000000</para>
            /// </summary>
            [NameInMap("order_id")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            /// <summary>
            /// <para>The order items.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>An empty array is returned when no items exist.</description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("order_item_list")]
            [Validation(Required=false)]
            public List<IntlFlightOrderDetailResponseBodyModuleOrderItemList> OrderItemList { get; set; }
            public class IntlFlightOrderDetailResponseBodyModuleOrderItemList : TeaModel {
                /// <summary>
                /// <para>The item baggage allowance information.</para>
                /// </summary>
                [NameInMap("baggage_rule")]
                [Validation(Required=false)]
                public IntlFlightOrderDetailResponseBodyModuleOrderItemListBaggageRule BaggageRule { get; set; }
                public class IntlFlightOrderDetailResponseBodyModuleOrderItemListBaggageRule : TeaModel {
                    /// <summary>
                    /// <para>The baggage summary.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>托运1件,每件10公斤</para>
                    /// </summary>
                    [NameInMap("baggage_digest")]
                    [Validation(Required=false)]
                    public string BaggageDigest { get; set; }

                    /// <summary>
                    /// <para>The baggage information by passenger type. Key: ADT/CHD/INF. Value: baggage information.</para>
                    /// </summary>
                    [NameInMap("offer_baggage_info_map")]
                    [Validation(Required=false)]
                    public Dictionary<string, List<ModuleOrderItemListBaggageRuleOfferBaggageInfoMapValue>> OfferBaggageInfoMap { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the baggage data is structured.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("structured_baggage")]
                    [Validation(Required=false)]
                    public bool? StructuredBaggage { get; set; }

                }

                /// <summary>
                /// <para>The passenger price information.</para>
                /// </summary>
                [NameInMap("passenger_price_list")]
                [Validation(Required=false)]
                public List<IntlFlightOrderDetailResponseBodyModuleOrderItemListPassengerPriceList> PassengerPriceList { get; set; }
                public class IntlFlightOrderDetailResponseBodyModuleOrderItemListPassengerPriceList : TeaModel {
                    /// <summary>
                    /// <para>The passenger type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("passenger_type")]
                    [Validation(Required=false)]
                    public int? PassengerType { get; set; }

                    /// <summary>
                    /// <para>The selling price, which equals the ticket selling price plus tax. Unit: cents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>230000</para>
                    /// </summary>
                    [NameInMap("sell_price")]
                    [Validation(Required=false)]
                    public int? SellPrice { get; set; }

                    /// <summary>
                    /// <para>The tax. For domestic flights, tax = airport construction fee + fuel surcharge. For international flights, this is the tax amount. Unit: cents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20000</para>
                    /// </summary>
                    [NameInMap("tax")]
                    [Validation(Required=false)]
                    public int? Tax { get; set; }

                    /// <summary>
                    /// <para>The ticket selling price (tax excluded). Unit: cents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>210000</para>
                    /// </summary>
                    [NameInMap("ticket_price")]
                    [Validation(Required=false)]
                    public int? TicketPrice { get; set; }

                }

                /// <summary>
                /// <para>The item refund and change information.</para>
                /// </summary>
                [NameInMap("refund_change_rule")]
                [Validation(Required=false)]
                public IntlFlightOrderDetailResponseBodyModuleOrderItemListRefundChangeRule RefundChangeRule { get; set; }
                public class IntlFlightOrderDetailResponseBodyModuleOrderItemListRefundChangeRule : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether refund is supported.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("cancel_fee_ind")]
                    [Validation(Required=false)]
                    public bool? CancelFeeInd { get; set; }

                    /// <summary>
                    /// <para>Indicates whether date change is supported.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("change_fee_ind")]
                    [Validation(Required=false)]
                    public bool? ChangeFeeInd { get; set; }

                    /// <summary>
                    /// <para>The change rule summary.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>部分情况不可改签</para>
                    /// </summary>
                    [NameInMap("change_rule_desc")]
                    [Validation(Required=false)]
                    public string ChangeRuleDesc { get; set; }

                    /// <summary>
                    /// <para>The refund and change rules by passenger type. Key: ADT/CHD/INF. Value: penalty rule.</para>
                    /// </summary>
                    [NameInMap("offer_penalty_info_map")]
                    [Validation(Required=false)]
                    public Dictionary<string, List<ModuleOrderItemListRefundChangeRuleOfferPenaltyInfoMapValue>> OfferPenaltyInfoMap { get; set; }

                    /// <summary>
                    /// <para>The refund and change summary.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>不可退改</para>
                    /// </summary>
                    [NameInMap("refund_change_digest")]
                    [Validation(Required=false)]
                    public string RefundChangeDigest { get; set; }

                    /// <summary>
                    /// <para>The refund rule summary.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>部分情况不可退票</para>
                    /// </summary>
                    [NameInMap("refund_rule_desc")]
                    [Validation(Required=false)]
                    public string RefundRuleDesc { get; set; }

                    /// <summary>
                    /// <para>Indicates whether structured refund and change rule data is available.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("structured_refund")]
                    [Validation(Required=false)]
                    public bool? StructuredRefund { get; set; }

                }

                /// <summary>
                /// <para>The segment information included in the item. The segment unique key format is: flight number + departure airport + arrival airport + departure date (MMdd).</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>An empty array is returned when no segments exist.</description></item>
                /// </list>
                /// </remarks>
                /// </summary>
                [NameInMap("segment_key_list")]
                [Validation(Required=false)]
                public List<string> SegmentKeyList { get; set; }

            }

            /// <summary>
            /// <para>The order status. Valid values: -1 (initialized), 32 (pending payment), 4 (paid), 5 (ticketing succeeded), 10 (order closed).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("order_status")]
            [Validation(Required=false)]
            public int? OrderStatus { get; set; }

            /// <summary>
            /// <para>The distribution external order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>F11374007131319304192</para>
            /// </summary>
            [NameInMap("out_order_id")]
            [Validation(Required=false)]
            public string OutOrderId { get; set; }

            /// <summary>
            /// <para>The passenger information.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>Returns null when no passengers are available.</description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("passenger_list")]
            [Validation(Required=false)]
            public List<IntlFlightOrderDetailResponseBodyModulePassengerList> PassengerList { get; set; }
            public class IntlFlightOrderDetailResponseBodyModulePassengerList : TeaModel {
                /// <summary>
                /// <para>The passenger name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ZHANG/SAN</para>
                /// </summary>
                [NameInMap("full_name")]
                [Validation(Required=false)]
                public string FullName { get; set; }

                /// <summary>
                /// <para>The gender.</para>
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
                /// <para>1001101</para>
                /// </summary>
                [NameInMap("job_no")]
                [Validation(Required=false)]
                public string JobNo { get; set; }

                /// <summary>
                /// <para>The nationality.</para>
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
                /// <para>The passenger type. Valid values: ADT (0, &quot;Adult&quot;), CHD (1, &quot;Child&quot;).</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

                /// <summary>
                /// <para>The employee ID. Required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12292812036903456</para>
                /// </summary>
                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The employee type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("user_type")]
                [Validation(Required=false)]
                public int? UserType { get; set; }

            }

            /// <summary>
            /// <para>The passenger ticket information.</para>
            /// </summary>
            [NameInMap("passenger_ticket_list")]
            [Validation(Required=false)]
            public List<IntlFlightOrderDetailResponseBodyModulePassengerTicketList> PassengerTicketList { get; set; }
            public class IntlFlightOrderDetailResponseBodyModulePassengerTicketList : TeaModel {
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
                /// <para>The passenger ticket list. Available after the order is ticketed.</para>
                /// </summary>
                [NameInMap("ticket_list")]
                [Validation(Required=false)]
                public List<IntlFlightOrderDetailResponseBodyModulePassengerTicketListTicketList> TicketList { get; set; }
                public class IntlFlightOrderDetailResponseBodyModulePassengerTicketListTicketList : TeaModel {
                    /// <summary>
                    /// <para>The ticketing time. Format: yyyy-MM-dd HH:mm:ss.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2025-01-01 00:00:09</para>
                    /// </summary>
                    [NameInMap("issue_time")]
                    [Validation(Required=false)]
                    public string IssueTime { get; set; }

                    /// <summary>
                    /// <para>The PNR code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>P012345</para>
                    /// </summary>
                    [NameInMap("pnr_no")]
                    [Validation(Required=false)]
                    public string PnrNo { get; set; }

                    /// <summary>
                    /// <para>The ticket price corresponding to the item.</para>
                    /// <remarks>
                    /// <para>Notice: If the tickets are conjunctive, the price cannot be split to each individual ticket.</notice></para>
                    /// </remarks>
                    /// </summary>
                    [NameInMap("price_info")]
                    [Validation(Required=false)]
                    public IntlFlightOrderDetailResponseBodyModulePassengerTicketListTicketListPriceInfo PriceInfo { get; set; }
                    public class IntlFlightOrderDetailResponseBodyModulePassengerTicketListTicketListPriceInfo : TeaModel {
                        /// <summary>
                        /// <para>The selling price (ticket price + tax), in cents.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>230000</para>
                        /// </summary>
                        [NameInMap("sell_price")]
                        [Validation(Required=false)]
                        public int? SellPrice { get; set; }

                        /// <summary>
                        /// <para>The reference tax, in cents.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>20000</para>
                        /// </summary>
                        [NameInMap("tax")]
                        [Validation(Required=false)]
                        public int? Tax { get; set; }

                        /// <summary>
                        /// <para>The ticket face price (excluding tax), in cents.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>210000</para>
                        /// </summary>
                        [NameInMap("ticket_price")]
                        [Validation(Required=false)]
                        public int? TicketPrice { get; set; }

                    }

                    /// <summary>
                    /// <para>The ticket segment key list.</para>
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
                    public List<IntlFlightOrderDetailResponseBodyModulePassengerTicketListTicketListTicketSegmentList> TicketSegmentList { get; set; }
                    public class IntlFlightOrderDetailResponseBodyModulePassengerTicketListTicketListTicketSegmentList : TeaModel {
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
                        /// <para>The cabin class.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Y</para>
                        /// </summary>
                        [NameInMap("cabin_class")]
                        [Validation(Required=false)]
                        public string CabinClass { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the ticket has been changed.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("modified")]
                        [Validation(Required=false)]
                        public bool? Modified { get; set; }

                        /// <summary>
                        /// <para>The ticket status.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>OPEN FOR USE</para>
                        /// </summary>
                        [NameInMap("open_ticket_status")]
                        [Validation(Required=false)]
                        public string OpenTicketStatus { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the ticket has been refunded.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("refunded")]
                        [Validation(Required=false)]
                        public bool? Refunded { get; set; }

                        /// <summary>
                        /// <para>The unique key of the segment. Format: flight number + departure airport + arrival airport + departure date (MMdd).</para>
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
            /// <para>The payment deadline for the order. The order is automatically closed if payment is not made before this time. Format: yyyy-MM-dd HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-03-06 15:35:00</para>
            /// </summary>
            [NameInMap("pay_latest_time")]
            [Validation(Required=false)]
            public string PayLatestTime { get; set; }

            /// <summary>
            /// <para>The payment status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pay_status")]
            [Validation(Required=false)]
            public int? PayStatus { get; set; }

            /// <summary>
            /// <para>The actual payment time. Format: yyyy-MM-dd HH:mm:ss.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>Available only after successful payment.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2024-03-06 15:00:35</para>
            /// </summary>
            [NameInMap("pay_time")]
            [Validation(Required=false)]
            public string PayTime { get; set; }

            /// <summary>
            /// <para>The actual payment method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("pay_type")]
            [Validation(Required=false)]
            public int? PayType { get; set; }

            /// <summary>
            /// <para>The ticketing success time. Format: yyyy-MM-dd HH:mm:ss.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>Available only after ticketing succeeds.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2024-03-06 15:01:35</para>
            /// </summary>
            [NameInMap("success_time")]
            [Validation(Required=false)]
            public string SuccessTime { get; set; }

            /// <summary>
            /// <para>The total order price, in cents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>230000</para>
            /// </summary>
            [NameInMap("total_price")]
            [Validation(Required=false)]
            public long? TotalPrice { get; set; }

            /// <summary>
            /// <para>The total tax, in cents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20000</para>
            /// </summary>
            [NameInMap("total_tax_price")]
            [Validation(Required=false)]
            public long? TotalTaxPrice { get; set; }

            /// <summary>
            /// <para>The total ticket price, in cents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>210000</para>
            /// </summary>
            [NameInMap("total_ticket_price")]
            [Validation(Required=false)]
            public long? TotalTicketPrice { get; set; }

            /// <summary>
            /// <para>The trip type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("trip_type")]
            [Validation(Required=false)]
            public int? TripType { get; set; }

        }

        /// <summary>
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>B72B39C8-32DE-558D-AD1C-D53F11F6ADFE</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values: true and false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The global trace identifier for the request, typically used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>210bc4b116835992457938931db4de</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
