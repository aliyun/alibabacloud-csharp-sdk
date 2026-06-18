// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeCacheReservePriceResponseBody : TeaModel {
        /// <summary>
        /// <para>The price information.</para>
        /// </summary>
        [NameInMap("PriceModel")]
        [Validation(Required=false)]
        public DescribeCacheReservePriceResponseBodyPriceModel PriceModel { get; set; }
        public class DescribeCacheReservePriceResponseBodyPriceModel : TeaModel {
            /// <summary>
            /// <para>The currency. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>JPY: Japanese Yen.</para>
            /// </description></item>
            /// <item><description><para>USD: US Dollar.</para>
            /// </description></item>
            /// <item><description><para>CNY: Chinese Yuan.</para>
            /// </description></item>
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
            public DescribeCacheReservePriceResponseBodyPriceModelRule Rule { get; set; }
            public class DescribeCacheReservePriceResponseBodyPriceModelRule : TeaModel {
                [NameInMap("RuleList")]
                [Validation(Required=false)]
                public List<DescribeCacheReservePriceResponseBodyPriceModelRuleRuleList> RuleList { get; set; }
                public class DescribeCacheReservePriceResponseBodyPriceModelRuleRuleList : TeaModel {
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
        /// <para>2430E05E-1340-5773-B5E1-B743929F46F2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
