// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class QueryEnableMultiAzPriceResponseBody : TeaModel {
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
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryEnableMultiAzPriceResponseBodyData Data { get; set; }
        public class QueryEnableMultiAzPriceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The component prices.</para>
            /// </summary>
            [NameInMap("ComponentPrices")]
            [Validation(Required=false)]
            public List<QueryEnableMultiAzPriceResponseBodyDataComponentPrices> ComponentPrices { get; set; }
            public class QueryEnableMultiAzPriceResponseBodyDataComponentPrices : TeaModel {
                /// <summary>
                /// <para>The component name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>multi-zone</para>
                /// </summary>
                [NameInMap("ComponentName")]
                [Validation(Required=false)]
                public string ComponentName { get; set; }

                /// <summary>
                /// <para>The discount amount for the order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DiscountAmount")]
                [Validation(Required=false)]
                public float? DiscountAmount { get; set; }

                /// <summary>
                /// <para>The original price of the order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7641</para>
                /// </summary>
                [NameInMap("OriginalAmount")]
                [Validation(Required=false)]
                public float? OriginalAmount { get; set; }

                /// <summary>
                /// <para>The final price, which is the original price minus the discount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7641</para>
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
            /// <item><description><para>USD: U.S. dollar.</para>
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
            /// <para>The total official price after the price reduction.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7641</para>
            /// </summary>
            [NameInMap("DepreciateInfo")]
            [Validation(Required=false)]
            public QueryEnableMultiAzPriceResponseBodyDataDepreciateInfo DepreciateInfo { get; set; }
            public class QueryEnableMultiAzPriceResponseBodyDataDepreciateInfo : TeaModel {
                /// <summary>
                /// <para>The price reduction percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CheapRate")]
                [Validation(Required=false)]
                public float? CheapRate { get; set; }

                /// <summary>
                /// <para>The total official price after the price reduction.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7641</para>
                /// </summary>
                [NameInMap("CheapStandAmount")]
                [Validation(Required=false)]
                public float? CheapStandAmount { get; set; }

                /// <summary>
                /// <para>Indicates whether to show the price reduction.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsShow")]
                [Validation(Required=false)]
                public bool? IsShow { get; set; }

                /// <summary>
                /// <para>The original total official price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7641</para>
                /// </summary>
                [NameInMap("OriginalStandAmount")]
                [Validation(Required=false)]
                public float? OriginalStandAmount { get; set; }

            }

            /// <summary>
            /// <para>The discount amount. This is the original amount minus the bill\&quot;s payable amount, which includes coupon deductions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DiscountAmount")]
            [Validation(Required=false)]
            public float? DiscountAmount { get; set; }

            /// <summary>
            /// <para>The module ID.</para>
            /// </summary>
            [NameInMap("ModuleInstance")]
            [Validation(Required=false)]
            public List<QueryEnableMultiAzPriceResponseBodyDataModuleInstance> ModuleInstance { get; set; }
            public class QueryEnableMultiAzPriceResponseBodyDataModuleInstance : TeaModel {
                /// <summary>
                /// <para>The identifier of the billing module.</para>
                /// 
                /// <b>Example:</b>
                /// <para>multi-zone</para>
                /// </summary>
                [NameInMap("ModuleCode")]
                [Validation(Required=false)]
                public string ModuleCode { get; set; }

                /// <summary>
                /// <para>The module name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zone</para>
                /// </summary>
                [NameInMap("ModuleName")]
                [Validation(Required=false)]
                public string ModuleName { get; set; }

                /// <summary>
                /// <para>The discounted price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7641</para>
                /// </summary>
                [NameInMap("StandPrice")]
                [Validation(Required=false)]
                public string StandPrice { get; set; }

                /// <summary>
                /// <para>The original price of the product.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7641</para>
                /// </summary>
                [NameInMap("TotalProductFee")]
                [Validation(Required=false)]
                public string TotalProductFee { get; set; }

            }

            /// <summary>
            /// <para>The coupon information.</para>
            /// </summary>
            [NameInMap("OptionalPromotions")]
            [Validation(Required=false)]
            public List<QueryEnableMultiAzPriceResponseBodyDataOptionalPromotions> OptionalPromotions { get; set; }
            public class QueryEnableMultiAzPriceResponseBodyDataOptionalPromotions : TeaModel {
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
            /// <para>The original price. This is the list price multiplied by the usage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7641</para>
            /// </summary>
            [NameInMap("OriginalAmount")]
            [Validation(Required=false)]
            public float? OriginalAmount { get; set; }

            /// <summary>
            /// <para>The returned data structure.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<QueryEnableMultiAzPriceResponseBodyDataRules> Rules { get; set; }
            public class QueryEnableMultiAzPriceResponseBodyDataRules : TeaModel {
                /// <summary>
                /// <para>The quantity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Amount")]
                [Validation(Required=false)]
                public float? Amount { get; set; }

                /// <summary>
                /// <para>The rule name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rule_28sdhsu2320t</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The rule ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2ju2sd9dss</para>
                /// </summary>
                [NameInMap("RuleDescId")]
                [Validation(Required=false)]
                public string RuleDescId { get; set; }

            }

            /// <summary>
            /// <para>The discounted price based on the official discount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7641</para>
            /// </summary>
            [NameInMap("StandDiscountPrice")]
            [Validation(Required=false)]
            public float? StandDiscountPrice { get; set; }

            /// <summary>
            /// <para>The official discounted price.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7641</para>
            /// </summary>
            [NameInMap("StandPrice")]
            [Validation(Required=false)]
            public float? StandPrice { get; set; }

            /// <summary>
            /// <para>The amount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7641</para>
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
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
