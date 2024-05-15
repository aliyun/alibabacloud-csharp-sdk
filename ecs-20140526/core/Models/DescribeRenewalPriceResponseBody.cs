// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeRenewalPriceResponseBody : TeaModel {
        /// <summary>
        /// Details about the prices and promotion rules.
        /// </summary>
        [NameInMap("PriceInfo")]
        [Validation(Required=false)]
        public DescribeRenewalPriceResponseBodyPriceInfo PriceInfo { get; set; }
        public class DescribeRenewalPriceResponseBodyPriceInfo : TeaModel {
            /// <summary>
            /// The price.
            /// </summary>
            [NameInMap("Price")]
            [Validation(Required=false)]
            public DescribeRenewalPriceResponseBodyPriceInfoPrice Price { get; set; }
            public class DescribeRenewalPriceResponseBodyPriceInfoPrice : TeaModel {
                /// <summary>
                /// The currency unit.
                /// 
                /// Alibaba Cloud China site (aliyun.com): CNY.
                /// 
                /// Alibaba Cloud International site (alibabacloud.com): USD.
                /// </summary>
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                /// <summary>
                /// Details about the resource prices.
                /// </summary>
                [NameInMap("DetailInfos")]
                [Validation(Required=false)]
                public DescribeRenewalPriceResponseBodyPriceInfoPriceDetailInfos DetailInfos { get; set; }
                public class DescribeRenewalPriceResponseBodyPriceInfoPriceDetailInfos : TeaModel {
                    [NameInMap("ResourcePriceModel")]
                    [Validation(Required=false)]
                    public List<DescribeRenewalPriceResponseBodyPriceInfoPriceDetailInfosResourcePriceModel> ResourcePriceModel { get; set; }
                    public class DescribeRenewalPriceResponseBodyPriceInfoPriceDetailInfosResourcePriceModel : TeaModel {
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
                        /// The name of the resource that corresponds to the price.
                        /// </summary>
                        [NameInMap("Resource")]
                        [Validation(Required=false)]
                        public string Resource { get; set; }

                        /// <summary>
                        /// The pricing rules.
                        /// </summary>
                        [NameInMap("SubRules")]
                        [Validation(Required=false)]
                        public DescribeRenewalPriceResponseBodyPriceInfoPriceDetailInfosResourcePriceModelSubRules SubRules { get; set; }
                        public class DescribeRenewalPriceResponseBodyPriceInfoPriceDetailInfosResourcePriceModelSubRules : TeaModel {
                            [NameInMap("Rule")]
                            [Validation(Required=false)]
                            public List<DescribeRenewalPriceResponseBodyPriceInfoPriceDetailInfosResourcePriceModelSubRulesRule> Rule { get; set; }
                            public class DescribeRenewalPriceResponseBodyPriceInfoPriceDetailInfosResourcePriceModelSubRulesRule : TeaModel {
                                /// <summary>
                                /// The description of the pricing rule.
                                /// </summary>
                                [NameInMap("Description")]
                                [Validation(Required=false)]
                                public string Description { get; set; }

                                /// <summary>
                                /// The ID of the pricing rule.
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
            public DescribeRenewalPriceResponseBodyPriceInfoRules Rules { get; set; }
            public class DescribeRenewalPriceResponseBodyPriceInfoRules : TeaModel {
                [NameInMap("Rule")]
                [Validation(Required=false)]
                public List<DescribeRenewalPriceResponseBodyPriceInfoRulesRule> Rule { get; set; }
                public class DescribeRenewalPriceResponseBodyPriceInfoRulesRule : TeaModel {
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

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
