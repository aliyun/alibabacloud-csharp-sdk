// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeSpotPriceHistoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance type of the spot instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CNY</para>
        /// </summary>
        [NameInMap("Currency")]
        [Validation(Required=false)]
        public string Currency { get; set; }

        /// <summary>
        /// <para>The network type of the spot instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("NextOffset")]
        [Validation(Required=false)]
        public int? NextOffset { get; set; }

        /// <summary>
        /// <para>The instance type of the spot instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SpotPrices")]
        [Validation(Required=false)]
        public DescribeSpotPriceHistoryResponseBodySpotPrices SpotPrices { get; set; }
        public class DescribeSpotPriceHistoryResponseBodySpotPrices : TeaModel {
            [NameInMap("SpotPriceType")]
            [Validation(Required=false)]
            public List<DescribeSpotPriceHistoryResponseBodySpotPricesSpotPriceType> SpotPriceType { get; set; }
            public class DescribeSpotPriceHistoryResponseBodySpotPricesSpotPriceType : TeaModel {
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                [NameInMap("IoOptimized")]
                [Validation(Required=false)]
                public string IoOptimized { get; set; }

                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                [NameInMap("OriginPrice")]
                [Validation(Required=false)]
                public float? OriginPrice { get; set; }

                [NameInMap("SpotPrice")]
                [Validation(Required=false)]
                public float? SpotPrice { get; set; }

                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

    }

}
