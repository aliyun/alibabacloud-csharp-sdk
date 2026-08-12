// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class QueryPriceV1ResponseBody : TeaModel {
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
        /// <para>Response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryPriceV1ResponseBodyData Data { get; set; }
        public class QueryPriceV1ResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Component prices.</para>
            /// </summary>
            [NameInMap("ComponentPrices")]
            [Validation(Required=false)]
            public List<QueryPriceV1ResponseBodyDataComponentPrices> ComponentPrices { get; set; }
            public class QueryPriceV1ResponseBodyDataComponentPrices : TeaModel {
                /// <summary>
                /// <para>Component name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FE</para>
                /// </summary>
                [NameInMap("ComponentName")]
                [Validation(Required=false)]
                public string ComponentName { get; set; }

                /// <summary>
                /// <para>Order discount amount.</para>
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
                /// <para>3192</para>
                /// </summary>
                [NameInMap("OriginalAmount")]
                [Validation(Required=false)]
                public float? OriginalAmount { get; set; }

                /// <summary>
                /// <para>Final price = original price − discount amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3192</para>
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
            /// <para>Promotion information.</para>
            /// </summary>
            [NameInMap("DepreciateInfo")]
            [Validation(Required=false)]
            public QueryPriceV1ResponseBodyDataDepreciateInfo DepreciateInfo { get; set; }
            public class QueryPriceV1ResponseBodyDataDepreciateInfo : TeaModel {
                /// <summary>
                /// <para>Discount rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CheapRate")]
                [Validation(Required=false)]
                public float? CheapRate { get; set; }

                /// <summary>
                /// <para>Total official price after discount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8094</para>
                /// </summary>
                [NameInMap("CheapStandAmount")]
                [Validation(Required=false)]
                public float? CheapStandAmount { get; set; }

                /// <summary>
                /// <para>Indicates whether to display the discount rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsShow")]
                [Validation(Required=false)]
                public bool? IsShow { get; set; }

                /// <summary>
                /// <para>Original total official price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8094</para>
                /// </summary>
                [NameInMap("OriginalStandAmount")]
                [Validation(Required=false)]
                public float? OriginalStandAmount { get; set; }

            }

            /// <summary>
            /// <para>Discount amount = original amount − billable amount (including coupon discounts).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DiscountAmount")]
            [Validation(Required=false)]
            public float? DiscountAmount { get; set; }

            /// <summary>
            /// <para>Product original price.</para>
            /// </summary>
            [NameInMap("ModuleInstance")]
            [Validation(Required=false)]
            public List<QueryPriceV1ResponseBodyDataModuleInstance> ModuleInstance { get; set; }
            public class QueryPriceV1ResponseBodyDataModuleInstance : TeaModel {
                /// <summary>
                /// <para>Pricing module code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cu_num</para>
                /// </summary>
                [NameInMap("ModuleCode")]
                [Validation(Required=false)]
                public string ModuleCode { get; set; }

                /// <summary>
                /// <para>Pricing module name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CU</para>
                /// </summary>
                [NameInMap("ModuleName")]
                [Validation(Required=false)]
                public string ModuleName { get; set; }

                /// <summary>
                /// <para>Discounted price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1622</para>
                /// </summary>
                [NameInMap("StandPrice")]
                [Validation(Required=false)]
                public string StandPrice { get; set; }

                /// <summary>
                /// <para>Product original price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1622</para>
                /// </summary>
                [NameInMap("TotalProductFee")]
                [Validation(Required=false)]
                public string TotalProductFee { get; set; }

            }

            /// <summary>
            /// <para>Coupon information.</para>
            /// </summary>
            [NameInMap("OptionalPromotions")]
            [Validation(Required=false)]
            public List<QueryPriceV1ResponseBodyDataOptionalPromotions> OptionalPromotions { get; set; }
            public class QueryPriceV1ResponseBodyDataOptionalPromotions : TeaModel {
                /// <summary>
                /// <para>Coupon description.</para>
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
            /// <para>Original amount = list price × usage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8094</para>
            /// </summary>
            [NameInMap("OriginalAmount")]
            [Validation(Required=false)]
            public float? OriginalAmount { get; set; }

            /// <summary>
            /// <para>Response data structure.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<QueryPriceV1ResponseBodyDataRules> Rules { get; set; }
            public class QueryPriceV1ResponseBodyDataRules : TeaModel {
                /// <summary>
                /// <para>Quantity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Amount")]
                [Validation(Required=false)]
                public float? Amount { get; set; }

                /// <summary>
                /// <para>Rule name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rule_8usi12321sa</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Rule ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7u22yshaasds</para>
                /// </summary>
                [NameInMap("RuleDescId")]
                [Validation(Required=false)]
                public string RuleDescId { get; set; }

            }

            /// <summary>
            /// <para>Discounted price.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8094</para>
            /// </summary>
            [NameInMap("StandDiscountPrice")]
            [Validation(Required=false)]
            public float? StandDiscountPrice { get; set; }

            /// <summary>
            /// <para>Official discounted price.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8094</para>
            /// </summary>
            [NameInMap("StandPrice")]
            [Validation(Required=false)]
            public float? StandPrice { get; set; }

            /// <summary>
            /// <para>Final amount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8094</para>
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
        /// <para>Invalid params: [instance not exists].</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>HTTP status code.</para>
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
        /// <para>32A44F0D-BFF6-5664-999A-218BBDE7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
