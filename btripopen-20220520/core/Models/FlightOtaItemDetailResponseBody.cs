// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightOtaItemDetailResponseBody : TeaModel {
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
                        /// baggage_desc
                        /// </summary>
                        [NameInMap("baggage_desc")]
                        [Validation(Required=false)]
                        public List<string> BaggageDesc { get; set; }

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
                        public FlightOtaItemDetailResponseBodyModuleBaggageRuleBaggageSubItemsBaggageSubContentVisualizesImageDO ImageDO { get; set; }
                        public class FlightOtaItemDetailResponseBodyModuleBaggageRuleBaggageSubItemsBaggageSubContentVisualizesImageDO : TeaModel {
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
                public FlightOtaItemDetailResponseBodyModuleBaggageRuleTips Tips { get; set; }
                public class FlightOtaItemDetailResponseBodyModuleBaggageRuleTips : TeaModel {
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

                [NameInMap("flight_no")]
                [Validation(Required=false)]
                public string FlightNo { get; set; }

                [NameInMap("free_baggage")]
                [Validation(Required=false)]
                public int? FreeBaggage { get; set; }

                [NameInMap("index")]
                [Validation(Required=false)]
                public int? Index { get; set; }

                [NameInMap("level")]
                [Validation(Required=false)]
                public int? Level { get; set; }

                [NameInMap("refund_sub_items")]
                [Validation(Required=false)]
                public List<FlightOtaItemDetailResponseBodyModuleChangeRuleRefundSubItems> RefundSubItems { get; set; }
                public class FlightOtaItemDetailResponseBodyModuleChangeRuleRefundSubItems : TeaModel {
                    [NameInMap("is_struct")]
                    [Validation(Required=false)]
                    public bool? IsStruct { get; set; }

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

                        [NameInMap("style")]
                        [Validation(Required=false)]
                        public int? Style { get; set; }

                    }

                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                /// <summary>
                /// subTableHead
                /// </summary>
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

                [NameInMap("flight_no")]
                [Validation(Required=false)]
                public string FlightNo { get; set; }

                [NameInMap("free_baggage")]
                [Validation(Required=false)]
                public int? FreeBaggage { get; set; }

                [NameInMap("index")]
                [Validation(Required=false)]
                public int? Index { get; set; }

                [NameInMap("level")]
                [Validation(Required=false)]
                public int? Level { get; set; }

                [NameInMap("refund_sub_items")]
                [Validation(Required=false)]
                public List<FlightOtaItemDetailResponseBodyModuleRefundRuleRefundSubItems> RefundSubItems { get; set; }
                public class FlightOtaItemDetailResponseBodyModuleRefundRuleRefundSubItems : TeaModel {
                    [NameInMap("is_struct")]
                    [Validation(Required=false)]
                    public bool? IsStruct { get; set; }

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

                        [NameInMap("style")]
                        [Validation(Required=false)]
                        public int? Style { get; set; }

                    }

                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                /// <summary>
                /// subTableHead
                /// </summary>
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

            [NameInMap("sell_price")]
            [Validation(Required=false)]
            public int? SellPrice { get; set; }

            [NameInMap("sell_price_list")]
            [Validation(Required=false)]
            public List<int?> SellPriceList { get; set; }

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
