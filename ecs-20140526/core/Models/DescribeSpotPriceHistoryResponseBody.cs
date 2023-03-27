// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeSpotPriceHistoryResponseBody : TeaModel {
        /// <summary>
        /// The currency unit of the price.
        /// 
        /// Alibaba Cloud China site (aliyun.com): CNY.
        /// 
        /// Alibaba Cloud International site (alibabacloud.com): USD.
        /// </summary>
        [NameInMap("Currency")]
        [Validation(Required=false)]
        public string Currency { get; set; }

        /// <summary>
        /// The start line of the next page. It is the value of the `Offset` request parameter.
        /// </summary>
        [NameInMap("NextOffset")]
        [Validation(Required=false)]
        public int? NextOffset { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Details about the price history of the preemptible instance.
        /// </summary>
        [NameInMap("SpotPrices")]
        [Validation(Required=false)]
        public DescribeSpotPriceHistoryResponseBodySpotPrices SpotPrices { get; set; }
        public class DescribeSpotPriceHistoryResponseBodySpotPrices : TeaModel {
            [NameInMap("SpotPriceType")]
            [Validation(Required=false)]
            public List<DescribeSpotPriceHistoryResponseBodySpotPricesSpotPriceType> SpotPriceType { get; set; }
            public class DescribeSpotPriceHistoryResponseBodySpotPricesSpotPriceType : TeaModel {
                /// <summary>
                /// The instance type of the preemptible instance.
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// Indicates whether the preemptible instance is I/O optimized.
                /// </summary>
                [NameInMap("IoOptimized")]
                [Validation(Required=false)]
                public string IoOptimized { get; set; }

                /// <summary>
                /// The network type of the preemptible instance.
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// The price for a pay-as-you-go instance that has the same configurations as the preemptible instance.
                /// </summary>
                [NameInMap("OriginPrice")]
                [Validation(Required=false)]
                public float? OriginPrice { get; set; }

                /// <summary>
                /// The spot price (market price) of the preemptible instance.
                /// </summary>
                [NameInMap("SpotPrice")]
                [Validation(Required=false)]
                public float? SpotPrice { get; set; }

                /// <summary>
                /// The time that corresponds to the queried spot price. The time is in the `yyyy-MM-ddTHH:mm:ssZ` format.
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

                /// <summary>
                /// The zone ID of the preemptible instance.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

    }

}
