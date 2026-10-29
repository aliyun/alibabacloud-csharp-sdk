// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeCloudPhoneNodeRenewPriceResponseBody : TeaModel {
        /// <summary>
        /// <para>The price.</para>
        /// </summary>
        [NameInMap("Price")]
        [Validation(Required=false)]
        public DescribeCloudPhoneNodeRenewPriceResponseBodyPrice Price { get; set; }
        public class DescribeCloudPhoneNodeRenewPriceResponseBodyPrice : TeaModel {
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
            /// <para>274.75</para>
            /// </summary>
            [NameInMap("DiscountPrice")]
            [Validation(Required=false)]
            public float? DiscountPrice { get; set; }

            /// <summary>
            /// <para>The original price.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1860</para>
            /// </summary>
            [NameInMap("OriginalPrice")]
            [Validation(Required=false)]
            public float? OriginalPrice { get; set; }

            /// <summary>
            /// <para>The price details.</para>
            /// </summary>
            [NameInMap("PriceDetail")]
            [Validation(Required=false)]
            public List<DescribeCloudPhoneNodeRenewPriceResponseBodyPricePriceDetail> PriceDetail { get; set; }
            public class DescribeCloudPhoneNodeRenewPriceResponseBodyPricePriceDetail : TeaModel {
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
                /// <para>The matrix ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cpn-9rz9ou1l0wq30****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The price of each module.</para>
                /// </summary>
                [NameInMap("ModulePrice")]
                [Validation(Required=false)]
                public List<DescribeCloudPhoneNodeRenewPriceResponseBodyPricePriceDetailModulePrice> ModulePrice { get; set; }
                public class DescribeCloudPhoneNodeRenewPriceResponseBodyPricePriceDetailModulePrice : TeaModel {
                    /// <summary>
                    /// <para>The discounted price.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>878.15</para>
                    /// </summary>
                    [NameInMap("DiscountPrice")]
                    [Validation(Required=false)]
                    public string DiscountPrice { get; set; }

                    /// <summary>
                    /// <para>The name of the module.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PhoneData</para>
                    /// </summary>
                    [NameInMap("ModuleName")]
                    [Validation(Required=false)]
                    public string ModuleName { get; set; }

                    /// <summary>
                    /// <para>The original price.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1090</para>
                    /// </summary>
                    [NameInMap("OriginalPrice")]
                    [Validation(Required=false)]
                    public string OriginalPrice { get; set; }

                    /// <summary>
                    /// <para>The transaction price.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>73.87</para>
                    /// </summary>
                    [NameInMap("TradePrice")]
                    [Validation(Required=false)]
                    public string TradePrice { get; set; }

                }

                /// <summary>
                /// <para>The original price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2087.0</para>
                /// </summary>
                [NameInMap("OriginalPrice")]
                [Validation(Required=false)]
                public float? OriginalPrice { get; set; }

                /// <summary>
                /// <para>The resource type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CloudPhoneMatrix</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <para>The transaction price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1099.0</para>
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
            public List<DescribeCloudPhoneNodeRenewPriceResponseBodyPricePromotions> Promotions { get; set; }
            public class DescribeCloudPhoneNodeRenewPriceResponseBodyPricePromotions : TeaModel {
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
                /// <para>Daily promotion</para>
                /// </summary>
                [NameInMap("PromotionDesc")]
                [Validation(Required=false)]
                public string PromotionDesc { get; set; }

                /// <summary>
                /// <para>The promotion ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>91381816****</para>
                /// </summary>
                [NameInMap("PromotionId")]
                [Validation(Required=false)]
                public string PromotionId { get; set; }

                /// <summary>
                /// <para>The promotion name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Daily promotion</para>
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
                [NameInMap("selected")]
                [Validation(Required=false)]
                public bool? Selected { get; set; }

            }

            /// <summary>
            /// <para>The transaction price.</para>
            /// 
            /// <b>Example:</b>
            /// <para>769.3</para>
            /// </summary>
            [NameInMap("TradePrice")]
            [Validation(Required=false)]
            public float? TradePrice { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>1A923337-44D9-5CAD-9A53-95084BD4****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The promotion rules.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<DescribeCloudPhoneNodeRenewPriceResponseBodyRules> Rules { get; set; }
        public class DescribeCloudPhoneNodeRenewPriceResponseBodyRules : TeaModel {
            /// <summary>
            /// <para>The description of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20 off for orders over 40</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023110611****</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

        }

    }

}
