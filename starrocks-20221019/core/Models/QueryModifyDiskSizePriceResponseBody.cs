// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class QueryModifyDiskSizePriceResponseBody : TeaModel {
        /// <summary>
        /// <para>AccessDeniedDetail</para>
        /// 
        /// <b>Example:</b>
        /// <para>{     &quot;PolicyType&quot;: &quot;AccountLevelIdentityBasedPolicy&quot;,     &quot;AuthPrincipalOwnerId&quot;: &quot;xxx&quot;,     &quot;EncodedDiagnosticMessage&quot;: &quot;xxx&quot;,     &quot;AuthPrincipalType&quot;: &quot;xxx&quot;,     &quot;AuthPrincipalDisplayName&quot;: &quot;xxx&quot;,     &quot;NoPermissionType&quot;: &quot;ImplicitDeny&quot;,     &quot;AuthAction&quot;: &quot;sr:xxx&quot;   }</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The order information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryModifyDiskSizePriceResponseBodyData Data { get; set; }
        public class QueryModifyDiskSizePriceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The component prices.</para>
            /// </summary>
            [NameInMap("ComponentPrices")]
            [Validation(Required=false)]
            public List<QueryModifyDiskSizePriceResponseBodyDataComponentPrices> ComponentPrices { get; set; }
            public class QueryModifyDiskSizePriceResponseBodyDataComponentPrices : TeaModel {
                /// <summary>
                /// <para>The component name. Defaults to the component ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>disk_size</para>
                /// </summary>
                [NameInMap("ComponentName")]
                [Validation(Required=false)]
                public string ComponentName { get; set; }

                /// <summary>
                /// <para>The order discount amount.</para>
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
                /// <para>9872</para>
                /// </summary>
                [NameInMap("OriginalAmount")]
                [Validation(Required=false)]
                public float? OriginalAmount { get; set; }

                /// <summary>
                /// <para>The final price, which is the original price minus the discount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9872</para>
                /// </summary>
                [NameInMap("TradeAmount")]
                [Validation(Required=false)]
                public float? TradeAmount { get; set; }

            }

            /// <summary>
            /// <para>The currency. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>CNY: Chinese Yuan.</para>
            /// </description></item>
            /// <item><description><para>USD: US Dollar.</para>
            /// </description></item>
            /// <item><description><para>JPY: Japanese Yen.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CNY</para>
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// <para>Indicates whether to display the price reduction.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DepreciateInfo")]
            [Validation(Required=false)]
            public QueryModifyDiskSizePriceResponseBodyDataDepreciateInfo DepreciateInfo { get; set; }
            public class QueryModifyDiskSizePriceResponseBodyDataDepreciateInfo : TeaModel {
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
                /// <para>9872</para>
                /// </summary>
                [NameInMap("CheapStandAmount")]
                [Validation(Required=false)]
                public float? CheapStandAmount { get; set; }

                /// <summary>
                /// <para>Indicates whether to display the price reduction.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IsShow")]
                [Validation(Required=false)]
                public bool? IsShow { get; set; }

                /// <summary>
                /// <para>The original total official website price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9872</para>
                /// </summary>
                [NameInMap("OriginalStandAmount")]
                [Validation(Required=false)]
                public float? OriginalStandAmount { get; set; }

            }

            /// <summary>
            /// <para>The discount amount. Discount amount = original amount - billable amount (including coupon deductions).</para>
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
            public List<QueryModifyDiskSizePriceResponseBodyDataOptionalPromotions> OptionalPromotions { get; set; }
            public class QueryModifyDiskSizePriceResponseBodyDataOptionalPromotions : TeaModel {
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
            /// <para>The original price. Original amount = catalog price × billing usage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9872</para>
            /// </summary>
            [NameInMap("OriginalAmount")]
            [Validation(Required=false)]
            public float? OriginalAmount { get; set; }

            /// <summary>
            /// <para>The price calculation rules.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<QueryModifyDiskSizePriceResponseBodyDataRules> Rules { get; set; }
            public class QueryModifyDiskSizePriceResponseBodyDataRules : TeaModel {
                /// <summary>
                /// <para>The quantity.</para>
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
                /// <para>rule-083ja12</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The rule ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7ysj12ksaa</para>
                /// </summary>
                [NameInMap("RuleDescId")]
                [Validation(Required=false)]
                public string RuleDescId { get; set; }

            }

            /// <summary>
            /// <para>The discounted price based on the official website discount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9872</para>
            /// </summary>
            [NameInMap("StandDiscountPrice")]
            [Validation(Required=false)]
            public float? StandDiscountPrice { get; set; }

            /// <summary>
            /// <para>The official website discount price.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9872</para>
            /// </summary>
            [NameInMap("StandPrice")]
            [Validation(Required=false)]
            public float? StandPrice { get; set; }

            /// <summary>
            /// <para>The amount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9872</para>
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
        /// <para>null</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The HTTP request status code.</para>
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
        /// <para>false</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
