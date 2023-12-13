// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class DescribeContainerGroupPriceResponseBody : TeaModel {
        /// <summary>
        /// The information about the prices and discount rules.
        /// </summary>
        [NameInMap("PriceInfo")]
        [Validation(Required=false)]
        public DescribeContainerGroupPriceResponseBodyPriceInfo PriceInfo { get; set; }
        public class DescribeContainerGroupPriceResponseBodyPriceInfo : TeaModel {
            /// <summary>
            /// The price.
            /// </summary>
            [NameInMap("Price")]
            [Validation(Required=false)]
            public DescribeContainerGroupPriceResponseBodyPriceInfoPrice Price { get; set; }
            public class DescribeContainerGroupPriceResponseBodyPriceInfoPrice : TeaModel {
                /// <summary>
                /// The currency unit. Valid values:
                /// 
                /// *   CNY: This value only applies to the China site (aliyun.com).
                /// *   USD: This value only applies to the International site (alibabacloud.com).
                /// </summary>
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                /// <summary>
                /// The information about the price.
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
                        /// The discount.
                        /// </summary>
                        [NameInMap("DiscountPrice")]
                        [Validation(Required=false)]
                        public float? DiscountPrice { get; set; }

                        /// <summary>
                        /// The original price.
                        /// </summary>
                        [NameInMap("OriginalPrice")]
                        [Validation(Required=false)]
                        public float? OriginalPrice { get; set; }

                        /// <summary>
                        /// The name of the resource.
                        /// </summary>
                        [NameInMap("Resource")]
                        [Validation(Required=false)]
                        public string Resource { get; set; }

                        /// <summary>
                        /// Details about the pricing rules.
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
                                /// The description of the rule.
                                /// </summary>
                                [NameInMap("Description")]
                                [Validation(Required=false)]
                                public string Description { get; set; }

                                /// <summary>
                                /// The rule ID.
                                /// </summary>
                                [NameInMap("RuleId")]
                                [Validation(Required=false)]
                                public long? RuleId { get; set; }

                            }

                        }

                        /// <summary>
                        /// The transaction price.
                        /// </summary>
                        [NameInMap("TradePrice")]
                        [Validation(Required=false)]
                        public float? TradePrice { get; set; }

                    }

                }

                /// <summary>
                /// The discount.
                /// </summary>
                [NameInMap("DiscountPrice")]
                [Validation(Required=false)]
                public float? DiscountPrice { get; set; }

                /// <summary>
                /// The original price.
                /// </summary>
                [NameInMap("OriginalPrice")]
                [Validation(Required=false)]
                public float? OriginalPrice { get; set; }

                /// <summary>
                /// The transaction price, which is equal to the original price minus the discount.
                /// </summary>
                [NameInMap("TradePrice")]
                [Validation(Required=false)]
                public float? TradePrice { get; set; }

            }

            /// <summary>
            /// Details about the promotion rules.
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
                    /// The description of the promotion rule.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The ID of the promotion rule.
                    /// </summary>
                    [NameInMap("RuleId")]
                    [Validation(Required=false)]
                    public long? RuleId { get; set; }

                }

            }

            /// <summary>
            /// The information about the prices of preemptible elastic container instances.
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
                    /// The ECS instance type.
                    /// </summary>
                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                    /// <summary>
                    /// The original price.
                    /// </summary>
                    [NameInMap("OriginPrice")]
                    [Validation(Required=false)]
                    public float? OriginPrice { get; set; }

                    /// <summary>
                    /// The prices of preemptible elastic container instances.
                    /// </summary>
                    [NameInMap("SpotPrice")]
                    [Validation(Required=false)]
                    public float? SpotPrice { get; set; }

                    /// <summary>
                    /// The zone ID of the instance.
                    /// </summary>
                    [NameInMap("ZoneId")]
                    [Validation(Required=false)]
                    public string ZoneId { get; set; }

                }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
