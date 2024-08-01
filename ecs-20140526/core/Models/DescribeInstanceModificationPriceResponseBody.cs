// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceModificationPriceResponseBody : TeaModel {
        /// <summary>
        /// Details about the prices and promotion rules.
        /// </summary>
        [NameInMap("PriceInfo")]
        [Validation(Required=false)]
        public DescribeInstanceModificationPriceResponseBodyPriceInfo PriceInfo { get; set; }
        public class DescribeInstanceModificationPriceResponseBodyPriceInfo : TeaModel {
            /// <summary>
            /// The price.
            /// </summary>
            [NameInMap("Price")]
            [Validation(Required=false)]
            public DescribeInstanceModificationPriceResponseBodyPriceInfoPrice Price { get; set; }
            public class DescribeInstanceModificationPriceResponseBodyPriceInfoPrice : TeaModel {
                /// <summary>
                /// The currency unit.
                /// 
                /// Alibaba Cloud China site (aliyun.com): CNY
                /// 
                /// Alibaba Cloud International site (alibabacloud.com): USD
                /// </summary>
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

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
            /// The promotion rules.
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
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
