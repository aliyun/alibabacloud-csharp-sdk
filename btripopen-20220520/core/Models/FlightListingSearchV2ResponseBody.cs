// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightListingSearchV2ResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// module
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public FlightListingSearchV2ResponseBodyModule Module { get; set; }
        public class FlightListingSearchV2ResponseBodyModule : TeaModel {
            [NameInMap("flight_item_list")]
            [Validation(Required=false)]
            public List<FlightListingSearchV2ResponseBodyModuleFlightItemList> FlightItemList { get; set; }
            public class FlightListingSearchV2ResponseBodyModuleFlightItemList : TeaModel {
                [NameInMap("best_price_item")]
                [Validation(Required=false)]
                public FlightListingSearchV2ResponseBodyModuleFlightItemListBestPriceItem BestPriceItem { get; set; }
                public class FlightListingSearchV2ResponseBodyModuleFlightItemListBestPriceItem : TeaModel {
                    [NameInMap("flight_rule_infos")]
                    [Validation(Required=false)]
                    public Dictionary<string, ModuleFlightItemListBestPriceItemFlightRuleInfosValue> FlightRuleInfos { get; set; }

                    [NameInMap("item_id")]
                    [Validation(Required=false)]
                    public string ItemId { get; set; }

                    [NameInMap("shopping_item_map")]
                    [Validation(Required=false)]
                    public Dictionary<string, ModuleFlightItemListBestPriceItemShoppingItemMapValue> ShoppingItemMap { get; set; }

                    [NameInMap("sub_item_position_map")]
                    [Validation(Required=false)]
                    public Dictionary<string, List<ModuleFlightItemListBestPriceItemSubItemPositionMapValue>> SubItemPositionMap { get; set; }

                    [NameInMap("sub_items")]
                    [Validation(Required=false)]
                    public List<FlightListingSearchV2ResponseBodyModuleFlightItemListBestPriceItemSubItems> SubItems { get; set; }
                    public class FlightListingSearchV2ResponseBodyModuleFlightItemListBestPriceItemSubItems : TeaModel {
                        [NameInMap("shopping_item_map")]
                        [Validation(Required=false)]
                        public Dictionary<string, ModuleFlightItemListBestPriceItemSubItemsShoppingItemMapValue> ShoppingItemMap { get; set; }

                        [NameInMap("uniq_key")]
                        [Validation(Required=false)]
                        public string UniqKey { get; set; }

                    }

                }

                [NameInMap("flight_journey_infos")]
                [Validation(Required=false)]
                public List<FlightListingSearchV2ResponseBodyModuleFlightItemListFlightJourneyInfos> FlightJourneyInfos { get; set; }
                public class FlightListingSearchV2ResponseBodyModuleFlightItemListFlightJourneyInfos : TeaModel {
                    [NameInMap("arr_city_code")]
                    [Validation(Required=false)]
                    public string ArrCityCode { get; set; }

                    [NameInMap("arr_city_name")]
                    [Validation(Required=false)]
                    public string ArrCityName { get; set; }

                    [NameInMap("arr_time")]
                    [Validation(Required=false)]
                    public string ArrTime { get; set; }

                    [NameInMap("dep_city_code")]
                    [Validation(Required=false)]
                    public string DepCityCode { get; set; }

                    [NameInMap("dep_city_name")]
                    [Validation(Required=false)]
                    public string DepCityName { get; set; }

                    [NameInMap("dep_time")]
                    [Validation(Required=false)]
                    public string DepTime { get; set; }

                    [NameInMap("duration")]
                    [Validation(Required=false)]
                    public int? Duration { get; set; }

                    [NameInMap("extensions")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> Extensions { get; set; }

                    [NameInMap("flight_segment_infos")]
                    [Validation(Required=false)]
                    public List<FlightListingSearchV2ResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfos> FlightSegmentInfos { get; set; }
                    public class FlightListingSearchV2ResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfos : TeaModel {
                        [NameInMap("airline_info")]
                        [Validation(Required=false)]
                        public FlightListingSearchV2ResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosAirlineInfo AirlineInfo { get; set; }
                        public class FlightListingSearchV2ResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosAirlineInfo : TeaModel {
                            [NameInMap("airline_chinese_name")]
                            [Validation(Required=false)]
                            public string AirlineChineseName { get; set; }

                            [NameInMap("airline_chinese_short_name")]
                            [Validation(Required=false)]
                            public string AirlineChineseShortName { get; set; }

                            [NameInMap("airline_code")]
                            [Validation(Required=false)]
                            public string AirlineCode { get; set; }

                            [NameInMap("airline_icon")]
                            [Validation(Required=false)]
                            public string AirlineIcon { get; set; }

                            [NameInMap("cheap_flight")]
                            [Validation(Required=false)]
                            public bool? CheapFlight { get; set; }

                        }

                        [NameInMap("arr_airport_info")]
                        [Validation(Required=false)]
                        public FlightListingSearchV2ResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosArrAirportInfo ArrAirportInfo { get; set; }
                        public class FlightListingSearchV2ResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosArrAirportInfo : TeaModel {
                            [NameInMap("airport_code")]
                            [Validation(Required=false)]
                            public string AirportCode { get; set; }

                            [NameInMap("airport_name")]
                            [Validation(Required=false)]
                            public string AirportName { get; set; }

                            [NameInMap("airport_name_color")]
                            [Validation(Required=false)]
                            public string AirportNameColor { get; set; }

                            [NameInMap("airport_short_name")]
                            [Validation(Required=false)]
                            public string AirportShortName { get; set; }

                            [NameInMap("terminal")]
                            [Validation(Required=false)]
                            public string Terminal { get; set; }

                        }

                        [NameInMap("arr_city_code")]
                        [Validation(Required=false)]
                        public string ArrCityCode { get; set; }

                        [NameInMap("arr_city_name")]
                        [Validation(Required=false)]
                        public string ArrCityName { get; set; }

                        [NameInMap("arr_time")]
                        [Validation(Required=false)]
                        public string ArrTime { get; set; }

                        [NameInMap("baggage_desc")]
                        [Validation(Required=false)]
                        public string BaggageDesc { get; set; }

                        [NameInMap("dep_airport_info")]
                        [Validation(Required=false)]
                        public FlightListingSearchV2ResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosDepAirportInfo DepAirportInfo { get; set; }
                        public class FlightListingSearchV2ResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosDepAirportInfo : TeaModel {
                            [NameInMap("airport_code")]
                            [Validation(Required=false)]
                            public string AirportCode { get; set; }

                            [NameInMap("airport_name")]
                            [Validation(Required=false)]
                            public string AirportName { get; set; }

                            [NameInMap("airport_name_color")]
                            [Validation(Required=false)]
                            public string AirportNameColor { get; set; }

                            [NameInMap("airport_short_name")]
                            [Validation(Required=false)]
                            public string AirportShortName { get; set; }

                            [NameInMap("terminal")]
                            [Validation(Required=false)]
                            public string Terminal { get; set; }

                        }

                        [NameInMap("dep_city_code")]
                        [Validation(Required=false)]
                        public string DepCityCode { get; set; }

                        [NameInMap("dep_city_name")]
                        [Validation(Required=false)]
                        public string DepCityName { get; set; }

                        [NameInMap("dep_time")]
                        [Validation(Required=false)]
                        public string DepTime { get; set; }

                        /// <summary>
                        /// duration
                        /// </summary>
                        [NameInMap("duration")]
                        [Validation(Required=false)]
                        public int? Duration { get; set; }

                        [NameInMap("extra_info")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> ExtraInfo { get; set; }

                        [NameInMap("flight_no")]
                        [Validation(Required=false)]
                        public string FlightNo { get; set; }

                        [NameInMap("flight_share_info")]
                        [Validation(Required=false)]
                        public FlightListingSearchV2ResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosFlightShareInfo FlightShareInfo { get; set; }
                        public class FlightListingSearchV2ResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosFlightShareInfo : TeaModel {
                            [NameInMap("operating_airline_info")]
                            [Validation(Required=false)]
                            public FlightListingSearchV2ResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosFlightShareInfoOperatingAirlineInfo OperatingAirlineInfo { get; set; }
                            public class FlightListingSearchV2ResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosFlightShareInfoOperatingAirlineInfo : TeaModel {
                                [NameInMap("airline_chinese_name")]
                                [Validation(Required=false)]
                                public string AirlineChineseName { get; set; }

                                [NameInMap("airline_chinese_short_name")]
                                [Validation(Required=false)]
                                public string AirlineChineseShortName { get; set; }

                                [NameInMap("airline_code")]
                                [Validation(Required=false)]
                                public string AirlineCode { get; set; }

                                [NameInMap("airline_icon")]
                                [Validation(Required=false)]
                                public string AirlineIcon { get; set; }

                                [NameInMap("cheap_flight")]
                                [Validation(Required=false)]
                                public bool? CheapFlight { get; set; }

                            }

                            [NameInMap("operating_flight_no")]
                            [Validation(Required=false)]
                            public string OperatingFlightNo { get; set; }

                        }

                        [NameInMap("flight_size")]
                        [Validation(Required=false)]
                        public string FlightSize { get; set; }

                        [NameInMap("flight_stop_info")]
                        [Validation(Required=false)]
                        public FlightListingSearchV2ResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosFlightStopInfo FlightStopInfo { get; set; }
                        public class FlightListingSearchV2ResponseBodyModuleFlightItemListFlightJourneyInfosFlightSegmentInfosFlightStopInfo : TeaModel {
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

                            [NameInMap("stop_city_names")]
                            [Validation(Required=false)]
                            public List<string> StopCityNames { get; set; }

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

                        [NameInMap("flight_type")]
                        [Validation(Required=false)]
                        public string FlightType { get; set; }

                        [NameInMap("manufacturer")]
                        [Validation(Required=false)]
                        public string Manufacturer { get; set; }

                        [NameInMap("meal_desc")]
                        [Validation(Required=false)]
                        public string MealDesc { get; set; }

                        [NameInMap("miles")]
                        [Validation(Required=false)]
                        public int? Miles { get; set; }

                        [NameInMap("on_time_rate")]
                        [Validation(Required=false)]
                        public string OnTimeRate { get; set; }

                        [NameInMap("one_more")]
                        [Validation(Required=false)]
                        public int? OneMore { get; set; }

                        [NameInMap("one_more_show")]
                        [Validation(Required=false)]
                        public string OneMoreShow { get; set; }

                        [NameInMap("segment_index")]
                        [Validation(Required=false)]
                        public int? SegmentIndex { get; set; }

                        [NameInMap("share")]
                        [Validation(Required=false)]
                        public bool? Share { get; set; }

                        [NameInMap("short_flight_size")]
                        [Validation(Required=false)]
                        public string ShortFlightSize { get; set; }

                        [NameInMap("stop")]
                        [Validation(Required=false)]
                        public bool? Stop { get; set; }

                        [NameInMap("total_time")]
                        [Validation(Required=false)]
                        public string TotalTime { get; set; }

                        [NameInMap("transfer_time")]
                        [Validation(Required=false)]
                        public string TransferTime { get; set; }

                        [NameInMap("transfer_time_number")]
                        [Validation(Required=false)]
                        public int? TransferTimeNumber { get; set; }

                    }

                    [NameInMap("journey_index")]
                    [Validation(Required=false)]
                    public int? JourneyIndex { get; set; }

                    [NameInMap("transfer_time")]
                    [Validation(Required=false)]
                    public int? TransferTime { get; set; }

                }

                [NameInMap("item_list")]
                [Validation(Required=false)]
                public List<FlightListingSearchV2ResponseBodyModuleFlightItemListItemList> ItemList { get; set; }
                public class FlightListingSearchV2ResponseBodyModuleFlightItemListItemList : TeaModel {
                    [NameInMap("flight_rule_infos")]
                    [Validation(Required=false)]
                    public Dictionary<string, ModuleFlightItemListItemListFlightRuleInfosValue> FlightRuleInfos { get; set; }

                    [NameInMap("item_id")]
                    [Validation(Required=false)]
                    public string ItemId { get; set; }

                    [NameInMap("shopping_item_map")]
                    [Validation(Required=false)]
                    public Dictionary<string, ModuleFlightItemListItemListShoppingItemMapValue> ShoppingItemMap { get; set; }

                    [NameInMap("sub_item_position_map")]
                    [Validation(Required=false)]
                    public Dictionary<string, List<ModuleFlightItemListItemListSubItemPositionMapValue>> SubItemPositionMap { get; set; }

                    [NameInMap("sub_items")]
                    [Validation(Required=false)]
                    public List<FlightListingSearchV2ResponseBodyModuleFlightItemListItemListSubItems> SubItems { get; set; }
                    public class FlightListingSearchV2ResponseBodyModuleFlightItemListItemListSubItems : TeaModel {
                        [NameInMap("shopping_item_map")]
                        [Validation(Required=false)]
                        public Dictionary<string, ModuleFlightItemListItemListSubItemsShoppingItemMapValue> ShoppingItemMap { get; set; }

                        [NameInMap("uniq_key")]
                        [Validation(Required=false)]
                        public string UniqKey { get; set; }

                    }

                }

            }

            [NameInMap("search_mode")]
            [Validation(Required=false)]
            public int? SearchMode { get; set; }

            [NameInMap("trip_type")]
            [Validation(Required=false)]
            public int? TripType { get; set; }

        }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// traceId
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
