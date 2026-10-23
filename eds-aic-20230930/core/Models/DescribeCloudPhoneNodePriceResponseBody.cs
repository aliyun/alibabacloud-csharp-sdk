// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeCloudPhoneNodePriceResponseBody : TeaModel {
        [NameInMap("Price")]
        [Validation(Required=false)]
        public DescribeCloudPhoneNodePriceResponseBodyPrice Price { get; set; }
        public class DescribeCloudPhoneNodePriceResponseBodyPrice : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>CNY</para>
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>878.15</para>
            /// </summary>
            [NameInMap("DiscountPrice")]
            [Validation(Required=false)]
            public float? DiscountPrice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2710</para>
            /// </summary>
            [NameInMap("OriginalPrice")]
            [Validation(Required=false)]
            public float? OriginalPrice { get; set; }

            [NameInMap("PriceDetail")]
            [Validation(Required=false)]
            public List<DescribeCloudPhoneNodePriceResponseBodyPricePriceDetail> PriceDetail { get; set; }
            public class DescribeCloudPhoneNodePriceResponseBodyPricePriceDetail : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1978.2</para>
                /// </summary>
                [NameInMap("DiscountPrice")]
                [Validation(Required=false)]
                public float? DiscountPrice { get; set; }

                [NameInMap("ModulePrice")]
                [Validation(Required=false)]
                public List<DescribeCloudPhoneNodePriceResponseBodyPricePriceDetailModulePrice> ModulePrice { get; set; }
                public class DescribeCloudPhoneNodePriceResponseBodyPricePriceDetailModulePrice : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1978.2</para>
                    /// </summary>
                    [NameInMap("DiscountPrice")]
                    [Validation(Required=false)]
                    public string DiscountPrice { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>PhoneData</para>
                    /// </summary>
                    [NameInMap("ModuleName")]
                    [Validation(Required=false)]
                    public string ModuleName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>8990</para>
                    /// </summary>
                    [NameInMap("OriginalPrice")]
                    [Validation(Required=false)]
                    public string OriginalPrice { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1666.0</para>
                    /// </summary>
                    [NameInMap("TradePrice")]
                    [Validation(Required=false)]
                    public string TradePrice { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4199</para>
                /// </summary>
                [NameInMap("OriginalPrice")]
                [Validation(Required=false)]
                public float? OriginalPrice { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CloudPhoneMatrix</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>892.0</para>
                /// </summary>
                [NameInMap("TradePrice")]
                [Validation(Required=false)]
                public float? TradePrice { get; set; }

            }

            [NameInMap("Promotions")]
            [Validation(Required=false)]
            public List<DescribeCloudPhoneNodePriceResponseBodyPricePromotions> Promotions { get; set; }
            public class DescribeCloudPhoneNodePriceResponseBodyPricePromotions : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>daily</para>
                /// </summary>
                [NameInMap("OptionCode")]
                [Validation(Required=false)]
                public string OptionCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>日常优惠</para>
                /// </summary>
                [NameInMap("PromotionDesc")]
                [Validation(Required=false)]
                public string PromotionDesc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>82842468****</para>
                /// </summary>
                [NameInMap("PromotionId")]
                [Validation(Required=false)]
                public string PromotionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>日常优惠</para>
                /// </summary>
                [NameInMap("PromotionName")]
                [Validation(Required=false)]
                public string PromotionName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("selected")]
                [Validation(Required=false)]
                public bool? Selected { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>99.0</para>
            /// </summary>
            [NameInMap("TradePrice")]
            [Validation(Required=false)]
            public float? TradePrice { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>425F351C-3F8E-5218-A520-B6311D0D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<DescribeCloudPhoneNodePriceResponseBodyRules> Rules { get; set; }
        public class DescribeCloudPhoneNodePriceResponseBodyRules : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>日常优惠</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>t1uf7xt141ut5i****</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

        }

    }

}
