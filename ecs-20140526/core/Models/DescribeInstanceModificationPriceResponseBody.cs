// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceModificationPriceResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the prices and promotion rules.</para>
        /// </summary>
        [NameInMap("PriceInfo")]
        [Validation(Required=false)]
        public DescribeInstanceModificationPriceResponseBodyPriceInfo PriceInfo { get; set; }
        public class DescribeInstanceModificationPriceResponseBodyPriceInfo : TeaModel {
            /// <summary>
            /// <para>The price.</para>
            /// </summary>
            [NameInMap("Price")]
            [Validation(Required=false)]
            public DescribeInstanceModificationPriceResponseBodyPriceInfoPrice Price { get; set; }
            public class DescribeInstanceModificationPriceResponseBodyPriceInfoPrice : TeaModel {
                /// <summary>
                /// <para>The currency unit. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Alibaba Cloud China site (aliyun.com): CNY</description></item>
                /// <item><description>Alibaba Cloud International site (alibabacloud.com): USD</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CNY</para>
                /// </summary>
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                /// <summary>
                /// <para>The information about the price.</para>
                /// <remarks>
                /// <para> This parameter is returned only when ResourceType is set to instance.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("DetailInfos")]
                [Validation(Required=false)]
                public DescribeInstanceModificationPriceResponseBodyPriceInfoPriceDetailInfos DetailInfos { get; set; }
                public class DescribeInstanceModificationPriceResponseBodyPriceInfoPriceDetailInfos : TeaModel {
                    [NameInMap("DetailInfo")]
                    [Validation(Required=false)]
                    public List<DescribeInstanceModificationPriceResponseBodyPriceInfoPriceDetailInfosDetailInfo> DetailInfo { get; set; }
                    public class DescribeInstanceModificationPriceResponseBodyPriceInfoPriceDetailInfosDetailInfo : TeaModel {
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
                        /// <para>The resource name. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>InstanceType</description></item>
                        /// <item><description>bandwidth</description></item>
                        /// <item><description>image</description></item>
                        /// <item><description>SystemDisk</description></item>
                        /// <item><description>DataDisk</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>instanceType</para>
                        /// </summary>
                        [NameInMap("Resource")]
                        [Validation(Required=false)]
                        public string Resource { get; set; }

                        /// <summary>
                        /// <para>The pricing rules.</para>
                        /// </summary>
                        [NameInMap("SubRules")]
                        [Validation(Required=false)]
                        public DescribeInstanceModificationPriceResponseBodyPriceInfoPriceDetailInfosDetailInfoSubRules SubRules { get; set; }
                        public class DescribeInstanceModificationPriceResponseBodyPriceInfoPriceDetailInfosDetailInfoSubRules : TeaModel {
                            [NameInMap("Rule")]
                            [Validation(Required=false)]
                            public List<DescribeInstanceModificationPriceResponseBodyPriceInfoPriceDetailInfosDetailInfoSubRulesRule> Rule { get; set; }
                            public class DescribeInstanceModificationPriceResponseBodyPriceInfoPriceDetailInfosDetailInfoSubRulesRule : TeaModel {
                                /// <summary>
                                /// <para>The description of the pricing rule.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>If you subscribe to an instance for one year, you can receive a 15% discount off the list price.</para>
                                /// </summary>
                                [NameInMap("Description")]
                                [Validation(Required=false)]
                                public string Description { get; set; }

                                /// <summary>
                                /// <para>The ID of the pricing rule.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>315716429631488</para>
                                /// </summary>
                                [NameInMap("RuleId")]
                                [Validation(Required=false)]
                                public long? RuleId { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The transaction price.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3712.8</para>
                        /// </summary>
                        [NameInMap("TradePrice")]
                        [Validation(Required=false)]
                        public float? TradePrice { get; set; }

                    }

                }

                /// <summary>
                /// <para>The discount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>61.320</para>
                /// </summary>
                [NameInMap("DiscountPrice")]
                [Validation(Required=false)]
                public float? DiscountPrice { get; set; }

                /// <summary>
                /// <para>The original price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>175.200</para>
                /// </summary>
                [NameInMap("OriginalPrice")]
                [Validation(Required=false)]
                public float? OriginalPrice { get; set; }

                /// <summary>
                /// <para>The transaction price, which is equal to the original price minus the discount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>113.880</para>
                /// </summary>
                [NameInMap("TradePrice")]
                [Validation(Required=false)]
                public float? TradePrice { get; set; }

            }

            /// <summary>
            /// <para>The information about the promotion rules.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public DescribeInstanceModificationPriceResponseBodyPriceInfoRules Rules { get; set; }
            public class DescribeInstanceModificationPriceResponseBodyPriceInfoRules : TeaModel {
                [NameInMap("Rule")]
                [Validation(Required=false)]
                public List<DescribeInstanceModificationPriceResponseBodyPriceInfoRulesRule> Rule { get; set; }
                public class DescribeInstanceModificationPriceResponseBodyPriceInfoRulesRule : TeaModel {
                    /// <summary>
                    /// <para>The description of the promotion rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Upgrade offers</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The ID of the promotion rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1234567890</para>
                    /// </summary>
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
        /// <para>A3DC3196-379B-4F32-A2C5-B937134FAD8A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
