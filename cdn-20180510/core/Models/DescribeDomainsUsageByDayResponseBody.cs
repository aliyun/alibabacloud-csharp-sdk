// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainsUsageByDayResponseBody : TeaModel {
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
        /// The monitoring data collected at each time interval.
        /// </summary>
        [NameInMap("UsageByDays")]
        [Validation(Required=false)]
        public DescribeDomainsUsageByDayResponseBodyUsageByDays UsageByDays { get; set; }
        public class DescribeDomainsUsageByDayResponseBodyUsageByDays : TeaModel {
            [NameInMap("UsageByDay")]
            [Validation(Required=false)]
            public List<DescribeDomainsUsageByDayResponseBodyUsageByDaysUsageByDay> UsageByDay { get; set; }
            public class DescribeDomainsUsageByDayResponseBodyUsageByDaysUsageByDay : TeaModel {
                /// <summary>
                /// The byte hit ratio. The byte hit ratio is measured in percentage.
                /// </summary>
                [NameInMap("BytesHitRate")]
                [Validation(Required=false)]
                public string BytesHitRate { get; set; }

                /// <summary>
                /// The peak bandwidth value. Unit: bit/s.
                /// </summary>
                [NameInMap("MaxBps")]
                [Validation(Required=false)]
                public string MaxBps { get; set; }

                /// <summary>
                /// The time when the bandwidth reached the peak value.
                /// </summary>
                [NameInMap("MaxBpsTime")]
                [Validation(Required=false)]
                public string MaxBpsTime { get; set; }

                /// <summary>
                /// The peak bandwidth value during back-to-origin routing. Unit: bit/s.
                /// </summary>
                [NameInMap("MaxSrcBps")]
                [Validation(Required=false)]
                public string MaxSrcBps { get; set; }

                /// <summary>
                /// The time when the bandwidth during back-to-origin routing reached the peak value.
                /// </summary>
                [NameInMap("MaxSrcBpsTime")]
                [Validation(Required=false)]
                public string MaxSrcBpsTime { get; set; }

                /// <summary>
                /// The number of queries per second (QPS).
                /// </summary>
                [NameInMap("Qps")]
                [Validation(Required=false)]
                public string Qps { get; set; }

                /// <summary>
                /// The cache hit ratio that is calculated based on requests. The cache hit ratio is measured in percentage.
                /// </summary>
                [NameInMap("RequestHitRate")]
                [Validation(Required=false)]
                public string RequestHitRate { get; set; }

                /// <summary>
                /// The timestamp of the data returned.
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                /// <summary>
                /// The total amount of requests.
                /// </summary>
                [NameInMap("TotalAccess")]
                [Validation(Required=false)]
                public string TotalAccess { get; set; }

                /// <summary>
                /// The total amount of network traffic. Unit: bytes.
                /// </summary>
                [NameInMap("TotalTraffic")]
                [Validation(Required=false)]
                public string TotalTraffic { get; set; }

            }

        }

        /// <summary>
        /// The summarized monitoring data.
        /// </summary>
        [NameInMap("UsageTotal")]
        [Validation(Required=false)]
        public DescribeDomainsUsageByDayResponseBodyUsageTotal UsageTotal { get; set; }
        public class DescribeDomainsUsageByDayResponseBodyUsageTotal : TeaModel {
            /// <summary>
            /// The byte hit ratio. The byte hit ratio is measured in percentage.
            /// </summary>
            [NameInMap("BytesHitRate")]
            [Validation(Required=false)]
            public string BytesHitRate { get; set; }

            /// <summary>
            /// The peak bandwidth value. Unit: bit/s.
            /// </summary>
            [NameInMap("MaxBps")]
            [Validation(Required=false)]
            public string MaxBps { get; set; }

            /// <summary>
            /// The time when the bandwidth reached the peak value.
            /// </summary>
            [NameInMap("MaxBpsTime")]
            [Validation(Required=false)]
            public string MaxBpsTime { get; set; }

            /// <summary>
            /// The peak bandwidth value during back-to-origin routing. Unit: bit/s.
            /// </summary>
            [NameInMap("MaxSrcBps")]
            [Validation(Required=false)]
            public string MaxSrcBps { get; set; }

            /// <summary>
            /// The time when the bandwidth during back-to-origin routing reached the peak value.
            /// </summary>
            [NameInMap("MaxSrcBpsTime")]
            [Validation(Required=false)]
            public string MaxSrcBpsTime { get; set; }

            /// <summary>
            /// The cache hit ratio that is calculated based on requests. The cache hit ratio is measured in percentage.
            /// </summary>
            [NameInMap("RequestHitRate")]
            [Validation(Required=false)]
            public string RequestHitRate { get; set; }

            /// <summary>
            /// The total amount of requests.
            /// </summary>
            [NameInMap("TotalAccess")]
            [Validation(Required=false)]
            public string TotalAccess { get; set; }

            /// <summary>
            /// The total amount of network traffic. Unit: bytes.
            /// </summary>
            [NameInMap("TotalTraffic")]
            [Validation(Required=false)]
            public string TotalTraffic { get; set; }

        }

    }

}
