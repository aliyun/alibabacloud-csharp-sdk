// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightSearchListResponseBody : TeaModel {
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
                public FlightSearchListResponseBodyModuleFlightListArrAirportInfo ArrAirportInfo { get; set; }
                public class FlightSearchListResponseBodyModuleFlightListArrAirportInfo : TeaModel {
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

                [NameInMap("cabin_info_list")]
                [Validation(Required=false)]
                public List<FlightSearchListResponseBodyModuleFlightListCabinInfoList> CabinInfoList { get; set; }
                public class FlightSearchListResponseBodyModuleFlightListCabinInfoList : TeaModel {
                    [NameInMap("agent_id")]
                    [Validation(Required=false)]
                    public long? AgentId { get; set; }

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

                    [NameInMap("cabin_class_name")]
                    [Validation(Required=false)]
                    public string CabinClassName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>G</para>
                    /// </summary>
                    [NameInMap("child_cabin")]
                    [Validation(Required=false)]
                    public string ChildCabin { get; set; }

                    [NameInMap("class_name")]
                    [Validation(Required=false)]
                    public string ClassName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>demo</para>
                    /// </summary>
                    [NameInMap("class_rule")]
                    [Validation(Required=false)]
                    public string ClassRule { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("discount")]
                    [Validation(Required=false)]
                    public string Discount { get; set; }

                    [NameInMap("flight_rule_list")]
                    [Validation(Required=false)]
                    public List<FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleList> FlightRuleList { get; set; }
                    public class FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleList : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>demo</para>
                        /// </summary>
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

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>0</para>
                                    /// </summary>
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
                                    public FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizesImageDO ImageDO { get; set; }
                                    public class FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizesImageDO : TeaModel {
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
                            public FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListBaggageItemTips Tips { get; set; }
                            public class FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListBaggageItemTips : TeaModel {
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
                        public FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListChangeRule ChangeRule { get; set; }
                        public class FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListChangeRule : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
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
                        public FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListChangeRuleItem ChangeRuleItem { get; set; }
                        public class FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListChangeRuleItem : TeaModel {
                            [NameInMap("extra_contents")]
                            [Validation(Required=false)]
                            public List<FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListChangeRuleItemExtraContents> ExtraContents { get; set; }
                            public class FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListChangeRuleItemExtraContents : TeaModel {
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
                            /// <para>0</para>
                            /// </summary>
                            [NameInMap("index")]
                            [Validation(Required=false)]
                            public int? Index { get; set; }

                            [NameInMap("refund_sub_items")]
                            [Validation(Required=false)]
                            public List<FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListChangeRuleItemRefundSubItems> RefundSubItems { get; set; }
                            public class FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListChangeRuleItemRefundSubItems : TeaModel {
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
                                public List<FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListChangeRuleItemRefundSubItemsRefundSubContents> RefundSubContents { get; set; }
                                public class FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListChangeRuleItemRefundSubItemsRefundSubContents : TeaModel {
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
                            /// <para>0</para>
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
                        public FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListRefundRule RefundRule { get; set; }
                        public class FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListRefundRule : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
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
                        public FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListRefundRuleItem RefundRuleItem { get; set; }
                        public class FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListRefundRuleItem : TeaModel {
                            [NameInMap("extra_contents")]
                            [Validation(Required=false)]
                            public List<FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListRefundRuleItemExtraContents> ExtraContents { get; set; }
                            public class FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListRefundRuleItemExtraContents : TeaModel {
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
                            public List<FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListRefundRuleItemRefundSubItems> RefundSubItems { get; set; }
                            public class FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListRefundRuleItemRefundSubItems : TeaModel {
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
                                public List<FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListRefundRuleItemRefundSubItemsRefundSubContents> RefundSubContents { get; set; }
                                public class FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListRefundRuleItemRefundSubItemsRefundSubContents : TeaModel {
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

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>demo</para>
                            /// </summary>
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
                        public FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListSignRule SignRule { get; set; }
                        public class FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListSignRule : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
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
                        public FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListUpgradeRule UpgradeRule { get; set; }
                        public class FlightSearchListResponseBodyModuleFlightListCabinInfoListFlightRuleListUpgradeRule : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
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
                    /// <para>{&quot;key&quot;:&quot;value&quot;}</para>
                    /// </summary>
                    [NameInMap("memo")]
                    [Validation(Required=false)]
                    public string Memo { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("oil_price")]
                    [Validation(Required=false)]
                    public int? OilPrice { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1000_1_0</para>
                    /// </summary>
                    [NameInMap("order_params")]
                    [Validation(Required=false)]
                    public string OrderParams { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>wisdiii2ii22ii2</para>
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

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>demo</para>
                    /// </summary>
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
                    public int? TotalPrice { get; set; }

                }

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

                [NameInMap("class_rule")]
                [Validation(Required=false)]
                public string ClassRule { get; set; }

                [NameInMap("dep_airport_info")]
                [Validation(Required=false)]
                public FlightSearchListResponseBodyModuleFlightListDepAirportInfo DepAirportInfo { get; set; }
                public class FlightSearchListResponseBodyModuleFlightListDepAirportInfo : TeaModel {
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
                public List<FlightSearchListResponseBodyModuleFlightListFlightRuleList> FlightRuleList { get; set; }
                public class FlightSearchListResponseBodyModuleFlightListFlightRuleList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>demo</para>
                    /// </summary>
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

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>1</para>
                                /// </summary>
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
                                public FlightSearchListResponseBodyModuleFlightListFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizesImageDO ImageDO { get; set; }
                                public class FlightSearchListResponseBodyModuleFlightListFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizesImageDO : TeaModel {
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
                        public FlightSearchListResponseBodyModuleFlightListFlightRuleListBaggageItemTips Tips { get; set; }
                        public class FlightSearchListResponseBodyModuleFlightListFlightRuleListBaggageItemTips : TeaModel {
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
                    public FlightSearchListResponseBodyModuleFlightListFlightRuleListChangeRule ChangeRule { get; set; }
                    public class FlightSearchListResponseBodyModuleFlightListFlightRuleListChangeRule : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
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

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("index")]
                        [Validation(Required=false)]
                        public int? Index { get; set; }

                        [NameInMap("refund_sub_items")]
                        [Validation(Required=false)]
                        public List<FlightSearchListResponseBodyModuleFlightListFlightRuleListChangeRuleItemRefundSubItems> RefundSubItems { get; set; }
                        public class FlightSearchListResponseBodyModuleFlightListFlightRuleListChangeRuleItemRefundSubItems : TeaModel {
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
                            public List<FlightSearchListResponseBodyModuleFlightListFlightRuleListChangeRuleItemRefundSubItemsRefundSubContents> RefundSubContents { get; set; }
                            public class FlightSearchListResponseBodyModuleFlightListFlightRuleListChangeRuleItemRefundSubItemsRefundSubContents : TeaModel {
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
                    public FlightSearchListResponseBodyModuleFlightListFlightRuleListRefundRule RefundRule { get; set; }
                    public class FlightSearchListResponseBodyModuleFlightListFlightRuleListRefundRule : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
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
                    public FlightSearchListResponseBodyModuleFlightListFlightRuleListRefundRuleItem RefundRuleItem { get; set; }
                    public class FlightSearchListResponseBodyModuleFlightListFlightRuleListRefundRuleItem : TeaModel {
                        [NameInMap("extra_contents")]
                        [Validation(Required=false)]
                        public List<FlightSearchListResponseBodyModuleFlightListFlightRuleListRefundRuleItemExtraContents> ExtraContents { get; set; }
                        public class FlightSearchListResponseBodyModuleFlightListFlightRuleListRefundRuleItemExtraContents : TeaModel {
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
                        public List<FlightSearchListResponseBodyModuleFlightListFlightRuleListRefundRuleItemRefundSubItems> RefundSubItems { get; set; }
                        public class FlightSearchListResponseBodyModuleFlightListFlightRuleListRefundRuleItemRefundSubItems : TeaModel {
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
                            public List<FlightSearchListResponseBodyModuleFlightListFlightRuleListRefundRuleItemRefundSubItemsRefundSubContents> RefundSubContents { get; set; }
                            public class FlightSearchListResponseBodyModuleFlightListFlightRuleListRefundRuleItemRefundSubItemsRefundSubContents : TeaModel {
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
                    public FlightSearchListResponseBodyModuleFlightListFlightRuleListSignRule SignRule { get; set; }
                    public class FlightSearchListResponseBodyModuleFlightListFlightRuleListSignRule : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
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
                    public FlightSearchListResponseBodyModuleFlightListFlightRuleListUpgradeRule UpgradeRule { get; set; }
                    public class FlightSearchListResponseBodyModuleFlightListFlightRuleListUpgradeRule : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
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
                /// <para>{&quot;key&quot;:&quot;value&quot;}</para>
                /// </summary>
                [NameInMap("memo")]
                [Validation(Required=false)]
                public string Memo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("oil_price")]
                [Validation(Required=false)]
                public int? OilPrice { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>wisdiii2ii22ii2</para>
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

                [NameInMap("transfer_info")]
                [Validation(Required=false)]
                public FlightSearchListResponseBodyModuleFlightListTransferInfo TransferInfo { get; set; }
                public class FlightSearchListResponseBodyModuleFlightListTransferInfo : TeaModel {
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

                    [NameInMap("transfer_airline_info")]
                    [Validation(Required=false)]
                    public FlightSearchListResponseBodyModuleFlightListTransferInfoTransferAirlineInfo TransferAirlineInfo { get; set; }
                    public class FlightSearchListResponseBodyModuleFlightListTransferInfoTransferAirlineInfo : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>ZH</para>
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

                    [NameInMap("transfer_arr_airport_info")]
                    [Validation(Required=false)]
                    public FlightSearchListResponseBodyModuleFlightListTransferInfoTransferArrAirportInfo TransferArrAirportInfo { get; set; }
                    public class FlightSearchListResponseBodyModuleFlightListTransferInfoTransferArrAirportInfo : TeaModel {
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
                        /// <para>T4</para>
                        /// </summary>
                        [NameInMap("terminal")]
                        [Validation(Required=false)]
                        public string Terminal { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>yyyy-MM-dd HH:mm:ss</para>
                    /// </summary>
                    [NameInMap("transfer_arr_date")]
                    [Validation(Required=false)]
                    public string TransferArrDate { get; set; }

                    [NameInMap("transfer_dep_airport_info")]
                    [Validation(Required=false)]
                    public FlightSearchListResponseBodyModuleFlightListTransferInfoTransferDepAirportInfo TransferDepAirportInfo { get; set; }
                    public class FlightSearchListResponseBodyModuleFlightListTransferInfoTransferDepAirportInfo : TeaModel {
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
                    /// <para>yyyy-MM-dd HH:mm:ss</para>
                    /// </summary>
                    [NameInMap("transfer_dep_date")]
                    [Validation(Required=false)]
                    public string TransferDepDate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>CA1234</para>
                    /// </summary>
                    [NameInMap("transfer_flight_no")]
                    [Validation(Required=false)]
                    public string TransferFlightNo { get; set; }

                    [NameInMap("transfer_flight_rule_list")]
                    [Validation(Required=false)]
                    public List<FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleList> TransferFlightRuleList { get; set; }
                    public class FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleList : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>demo</para>
                        /// </summary>
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

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>1</para>
                                    /// </summary>
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
                                    public FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizesImageDO ImageDO { get; set; }
                                    public class FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizesImageDO : TeaModel {
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

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>1</para>
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

                            [NameInMap("table_head")]
                            [Validation(Required=false)]
                            public string TableHead { get; set; }

                            [NameInMap("tips")]
                            [Validation(Required=false)]
                            public FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListBaggageItemTips Tips { get; set; }
                            public class FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListBaggageItemTips : TeaModel {
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
                        public FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListChangeRule ChangeRule { get; set; }
                        public class FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListChangeRule : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
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

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>100</para>
                                /// </summary>
                                [NameInMap("cost")]
                                [Validation(Required=false)]
                                public int? Cost { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>100</para>
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
                        public FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListChangeRuleItem ChangeRuleItem { get; set; }
                        public class FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListChangeRuleItem : TeaModel {
                            [NameInMap("extra_contents")]
                            [Validation(Required=false)]
                            public List<FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListChangeRuleItemExtraContents> ExtraContents { get; set; }
                            public class FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListChangeRuleItemExtraContents : TeaModel {
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
                            /// <para>0</para>
                            /// </summary>
                            [NameInMap("index")]
                            [Validation(Required=false)]
                            public int? Index { get; set; }

                            [NameInMap("refund_sub_items")]
                            [Validation(Required=false)]
                            public List<FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListChangeRuleItemRefundSubItems> RefundSubItems { get; set; }
                            public class FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListChangeRuleItemRefundSubItems : TeaModel {
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
                                public List<FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListChangeRuleItemRefundSubItemsRefundSubContents> RefundSubContents { get; set; }
                                public class FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListChangeRuleItemRefundSubItemsRefundSubContents : TeaModel {
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
                            /// <para>0</para>
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
                        public FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListRefundRule RefundRule { get; set; }
                        public class FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListRefundRule : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
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

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>100</para>
                                /// </summary>
                                [NameInMap("cost")]
                                [Validation(Required=false)]
                                public int? Cost { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>100</para>
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
                        public FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListRefundRuleItem RefundRuleItem { get; set; }
                        public class FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListRefundRuleItem : TeaModel {
                            [NameInMap("extra_contents")]
                            [Validation(Required=false)]
                            public List<FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListRefundRuleItemExtraContents> ExtraContents { get; set; }
                            public class FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListRefundRuleItemExtraContents : TeaModel {
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
                            public List<FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListRefundRuleItemRefundSubItems> RefundSubItems { get; set; }
                            public class FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListRefundRuleItemRefundSubItems : TeaModel {
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
                                public List<FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListRefundRuleItemRefundSubItemsRefundSubContents> RefundSubContents { get; set; }
                                public class FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListRefundRuleItemRefundSubItemsRefundSubContents : TeaModel {
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

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>demo</para>
                            /// </summary>
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
                        public FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListSignRule SignRule { get; set; }
                        public class FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListSignRule : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
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

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>demo</para>
                        /// </summary>
                        [NameInMap("tuigaiqian_info")]
                        [Validation(Required=false)]
                        public string TuigaiqianInfo { get; set; }

                        [NameInMap("upgrade_rule")]
                        [Validation(Required=false)]
                        public FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListUpgradeRule UpgradeRule { get; set; }
                        public class FlightSearchListResponseBodyModuleFlightListTransferInfoTransferFlightRuleListUpgradeRule : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
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

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("trip_type")]
                [Validation(Required=false)]
                public int? TripType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("is_replace_pnr")]
            [Validation(Required=false)]
            public bool? IsReplacePnr { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A5009956-1077-52FB-B520-EA8C7E91D722</para>
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
