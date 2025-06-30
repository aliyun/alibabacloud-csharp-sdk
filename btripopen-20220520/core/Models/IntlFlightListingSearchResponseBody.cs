// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightListingSearchResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public IntlFlightListingSearchResponseBodyModule Module { get; set; }
        public class IntlFlightListingSearchResponseBodyModule : TeaModel {
            [NameInMap("flight_item_list")]
            [Validation(Required=false)]
            public List<IntlFlightListingSearchResponseBodyModuleFlightItemList> FlightItemList { get; set; }
            public class IntlFlightListingSearchResponseBodyModuleFlightItemList : TeaModel {
                [NameInMap("best_price_item")]
                [Validation(Required=false)]
                public IntlFlightListingSearchResponseBodyModuleFlightItemListBestPriceItem BestPriceItem { get; set; }
                public class IntlFlightListingSearchResponseBodyModuleFlightItemListBestPriceItem : TeaModel {
                    [NameInMap("agreement_price_codes")]
                    [Validation(Required=false)]
                    public List<IntlFlightListingSearchResponseBodyModuleFlightItemListBestPriceItemAgreementPriceCodes> AgreementPriceCodes { get; set; }
                    public class IntlFlightListingSearchResponseBodyModuleFlightItemListBestPriceItemAgreementPriceCodes : TeaModel {
                        [NameInMap("code")]
                        [Validation(Required=false)]
                        public string Code { get; set; }

                        [NameInMap("type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    [NameInMap("item_id")]
                    [Validation(Required=false)]
                    public string ItemId { get; set; }

                    [NameInMap("item_type")]
                    [Validation(Required=false)]
                    public string ItemType { get; set; }

                    [NameInMap("shopping_item_map")]
                    [Validation(Required=false)]
                    public Dictionary<string, ModuleFlightItemListBestPriceItemShoppingItemMapValue> ShoppingItemMap { get; set; }

                }

                [NameInMap("flight_journey_infos")]
                [Validation(Required=false)]
                public List<IntlFlightListingSearchResponseBodyModuleFlightItemListFlightJourneyInfos> FlightJourneyInfos { get; set; }
                public class IntlFlightListingSearchResponseBodyModuleFlightItemListFlightJourneyInfos : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>HGH</para>
                    /// </summary>
                    [NameInMap("arr_city_code")]
                    [Validation(Required=false)]
                    public string ArrCityCode { get; set; }

                    [NameInMap("arr_city_name")]
                    [Validation(Required=false)]
                    public string ArrCityName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2023-08-13 09:45</para>
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
                    /// <para>2023-08-13 07:25</para>
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
                    public List<IntlFlightListingSearchResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfos> FlightSegmentInfos { get; set; }
                    public class IntlFlightListingSearchResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfos : TeaModel {
                        [NameInMap("airline_info")]
                        [Validation(Required=false)]
                        public IntlFlightListingSearchResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosAirlineInfo AirlineInfo { get; set; }
                        public class IntlFlightListingSearchResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosAirlineInfo : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>9H</para>
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
                        public IntlFlightListingSearchResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosArrAirportInfo ArrAirportInfo { get; set; }
                        public class IntlFlightListingSearchResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosArrAirportInfo : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>PKX</para>
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
                            /// <para>--</para>
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

                        [NameInMap("arr_city_name")]
                        [Validation(Required=false)]
                        public string ArrCityName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2023-08-13 09:45</para>
                        /// </summary>
                        [NameInMap("arr_time")]
                        [Validation(Required=false)]
                        public string ArrTime { get; set; }

                        [NameInMap("dep_airport_info")]
                        [Validation(Required=false)]
                        public IntlFlightListingSearchResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosDepAirportInfo DepAirportInfo { get; set; }
                        public class IntlFlightListingSearchResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosDepAirportInfo : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>HGH</para>
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
                        /// <para>HGH</para>
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
                        /// <para>duration</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>140</para>
                        /// </summary>
                        [NameInMap("duration")]
                        [Validation(Required=false)]
                        public int? Duration { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>HO1116</para>
                        /// </summary>
                        [NameInMap("flight_no")]
                        [Validation(Required=false)]
                        public string FlightNo { get; set; }

                        [NameInMap("flight_share_info")]
                        [Validation(Required=false)]
                        public IntlFlightListingSearchResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosFlightShareInfo FlightShareInfo { get; set; }
                        public class IntlFlightListingSearchResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosFlightShareInfo : TeaModel {
                            [NameInMap("operating_airline_info")]
                            [Validation(Required=false)]
                            public IntlFlightListingSearchResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosFlightShareInfoOperatingAirlineInfo OperatingAirlineInfo { get; set; }
                            public class IntlFlightListingSearchResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosFlightShareInfoOperatingAirlineInfo : TeaModel {
                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>DR</para>
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
                            /// <para>CX601</para>
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
                        public List<IntlFlightListingSearchResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosFlightStopInfoList> FlightStopInfoList { get; set; }
                        public class IntlFlightListingSearchResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosFlightStopInfoList : TeaModel {
                            [NameInMap("stop_airport")]
                            [Validation(Required=false)]
                            public string StopAirport { get; set; }

                            [NameInMap("stop_airport_name")]
                            [Validation(Required=false)]
                            public string StopAirportName { get; set; }

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

                            [NameInMap("stop_time")]
                            [Validation(Required=false)]
                            public string StopTime { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>320</para>
                        /// </summary>
                        [NameInMap("flight_type")]
                        [Validation(Required=false)]
                        public string FlightType { get; set; }

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
                        /// <para>KN6728HGHPKX0725</para>
                        /// </summary>
                        [NameInMap("segment_key")]
                        [Validation(Required=false)]
                        public string SegmentKey { get; set; }

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

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>false</para>
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

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("need_continue")]
            [Validation(Required=false)]
            public bool? NeedContinue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ASDFASDFASDFASDFASDF</para>
            /// </summary>
            [NameInMap("query_record_id")]
            [Validation(Required=false)]
            public string QueryRecordId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ee229f2d-1835-4199-bfe6-fd14afe8645e</para>
            /// </summary>
            [NameInMap("token")]
            [Validation(Required=false)]
            public string Token { get; set; }

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
