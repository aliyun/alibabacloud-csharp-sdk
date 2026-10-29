// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeBandwidthPackagePriceResponseBody : TeaModel {
        /// <summary>
        /// <para>The price.</para>
        /// </summary>
        [NameInMap("Price")]
        [Validation(Required=false)]
        public DescribeBandwidthPackagePriceResponseBodyPrice Price { get; set; }
        public class DescribeBandwidthPackagePriceResponseBodyPrice : TeaModel {
            /// <summary>
            /// <para>&lt;props=&quot;china&quot;&gt;The currency unit (CNY).
            /// &lt;props=&quot;intl&quot;&gt;The currency unit (USD).</para>
            /// 
            /// <b>Example:</b>
            /// <para>CNY</para>
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// <para>The discounted price.</para>
            /// 
            /// <b>Example:</b>
            /// <para>274.75</para>
            /// </summary>
            [NameInMap("DiscountPrice")]
            [Validation(Required=false)]
            public float? DiscountPrice { get; set; }

            /// <summary>
            /// <para>The original price.</para>
            /// <para>&lt;props=&quot;china&quot;&gt;Unit: CNY.</para>
            /// <para>&lt;props=&quot;intl&quot;&gt;Unit: USD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8800</para>
            /// </summary>
            [NameInMap("OriginalPrice")]
            [Validation(Required=false)]
            public float? OriginalPrice { get; set; }

            /// <summary>
            /// <para>The promotion information.</para>
            /// </summary>
            [NameInMap("Promotions")]
            [Validation(Required=false)]
            public List<DescribeBandwidthPackagePriceResponseBodyPricePromotions> Promotions { get; set; }
            public class DescribeBandwidthPackagePriceResponseBodyPricePromotions : TeaModel {
                /// <summary>
                /// <para>The promotion code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>youhui_quan</para>
                /// </summary>
                [NameInMap("OptionCode")]
                [Validation(Required=false)]
                public string OptionCode { get; set; }

                /// <summary>
                /// <para>The promotion description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>youhui</para>
                /// </summary>
                [NameInMap("PromotionDesc")]
                [Validation(Required=false)]
                public string PromotionDesc { get; set; }

                /// <summary>
                /// <para>The ID of the promotion.</para>
                /// 
                /// <b>Example:</b>
                /// <para>91381816****</para>
                /// </summary>
                [NameInMap("PromotionId")]
                [Validation(Required=false)]
                public string PromotionId { get; set; }

                /// <summary>
                /// <para>The name of the promotion.</para>
                /// 
                /// <b>Example:</b>
                /// <para>youhui</para>
                /// </summary>
                [NameInMap("PromotionName")]
                [Validation(Required=false)]
                public string PromotionName { get; set; }

                /// <summary>
                /// <para>Indicates whether the promotion is selected.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ture</para>
                /// </summary>
                [NameInMap("Selected")]
                [Validation(Required=false)]
                public bool? Selected { get; set; }

            }

            /// <summary>
            /// <para>The transaction price.</para>
            /// 
            /// <b>Example:</b>
            /// <para>213.52</para>
            /// </summary>
            [NameInMap("TradePrice")]
            [Validation(Required=false)]
            public float? TradePrice { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>6C8439B9-7DBF-57F4-92AE-55A9B9D3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The promotion rules.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<DescribeBandwidthPackagePriceResponseBodyRules> Rules { get; set; }
        public class DescribeBandwidthPackagePriceResponseBodyRules : TeaModel {
            /// <summary>
            /// <para>The rule description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a7gesyly7o34qy****</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

        }

    }

}
