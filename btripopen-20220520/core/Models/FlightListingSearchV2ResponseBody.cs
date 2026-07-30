// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightListingSearchV2ResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
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
        /// <para>module</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public FlightListingSearchV2ResponseBodyModule Module { get; set; }
        public class FlightListingSearchV2ResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The list of flight items.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>Returns an empty array when no results are available.</description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("flight_item_list")]
            [Validation(Required=false)]
            public List<FlightListingSearchV2ResponseBodyModuleFlightItemList> FlightItemList { get; set; }
            public class FlightListingSearchV2ResponseBodyModuleFlightItemList : TeaModel {
                /// <summary>
                /// <para>The lowest-priced product.</para>
                /// <remarks>
                /// <para>The lowest-priced product.</para>
                /// <list type="bullet">
                /// <item><description>Normal case: The &quot;item_list&quot; returns only one item, which is the same as &quot;best_price_item&quot;. You can use either one.</description></item>
                /// <item><description>Special case (multi-price scenario): For example, when need_y_c_best_price is set to true, &quot;item_list&quot; may return two products, and &quot;best_price_item&quot; is the lowest-priced product in &quot;item_list&quot;.</description></item>
                /// </list>
                /// </remarks>
                /// </summary>
                [NameInMap("best_price_item")]
                [Validation(Required=false)]
                public FlightListingSearchV2ResponseBodyModuleFlightItemListBestPriceItem BestPriceItem { get; set; }
                public class FlightListingSearchV2ResponseBodyModuleFlightItemListBestPriceItem : TeaModel {
                    /// <summary>
                    /// <para>The contract price type: contract price or business travel price. (Note: the value returned is text.)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>协议价</para>
                    /// </summary>
                    [NameInMap("code_type")]
                    [Validation(Required=false)]
                    public string CodeType { get; set; }

                    /// <summary>
                    /// <para>The refund/change rules and baggage allowance.</para>
                    /// <list type="bullet">
                    /// <item><description>Returns empty when no value is available.</description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("flight_rule_infos")]
                    [Validation(Required=false)]
                    public Dictionary<string, ModuleFlightItemListBestPriceItemFlightRuleInfosValue> FlightRuleInfos { get; set; }

                    /// <summary>
                    /// <para>The product ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>e50d380fc05942cc8ac57af8ae02f448_0</para>
                    /// </summary>
                    [NameInMap("item_id")]
                    [Validation(Required=false)]
                    public string ItemId { get; set; }

                    /// <summary>
                    /// <para>Key: ADT (adult), CHD (child), INFANT (infant).</para>
                    /// <para>Value: price and cabin remaining inventory information.</para>
                    /// </summary>
                    [NameInMap("shopping_item_map")]
                    [Validation(Required=false)]
                    public Dictionary<string, ModuleFlightItemListBestPriceItemShoppingItemMapValue> ShoppingItemMap { get; set; }

                    /// <summary>
                    /// <para>The mapping of subItem.uniqKey to the positions of all segments where the subItem appears.</para>
                    /// </summary>
                    [NameInMap("sub_item_position_map")]
                    [Validation(Required=false)]
                    public Dictionary<string, List<ModuleFlightItemListBestPriceItemSubItemPositionMapValue>> SubItemPositionMap { get; set; }

                    /// <summary>
                    /// <para>The sub-product list. Combined products may have multiple sub-products.</para>
                    /// </summary>
                    [NameInMap("sub_items")]
                    [Validation(Required=false)]
                    public List<FlightListingSearchV2ResponseBodyModuleFlightItemListBestPriceItemSubItems> SubItems { get; set; }
                    public class FlightListingSearchV2ResponseBodyModuleFlightItemListBestPriceItemSubItems : TeaModel {
                        /// <summary>
                        /// <para>Key: ADT - adult, CHD - child, INFANT - infant.</para>
                        /// <para>Value: price and cabin remaining inventory information.</para>
                        /// </summary>
                        [NameInMap("shopping_item_map")]
                        [Validation(Required=false)]
                        public Dictionary<string, ModuleFlightItemListBestPriceItemSubItemsShoppingItemMapValue> ShoppingItemMap { get; set; }

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

                /// <summary>
                /// <para>The list of journey information.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>Returns null when no value is available.</description></item>
                /// </list>
                /// </remarks>
                /// </summary>
                [NameInMap("flight_journey_infos")]
                [Validation(Required=false)]
                public List<FlightListingSearchV2ResponseBodyModuleFlightItemListFlightJourneyInfos> FlightJourneyInfos { get; set; }
                public class FlightListingSearchV2ResponseBodyModuleFlightItemListFlightJourneyInfos : TeaModel {
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
                    /// <para>The flight extension information.</para>
                    /// </summary>
                    [NameInMap("extensions")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> Extensions { get; set; }

                    /// <summary>
                    /// <para>The list of flight segment information.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>Returns null when no value is available.</description></item>
                    /// </list>
                    /// </remarks>
                    /// </summary>
                    [NameInMap("flight_segment_infos")]
                    [Validation(Required=false)]
                    public List<FlightListingSearchV2ResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfos> FlightSegmentInfos { get; set; }
                    public class FlightListingSearchV2ResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfos : TeaModel {
                        /// <summary>
                        /// <para>The marketing airline information.</para>
                        /// </summary>
                        [NameInMap("airline_info")]
                        [Validation(Required=false)]
                        public FlightListingSearchV2ResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosAirlineInfo AirlineInfo { get; set; }
                        public class FlightListingSearchV2ResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosAirlineInfo : TeaModel {
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
                            /// <para>Indicates whether the airline is a low-cost carrier.</para>
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
                        public FlightListingSearchV2ResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosArrAirportInfo ArrAirportInfo { get; set; }
                        public class FlightListingSearchV2ResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosArrAirportInfo : TeaModel {
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
                            /// <para>Indicates whether the airport name is highlighted.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>#FF7300</para>
                            /// </summary>
                            [NameInMap("airport_name_color")]
                            [Validation(Required=false)]
                            public string AirportNameColor { get; set; }

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
                        /// <para>The baggage allowance description.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>行李额描述</para>
                        /// </summary>
                        [NameInMap("baggage_desc")]
                        [Validation(Required=false)]
                        public string BaggageDesc { get; set; }

                        /// <summary>
                        /// <para>The departure airport information.</para>
                        /// </summary>
                        [NameInMap("dep_airport_info")]
                        [Validation(Required=false)]
                        public FlightListingSearchV2ResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosDepAirportInfo DepAirportInfo { get; set; }
                        public class FlightListingSearchV2ResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosDepAirportInfo : TeaModel {
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
                            /// <para>Indicates whether the airport name is highlighted.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>#FF7300</para>
                            /// </summary>
                            [NameInMap("airport_name_color")]
                            [Validation(Required=false)]
                            public string AirportNameColor { get; set; }

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
                        /// <para>The total duration of the segment in numeric format.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>140</para>
                        /// </summary>
                        [NameInMap("duration")]
                        [Validation(Required=false)]
                        public int? Duration { get; set; }

                        /// <summary>
                        /// <para>The extension fields.</para>
                        /// </summary>
                        [NameInMap("extra_info")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> ExtraInfo { get; set; }

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
                        public FlightListingSearchV2ResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosFlightShareInfo FlightShareInfo { get; set; }
                        public class FlightListingSearchV2ResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosFlightShareInfo : TeaModel {
                            /// <summary>
                            /// <para>The operating airline information.</para>
                            /// </summary>
                            [NameInMap("operating_airline_info")]
                            [Validation(Required=false)]
                            public FlightListingSearchV2ResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosFlightShareInfoOperatingAirlineInfo OperatingAirlineInfo { get; set; }
                            public class FlightListingSearchV2ResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosFlightShareInfoOperatingAirlineInfo : TeaModel {
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
                                /// <para>DR</para>
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
                                /// <para>Indicates whether the airline is a low-cost carrier.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>false</para>
                                /// </summary>
                                [NameInMap("cheap_flight")]
                                [Validation(Required=false)]
                                public bool? CheapFlight { get; set; }

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
                        /// <para>The stopover information.</para>
                        /// </summary>
                        [NameInMap("flight_stop_info")]
                        [Validation(Required=false)]
                        public FlightListingSearchV2ResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosFlightStopInfo FlightStopInfo { get; set; }
                        public class FlightListingSearchV2ResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosFlightStopInfo : TeaModel {
                            /// <summary>
                            /// <para>The stopover airport code.</para>
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
                            /// <para>The arrival terminal at the stopover airport.
                            /// [_single.resp.200.props.module.flight_item_list.items</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>T3</para>
                            /// </summary>
                            [NameInMap("stop_arr_term")]
                            [Validation(Required=false)]
                            public string StopArrTerm { get; set; }

                            /// <summary>
                            /// <para>The arrival time at the stopover city.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>BJS</para>
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
                            /// <list type="bullet">
                            /// <item><description>Returns empty when no value is available.</description></item>
                            /// </list>
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
                            /// <para>The departure time from the stopover city.</para>
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
                            /// <para>经停时间</para>
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
                        /// <para>The manufacturer, such as &quot;Boeing&quot;.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>空客</para>
                        /// </summary>
                        [NameInMap("manufacturer")]
                        [Validation(Required=false)]
                        public string Manufacturer { get; set; }

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
                        /// <para>The mileage.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>里程</para>
                        /// </summary>
                        [NameInMap("miles")]
                        [Validation(Required=false)]
                        public int? Miles { get; set; }

                        /// <summary>
                        /// <para>The on-time rate.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>准点率</para>
                        /// </summary>
                        [NameInMap("on_time_rate")]
                        [Validation(Required=false)]
                        public string OnTimeRate { get; set; }

                        /// <summary>
                        /// <para>The number of days crossed. A value of 1 means the arrival is on the next day.</para>
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
                        /// <para>The total duration of the segment.</para>
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
                        /// <para>中转时间</para>
                        /// </summary>
                        [NameInMap("transfer_time")]
                        [Validation(Required=false)]
                        public string TransferTime { get; set; }

                        /// <summary>
                        /// <para>The transfer time in numeric format.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>中转时间数字</para>
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
                    /// <para>The transfer time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("transfer_time")]
                    [Validation(Required=false)]
                    public int? TransferTime { get; set; }

                }

                /// <summary>
                /// <para>The product list. Multiple products may be returned in multi-quote scenarios.</para>
                /// <remarks>
                /// <para>The product list. Multiple products may be returned in multi-quote scenarios.</para>
                /// <list type="bullet">
                /// <item><description>Normal case: &quot;item_list - product list&quot; returns only one item, which is consistent with &quot;best_price_item - lowest price product&quot;. You can use either one.</description></item>
                /// <item><description>Special case, multi-quote scenario: For example, when need_y_c_best_price (whether to query the lowest Y/C cabin price) is set to true, &quot;item_list - product list&quot; may return two products, and &quot;best_price_item - lowest price product&quot; is the lowest-priced product in &quot;item_list - product list&quot;.</description></item>
                /// </list>
                /// </remarks>
                /// </summary>
                [NameInMap("item_list")]
                [Validation(Required=false)]
                public List<FlightListingSearchV2ResponseBodyModuleFlightItemListItemList> ItemList { get; set; }
                public class FlightListingSearchV2ResponseBodyModuleFlightItemListItemList : TeaModel {
                    /// <summary>
                    /// <para>协议价类型：协议价 ｜ 商旅价
                    /// (注：返回的是文字)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>协议价</para>
                    /// </summary>
                    [NameInMap("code_type")]
                    [Validation(Required=false)]
                    public string CodeType { get; set; }

                    /// <summary>
                    /// <para>退改、行李额</para>
                    /// </summary>
                    [NameInMap("flight_rule_infos")]
                    [Validation(Required=false)]
                    public Dictionary<string, ModuleFlightItemListItemListFlightRuleInfosValue> FlightRuleInfos { get; set; }

                    /// <summary>
                    /// <para>The product ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>e50d380fc05942cc8ac57af8ae02f448_0</para>
                    /// </summary>
                    [NameInMap("item_id")]
                    [Validation(Required=false)]
                    public string ItemId { get; set; }

                    /// <summary>
                    /// <para>Key: ADT - adult, CHD - child, INFANT - infant.</para>
                    /// <para>Value: price and cabin remaining inventory information.</para>
                    /// </summary>
                    [NameInMap("shopping_item_map")]
                    [Validation(Required=false)]
                    public Dictionary<string, ModuleFlightItemListItemListShoppingItemMapValue> ShoppingItemMap { get; set; }

                    /// <summary>
                    /// <para>subItem.uniqKey -&gt; 该subItem所有出现的段的位置</para>
                    /// </summary>
                    [NameInMap("sub_item_position_map")]
                    [Validation(Required=false)]
                    public Dictionary<string, List<ModuleFlightItemListItemListSubItemPositionMapValue>> SubItemPositionMap { get; set; }

                    /// <summary>
                    /// <para>子商品列表，拼接商品会有多个子商品</para>
                    /// </summary>
                    [NameInMap("sub_items")]
                    [Validation(Required=false)]
                    public List<FlightListingSearchV2ResponseBodyModuleFlightItemListItemListSubItems> SubItems { get; set; }
                    public class FlightListingSearchV2ResponseBodyModuleFlightItemListItemListSubItems : TeaModel {
                        /// <summary>
                        /// <para>Key: ADT - adult, CHD - child, INFANT - infant.</para>
                        /// <para>Value: price and cabin remaining inventory information.</para>
                        /// </summary>
                        [NameInMap("shopping_item_map")]
                        [Validation(Required=false)]
                        public Dictionary<string, ModuleFlightItemListItemListSubItemsShoppingItemMapValue> ShoppingItemMap { get; set; }

                        /// <summary>
                        /// <para>测试商品tag</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>测试商品tag</para>
                        /// </summary>
                        [NameInMap("tag")]
                        [Validation(Required=false)]
                        public string Tag { get; set; }

                        /// <summary>
                        /// <para>唯一id</para>
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
            /// <para>The search mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("search_mode")]
            [Validation(Required=false)]
            public int? SearchMode { get; set; }

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
        /// <para>The unique identifier of the request.</para>
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
        /// <para>The global trace identifier for the request, typically used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>210e842b16611337974412836dae27</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
