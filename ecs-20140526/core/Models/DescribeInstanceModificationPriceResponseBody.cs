// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceModificationPriceResponseBody : TeaModel {
        /// <summary>
        /// $.parameters[4].schema.enumValueTitles
        /// </summary>
        [NameInMap("PriceInfo")]
        [Validation(Required=false)]
        public DescribeInstanceModificationPriceResponseBodyPriceInfo PriceInfo { get; set; }
        public class DescribeInstanceModificationPriceResponseBodyPriceInfo : TeaModel {
            /// <summary>
            /// Queries the pricing information about newly attached subscription data disks or about the new instance types when you upgrade the configurations of unexpired subscription Elastic Compute Service (ECS) instances.
            /// </summary>
            [NameInMap("Price")]
            [Validation(Required=false)]
            public DescribeInstanceModificationPriceResponseBodyPriceInfoPrice Price { get; set; }
            public class DescribeInstanceModificationPriceResponseBodyPriceInfoPrice : TeaModel {
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                /// <summary>
                /// WB01405484
                /// </summary>
                [NameInMap("DiscountPrice")]
                [Validation(Required=false)]
                public float? DiscountPrice { get; set; }

                /// <summary>
                /// DescribeInstanceModificationPrice
                /// </summary>
                [NameInMap("OriginalPrice")]
                [Validation(Required=false)]
                public float? OriginalPrice { get; set; }

                [NameInMap("TradePrice")]
                [Validation(Required=false)]
                public float? TradePrice { get; set; }

            }

            /// <summary>
            /// $.parameters[5].schema.description
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
                    /// $.parameters[5].schema.example
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// $.parameters[5].schema.enumValueTitles
                    /// </summary>
                    [NameInMap("RuleId")]
                    [Validation(Required=false)]
                    public long? RuleId { get; set; }

                }

            }

        }

        /// <summary>
        /// $.parameters[4].schema.example
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
