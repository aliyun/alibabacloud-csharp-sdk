// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribePriceResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the prices and promotion rules.</para>
        /// </summary>
        [NameInMap("PriceInfo")]
        [Validation(Required=false)]
        public DescribePriceResponseBodyPriceInfo PriceInfo { get; set; }
        public class DescribePriceResponseBodyPriceInfo : TeaModel {
            /// <summary>
            /// <para>The price.</para>
            /// </summary>
            [NameInMap("Price")]
            [Validation(Required=false)]
            public DescribePriceResponseBodyPriceInfoPrice Price { get; set; }
            public class DescribePriceResponseBodyPriceInfoPrice : TeaModel {
                /// <summary>
                /// <para>The currency unit.</para>
                /// <para>Alibaba Cloud China site (aliyun.com): CNY.</para>
                /// <para>Alibaba Cloud International site (alibabacloud.com): USD.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CNY</para>
                /// </summary>
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                [NameInMap("DetailInfos")]
                [Validation(Required=false)]
                public DescribePriceResponseBodyPriceInfoPriceDetailInfos DetailInfos { get; set; }
                public class DescribePriceResponseBodyPriceInfoPriceDetailInfos : TeaModel {
                    [NameInMap("DetailInfo")]
                    [Validation(Required=false)]
                    public List<DescribePriceResponseBodyPriceInfoPriceDetailInfosDetailInfo> DetailInfo { get; set; }
                    public class DescribePriceResponseBodyPriceInfoPriceDetailInfosDetailInfo : TeaModel {
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
                        public DescribePriceResponseBodyPriceInfoPriceDetailInfosDetailInfoSubRules SubRules { get; set; }
                        public class DescribePriceResponseBodyPriceInfoPriceDetailInfosDetailInfoSubRules : TeaModel {
                            [NameInMap("Rule")]
                            [Validation(Required=false)]
                            public List<DescribePriceResponseBodyPriceInfoPriceDetailInfosDetailInfoSubRulesRule> Rule { get; set; }
                            public class DescribePriceResponseBodyPriceInfoPriceDetailInfosDetailInfoSubRulesRule : TeaModel {
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
                /// <para>The hourly price of the reserved instance for which the No Upfront or Partial Upfront payment option is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ReservedInstanceHourPrice")]
                [Validation(Required=false)]
                public float? ReservedInstanceHourPrice { get; set; }

                /// <summary>
                /// <para>The transaction price of the order. The transaction price is equal to the original price minus the discount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3712.8</para>
                /// </summary>
                [NameInMap("TradePrice")]
                [Validation(Required=false)]
                public float? TradePrice { get; set; }

            }

            /// <summary>
            /// <para>The related price.</para>
            /// </summary>
            [NameInMap("RelatedPrice")]
            [Validation(Required=false)]
            public DescribePriceResponseBodyPriceInfoRelatedPrice RelatedPrice { get; set; }
            public class DescribePriceResponseBodyPriceInfoRelatedPrice : TeaModel {
                /// <summary>
                /// <para>The Alibaba Cloud Marketplace image price.</para>
                /// </summary>
                [NameInMap("MarketplaceImagePrice")]
                [Validation(Required=false)]
                public DescribePriceResponseBodyPriceInfoRelatedPriceMarketplaceImagePrice MarketplaceImagePrice { get; set; }
                public class DescribePriceResponseBodyPriceInfoRelatedPriceMarketplaceImagePrice : TeaModel {
                    /// <summary>
                    /// <para>The currency unit.</para>
                    /// <para>China site (aliyun.com): CNY</para>
                    /// <para>International site (alibabacloud.com): USD</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CNY</para>
                    /// </summary>
                    [NameInMap("Currency")]
                    [Validation(Required=false)]
                    public string Currency { get; set; }

                    /// <summary>
                    /// <para>The discount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("DiscountPrice")]
                    [Validation(Required=false)]
                    public float? DiscountPrice { get; set; }

                    /// <summary>
                    /// <para>The original price.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("OriginalPrice")]
                    [Validation(Required=false)]
                    public float? OriginalPrice { get; set; }

                    /// <summary>
                    /// <para>The transaction price, which is equal to the original price minus the discount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("TradePrice")]
                    [Validation(Required=false)]
                    public float? TradePrice { get; set; }

                }

            }

            [NameInMap("Rules")]
            [Validation(Required=false)]
            public DescribePriceResponseBodyPriceInfoRules Rules { get; set; }
            public class DescribePriceResponseBodyPriceInfoRules : TeaModel {
                [NameInMap("Rule")]
                [Validation(Required=false)]
                public List<DescribePriceResponseBodyPriceInfoRulesRule> Rule { get; set; }
                public class DescribePriceResponseBodyPriceInfoRulesRule : TeaModel {
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
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
