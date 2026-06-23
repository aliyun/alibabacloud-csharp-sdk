// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeRatePlanPriceGapResponseBody : TeaModel {
        /// <summary>
        /// <para>The price information.</para>
        /// </summary>
        [NameInMap("PriceModel")]
        [Validation(Required=false)]
        public DescribeRatePlanPriceGapResponseBodyPriceModel PriceModel { get; set; }
        public class DescribeRatePlanPriceGapResponseBodyPriceModel : TeaModel {
            /// <summary>
            /// <para>The currency. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>JPY: Japanese Yen.</description></item>
            /// <item><description>USD: US Dollar.</description></item>
            /// <item><description>CNY: Chinese Yuan.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CNY</para>
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// <para>The order discount amount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DiscountPrice")]
            [Validation(Required=false)]
            public float? DiscountPrice { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xcdn-91fknmb80f0g</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The final order price, which is the actual transaction price.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Price")]
            [Validation(Required=false)]
            public float? Price { get; set; }

            [NameInMap("Rule")]
            [Validation(Required=false)]
            public DescribeRatePlanPriceGapResponseBodyPriceModelRule Rule { get; set; }
            public class DescribeRatePlanPriceGapResponseBodyPriceModelRule : TeaModel {
                [NameInMap("RuleList")]
                [Validation(Required=false)]
                public List<DescribeRatePlanPriceGapResponseBodyPriceModelRuleRuleList> RuleList { get; set; }
                public class DescribeRatePlanPriceGapResponseBodyPriceModelRuleRuleList : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("RuleDescId")]
                    [Validation(Required=false)]
                    public long? RuleDescId { get; set; }

                }

            }

            /// <summary>
            /// <para>The target plan code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>entranceplan</para>
            /// </summary>
            [NameInMap("TargetPlanCode")]
            [Validation(Required=false)]
            public string TargetPlanCode { get; set; }

            /// <summary>
            /// <para>The original order price. Original order price = actual transaction price + discount amount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TotalPrice")]
            [Validation(Required=false)]
            public float? TotalPrice { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40423A7F-A83D-1E24-B80E-86DD25790759</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
