// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightOtaItemDetailResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
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
        public FlightOtaItemDetailResponseBodyModule Module { get; set; }
        public class FlightOtaItemDetailResponseBodyModule : TeaModel {
            [NameInMap("baggage_rule")]
            [Validation(Required=false)]
            public List<FlightOtaItemDetailResponseBodyModuleBaggageRule> BaggageRule { get; set; }
            public class FlightOtaItemDetailResponseBodyModuleBaggageRule : TeaModel {
                [NameInMap("baggage_sub_items")]
                [Validation(Required=false)]
                public List<FlightOtaItemDetailResponseBodyModuleBaggageRuleBaggageSubItems> BaggageSubItems { get; set; }
                public class FlightOtaItemDetailResponseBodyModuleBaggageRuleBaggageSubItems : TeaModel {
                    [NameInMap("baggage_sub_content_visualizes")]
                    [Validation(Required=false)]
                    public List<FlightOtaItemDetailResponseBodyModuleBaggageRuleBaggageSubItemsBaggageSubContentVisualizes> BaggageSubContentVisualizes { get; set; }
                    public class FlightOtaItemDetailResponseBodyModuleBaggageRuleBaggageSubItemsBaggageSubContentVisualizes : TeaModel {
                        /// <summary>
                        /// <para>baggage_desc</para>
                        /// </summary>
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
                        public FlightOtaItemDetailResponseBodyModuleBaggageRuleBaggageSubItemsBaggageSubContentVisualizesDescription Description { get; set; }
                        public class FlightOtaItemDetailResponseBodyModuleBaggageRuleBaggageSubItemsBaggageSubContentVisualizesDescription : TeaModel {
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
                        public FlightOtaItemDetailResponseBodyModuleBaggageRuleBaggageSubItemsBaggageSubContentVisualizesImageDO ImageDO { get; set; }
                        public class FlightOtaItemDetailResponseBodyModuleBaggageRuleBaggageSubItemsBaggageSubContentVisualizesImageDO : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para><a href="https://gw.alicdn.com/imgextra/i3/O1CN01kLt3m923XsUs6WVif_!!6000000007266-2-tps-280-300.png">https://gw.alicdn.com/imgextra/i3/O1CN01kLt3m923XsUs6WVif_!!6000000007266-2-tps-280-300.png</a></para>
                            /// </summary>
                            [NameInMap("image")]
                            [Validation(Required=false)]
                            public string Image { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>55</para>
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
                        /// <para>false</para>
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
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("is_struct")]
                    [Validation(Required=false)]
                    public bool? IsStruct { get; set; }

                    /// <summary>
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
                /// <para>0</para>
                /// </summary>
                [NameInMap("index")]
                [Validation(Required=false)]
                public int? Index { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>tableHead</para>
                /// </summary>
                [NameInMap("table_head")]
                [Validation(Required=false)]
                public string TableHead { get; set; }

                [NameInMap("tips")]
                [Validation(Required=false)]
                public FlightOtaItemDetailResponseBodyModuleBaggageRuleTips Tips { get; set; }
                public class FlightOtaItemDetailResponseBodyModuleBaggageRuleTips : TeaModel {
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
                /// <para>2</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

            [NameInMap("change_rule")]
            [Validation(Required=false)]
            public List<FlightOtaItemDetailResponseBodyModuleChangeRule> ChangeRule { get; set; }
            public class FlightOtaItemDetailResponseBodyModuleChangeRule : TeaModel {
                [NameInMap("extra_contents")]
                [Validation(Required=false)]
                public List<FlightOtaItemDetailResponseBodyModuleChangeRuleExtraContents> ExtraContents { get; set; }
                public class FlightOtaItemDetailResponseBodyModuleChangeRuleExtraContents : TeaModel {
                    [NameInMap("content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>HO3925</para>
                /// </summary>
                [NameInMap("flight_no")]
                [Validation(Required=false)]
                public string FlightNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("free_baggage")]
                [Validation(Required=false)]
                public int? FreeBaggage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("index")]
                [Validation(Required=false)]
                public int? Index { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("level")]
                [Validation(Required=false)]
                public int? Level { get; set; }

                [NameInMap("refund_sub_items")]
                [Validation(Required=false)]
                public List<FlightOtaItemDetailResponseBodyModuleChangeRuleRefundSubItems> RefundSubItems { get; set; }
                public class FlightOtaItemDetailResponseBodyModuleChangeRuleRefundSubItems : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("is_struct")]
                    [Validation(Required=false)]
                    public bool? IsStruct { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ADT</para>
                    /// </summary>
                    [NameInMap("ptc")]
                    [Validation(Required=false)]
                    public string Ptc { get; set; }

                    [NameInMap("refund_sub_contents")]
                    [Validation(Required=false)]
                    public List<FlightOtaItemDetailResponseBodyModuleChangeRuleRefundSubItemsRefundSubContents> RefundSubContents { get; set; }
                    public class FlightOtaItemDetailResponseBodyModuleChangeRuleRefundSubItemsRefundSubContents : TeaModel {
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

                /// <summary>
                /// <para>subTableHead</para>
                /// </summary>
                [NameInMap("sub_table_head")]
                [Validation(Required=false)]
                public List<string> SubTableHead { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>tableHead</para>
                /// </summary>
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

            [NameInMap("refund_rule")]
            [Validation(Required=false)]
            public List<FlightOtaItemDetailResponseBodyModuleRefundRule> RefundRule { get; set; }
            public class FlightOtaItemDetailResponseBodyModuleRefundRule : TeaModel {
                [NameInMap("extra_contents")]
                [Validation(Required=false)]
                public List<FlightOtaItemDetailResponseBodyModuleRefundRuleExtraContents> ExtraContents { get; set; }
                public class FlightOtaItemDetailResponseBodyModuleRefundRuleExtraContents : TeaModel {
                    [NameInMap("content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>HO3925</para>
                /// </summary>
                [NameInMap("flight_no")]
                [Validation(Required=false)]
                public string FlightNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("free_baggage")]
                [Validation(Required=false)]
                public int? FreeBaggage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("index")]
                [Validation(Required=false)]
                public int? Index { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("level")]
                [Validation(Required=false)]
                public int? Level { get; set; }

                [NameInMap("refund_sub_items")]
                [Validation(Required=false)]
                public List<FlightOtaItemDetailResponseBodyModuleRefundRuleRefundSubItems> RefundSubItems { get; set; }
                public class FlightOtaItemDetailResponseBodyModuleRefundRuleRefundSubItems : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("is_struct")]
                    [Validation(Required=false)]
                    public bool? IsStruct { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ADT</para>
                    /// </summary>
                    [NameInMap("ptc")]
                    [Validation(Required=false)]
                    public string Ptc { get; set; }

                    [NameInMap("refund_sub_contents")]
                    [Validation(Required=false)]
                    public List<FlightOtaItemDetailResponseBodyModuleRefundRuleRefundSubItemsRefundSubContents> RefundSubContents { get; set; }
                    public class FlightOtaItemDetailResponseBodyModuleRefundRuleRefundSubItemsRefundSubContents : TeaModel {
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

                /// <summary>
                /// <para>subTableHead</para>
                /// </summary>
                [NameInMap("sub_table_head")]
                [Validation(Required=false)]
                public List<string> SubTableHead { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>tableHead</para>
                /// </summary>
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
            /// <para>1830</para>
            /// </summary>
            [NameInMap("sell_price")]
            [Validation(Required=false)]
            public int? SellPrice { get; set; }

            [NameInMap("sell_price_list")]
            [Validation(Required=false)]
            public List<int?> SellPriceList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("trip_type")]
            [Validation(Required=false)]
            public int? TripType { get; set; }

        }

        /// <summary>
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>92359A00-85D8-16C4-AED0-249618DEEC17</para>
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
        /// <para>traceId</para>
        /// 
        /// <b>Example:</b>
        /// <para>210bc60a16916374201706365d2a16</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
