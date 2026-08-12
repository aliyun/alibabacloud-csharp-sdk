// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class QueryModifyCuPriceResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the access denial.</para>
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
        public QueryModifyCuPriceResponseBodyData Data { get; set; }
        public class QueryModifyCuPriceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The prices of the components.</para>
            /// </summary>
            [NameInMap("ComponentPrices")]
            [Validation(Required=false)]
            public List<QueryModifyCuPriceResponseBodyDataComponentPrices> ComponentPrices { get; set; }
            public class QueryModifyCuPriceResponseBodyDataComponentPrices : TeaModel {
                /// <summary>
                /// <para>The name of the component.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cu_num</para>
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
                /// <para>7986</para>
                /// </summary>
                [NameInMap("OriginalAmount")]
                [Validation(Required=false)]
                public float? OriginalAmount { get; set; }

                /// <summary>
                /// <para>The final price, which is the original price minus the discount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7986</para>
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
            /// <para>The depreciation rate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DepreciateInfo")]
            [Validation(Required=false)]
            public QueryModifyCuPriceResponseBodyDataDepreciateInfo DepreciateInfo { get; set; }
            public class QueryModifyCuPriceResponseBodyDataDepreciateInfo : TeaModel {
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
                /// <para>The total list price after the price reduction.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7986</para>
                /// </summary>
                [NameInMap("CheapStandAmount")]
                [Validation(Required=false)]
                public float? CheapStandAmount { get; set; }

                /// <summary>
                /// <para>Indicates whether to show the price reduction information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsShow")]
                [Validation(Required=false)]
                public bool? IsShow { get; set; }

                /// <summary>
                /// <para>The original total list price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7986</para>
                /// </summary>
                [NameInMap("OriginalStandAmount")]
                [Validation(Required=false)]
                public float? OriginalStandAmount { get; set; }

            }

            /// <summary>
            /// <para>The discount amount. Discount amount = Original amount - Billable amount. The billable amount includes coupon deductions.</para>
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
            public List<QueryModifyCuPriceResponseBodyDataOptionalPromotions> OptionalPromotions { get; set; }
            public class QueryModifyCuPriceResponseBodyDataOptionalPromotions : TeaModel {
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
                /// <para>The name of the coupon.</para>
                /// 
                /// <b>Example:</b>
                /// <para>youhuiquan_promotion_option_id_for_blank</para>
                /// </summary>
                [NameInMap("PromotionName")]
                [Validation(Required=false)]
                public string PromotionName { get; set; }

                /// <summary>
                /// <para>The ID of the coupon.</para>
                /// 
                /// <b>Example:</b>
                /// <para>youhuiquan_12378dfj6</para>
                /// </summary>
                [NameInMap("PromotionOptionNo")]
                [Validation(Required=false)]
                public string PromotionOptionNo { get; set; }

            }

            /// <summary>
            /// <para>The original price. Original price = List price × Billing usage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7986</para>
            /// </summary>
            [NameInMap("OriginalAmount")]
            [Validation(Required=false)]
            public float? OriginalAmount { get; set; }

            /// <summary>
            /// <para>The data structure returned in the response.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<QueryModifyCuPriceResponseBodyDataRules> Rules { get; set; }
            public class QueryModifyCuPriceResponseBodyDataRules : TeaModel {
                /// <summary>
                /// <para>The number of instances to purchase in a batch. You can use this parameter to query the price of purchasing multiple Elastic Compute Service (ECS) instances with a specific configuration. Valid values: 1 to 1000.</para>
                /// <para>Default value: 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Amount")]
                [Validation(Required=false)]
                public float? Amount { get; set; }

                /// <summary>
                /// <para>The name of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rule_123123</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ID of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ak72hajsd</para>
                /// </summary>
                [NameInMap("RuleDescId")]
                [Validation(Required=false)]
                public string RuleDescId { get; set; }

            }

            /// <summary>
            /// <para>The price after the standard discount is applied.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7986</para>
            /// </summary>
            [NameInMap("StandDiscountPrice")]
            [Validation(Required=false)]
            public float? StandDiscountPrice { get; set; }

            /// <summary>
            /// <para>The discounted price on the official website.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7986</para>
            /// </summary>
            [NameInMap("StandPrice")]
            [Validation(Required=false)]
            public float? StandPrice { get; set; }

            /// <summary>
            /// <para>The transaction amount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7986</para>
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
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B67D142D-D54E-184F-A306-22BDC01B2XXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
