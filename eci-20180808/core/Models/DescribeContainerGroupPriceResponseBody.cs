// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class DescribeContainerGroupPriceResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the prices and discount rules.</para>
        /// </summary>
        [NameInMap("PriceInfo")]
        [Validation(Required=false)]
        public DescribeContainerGroupPriceResponseBodyPriceInfo PriceInfo { get; set; }
        public class DescribeContainerGroupPriceResponseBodyPriceInfo : TeaModel {
            /// <summary>
            /// <para>The price.</para>
            /// </summary>
            [NameInMap("Price")]
            [Validation(Required=false)]
            public DescribeContainerGroupPriceResponseBodyPriceInfoPrice Price { get; set; }
            public class DescribeContainerGroupPriceResponseBodyPriceInfoPrice : TeaModel {
                /// <summary>
                /// <para>The currency unit. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>CNY: This value only applies to the China site (aliyun.com).</description></item>
                /// <item><description>USD: This value only applies to the International site (alibabacloud.com).</description></item>
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
                /// </summary>
                [NameInMap("DetailInfos")]
                [Validation(Required=false)]
                public DescribeContainerGroupPriceResponseBodyPriceInfoPriceDetailInfos DetailInfos { get; set; }
                public class DescribeContainerGroupPriceResponseBodyPriceInfoPriceDetailInfos : TeaModel {
                    [NameInMap("DetailInfo")]
                    [Validation(Required=false)]
                    public List<DescribeContainerGroupPriceResponseBodyPriceInfoPriceDetailInfosDetailInfo> DetailInfo { get; set; }
                    public class DescribeContainerGroupPriceResponseBodyPriceInfoPriceDetailInfosDetailInfo : TeaModel {
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
                        /// <para>0.000098</para>
                        /// </summary>
                        [NameInMap("OriginalPrice")]
                        [Validation(Required=false)]
                        public float? OriginalPrice { get; set; }

                        /// <summary>
                        /// <para>The name of the resource.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cpu</para>
                        /// </summary>
                        [NameInMap("Resource")]
                        [Validation(Required=false)]
                        public string Resource { get; set; }

                        /// <summary>
                        /// <para>Details about the pricing rules.</para>
                        /// </summary>
                        [NameInMap("Rules")]
                        [Validation(Required=false)]
                        public DescribeContainerGroupPriceResponseBodyPriceInfoPriceDetailInfosDetailInfoRules Rules { get; set; }
                        public class DescribeContainerGroupPriceResponseBodyPriceInfoPriceDetailInfosDetailInfoRules : TeaModel {
                            [NameInMap("Rule")]
                            [Validation(Required=false)]
                            public List<DescribeContainerGroupPriceResponseBodyPriceInfoPriceDetailInfosDetailInfoRulesRule> Rule { get; set; }
                            public class DescribeContainerGroupPriceResponseBodyPriceInfoPriceDetailInfosDetailInfoRulesRule : TeaModel {
                                /// <summary>
                                /// <para>The description of the rule.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>Receive a 15% discount on a 1-year subscription</para>
                                /// </summary>
                                [NameInMap("Description")]
                                [Validation(Required=false)]
                                public string Description { get; set; }

                                /// <summary>
                                /// <para>The rule ID.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>123456</para>
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
                        /// <para>0.000098</para>
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
                /// <para>0</para>
                /// </summary>
                [NameInMap("DiscountPrice")]
                [Validation(Required=false)]
                public float? DiscountPrice { get; set; }

                /// <summary>
                /// <para>The original price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.00012252</para>
                /// </summary>
                [NameInMap("OriginalPrice")]
                [Validation(Required=false)]
                public float? OriginalPrice { get; set; }

                /// <summary>
                /// <para>The transaction price, which is equal to the original price minus the discount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.00012252</para>
                /// </summary>
                [NameInMap("TradePrice")]
                [Validation(Required=false)]
                public float? TradePrice { get; set; }

            }

            /// <summary>
            /// <para>Details about the promotion rules.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public DescribeContainerGroupPriceResponseBodyPriceInfoRules Rules { get; set; }
            public class DescribeContainerGroupPriceResponseBodyPriceInfoRules : TeaModel {
                [NameInMap("Rule")]
                [Validation(Required=false)]
                public List<DescribeContainerGroupPriceResponseBodyPriceInfoRulesRule> Rule { get; set; }
                public class DescribeContainerGroupPriceResponseBodyPriceInfoRulesRule : TeaModel {
                    /// <summary>
                    /// <para>The description of the promotion rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Receive a 15% discount on a 1-year subscription</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The ID of the promotion rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123456</para>
                    /// </summary>
                    [NameInMap("RuleId")]
                    [Validation(Required=false)]
                    public long? RuleId { get; set; }

                }

            }

            /// <summary>
            /// <para>The information about the prices of preemptible elastic container instances.</para>
            /// </summary>
            [NameInMap("SpotPrices")]
            [Validation(Required=false)]
            public DescribeContainerGroupPriceResponseBodyPriceInfoSpotPrices SpotPrices { get; set; }
            public class DescribeContainerGroupPriceResponseBodyPriceInfoSpotPrices : TeaModel {
                [NameInMap("SpotPrice")]
                [Validation(Required=false)]
                public List<DescribeContainerGroupPriceResponseBodyPriceInfoSpotPricesSpotPrice> SpotPrice { get; set; }
                public class DescribeContainerGroupPriceResponseBodyPriceInfoSpotPricesSpotPrice : TeaModel {
                    /// <summary>
                    /// <para>The ECS instance type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ecs.c5.large</para>
                    /// </summary>
                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                    /// <summary>
                    /// <para>The original price.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.622</para>
                    /// </summary>
                    [NameInMap("OriginPrice")]
                    [Validation(Required=false)]
                    public float? OriginPrice { get; set; }

                    /// <summary>
                    /// <para>The prices of preemptible elastic container instances.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.056</para>
                    /// </summary>
                    [NameInMap("SpotPrice")]
                    [Validation(Required=false)]
                    public float? SpotPrice { get; set; }

                    /// <summary>
                    /// <para>The zone ID of the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou-i</para>
                    /// </summary>
                    [NameInMap("ZoneId")]
                    [Validation(Required=false)]
                    public string ZoneId { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7A872585-33C7-4D69-AB8E-412E81EBA387</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
