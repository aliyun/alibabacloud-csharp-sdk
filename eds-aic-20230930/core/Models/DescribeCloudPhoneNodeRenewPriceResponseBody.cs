// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeCloudPhoneNodeRenewPriceResponseBody : TeaModel {
        [NameInMap("Price")]
        [Validation(Required=false)]
        public DescribeCloudPhoneNodeRenewPriceResponseBodyPrice Price { get; set; }
        public class DescribeCloudPhoneNodeRenewPriceResponseBodyPrice : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>CNY</para>
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>274.75</para>
            /// </summary>
            [NameInMap("DiscountPrice")]
            [Validation(Required=false)]
            public float? DiscountPrice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1860</para>
            /// </summary>
            [NameInMap("OriginalPrice")]
            [Validation(Required=false)]
            public float? OriginalPrice { get; set; }

            [NameInMap("PriceDetail")]
            [Validation(Required=false)]
            public List<DescribeCloudPhoneNodeRenewPriceResponseBodyPricePriceDetail> PriceDetail { get; set; }
            public class DescribeCloudPhoneNodeRenewPriceResponseBodyPricePriceDetail : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>274.75</para>
                /// </summary>
                [NameInMap("DiscountPrice")]
                [Validation(Required=false)]
                public float? DiscountPrice { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cpn-9rz9ou1l0wq30****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("ModulePrice")]
                [Validation(Required=false)]
                public List<DescribeCloudPhoneNodeRenewPriceResponseBodyPricePriceDetailModulePrice> ModulePrice { get; set; }
                public class DescribeCloudPhoneNodeRenewPriceResponseBodyPricePriceDetailModulePrice : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>878.15</para>
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
                    /// <para>1090</para>
                    /// </summary>
                    [NameInMap("OriginalPrice")]
                    [Validation(Required=false)]
                    public string OriginalPrice { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>73.87</para>
                    /// </summary>
                    [NameInMap("TradePrice")]
                    [Validation(Required=false)]
                    public string TradePrice { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2087.0</para>
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
                /// <para>1099.0</para>
                /// </summary>
                [NameInMap("TradePrice")]
                [Validation(Required=false)]
                public float? TradePrice { get; set; }

            }

            [NameInMap("Promotions")]
            [Validation(Required=false)]
            public List<DescribeCloudPhoneNodeRenewPriceResponseBodyPricePromotions> Promotions { get; set; }
            public class DescribeCloudPhoneNodeRenewPriceResponseBodyPricePromotions : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>youhui_quan</para>
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
                /// <para>91381816****</para>
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
            /// <para>769.3</para>
            /// </summary>
            [NameInMap("TradePrice")]
            [Validation(Required=false)]
            public float? TradePrice { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1A923337-44D9-5CAD-9A53-95084BD4****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<DescribeCloudPhoneNodeRenewPriceResponseBodyRules> Rules { get; set; }
        public class DescribeCloudPhoneNodeRenewPriceResponseBodyRules : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>满40减20</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023110611****</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

        }

    }

}
