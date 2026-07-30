// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightOtaItemDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The data.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public IntlFlightOtaItemDetailResponseBodyModule Module { get; set; }
        public class IntlFlightOtaItemDetailResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The flight journey information.</para>
            /// </summary>
            [NameInMap("flight_journey_infos")]
            [Validation(Required=false)]
            public List<IntlFlightOtaItemDetailResponseBodyModuleFlightJourneyInfos> FlightJourneyInfos { get; set; }
            public class IntlFlightOtaItemDetailResponseBodyModuleFlightJourneyInfos : TeaModel {
                /// <summary>
                /// <para>The arrival city code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HGH</para>
                /// </summary>
                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                /// <summary>
                /// <para>The arrival city name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>杭州</para>
                /// </summary>
                [NameInMap("arr_city_name")]
                [Validation(Required=false)]
                public string ArrCityName { get; set; }

                /// <summary>
                /// <para>The arrival time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-08-13 09:45</para>
                /// </summary>
                [NameInMap("arr_time")]
                [Validation(Required=false)]
                public string ArrTime { get; set; }

                /// <summary>
                /// <para>The departure city code.</para>
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
                /// <para>The departure time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-08-13 07:25</para>
                /// </summary>
                [NameInMap("dep_time")]
                [Validation(Required=false)]
                public string DepTime { get; set; }

                /// <summary>
                /// <para>The total duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>140</para>
                /// </summary>
                [NameInMap("duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                /// <summary>
                /// <para>The flight extended information.</para>
                /// </summary>
                [NameInMap("extensions")]
                [Validation(Required=false)]
                public Dictionary<string, string> Extensions { get; set; }

                /// <summary>
                /// <para>The flight segment information.</para>
                /// </summary>
                [NameInMap("flight_segment_infos")]
                [Validation(Required=false)]
                public List<IntlFlightOtaItemDetailResponseBodyModuleFlightJourneyInfosFlightSegmentInfos> FlightSegmentInfos { get; set; }
                public class IntlFlightOtaItemDetailResponseBodyModuleFlightJourneyInfosFlightSegmentInfos : TeaModel {
                    /// <summary>
                    /// <para>The marketing airline information.</para>
                    /// </summary>
                    [NameInMap("airline_info")]
                    [Validation(Required=false)]
                    public IntlFlightOtaItemDetailResponseBodyModuleFlightJourneyInfosFlightSegmentInfosAirlineInfo AirlineInfo { get; set; }
                    public class IntlFlightOtaItemDetailResponseBodyModuleFlightJourneyInfosFlightSegmentInfosAirlineInfo : TeaModel {
                        /// <summary>
                        /// <para>The airline Chinese name, such as Air China.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>中国东方航空</para>
                        /// </summary>
                        [NameInMap("airline_chinese_name")]
                        [Validation(Required=false)]
                        public string AirlineChineseName { get; set; }

                        /// <summary>
                        /// <para>The airline Chinese short name, such as Air China.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>东航</para>
                        /// </summary>
                        [NameInMap("airline_chinese_short_name")]
                        [Validation(Required=false)]
                        public string AirlineChineseShortName { get; set; }

                        /// <summary>
                        /// <para>The airline code, such as &quot;HU&quot; for Hainan Airlines.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>MU</para>
                        /// </summary>
                        [NameInMap("airline_code")]
                        [Validation(Required=false)]
                        public string AirlineCode { get; set; }

                        /// <summary>
                        /// <para>The airline logo URL, such as <a href="https://img.alicdn.com/tps/TB1DjLzLXXXXXaoXFXXXXXXXXXX-64-64.png">https://img.alicdn.com/tps/TB1DjLzLXXXXXaoXFXXXXXXXXXX-64-64.png</a>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="https://gw.alicdn.com/tfs/TB15EXDFHY1gK0jSZTEXXXDQVXa-450-450.png_80x80.jpg">https://gw.alicdn.com/tfs/TB15EXDFHY1gK0jSZTEXXXDQVXa-450-450.png_80x80.jpg</a></para>
                        /// </summary>
                        [NameInMap("airline_icon")]
                        [Validation(Required=false)]
                        public string AirlineIcon { get; set; }

                        /// <summary>
                        /// <para>The low-cost carrier indicator.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("cheap_flight")]
                        [Validation(Required=false)]
                        public bool? CheapFlight { get; set; }

                    }

                    /// <summary>
                    /// <para>The arrival airport information.</para>
                    /// </summary>
                    [NameInMap("arr_airport_info")]
                    [Validation(Required=false)]
                    public IntlFlightOtaItemDetailResponseBodyModuleFlightJourneyInfosFlightSegmentInfosArrAirportInfo ArrAirportInfo { get; set; }
                    public class IntlFlightOtaItemDetailResponseBodyModuleFlightJourneyInfosFlightSegmentInfosArrAirportInfo : TeaModel {
                        /// <summary>
                        /// <para>The airport code.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>PKX</para>
                        /// </summary>
                        [NameInMap("airport_code")]
                        [Validation(Required=false)]
                        public string AirportCode { get; set; }

                        /// <summary>
                        /// <para>The airport name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>大兴国际机场</para>
                        /// </summary>
                        [NameInMap("airport_name")]
                        [Validation(Required=false)]
                        public string AirportName { get; set; }

                        /// <summary>
                        /// <para>The airport short name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>大兴</para>
                        /// </summary>
                        [NameInMap("airport_short_name")]
                        [Validation(Required=false)]
                        public string AirportShortName { get; set; }

                        /// <summary>
                        /// <para>The terminal.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>--</para>
                        /// </summary>
                        [NameInMap("terminal")]
                        [Validation(Required=false)]
                        public string Terminal { get; set; }

                    }

                    /// <summary>
                    /// <para>The arrival city three-letter code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>BJS</para>
                    /// </summary>
                    [NameInMap("arr_city_code")]
                    [Validation(Required=false)]
                    public string ArrCityCode { get; set; }

                    /// <summary>
                    /// <para>The arrival city name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>北京</para>
                    /// </summary>
                    [NameInMap("arr_city_name")]
                    [Validation(Required=false)]
                    public string ArrCityName { get; set; }

                    /// <summary>
                    /// <para>The arrival time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2023-08-13 09:45</para>
                    /// </summary>
                    [NameInMap("arr_time")]
                    [Validation(Required=false)]
                    public string ArrTime { get; set; }

                    /// <summary>
                    /// <para>The baggage allowance description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>无免费行李额</para>
                    /// </summary>
                    [NameInMap("baggage_desc")]
                    [Validation(Required=false)]
                    public string BaggageDesc { get; set; }

                    /// <summary>
                    /// <para>The departure airport information.</para>
                    /// </summary>
                    [NameInMap("dep_airport_info")]
                    [Validation(Required=false)]
                    public IntlFlightOtaItemDetailResponseBodyModuleFlightJourneyInfosFlightSegmentInfosDepAirportInfo DepAirportInfo { get; set; }
                    public class IntlFlightOtaItemDetailResponseBodyModuleFlightJourneyInfosFlightSegmentInfosDepAirportInfo : TeaModel {
                        /// <summary>
                        /// <para>The airport code.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>HGH</para>
                        /// </summary>
                        [NameInMap("airport_code")]
                        [Validation(Required=false)]
                        public string AirportCode { get; set; }

                        /// <summary>
                        /// <para>The airport name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>萧山国际机场</para>
                        /// </summary>
                        [NameInMap("airport_name")]
                        [Validation(Required=false)]
                        public string AirportName { get; set; }

                        /// <summary>
                        /// <para>The airport short name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>萧山</para>
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
                    /// <para>The departure city three-letter code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HGH</para>
                    /// </summary>
                    [NameInMap("dep_city_code")]
                    [Validation(Required=false)]
                    public string DepCityCode { get; set; }

                    /// <summary>
                    /// <para>The departure city name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>杭州</para>
                    /// </summary>
                    [NameInMap("dep_city_name")]
                    [Validation(Required=false)]
                    public string DepCityName { get; set; }

                    /// <summary>
                    /// <para>The departure time, such as 2021-11-15 21:55.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2023-08-13 07:25</para>
                    /// </summary>
                    [NameInMap("dep_time")]
                    [Validation(Required=false)]
                    public string DepTime { get; set; }

                    /// <summary>
                    /// <para>The total duration.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>140</para>
                    /// </summary>
                    [NameInMap("duration")]
                    [Validation(Required=false)]
                    public int? Duration { get; set; }

                    /// <summary>
                    /// <para>The flight number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MU5131</para>
                    /// </summary>
                    [NameInMap("flight_no")]
                    [Validation(Required=false)]
                    public string FlightNo { get; set; }

                    /// <summary>
                    /// <para>The codeshare flight information.</para>
                    /// </summary>
                    [NameInMap("flight_share_info")]
                    [Validation(Required=false)]
                    public IntlFlightOtaItemDetailResponseBodyModuleFlightJourneyInfosFlightSegmentInfosFlightShareInfo FlightShareInfo { get; set; }
                    public class IntlFlightOtaItemDetailResponseBodyModuleFlightJourneyInfosFlightSegmentInfosFlightShareInfo : TeaModel {
                        /// <summary>
                        /// <para>The operating airline information.</para>
                        /// </summary>
                        [NameInMap("operating_airline_info")]
                        [Validation(Required=false)]
                        public IntlFlightOtaItemDetailResponseBodyModuleFlightJourneyInfosFlightSegmentInfosFlightShareInfoOperatingAirlineInfo OperatingAirlineInfo { get; set; }
                        public class IntlFlightOtaItemDetailResponseBodyModuleFlightJourneyInfosFlightSegmentInfosFlightShareInfoOperatingAirlineInfo : TeaModel {
                            /// <summary>
                            /// <para>The airline Chinese name, such as Air China.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>中国国航</para>
                            /// </summary>
                            [NameInMap("airline_chinese_name")]
                            [Validation(Required=false)]
                            public string AirlineChineseName { get; set; }

                            /// <summary>
                            /// <para>The airline Chinese short name, such as Air China.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>国航</para>
                            /// </summary>
                            [NameInMap("airline_chinese_short_name")]
                            [Validation(Required=false)]
                            public string AirlineChineseShortName { get; set; }

                            /// <summary>
                            /// <para>The airline code, such as &quot;HU&quot; for Hainan Airlines.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>KN</para>
                            /// </summary>
                            [NameInMap("airline_code")]
                            [Validation(Required=false)]
                            public string AirlineCode { get; set; }

                            /// <summary>
                            /// <para>The airline logo URL, such as <a href="https://img.alicdn.com/tps/TB1DjLzLXXXXXaoXFXXXXXXXXXX-64-64.png">https://img.alicdn.com/tps/TB1DjLzLXXXXXaoXFXXXXXXXXXX-64-64.png</a>.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para><a href="https://gw.alicdn.com/tfs/TB1gSXBFUT1gK0jSZFhXXaAtVXa-450-450.png_80x80.jpg">https://gw.alicdn.com/tfs/TB1gSXBFUT1gK0jSZFhXXaAtVXa-450-450.png_80x80.jpg</a></para>
                            /// </summary>
                            [NameInMap("airline_icon")]
                            [Validation(Required=false)]
                            public string AirlineIcon { get; set; }

                            /// <summary>
                            /// <para>The low-cost carrier indicator.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>false</para>
                            /// </summary>
                            [NameInMap("cheap_flight")]
                            [Validation(Required=false)]
                            public bool? CheapFlight { get; set; }

                        }

                        /// <summary>
                        /// <para>The operating carrier flight number. This field has a value only for codeshare flights.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CX601</para>
                        /// </summary>
                        [NameInMap("operating_flight_no")]
                        [Validation(Required=false)]
                        public string OperatingFlightNo { get; set; }

                    }

                    /// <summary>
                    /// <para>The aircraft size name, such as &quot;Medium&quot;.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>中型机</para>
                    /// </summary>
                    [NameInMap("flight_size")]
                    [Validation(Required=false)]
                    public string FlightSize { get; set; }

                    /// <summary>
                    /// <para>The stopover information.</para>
                    /// </summary>
                    [NameInMap("flight_stop_info")]
                    [Validation(Required=false)]
                    public IntlFlightOtaItemDetailResponseBodyModuleFlightJourneyInfosFlightSegmentInfosFlightStopInfo FlightStopInfo { get; set; }
                    public class IntlFlightOtaItemDetailResponseBodyModuleFlightJourneyInfosFlightSegmentInfosFlightStopInfo : TeaModel {
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
                        /// <para>The stopover airport name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>萧山国际机场</para>
                        /// </summary>
                        [NameInMap("stop_airport_name")]
                        [Validation(Required=false)]
                        public string StopAirportName { get; set; }

                        /// <summary>
                        /// <para>The stopover terminal for arrival.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>T3</para>
                        /// </summary>
                        [NameInMap("stop_arr_term")]
                        [Validation(Required=false)]
                        public string StopArrTerm { get; set; }

                        /// <summary>
                        /// <para>The stopover arrival time.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>BJS</para>
                        /// </summary>
                        [NameInMap("stop_arr_time")]
                        [Validation(Required=false)]
                        public string StopArrTime { get; set; }

                        /// <summary>
                        /// <para>The stopover city three-letter code.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>HGH</para>
                        /// </summary>
                        [NameInMap("stop_city_code")]
                        [Validation(Required=false)]
                        public string StopCityCode { get; set; }

                        /// <summary>
                        /// <para>The stopover city name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>HGH</para>
                        /// </summary>
                        [NameInMap("stop_city_name")]
                        [Validation(Required=false)]
                        public string StopCityName { get; set; }

                        /// <summary>
                        /// <para>The stopover cities.</para>
                        /// </summary>
                        [NameInMap("stop_city_names")]
                        [Validation(Required=false)]
                        public List<string> StopCityNames { get; set; }

                        /// <summary>
                        /// <para>The stopover terminal for departure.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>T4</para>
                        /// </summary>
                        [NameInMap("stop_dep_term")]
                        [Validation(Required=false)]
                        public string StopDepTerm { get; set; }

                        /// <summary>
                        /// <para>The stopover departure time.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2023-08-13 07:25</para>
                        /// </summary>
                        [NameInMap("stop_dep_time")]
                        [Validation(Required=false)]
                        public string StopDepTime { get; set; }

                        /// <summary>
                        /// <para>The stopover duration.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1小时20分钟</para>
                        /// </summary>
                        [NameInMap("stop_time")]
                        [Validation(Required=false)]
                        public string StopTime { get; set; }

                    }

                    /// <summary>
                    /// <para>The aircraft type code, such as 738.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>320</para>
                    /// </summary>
                    [NameInMap("flight_type")]
                    [Validation(Required=false)]
                    public string FlightType { get; set; }

                    /// <summary>
                    /// <para>The baggage through-check information for the current segment.</para>
                    /// </summary>
                    [NameInMap("luggage_direct_info")]
                    [Validation(Required=false)]
                    public IntlFlightOtaItemDetailResponseBodyModuleFlightJourneyInfosFlightSegmentInfosLuggageDirectInfo LuggageDirectInfo { get; set; }
                    public class IntlFlightOtaItemDetailResponseBodyModuleFlightJourneyInfosFlightSegmentInfosLuggageDirectInfo : TeaModel {
                        /// <summary>
                        /// <para>The baggage through-check status. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>0: Re-check required.</description></item>
                        /// <item><description>1: Through-checked.</description></item>
                        /// <item><description>null: Unknown.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("dep_city_luggage_direct")]
                        [Validation(Required=false)]
                        public int? DepCityLuggageDirect { get; set; }

                        /// <summary>
                        /// <para>The baggage through-check status. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>0: Re-check required.</description></item>
                        /// <item><description>1: Through-checked.</description></item>
                        /// <item><description>null: Unknown.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("stop_city_luggage_direct")]
                        [Validation(Required=false)]
                        public int? StopCityLuggageDirect { get; set; }

                    }

                    /// <summary>
                    /// <para>The manufacturer, such as &quot;Boeing&quot;.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>空客</para>
                    /// </summary>
                    [NameInMap("manufacturer")]
                    [Validation(Required=false)]
                    public string Manufacturer { get; set; }

                    /// <summary>
                    /// <para>The meal service description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>小食</para>
                    /// </summary>
                    [NameInMap("meal_desc")]
                    [Validation(Required=false)]
                    public string MealDesc { get; set; }

                    /// <summary>
                    /// <para>The on-time rate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>80%</para>
                    /// </summary>
                    [NameInMap("on_time_rate")]
                    [Validation(Required=false)]
                    public string OnTimeRate { get; set; }

                    /// <summary>
                    /// <para>The number of days crossed, where 1 indicates crossing 1 day.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("one_more")]
                    [Validation(Required=false)]
                    public int? OneMore { get; set; }

                    /// <summary>
                    /// <para>The day-crossing display text, such as &quot;+1 day&quot;.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>+1天</para>
                    /// </summary>
                    [NameInMap("one_more_show")]
                    [Validation(Required=false)]
                    public string OneMoreShow { get; set; }

                    /// <summary>
                    /// <para>The segment index, starting from 0.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("segment_index")]
                    [Validation(Required=false)]
                    public int? SegmentIndex { get; set; }

                    /// <summary>
                    /// <para>The unique segment key in the format: flight number + departure airport + arrival airport + departure date (MMdd), for example: KN6728HGHPKX0725.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>KN6728HGHPKX0725</para>
                    /// </summary>
                    [NameInMap("segment_key")]
                    [Validation(Required=false)]
                    public string SegmentKey { get; set; }

                    /// <summary>
                    /// <para>The transit visa information for the current segment (international).</para>
                    /// </summary>
                    [NameInMap("segment_visa_remark")]
                    [Validation(Required=false)]
                    public IntlFlightOtaItemDetailResponseBodyModuleFlightJourneyInfosFlightSegmentInfosSegmentVisaRemark SegmentVisaRemark { get; set; }
                    public class IntlFlightOtaItemDetailResponseBodyModuleFlightJourneyInfosFlightSegmentInfosSegmentVisaRemark : TeaModel {
                        /// <summary>
                        /// <para>The transit visa information for the departure city.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>前往菲律宾的旅客，请确保持有往返纸质行程单以及纸质签证办理登记手续，否则可能会被当地政府拒绝入境</para>
                        /// </summary>
                        [NameInMap("dep_city_visa_remark")]
                        [Validation(Required=false)]
                        public string DepCityVisaRemark { get; set; }

                        /// <summary>
                        /// <para>The transit visa type for the departure city. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>0: No transit visa required.</description></item>
                        /// <item><description>1: Transit visa required.</description></item>
                        /// </list>
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
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("share")]
                    [Validation(Required=false)]
                    public bool? Share { get; set; }

                    /// <summary>
                    /// <para>The aircraft size abbreviation, such as &quot;M&quot;.</para>
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
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("stop")]
                    [Validation(Required=false)]
                    public bool? Stop { get; set; }

                    /// <summary>
                    /// <para>The total duration of this segment.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2小时20分</para>
                    /// </summary>
                    [NameInMap("total_time")]
                    [Validation(Required=false)]
                    public string TotalTime { get; set; }

                    /// <summary>
                    /// <para>The transfer time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1小时20分钟</para>
                    /// </summary>
                    [NameInMap("transfer_time")]
                    [Validation(Required=false)]
                    public string TransferTime { get; set; }

                    /// <summary>
                    /// <para>The transfer time in numeric format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>80</para>
                    /// </summary>
                    [NameInMap("transfer_time_number")]
                    [Validation(Required=false)]
                    public int? TransferTimeNumber { get; set; }

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
            /// <para>The quote item information.</para>
            /// </summary>
            [NameInMap("group_item")]
            [Validation(Required=false)]
            public IntlFlightOtaItemDetailResponseBodyModuleGroupItem GroupItem { get; set; }
            public class IntlFlightOtaItemDetailResponseBodyModuleGroupItem : TeaModel {
                /// <summary>
                /// <para>The agreement price encoding.</para>
                /// </summary>
                [NameInMap("agreement_price_codes")]
                [Validation(Required=false)]
                public List<string> AgreementPriceCodes { get; set; }

                /// <summary>
                /// <para>The refund/change rules and baggage allowance.</para>
                /// <list type="bullet">
                /// <item><description>An empty array is returned when no data is available.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("flight_rule_info_list")]
                [Validation(Required=false)]
                public List<IntlFlightOtaItemDetailResponseBodyModuleGroupItemFlightRuleInfoList> FlightRuleInfoList { get; set; }
                public class IntlFlightOtaItemDetailResponseBodyModuleGroupItemFlightRuleInfoList : TeaModel {
                    /// <summary>
                    /// <para>The refund/change and baggage rules.</para>
                    /// </summary>
                    [NameInMap("flight_rule_info")]
                    [Validation(Required=false)]
                    public IntlFlightOtaItemDetailResponseBodyModuleGroupItemFlightRuleInfoListFlightRuleInfo FlightRuleInfo { get; set; }
                    public class IntlFlightOtaItemDetailResponseBodyModuleGroupItemFlightRuleInfoListFlightRuleInfo : TeaModel {
                        /// <summary>
                        /// <para>The brief description of the baggage allowance rules.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>无免费行李额</para>
                        /// </summary>
                        [NameInMap("baggage_desc")]
                        [Validation(Required=false)]
                        public string BaggageDesc { get; set; }

                        /// <summary>
                        /// <para>The brief description of the refund/change rules.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>免费退改</para>
                        /// </summary>
                        [NameInMap("refund_change_rule_desc")]
                        [Validation(Required=false)]
                        public string RefundChangeRuleDesc { get; set; }

                    }

                    /// <summary>
                    /// <para>The segment position information, indicating which journey and which segment within the overall itinerary.</para>
                    /// </summary>
                    [NameInMap("segment_position")]
                    [Validation(Required=false)]
                    public IntlFlightOtaItemDetailResponseBodyModuleGroupItemFlightRuleInfoListSegmentPosition SegmentPosition { get; set; }
                    public class IntlFlightOtaItemDetailResponseBodyModuleGroupItemFlightRuleInfoListSegmentPosition : TeaModel {
                        /// <summary>
                        /// <para>The journey index (starting from 0).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("journey_index")]
                        [Validation(Required=false)]
                        public int? JourneyIndex { get; set; }

                        /// <summary>
                        /// <para>The segment index (starting from 0 within the same journey).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("segment_index")]
                        [Validation(Required=false)]
                        public int? SegmentIndex { get; set; }

                    }

                }

                /// <summary>
                /// <para>The item ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>669845158418</para>
                /// </summary>
                [NameInMap("item_id")]
                [Validation(Required=false)]
                public string ItemId { get; set; }

                /// <summary>
                /// <para>The product type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>normal: standard product.</description></item>
                /// <item><description>combination: combination special offer.</description></item>
                /// <item><description>reliable_combination: fly-enjoy combination.</description></item>
                /// </list>
                /// <remarks>
                /// <para>Notice: The fly-enjoy combination product is deprecated.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("item_type")]
                [Validation(Required=false)]
                public string ItemType { get; set; }

                /// <summary>
                /// <para>The map where key is the passenger type: ADT for adult, CHD for child, INFANT for infant.</para>
                /// </summary>
                [NameInMap("shopping_item_map")]
                [Validation(Required=false)]
                public Dictionary<string, ModuleGroupItemShoppingItemMapValue> ShoppingItemMap { get; set; }

                /// <summary>
                /// <para>The mapping of subItem.uniqKey to the positions of all segments where the subItem appears.</para>
                /// </summary>
                [NameInMap("sub_item_position_map")]
                [Validation(Required=false)]
                public Dictionary<string, List<ModuleGroupItemSubItemPositionMapValue>> SubItemPositionMap { get; set; }

                /// <summary>
                /// <para>The sub-items. Combined products have multiple sub-items.</para>
                /// </summary>
                [NameInMap("sub_items")]
                [Validation(Required=false)]
                public List<IntlFlightOtaItemDetailResponseBodyModuleGroupItemSubItems> SubItems { get; set; }
                public class IntlFlightOtaItemDetailResponseBodyModuleGroupItemSubItems : TeaModel {
                    /// <summary>
                    /// <para>The baggage allowance information of the sub-item.</para>
                    /// </summary>
                    [NameInMap("baggage_rule")]
                    [Validation(Required=false)]
                    public IntlFlightOtaItemDetailResponseBodyModuleGroupItemSubItemsBaggageRule BaggageRule { get; set; }
                    public class IntlFlightOtaItemDetailResponseBodyModuleGroupItemSubItemsBaggageRule : TeaModel {
                        /// <summary>
                        /// <para>The baggage summary.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>免费退改</para>
                        /// </summary>
                        [NameInMap("baggage_digest")]
                        [Validation(Required=false)]
                        public string BaggageDigest { get; set; }

                        /// <summary>
                        /// <para>The baggage information of the sub-item.</para>
                        /// </summary>
                        [NameInMap("baggage_info_map")]
                        [Validation(Required=false)]
                        public Dictionary<string, List<ModuleGroupItemSubItemsBaggageRuleBaggageInfoMapValue>> BaggageInfoMap { get; set; }

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
                    /// <para>The refund and change rule information of the sub-item.</para>
                    /// </summary>
                    [NameInMap("refund_change_rule")]
                    [Validation(Required=false)]
                    public IntlFlightOtaItemDetailResponseBodyModuleGroupItemSubItemsRefundChangeRule RefundChangeRule { get; set; }
                    public class IntlFlightOtaItemDetailResponseBodyModuleGroupItemSubItemsRefundChangeRule : TeaModel {
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
                        /// <para>The refund and change rules.</para>
                        /// </summary>
                        [NameInMap("offer_penalty_info_map")]
                        [Validation(Required=false)]
                        public Dictionary<string, List<ModuleGroupItemSubItemsRefundChangeRuleOfferPenaltyInfoMapValue>> OfferPenaltyInfoMap { get; set; }

                        /// <summary>
                        /// <para>The refund and change summary.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>免费退改</para>
                        /// </summary>
                        [NameInMap("refund_change_digest")]
                        [Validation(Required=false)]
                        public string RefundChangeDigest { get; set; }

                        /// <summary>
                        /// <para>Indicates whether structured refund and change rule data is available.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("structured_refund")]
                        [Validation(Required=false)]
                        public bool? StructuredRefund { get; set; }

                    }

                    /// <summary>
                    /// <para>The segment information contained in the sub-item.</para>
                    /// </summary>
                    [NameInMap("segment_keys")]
                    [Validation(Required=false)]
                    public List<string> SegmentKeys { get; set; }

                    /// <summary>
                    /// <para>The map where key is the passenger type: ADT for adult, CHD for child, INFANT for infant.</para>
                    /// </summary>
                    [NameInMap("shopping_item_map")]
                    [Validation(Required=false)]
                    public Dictionary<string, ModuleGroupItemSubItemsShoppingItemMapValue> ShoppingItemMap { get; set; }

                    /// <summary>
                    /// <para>The unique ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>23412341234124</para>
                    /// </summary>
                    [NameInMap("uniq_key")]
                    [Validation(Required=false)]
                    public string UniqKey { get; set; }

                }

            }

            /// <summary>
            /// <para>The journey notice information.
            /// [<em>single.resp.200.props.module.shutter</em></para>
            /// </summary>
            [NameInMap("shutter_docs")]
            [Validation(Required=false)]
            public List<IntlFlightOtaItemDetailResponseBodyModuleShutterDocs> ShutterDocs { get; set; }
            public class IntlFlightOtaItemDetailResponseBodyModuleShutterDocs : TeaModel {
                /// <summary>
                /// <para>The notice content.</para>
                /// </summary>
                [NameInMap("contents")]
                [Validation(Required=false)]
                public List<string> Contents { get; set; }

                /// <summary>
                /// <para>The main notice title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>入境提示</para>
                /// </summary>
                [NameInMap("main_title")]
                [Validation(Required=false)]
                public string MainTitle { get; set; }

            }

            /// <summary>
            /// <para>The trip type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("trip_type")]
            [Validation(Required=false)]
            public int? TripType { get; set; }

        }

        /// <summary>
        /// <para>The unique identity of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C61ECFF6-606B-5F66-B81D-D77369043A5F</para>
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
        /// <para>The global identity for tracking the request, typically used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
