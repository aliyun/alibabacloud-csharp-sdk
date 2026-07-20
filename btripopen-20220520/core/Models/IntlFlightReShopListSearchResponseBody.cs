// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightReShopListSearchResponseBody : TeaModel {
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
        public IntlFlightReShopListSearchResponseBodyModule Module { get; set; }
        public class IntlFlightReShopListSearchResponseBodyModule : TeaModel {
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
            /// <para>The wait time before the next search request, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("next_req_wait_time")]
            [Validation(Required=false)]
            public int? NextReqWaitTime { get; set; }

            /// <summary>
            /// <para>The flight list.</para>
            /// </summary>
            [NameInMap("re_shop_item_list")]
            [Validation(Required=false)]
            public List<IntlFlightReShopListSearchResponseBodyModuleReShopItemList> ReShopItemList { get; set; }
            public class IntlFlightReShopListSearchResponseBodyModuleReShopItemList : TeaModel {
                /// <summary>
                /// <para>The lowest price item.</para>
                /// </summary>
                [NameInMap("best_price_item")]
                [Validation(Required=false)]
                public IntlFlightReShopListSearchResponseBodyModuleReShopItemListBestPriceItem BestPriceItem { get; set; }
                public class IntlFlightReShopListSearchResponseBodyModuleReShopItemListBestPriceItem : TeaModel {
                    /// <summary>
                    /// <para>The item ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>b83e3d6ebb8b44dfb94c763abc66c966_2</para>
                    /// </summary>
                    [NameInMap("item_id")]
                    [Validation(Required=false)]
                    public string ItemId { get; set; }

                    /// <summary>
                    /// <para>The item type. Valid values: normal: standard item. combination: combined special offer.</para>
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
                    public Dictionary<string, ModuleReShopItemListBestPriceItemShoppingItemMapValue> ShoppingItemMap { get; set; }

                    /// <summary>
                    /// <para>The sub-items. Combined products may have multiple sub-items.</para>
                    /// </summary>
                    [NameInMap("sub_items")]
                    [Validation(Required=false)]
                    public List<IntlFlightReShopListSearchResponseBodyModuleReShopItemListBestPriceItemSubItems> SubItems { get; set; }
                    public class IntlFlightReShopListSearchResponseBodyModuleReShopItemListBestPriceItemSubItems : TeaModel {
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
                        /// <para>The list of segment keys contained in the sub-item.</para>
                        /// </summary>
                        [NameInMap("segment_keys")]
                        [Validation(Required=false)]
                        public List<string> SegmentKeys { get; set; }

                        /// <summary>
                        /// <para>The list of segment position information contained in the sub-item.</para>
                        /// </summary>
                        [NameInMap("segment_position_list")]
                        [Validation(Required=false)]
                        public List<IntlFlightReShopListSearchResponseBodyModuleReShopItemListBestPriceItemSubItemsSegmentPositionList> SegmentPositionList { get; set; }
                        public class IntlFlightReShopListSearchResponseBodyModuleReShopItemListBestPriceItemSubItemsSegmentPositionList : TeaModel {
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
                        /// <para>Key: ADT (adult), CHD (child), or INFANT (infant).</para>
                        /// </summary>
                        [NameInMap("shopping_item_map")]
                        [Validation(Required=false)]
                        public Dictionary<string, ModuleReShopItemListBestPriceItemSubItemsShoppingItemMapValue> ShoppingItemMap { get; set; }

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
                /// <para>The flight journey information.</para>
                /// </summary>
                [NameInMap("flight_journey_infos")]
                [Validation(Required=false)]
                public List<IntlFlightReShopListSearchResponseBodyModuleReShopItemListFlightJourneyInfos> FlightJourneyInfos { get; set; }
                public class IntlFlightReShopListSearchResponseBodyModuleReShopItemListFlightJourneyInfos : TeaModel {
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
                    /// <para>2023-08-13 09:25</para>
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
                    /// <para>2023-08-13 07:25</para>
                    /// </summary>
                    [NameInMap("dep_time")]
                    [Validation(Required=false)]
                    public string DepTime { get; set; }

                    /// <summary>
                    /// <para>The total duration, in minutes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>120</para>
                    /// </summary>
                    [NameInMap("duration")]
                    [Validation(Required=false)]
                    public int? Duration { get; set; }

                    /// <summary>
                    /// <para>The flight segment information.</para>
                    /// </summary>
                    [NameInMap("flight_segment_infos")]
                    [Validation(Required=false)]
                    public List<IntlFlightReShopListSearchResponseBodyModuleReShopItemListFlightJourneyInfosFlightSegmentInfos> FlightSegmentInfos { get; set; }
                    public class IntlFlightReShopListSearchResponseBodyModuleReShopItemListFlightJourneyInfosFlightSegmentInfos : TeaModel {
                        /// <summary>
                        /// <para>The marketing airline information.</para>
                        /// </summary>
                        [NameInMap("airline_info")]
                        [Validation(Required=false)]
                        public IntlFlightReShopListSearchResponseBodyModuleReShopItemListFlightJourneyInfosFlightSegmentInfosAirlineInfo AirlineInfo { get; set; }
                        public class IntlFlightReShopListSearchResponseBodyModuleReShopItemListFlightJourneyInfosFlightSegmentInfosAirlineInfo : TeaModel {
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
                            /// <para>中国国航</para>
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
                        /// <para>The arrival airport information.</para>
                        /// </summary>
                        [NameInMap("arr_airport_info")]
                        [Validation(Required=false)]
                        public IntlFlightReShopListSearchResponseBodyModuleReShopItemListFlightJourneyInfosFlightSegmentInfosArrAirportInfo ArrAirportInfo { get; set; }
                        public class IntlFlightReShopListSearchResponseBodyModuleReShopItemListFlightJourneyInfosFlightSegmentInfosArrAirportInfo : TeaModel {
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
                        /// <para>2023-08-13 09:25</para>
                        /// </summary>
                        [NameInMap("arr_time")]
                        [Validation(Required=false)]
                        public string ArrTime { get; set; }

                        /// <summary>
                        /// <para>The arrival time with time zone.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2022-06-06T12:56:34Z</para>
                        /// </summary>
                        [NameInMap("arr_time_u_t_c")]
                        [Validation(Required=false)]
                        public string ArrTimeUTC { get; set; }

                        /// <summary>
                        /// <para>The departure airport information.</para>
                        /// </summary>
                        [NameInMap("dep_airport_info")]
                        [Validation(Required=false)]
                        public IntlFlightReShopListSearchResponseBodyModuleReShopItemListFlightJourneyInfosFlightSegmentInfosDepAirportInfo DepAirportInfo { get; set; }
                        public class IntlFlightReShopListSearchResponseBodyModuleReShopItemListFlightJourneyInfosFlightSegmentInfosDepAirportInfo : TeaModel {
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
                        /// <para>2023-08-13 07:25</para>
                        /// </summary>
                        [NameInMap("dep_time")]
                        [Validation(Required=false)]
                        public string DepTime { get; set; }

                        /// <summary>
                        /// <para>The departure time with time zone.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2022-06-06T12:56:34Z</para>
                        /// </summary>
                        [NameInMap("dep_time_u_t_c")]
                        [Validation(Required=false)]
                        public string DepTimeUTC { get; set; }

                        /// <summary>
                        /// <para>The total duration of the flight segment in minutes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>320</para>
                        /// </summary>
                        [NameInMap("duration")]
                        [Validation(Required=false)]
                        public int? Duration { get; set; }

                        /// <summary>
                        /// <para>The flight number.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CA2013</para>
                        /// </summary>
                        [NameInMap("flight_no")]
                        [Validation(Required=false)]
                        public string FlightNo { get; set; }

                        /// <summary>
                        /// <para>The codeshare flight information.</para>
                        /// </summary>
                        [NameInMap("flight_share_info")]
                        [Validation(Required=false)]
                        public IntlFlightReShopListSearchResponseBodyModuleReShopItemListFlightJourneyInfosFlightSegmentInfosFlightShareInfo FlightShareInfo { get; set; }
                        public class IntlFlightReShopListSearchResponseBodyModuleReShopItemListFlightJourneyInfosFlightSegmentInfosFlightShareInfo : TeaModel {
                            /// <summary>
                            /// <para>The operating airline information.</para>
                            /// </summary>
                            [NameInMap("operating_airline_info")]
                            [Validation(Required=false)]
                            public IntlFlightReShopListSearchResponseBodyModuleReShopItemListFlightJourneyInfosFlightSegmentInfosFlightShareInfoOperatingAirlineInfo OperatingAirlineInfo { get; set; }
                            public class IntlFlightReShopListSearchResponseBodyModuleReShopItemListFlightJourneyInfosFlightSegmentInfosFlightShareInfoOperatingAirlineInfo : TeaModel {
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
                                /// <para>中国国航</para>
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
                        public List<IntlFlightReShopListSearchResponseBodyModuleReShopItemListFlightJourneyInfosFlightSegmentInfosFlightStopInfoList> FlightStopInfoList { get; set; }
                        public class IntlFlightReShopListSearchResponseBodyModuleReShopItemListFlightJourneyInfosFlightSegmentInfosFlightStopInfoList : TeaModel {
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
                            /// <para>The county information of the stopover airport.</para>
                            /// </summary>
                            [NameInMap("stop_airport_county_info")]
                            [Validation(Required=false)]
                            public IntlFlightReShopListSearchResponseBodyModuleReShopItemListFlightJourneyInfosFlightSegmentInfosFlightStopInfoListStopAirportCountyInfo StopAirportCountyInfo { get; set; }
                            public class IntlFlightReShopListSearchResponseBodyModuleReShopItemListFlightJourneyInfosFlightSegmentInfosFlightStopInfoListStopAirportCountyInfo : TeaModel {
                                /// <summary>
                                /// <para>The administrative division code.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>330182</para>
                                /// </summary>
                                [NameInMap("adcode")]
                                [Validation(Required=false)]
                                public string Adcode { get; set; }

                                /// <summary>
                                /// <para>The airport city code.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>HGH</para>
                                /// </summary>
                                [NameInMap("airport_city_code")]
                                [Validation(Required=false)]
                                public string AirportCityCode { get; set; }

                                /// <summary>
                                /// <para>The city name of the airport.
                                /// [_single.resp.200.props.module.re_shop_item_list.items.flight_journey_infos.items.flight_segment_infos.items.flight_stop_info</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>杭州</para>
                                /// </summary>
                                [NameInMap("airport_city_name")]
                                [Validation(Required=false)]
                                public string AirportCityName { get; set; }

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
                                /// <para>The parent city name of the airport.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>杭州</para>
                                /// </summary>
                                [NameInMap("airport_parent_city_name")]
                                [Validation(Required=false)]
                                public string AirportParentCityName { get; set; }

                                /// <summary>
                                /// <para>The administrative division code of the county-level city where the airport is located.</para>
                                /// <remarks>
                                /// <para>Notice: This value is null if the airport is not at the county level.</notice></para>
                                /// </remarks>
                                /// 
                                /// <b>Example:</b>
                                /// <para>杭州</para>
                                /// </summary>
                                [NameInMap("county_city_adcode")]
                                [Validation(Required=false)]
                                public string CountyCityAdcode { get; set; }

                                /// <summary>
                                /// <para>The name of the county-level city where the airport is located.</para>
                                /// <remarks>
                                /// <para>Notice: This value is null if the airport is not at the county level.</notice></para>
                                /// </remarks>
                                /// 
                                /// <b>Example:</b>
                                /// <para>330182</para>
                                /// </summary>
                                [NameInMap("county_city_name")]
                                [Validation(Required=false)]
                                public string CountyCityName { get; set; }

                                /// <summary>
                                /// <para>The administrative division code of the prefecture-level city where the airport is located.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>330182</para>
                                /// </summary>
                                [NameInMap("prefecture_city_adcode")]
                                [Validation(Required=false)]
                                public string PrefectureCityAdcode { get; set; }

                                /// <summary>
                                /// <para>The name of the prefecture-level city where the airport is located.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>杭州</para>
                                /// </summary>
                                [NameInMap("prefecture_city_name")]
                                [Validation(Required=false)]
                                public string PrefectureCityName { get; set; }

                            }

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
                            /// <para>The arrival time at the stopover. Format: yyyy-MM-dd HH:mm.</para>
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
                            /// <para>2023-08-13 09:25</para>
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
                        public IntlFlightReShopListSearchResponseBodyModuleReShopItemListFlightJourneyInfosFlightSegmentInfosLuggageDirectInfo LuggageDirectInfo { get; set; }
                        public class IntlFlightReShopListSearchResponseBodyModuleReShopItemListFlightJourneyInfosFlightSegmentInfosLuggageDirectInfo : TeaModel {
                            /// <summary>
                            /// <para>The luggage through-check status for the departure city. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>0: re-check required.</description></item>
                            /// <item><description>1: through-checked.</description></item>
                            /// <item><description>null: unknown.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("dep_city_luggage_direct")]
                            [Validation(Required=false)]
                            public int? DepCityLuggageDirect { get; set; }

                            /// <summary>
                            /// <para>The luggage through-check status for the departure city. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>0: re-check required.</description></item>
                            /// <item><description>1: through-checked.</description></item>
                            /// <item><description>null: unknown.</description></item>
                            /// </list>
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
                        /// <para>空客</para>
                        /// </summary>
                        [NameInMap("manufacturer")]
                        [Validation(Required=false)]
                        public string Manufacturer { get; set; }

                        /// <summary>
                        /// <para>Indicates whether a meal is provided. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>0: no meal.</description></item>
                        /// <item><description>1: meal provided.</description></item>
                        /// </list>
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
                        /// <para>12</para>
                        /// </summary>
                        [NameInMap("miles")]
                        [Validation(Required=false)]
                        public int? Miles { get; set; }

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
                        /// <para>The number of extra days. For example, 1 indicates that the flight crosses 1 day.</para>
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
                        public IntlFlightReShopListSearchResponseBodyModuleReShopItemListFlightJourneyInfosFlightSegmentInfosOtherInfo OtherInfo { get; set; }
                        public class IntlFlightReShopListSearchResponseBodyModuleReShopItemListFlightJourneyInfosFlightSegmentInfosOtherInfo : TeaModel {
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
                            /// <para>The average delay time.</para>
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
                            /// <para>10%</para>
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
                            /// <para>到达准点率90%</para>
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
                        /// <para>The unique key of the segment.</para>
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
                        public IntlFlightReShopListSearchResponseBodyModuleReShopItemListFlightJourneyInfosFlightSegmentInfosSegmentVisaRemark SegmentVisaRemark { get; set; }
                        public class IntlFlightReShopListSearchResponseBodyModuleReShopItemListFlightJourneyInfosFlightSegmentInfosSegmentVisaRemark : TeaModel {
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
                            /// <item><description>0: no transit visa required.</description></item>
                            /// <item><description>1: transit visa required.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>0</para>
                            /// </summary>
                            [NameInMap("dep_city_visa_type")]
                            [Validation(Required=false)]
                            public int? DepCityVisaType { get; set; }

                            /// <summary>
                            /// <para>The transit visa information for stopover cities, one entry per stopover city.</para>
                            /// </summary>
                            [NameInMap("stop_city_visa_remarks")]
                            [Validation(Required=false)]
                            public List<string> StopCityVisaRemarks { get; set; }

                            /// <summary>
                            /// <para>The transit visa types for stopover cities, one entry per stopover city.</para>
                            /// </summary>
                            [NameInMap("stop_city_visa_types")]
                            [Validation(Required=false)]
                            public List<int?> StopCityVisaTypes { get; set; }

                        }

                        /// <summary>
                        /// <para>Indicates whether the flight is a codeshare flight.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
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
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("stop")]
                        [Validation(Required=false)]
                        public bool? Stop { get; set; }

                        /// <summary>
                        /// <para>The ticketing airline information.</para>
                        /// </summary>
                        [NameInMap("ticketing_airline_info")]
                        [Validation(Required=false)]
                        public IntlFlightReShopListSearchResponseBodyModuleReShopItemListFlightJourneyInfosFlightSegmentInfosTicketingAirlineInfo TicketingAirlineInfo { get; set; }
                        public class IntlFlightReShopListSearchResponseBodyModuleReShopItemListFlightJourneyInfosFlightSegmentInfosTicketingAirlineInfo : TeaModel {
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
                            /// <para>中国国航</para>
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
                        /// <para>The total duration of the flight segment.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>5小时20分</para>
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
            /// <para>The query record token for external polling.</para>
            /// 
            /// <b>Example:</b>
            /// <para>284e692fffdf71e8a49aebbe0657a625</para>
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
        /// <para>Indicates whether the request is successful.</para>
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
