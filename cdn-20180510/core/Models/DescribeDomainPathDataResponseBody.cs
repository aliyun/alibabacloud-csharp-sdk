// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainPathDataResponseBody : TeaModel {
        /// <summary>
        /// The time interval. Unit: seconds.
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
        /// The page number of the returned page. Pages start from page **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// A list of bandwidth values collected at each time interval.
        /// </summary>
        [NameInMap("PathDataPerInterval")]
        [Validation(Required=false)]
        public DescribeDomainPathDataResponseBodyPathDataPerInterval PathDataPerInterval { get; set; }
        public class DescribeDomainPathDataResponseBodyPathDataPerInterval : TeaModel {
            [NameInMap("UsageData")]
            [Validation(Required=false)]
            public List<DescribeDomainPathDataResponseBodyPathDataPerIntervalUsageData> UsageData { get; set; }
            public class DescribeDomainPathDataResponseBodyPathDataPerIntervalUsageData : TeaModel {
                /// <summary>
                /// The number of visits to the URL.
                /// </summary>
                [NameInMap("Acc")]
                [Validation(Required=false)]
                public int? Acc { get; set; }

                /// <summary>
                /// The path.
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// The point in time.
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

                /// <summary>
                /// The amount of network traffic. Unit: bytes.
                /// </summary>
                [NameInMap("Traffic")]
                [Validation(Required=false)]
                public int? Traffic { get; set; }

            }

        }

        /// <summary>
        /// The start of the time range during which data was queried.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
