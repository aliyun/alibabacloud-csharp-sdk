// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightOtaSearchResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
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
        /// <para>module。</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public IntlFlightOtaSearchResponseBodyModule Module { get; set; }
        public class IntlFlightOtaSearchResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The flight journey information.</para>
            /// </summary>
            [NameInMap("flight_journey_infos")]
            [Validation(Required=false)]
            public List<IntlFlightOtaSearchResponseBodyModuleFlightJourneyInfos> FlightJourneyInfos { get; set; }
            public class IntlFlightOtaSearchResponseBodyModuleFlightJourneyInfos : TeaModel {
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
                /// <para>The flight segment information.</para>
                /// </summary>
                [NameInMap("flight_segment_infos")]
                [Validation(Required=false)]
                public List<IntlFlightOtaSearchResponseBodyModuleFlightJourneyInfosFlightSegmentInfos> FlightSegmentInfos { get; set; }
                public class IntlFlightOtaSearchResponseBodyModuleFlightJourneyInfosFlightSegmentInfos : TeaModel {
                    /// <summary>
                    /// <para>The marketing airline information.</para>
                    /// </summary>
                    [NameInMap("airline_info")]
                    [Validation(Required=false)]
                    public IntlFlightOtaSearchResponseBodyModuleFlightJourneyInfosFlightSegmentInfosAirlineInfo AirlineInfo { get; set; }
                    public class IntlFlightOtaSearchResponseBodyModuleFlightJourneyInfosFlightSegmentInfosAirlineInfo : TeaModel {
                        /// <summary>
                        /// <para>The airline code, e.g., &quot;HU&quot; for Hainan Airlines.</para>
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
                        /// <para>东方航空</para>
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
                    public IntlFlightOtaSearchResponseBodyModuleFlightJourneyInfosFlightSegmentInfosArrAirportInfo ArrAirportInfo { get; set; }
                    public class IntlFlightOtaSearchResponseBodyModuleFlightJourneyInfosFlightSegmentInfosArrAirportInfo : TeaModel {
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
                        /// <para>The terminal (may not have a value).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>--</para>
                        /// </summary>
                        [NameInMap("terminal")]
                        [Validation(Required=false)]
                        public string Terminal { get; set; }

                    }

                    /// <summary>
                    /// <para>The three-letter code of the arrival city.</para>
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
                    /// <para>The departure airport information.</para>
                    /// </summary>
                    [NameInMap("dep_airport_info")]
                    [Validation(Required=false)]
                    public IntlFlightOtaSearchResponseBodyModuleFlightJourneyInfosFlightSegmentInfosDepAirportInfo DepAirportInfo { get; set; }
                    public class IntlFlightOtaSearchResponseBodyModuleFlightJourneyInfosFlightSegmentInfosDepAirportInfo : TeaModel {
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
                        /// <para>The terminal (may not have a value).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>T3</para>
                        /// </summary>
                        [NameInMap("terminal")]
                        [Validation(Required=false)]
                        public string Terminal { get; set; }

                    }

                    /// <summary>
                    /// <para>The three-letter code of the departure city.</para>
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
                    /// <para>The departure time, e.g., 2021-11-15 21:55.</para>
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
                    public IntlFlightOtaSearchResponseBodyModuleFlightJourneyInfosFlightSegmentInfosFlightShareInfo FlightShareInfo { get; set; }
                    public class IntlFlightOtaSearchResponseBodyModuleFlightJourneyInfosFlightSegmentInfosFlightShareInfo : TeaModel {
                        /// <summary>
                        /// <para>The operating airline information.</para>
                        /// </summary>
                        [NameInMap("operating_airline_info")]
                        [Validation(Required=false)]
                        public IntlFlightOtaSearchResponseBodyModuleFlightJourneyInfosFlightSegmentInfosFlightShareInfoOperatingAirlineInfo OperatingAirlineInfo { get; set; }
                        public class IntlFlightOtaSearchResponseBodyModuleFlightJourneyInfosFlightSegmentInfosFlightShareInfoOperatingAirlineInfo : TeaModel {
                            /// <summary>
                            /// <para>The airline code, e.g., &quot;HU&quot; for Hainan Airlines.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>DR</para>
                            /// </summary>
                            [NameInMap("airline_code")]
                            [Validation(Required=false)]
                            public string AirlineCode { get; set; }

                            /// <summary>
                            /// <para>The airline name.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>苏南瑞丽航空</para>
                            /// </summary>
                            [NameInMap("airline_name")]
                            [Validation(Required=false)]
                            public string AirlineName { get; set; }

                            /// <summary>
                            /// <para>The airline short name.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>瑞丽航空</para>
                            /// </summary>
                            [NameInMap("short_name")]
                            [Validation(Required=false)]
                            public string ShortName { get; set; }

                        }

                        /// <summary>
                        /// <para>The operating carrier flight number (available for codeshare flights).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CX601</para>
                        /// </summary>
                        [NameInMap("operating_flight_no")]
                        [Validation(Required=false)]
                        public string OperatingFlightNo { get; set; }

                    }

                    /// <summary>
                    /// <para>The aircraft size name, e.g., &quot;Medium&quot; (may not have a value).</para>
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
                    public List<IntlFlightOtaSearchResponseBodyModuleFlightJourneyInfosFlightSegmentInfosFlightStopInfoList> FlightStopInfoList { get; set; }
                    public class IntlFlightOtaSearchResponseBodyModuleFlightJourneyInfosFlightSegmentInfosFlightStopInfoList : TeaModel {
                        /// <summary>
                        /// <para>The stopover airport.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>大兴机场</para>
                        /// </summary>
                        [NameInMap("stop_airport")]
                        [Validation(Required=false)]
                        public string StopAirport { get; set; }

                        /// <summary>
                        /// <para>The stopover airport name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>PKX</para>
                        /// </summary>
                        [NameInMap("stop_airport_name")]
                        [Validation(Required=false)]
                        public string StopAirportName { get; set; }

                        /// <summary>
                        /// <para>The stopover terminal for arrival.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>T1</para>
                        /// </summary>
                        [NameInMap("stop_arr_term")]
                        [Validation(Required=false)]
                        public string StopArrTerm { get; set; }

                        /// <summary>
                        /// <para>The stopover arrival time, format: yyyy-MM-dd HH:mm.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2025-10-01 02:00</para>
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
                        /// <para>The stopover terminal for departure.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>T1</para>
                        /// </summary>
                        [NameInMap("stop_dep_term")]
                        [Validation(Required=false)]
                        public string StopDepTerm { get; set; }

                        /// <summary>
                        /// <para>The stopover departure time, format: yyyy-MM-dd HH:mm.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2025-10-01 03:00</para>
                        /// </summary>
                        [NameInMap("stop_dep_time")]
                        [Validation(Required=false)]
                        public string StopDepTime { get; set; }

                        /// <summary>
                        /// <para>The stopover duration, in minutes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>60</para>
                        /// </summary>
                        [NameInMap("stop_time")]
                        [Validation(Required=false)]
                        public string StopTime { get; set; }

                    }

                    /// <summary>
                    /// <para>The aircraft type code, e.g., 738 (may not have a value).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>320</para>
                    /// </summary>
                    [NameInMap("flight_type")]
                    [Validation(Required=false)]
                    public string FlightType { get; set; }

                    /// <summary>
                    /// <para>Indicates whether luggage is checked through directly for the current segment.</para>
                    /// </summary>
                    [NameInMap("luggage_direct_info")]
                    [Validation(Required=false)]
                    public IntlFlightOtaSearchResponseBodyModuleFlightJourneyInfosFlightSegmentInfosLuggageDirectInfo LuggageDirectInfo { get; set; }
                    public class IntlFlightOtaSearchResponseBodyModuleFlightJourneyInfosFlightSegmentInfosLuggageDirectInfo : TeaModel {
                        /// <summary>
                        /// <para>The luggage transfer type for the departure city. Valid values: 0: re-check. 1: through. null: unknown.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("dep_city_luggage_direct")]
                        [Validation(Required=false)]
                        public int? DepCityLuggageDirect { get; set; }

                        /// <summary>
                        /// <para>The luggage transfer type for the departure city. Valid values: 0: re-check. 1: through. null: unknown.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("stop_city_luggage_direct")]
                        [Validation(Required=false)]
                        public int? StopCityLuggageDirect { get; set; }

                    }

                    /// <summary>
                    /// <para>The manufacturer, e.g., &quot;Airbus&quot; (may not have a value).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>空客</para>
                    /// </summary>
                    [NameInMap("manufacturer")]
                    [Validation(Required=false)]
                    public string Manufacturer { get; set; }

                    /// <summary>
                    /// <para>The meal information.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>小食</para>
                    /// </summary>
                    [NameInMap("meal_desc")]
                    [Validation(Required=false)]
                    public string MealDesc { get; set; }

                    /// <summary>
                    /// <para>The number of days crossed. 1 means the flight crosses 1 day.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("one_more")]
                    [Validation(Required=false)]
                    public int? OneMore { get; set; }

                    /// <summary>
                    /// <para>The display text for day crossing, e.g., &quot;+1 day&quot;.</para>
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
                    /// <para>The unique key of the segment, in the format: flight number + departure airport + arrival airport + departure date (MMdd). Example: KN6728HGHPKX0725.</para>
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
                    public IntlFlightOtaSearchResponseBodyModuleFlightJourneyInfosFlightSegmentInfosSegmentVisaRemark SegmentVisaRemark { get; set; }
                    public class IntlFlightOtaSearchResponseBodyModuleFlightJourneyInfosFlightSegmentInfosSegmentVisaRemark : TeaModel {
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
                        /// <para>The transit visa information for stopover cities, one per stopover city.</para>
                        /// </summary>
                        [NameInMap("stop_city_visa_remarks")]
                        [Validation(Required=false)]
                        public List<string> StopCityVisaRemarks { get; set; }

                        /// <summary>
                        /// <para>The transit visa.</para>
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
                    /// <para>The aircraft size abbreviation, e.g., &quot;M&quot; (may not have a value).</para>
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
                    /// <para>The total duration of the segment.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2小时20分</para>
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
            /// <para>The list of quoted items.</para>
            /// </summary>
            [NameInMap("item_list")]
            [Validation(Required=false)]
            public List<IntlFlightOtaSearchResponseBodyModuleItemList> ItemList { get; set; }
            public class IntlFlightOtaSearchResponseBodyModuleItemList : TeaModel {
                /// <summary>
                /// <para>The agreement price encoding. A value indicates that an agreement price is available.</para>
                /// </summary>
                [NameInMap("agreement_price_codes")]
                [Validation(Required=false)]
                public List<IntlFlightOtaSearchResponseBodyModuleItemListAgreementPriceCodes> AgreementPriceCodes { get; set; }
                public class IntlFlightOtaSearchResponseBodyModuleItemListAgreementPriceCodes : TeaModel {
                    /// <summary>
                    /// <para>The agreement price encoding.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>V5400000</para>
                    /// </summary>
                    [NameInMap("code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <para>The agreement price type. Valid values: 1: customer tripartite. 2: platform bilateral (business travel price). 3: customer bilateral.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public int? Type { get; set; }

                }

                /// <summary>
                /// <para>The item ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>e50d380fc05942cc8ac57af8ae02f448_0</para>
                /// </summary>
                [NameInMap("item_id")]
                [Validation(Required=false)]
                public string ItemId { get; set; }

                /// <summary>
                /// <para>The item type. Valid values: normal: standard item. combination: combination special fare. reliable_combination: fly-enjoy combination.</para>
                /// 
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("item_type")]
                [Validation(Required=false)]
                public string ItemType { get; set; }

                /// <summary>
                /// <para>The list of item labels.</para>
                /// </summary>
                [NameInMap("label_list")]
                [Validation(Required=false)]
                public List<IntlFlightOtaSearchResponseBodyModuleItemListLabelList> LabelList { get; set; }
                public class IntlFlightOtaSearchResponseBodyModuleItemListLabelList : TeaModel {
                    /// <summary>
                    /// <para>The label code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("labelCode")]
                    [Validation(Required=false)]
                    public int? LabelCode { get; set; }

                    /// <summary>
                    /// <para>The label name, such as &quot;Test item&quot;.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>测试商品</para>
                    /// </summary>
                    [NameInMap("labelName")]
                    [Validation(Required=false)]
                    public string LabelName { get; set; }

                }

                /// <summary>
                /// <para>The key represents the passenger type: ADT for adult, CHD for child, INFANT for infant.</para>
                /// </summary>
                [NameInMap("shopping_item_map")]
                [Validation(Required=false)]
                public Dictionary<string, ModuleItemListShoppingItemMapValue> ShoppingItemMap { get; set; }

                /// <summary>
                /// <para>The sub-items. Combined products have multiple sub-items.</para>
                /// </summary>
                [NameInMap("sub_items")]
                [Validation(Required=false)]
                public List<IntlFlightOtaSearchResponseBodyModuleItemListSubItems> SubItems { get; set; }
                public class IntlFlightOtaSearchResponseBodyModuleItemListSubItems : TeaModel {
                    /// <summary>
                    /// <para>The baggage allowance information for the sub-item.</para>
                    /// </summary>
                    [NameInMap("baggage_rule")]
                    [Validation(Required=false)]
                    public IntlFlightOtaSearchResponseBodyModuleItemListSubItemsBaggageRule BaggageRule { get; set; }
                    public class IntlFlightOtaSearchResponseBodyModuleItemListSubItemsBaggageRule : TeaModel {
                        /// <summary>
                        /// <para>The baggage summary.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>20KG免费托运行李</para>
                        /// </summary>
                        [NameInMap("baggage_digest")]
                        [Validation(Required=false)]
                        public string BaggageDigest { get; set; }

                        /// <summary>
                        /// <para>The baggage information by passenger type. Key: ADT/CHD/INF. Value: baggage information.</para>
                        /// </summary>
                        [NameInMap("offer_baggage_info_map")]
                        [Validation(Required=false)]
                        public Dictionary<string, List<ModuleItemListSubItemsBaggageRuleOfferBaggageInfoMapValue>> OfferBaggageInfoMap { get; set; }

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
                    /// <para>The refund and change rule information for the sub-item.</para>
                    /// </summary>
                    [NameInMap("refund_change_rule")]
                    [Validation(Required=false)]
                    public IntlFlightOtaSearchResponseBodyModuleItemListSubItemsRefundChangeRule RefundChangeRule { get; set; }
                    public class IntlFlightOtaSearchResponseBodyModuleItemListSubItemsRefundChangeRule : TeaModel {
                        /// <summary>
                        /// <para>Indicates whether refund is supported.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("cancel_fee_ind")]
                        [Validation(Required=false)]
                        public bool? CancelFeeInd { get; set; }

                        /// <summary>
                        /// <para>Indicates whether date change is supported.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
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
                        /// <para>The refund and change rules. Key: ADT/CHD/INF. Value: refund and change rule details.</para>
                        /// </summary>
                        [NameInMap("offer_penalty_info_map")]
                        [Validation(Required=false)]
                        public Dictionary<string, List<ModuleItemListSubItemsRefundChangeRuleOfferPenaltyInfoMapValue>> OfferPenaltyInfoMap { get; set; }

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
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("structured_refund")]
                        [Validation(Required=false)]
                        public bool? StructuredRefund { get; set; }

                    }

                    /// <summary>
                    /// <para>The segment information included in the sub-item.</para>
                    /// </summary>
                    [NameInMap("segment_keys")]
                    [Validation(Required=false)]
                    public List<string> SegmentKeys { get; set; }

                    /// <summary>
                    /// <para>The list of segment position information included in the sub-item.</para>
                    /// </summary>
                    [NameInMap("segment_position_list")]
                    [Validation(Required=false)]
                    public List<IntlFlightOtaSearchResponseBodyModuleItemListSubItemsSegmentPositionList> SegmentPositionList { get; set; }
                    public class IntlFlightOtaSearchResponseBodyModuleItemListSubItemsSegmentPositionList : TeaModel {
                        /// <summary>
                        /// <para>The journey ordinal number (starting from 0).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("journey_index")]
                        [Validation(Required=false)]
                        public int? JourneyIndex { get; set; }

                        /// <summary>
                        /// <para>The segment ordinal number (starting from 0 within the same journey).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("segment_index")]
                        [Validation(Required=false)]
                        public int? SegmentIndex { get; set; }

                    }

                    /// <summary>
                    /// <para>The key represents the passenger type: ADT for adult, CHD for child, INFANT for infant.</para>
                    /// </summary>
                    [NameInMap("shopping_item_map")]
                    [Validation(Required=false)]
                    public Dictionary<string, ModuleItemListSubItemsShoppingItemMapValue> ShoppingItemMap { get; set; }

                    /// <summary>
                    /// <para>The unique ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>07df0bd9-f803-4a50-8449-f4bd675d9939</para>
                    /// </summary>
                    [NameInMap("uniq_key")]
                    [Validation(Required=false)]
                    public string UniqKey { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B018C9F3-3311-5129-A1EF-1D1CC7124348</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The trace ID used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2150435016896473589786246e03e9</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
