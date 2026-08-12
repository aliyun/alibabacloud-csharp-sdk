// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class QueryModifyDiskTypePriceResponseBody : TeaModel {
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
        /// <para>Returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryModifyDiskTypePriceResponseBodyData Data { get; set; }
        public class QueryModifyDiskTypePriceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Component prices.</para>
            /// </summary>
            [NameInMap("ComponentPrices")]
            [Validation(Required=false)]
            public List<QueryModifyDiskTypePriceResponseBodyDataComponentPrices> ComponentPrices { get; set; }
            public class QueryModifyDiskTypePriceResponseBodyDataComponentPrices : TeaModel {
                /// <summary>
                /// <para>Resource group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>disk_type</para>
                /// </summary>
                [NameInMap("ComponentName")]
                [Validation(Required=false)]
                public string ComponentName { get; set; }

                /// <summary>
                /// <para>Discount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DiscountAmount")]
                [Validation(Required=false)]
                public float? DiscountAmount { get; set; }

                /// <summary>
                /// <para>Original price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10923</para>
                /// </summary>
                [NameInMap("OriginalAmount")]
                [Validation(Required=false)]
                public float? OriginalAmount { get; set; }

                /// <summary>
                /// <para>Final price, which is the original price minus the discount amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10923</para>
                /// </summary>
                [NameInMap("TradeAmount")]
                [Validation(Required=false)]
                public float? TradeAmount { get; set; }

            }

            /// <summary>
            /// <para>Currency.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CNY</para>
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// <para>Price reduction ratio.</para>
            /// </summary>
            [NameInMap("DepreciateInfo")]
            [Validation(Required=false)]
            public QueryModifyDiskTypePriceResponseBodyDataDepreciateInfo DepreciateInfo { get; set; }
            public class QueryModifyDiskTypePriceResponseBodyDataDepreciateInfo : TeaModel {
                /// <summary>
                /// <para>Price reduction ratio.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CheapRate")]
                [Validation(Required=false)]
                public float? CheapRate { get; set; }

                /// <summary>
                /// <para>Total official website price after reduction.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10923</para>
                /// </summary>
                [NameInMap("CheapStandAmount")]
                [Validation(Required=false)]
                public float? CheapStandAmount { get; set; }

                /// <summary>
                /// <para>Display price reduction range.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsShow")]
                [Validation(Required=false)]
                public bool? IsShow { get; set; }

                /// <summary>
                /// <para>Original total official website price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10923</para>
                /// </summary>
                [NameInMap("OriginalStandAmount")]
                [Validation(Required=false)]
                public float? OriginalStandAmount { get; set; }

            }

            /// <summary>
            /// <para>Discount amount = original amount - bill payable amount (including coupon deduction amount).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DiscountAmount")]
            [Validation(Required=false)]
            public float? DiscountAmount { get; set; }

            /// <summary>
            /// <para>Coupon information.</para>
            /// </summary>
            [NameInMap("OptionalPromotions")]
            [Validation(Required=false)]
            public List<QueryModifyDiskTypePriceResponseBodyDataOptionalPromotions> OptionalPromotions { get; set; }
            public class QueryModifyDiskTypePriceResponseBodyDataOptionalPromotions : TeaModel {
                /// <summary>
                /// <para>The description of the coupon.</para>
                /// 
                /// <b>Example:</b>
                /// <para>youhuiquan_desc</para>
                /// </summary>
                [NameInMap("PromotionDesc")]
                [Validation(Required=false)]
                public string PromotionDesc { get; set; }

                /// <summary>
                /// <para>Coupon name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>youhuiquan_promotion_option_id_for_blank</para>
                /// </summary>
                [NameInMap("PromotionName")]
                [Validation(Required=false)]
                public string PromotionName { get; set; }

                /// <summary>
                /// <para>Coupon ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>youhuiquan_12378dfj6</para>
                /// </summary>
                [NameInMap("PromotionOptionNo")]
                [Validation(Required=false)]
                public string PromotionOptionNo { get; set; }

            }

            /// <summary>
            /// <para>Original price (original amount) = catalog price × usage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10923</para>
            /// </summary>
            [NameInMap("OriginalAmount")]
            [Validation(Required=false)]
            public float? OriginalAmount { get; set; }

            /// <summary>
            /// <para>Returned data structure.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<QueryModifyDiskTypePriceResponseBodyDataRules> Rules { get; set; }
            public class QueryModifyDiskTypePriceResponseBodyDataRules : TeaModel {
                /// <summary>
                /// <para>Quantity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Amount")]
                [Validation(Required=false)]
                public float? Amount { get; set; }

                /// <summary>
                /// <para>Rule name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rule-928shy23sa</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Rule ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7dsu230ks23</para>
                /// </summary>
                [NameInMap("RuleDescId")]
                [Validation(Required=false)]
                public string RuleDescId { get; set; }

            }

            /// <summary>
            /// <para>Discounted price based on the official website discount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10923</para>
            /// </summary>
            [NameInMap("StandDiscountPrice")]
            [Validation(Required=false)]
            public float? StandDiscountPrice { get; set; }

            /// <summary>
            /// <para>Official website discount price.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10923</para>
            /// </summary>
            [NameInMap("StandPrice")]
            [Validation(Required=false)]
            public float? StandPrice { get; set; }

            /// <summary>
            /// <para>Amount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10923</para>
            /// </summary>
            [NameInMap("TradeAmount")]
            [Validation(Required=false)]
            public float? TradeAmount { get; set; }

        }

        /// <summary>
        /// <para>Error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidParams</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>Error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Invalid params: [Region id should be select from set [cn-beijing, cn-hangzhou]]</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>HTTP request status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32A44F0D-BFF6-5664-999A-218BBDE74XXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Is the request successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
