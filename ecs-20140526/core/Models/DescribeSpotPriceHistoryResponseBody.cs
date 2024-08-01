// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeSpotPriceHistoryResponseBody : TeaModel {
        /// <summary>
        /// The instance type of the preemptible instance.
        /// </summary>
        [NameInMap("Currency")]
        [Validation(Required=false)]
        public string Currency { get; set; }

        /// <summary>
        /// The network type of the preemptible instance.
        /// </summary>
        [NameInMap("NextOffset")]
        [Validation(Required=false)]
        public int? NextOffset { get; set; }

        /// <summary>
        /// The instance type of the preemptible instance.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The zone ID of the preemptible instance.
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
                /// Details about the price history of the preemptible instance.
                /// </summary>
                [NameInMap("IoOptimized")]
                [Validation(Required=false)]
                public string IoOptimized { get; set; }

                /// <summary>
                /// Queries the price history of a preemptible instance within the last 30 days.
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// The price for a pay-as-you-go instance that has the same configuration as the specified preemptible instance.
                /// </summary>
                [NameInMap("OriginPrice")]
                [Validation(Required=false)]
                public float? OriginPrice { get; set; }

                /// <summary>
                /// The price for a pay-as-you-go instance that has the same configurations as the preemptible instance.
                /// </summary>
                [NameInMap("SpotPrice")]
                [Validation(Required=false)]
                public float? SpotPrice { get; set; }

                /// <summary>
                /// The currency unit of the price.
                /// 
                /// Alibaba Cloud China site (aliyun.com): CNY.
                /// 
                /// Alibaba Cloud International site (alibabacloud.com): USD.
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

                /// <summary>
                /// The ID of the request.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

    }

}
