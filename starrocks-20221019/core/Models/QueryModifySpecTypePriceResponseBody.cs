// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class QueryModifySpecTypePriceResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{     &quot;PolicyType&quot;: &quot;AccountLevelIdentityBasedPolicy&quot;,     &quot;AuthPrincipalOwnerId&quot;: &quot;xxx&quot;,     &quot;EncodedDiagnosticMessage&quot;: &quot;xxx&quot;,     &quot;AuthPrincipalType&quot;: &quot;xxx&quot;,     &quot;AuthPrincipalDisplayName&quot;: &quot;xxx&quot;,     &quot;NoPermissionType&quot;: &quot;ImplicitDeny&quot;,     &quot;AuthAction&quot;: &quot;sr:xxx&quot;   }</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryModifySpecTypePriceResponseBodyData Data { get; set; }
        public class QueryModifySpecTypePriceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The component prices.</para>
            /// </summary>
            [NameInMap("ComponentPrices")]
            [Validation(Required=false)]
            public List<QueryModifySpecTypePriceResponseBodyDataComponentPrices> ComponentPrices { get; set; }
            public class QueryModifySpecTypePriceResponseBodyDataComponentPrices : TeaModel {
                /// <summary>
                /// <para>The component name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>node_type</para>
                /// </summary>
                [NameInMap("ComponentName")]
                [Validation(Required=false)]
                public string ComponentName { get; set; }

                /// <summary>
                /// <para>The discount amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DiscountAmount")]
                [Validation(Required=false)]
                public float? DiscountAmount { get; set; }

                /// <summary>
                /// <para>The original price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5612</para>
                /// </summary>
                [NameInMap("OriginalAmount")]
                [Validation(Required=false)]
                public float? OriginalAmount { get; set; }

                /// <summary>
                /// <para>The final price. The final price is the original price minus the discount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5612</para>
                /// </summary>
                [NameInMap("TradeAmount")]
                [Validation(Required=false)]
                public float? TradeAmount { get; set; }

            }

            /// <summary>
            /// <para>The currency.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CNY</para>
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// <para>The name of the campaign.</para>
            /// </summary>
            [NameInMap("DepreciateInfo")]
            [Validation(Required=false)]
            public QueryModifySpecTypePriceResponseBodyDataDepreciateInfo DepreciateInfo { get; set; }
            public class QueryModifySpecTypePriceResponseBodyDataDepreciateInfo : TeaModel {
                /// <summary>
                /// <para>The price reduction ratio.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CheapRate")]
                [Validation(Required=false)]
                public float? CheapRate { get; set; }

                /// <summary>
                /// <para>The total official website price after the price reduction.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5612</para>
                /// </summary>
                [NameInMap("CheapStandAmount")]
                [Validation(Required=false)]
                public float? CheapStandAmount { get; set; }

                /// <summary>
                /// <para>Indicates whether to display the price reduction.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsShow")]
                [Validation(Required=false)]
                public bool? IsShow { get; set; }

                /// <summary>
                /// <para>The original total official website price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5612</para>
                /// </summary>
                [NameInMap("OriginalStandAmount")]
                [Validation(Required=false)]
                public float? OriginalStandAmount { get; set; }

            }

            /// <summary>
            /// <para>The discount amount. Formula: Original amount - Payable amount on the bill. The payable amount includes the amount deducted by coupons.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DiscountAmount")]
            [Validation(Required=false)]
            public float? DiscountAmount { get; set; }

            /// <summary>
            /// <para>The coupon information.</para>
            /// </summary>
            [NameInMap("OptionalPromotions")]
            [Validation(Required=false)]
            public List<QueryModifySpecTypePriceResponseBodyDataOptionalPromotions> OptionalPromotions { get; set; }
            public class QueryModifySpecTypePriceResponseBodyDataOptionalPromotions : TeaModel {
                /// <summary>
                /// <para>The coupon description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>youhuiquan_desc</para>
                /// </summary>
                [NameInMap("PromotionDesc")]
                [Validation(Required=false)]
                public string PromotionDesc { get; set; }

                /// <summary>
                /// <para>The coupon name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>youhuiquan_promotion_option_id_for_blank</para>
                /// </summary>
                [NameInMap("PromotionName")]
                [Validation(Required=false)]
                public string PromotionName { get; set; }

                /// <summary>
                /// <para>The coupon ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>youhuiquan_12378dfj6</para>
                /// </summary>
                [NameInMap("PromotionOptionNo")]
                [Validation(Required=false)]
                public string PromotionOptionNo { get; set; }

            }

            /// <summary>
            /// <para>The original price. Formula: List price × Billed usage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5612</para>
            /// </summary>
            [NameInMap("OriginalAmount")]
            [Validation(Required=false)]
            public float? OriginalAmount { get; set; }

            /// <summary>
            /// <para>The price calculation rules.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<QueryModifySpecTypePriceResponseBodyDataRules> Rules { get; set; }
            public class QueryModifySpecTypePriceResponseBodyDataRules : TeaModel {
                /// <summary>
                /// <para>The resource count.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Amount")]
                [Validation(Required=false)]
                public float? Amount { get; set; }

                /// <summary>
                /// <para>The rule name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rule_827231sg1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The rule ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7usy32gs01</para>
                /// </summary>
                [NameInMap("RuleDescId")]
                [Validation(Required=false)]
                public string RuleDescId { get; set; }

            }

            /// <summary>
            /// <para>The discounted price that is based on the official website discount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5612</para>
            /// </summary>
            [NameInMap("StandDiscountPrice")]
            [Validation(Required=false)]
            public float? StandDiscountPrice { get; set; }

            /// <summary>
            /// <para>The official website discount price.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5612</para>
            /// </summary>
            [NameInMap("StandPrice")]
            [Validation(Required=false)]
            public float? StandPrice { get; set; }

            /// <summary>
            /// <para>The amount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5612</para>
            /// </summary>
            [NameInMap("TradeAmount")]
            [Validation(Required=false)]
            public float? TradeAmount { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidParams</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Invalid params: [instance not exists].</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32A44F0D-BFF6-5664-999A-218BBDE7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
