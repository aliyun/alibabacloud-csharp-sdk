// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeRenewalPriceResponseBody : TeaModel {
        /// <summary>
        /// <para>The price information, including the price and discount rule details.</para>
        /// </summary>
        [NameInMap("PriceInfo")]
        [Validation(Required=false)]
        public DescribeRenewalPriceResponseBodyPriceInfo PriceInfo { get; set; }
        public class DescribeRenewalPriceResponseBodyPriceInfo : TeaModel {
            /// <summary>
            /// <para>The price.</para>
            /// </summary>
            [NameInMap("Price")]
            [Validation(Required=false)]
            public DescribeRenewalPriceResponseBodyPriceInfoPrice Price { get; set; }
            public class DescribeRenewalPriceResponseBodyPriceInfoPrice : TeaModel {
                /// <summary>
                /// <para>The currency unit.</para>
                /// <para>China site: CNY.</para>
                /// <para>International site: USD.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CNY</para>
                /// </summary>
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                [NameInMap("DetailInfos")]
                [Validation(Required=false)]
                public DescribeRenewalPriceResponseBodyPriceInfoPriceDetailInfos DetailInfos { get; set; }
                public class DescribeRenewalPriceResponseBodyPriceInfoPriceDetailInfos : TeaModel {
                    [NameInMap("DetailInfo")]
                    [Validation(Required=false)]
                    public List<DescribeRenewalPriceResponseBodyPriceInfoPriceDetailInfosDetailInfo> DetailInfo { get; set; }
                    public class DescribeRenewalPriceResponseBodyPriceInfoPriceDetailInfosDetailInfo : TeaModel {
                        [NameInMap("DiscountPrice")]
                        [Validation(Required=false)]
                        public float? DiscountPrice { get; set; }

                        [NameInMap("OriginalPrice")]
                        [Validation(Required=false)]
                        public float? OriginalPrice { get; set; }

                        [NameInMap("Resource")]
                        [Validation(Required=false)]
                        public string Resource { get; set; }

                        [NameInMap("SubRules")]
                        [Validation(Required=false)]
                        public DescribeRenewalPriceResponseBodyPriceInfoPriceDetailInfosDetailInfoSubRules SubRules { get; set; }
                        public class DescribeRenewalPriceResponseBodyPriceInfoPriceDetailInfosDetailInfoSubRules : TeaModel {
                            [NameInMap("Rule")]
                            [Validation(Required=false)]
                            public List<DescribeRenewalPriceResponseBodyPriceInfoPriceDetailInfosDetailInfoSubRulesRule> Rule { get; set; }
                            public class DescribeRenewalPriceResponseBodyPriceInfoPriceDetailInfosDetailInfoSubRulesRule : TeaModel {
                                [NameInMap("Description")]
                                [Validation(Required=false)]
                                public string Description { get; set; }

                                [NameInMap("RuleId")]
                                [Validation(Required=false)]
                                public long? RuleId { get; set; }

                            }

                        }

                        [NameInMap("TradePrice")]
                        [Validation(Required=false)]
                        public float? TradePrice { get; set; }

                    }

                }

                /// <summary>
                /// <para>The discount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>655.2</para>
                /// </summary>
                [NameInMap("DiscountPrice")]
                [Validation(Required=false)]
                public float? DiscountPrice { get; set; }

                /// <summary>
                /// <para>The original price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4368</para>
                /// </summary>
                [NameInMap("OriginalPrice")]
                [Validation(Required=false)]
                public float? OriginalPrice { get; set; }

                /// <summary>
                /// <para>The transaction price, which is equal to the original price minus the discount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3712.8</para>
                /// </summary>
                [NameInMap("TradePrice")]
                [Validation(Required=false)]
                public float? TradePrice { get; set; }

            }

            [NameInMap("RelatedPrice")]
            [Validation(Required=false)]
            public DescribeRenewalPriceResponseBodyPriceInfoRelatedPrice RelatedPrice { get; set; }
            public class DescribeRenewalPriceResponseBodyPriceInfoRelatedPrice : TeaModel {
                [NameInMap("MarketplaceImagePrice")]
                [Validation(Required=false)]
                public DescribeRenewalPriceResponseBodyPriceInfoRelatedPriceMarketplaceImagePrice MarketplaceImagePrice { get; set; }
                public class DescribeRenewalPriceResponseBodyPriceInfoRelatedPriceMarketplaceImagePrice : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>CNY</para>
                    /// </summary>
                    [NameInMap("Currency")]
                    [Validation(Required=false)]
                    public string Currency { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("DiscountPrice")]
                    [Validation(Required=false)]
                    public float? DiscountPrice { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("OriginalPrice")]
                    [Validation(Required=false)]
                    public float? OriginalPrice { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("TradePrice")]
                    [Validation(Required=false)]
                    public float? TradePrice { get; set; }

                }

            }

            [NameInMap("Rules")]
            [Validation(Required=false)]
            public DescribeRenewalPriceResponseBodyPriceInfoRules Rules { get; set; }
            public class DescribeRenewalPriceResponseBodyPriceInfoRules : TeaModel {
                [NameInMap("Rule")]
                [Validation(Required=false)]
                public List<DescribeRenewalPriceResponseBodyPriceInfoRulesRule> Rule { get; set; }
                public class DescribeRenewalPriceResponseBodyPriceInfoRulesRule : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("RuleId")]
                    [Validation(Required=false)]
                    public long? RuleId { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
