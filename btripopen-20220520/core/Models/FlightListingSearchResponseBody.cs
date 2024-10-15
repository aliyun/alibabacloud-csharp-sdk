// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightListingSearchResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>module</para>
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

                    [NameInMap("airline_simple_name")]
                    [Validation(Required=false)]
                    public string AirlineSimpleName { get; set; }

                }

                [NameInMap("arr_airport_info")]
                [Validation(Required=false)]
                public FlightListingSearchResponseBodyModuleFlightListArrAirportInfo ArrAirportInfo { get; set; }
                public class FlightListingSearchResponseBodyModuleFlightListArrAirportInfo : TeaModel {
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

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>HGH</para>
                    /// </summary>
                    [NameInMap("city_code")]
                    [Validation(Required=false)]
                    public string CityCode { get; set; }

                    [NameInMap("city_name")]
                    [Validation(Required=false)]
                    public string CityName { get; set; }

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
                /// <para>yyyy-MM-dd HH:mm:ss</para>
                /// </summary>
                [NameInMap("arr_date")]
                [Validation(Required=false)]
                public string ArrDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12456</para>
                /// </summary>
                [NameInMap("basic_cabin_price")]
                [Validation(Required=false)]
                public int? BasicCabinPrice { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("build_price")]
                [Validation(Required=false)]
                public int? BuildPrice { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Y</para>
                /// </summary>
                [NameInMap("cabin")]
                [Validation(Required=false)]
                public string Cabin { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("cabin_class")]
                [Validation(Required=false)]
                public string CabinClass { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>FM</para>
                /// </summary>
                [NameInMap("carrier_airline")]
                [Validation(Required=false)]
                public string CarrierAirline { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>FM9152</para>
                /// </summary>
                [NameInMap("carrier_no")]
                [Validation(Required=false)]
                public string CarrierNo { get; set; }

                [NameInMap("dep_airport_info")]
                [Validation(Required=false)]
                public FlightListingSearchResponseBodyModuleFlightListDepAirportInfo DepAirportInfo { get; set; }
                public class FlightListingSearchResponseBodyModuleFlightListDepAirportInfo : TeaModel {
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

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>BJS</para>
                    /// </summary>
                    [NameInMap("city_code")]
                    [Validation(Required=false)]
                    public string CityCode { get; set; }

                    [NameInMap("city_name")]
                    [Validation(Required=false)]
                    public string CityName { get; set; }

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
                /// <para>BJS</para>
                /// </summary>
                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>yyyy-MM-dd HH:mm:ss</para>
                /// </summary>
                [NameInMap("dep_date")]
                [Validation(Required=false)]
                public string DepDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("discount")]
                [Validation(Required=false)]
                public int? Discount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CA1234</para>
                /// </summary>
                [NameInMap("flight_no")]
                [Validation(Required=false)]
                public string FlightNo { get; set; }

                [NameInMap("flight_rule_list")]
                [Validation(Required=false)]
                public List<FlightListingSearchResponseBodyModuleFlightListFlightRuleList> FlightRuleList { get; set; }
                public class FlightListingSearchResponseBodyModuleFlightListFlightRuleList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>demo</para>
                    /// </summary>
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

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>1</para>
                                /// </summary>
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

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para><a href="https://gw.alicdn.com/imgextra/i4/O1CN01UynXG31pjsEtA3tMF_!!6000000005397-2-tps-36-36.png">https://gw.alicdn.com/imgextra/i4/O1CN01UynXG31pjsEtA3tMF_!!6000000005397-2-tps-36-36.png</a></para>
                                    /// </summary>
                                    [NameInMap("icon")]
                                    [Validation(Required=false)]
                                    public string Icon { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para><a href="https://gw.alicdn.com/imgextra/i1/O1CN01qe7wL21gJ0SmEXXL7_!!6000000004120-2-tps-1206-768.png">https://gw.alicdn.com/imgextra/i1/O1CN01qe7wL21gJ0SmEXXL7_!!6000000004120-2-tps-1206-768.png</a></para>
                                    /// </summary>
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
                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>demo</para>
                                    /// </summary>
                                    [NameInMap("image")]
                                    [Validation(Required=false)]
                                    public string Image { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>50</para>
                                    /// </summary>
                                    [NameInMap("largest")]
                                    [Validation(Required=false)]
                                    public string Largest { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>40</para>
                                    /// </summary>
                                    [NameInMap("middle")]
                                    [Validation(Required=false)]
                                    public string Middle { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>20</para>
                                    /// </summary>
                                    [NameInMap("smallest")]
                                    [Validation(Required=false)]
                                    public string Smallest { get; set; }

                                }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>true</para>
                                /// </summary>
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

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
                            [NameInMap("is_struct")]
                            [Validation(Required=false)]
                            public bool? IsStruct { get; set; }

                            /// <summary>
                            /// <para>PTC</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>ADT</para>
                            /// </summary>
                            [NameInMap("ptc")]
                            [Validation(Required=false)]
                            public string Ptc { get; set; }

                            [NameInMap("title")]
                            [Validation(Required=false)]
                            public string Title { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
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
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para><a href="https://gw.alicdn.com/imgextra/i1/O1CN019zl3WZ22fNLxzx2cR_!!6000000007147-2-tps-125-45.png">https://gw.alicdn.com/imgextra/i1/O1CN019zl3WZ22fNLxzx2cR_!!6000000007147-2-tps-125-45.png</a></para>
                            /// </summary>
                            [NameInMap("logo")]
                            [Validation(Required=false)]
                            public string Logo { get; set; }

                            [NameInMap("tips_desc")]
                            [Validation(Required=false)]
                            public string TipsDesc { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para><a href="https://gw.alicdn.com/imgextra/i3/O1CN01rJxjw61f3bXNHAmlk_!!6000000003951-2-tps-1050-675.png">https://gw.alicdn.com/imgextra/i3/O1CN01rJxjw61f3bXNHAmlk_!!6000000003951-2-tps-1050-675.png</a></para>
                            /// </summary>
                            [NameInMap("tips_image")]
                            [Validation(Required=false)]
                            public string TipsImage { get; set; }

                        }

                        [NameInMap("title")]
                        [Validation(Required=false)]
                        public string Title { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("type")]
                        [Validation(Required=false)]
                        public int? Type { get; set; }

                    }

                    [NameInMap("change_rule")]
                    [Validation(Required=false)]
                    public FlightListingSearchResponseBodyModuleFlightListFlightRuleListChangeRule ChangeRule { get; set; }
                    public class FlightListingSearchResponseBodyModuleFlightListFlightRuleListChangeRule : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
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

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>100</para>
                            /// </summary>
                            [NameInMap("cost")]
                            [Validation(Required=false)]
                            public int? Cost { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>10</para>
                            /// </summary>
                            [NameInMap("cost_percent")]
                            [Validation(Required=false)]
                            public int? CostPercent { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>1675036500000</para>
                            /// </summary>
                            [NameInMap("time_stamp")]
                            [Validation(Required=false)]
                            public int? TimeStamp { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>demo</para>
                            /// </summary>
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

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("index")]
                        [Validation(Required=false)]
                        public int? Index { get; set; }

                        [NameInMap("refund_sub_items")]
                        [Validation(Required=false)]
                        public List<FlightListingSearchResponseBodyModuleFlightListFlightRuleListChangeRuleItemRefundSubItems> RefundSubItems { get; set; }
                        public class FlightListingSearchResponseBodyModuleFlightListFlightRuleListChangeRuleItemRefundSubItems : TeaModel {
                            /// <summary>
                            /// <para>isStruct : true</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
                            [NameInMap("is_struct")]
                            [Validation(Required=false)]
                            public bool? IsStruct { get; set; }

                            /// <summary>
                            /// <para>PTC</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>ADT</para>
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

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>1</para>
                                /// </summary>
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

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("type")]
                        [Validation(Required=false)]
                        public int? Type { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>{}</para>
                    /// </summary>
                    [NameInMap("extra")]
                    [Validation(Required=false)]
                    public string Extra { get; set; }

                    [NameInMap("refund_rule")]
                    [Validation(Required=false)]
                    public FlightListingSearchResponseBodyModuleFlightListFlightRuleListRefundRule RefundRule { get; set; }
                    public class FlightListingSearchResponseBodyModuleFlightListFlightRuleListRefundRule : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
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

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>100</para>
                            /// </summary>
                            [NameInMap("cost")]
                            [Validation(Required=false)]
                            public int? Cost { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>10</para>
                            /// </summary>
                            [NameInMap("cost_percent")]
                            [Validation(Required=false)]
                            public int? CostPercent { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>1675036500000</para>
                            /// </summary>
                            [NameInMap("time_stamp")]
                            [Validation(Required=false)]
                            public int? TimeStamp { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>demo</para>
                            /// </summary>
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
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>demo</para>
                            /// </summary>
                            [NameInMap("content")]
                            [Validation(Required=false)]
                            public string Content { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>demo</para>
                            /// </summary>
                            [NameInMap("title")]
                            [Validation(Required=false)]
                            public string Title { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("index")]
                        [Validation(Required=false)]
                        public int? Index { get; set; }

                        [NameInMap("refund_sub_items")]
                        [Validation(Required=false)]
                        public List<FlightListingSearchResponseBodyModuleFlightListFlightRuleListRefundRuleItemRefundSubItems> RefundSubItems { get; set; }
                        public class FlightListingSearchResponseBodyModuleFlightListFlightRuleListRefundRuleItemRefundSubItems : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
                            [NameInMap("is_struct")]
                            [Validation(Required=false)]
                            public bool? IsStruct { get; set; }

                            /// <summary>
                            /// <para>PTC</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>ADT</para>
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

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>1</para>
                                /// </summary>
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

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("type")]
                        [Validation(Required=false)]
                        public int? Type { get; set; }

                    }

                    [NameInMap("sign_rule")]
                    [Validation(Required=false)]
                    public FlightListingSearchResponseBodyModuleFlightListFlightRuleListSignRule SignRule { get; set; }
                    public class FlightListingSearchResponseBodyModuleFlightListFlightRuleListSignRule : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
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

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>100</para>
                            /// </summary>
                            [NameInMap("cost")]
                            [Validation(Required=false)]
                            public int? Cost { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>10</para>
                            /// </summary>
                            [NameInMap("cost_percent")]
                            [Validation(Required=false)]
                            public int? CostPercent { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>1675036500000</para>
                            /// </summary>
                            [NameInMap("time_stamp")]
                            [Validation(Required=false)]
                            public int? TimeStamp { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>demo</para>
                            /// </summary>
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
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
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

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>100</para>
                            /// </summary>
                            [NameInMap("cost")]
                            [Validation(Required=false)]
                            public int? Cost { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>10</para>
                            /// </summary>
                            [NameInMap("cost_percent")]
                            [Validation(Required=false)]
                            public int? CostPercent { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>1675036500000</para>
                            /// </summary>
                            [NameInMap("time_stamp")]
                            [Validation(Required=false)]
                            public int? TimeStamp { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>demo</para>
                            /// </summary>
                            [NameInMap("time_type")]
                            [Validation(Required=false)]
                            public string TimeType { get; set; }

                            [NameInMap("title")]
                            [Validation(Required=false)]
                            public string Title { get; set; }

                        }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>demo</para>
                /// </summary>
                [NameInMap("flight_rule_list_str")]
                [Validation(Required=false)]
                public string FlightRuleListStr { get; set; }

                [NameInMap("flight_size")]
                [Validation(Required=false)]
                public string FlightSize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>demo</para>
                /// </summary>
                [NameInMap("flight_type")]
                [Validation(Required=false)]
                public string FlightType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("invoice_type")]
                [Validation(Required=false)]
                public int? InvoiceType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("is_protocol")]
                [Validation(Required=false)]
                public bool? IsProtocol { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("is_share")]
                [Validation(Required=false)]
                public bool? IsShare { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("is_stop")]
                [Validation(Required=false)]
                public bool? IsStop { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("is_transfer")]
                [Validation(Required=false)]
                public bool? IsTransfer { get; set; }

                [NameInMap("meal_desc")]
                [Validation(Required=false)]
                public string MealDesc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("oil_price")]
                [Validation(Required=false)]
                public int? OilPrice { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4ec61b13fc9746f99c072a16bfc265af_0</para>
                /// </summary>
                [NameInMap("ota_item_id")]
                [Validation(Required=false)]
                public string OtaItemId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("price")]
                [Validation(Required=false)]
                public int? Price { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("product_type")]
                [Validation(Required=false)]
                public long? ProductType { get; set; }

                [NameInMap("product_type_desc")]
                [Validation(Required=false)]
                public string ProductTypeDesc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("promotion_price")]
                [Validation(Required=false)]
                public string PromotionPrice { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("remained_seat_count")]
                [Validation(Required=false)]
                public string RemainedSeatCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1000_1_0</para>
                /// </summary>
                [NameInMap("secret_params")]
                [Validation(Required=false)]
                public string SecretParams { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("segment_number")]
                [Validation(Required=false)]
                public string SegmentNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>yyyy-MM-dd HH:mm:ss</para>
                /// </summary>
                [NameInMap("stop_arr_time")]
                [Validation(Required=false)]
                public string StopArrTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>HGH</para>
                /// </summary>
                [NameInMap("stop_city")]
                [Validation(Required=false)]
                public string StopCity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>yyyy-MM-dd HH:mm:ss</para>
                /// </summary>
                [NameInMap("stop_dep_time")]
                [Validation(Required=false)]
                public string StopDepTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("ticket_price")]
                [Validation(Required=false)]
                public int? TicketPrice { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("total_price")]
                [Validation(Required=false)]
                public string TotalPrice { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("trip_type")]
                [Validation(Required=false)]
                public int? TripType { get; set; }

            }

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
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
