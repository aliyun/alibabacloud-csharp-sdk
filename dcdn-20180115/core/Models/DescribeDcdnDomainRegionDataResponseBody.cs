// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainRegionDataResponseBody : TeaModel {
        /// <summary>
        /// The time interval between the data entries returned. Unit: seconds.
        /// </summary>
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        /// <summary>
        /// The accelerated domain name.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The end of the time range during which data was queried.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The start of the time range during which data was queried.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The proportions of requests that were initiated from each region.
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public DescribeDcdnDomainRegionDataResponseBodyValue Value { get; set; }
        public class DescribeDcdnDomainRegionDataResponseBodyValue : TeaModel {
            [NameInMap("RegionProportionData")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainRegionDataResponseBodyValueRegionProportionData> RegionProportionData { get; set; }
            public class DescribeDcdnDomainRegionDataResponseBodyValueRegionProportionData : TeaModel {
                /// <summary>
                /// The average response size. Unit: bytes.
                /// </summary>
                [NameInMap("AvgObjectSize")]
                [Validation(Required=false)]
                public string AvgObjectSize { get; set; }

                /// <summary>
                /// The average response speed. Unit: byte/s.
                /// </summary>
                [NameInMap("AvgResponseRate")]
                [Validation(Required=false)]
                public string AvgResponseRate { get; set; }

                /// <summary>
                /// The average response time. Unit: milliseconds.
                /// </summary>
                [NameInMap("AvgResponseTime")]
                [Validation(Required=false)]
                public string AvgResponseTime { get; set; }

                /// <summary>
                /// The bandwidth.
                /// </summary>
                [NameInMap("Bps")]
                [Validation(Required=false)]
                public string Bps { get; set; }

                /// <summary>
                /// The proportion of network traffic. For example, a value of 90 indicates that 90% of network traffic was coming from the specified ISP.
                /// </summary>
                [NameInMap("BytesProportion")]
                [Validation(Required=false)]
                public string BytesProportion { get; set; }

                /// <summary>
                /// The proportion of requests from the specified region based on the total number of requests in percentile. For example, a value of 90 indicates that 90% of the requests were coming from the specified region.
                /// </summary>
                [NameInMap("Proportion")]
                [Validation(Required=false)]
                public string Proportion { get; set; }

                /// <summary>
                /// The number of queries per second (QPS).
                /// </summary>
                [NameInMap("Qps")]
                [Validation(Required=false)]
                public string Qps { get; set; }

                /// <summary>
                /// The information of the regions.
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// The name of the region.
                /// </summary>
                [NameInMap("RegionEname")]
                [Validation(Required=false)]
                public string RegionEname { get; set; }

                /// <summary>
                /// The total amount of network traffic.
                /// </summary>
                [NameInMap("TotalBytes")]
                [Validation(Required=false)]
                public string TotalBytes { get; set; }

                /// <summary>
                /// The total number of requests that are destined for your website.
                /// </summary>
                [NameInMap("TotalQuery")]
                [Validation(Required=false)]
                public string TotalQuery { get; set; }

            }

        }

    }

}
