// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightListingSearchResponseBody : TeaModel {
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
        public IntlFlightListingSearchResponseBodyModule Module { get; set; }
        public class IntlFlightListingSearchResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The flight list.</para>
            /// </summary>
            [NameInMap("flight_item_list")]
            [Validation(Required=false)]
            public List<IntlFlightListingSearchResponseBodyModuleFlightItemList> FlightItemList { get; set; }
            public class IntlFlightListingSearchResponseBodyModuleFlightItemList : TeaModel {
                /// <summary>
                /// <para>The item with the lowest price.</para>
                /// </summary>
                [NameInMap("best_price_item")]
                [Validation(Required=false)]
                public IntlFlightListingSearchResponseBodyModuleFlightItemListBestPriceItem BestPriceItem { get; set; }
                public class IntlFlightListingSearchResponseBodyModuleFlightItemListBestPriceItem : TeaModel {
                    /// <summary>
                    /// <para>The agreement price codes.</para>
                    /// </summary>
                    [NameInMap("agreement_price_codes")]
                    [Validation(Required=false)]
                    public List<IntlFlightListingSearchResponseBodyModuleFlightItemListBestPriceItemAgreementPriceCodes> AgreementPriceCodes { get; set; }
                    public class IntlFlightListingSearchResponseBodyModuleFlightItemListBestPriceItemAgreementPriceCodes : TeaModel {
                        /// <summary>
                        /// <para>The agreement price code.</para>
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
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// <para>The item type. Valid values: normal: standard item. combination: combination special. reliable_combination: reliable combination.</para>
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
                    public List<IntlFlightListingSearchResponseBodyModuleFlightItemListBestPriceItemLabelList> LabelList { get; set; }
                    public class IntlFlightListingSearchResponseBodyModuleFlightItemListBestPriceItemLabelList : TeaModel {
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
                    /// <para>Key: ADT (adult), CHD (child).</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>An empty collection is returned when no value exists.</description></item>
                    /// </list>
                    /// </remarks>
                    /// </summary>
                    [NameInMap("shopping_item_map")]
                    [Validation(Required=false)]
                    public Dictionary<string, ModuleFlightItemListBestPriceItemShoppingItemMapValue> ShoppingItemMap { get; set; }

                }

                /// <summary>
                /// <para>The journey information.</para>
                /// </summary>
                [NameInMap("flight_journey_infos")]
                [Validation(Required=false)]
                public List<IntlFlightListingSearchResponseBodyModuleFlightItemListFlightJourneyInfos> FlightJourneyInfos { get; set; }
                public class IntlFlightListingSearchResponseBodyModuleFlightItemListFlightJourneyInfos : TeaModel {
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
                    /// <para>60</para>
                    /// </summary>
                    [NameInMap("duration")]
                    [Validation(Required=false)]
                    public int? Duration { get; set; }

                    /// <summary>
                    /// <para>The segment information.</para>
                    /// </summary>
                    [NameInMap("flight_segment_infos")]
                    [Validation(Required=false)]
                    public List<IntlFlightListingSearchResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfos> FlightSegmentInfos { get; set; }
                    public class IntlFlightListingSearchResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfos : TeaModel {
                        /// <summary>
                        /// <para>The marketing airline information.</para>
                        /// </summary>
                        [NameInMap("airline_info")]
                        [Validation(Required=false)]
                        public IntlFlightListingSearchResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosAirlineInfo AirlineInfo { get; set; }
                        public class IntlFlightListingSearchResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosAirlineInfo : TeaModel {
                            /// <summary>
                            /// <para>The airline code, such as &quot;HU&quot; for Hainan Airlines.</para>
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
                        public IntlFlightListingSearchResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosArrAirportInfo ArrAirportInfo { get; set; }
                        public class IntlFlightListingSearchResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosArrAirportInfo : TeaModel {
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
                        public IntlFlightListingSearchResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosDepAirportInfo DepAirportInfo { get; set; }
                        public class IntlFlightListingSearchResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosDepAirportInfo : TeaModel {
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
                        /// <para>HO1116</para>
                        /// </summary>
                        [NameInMap("flight_no")]
                        [Validation(Required=false)]
                        public string FlightNo { get; set; }

                        /// <summary>
                        /// <para>The codeshare flight information.</para>
                        /// </summary>
                        [NameInMap("flight_share_info")]
                        [Validation(Required=false)]
                        public IntlFlightListingSearchResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosFlightShareInfo FlightShareInfo { get; set; }
                        public class IntlFlightListingSearchResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosFlightShareInfo : TeaModel {
                            /// <summary>
                            /// <para>The operating airline information.</para>
                            /// </summary>
                            [NameInMap("operating_airline_info")]
                            [Validation(Required=false)]
                            public IntlFlightListingSearchResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosFlightShareInfoOperatingAirlineInfo OperatingAirlineInfo { get; set; }
                            public class IntlFlightListingSearchResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosFlightShareInfoOperatingAirlineInfo : TeaModel {
                                /// <summary>
                                /// <para>The airline code, such as &quot;HU&quot; for Hainan Airlines.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>CZ</para>
                                /// </summary>
                                [NameInMap("airline_code")]
                                [Validation(Required=false)]
                                public string AirlineCode { get; set; }

                                /// <summary>
                                /// <para>The airline name.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>中国南方航空</para>
                                /// </summary>
                                [NameInMap("airline_name")]
                                [Validation(Required=false)]
                                public string AirlineName { get; set; }

                                /// <summary>
                                /// <para>The airline short name.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>南航</para>
                                /// </summary>
                                [NameInMap("short_name")]
                                [Validation(Required=false)]
                                public string ShortName { get; set; }

                            }

                            /// <summary>
                            /// <para>The operating flight number (populated for codeshare flights).</para>
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
                        /// <para>The flight stopover list.</para>
                        /// </summary>
                        [NameInMap("flight_stop_info_list")]
                        [Validation(Required=false)]
                        public List<IntlFlightListingSearchResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosFlightStopInfoList> FlightStopInfoList { get; set; }
                        public class IntlFlightListingSearchResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosFlightStopInfoList : TeaModel {
                            /// <summary>
                            /// <para>The stopover airport code.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>SZX</para>
                            /// </summary>
                            [NameInMap("stop_airport")]
                            [Validation(Required=false)]
                            public string StopAirport { get; set; }

                            /// <summary>
                            /// <para>The name of the stopover airport.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>深圳宝安国际机场</para>
                            /// </summary>
                            [NameInMap("stop_airport_name")]
                            [Validation(Required=false)]
                            public string StopAirportName { get; set; }

                            /// <summary>
                            /// <para>The terminal at the stopover airport for arrival.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>T3</para>
                            /// </summary>
                            [NameInMap("stop_arr_term")]
                            [Validation(Required=false)]
                            public string StopArrTerm { get; set; }

                            /// <summary>
                            /// <para>The stopover arrival time. Format: yyyy-MM-dd HH:mm.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>2025-10-10 09:25</para>
                            /// </summary>
                            [NameInMap("stop_arr_time")]
                            [Validation(Required=false)]
                            public string StopArrTime { get; set; }

                            /// <summary>
                            /// <para>The three-letter code of the stopover city.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>SZX</para>
                            /// </summary>
                            [NameInMap("stop_city_code")]
                            [Validation(Required=false)]
                            public string StopCityCode { get; set; }

                            /// <summary>
                            /// <para>The stopover city name.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>深圳</para>
                            /// </summary>
                            [NameInMap("stop_city_name")]
                            [Validation(Required=false)]
                            public string StopCityName { get; set; }

                            /// <summary>
                            /// <para>The terminal at the stopover airport for departure.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>T3</para>
                            /// </summary>
                            [NameInMap("stop_dep_term")]
                            [Validation(Required=false)]
                            public string StopDepTerm { get; set; }

                            /// <summary>
                            /// <para>The stopover departure time. Format: yyyy-MM-dd HH:mm.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>2025-10-10 07:25</para>
                            /// </summary>
                            [NameInMap("stop_dep_time")]
                            [Validation(Required=false)]
                            public string StopDepTime { get; set; }

                            /// <summary>
                            /// <para>The stopover duration. Unit: minutes.</para>
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
                        /// <para>320</para>
                        /// </summary>
                        [NameInMap("flight_type")]
                        [Validation(Required=false)]
                        public string FlightType { get; set; }

                        /// <summary>
                        /// <para>The manufacturer, such as &quot;Airbus&quot;.</para>
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
                        /// <para>The number of days crossed. 1 indicates crossing 1 day.</para>
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
                        /// <para>The segment index, starting from 0 within the same journey.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("segment_index")]
                        [Validation(Required=false)]
                        public int? SegmentIndex { get; set; }

                        /// <summary>
                        /// <para>The unique segment key. Format: flight number + departure airport + arrival airport + departure date (MMdd). Example: KN6728HGHPKX0725.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>KN6728HGHPKX0725</para>
                        /// </summary>
                        [NameInMap("segment_key")]
                        [Validation(Required=false)]
                        public string SegmentKey { get; set; }

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
                        /// <para>The total duration of the flight segment.</para>
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

            }

            /// <summary>
            /// <para>Indicates whether polling needs to continue.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("need_continue")]
            [Validation(Required=false)]
            public bool? NeedContinue { get; set; }

            /// <summary>
            /// <para>The query record ID, used for external polling.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ASDFASDFASDFASDFASDF</para>
            /// </summary>
            [NameInMap("query_record_id")]
            [Validation(Required=false)]
            public string QueryRecordId { get; set; }

            /// <summary>
            /// <para>The query record token, used for external polling.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ee229f2d-1835-4199-bfe6-fd14afe8645e</para>
            /// </summary>
            [NameInMap("token")]
            [Validation(Required=false)]
            public string Token { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>71493A1A-DD8F-5A20-90E9-BE5138AC1156</para>
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
        /// <para>The global identifier for tracing the request, typically used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>210bc4b116835992457938931db4de</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
