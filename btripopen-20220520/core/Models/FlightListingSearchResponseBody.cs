// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightListingSearchResponseBody : TeaModel {
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
        public FlightListingSearchResponseBodyModule Module { get; set; }
        public class FlightListingSearchResponseBodyModule : TeaModel {
            [NameInMap("flight_list")]
            [Validation(Required=false)]
            public List<FlightListingSearchResponseBodyModuleFlightList> FlightList { get; set; }
            public class FlightListingSearchResponseBodyModuleFlightList : TeaModel {
                [NameInMap("airline_info")]
                [Validation(Required=false)]
                public FlightListingSearchResponseBodyModuleFlightListAirlineInfo AirlineInfo { get; set; }
                public class FlightListingSearchResponseBodyModuleFlightListAirlineInfo : TeaModel {
                    [NameInMap("airline_code")]
                    [Validation(Required=false)]
                    public string AirlineCode { get; set; }

                    [NameInMap("airline_name")]
                    [Validation(Required=false)]
                    public string AirlineName { get; set; }

                    [NameInMap("airline_simple_name")]
                    [Validation(Required=false)]
                    public string AirlineSimpleName { get; set; }

                }

                [NameInMap("arr_airport_info")]
                [Validation(Required=false)]
                public FlightListingSearchResponseBodyModuleFlightListArrAirportInfo ArrAirportInfo { get; set; }
                public class FlightListingSearchResponseBodyModuleFlightListArrAirportInfo : TeaModel {
                    [NameInMap("airport_code")]
                    [Validation(Required=false)]
                    public string AirportCode { get; set; }

                    [NameInMap("airport_name")]
                    [Validation(Required=false)]
                    public string AirportName { get; set; }

                    [NameInMap("city_code")]
                    [Validation(Required=false)]
                    public string CityCode { get; set; }

                    [NameInMap("city_name")]
                    [Validation(Required=false)]
                    public string CityName { get; set; }

                    [NameInMap("terminal")]
                    [Validation(Required=false)]
                    public string Terminal { get; set; }

                }

                [NameInMap("arr_date")]
                [Validation(Required=false)]
                public string ArrDate { get; set; }

                [NameInMap("basic_cabin_price")]
                [Validation(Required=false)]
                public int? BasicCabinPrice { get; set; }

                [NameInMap("build_price")]
                [Validation(Required=false)]
                public int? BuildPrice { get; set; }

                [NameInMap("cabin")]
                [Validation(Required=false)]
                public string Cabin { get; set; }

                [NameInMap("cabin_class")]
                [Validation(Required=false)]
                public string CabinClass { get; set; }

                [NameInMap("carrier_airline")]
                [Validation(Required=false)]
                public string CarrierAirline { get; set; }

                [NameInMap("carrier_no")]
                [Validation(Required=false)]
                public string CarrierNo { get; set; }

                [NameInMap("dep_airport_info")]
                [Validation(Required=false)]
                public FlightListingSearchResponseBodyModuleFlightListDepAirportInfo DepAirportInfo { get; set; }
                public class FlightListingSearchResponseBodyModuleFlightListDepAirportInfo : TeaModel {
                    [NameInMap("airport_code")]
                    [Validation(Required=false)]
                    public string AirportCode { get; set; }

                    [NameInMap("airport_name")]
                    [Validation(Required=false)]
                    public string AirportName { get; set; }

                    [NameInMap("city_code")]
                    [Validation(Required=false)]
                    public string CityCode { get; set; }

                    [NameInMap("city_name")]
                    [Validation(Required=false)]
                    public string CityName { get; set; }

                    [NameInMap("terminal")]
                    [Validation(Required=false)]
                    public string Terminal { get; set; }

                }

                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                [NameInMap("dep_date")]
                [Validation(Required=false)]
                public string DepDate { get; set; }

                [NameInMap("discount")]
                [Validation(Required=false)]
                public int? Discount { get; set; }

                [NameInMap("flight_no")]
                [Validation(Required=false)]
                public string FlightNo { get; set; }

                [NameInMap("flight_rule_list")]
                [Validation(Required=false)]
                public List<FlightListingSearchResponseBodyModuleFlightListFlightRuleList> FlightRuleList { get; set; }
                public class FlightListingSearchResponseBodyModuleFlightListFlightRuleList : TeaModel {
                    [NameInMap("baggage_info")]
                    [Validation(Required=false)]
                    public string BaggageInfo { get; set; }

                    [NameInMap("baggage_item")]
                    [Validation(Required=false)]
                    public FlightListingSearchResponseBodyModuleFlightListFlightRuleListBaggageItem BaggageItem { get; set; }
                    public class FlightListingSearchResponseBodyModuleFlightListFlightRuleListBaggageItem : TeaModel {
                        [NameInMap("baggage_sub_items")]
                        [Validation(Required=false)]
                        public List<FlightListingSearchResponseBodyModuleFlightListFlightRuleListBaggageItemBaggageSubItems> BaggageSubItems { get; set; }
                        public class FlightListingSearchResponseBodyModuleFlightListFlightRuleListBaggageItemBaggageSubItems : TeaModel {
                            [NameInMap("baggage_sub_content_visualizes")]
                            [Validation(Required=false)]
                            public List<FlightListingSearchResponseBodyModuleFlightListFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizes> BaggageSubContentVisualizes { get; set; }
                            public class FlightListingSearchResponseBodyModuleFlightListFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizes : TeaModel {
                                [NameInMap("baggage_desc")]
                                [Validation(Required=false)]
                                public List<string> BaggageDesc { get; set; }

                                [NameInMap("baggage_sub_content_type")]
                                [Validation(Required=false)]
                                public int? BaggageSubContentType { get; set; }

                                [NameInMap("description")]
                                [Validation(Required=false)]
                                public FlightListingSearchResponseBodyModuleFlightListFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizesDescription Description { get; set; }
                                public class FlightListingSearchResponseBodyModuleFlightListFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizesDescription : TeaModel {
                                    [NameInMap("desc")]
                                    [Validation(Required=false)]
                                    public string Desc { get; set; }

                                    [NameInMap("icon")]
                                    [Validation(Required=false)]
                                    public string Icon { get; set; }

                                    [NameInMap("image")]
                                    [Validation(Required=false)]
                                    public string Image { get; set; }

                                    [NameInMap("title")]
                                    [Validation(Required=false)]
                                    public string Title { get; set; }

                                }

                                [NameInMap("image_d_o")]
                                [Validation(Required=false)]
                                public FlightListingSearchResponseBodyModuleFlightListFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizesImageDO ImageDO { get; set; }
                                public class FlightListingSearchResponseBodyModuleFlightListFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizesImageDO : TeaModel {
                                    [NameInMap("image")]
                                    [Validation(Required=false)]
                                    public string Image { get; set; }

                                    [NameInMap("largest")]
                                    [Validation(Required=false)]
                                    public string Largest { get; set; }

                                    [NameInMap("middle")]
                                    [Validation(Required=false)]
                                    public string Middle { get; set; }

                                    [NameInMap("smallest")]
                                    [Validation(Required=false)]
                                    public string Smallest { get; set; }

                                }

                                [NameInMap("is_highlight")]
                                [Validation(Required=false)]
                                public bool? IsHighlight { get; set; }

                                [NameInMap("sub_title")]
                                [Validation(Required=false)]
                                public string SubTitle { get; set; }

                            }

                            [NameInMap("extra_content_visualizes")]
                            [Validation(Required=false)]
                            public List<object> ExtraContentVisualizes { get; set; }

                            [NameInMap("is_struct")]
                            [Validation(Required=false)]
                            public bool? IsStruct { get; set; }

                            /// <summary>
                            /// PTC
                            /// </summary>
                            [NameInMap("ptc")]
                            [Validation(Required=false)]
                            public string Ptc { get; set; }

                            [NameInMap("title")]
                            [Validation(Required=false)]
                            public string Title { get; set; }

                        }

                        [NameInMap("index")]
                        [Validation(Required=false)]
                        public int? Index { get; set; }

                        [NameInMap("table_head")]
                        [Validation(Required=false)]
                        public string TableHead { get; set; }

                        [NameInMap("tips")]
                        [Validation(Required=false)]
                        public FlightListingSearchResponseBodyModuleFlightListFlightRuleListBaggageItemTips Tips { get; set; }
                        public class FlightListingSearchResponseBodyModuleFlightListFlightRuleListBaggageItemTips : TeaModel {
                            [NameInMap("logo")]
                            [Validation(Required=false)]
                            public string Logo { get; set; }

                            [NameInMap("tips_desc")]
                            [Validation(Required=false)]
                            public string TipsDesc { get; set; }

                            [NameInMap("tips_image")]
                            [Validation(Required=false)]
                            public string TipsImage { get; set; }

                        }

                        [NameInMap("title")]
                        [Validation(Required=false)]
                        public string Title { get; set; }

                        [NameInMap("type")]
                        [Validation(Required=false)]
                        public int? Type { get; set; }

                    }

                    [NameInMap("change_rule")]
                    [Validation(Required=false)]
                    public FlightListingSearchResponseBodyModuleFlightListFlightRuleListChangeRule ChangeRule { get; set; }
                    public class FlightListingSearchResponseBodyModuleFlightListFlightRuleListChangeRule : TeaModel {
                        [NameInMap("able")]
                        [Validation(Required=false)]
                        public bool? Able { get; set; }

                        [NameInMap("info")]
                        [Validation(Required=false)]
                        public List<FlightListingSearchResponseBodyModuleFlightListFlightRuleListChangeRuleInfo> Info { get; set; }
                        public class FlightListingSearchResponseBodyModuleFlightListFlightRuleListChangeRuleInfo : TeaModel {
                            [NameInMap("content")]
                            [Validation(Required=false)]
                            public string Content { get; set; }

                            [NameInMap("cost")]
                            [Validation(Required=false)]
                            public int? Cost { get; set; }

                            [NameInMap("cost_percent")]
                            [Validation(Required=false)]
                            public int? CostPercent { get; set; }

                            [NameInMap("time_stamp")]
                            [Validation(Required=false)]
                            public int? TimeStamp { get; set; }

                            [NameInMap("time_type")]
                            [Validation(Required=false)]
                            public string TimeType { get; set; }

                            [NameInMap("title")]
                            [Validation(Required=false)]
                            public string Title { get; set; }

                        }

                    }

                    [NameInMap("change_rule_item")]
                    [Validation(Required=false)]
                    public FlightListingSearchResponseBodyModuleFlightListFlightRuleListChangeRuleItem ChangeRuleItem { get; set; }
                    public class FlightListingSearchResponseBodyModuleFlightListFlightRuleListChangeRuleItem : TeaModel {
                        [NameInMap("extra_contents")]
                        [Validation(Required=false)]
                        public List<FlightListingSearchResponseBodyModuleFlightListFlightRuleListChangeRuleItemExtraContents> ExtraContents { get; set; }
                        public class FlightListingSearchResponseBodyModuleFlightListFlightRuleListChangeRuleItemExtraContents : TeaModel {
                            [NameInMap("content")]
                            [Validation(Required=false)]
                            public string Content { get; set; }

                            [NameInMap("title")]
                            [Validation(Required=false)]
                            public string Title { get; set; }

                        }

                        [NameInMap("index")]
                        [Validation(Required=false)]
                        public int? Index { get; set; }

                        [NameInMap("refund_sub_items")]
                        [Validation(Required=false)]
                        public List<FlightListingSearchResponseBodyModuleFlightListFlightRuleListChangeRuleItemRefundSubItems> RefundSubItems { get; set; }
                        public class FlightListingSearchResponseBodyModuleFlightListFlightRuleListChangeRuleItemRefundSubItems : TeaModel {
                            /// <summary>
                            /// isStruct : true
                            /// </summary>
                            [NameInMap("is_struct")]
                            [Validation(Required=false)]
                            public bool? IsStruct { get; set; }

                            /// <summary>
                            /// PTC
                            /// </summary>
                            [NameInMap("ptc")]
                            [Validation(Required=false)]
                            public string Ptc { get; set; }

                            [NameInMap("refund_sub_contents")]
                            [Validation(Required=false)]
                            public List<FlightListingSearchResponseBodyModuleFlightListFlightRuleListChangeRuleItemRefundSubItemsRefundSubContents> RefundSubContents { get; set; }
                            public class FlightListingSearchResponseBodyModuleFlightListFlightRuleListChangeRuleItemRefundSubItemsRefundSubContents : TeaModel {
                                [NameInMap("fee_desc")]
                                [Validation(Required=false)]
                                public string FeeDesc { get; set; }

                                [NameInMap("fee_range")]
                                [Validation(Required=false)]
                                public string FeeRange { get; set; }

                                [NameInMap("style")]
                                [Validation(Required=false)]
                                public int? Style { get; set; }

                            }

                            [NameInMap("title")]
                            [Validation(Required=false)]
                            public string Title { get; set; }

                        }

                        [NameInMap("sub_table_head")]
                        [Validation(Required=false)]
                        public List<string> SubTableHead { get; set; }

                        [NameInMap("table_head")]
                        [Validation(Required=false)]
                        public string TableHead { get; set; }

                        [NameInMap("title")]
                        [Validation(Required=false)]
                        public string Title { get; set; }

                        [NameInMap("type")]
                        [Validation(Required=false)]
                        public int? Type { get; set; }

                    }

                    [NameInMap("extra")]
                    [Validation(Required=false)]
                    public string Extra { get; set; }

                    [NameInMap("refund_rule")]
                    [Validation(Required=false)]
                    public FlightListingSearchResponseBodyModuleFlightListFlightRuleListRefundRule RefundRule { get; set; }
                    public class FlightListingSearchResponseBodyModuleFlightListFlightRuleListRefundRule : TeaModel {
                        [NameInMap("able")]
                        [Validation(Required=false)]
                        public bool? Able { get; set; }

                        [NameInMap("info")]
                        [Validation(Required=false)]
                        public List<FlightListingSearchResponseBodyModuleFlightListFlightRuleListRefundRuleInfo> Info { get; set; }
                        public class FlightListingSearchResponseBodyModuleFlightListFlightRuleListRefundRuleInfo : TeaModel {
                            [NameInMap("content")]
                            [Validation(Required=false)]
                            public string Content { get; set; }

                            [NameInMap("cost")]
                            [Validation(Required=false)]
                            public int? Cost { get; set; }

                            [NameInMap("cost_percent")]
                            [Validation(Required=false)]
                            public int? CostPercent { get; set; }

                            [NameInMap("time_stamp")]
                            [Validation(Required=false)]
                            public int? TimeStamp { get; set; }

                            [NameInMap("time_type")]
                            [Validation(Required=false)]
                            public string TimeType { get; set; }

                            [NameInMap("title")]
                            [Validation(Required=false)]
                            public string Title { get; set; }

                        }

                    }

                    [NameInMap("refund_rule_item")]
                    [Validation(Required=false)]
                    public FlightListingSearchResponseBodyModuleFlightListFlightRuleListRefundRuleItem RefundRuleItem { get; set; }
                    public class FlightListingSearchResponseBodyModuleFlightListFlightRuleListRefundRuleItem : TeaModel {
                        [NameInMap("extra_contents")]
                        [Validation(Required=false)]
                        public List<FlightListingSearchResponseBodyModuleFlightListFlightRuleListRefundRuleItemExtraContents> ExtraContents { get; set; }
                        public class FlightListingSearchResponseBodyModuleFlightListFlightRuleListRefundRuleItemExtraContents : TeaModel {
                            [NameInMap("content")]
                            [Validation(Required=false)]
                            public string Content { get; set; }

                            [NameInMap("title")]
                            [Validation(Required=false)]
                            public string Title { get; set; }

                        }

                        [NameInMap("index")]
                        [Validation(Required=false)]
                        public int? Index { get; set; }

                        [NameInMap("refund_sub_items")]
                        [Validation(Required=false)]
                        public List<FlightListingSearchResponseBodyModuleFlightListFlightRuleListRefundRuleItemRefundSubItems> RefundSubItems { get; set; }
                        public class FlightListingSearchResponseBodyModuleFlightListFlightRuleListRefundRuleItemRefundSubItems : TeaModel {
                            [NameInMap("is_struct")]
                            [Validation(Required=false)]
                            public bool? IsStruct { get; set; }

                            /// <summary>
                            /// PTC
                            /// </summary>
                            [NameInMap("ptc")]
                            [Validation(Required=false)]
                            public string Ptc { get; set; }

                            [NameInMap("refund_sub_contents")]
                            [Validation(Required=false)]
                            public List<FlightListingSearchResponseBodyModuleFlightListFlightRuleListRefundRuleItemRefundSubItemsRefundSubContents> RefundSubContents { get; set; }
                            public class FlightListingSearchResponseBodyModuleFlightListFlightRuleListRefundRuleItemRefundSubItemsRefundSubContents : TeaModel {
                                [NameInMap("fee_desc")]
                                [Validation(Required=false)]
                                public string FeeDesc { get; set; }

                                [NameInMap("fee_range")]
                                [Validation(Required=false)]
                                public string FeeRange { get; set; }

                                [NameInMap("style")]
                                [Validation(Required=false)]
                                public int? Style { get; set; }

                            }

                            [NameInMap("title")]
                            [Validation(Required=false)]
                            public string Title { get; set; }

                        }

                        [NameInMap("sub_table_head")]
                        [Validation(Required=false)]
                        public List<string> SubTableHead { get; set; }

                        [NameInMap("table_head")]
                        [Validation(Required=false)]
                        public string TableHead { get; set; }

                        [NameInMap("title")]
                        [Validation(Required=false)]
                        public string Title { get; set; }

                        [NameInMap("type")]
                        [Validation(Required=false)]
                        public int? Type { get; set; }

                    }

                    [NameInMap("sign_rule")]
                    [Validation(Required=false)]
                    public FlightListingSearchResponseBodyModuleFlightListFlightRuleListSignRule SignRule { get; set; }
                    public class FlightListingSearchResponseBodyModuleFlightListFlightRuleListSignRule : TeaModel {
                        [NameInMap("able")]
                        [Validation(Required=false)]
                        public bool? Able { get; set; }

                        [NameInMap("info")]
                        [Validation(Required=false)]
                        public List<FlightListingSearchResponseBodyModuleFlightListFlightRuleListSignRuleInfo> Info { get; set; }
                        public class FlightListingSearchResponseBodyModuleFlightListFlightRuleListSignRuleInfo : TeaModel {
                            [NameInMap("content")]
                            [Validation(Required=false)]
                            public string Content { get; set; }

                            [NameInMap("cost")]
                            [Validation(Required=false)]
                            public int? Cost { get; set; }

                            [NameInMap("cost_percent")]
                            [Validation(Required=false)]
                            public int? CostPercent { get; set; }

                            [NameInMap("time_stamp")]
                            [Validation(Required=false)]
                            public int? TimeStamp { get; set; }

                            [NameInMap("time_type")]
                            [Validation(Required=false)]
                            public string TimeType { get; set; }

                            [NameInMap("title")]
                            [Validation(Required=false)]
                            public string Title { get; set; }

                        }

                    }

                    [NameInMap("tuigaiqian_info")]
                    [Validation(Required=false)]
                    public string TuigaiqianInfo { get; set; }

                    [NameInMap("upgrade_rule")]
                    [Validation(Required=false)]
                    public FlightListingSearchResponseBodyModuleFlightListFlightRuleListUpgradeRule UpgradeRule { get; set; }
                    public class FlightListingSearchResponseBodyModuleFlightListFlightRuleListUpgradeRule : TeaModel {
                        [NameInMap("able")]
                        [Validation(Required=false)]
                        public bool? Able { get; set; }

                        [NameInMap("info")]
                        [Validation(Required=false)]
                        public List<FlightListingSearchResponseBodyModuleFlightListFlightRuleListUpgradeRuleInfo> Info { get; set; }
                        public class FlightListingSearchResponseBodyModuleFlightListFlightRuleListUpgradeRuleInfo : TeaModel {
                            [NameInMap("content")]
                            [Validation(Required=false)]
                            public string Content { get; set; }

                            [NameInMap("cost")]
                            [Validation(Required=false)]
                            public int? Cost { get; set; }

                            [NameInMap("cost_percent")]
                            [Validation(Required=false)]
                            public int? CostPercent { get; set; }

                            [NameInMap("time_stamp")]
                            [Validation(Required=false)]
                            public int? TimeStamp { get; set; }

                            [NameInMap("time_type")]
                            [Validation(Required=false)]
                            public string TimeType { get; set; }

                            [NameInMap("title")]
                            [Validation(Required=false)]
                            public string Title { get; set; }

                        }

                    }

                }

                [NameInMap("flight_rule_list_str")]
                [Validation(Required=false)]
                public string FlightRuleListStr { get; set; }

                [NameInMap("flight_size")]
                [Validation(Required=false)]
                public string FlightSize { get; set; }

                [NameInMap("flight_type")]
                [Validation(Required=false)]
                public string FlightType { get; set; }

                [NameInMap("invoice_type")]
                [Validation(Required=false)]
                public int? InvoiceType { get; set; }

                [NameInMap("is_protocol")]
                [Validation(Required=false)]
                public bool? IsProtocol { get; set; }

                [NameInMap("is_share")]
                [Validation(Required=false)]
                public bool? IsShare { get; set; }

                [NameInMap("is_stop")]
                [Validation(Required=false)]
                public bool? IsStop { get; set; }

                [NameInMap("is_transfer")]
                [Validation(Required=false)]
                public bool? IsTransfer { get; set; }

                [NameInMap("meal_desc")]
                [Validation(Required=false)]
                public string MealDesc { get; set; }

                [NameInMap("oil_price")]
                [Validation(Required=false)]
                public int? OilPrice { get; set; }

                [NameInMap("ota_item_id")]
                [Validation(Required=false)]
                public string OtaItemId { get; set; }

                [NameInMap("price")]
                [Validation(Required=false)]
                public int? Price { get; set; }

                [NameInMap("product_type")]
                [Validation(Required=false)]
                public long? ProductType { get; set; }

                [NameInMap("product_type_desc")]
                [Validation(Required=false)]
                public string ProductTypeDesc { get; set; }

                [NameInMap("promotion_price")]
                [Validation(Required=false)]
                public string PromotionPrice { get; set; }

                [NameInMap("remained_seat_count")]
                [Validation(Required=false)]
                public string RemainedSeatCount { get; set; }

                [NameInMap("secret_params")]
                [Validation(Required=false)]
                public string SecretParams { get; set; }

                [NameInMap("segment_number")]
                [Validation(Required=false)]
                public string SegmentNumber { get; set; }

                [NameInMap("stop_arr_time")]
                [Validation(Required=false)]
                public string StopArrTime { get; set; }

                [NameInMap("stop_city")]
                [Validation(Required=false)]
                public string StopCity { get; set; }

                [NameInMap("stop_dep_time")]
                [Validation(Required=false)]
                public string StopDepTime { get; set; }

                [NameInMap("ticket_price")]
                [Validation(Required=false)]
                public int? TicketPrice { get; set; }

                [NameInMap("total_price")]
                [Validation(Required=false)]
                public string TotalPrice { get; set; }

                [NameInMap("trip_type")]
                [Validation(Required=false)]
                public int? TripType { get; set; }

            }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
