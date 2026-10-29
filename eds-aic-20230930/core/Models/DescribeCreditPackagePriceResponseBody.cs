// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeCreditPackagePriceResponseBody : TeaModel {
        /// <summary>
        /// <para>The price.</para>
        /// </summary>
        [NameInMap("Price")]
        [Validation(Required=false)]
        public DescribeCreditPackagePriceResponseBodyPrice Price { get; set; }
        public class DescribeCreditPackagePriceResponseBodyPrice : TeaModel {
            /// <summary>
            /// <para>The currency. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CNY: Chinese yuan</description></item>
            /// <item><description>USD: US dollar</description></item>
            /// <item><description>JPY: Japanese yen</description></item>
            /// </list>
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
            /// <para>800</para>
            /// </summary>
            [NameInMap("DiscountPrice")]
            [Validation(Required=false)]
            public float? DiscountPrice { get; set; }

            /// <summary>
            /// <para>The original price.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("OriginalPrice")]
            [Validation(Required=false)]
            public float? OriginalPrice { get; set; }

            /// <summary>
            /// <para>The price details.</para>
            /// </summary>
            [NameInMap("PriceDetail")]
            [Validation(Required=false)]
            public List<DescribeCreditPackagePriceResponseBodyPricePriceDetail> PriceDetail { get; set; }
            public class DescribeCreditPackagePriceResponseBodyPricePriceDetail : TeaModel {
                /// <summary>
                /// <para>The discounted price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>800</para>
                /// </summary>
                [NameInMap("DiscountPrice")]
                [Validation(Required=false)]
                public float? DiscountPrice { get; set; }

                /// <summary>
                /// <para>The prices of the modules.</para>
                /// </summary>
                [NameInMap("ModulePrice")]
                [Validation(Required=false)]
                public List<DescribeCreditPackagePriceResponseBodyPricePriceDetailModulePrice> ModulePrice { get; set; }
                public class DescribeCreditPackagePriceResponseBodyPricePriceDetailModulePrice : TeaModel {
                    /// <summary>
                    /// <para>The discounted price.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>800</para>
                    /// </summary>
                    [NameInMap("DiscountPrice")]
                    [Validation(Required=false)]
                    public string DiscountPrice { get; set; }

                    /// <summary>
                    /// <para>The name of the billing module.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000 credits</para>
                    /// </summary>
                    [NameInMap("ModuleName")]
                    [Validation(Required=false)]
                    public string ModuleName { get; set; }

                    /// <summary>
                    /// <para>The original price.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("OriginalPrice")]
                    [Validation(Required=false)]
                    public string OriginalPrice { get; set; }

                    /// <summary>
                    /// <para>The transaction price.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("TradePrice")]
                    [Validation(Required=false)]
                    public string TradePrice { get; set; }

                }

                /// <summary>
                /// <para>The original price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("OriginalPrice")]
                [Validation(Required=false)]
                public float? OriginalPrice { get; set; }

                /// <summary>
                /// <para>The resource type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CloudPhoneAIPackage</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <para>The transaction price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("TradePrice")]
                [Validation(Required=false)]
                public float? TradePrice { get; set; }

            }

            /// <summary>
            /// <para>The promotion information.</para>
            /// </summary>
            [NameInMap("Promotions")]
            [Validation(Required=false)]
            public List<DescribeCreditPackagePriceResponseBodyPricePromotions> Promotions { get; set; }
            public class DescribeCreditPackagePriceResponseBodyPricePromotions : TeaModel {
                /// <summary>
                /// <para>The coupon code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>daily</para>
                /// </summary>
                [NameInMap("OptionCode")]
                [Validation(Required=false)]
                public string OptionCode { get; set; }

                /// <summary>
                /// <para>The coupon description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Regular discount</para>
                /// </summary>
                [NameInMap("PromotionDesc")]
                [Validation(Required=false)]
                public string PromotionDesc { get; set; }

                /// <summary>
                /// <para>The ID of the promotion.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50003308011****</para>
                /// </summary>
                [NameInMap("PromotionId")]
                [Validation(Required=false)]
                public string PromotionId { get; set; }

                /// <summary>
                /// <para>The coupon name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Regular discount</para>
                /// </summary>
                [NameInMap("PromotionName")]
                [Validation(Required=false)]
                public string PromotionName { get; set; }

                /// <summary>
                /// <para>Indicates whether the coupon is selected.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Selected")]
                [Validation(Required=false)]
                public bool? Selected { get; set; }

            }

            /// <summary>
            /// <para>The transaction price.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
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
        public List<DescribeCreditPackagePriceResponseBodyRules> Rules { get; set; }
        public class DescribeCreditPackagePriceResponseBodyRules : TeaModel {
            /// <summary>
            /// <para>The promotion description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Regular discount</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3s2f42fis7pmb9****</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

        }

    }

}
