// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightSearchListResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public FlightSearchListResponseBodyModule Module { get; set; }
        public class FlightSearchListResponseBodyModule : TeaModel {
            [NameInMap("flight_list")]
            [Validation(Required=false)]
            public List<FlightSearchListResponseBodyModuleFlightList> FlightList { get; set; }
            public class FlightSearchListResponseBodyModuleFlightList : TeaModel {
                [NameInMap("airline_info")]
                [Validation(Required=false)]
                public FlightSearchListResponseBodyModuleFlightListAirlineInfo AirlineInfo { get; set; }
                public class FlightSearchListResponseBodyModuleFlightListAirlineInfo : TeaModel {
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
                public FlightSearchListResponseBodyModuleFlightListArrAirportInfo ArrAirportInfo { get; set; }
                public class FlightSearchListResponseBodyModuleFlightListArrAirportInfo : TeaModel {
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

                [NameInMap("cabin_info_list")]
                [Validation(Required=false)]
                public List<FlightSearchListResponseBodyModuleFlightListCabinInfoList> CabinInfoList { get; set; }
                public class FlightSearchListResponseBodyModuleFlightListCabinInfoList : TeaModel {
                    [NameInMap("agent_id")]
                    [Validation(Required=false)]
                    public long? AgentId { get; set; }

                    [NameInMap("build_price")]
                    [Validation(Required=false)]
                    public int? BuildPrice { get; set; }

                    [NameInMap("cabin")]
                    [Validation(Required=false)]
                    public string Cabin { get; set; }

                    [NameInMap("cabin_class")]
                    [Validation(Required=false)]
                    public string CabinClass { get; set; }

                    [NameInMap("cabin_class_name")]
                    [Validation(Required=false)]
                    public string CabinClassName { get; set; }

                    [NameInMap("child_cabin")]
                    [Validation(Required=false)]
                    public string ChildCabin { get; set; }

                    [NameInMap("class_name")]
                    [Validation(Required=false)]
                    public string ClassName { get; set; }

                    [NameInMap("class_rule")]
                    [Validation(Required=false)]
                    public string ClassRule { get; set; }

                    [NameInMap("discount")]
                    [Validation(Required=false)]
                    public string Discount { get; set; }

                    [NameInMap("flight_rule_list")]
                    [Validation(Required=false)]
                    public List<FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleList> FlightRuleList { get; set; }
                    public class FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleList : TeaModel {
                        [NameInMap("baggage_info")]
                        [Validation(Required=false)]
                        public string BaggageInfo { get; set; }

                        [NameInMap("baggage_item")]
                        [Validation(Required=false)]
                        public FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListBaggageItem BaggageItem { get; set; }
                        public class FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListBaggageItem : TeaModel {
                            [NameInMap("baggage_sub_items")]
                            [Validation(Required=false)]
                            public List<FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListBaggageItemBaggageSubItems> BaggageSubItems { get; set; }
                            public class FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListBaggageItemBaggageSubItems : TeaModel {
                                [NameInMap("baggage_sub_content_visualizes")]
                                [Validation(Required=false)]
                                public List<FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizes> BaggageSubContentVisualizes { get; set; }
                                public class FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizes : TeaModel {
                                    [NameInMap("baggage_desc")]
                                    [Validation(Required=false)]
                                    public List<string> BaggageDesc { get; set; }

                                    [NameInMap("baggage_sub_content_type")]
                                    [Validation(Required=false)]
                                    public int? BaggageSubContentType { get; set; }

                                    [NameInMap("description")]
                                    [Validation(Required=false)]
                                    public FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizesDescription Description { get; set; }
                                    public class FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizesDescription : TeaModel {
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
                                    public FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizesImageDO ImageDO { get; set; }
                                    public class FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizesImageDO : TeaModel {
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
                            public FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListBaggageItemTips Tips { get; set; }
                            public class FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListBaggageItemTips : TeaModel {
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
                        public FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListChangeRule ChangeRule { get; set; }
                        public class FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListChangeRule : TeaModel {
                            [NameInMap("able")]
                            [Validation(Required=false)]
                            public bool? Able { get; set; }

                            [NameInMap("info")]
                            [Validation(Required=false)]
                            public List<FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListChangeRuleInfo> Info { get; set; }
                            public class FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListChangeRuleInfo : TeaModel {
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
                        public FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListChangeRuleItem ChangeRuleItem { get; set; }
                        public class FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListChangeRuleItem : TeaModel {
                            [NameInMap("extra_contents")]
                            [Validation(Required=false)]
                            public List<FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListChangeRuleItemExtraContents> ExtraContents { get; set; }
                            public class FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListChangeRuleItemExtraContents : TeaModel {
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
                            public List<FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListChangeRuleItemRefundSubItems> RefundSubItems { get; set; }
                            public class FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListChangeRuleItemRefundSubItems : TeaModel {
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
                                public List<FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListChangeRuleItemRefundSubItemsRefundSubContents> RefundSubContents { get; set; }
                                public class FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListChangeRuleItemRefundSubItemsRefundSubContents : TeaModel {
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
                        public FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListRefundRule RefundRule { get; set; }
                        public class FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListRefundRule : TeaModel {
                            [NameInMap("able")]
                            [Validation(Required=false)]
                            public bool? Able { get; set; }

                            [NameInMap("info")]
                            [Validation(Required=false)]
                            public List<FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListRefundRuleInfo> Info { get; set; }
                            public class FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListRefundRuleInfo : TeaModel {
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
                        public FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListRefundRuleItem RefundRuleItem { get; set; }
                        public class FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListRefundRuleItem : TeaModel {
                            [NameInMap("extra_contents")]
                            [Validation(Required=false)]
                            public List<FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListRefundRuleItemExtraContents> ExtraContents { get; set; }
                            public class FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListRefundRuleItemExtraContents : TeaModel {
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
                            public List<FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListRefundRuleItemRefundSubItems> RefundSubItems { get; set; }
                            public class FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListRefundRuleItemRefundSubItems : TeaModel {
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
                                public List<FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListRefundRuleItemRefundSubItemsRefundSubContents> RefundSubContents { get; set; }
                                public class FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListRefundRuleItemRefundSubItemsRefundSubContents : TeaModel {
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
                        public FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListSignRule SignRule { get; set; }
                        public class FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListSignRule : TeaModel {
                            [NameInMap("able")]
                            [Validation(Required=false)]
                            public bool? Able { get; set; }

                            [NameInMap("info")]
                            [Validation(Required=false)]
                            public List<FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListSignRuleInfo> Info { get; set; }
                            public class FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListSignRuleInfo : TeaModel {
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
                        public FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListUpgradeRule UpgradeRule { get; set; }
                        public class FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListUpgradeRule : TeaModel {
                            [NameInMap("able")]
                            [Validation(Required=false)]
                            public bool? Able { get; set; }

                            [NameInMap("info")]
                            [Validation(Required=false)]
                            public List<FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListUpgradeRuleInfo> Info { get; set; }
                            public class FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListUpgradeRuleInfo : TeaModel {
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

                    [NameInMap("invoice_type")]
                    [Validation(Required=false)]
                    public int? InvoiceType { get; set; }

                    [NameInMap("is_protocol")]
                    [Validation(Required=false)]
                    public bool? IsProtocol { get; set; }

                    [NameInMap("memo")]
                    [Validation(Required=false)]
                    public string Memo { get; set; }

                    [NameInMap("oil_price")]
                    [Validation(Required=false)]
                    public int? OilPrice { get; set; }

                    [NameInMap("order_params")]
                    [Validation(Required=false)]
                    public string OrderParams { get; set; }

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

                    [NameInMap("ticket_price")]
                    [Validation(Required=false)]
                    public int? TicketPrice { get; set; }

                    [NameInMap("total_price")]
                    [Validation(Required=false)]
                    public int? TotalPrice { get; set; }

                }

                [NameInMap("carrier_airline")]
                [Validation(Required=false)]
                public string CarrierAirline { get; set; }

                [NameInMap("carrier_no")]
                [Validation(Required=false)]
                public string CarrierNo { get; set; }

                [NameInMap("class_rule")]
                [Validation(Required=false)]
                public string ClassRule { get; set; }

                [NameInMap("dep_airport_info")]
                [Validation(Required=false)]
                public FlightSearchListResponseBodyModuleFlightListDepAirportInfo DepAirportInfo { get; set; }
                public class FlightSearchListResponseBodyModuleFlightListDepAirportInfo : TeaModel {
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
                public List<FlightSearchListResponseBodyModuleFlightListFlightRuleList> FlightRuleList { get; set; }
                public class FlightSearchListResponseBodyModuleFlightListFlightRuleList : TeaModel {
                    [NameInMap("baggage_info")]
                    [Validation(Required=false)]
                    public string BaggageInfo { get; set; }

                    [NameInMap("baggage_item")]
                    [Validation(Required=false)]
                    public FlightSearchListResponseBodyModuleFlightListFlightRuleListBaggageItem BaggageItem { get; set; }
                    public class FlightSearchListResponseBodyModuleFlightListFlightRuleListBaggageItem : TeaModel {
                        [NameInMap("baggage_sub_items")]
                        [Validation(Required=false)]
                        public List<FlightSearchListResponseBodyModuleFlightListFlightRuleListBaggageItemBaggageSubItems> BaggageSubItems { get; set; }
                        public class FlightSearchListResponseBodyModuleFlightListFlightRuleListBaggageItemBaggageSubItems : TeaModel {
                            [NameInMap("baggage_sub_content_visualizes")]
                            [Validation(Required=false)]
                            public List<FlightSearchListResponseBodyModuleFlightListFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizes> BaggageSubContentVisualizes { get; set; }
                            public class FlightSearchListResponseBodyModuleFlightListFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizes : TeaModel {
                                [NameInMap("baggage_desc")]
                                [Validation(Required=false)]
                                public List<string> BaggageDesc { get; set; }

                                [NameInMap("baggage_sub_content_type")]
                                [Validation(Required=false)]
                                public int? BaggageSubContentType { get; set; }

                                [NameInMap("description")]
                                [Validation(Required=false)]
                                public FlightSearchListResponseBodyModuleFlightListFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizesDescription Description { get; set; }
                                public class FlightSearchListResponseBodyModuleFlightListFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizesDescription : TeaModel {
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
                                public FlightSearchListResponseBodyModuleFlightListFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizesImageDO ImageDO { get; set; }
                                public class FlightSearchListResponseBodyModuleFlightListFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizesImageDO : TeaModel {
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
                        public FlightSearchListResponseBodyModuleFlightListFlightRuleListBaggageItemTips Tips { get; set; }
                        public class FlightSearchListResponseBodyModuleFlightListFlightRuleListBaggageItemTips : TeaModel {
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
                    public FlightSearchListResponseBodyModuleFlightListFlightRuleListChangeRule ChangeRule { get; set; }
                    public class FlightSearchListResponseBodyModuleFlightListFlightRuleListChangeRule : TeaModel {
                        [NameInMap("able")]
                        [Validation(Required=false)]
                        public bool? Able { get; set; }

                        [NameInMap("info")]
                        [Validation(Required=false)]
                        public List<FlightSearchListResponseBodyModuleFlightListFlightRuleListChangeRuleInfo> Info { get; set; }
                        public class FlightSearchListResponseBodyModuleFlightListFlightRuleListChangeRuleInfo : TeaModel {
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
                    public FlightSearchListResponseBodyModuleFlightListFlightRuleListChangeRuleItem ChangeRuleItem { get; set; }
                    public class FlightSearchListResponseBodyModuleFlightListFlightRuleListChangeRuleItem : TeaModel {
                        [NameInMap("extra_contents")]
                        [Validation(Required=false)]
                        public List<FlightSearchListResponseBodyModuleFlightListFlightRuleListChangeRuleItemExtraContents> ExtraContents { get; set; }
                        public class FlightSearchListResponseBodyModuleFlightListFlightRuleListChangeRuleItemExtraContents : TeaModel {
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
                        public List<FlightSearchListResponseBodyModuleFlightListFlightRuleListChangeRuleItemRefundSubItems> RefundSubItems { get; set; }
                        public class FlightSearchListResponseBodyModuleFlightListFlightRuleListChangeRuleItemRefundSubItems : TeaModel {
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
                            public List<FlightSearchListResponseBodyModuleFlightListFlightRuleListChangeRuleItemRefundSubItemsRefundSubContents> RefundSubContents { get; set; }
                            public class FlightSearchListResponseBodyModuleFlightListFlightRuleListChangeRuleItemRefundSubItemsRefundSubContents : TeaModel {
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
                    public FlightSearchListResponseBodyModuleFlightListFlightRuleListRefundRule RefundRule { get; set; }
                    public class FlightSearchListResponseBodyModuleFlightListFlightRuleListRefundRule : TeaModel {
                        [NameInMap("able")]
                        [Validation(Required=false)]
                        public bool? Able { get; set; }

                        [NameInMap("info")]
                        [Validation(Required=false)]
                        public List<FlightSearchListResponseBodyModuleFlightListFlightRuleListRefundRuleInfo> Info { get; set; }
                        public class FlightSearchListResponseBodyModuleFlightListFlightRuleListRefundRuleInfo : TeaModel {
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
                    public FlightSearchListResponseBodyModuleFlightListFlightRuleListRefundRuleItem RefundRuleItem { get; set; }
                    public class FlightSearchListResponseBodyModuleFlightListFlightRuleListRefundRuleItem : TeaModel {
                        [NameInMap("extra_contents")]
                        [Validation(Required=false)]
                        public List<FlightSearchListResponseBodyModuleFlightListFlightRuleListRefundRuleItemExtraContents> ExtraContents { get; set; }
                        public class FlightSearchListResponseBodyModuleFlightListFlightRuleListRefundRuleItemExtraContents : TeaModel {
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
                        public List<FlightSearchListResponseBodyModuleFlightListFlightRuleListRefundRuleItemRefundSubItems> RefundSubItems { get; set; }
                        public class FlightSearchListResponseBodyModuleFlightListFlightRuleListRefundRuleItemRefundSubItems : TeaModel {
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
                            public List<FlightSearchListResponseBodyModuleFlightListFlightRuleListRefundRuleItemRefundSubItemsRefundSubContents> RefundSubContents { get; set; }
                            public class FlightSearchListResponseBodyModuleFlightListFlightRuleListRefundRuleItemRefundSubItemsRefundSubContents : TeaModel {
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
                    public FlightSearchListResponseBodyModuleFlightListFlightRuleListSignRule SignRule { get; set; }
                    public class FlightSearchListResponseBodyModuleFlightListFlightRuleListSignRule : TeaModel {
                        [NameInMap("able")]
                        [Validation(Required=false)]
                        public bool? Able { get; set; }

                        [NameInMap("info")]
                        [Validation(Required=false)]
                        public List<FlightSearchListResponseBodyModuleFlightListFlightRuleListSignRuleInfo> Info { get; set; }
                        public class FlightSearchListResponseBodyModuleFlightListFlightRuleListSignRuleInfo : TeaModel {
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
                    public FlightSearchListResponseBodyModuleFlightListFlightRuleListUpgradeRule UpgradeRule { get; set; }
                    public class FlightSearchListResponseBodyModuleFlightListFlightRuleListUpgradeRule : TeaModel {
                        [NameInMap("able")]
                        [Validation(Required=false)]
                        public bool? Able { get; set; }

                        [NameInMap("info")]
                        [Validation(Required=false)]
                        public List<FlightSearchListResponseBodyModuleFlightListFlightRuleListUpgradeRuleInfo> Info { get; set; }
                        public class FlightSearchListResponseBodyModuleFlightListFlightRuleListUpgradeRuleInfo : TeaModel {
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

                [NameInMap("memo")]
                [Validation(Required=false)]
                public string Memo { get; set; }

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

                [NameInMap("transfer_info")]
                [Validation(Required=false)]
                public FlightSearchListResponseBodyModuleFlightListTransferInfo TransferInfo { get; set; }
                public class FlightSearchListResponseBodyModuleFlightListTransferInfo : TeaModel {
                    [NameInMap("flight_size")]
                    [Validation(Required=false)]
                    public string FlightSize { get; set; }

                    [NameInMap("flight_type")]
                    [Validation(Required=false)]
                    public string FlightType { get; set; }

                    [NameInMap("transfer_airline_info")]
                    [Validation(Required=false)]
                    public FlightSearchListResponseBodyModuleFlightListTransferInfoTransferAirlineInfo TransferAirlineInfo { get; set; }
                    public class FlightSearchListResponseBodyModuleFlightListTransferInfoTransferAirlineInfo : TeaModel {
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

                    [NameInMap("transfer_arr_airport_info")]
                    [Validation(Required=false)]
                    public FlightSearchListResponseBodyModuleFlightListTransferInfoTransferArrAirportInfo TransferArrAirportInfo { get; set; }
                    public class FlightSearchListResponseBodyModuleFlightListTransferInfoTransferArrAirportInfo : TeaModel {
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

                    [NameInMap("transfer_arr_date")]
                    [Validation(Required=false)]
                    public string TransferArrDate { get; set; }

                    [NameInMap("transfer_dep_airport_info")]
                    [Validation(Required=false)]
                    public FlightSearchListResponseBodyModuleFlightListTransferInfoTransferDepAirportInfo TransferDepAirportInfo { get; set; }
                    public class FlightSearchListResponseBodyModuleFlightListTransferInfoTransferDepAirportInfo : TeaModel {
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

                    [NameInMap("transfer_dep_date")]
                    [Validation(Required=false)]
                    public string TransferDepDate { get; set; }

                    [NameInMap("transfer_flight_no")]
                    [Validation(Required=false)]
                    public string TransferFlightNo { get; set; }

                    [NameInMap("transfer_flight_rule_list")]
                    [Validation(Required=false)]
                    public List<FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleList> TransferFlightRuleList { get; set; }
                    public class FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleList : TeaModel {
                        [NameInMap("baggage_info")]
                        [Validation(Required=false)]
                        public string BaggageInfo { get; set; }

                        [NameInMap("baggage_item")]
                        [Validation(Required=false)]
                        public FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListBaggageItem BaggageItem { get; set; }
                        public class FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListBaggageItem : TeaModel {
                            [NameInMap("baggage_sub_items")]
                            [Validation(Required=false)]
                            public List<FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListBaggageItemBaggageSubItems> BaggageSubItems { get; set; }
                            public class FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListBaggageItemBaggageSubItems : TeaModel {
                                [NameInMap("baggage_sub_content_visualizes")]
                                [Validation(Required=false)]
                                public List<FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizes> BaggageSubContentVisualizes { get; set; }
                                public class FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizes : TeaModel {
                                    [NameInMap("baggage_desc")]
                                    [Validation(Required=false)]
                                    public List<string> BaggageDesc { get; set; }

                                    [NameInMap("baggage_sub_content_type")]
                                    [Validation(Required=false)]
                                    public int? BaggageSubContentType { get; set; }

                                    [NameInMap("description")]
                                    [Validation(Required=false)]
                                    public FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizesDescription Description { get; set; }
                                    public class FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizesDescription : TeaModel {
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
                                    public FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizesImageDO ImageDO { get; set; }
                                    public class FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizesImageDO : TeaModel {
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
                            public FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListBaggageItemTips Tips { get; set; }
                            public class FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListBaggageItemTips : TeaModel {
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
                        public FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListChangeRule ChangeRule { get; set; }
                        public class FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListChangeRule : TeaModel {
                            [NameInMap("able")]
                            [Validation(Required=false)]
                            public bool? Able { get; set; }

                            [NameInMap("info")]
                            [Validation(Required=false)]
                            public List<FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListChangeRuleInfo> Info { get; set; }
                            public class FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListChangeRuleInfo : TeaModel {
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
                        public FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListChangeRuleItem ChangeRuleItem { get; set; }
                        public class FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListChangeRuleItem : TeaModel {
                            [NameInMap("extra_contents")]
                            [Validation(Required=false)]
                            public List<FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListChangeRuleItemExtraContents> ExtraContents { get; set; }
                            public class FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListChangeRuleItemExtraContents : TeaModel {
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
                            public List<FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListChangeRuleItemRefundSubItems> RefundSubItems { get; set; }
                            public class FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListChangeRuleItemRefundSubItems : TeaModel {
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
                                public List<FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListChangeRuleItemRefundSubItemsRefundSubContents> RefundSubContents { get; set; }
                                public class FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListChangeRuleItemRefundSubItemsRefundSubContents : TeaModel {
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
                        public FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListRefundRule RefundRule { get; set; }
                        public class FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListRefundRule : TeaModel {
                            [NameInMap("able")]
                            [Validation(Required=false)]
                            public bool? Able { get; set; }

                            [NameInMap("info")]
                            [Validation(Required=false)]
                            public List<FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListRefundRuleInfo> Info { get; set; }
                            public class FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListRefundRuleInfo : TeaModel {
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
                        public FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListRefundRuleItem RefundRuleItem { get; set; }
                        public class FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListRefundRuleItem : TeaModel {
                            [NameInMap("extra_contents")]
                            [Validation(Required=false)]
                            public List<FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListRefundRuleItemExtraContents> ExtraContents { get; set; }
                            public class FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListRefundRuleItemExtraContents : TeaModel {
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
                            public List<FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListRefundRuleItemRefundSubItems> RefundSubItems { get; set; }
                            public class FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListRefundRuleItemRefundSubItems : TeaModel {
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
                                public List<FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListRefundRuleItemRefundSubItemsRefundSubContents> RefundSubContents { get; set; }
                                public class FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListRefundRuleItemRefundSubItemsRefundSubContents : TeaModel {
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
                        public FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListSignRule SignRule { get; set; }
                        public class FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListSignRule : TeaModel {
                            [NameInMap("able")]
                            [Validation(Required=false)]
                            public bool? Able { get; set; }

                            [NameInMap("info")]
                            [Validation(Required=false)]
                            public List<FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListSignRuleInfo> Info { get; set; }
                            public class FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListSignRuleInfo : TeaModel {
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
                        public FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListUpgradeRule UpgradeRule { get; set; }
                        public class FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListUpgradeRule : TeaModel {
                            [NameInMap("able")]
                            [Validation(Required=false)]
                            public bool? Able { get; set; }

                            [NameInMap("info")]
                            [Validation(Required=false)]
                            public List<FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListUpgradeRuleInfo> Info { get; set; }
                            public class FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListUpgradeRuleInfo : TeaModel {
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

                }

                [NameInMap("trip_type")]
                [Validation(Required=false)]
                public int? TripType { get; set; }

            }

            [NameInMap("is_replace_pnr")]
            [Validation(Required=false)]
            public bool? IsReplacePnr { get; set; }

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
