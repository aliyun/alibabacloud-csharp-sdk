// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribePriceResponseBody : TeaModel {
        /// <summary>
        /// Details about the prices and promotion rules.
        /// </summary>
        [NameInMap("PriceInfo")]
        [Validation(Required=false)]
        public DescribePriceResponseBodyPriceInfo PriceInfo { get; set; }
        public class DescribePriceResponseBodyPriceInfo : TeaModel {
            /// <summary>
            /// The price.
            /// </summary>
            [NameInMap("Price")]
            [Validation(Required=false)]
            public DescribePriceResponseBodyPriceInfoPrice Price { get; set; }
            public class DescribePriceResponseBodyPriceInfoPrice : TeaModel {
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
                /// Details about the price.
                /// 
                /// > This parameter is in invitational preview and is unavailable for public use.
                /// </summary>
                [NameInMap("DetailInfos")]
                [Validation(Required=false)]
                public DescribePriceResponseBodyPriceInfoPriceDetailInfos DetailInfos { get; set; }
                public class DescribePriceResponseBodyPriceInfoPriceDetailInfos : TeaModel {
                    [NameInMap("ResourcePriceModel")]
                    [Validation(Required=false)]
                    public List<DescribePriceResponseBodyPriceInfoPriceDetailInfosResourcePriceModel> ResourcePriceModel { get; set; }
                    public class DescribePriceResponseBodyPriceInfoPriceDetailInfosResourcePriceModel : TeaModel {
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
                        /// The resource name.
                        /// </summary>
                        [NameInMap("Resource")]
                        [Validation(Required=false)]
                        public string Resource { get; set; }

                        /// <summary>
                        /// Details about the pricing rules.
                        /// </summary>
                        [NameInMap("SubRules")]
                        [Validation(Required=false)]
                        public DescribePriceResponseBodyPriceInfoPriceDetailInfosResourcePriceModelSubRules SubRules { get; set; }
                        public class DescribePriceResponseBodyPriceInfoPriceDetailInfosResourcePriceModelSubRules : TeaModel {
                            [NameInMap("Rule")]
                            [Validation(Required=false)]
                            public List<DescribePriceResponseBodyPriceInfoPriceDetailInfosResourcePriceModelSubRulesRule> Rule { get; set; }
                            public class DescribePriceResponseBodyPriceInfoPriceDetailInfosResourcePriceModelSubRulesRule : TeaModel {
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
                /// The hourly price of the reserved instance for which the No Upfront or Partial Upfront payment option is used.
                /// </summary>
                [NameInMap("ReservedInstanceHourPrice")]
                [Validation(Required=false)]
                public float? ReservedInstanceHourPrice { get; set; }

                /// <summary>
                /// The transaction price of the order. The transaction price is equal to the original price minus the discount.
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
            public DescribePriceResponseBodyPriceInfoRules Rules { get; set; }
            public class DescribePriceResponseBodyPriceInfoRules : TeaModel {
                [NameInMap("Rule")]
                [Validation(Required=false)]
                public List<DescribePriceResponseBodyPriceInfoRulesRule> Rule { get; set; }
                public class DescribePriceResponseBodyPriceInfoRulesRule : TeaModel {
                    /// <summary>
                    /// The description of the promotion rule.
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

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
