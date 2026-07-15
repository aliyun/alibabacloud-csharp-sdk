// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeCacheReservePriceGapResponseBody : TeaModel {
        /// <summary>
        /// <para>The pricing information.</para>
        /// </summary>
        [NameInMap("PriceModel")]
        [Validation(Required=false)]
        public DescribeCacheReservePriceGapResponseBodyPriceModel PriceModel { get; set; }
        public class DescribeCacheReservePriceGapResponseBodyPriceModel : TeaModel {
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
            /// <para>The discount amount of the order.</para>
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
            /// <para>esa-cr-9tuv*********</para>
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
            public DescribeCacheReservePriceGapResponseBodyPriceModelRule Rule { get; set; }
            public class DescribeCacheReservePriceGapResponseBodyPriceModelRule : TeaModel {
                [NameInMap("RuleList")]
                [Validation(Required=false)]
                public List<DescribeCacheReservePriceGapResponseBodyPriceModelRuleRuleList> RuleList { get; set; }
                public class DescribeCacheReservePriceGapResponseBodyPriceModelRuleRuleList : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("RuleDescId")]
                    [Validation(Required=false)]
                    public long? RuleDescId { get; set; }

                }

            }

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
