// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightReShopOtaSearchResponseBody : TeaModel {
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
        /// <para>The data.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public IntlFlightReShopOtaSearchResponseBodyModule Module { get; set; }
        public class IntlFlightReShopOtaSearchResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The flight journey information.</para>
            /// </summary>
            [NameInMap("flight_journey_infos")]
            [Validation(Required=false)]
            public List<IntlFlightReShopOtaSearchResponseBodyModuleFlightJourneyInfos> FlightJourneyInfos { get; set; }
            public class IntlFlightReShopOtaSearchResponseBodyModuleFlightJourneyInfos : TeaModel {
                /// <summary>
                /// <para>The three-letter code of the arrival city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HGH</para>
                /// </summary>
                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                /// <summary>
                /// <para>The name of the arrival city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>杭州</para>
                /// </summary>
                [NameInMap("arr_city_name")]
                [Validation(Required=false)]
                public string ArrCityName { get; set; }

                /// <summary>
                /// <para>The arrival time. Format: yyyy-MM-dd HH:mm.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-12-28 15:25</para>
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
                /// <para>The name of the departure city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>北京</para>
                /// </summary>
                [NameInMap("dep_city_name")]
                [Validation(Required=false)]
                public string DepCityName { get; set; }

                /// <summary>
                /// <para>The departure time. Format: yyyy-MM-dd HH:mm.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-12-28 12:25</para>
                /// </summary>
                [NameInMap("dep_time")]
                [Validation(Required=false)]
                public string DepTime { get; set; }

                /// <summary>
                /// <para>The total duration in minutes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>180</para>
                /// </summary>
                [NameInMap("duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                /// <summary>
                /// <para>The flight segment information.</para>
                /// </summary>
                [NameInMap("flight_segment_infos")]
                [Validation(Required=false)]
                public List<IntlFlightReShopOtaSearchResponseBodyModuleFlightJourneyInfosFlightSegmentInfos> FlightSegmentInfos { get; set; }
                public class IntlFlightReShopOtaSearchResponseBodyModuleFlightJourneyInfosFlightSegmentInfos : TeaModel {
                    /// <summary>
                    /// <para>The marketing airline information.</para>
                    /// </summary>
                    [NameInMap("airline_info")]
                    [Validation(Required=false)]
                    public IntlFlightReShopOtaSearchResponseBodyModuleFlightJourneyInfosFlightSegmentInfosAirlineInfo AirlineInfo { get; set; }
                    public class IntlFlightReShopOtaSearchResponseBodyModuleFlightJourneyInfosFlightSegmentInfosAirlineInfo : TeaModel {
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
                        /// <para>Indicates whether the airline is a low-cost airline.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("cheap_airline")]
                        [Validation(Required=false)]
                        public bool? CheapAirline { get; set; }

                        /// <summary>
                        /// <para>The URL of the airline icon.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>https://</para>
                        /// </summary>
                        [NameInMap("icon_url")]
                        [Validation(Required=false)]
                        public string IconUrl { get; set; }

                        /// <summary>
                        /// <para>The short name of the airline.</para>
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
                    public IntlFlightReShopOtaSearchResponseBodyModuleFlightJourneyInfosFlightSegmentInfosArrAirportInfo ArrAirportInfo { get; set; }
                    public class IntlFlightReShopOtaSearchResponseBodyModuleFlightJourneyInfosFlightSegmentInfosArrAirportInfo : TeaModel {
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
                        /// <para>The short name of the airport.</para>
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
                    /// <para>The three-letter code of the arrival city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HGH</para>
                    /// </summary>
                    [NameInMap("arr_city_code")]
                    [Validation(Required=false)]
                    public string ArrCityCode { get; set; }

                    /// <summary>
                    /// <para>The name of the arrival city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>杭州</para>
                    /// </summary>
                    [NameInMap("arr_city_name")]
                    [Validation(Required=false)]
                    public string ArrCityName { get; set; }

                    /// <summary>
                    /// <para>The arrival time. Format: yyyy-MM-dd HH:mm.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2025-12-28 15:25</para>
                    /// </summary>
                    [NameInMap("arr_time")]
                    [Validation(Required=false)]
                    public string ArrTime { get; set; }

                    /// <summary>
                    /// <para>The arrival time with time zone. Format: 2022-06-06T12:56:34Z.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2025-12-28T15:25:34Z</para>
                    /// </summary>
                    [NameInMap("arr_time_u_t_c")]
                    [Validation(Required=false)]
                    public string ArrTimeUTC { get; set; }

                    /// <summary>
                    /// <para>The departure airport information.</para>
                    /// </summary>
                    [NameInMap("dep_airport_info")]
                    [Validation(Required=false)]
                    public IntlFlightReShopOtaSearchResponseBodyModuleFlightJourneyInfosFlightSegmentInfosDepAirportInfo DepAirportInfo { get; set; }
                    public class IntlFlightReShopOtaSearchResponseBodyModuleFlightJourneyInfosFlightSegmentInfosDepAirportInfo : TeaModel {
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
                        /// <para>The short name of the airport.</para>
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
                    /// <para>BJS</para>
                    /// </summary>
                    [NameInMap("dep_city_code")]
                    [Validation(Required=false)]
                    public string DepCityCode { get; set; }

                    /// <summary>
                    /// <para>The name of the departure city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>北京</para>
                    /// </summary>
                    [NameInMap("dep_city_name")]
                    [Validation(Required=false)]
                    public string DepCityName { get; set; }

                    /// <summary>
                    /// <para>The departure time. Format: yyyy-MM-dd HH:mm.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2025-12-28 12:25</para>
                    /// </summary>
                    [NameInMap("dep_time")]
                    [Validation(Required=false)]
                    public string DepTime { get; set; }

                    /// <summary>
                    /// <para>The departure time with time zone. Format: 2022-06-06T12:56:34Z.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2025-12-28T12:25:34Z</para>
                    /// </summary>
                    [NameInMap("dep_time_u_t_c")]
                    [Validation(Required=false)]
                    public string DepTimeUTC { get; set; }

                    /// <summary>
                    /// <para>The total duration of the segment in minutes.</para>
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
                    public IntlFlightReShopOtaSearchResponseBodyModuleFlightJourneyInfosFlightSegmentInfosFlightShareInfo FlightShareInfo { get; set; }
                    public class IntlFlightReShopOtaSearchResponseBodyModuleFlightJourneyInfosFlightSegmentInfosFlightShareInfo : TeaModel {
                        /// <summary>
                        /// <para>The operating airline information.</para>
                        /// </summary>
                        [NameInMap("operating_airline_info")]
                        [Validation(Required=false)]
                        public IntlFlightReShopOtaSearchResponseBodyModuleFlightJourneyInfosFlightSegmentInfosFlightShareInfoOperatingAirlineInfo OperatingAirlineInfo { get; set; }
                        public class IntlFlightReShopOtaSearchResponseBodyModuleFlightJourneyInfosFlightSegmentInfosFlightShareInfoOperatingAirlineInfo : TeaModel {
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
                            /// <para>Indicates whether the airline is a low-cost airline.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>false</para>
                            /// </summary>
                            [NameInMap("cheap_airline")]
                            [Validation(Required=false)]
                            public bool? CheapAirline { get; set; }

                            /// <summary>
                            /// <para>The URL of the airline icon.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>https://</para>
                            /// </summary>
                            [NameInMap("icon_url")]
                            [Validation(Required=false)]
                            public string IconUrl { get; set; }

                            /// <summary>
                            /// <para>The short name of the airline.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>国航</para>
                            /// </summary>
                            [NameInMap("short_name")]
                            [Validation(Required=false)]
                            public string ShortName { get; set; }

                        }

                        /// <summary>
                        /// <para>The operating flight number. This field has a value only for codeshare flights.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CA601</para>
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
                    /// <para>The list of flight stopovers.</para>
                    /// </summary>
                    [NameInMap("flight_stop_info_list")]
                    [Validation(Required=false)]
                    public List<IntlFlightReShopOtaSearchResponseBodyModuleFlightJourneyInfosFlightSegmentInfosFlightStopInfoList> FlightStopInfoList { get; set; }
                    public class IntlFlightReShopOtaSearchResponseBodyModuleFlightJourneyInfosFlightSegmentInfosFlightStopInfoList : TeaModel {
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
                        /// <para>The county information of the stopover airport.</para>
                        /// </summary>
                        [NameInMap("stop_airport_county_info")]
                        [Validation(Required=false)]
                        public IntlFlightReShopOtaSearchResponseBodyModuleFlightJourneyInfosFlightSegmentInfosFlightStopInfoListStopAirportCountyInfo StopAirportCountyInfo { get; set; }
                        public class IntlFlightReShopOtaSearchResponseBodyModuleFlightJourneyInfosFlightSegmentInfosFlightStopInfoListStopAirportCountyInfo : TeaModel {
                            /// <summary>
                            /// <para>The administrative division code.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>110000</para>
                            /// </summary>
                            [NameInMap("adcode")]
                            [Validation(Required=false)]
                            public string Adcode { get; set; }

                            /// <summary>
                            /// <para>The airport city code.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>BJS</para>
                            /// </summary>
                            [NameInMap("airport_city_code")]
                            [Validation(Required=false)]
                            public string AirportCityCode { get; set; }

                            /// <summary>
                            /// <para>The city name of the airport.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>北京</para>
                            /// </summary>
                            [NameInMap("airport_city_name")]
                            [Validation(Required=false)]
                            public string AirportCityName { get; set; }

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
                            /// <para>大兴机场</para>
                            /// </summary>
                            [NameInMap("airport_name")]
                            [Validation(Required=false)]
                            public string AirportName { get; set; }

                            /// <summary>
                            /// <para>The parent city name of the airport.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>北京</para>
                            /// </summary>
                            [NameInMap("airport_parent_city_name")]
                            [Validation(Required=false)]
                            public string AirportParentCityName { get; set; }

                            /// <summary>
                            /// <para>The administrative division code of the county-level city where the airport is located.</para>
                            /// <remarks>
                            /// <para>Notice: This value is null if the airport is not at the county level.</para>
                            /// </remarks>
                            /// 
                            /// <b>Example:</b>
                            /// <para>110000</para>
                            /// </summary>
                            [NameInMap("county_city_adcode")]
                            [Validation(Required=false)]
                            public string CountyCityAdcode { get; set; }

                            /// <summary>
                            /// <para>The name of the county-level city where the airport is located.</para>
                            /// <remarks>
                            /// <para>Notice: This value is null if the airport is not at the county level.</para>
                            /// </remarks>
                            /// 
                            /// <b>Example:</b>
                            /// <para>北京</para>
                            /// </summary>
                            [NameInMap("county_city_name")]
                            [Validation(Required=false)]
                            public string CountyCityName { get; set; }

                            /// <summary>
                            /// <para>The administrative division code of the prefecture-level city where the airport is located.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>110000</para>
                            /// </summary>
                            [NameInMap("prefecture_city_adcode")]
                            [Validation(Required=false)]
                            public string PrefectureCityAdcode { get; set; }

                            /// <summary>
                            /// <para>The name of the prefecture-level city where the airport is located.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>北京</para>
                            /// </summary>
                            [NameInMap("prefecture_city_name")]
                            [Validation(Required=false)]
                            public string PrefectureCityName { get; set; }

                        }

                        /// <summary>
                        /// <para>The name of the stopover airport.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>PKX</para>
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
                        /// <para>The arrival time at the stopover. Format: yyyy-MM-dd HH:mm.</para>
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
                        /// <para>T1</para>
                        /// </summary>
                        [NameInMap("stop_dep_term")]
                        [Validation(Required=false)]
                        public string StopDepTerm { get; set; }

                        /// <summary>
                        /// <para>The departure time from the stopover. Format: yyyy-MM-dd HH:mm.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2025-10-01 03:00</para>
                        /// </summary>
                        [NameInMap("stop_dep_time")]
                        [Validation(Required=false)]
                        public string StopDepTime { get; set; }

                        /// <summary>
                        /// <para>The stopover duration in minutes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>60</para>
                        /// </summary>
                        [NameInMap("stop_time")]
                        [Validation(Required=false)]
                        public string StopTime { get; set; }

                    }

                    /// <summary>
                    /// <para>The aircraft type code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>320</para>
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
                    public IntlFlightReShopOtaSearchResponseBodyModuleFlightJourneyInfosFlightSegmentInfosLuggageDirectInfo LuggageDirectInfo { get; set; }
                    public class IntlFlightReShopOtaSearchResponseBodyModuleFlightJourneyInfosFlightSegmentInfosLuggageDirectInfo : TeaModel {
                        /// <summary>
                        /// <para>The baggage transfer type for the departure city. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>0: Re-check baggage.</description></item>
                        /// <item><description>1: Through check.</description></item>
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
                        /// <para>The baggage transfer type for the departure city. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>0: Re-check baggage.</description></item>
                        /// <item><description>1: Through check.</description></item>
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
                    /// <para>The manufacturer.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>空客</para>
                    /// </summary>
                    [NameInMap("manufacturer")]
                    [Validation(Required=false)]
                    public string Manufacturer { get; set; }

                    /// <summary>
                    /// <para>The meal availability. Valid values: 0 (no meal) and 1 (meal provided).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("meal")]
                    [Validation(Required=false)]
                    public int? Meal { get; set; }

                    /// <summary>
                    /// <para>The meal description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>小食</para>
                    /// </summary>
                    [NameInMap("meal_desc")]
                    [Validation(Required=false)]
                    public string MealDesc { get; set; }

                    /// <summary>
                    /// <para>The flight mileage.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1200</para>
                    /// </summary>
                    [NameInMap("miles")]
                    [Validation(Required=false)]
                    public int? Miles { get; set; }

                    /// <summary>
                    /// <para>The on-time rate information, such as &quot;arrival on-time rate 90%&quot;.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>80%</para>
                    /// </summary>
                    [NameInMap("on_time_rate")]
                    [Validation(Required=false)]
                    public string OnTimeRate { get; set; }

                    /// <summary>
                    /// <para>The number of extra days. For example, 1 indicates the flight crosses 1 day.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("one_more")]
                    [Validation(Required=false)]
                    public int? OneMore { get; set; }

                    /// <summary>
                    /// <para>The cross-day display text.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>+1天</para>
                    /// </summary>
                    [NameInMap("one_more_show")]
                    [Validation(Required=false)]
                    public string OneMoreShow { get; set; }

                    /// <summary>
                    /// <para>The other information about the flight segment.</para>
                    /// </summary>
                    [NameInMap("other_info")]
                    [Validation(Required=false)]
                    public IntlFlightReShopOtaSearchResponseBodyModuleFlightJourneyInfosFlightSegmentInfosOtherInfo OtherInfo { get; set; }
                    public class IntlFlightReShopOtaSearchResponseBodyModuleFlightJourneyInfosFlightSegmentInfosOtherInfo : TeaModel {
                        /// <summary>
                        /// <para>The aircraft age.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2.5年</para>
                        /// </summary>
                        [NameInMap("aircraft_age")]
                        [Validation(Required=false)]
                        public string AircraftAge { get; set; }

                        /// <summary>
                        /// <para>The average delay duration.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>平均延误58分钟</para>
                        /// </summary>
                        [NameInMap("avg_delay_time")]
                        [Validation(Required=false)]
                        public string AvgDelayTime { get; set; }

                        /// <summary>
                        /// <para>The flight cancellation rate.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>20%</para>
                        /// </summary>
                        [NameInMap("flight_cancel_rate")]
                        [Validation(Required=false)]
                        public string FlightCancelRate { get; set; }

                        /// <summary>
                        /// <para>The jet bridge rate.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10%</para>
                        /// </summary>
                        [NameInMap("jet_bridge_rate")]
                        [Validation(Required=false)]
                        public string JetBridgeRate { get; set; }

                        /// <summary>
                        /// <para>The on-time rate information.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>90%</para>
                        /// </summary>
                        [NameInMap("on_time_rate")]
                        [Validation(Required=false)]
                        public string OnTimeRate { get; set; }

                        /// <summary>
                        /// <para>Indicates whether Wi-Fi is available.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("wifi")]
                        [Validation(Required=false)]
                        public bool? Wifi { get; set; }

                    }

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
                    /// <para>KN6728HGHPKX0725</para>
                    /// </summary>
                    [NameInMap("segment_key")]
                    [Validation(Required=false)]
                    public string SegmentKey { get; set; }

                    /// <summary>
                    /// <para>The transit visa information for the current segment.</para>
                    /// </summary>
                    [NameInMap("segment_visa_remark")]
                    [Validation(Required=false)]
                    public IntlFlightReShopOtaSearchResponseBodyModuleFlightJourneyInfosFlightSegmentInfosSegmentVisaRemark SegmentVisaRemark { get; set; }
                    public class IntlFlightReShopOtaSearchResponseBodyModuleFlightJourneyInfosFlightSegmentInfosSegmentVisaRemark : TeaModel {
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
                        /// <para>The transit visa information for stopover cities. Each stopover city corresponds to one entry.</para>
                        /// </summary>
                        [NameInMap("stop_city_visa_remarks")]
                        [Validation(Required=false)]
                        public List<string> StopCityVisaRemarks { get; set; }

                        /// <summary>
                        /// <para>The transit visa types for stopover cities. Each stopover city corresponds to one entry.</para>
                        /// </summary>
                        [NameInMap("stop_city_visa_types")]
                        [Validation(Required=false)]
                        public List<int?> StopCityVisaTypes { get; set; }

                    }

                    /// <summary>
                    /// <para>Indicates whether the flight is a codeshare flight.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("share")]
                    [Validation(Required=false)]
                    public bool? Share { get; set; }

                    /// <summary>
                    /// <para>The short name of the aircraft type.</para>
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
                    /// <para>The ticketing airline information.</para>
                    /// </summary>
                    [NameInMap("ticketing_airline_info")]
                    [Validation(Required=false)]
                    public IntlFlightReShopOtaSearchResponseBodyModuleFlightJourneyInfosFlightSegmentInfosTicketingAirlineInfo TicketingAirlineInfo { get; set; }
                    public class IntlFlightReShopOtaSearchResponseBodyModuleFlightJourneyInfosFlightSegmentInfosTicketingAirlineInfo : TeaModel {
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
                        /// <para>Indicates whether the airline is a low-cost airline.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("cheap_airline")]
                        [Validation(Required=false)]
                        public bool? CheapAirline { get; set; }

                        /// <summary>
                        /// <para>The URL of the airline icon.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>https://</para>
                        /// </summary>
                        [NameInMap("icon_url")]
                        [Validation(Required=false)]
                        public string IconUrl { get; set; }

                        /// <summary>
                        /// <para>The short name of the airline.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>国航</para>
                        /// </summary>
                        [NameInMap("short_name")]
                        [Validation(Required=false)]
                        public string ShortName { get; set; }

                    }

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
            /// <para>是否需要继续轮询</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("need_continue")]
            [Validation(Required=false)]
            public bool? NeedContinue { get; set; }

            /// <summary>
            /// <para>下次搜索等待时间，单位毫秒</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("next_req_wait_time")]
            [Validation(Required=false)]
            public int? NextReqWaitTime { get; set; }

            /// <summary>
            /// <para>The list of quoted items.</para>
            /// </summary>
            [NameInMap("re_shop_item_list")]
            [Validation(Required=false)]
            public List<IntlFlightReShopOtaSearchResponseBodyModuleReShopItemList> ReShopItemList { get; set; }
            public class IntlFlightReShopOtaSearchResponseBodyModuleReShopItemList : TeaModel {
                /// <summary>
                /// <para>The item ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2b99a126923d4d13be53cd80a32ef0e3_0</para>
                /// </summary>
                [NameInMap("item_id")]
                [Validation(Required=false)]
                public string ItemId { get; set; }

                /// <summary>
                /// <para>商品类型。</para>
                /// <list type="bullet">
                /// <item><description>normal-普通商品</description></item>
                /// <item><description>combination-组合特价</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("item_type")]
                [Validation(Required=false)]
                public string ItemType { get; set; }

                /// <summary>
                /// <para>The pricing information mapped by passenger type.</para>
                /// </summary>
                [NameInMap("shopping_item_map")]
                [Validation(Required=false)]
                public Dictionary<string, ModuleReShopItemListShoppingItemMapValue> ShoppingItemMap { get; set; }

                /// <summary>
                /// <para>The sub-items. Combined products may have multiple sub-items.</para>
                /// </summary>
                [NameInMap("sub_items")]
                [Validation(Required=false)]
                public List<IntlFlightReShopOtaSearchResponseBodyModuleReShopItemListSubItems> SubItems { get; set; }
                public class IntlFlightReShopOtaSearchResponseBodyModuleReShopItemListSubItems : TeaModel {
                    /// <summary>
                    /// <para>The baggage allowance information of the sub-item.</para>
                    /// </summary>
                    [NameInMap("baggage_rule")]
                    [Validation(Required=false)]
                    public IntlFlightReShopOtaSearchResponseBodyModuleReShopItemListSubItemsBaggageRule BaggageRule { get; set; }
                    public class IntlFlightReShopOtaSearchResponseBodyModuleReShopItemListSubItemsBaggageRule : TeaModel {
                        /// <summary>
                        /// <para>The display color of the baggage allowance description.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>行李额描述展示颜色</para>
                        /// </summary>
                        [NameInMap("baggage_desc_show_color")]
                        [Validation(Required=false)]
                        public string BaggageDescShowColor { get; set; }

                        /// <summary>
                        /// <para>The baggage summary.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>无托运行李</para>
                        /// </summary>
                        [NameInMap("baggage_digest")]
                        [Validation(Required=false)]
                        public string BaggageDigest { get; set; }

                        /// <summary>
                        /// <para>The baggage rule description.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>以航司规定为准</para>
                        /// </summary>
                        [NameInMap("baggage_rule_desc")]
                        [Validation(Required=false)]
                        public string BaggageRuleDesc { get; set; }

                        /// <summary>
                        /// <para>The baggage information mapped by passenger type. Key: ADT/CHD/INF. Value: baggage information.</para>
                        /// </summary>
                        [NameInMap("offer_baggage_info_map")]
                        [Validation(Required=false)]
                        public Dictionary<string, List<ModuleReShopItemListSubItemsBaggageRuleOfferBaggageInfoMapValue>> OfferBaggageInfoMap { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the baggage data is structured.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("structured_baggage")]
                        [Validation(Required=false)]
                        public bool? StructuredBaggage { get; set; }

                    }

                    /// <summary>
                    /// <para>The discount value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5.1</para>
                    /// </summary>
                    [NameInMap("discount_num")]
                    [Validation(Required=false)]
                    public double? DiscountNum { get; set; }

                    /// <summary>
                    /// <para>The refund and change information of the sub-item.</para>
                    /// </summary>
                    [NameInMap("refund_change_rule")]
                    [Validation(Required=false)]
                    public IntlFlightReShopOtaSearchResponseBodyModuleReShopItemListSubItemsRefundChangeRule RefundChangeRule { get; set; }
                    public class IntlFlightReShopOtaSearchResponseBodyModuleReShopItemListSubItemsRefundChangeRule : TeaModel {
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
                        /// <para>改签规则简述</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>改签规则简述</para>
                        /// </summary>
                        [NameInMap("change_rule_desc")]
                        [Validation(Required=false)]
                        public string ChangeRuleDesc { get; set; }

                        /// <summary>
                        /// <para>改签规则展示颜色</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>改签规则展示颜色</para>
                        /// </summary>
                        [NameInMap("change_rule_show_color")]
                        [Validation(Required=false)]
                        public string ChangeRuleShowColor { get; set; }

                        /// <summary>
                        /// <para>The refund and change rules mapped by passenger type. Key: ADT/CHD/INF. Value: refund/change rule.</para>
                        /// </summary>
                        [NameInMap("offer_penalty_info_map")]
                        [Validation(Required=false)]
                        public Dictionary<string, List<ModuleReShopItemListSubItemsRefundChangeRuleOfferPenaltyInfoMapValue>> OfferPenaltyInfoMap { get; set; }

                        /// <summary>
                        /// <para>The refund and change summary.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>退改¥395起</para>
                        /// </summary>
                        [NameInMap("refund_change_digest")]
                        [Validation(Required=false)]
                        public string RefundChangeDigest { get; set; }

                        /// <summary>
                        /// <para>The refund and change rule description.
                        /// [_single.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>以航司规定为准</para>
                        /// </summary>
                        [NameInMap("refund_change_rule_desc")]
                        [Validation(Required=false)]
                        public string RefundChangeRuleDesc { get; set; }

                        /// <summary>
                        /// <para>退票规则简述</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>退票规则简述</para>
                        /// </summary>
                        [NameInMap("refund_rule_desc")]
                        [Validation(Required=false)]
                        public string RefundRuleDesc { get; set; }

                        /// <summary>
                        /// <para>退票规则展示颜色</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>退票规则展示颜色</para>
                        /// </summary>
                        [NameInMap("refund_rule_show_color")]
                        [Validation(Required=false)]
                        public string RefundRuleShowColor { get; set; }

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
                    /// <para>The list of segment keys included in the sub-item.</para>
                    /// </summary>
                    [NameInMap("segment_keys")]
                    [Validation(Required=false)]
                    public List<string> SegmentKeys { get; set; }

                    /// <summary>
                    /// <para>The list of segment position information included in the sub-item.</para>
                    /// </summary>
                    [NameInMap("segment_position_list")]
                    [Validation(Required=false)]
                    public List<IntlFlightReShopOtaSearchResponseBodyModuleReShopItemListSubItemsSegmentPositionList> SegmentPositionList { get; set; }
                    public class IntlFlightReShopOtaSearchResponseBodyModuleReShopItemListSubItemsSegmentPositionList : TeaModel {
                        /// <summary>
                        /// <para>The journey ordinal number, starting from 0.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("journey_index")]
                        [Validation(Required=false)]
                        public int? JourneyIndex { get; set; }

                        /// <summary>
                        /// <para>The segment ordinal number, starting from 0 within the same journey.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("segment_index")]
                        [Validation(Required=false)]
                        public int? SegmentIndex { get; set; }

                    }

                    /// <summary>
                    /// <para>The pricing information mapped by passenger type. Key: ADT (adult), CHD (child), or INFANT (infant).</para>
                    /// </summary>
                    [NameInMap("shopping_item_map")]
                    [Validation(Required=false)]
                    public Dictionary<string, ModuleReShopItemListSubItemsShoppingItemMapValue> ShoppingItemMap { get; set; }

                    /// <summary>
                    /// <para>The unique item ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>07df0bd9-f803-4a50-8449-f4bd675d9939</para>
                    /// </summary>
                    [NameInMap("uniq_key")]
                    [Validation(Required=false)]
                    public string UniqKey { get; set; }

                }

            }

            /// <summary>
            /// <para>The query record token used for external polling.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0305b8203a7767626f911d97a91a9473</para>
            /// </summary>
            [NameInMap("token")]
            [Validation(Required=false)]
            public string Token { get; set; }

        }

        /// <summary>
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>407543AF-2BD9-5890-BD92-9D1AB7218B27</para>
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
        /// <para>The global trace ID of the request, typically used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>210bc4b116835992457938931db4de</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
