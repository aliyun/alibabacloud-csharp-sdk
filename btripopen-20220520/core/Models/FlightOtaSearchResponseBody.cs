// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightOtaSearchResponseBody : TeaModel {
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

        [NameInMap("module")]
        [Validation(Required=false)]
        public FlightOtaSearchResponseBodyModule Module { get; set; }
        public class FlightOtaSearchResponseBodyModule : TeaModel {
            [NameInMap("flight_list")]
            [Validation(Required=false)]
            public List<FlightOtaSearchResponseBodyModuleFlightList> FlightList { get; set; }
            public class FlightOtaSearchResponseBodyModuleFlightList : TeaModel {
                [NameInMap("airline_info")]
                [Validation(Required=false)]
                public FlightOtaSearchResponseBodyModuleFlightListAirlineInfo AirlineInfo { get; set; }
                public class FlightOtaSearchResponseBodyModuleFlightListAirlineInfo : TeaModel {
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
                public FlightOtaSearchResponseBodyModuleFlightListArrAirportInfo ArrAirportInfo { get; set; }
                public class FlightOtaSearchResponseBodyModuleFlightListArrAirportInfo : TeaModel {
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
                public List<FlightOtaSearchResponseBodyModuleFlightListCabinInfoList> CabinInfoList { get; set; }
                public class FlightOtaSearchResponseBodyModuleFlightListCabinInfoList : TeaModel {
                    [NameInMap("agent_id")]
                    [Validation(Required=false)]
                    public long? AgentId { get; set; }

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
                    public List<FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleList> FlightRuleList { get; set; }
                    public class FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleList : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>demo</para>
                        /// </summary>
                        [NameInMap("baggage_info")]
                        [Validation(Required=false)]
                        public string BaggageInfo { get; set; }

                        [NameInMap("baggage_item")]
                        [Validation(Required=false)]
                        public FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListBaggageItem BaggageItem { get; set; }
                        public class FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListBaggageItem : TeaModel {
                            [NameInMap("baggage_sub_items")]
                            [Validation(Required=false)]
                            public List<FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListBaggageItemBaggageSubItems> BaggageSubItems { get; set; }
                            public class FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListBaggageItemBaggageSubItems : TeaModel {
                                [NameInMap("baggage_sub_content_visualizes")]
                                [Validation(Required=false)]
                                public List<FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizes> BaggageSubContentVisualizes { get; set; }
                                public class FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizes : TeaModel {
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
                                    public FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizesDescription Description { get; set; }
                                    public class FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizesDescription : TeaModel {
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
                                    public FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizesImageDO ImageDO { get; set; }
                                    public class FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizesImageDO : TeaModel {
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
                            public FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListBaggageItemTips Tips { get; set; }
                            public class FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListBaggageItemTips : TeaModel {
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
                        public FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListChangeRule ChangeRule { get; set; }
                        public class FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListChangeRule : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
                            [NameInMap("able")]
                            [Validation(Required=false)]
                            public bool? Able { get; set; }

                            [NameInMap("info")]
                            [Validation(Required=false)]
                            public List<FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListChangeRuleInfo> Info { get; set; }
                            public class FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListChangeRuleInfo : TeaModel {
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
                        public FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListChangeRuleItem ChangeRuleItem { get; set; }
                        public class FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListChangeRuleItem : TeaModel {
                            [NameInMap("extra_contents")]
                            [Validation(Required=false)]
                            public List<FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListChangeRuleItemExtraContents> ExtraContents { get; set; }
                            public class FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListChangeRuleItemExtraContents : TeaModel {
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
                            public List<FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListChangeRuleItemRefundSubItems> RefundSubItems { get; set; }
                            public class FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListChangeRuleItemRefundSubItems : TeaModel {
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
                                public List<FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListChangeRuleItemRefundSubItemsRefundSubContents> RefundSubContents { get; set; }
                                public class FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListChangeRuleItemRefundSubItemsRefundSubContents : TeaModel {
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
                        public FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListRefundRule RefundRule { get; set; }
                        public class FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListRefundRule : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
                            [NameInMap("able")]
                            [Validation(Required=false)]
                            public bool? Able { get; set; }

                            [NameInMap("info")]
                            [Validation(Required=false)]
                            public List<FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListRefundRuleInfo> Info { get; set; }
                            public class FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListRefundRuleInfo : TeaModel {
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
                        public FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListRefundRuleItem RefundRuleItem { get; set; }
                        public class FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListRefundRuleItem : TeaModel {
                            [NameInMap("extra_contents")]
                            [Validation(Required=false)]
                            public List<FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListRefundRuleItemExtraContents> ExtraContents { get; set; }
                            public class FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListRefundRuleItemExtraContents : TeaModel {
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
                            public List<FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListRefundRuleItemRefundSubItems> RefundSubItems { get; set; }
                            public class FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListRefundRuleItemRefundSubItems : TeaModel {
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
                                public List<FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListRefundRuleItemRefundSubItemsRefundSubContents> RefundSubContents { get; set; }
                                public class FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListRefundRuleItemRefundSubItemsRefundSubContents : TeaModel {
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
                        public FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListSignRule SignRule { get; set; }
                        public class FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListSignRule : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
                            [NameInMap("able")]
                            [Validation(Required=false)]
                            public bool? Able { get; set; }

                            [NameInMap("info")]
                            [Validation(Required=false)]
                            public List<FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListSignRuleInfo> Info { get; set; }
                            public class FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListSignRuleInfo : TeaModel {
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
                        public FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListUpgradeRule UpgradeRule { get; set; }
                        public class FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListUpgradeRule : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
                            [NameInMap("able")]
                            [Validation(Required=false)]
                            public bool? Able { get; set; }

                            [NameInMap("info")]
                            [Validation(Required=false)]
                            public List<FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListUpgradeRuleInfo> Info { get; set; }
                            public class FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListUpgradeRuleInfo : TeaModel {
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
                    /// <para>97f64e2d6f61408a827dd523817fefd6_0</para>
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

                [NameInMap("dep_airport_info")]
                [Validation(Required=false)]
                public FlightOtaSearchResponseBodyModuleFlightListDepAirportInfo DepAirportInfo { get; set; }
                public class FlightOtaSearchResponseBodyModuleFlightListDepAirportInfo : TeaModel {
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
                public List<FlightOtaSearchResponseBodyModuleFlightListFlightRuleList> FlightRuleList { get; set; }
                public class FlightOtaSearchResponseBodyModuleFlightListFlightRuleList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>demo</para>
                    /// </summary>
                    [NameInMap("baggage_info")]
                    [Validation(Required=false)]
                    public string BaggageInfo { get; set; }

                    [NameInMap("baggage_item")]
                    [Validation(Required=false)]
                    public FlightOtaSearchResponseBodyModuleFlightListFlightRuleListBaggageItem BaggageItem { get; set; }
                    public class FlightOtaSearchResponseBodyModuleFlightListFlightRuleListBaggageItem : TeaModel {
                        [NameInMap("baggage_sub_items")]
                        [Validation(Required=false)]
                        public List<FlightOtaSearchResponseBodyModuleFlightListFlightRuleListBaggageItemBaggageSubItems> BaggageSubItems { get; set; }
                        public class FlightOtaSearchResponseBodyModuleFlightListFlightRuleListBaggageItemBaggageSubItems : TeaModel {
                            [NameInMap("baggage_sub_content_visualizes")]
                            [Validation(Required=false)]
                            public List<FlightOtaSearchResponseBodyModuleFlightListFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizes> BaggageSubContentVisualizes { get; set; }
                            public class FlightOtaSearchResponseBodyModuleFlightListFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizes : TeaModel {
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
                                public FlightOtaSearchResponseBodyModuleFlightListFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizesDescription Description { get; set; }
                                public class FlightOtaSearchResponseBodyModuleFlightListFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizesDescription : TeaModel {
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
                                public FlightOtaSearchResponseBodyModuleFlightListFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizesImageDO ImageDO { get; set; }
                                public class FlightOtaSearchResponseBodyModuleFlightListFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizesImageDO : TeaModel {
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
                        public FlightOtaSearchResponseBodyModuleFlightListFlightRuleListBaggageItemTips Tips { get; set; }
                        public class FlightOtaSearchResponseBodyModuleFlightListFlightRuleListBaggageItemTips : TeaModel {
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
                    public FlightOtaSearchResponseBodyModuleFlightListFlightRuleListChangeRule ChangeRule { get; set; }
                    public class FlightOtaSearchResponseBodyModuleFlightListFlightRuleListChangeRule : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("able")]
                        [Validation(Required=false)]
                        public bool? Able { get; set; }

                        [NameInMap("info")]
                        [Validation(Required=false)]
                        public List<FlightOtaSearchResponseBodyModuleFlightListFlightRuleListChangeRuleInfo> Info { get; set; }
                        public class FlightOtaSearchResponseBodyModuleFlightListFlightRuleListChangeRuleInfo : TeaModel {
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
                    public FlightOtaSearchResponseBodyModuleFlightListFlightRuleListChangeRuleItem ChangeRuleItem { get; set; }
                    public class FlightOtaSearchResponseBodyModuleFlightListFlightRuleListChangeRuleItem : TeaModel {
                        [NameInMap("extra_contents")]
                        [Validation(Required=false)]
                        public List<FlightOtaSearchResponseBodyModuleFlightListFlightRuleListChangeRuleItemExtraContents> ExtraContents { get; set; }
                        public class FlightOtaSearchResponseBodyModuleFlightListFlightRuleListChangeRuleItemExtraContents : TeaModel {
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
                        public List<FlightOtaSearchResponseBodyModuleFlightListFlightRuleListChangeRuleItemRefundSubItems> RefundSubItems { get; set; }
                        public class FlightOtaSearchResponseBodyModuleFlightListFlightRuleListChangeRuleItemRefundSubItems : TeaModel {
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
                            public List<FlightOtaSearchResponseBodyModuleFlightListFlightRuleListChangeRuleItemRefundSubItemsRefundSubContents> RefundSubContents { get; set; }
                            public class FlightOtaSearchResponseBodyModuleFlightListFlightRuleListChangeRuleItemRefundSubItemsRefundSubContents : TeaModel {
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
                    public FlightOtaSearchResponseBodyModuleFlightListFlightRuleListRefundRule RefundRule { get; set; }
                    public class FlightOtaSearchResponseBodyModuleFlightListFlightRuleListRefundRule : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("able")]
                        [Validation(Required=false)]
                        public bool? Able { get; set; }

                        [NameInMap("info")]
                        [Validation(Required=false)]
                        public List<FlightOtaSearchResponseBodyModuleFlightListFlightRuleListRefundRuleInfo> Info { get; set; }
                        public class FlightOtaSearchResponseBodyModuleFlightListFlightRuleListRefundRuleInfo : TeaModel {
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
                    public FlightOtaSearchResponseBodyModuleFlightListFlightRuleListRefundRuleItem RefundRuleItem { get; set; }
                    public class FlightOtaSearchResponseBodyModuleFlightListFlightRuleListRefundRuleItem : TeaModel {
                        [NameInMap("extra_contents")]
                        [Validation(Required=false)]
                        public List<FlightOtaSearchResponseBodyModuleFlightListFlightRuleListRefundRuleItemExtraContents> ExtraContents { get; set; }
                        public class FlightOtaSearchResponseBodyModuleFlightListFlightRuleListRefundRuleItemExtraContents : TeaModel {
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
                        public List<FlightOtaSearchResponseBodyModuleFlightListFlightRuleListRefundRuleItemRefundSubItems> RefundSubItems { get; set; }
                        public class FlightOtaSearchResponseBodyModuleFlightListFlightRuleListRefundRuleItemRefundSubItems : TeaModel {
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
                            public List<FlightOtaSearchResponseBodyModuleFlightListFlightRuleListRefundRuleItemRefundSubItemsRefundSubContents> RefundSubContents { get; set; }
                            public class FlightOtaSearchResponseBodyModuleFlightListFlightRuleListRefundRuleItemRefundSubItemsRefundSubContents : TeaModel {
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
                    public FlightOtaSearchResponseBodyModuleFlightListFlightRuleListSignRule SignRule { get; set; }
                    public class FlightOtaSearchResponseBodyModuleFlightListFlightRuleListSignRule : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("able")]
                        [Validation(Required=false)]
                        public bool? Able { get; set; }

                        [NameInMap("info")]
                        [Validation(Required=false)]
                        public List<FlightOtaSearchResponseBodyModuleFlightListFlightRuleListSignRuleInfo> Info { get; set; }
                        public class FlightOtaSearchResponseBodyModuleFlightListFlightRuleListSignRuleInfo : TeaModel {
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
                    public FlightOtaSearchResponseBodyModuleFlightListFlightRuleListUpgradeRule UpgradeRule { get; set; }
                    public class FlightOtaSearchResponseBodyModuleFlightListFlightRuleListUpgradeRule : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("able")]
                        [Validation(Required=false)]
                        public bool? Able { get; set; }

                        [NameInMap("info")]
                        [Validation(Required=false)]
                        public List<FlightOtaSearchResponseBodyModuleFlightListFlightRuleListUpgradeRuleInfo> Info { get; set; }
                        public class FlightOtaSearchResponseBodyModuleFlightListFlightRuleListUpgradeRuleInfo : TeaModel {
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
                /// <para>6669c8e53b684105b8687bad0331988a_41</para>
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
