// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightReShopDetailResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public IntlFlightReShopDetailResponseBodyModule Module { get; set; }
        public class IntlFlightReShopDetailResponseBodyModule : TeaModel {
            [NameInMap("baggage_rule")]
            [Validation(Required=false)]
            public IntlFlightReShopDetailResponseBodyModuleBaggageRule BaggageRule { get; set; }
            public class IntlFlightReShopDetailResponseBodyModuleBaggageRule : TeaModel {
                [NameInMap("baggage_rule_desc")]
                [Validation(Required=false)]
                public string BaggageRuleDesc { get; set; }

            }

            [NameInMap("close_reason")]
            [Validation(Required=false)]
            public string CloseReason { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-03-06 15:00:35</para>
            /// </summary>
            [NameInMap("close_time")]
            [Validation(Required=false)]
            public string CloseTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("close_type")]
            [Validation(Required=false)]
            public int? CloseType { get; set; }

            [NameInMap("journey_list")]
            [Validation(Required=false)]
            public List<IntlFlightReShopDetailResponseBodyModuleJourneyList> JourneyList { get; set; }
            public class IntlFlightReShopDetailResponseBodyModuleJourneyList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>HKG</para>
                /// </summary>
                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                [NameInMap("arr_city_name")]
                [Validation(Required=false)]
                public string ArrCityName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-01-01 02:00</para>
                /// </summary>
                [NameInMap("arr_time")]
                [Validation(Required=false)]
                public string ArrTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>BJS</para>
                /// </summary>
                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                [NameInMap("dep_city_name")]
                [Validation(Required=false)]
                public string DepCityName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-01-01 01:00</para>
                /// </summary>
                [NameInMap("dep_time")]
                [Validation(Required=false)]
                public string DepTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                [NameInMap("flight_segment_infos")]
                [Validation(Required=false)]
                public List<IntlFlightReShopDetailResponseBodyModuleJourneyListFlightSegmentInfos> FlightSegmentInfos { get; set; }
                public class IntlFlightReShopDetailResponseBodyModuleJourneyListFlightSegmentInfos : TeaModel {
                    [NameInMap("airline_info")]
                    [Validation(Required=false)]
                    public IntlFlightReShopDetailResponseBodyModuleJourneyListFlightSegmentInfosAirlineInfo AirlineInfo { get; set; }
                    public class IntlFlightReShopDetailResponseBodyModuleJourneyListFlightSegmentInfosAirlineInfo : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>NS</para>
                        /// </summary>
                        [NameInMap("airline_code")]
                        [Validation(Required=false)]
                        public string AirlineCode { get; set; }

                        [NameInMap("airline_name")]
                        [Validation(Required=false)]
                        public string AirlineName { get; set; }

                        [NameInMap("short_name")]
                        [Validation(Required=false)]
                        public string ShortName { get; set; }

                    }

                    [NameInMap("arr_airport_info")]
                    [Validation(Required=false)]
                    public IntlFlightReShopDetailResponseBodyModuleJourneyListFlightSegmentInfosArrAirportInfo ArrAirportInfo { get; set; }
                    public class IntlFlightReShopDetailResponseBodyModuleJourneyListFlightSegmentInfosArrAirportInfo : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>DLC</para>
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
                        /// <para>T1</para>
                        /// </summary>
                        [NameInMap("terminal")]
                        [Validation(Required=false)]
                        public string Terminal { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>HKG</para>
                    /// </summary>
                    [NameInMap("arr_city_code")]
                    [Validation(Required=false)]
                    public string ArrCityCode { get; set; }

                    [NameInMap("arr_city_name")]
                    [Validation(Required=false)]
                    public string ArrCityName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2025-01-01 02:00</para>
                    /// </summary>
                    [NameInMap("arr_time")]
                    [Validation(Required=false)]
                    public string ArrTime { get; set; }

                    [NameInMap("dep_airport_info")]
                    [Validation(Required=false)]
                    public IntlFlightReShopDetailResponseBodyModuleJourneyListFlightSegmentInfosDepAirportInfo DepAirportInfo { get; set; }
                    public class IntlFlightReShopDetailResponseBodyModuleJourneyListFlightSegmentInfosDepAirportInfo : TeaModel {
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
                        /// <para>T1</para>
                        /// </summary>
                        [NameInMap("terminal")]
                        [Validation(Required=false)]
                        public string Terminal { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>BJS</para>
                    /// </summary>
                    [NameInMap("dep_city_code")]
                    [Validation(Required=false)]
                    public string DepCityCode { get; set; }

                    [NameInMap("dep_city_name")]
                    [Validation(Required=false)]
                    public string DepCityName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2025-01-01 01:00</para>
                    /// </summary>
                    [NameInMap("dep_time")]
                    [Validation(Required=false)]
                    public string DepTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>130</para>
                    /// </summary>
                    [NameInMap("duration")]
                    [Validation(Required=false)]
                    public int? Duration { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>NS8210</para>
                    /// </summary>
                    [NameInMap("flight_no")]
                    [Validation(Required=false)]
                    public string FlightNo { get; set; }

                    [NameInMap("flight_share_info")]
                    [Validation(Required=false)]
                    public IntlFlightReShopDetailResponseBodyModuleJourneyListFlightSegmentInfosFlightShareInfo FlightShareInfo { get; set; }
                    public class IntlFlightReShopDetailResponseBodyModuleJourneyListFlightSegmentInfosFlightShareInfo : TeaModel {
                        [NameInMap("operating_airline_info")]
                        [Validation(Required=false)]
                        public IntlFlightReShopDetailResponseBodyModuleJourneyListFlightSegmentInfosFlightShareInfoOperatingAirlineInfo OperatingAirlineInfo { get; set; }
                        public class IntlFlightReShopDetailResponseBodyModuleJourneyListFlightSegmentInfosFlightShareInfoOperatingAirlineInfo : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>CA</para>
                            /// </summary>
                            [NameInMap("airline_code")]
                            [Validation(Required=false)]
                            public string AirlineCode { get; set; }

                            [NameInMap("airline_name")]
                            [Validation(Required=false)]
                            public string AirlineName { get; set; }

                            [NameInMap("short_name")]
                            [Validation(Required=false)]
                            public string ShortName { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>CA1234</para>
                        /// </summary>
                        [NameInMap("operating_flight_no")]
                        [Validation(Required=false)]
                        public string OperatingFlightNo { get; set; }

                    }

                    [NameInMap("flight_size")]
                    [Validation(Required=false)]
                    public string FlightSize { get; set; }

                    [NameInMap("flight_stop_info_list")]
                    [Validation(Required=false)]
                    public List<IntlFlightReShopDetailResponseBodyModuleJourneyListFlightSegmentInfosFlightStopInfoList> FlightStopInfoList { get; set; }
                    public class IntlFlightReShopDetailResponseBodyModuleJourneyListFlightSegmentInfosFlightStopInfoList : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>PEK</para>
                        /// </summary>
                        [NameInMap("stop_airport")]
                        [Validation(Required=false)]
                        public string StopAirport { get; set; }

                        [NameInMap("stop_airport_name")]
                        [Validation(Required=false)]
                        public string StopAirportName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>T3</para>
                        /// </summary>
                        [NameInMap("stop_arr_term")]
                        [Validation(Required=false)]
                        public string StopArrTerm { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2024-01-01 05:00</para>
                        /// </summary>
                        [NameInMap("stop_arr_time")]
                        [Validation(Required=false)]
                        public string StopArrTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>BJS</para>
                        /// </summary>
                        [NameInMap("stop_city_code")]
                        [Validation(Required=false)]
                        public string StopCityCode { get; set; }

                        [NameInMap("stop_city_name")]
                        [Validation(Required=false)]
                        public string StopCityName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>T2</para>
                        /// </summary>
                        [NameInMap("stop_dep_term")]
                        [Validation(Required=false)]
                        public string StopDepTerm { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2024-01-01 07:00</para>
                        /// </summary>
                        [NameInMap("stop_dep_time")]
                        [Validation(Required=false)]
                        public string StopDepTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>120</para>
                        /// </summary>
                        [NameInMap("stop_time")]
                        [Validation(Required=false)]
                        public string StopTime { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>737</para>
                    /// </summary>
                    [NameInMap("flight_type")]
                    [Validation(Required=false)]
                    public string FlightType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("journey_index")]
                    [Validation(Required=false)]
                    public int? JourneyIndex { get; set; }

                    [NameInMap("luggage_direct_info")]
                    [Validation(Required=false)]
                    public IntlFlightReShopDetailResponseBodyModuleJourneyListFlightSegmentInfosLuggageDirectInfo LuggageDirectInfo { get; set; }
                    public class IntlFlightReShopDetailResponseBodyModuleJourneyListFlightSegmentInfosLuggageDirectInfo : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("dep_city_luggage_direct")]
                        [Validation(Required=false)]
                        public int? DepCityLuggageDirect { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("stop_city_luggage_direct")]
                        [Validation(Required=false)]
                        public int? StopCityLuggageDirect { get; set; }

                    }

                    [NameInMap("manufacturer")]
                    [Validation(Required=false)]
                    public string Manufacturer { get; set; }

                    [NameInMap("meal_desc")]
                    [Validation(Required=false)]
                    public string MealDesc { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("one_more")]
                    [Validation(Required=false)]
                    public int? OneMore { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <list type="bullet">
                    /// <item><description></description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("one_more_show")]
                    [Validation(Required=false)]
                    public string OneMoreShow { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("segment_index")]
                    [Validation(Required=false)]
                    public int? SegmentIndex { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>NS8210XIYHGH0501</para>
                    /// </summary>
                    [NameInMap("segment_key")]
                    [Validation(Required=false)]
                    public string SegmentKey { get; set; }

                    [NameInMap("segment_visa_remark")]
                    [Validation(Required=false)]
                    public IntlFlightReShopDetailResponseBodyModuleJourneyListFlightSegmentInfosSegmentVisaRemark SegmentVisaRemark { get; set; }
                    public class IntlFlightReShopDetailResponseBodyModuleJourneyListFlightSegmentInfosSegmentVisaRemark : TeaModel {
                        [NameInMap("dep_city_visa_remark")]
                        [Validation(Required=false)]
                        public string DepCityVisaRemark { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("dep_city_visa_type")]
                        [Validation(Required=false)]
                        public int? DepCityVisaType { get; set; }

                        [NameInMap("stop_city_visa_remarks")]
                        [Validation(Required=false)]
                        public List<string> StopCityVisaRemarks { get; set; }

                        [NameInMap("stop_city_visa_types")]
                        [Validation(Required=false)]
                        public List<int?> StopCityVisaTypes { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("share")]
                    [Validation(Required=false)]
                    public bool? Share { get; set; }

                    [NameInMap("short_flight_size")]
                    [Validation(Required=false)]
                    public string ShortFlightSize { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("stop")]
                    [Validation(Required=false)]
                    public bool? Stop { get; set; }

                    [NameInMap("total_time")]
                    [Validation(Required=false)]
                    public string TotalTime { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("journey_index")]
                [Validation(Required=false)]
                public int? JourneyIndex { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("transfer_time")]
                [Validation(Required=false)]
                public int? TransferTime { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1017124195788186048</para>
            /// </summary>
            [NameInMap("order_id")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

            [NameInMap("origin_journey_list")]
            [Validation(Required=false)]
            public List<IntlFlightReShopDetailResponseBodyModuleOriginJourneyList> OriginJourneyList { get; set; }
            public class IntlFlightReShopDetailResponseBodyModuleOriginJourneyList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>HKG</para>
                /// </summary>
                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                [NameInMap("arr_city_name")]
                [Validation(Required=false)]
                public string ArrCityName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-01-01 02:00</para>
                /// </summary>
                [NameInMap("arr_time")]
                [Validation(Required=false)]
                public string ArrTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>BJS</para>
                /// </summary>
                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                [NameInMap("dep_city_name")]
                [Validation(Required=false)]
                public string DepCityName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-01-01 01:00</para>
                /// </summary>
                [NameInMap("dep_time")]
                [Validation(Required=false)]
                public string DepTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                [NameInMap("flight_segment_infos")]
                [Validation(Required=false)]
                public List<IntlFlightReShopDetailResponseBodyModuleOriginJourneyListFlightSegmentInfos> FlightSegmentInfos { get; set; }
                public class IntlFlightReShopDetailResponseBodyModuleOriginJourneyListFlightSegmentInfos : TeaModel {
                    [NameInMap("airline_info")]
                    [Validation(Required=false)]
                    public IntlFlightReShopDetailResponseBodyModuleOriginJourneyListFlightSegmentInfosAirlineInfo AirlineInfo { get; set; }
                    public class IntlFlightReShopDetailResponseBodyModuleOriginJourneyListFlightSegmentInfosAirlineInfo : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>CA</para>
                        /// </summary>
                        [NameInMap("airline_code")]
                        [Validation(Required=false)]
                        public string AirlineCode { get; set; }

                        [NameInMap("airline_name")]
                        [Validation(Required=false)]
                        public string AirlineName { get; set; }

                        [NameInMap("short_name")]
                        [Validation(Required=false)]
                        public string ShortName { get; set; }

                    }

                    [NameInMap("arr_airport_info")]
                    [Validation(Required=false)]
                    public IntlFlightReShopDetailResponseBodyModuleOriginJourneyListFlightSegmentInfosArrAirportInfo ArrAirportInfo { get; set; }
                    public class IntlFlightReShopDetailResponseBodyModuleOriginJourneyListFlightSegmentInfosArrAirportInfo : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>HKG</para>
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
                    /// <para>HKG</para>
                    /// </summary>
                    [NameInMap("arr_city_code")]
                    [Validation(Required=false)]
                    public string ArrCityCode { get; set; }

                    [NameInMap("arr_city_name")]
                    [Validation(Required=false)]
                    public string ArrCityName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2023-08-13 09:25</para>
                    /// </summary>
                    [NameInMap("arr_time")]
                    [Validation(Required=false)]
                    public string ArrTime { get; set; }

                    [NameInMap("dep_airport_info")]
                    [Validation(Required=false)]
                    public IntlFlightReShopDetailResponseBodyModuleOriginJourneyListFlightSegmentInfosDepAirportInfo DepAirportInfo { get; set; }
                    public class IntlFlightReShopDetailResponseBodyModuleOriginJourneyListFlightSegmentInfosDepAirportInfo : TeaModel {
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
                        /// <para>T1</para>
                        /// </summary>
                        [NameInMap("terminal")]
                        [Validation(Required=false)]
                        public string Terminal { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>BJS</para>
                    /// </summary>
                    [NameInMap("dep_city_code")]
                    [Validation(Required=false)]
                    public string DepCityCode { get; set; }

                    [NameInMap("dep_city_name")]
                    [Validation(Required=false)]
                    public string DepCityName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2023-08-13 07:25</para>
                    /// </summary>
                    [NameInMap("dep_time")]
                    [Validation(Required=false)]
                    public string DepTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>120</para>
                    /// </summary>
                    [NameInMap("duration")]
                    [Validation(Required=false)]
                    public int? Duration { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>NS8210</para>
                    /// </summary>
                    [NameInMap("flight_no")]
                    [Validation(Required=false)]
                    public string FlightNo { get; set; }

                    [NameInMap("flight_share_info")]
                    [Validation(Required=false)]
                    public IntlFlightReShopDetailResponseBodyModuleOriginJourneyListFlightSegmentInfosFlightShareInfo FlightShareInfo { get; set; }
                    public class IntlFlightReShopDetailResponseBodyModuleOriginJourneyListFlightSegmentInfosFlightShareInfo : TeaModel {
                        [NameInMap("operating_airline_info")]
                        [Validation(Required=false)]
                        public IntlFlightReShopDetailResponseBodyModuleOriginJourneyListFlightSegmentInfosFlightShareInfoOperatingAirlineInfo OperatingAirlineInfo { get; set; }
                        public class IntlFlightReShopDetailResponseBodyModuleOriginJourneyListFlightSegmentInfosFlightShareInfoOperatingAirlineInfo : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>MU</para>
                            /// </summary>
                            [NameInMap("airline_code")]
                            [Validation(Required=false)]
                            public string AirlineCode { get; set; }

                            [NameInMap("airline_name")]
                            [Validation(Required=false)]
                            public string AirlineName { get; set; }

                            [NameInMap("short_name")]
                            [Validation(Required=false)]
                            public string ShortName { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>CA0001</para>
                        /// </summary>
                        [NameInMap("operating_flight_no")]
                        [Validation(Required=false)]
                        public string OperatingFlightNo { get; set; }

                    }

                    [NameInMap("flight_size")]
                    [Validation(Required=false)]
                    public string FlightSize { get; set; }

                    [NameInMap("flight_stop_info_list")]
                    [Validation(Required=false)]
                    public List<IntlFlightReShopDetailResponseBodyModuleOriginJourneyListFlightSegmentInfosFlightStopInfoList> FlightStopInfoList { get; set; }
                    public class IntlFlightReShopDetailResponseBodyModuleOriginJourneyListFlightSegmentInfosFlightStopInfoList : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>HGH</para>
                        /// </summary>
                        [NameInMap("stop_airport")]
                        [Validation(Required=false)]
                        public string StopAirport { get; set; }

                        [NameInMap("stop_airport_name")]
                        [Validation(Required=false)]
                        public string StopAirportName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>T1</para>
                        /// </summary>
                        [NameInMap("stop_arr_term")]
                        [Validation(Required=false)]
                        public string StopArrTerm { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2023-08-13 07:25</para>
                        /// </summary>
                        [NameInMap("stop_arr_time")]
                        [Validation(Required=false)]
                        public string StopArrTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>HGH</para>
                        /// </summary>
                        [NameInMap("stop_city_code")]
                        [Validation(Required=false)]
                        public string StopCityCode { get; set; }

                        [NameInMap("stop_city_name")]
                        [Validation(Required=false)]
                        public string StopCityName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>T1</para>
                        /// </summary>
                        [NameInMap("stop_dep_term")]
                        [Validation(Required=false)]
                        public string StopDepTerm { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2023-08-13 09:25</para>
                        /// </summary>
                        [NameInMap("stop_dep_time")]
                        [Validation(Required=false)]
                        public string StopDepTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>20</para>
                        /// </summary>
                        [NameInMap("stop_time")]
                        [Validation(Required=false)]
                        public string StopTime { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>738</para>
                    /// </summary>
                    [NameInMap("flight_type")]
                    [Validation(Required=false)]
                    public string FlightType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("journey_index")]
                    [Validation(Required=false)]
                    public int? JourneyIndex { get; set; }

                    [NameInMap("luggage_direct_info")]
                    [Validation(Required=false)]
                    public IntlFlightReShopDetailResponseBodyModuleOriginJourneyListFlightSegmentInfosLuggageDirectInfo LuggageDirectInfo { get; set; }
                    public class IntlFlightReShopDetailResponseBodyModuleOriginJourneyListFlightSegmentInfosLuggageDirectInfo : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("dep_city_luggage_direct")]
                        [Validation(Required=false)]
                        public int? DepCityLuggageDirect { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("stop_city_luggage_direct")]
                        [Validation(Required=false)]
                        public int? StopCityLuggageDirect { get; set; }

                    }

                    [NameInMap("manufacturer")]
                    [Validation(Required=false)]
                    public string Manufacturer { get; set; }

                    [NameInMap("meal_desc")]
                    [Validation(Required=false)]
                    public string MealDesc { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("one_more")]
                    [Validation(Required=false)]
                    public int? OneMore { get; set; }

                    [NameInMap("one_more_show")]
                    [Validation(Required=false)]
                    public string OneMoreShow { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("segment_index")]
                    [Validation(Required=false)]
                    public int? SegmentIndex { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>NS8210XIYHGH0501</para>
                    /// </summary>
                    [NameInMap("segment_key")]
                    [Validation(Required=false)]
                    public string SegmentKey { get; set; }

                    [NameInMap("segment_visa_remark")]
                    [Validation(Required=false)]
                    public IntlFlightReShopDetailResponseBodyModuleOriginJourneyListFlightSegmentInfosSegmentVisaRemark SegmentVisaRemark { get; set; }
                    public class IntlFlightReShopDetailResponseBodyModuleOriginJourneyListFlightSegmentInfosSegmentVisaRemark : TeaModel {
                        [NameInMap("dep_city_visa_remark")]
                        [Validation(Required=false)]
                        public string DepCityVisaRemark { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("dep_city_visa_type")]
                        [Validation(Required=false)]
                        public int? DepCityVisaType { get; set; }

                        [NameInMap("stop_city_visa_remarks")]
                        [Validation(Required=false)]
                        public List<string> StopCityVisaRemarks { get; set; }

                        [NameInMap("stop_city_visa_types")]
                        [Validation(Required=false)]
                        public List<int?> StopCityVisaTypes { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("share")]
                    [Validation(Required=false)]
                    public bool? Share { get; set; }

                    [NameInMap("short_flight_size")]
                    [Validation(Required=false)]
                    public string ShortFlightSize { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("stop")]
                    [Validation(Required=false)]
                    public bool? Stop { get; set; }

                    [NameInMap("total_time")]
                    [Validation(Required=false)]
                    public string TotalTime { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("journey_index")]
                [Validation(Required=false)]
                public int? JourneyIndex { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("transfer_time")]
                [Validation(Required=false)]
                public int? TransferTime { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>F11552194294228713472</para>
            /// </summary>
            [NameInMap("out_order_id")]
            [Validation(Required=false)]
            public string OutOrderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>JPM20241024354</para>
            /// </summary>
            [NameInMap("out_re_shop_apply_id")]
            [Validation(Required=false)]
            public string OutReShopApplyId { get; set; }

            [NameInMap("passenger_list")]
            [Validation(Required=false)]
            public List<IntlFlightReShopDetailResponseBodyModulePassengerList> PassengerList { get; set; }
            public class IntlFlightReShopDetailResponseBodyModulePassengerList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>ZHANG/SAN</para>
                /// </summary>
                [NameInMap("full_name")]
                [Validation(Required=false)]
                public string FullName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("gender")]
                [Validation(Required=false)]
                public int? Gender { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>76230022</para>
                /// </summary>
                [NameInMap("job_no")]
                [Validation(Required=false)]
                public string JobNo { get; set; }

                [NameInMap("nationality")]
                [Validation(Required=false)]
                public string Nationality { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CN</para>
                /// </summary>
                [NameInMap("nationality_code")]
                [Validation(Required=false)]
                public string NationalityCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8432002</para>
                /// </summary>
                [NameInMap("passenger_id")]
                [Validation(Required=false)]
                public long? PassengerId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>btrip8432002</para>
                /// </summary>
                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("user_type")]
                [Validation(Required=false)]
                public int? UserType { get; set; }

            }

            [NameInMap("passenger_price_info_list")]
            [Validation(Required=false)]
            public List<IntlFlightReShopDetailResponseBodyModulePassengerPriceInfoList> PassengerPriceInfoList { get; set; }
            public class IntlFlightReShopDetailResponseBodyModulePassengerPriceInfoList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>100001</para>
                /// </summary>
                [NameInMap("passenger_id")]
                [Validation(Required=false)]
                public long? PassengerId { get; set; }

                [NameInMap("price_info")]
                [Validation(Required=false)]
                public IntlFlightReShopDetailResponseBodyModulePassengerPriceInfoListPriceInfo PriceInfo { get; set; }
                public class IntlFlightReShopDetailResponseBodyModulePassengerPriceInfoListPriceInfo : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>4000</para>
                    /// </summary>
                    [NameInMap("handling_amount")]
                    [Validation(Required=false)]
                    public long? HandlingAmount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("tax_diff_amount")]
                    [Validation(Required=false)]
                    public long? TaxDiffAmount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>125000</para>
                    /// </summary>
                    [NameInMap("total_amount")]
                    [Validation(Required=false)]
                    public long? TotalAmount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2000</para>
                    /// </summary>
                    [NameInMap("upgrade_amount")]
                    [Validation(Required=false)]
                    public long? UpgradeAmount { get; set; }

                }

            }

            [NameInMap("passenger_ticket_list")]
            [Validation(Required=false)]
            public List<IntlFlightReShopDetailResponseBodyModulePassengerTicketList> PassengerTicketList { get; set; }
            public class IntlFlightReShopDetailResponseBodyModulePassengerTicketList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2345678</para>
                /// </summary>
                [NameInMap("passenger_id")]
                [Validation(Required=false)]
                public long? PassengerId { get; set; }

                [NameInMap("ticket_list")]
                [Validation(Required=false)]
                public List<IntlFlightReShopDetailResponseBodyModulePassengerTicketListTicketList> TicketList { get; set; }
                public class IntlFlightReShopDetailResponseBodyModulePassengerTicketListTicketList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2025-01-01 00:00:09</para>
                    /// </summary>
                    [NameInMap("issue_time")]
                    [Validation(Required=false)]
                    public string IssueTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>P123456</para>
                    /// </summary>
                    [NameInMap("pnr_no")]
                    [Validation(Required=false)]
                    public string PnrNo { get; set; }

                    [NameInMap("segment_key_list")]
                    [Validation(Required=false)]
                    public List<string> SegmentKeyList { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>781-9574833593</para>
                    /// </summary>
                    [NameInMap("ticket_no")]
                    [Validation(Required=false)]
                    public string TicketNo { get; set; }

                    [NameInMap("ticket_segment_list")]
                    [Validation(Required=false)]
                    public List<IntlFlightReShopDetailResponseBodyModulePassengerTicketListTicketListTicketSegmentList> TicketSegmentList { get; set; }
                    public class IntlFlightReShopDetailResponseBodyModulePassengerTicketListTicketListTicketSegmentList : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>G</para>
                        /// </summary>
                        [NameInMap("cabin")]
                        [Validation(Required=false)]
                        public string Cabin { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Y</para>
                        /// </summary>
                        [NameInMap("cabin_class")]
                        [Validation(Required=false)]
                        public string CabinClass { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("modified")]
                        [Validation(Required=false)]
                        public bool? Modified { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>OPEN_FOR_USE</para>
                        /// </summary>
                        [NameInMap("open_ticket_status")]
                        [Validation(Required=false)]
                        public string OpenTicketStatus { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("refunded")]
                        [Validation(Required=false)]
                        public bool? Refunded { get; set; }

                        /// <summary>
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
            /// <b>Example:</b>
            /// <para>2024-03-06 15:35:00</para>
            /// </summary>
            [NameInMap("pay_latest_time")]
            [Validation(Required=false)]
            public string PayLatestTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("pay_status")]
            [Validation(Required=false)]
            public int? PayStatus { get; set; }

            [NameInMap("price_info")]
            [Validation(Required=false)]
            public IntlFlightReShopDetailResponseBodyModulePriceInfo PriceInfo { get; set; }
            public class IntlFlightReShopDetailResponseBodyModulePriceInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>4000</para>
                /// </summary>
                [NameInMap("handling_amount")]
                [Validation(Required=false)]
                public long? HandlingAmount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("tax_diff_amount")]
                [Validation(Required=false)]
                public long? TaxDiffAmount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>125000</para>
                /// </summary>
                [NameInMap("total_amount")]
                [Validation(Required=false)]
                public long? TotalAmount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2000</para>
                /// </summary>
                [NameInMap("upgrade_amount")]
                [Validation(Required=false)]
                public long? UpgradeAmount { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1017035199374643191</para>
            /// </summary>
            [NameInMap("re_shop_apply_id")]
            [Validation(Required=false)]
            public long? ReShopApplyId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("re_shop_reason_code")]
            [Validation(Required=false)]
            public string ReShopReasonCode { get; set; }

            [NameInMap("re_shop_reason_desc")]
            [Validation(Required=false)]
            public string ReShopReasonDesc { get; set; }

            [NameInMap("refund_change_rule")]
            [Validation(Required=false)]
            public IntlFlightReShopDetailResponseBodyModuleRefundChangeRule RefundChangeRule { get; set; }
            public class IntlFlightReShopDetailResponseBodyModuleRefundChangeRule : TeaModel {
                [NameInMap("refund_change_rule_desc")]
                [Validation(Required=false)]
                public string RefundChangeRuleDesc { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-03-06 15:01:35</para>
            /// </summary>
            [NameInMap("success_time")]
            [Validation(Required=false)]
            public string SuccessTime { get; set; }

            [NameInMap("user_intention_memo")]
            [Validation(Required=false)]
            public string UserIntentionMemo { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>407543AF-2BD9-5890-BD92-9D1AB7218B27</para>
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
        /// <b>Example:</b>
        /// <para>210bc4b116835992457938931db4de</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
