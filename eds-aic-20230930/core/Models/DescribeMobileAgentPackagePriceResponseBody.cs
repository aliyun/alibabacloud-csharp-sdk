// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeMobileAgentPackagePriceResponseBody : TeaModel {
        /// <summary>
        /// <para>The price.</para>
        /// </summary>
        [NameInMap("Price")]
        [Validation(Required=false)]
        public DescribeMobileAgentPackagePriceResponseBodyPrice Price { get; set; }
        public class DescribeMobileAgentPackagePriceResponseBodyPrice : TeaModel {
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
            /// <para>The discounted price.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
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
            public List<DescribeMobileAgentPackagePriceResponseBodyPricePriceDetail> PriceDetail { get; set; }
            public class DescribeMobileAgentPackagePriceResponseBodyPricePriceDetail : TeaModel {
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
                public List<DescribeMobileAgentPackagePriceResponseBodyPricePriceDetailModulePrice> ModulePrice { get; set; }
                public class DescribeMobileAgentPackagePriceResponseBodyPricePriceDetailModulePrice : TeaModel {
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
                    /// <para>The name of the module.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Advanced Edition</para>
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
                /// <para>CloudPhoneMobileAgent</para>
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
            public List<DescribeMobileAgentPackagePriceResponseBodyPricePromotions> Promotions { get; set; }
            public class DescribeMobileAgentPackagePriceResponseBodyPricePromotions : TeaModel {
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
                /// <para>90712091****</para>
                /// </summary>
                [NameInMap("PromotionId")]
                [Validation(Required=false)]
                public string PromotionId { get; set; }

                /// <summary>
                /// <para>The name of the promotion.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Regular discount</para>
                /// </summary>
                [NameInMap("PromotionName")]
                [Validation(Required=false)]
                public string PromotionName { get; set; }

                /// <summary>
                /// <para>Indicates whether the promotion is selected.</para>
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
            /// <para>800</para>
            /// </summary>
            [NameInMap("TradePrice")]
            [Validation(Required=false)]
            public float? TradePrice { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The promotion rules.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<DescribeMobileAgentPackagePriceResponseBodyRules> Rules { get; set; }
        public class DescribeMobileAgentPackagePriceResponseBodyRules : TeaModel {
            /// <summary>
            /// <para>The rule description.</para>
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
            /// <para>f07tkae80jbiy****</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

        }

    }

}
