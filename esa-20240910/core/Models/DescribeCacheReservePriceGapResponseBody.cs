// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeCacheReservePriceGapResponseBody : TeaModel {
        [NameInMap("PriceModel")]
        [Validation(Required=false)]
        public DescribeCacheReservePriceGapResponseBodyPriceModel PriceModel { get; set; }
        public class DescribeCacheReservePriceGapResponseBodyPriceModel : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>CNY</para>
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DiscountPrice")]
            [Validation(Required=false)]
            public float? DiscountPrice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>esa-cr-9tuv*********</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
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
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TotalPrice")]
            [Validation(Required=false)]
            public float? TotalPrice { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>40423A7F-A83D-1E24-B80E-86DD25790759</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
