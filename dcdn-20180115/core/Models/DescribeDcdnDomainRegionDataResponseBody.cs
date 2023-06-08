// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainRegionDataResponseBody : TeaModel {
        /// <summary>
        /// The average response time. Unit: milliseconds.
        /// </summary>
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        /// <summary>
        /// The average response speed. Unit: byte/s.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The total amount of network traffic.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The region.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The name of the region.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The proportion of requests from the specified region based on the total number of requests in percentile. For example, a value of 90 indicates that 90% of the requests were coming from the specified region.
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public DescribeDcdnDomainRegionDataResponseBodyValue Value { get; set; }
        public class DescribeDcdnDomainRegionDataResponseBodyValue : TeaModel {
            [NameInMap("RegionProportionData")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainRegionDataResponseBodyValueRegionProportionData> RegionProportionData { get; set; }
            public class DescribeDcdnDomainRegionDataResponseBodyValueRegionProportionData : TeaModel {
                [NameInMap("AvgObjectSize")]
                [Validation(Required=false)]
                public string AvgObjectSize { get; set; }

                [NameInMap("AvgResponseRate")]
                [Validation(Required=false)]
                public string AvgResponseRate { get; set; }

                [NameInMap("AvgResponseTime")]
                [Validation(Required=false)]
                public string AvgResponseTime { get; set; }

                [NameInMap("Bps")]
                [Validation(Required=false)]
                public string Bps { get; set; }

                [NameInMap("BytesProportion")]
                [Validation(Required=false)]
                public string BytesProportion { get; set; }

                [NameInMap("Proportion")]
                [Validation(Required=false)]
                public string Proportion { get; set; }

                /// <summary>
                /// The average response size. Unit: bytes.
                /// </summary>
                [NameInMap("Qps")]
                [Validation(Required=false)]
                public string Qps { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// > 
                /// *   If you do not specify the StartTime or EndTime parameters, the data within the last 24 hours is queried by default.
                /// *   If you specify the StartTime and EndTime parameters, the data within the specified time range is queried.
                /// *   The maximum number of times that each user can call this operation per second is 100.
                /// </summary>
                [NameInMap("RegionEname")]
                [Validation(Required=false)]
                public string RegionEname { get; set; }

                /// <summary>
                /// The proportion of network traffic occupied by the specified region based on the total amount of network traffic in percentile. For example, a value of 90 indicates that 90% of the network traffic was coming from the specified region.
                /// </summary>
                [NameInMap("TotalBytes")]
                [Validation(Required=false)]
                public string TotalBytes { get; set; }

                /// <summary>
                /// The bandwidth.
                /// </summary>
                [NameInMap("TotalQuery")]
                [Validation(Required=false)]
                public string TotalQuery { get; set; }

            }

        }

    }

}
