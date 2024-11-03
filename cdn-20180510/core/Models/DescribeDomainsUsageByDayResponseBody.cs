// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainsUsageByDayResponseBody : TeaModel {
        /// <summary>
        /// <para>The time interval between the data entries returned. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86400</para>
        /// </summary>
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        /// <summary>
        /// <para>The accelerated domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end of the time range during which data was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-12-23T09:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C88EF8ED-72F0-45EA-9E86-95114E224FC5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start of the time range during which data was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-12-22T08:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The monitoring data collected at each time interval.</para>
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
                /// <para>The byte hit ratio. The byte hit ratio is measured in percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>97.46250599529726</para>
                /// </summary>
                [NameInMap("BytesHitRate")]
                [Validation(Required=false)]
                public string BytesHitRate { get; set; }

                /// <summary>
                /// <para>The peak bandwidth value. Unit: bit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>306747.76</para>
                /// </summary>
                [NameInMap("MaxBps")]
                [Validation(Required=false)]
                public string MaxBps { get; set; }

                /// <summary>
                /// <para>The time when the bandwidth reached the peak value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-12-23 10:55:00</para>
                /// </summary>
                [NameInMap("MaxBpsTime")]
                [Validation(Required=false)]
                public string MaxBpsTime { get; set; }

                /// <summary>
                /// <para>The peak bandwidth value during back-to-origin routing. Unit: bit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>72584.072</para>
                /// </summary>
                [NameInMap("MaxSrcBps")]
                [Validation(Required=false)]
                public string MaxSrcBps { get; set; }

                /// <summary>
                /// <para>The time when the bandwidth during back-to-origin routing reached the peak value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-12-23 11:45:00</para>
                /// </summary>
                [NameInMap("MaxSrcBpsTime")]
                [Validation(Required=false)]
                public string MaxSrcBpsTime { get; set; }

                /// <summary>
                /// <para>The number of queries per second (QPS).</para>
                /// 
                /// <b>Example:</b>
                /// <para>7.466354166666667</para>
                /// </summary>
                [NameInMap("Qps")]
                [Validation(Required=false)]
                public string Qps { get; set; }

                /// <summary>
                /// <para>The cache hit ratio that is calculated based on requests. The cache hit ratio is measured in percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>70.24770071912111</para>
                /// </summary>
                [NameInMap("RequestHitRate")]
                [Validation(Required=false)]
                public string RequestHitRate { get; set; }

                /// <summary>
                /// <para>The timestamp of the data returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-12-22</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                /// <summary>
                /// <para>The total amount of requests.</para>
                /// 
                /// <b>Example:</b>
                /// <para>645093</para>
                /// </summary>
                [NameInMap("TotalAccess")]
                [Validation(Required=false)]
                public string TotalAccess { get; set; }

                /// <summary>
                /// <para>The total amount of network traffic. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>564300099309</para>
                /// </summary>
                [NameInMap("TotalTraffic")]
                [Validation(Required=false)]
                public string TotalTraffic { get; set; }

            }

        }

        /// <summary>
        /// <para>The summarized monitoring data.</para>
        /// </summary>
        [NameInMap("UsageTotal")]
        [Validation(Required=false)]
        public DescribeDomainsUsageByDayResponseBodyUsageTotal UsageTotal { get; set; }
        public class DescribeDomainsUsageByDayResponseBodyUsageTotal : TeaModel {
            /// <summary>
            /// <para>The byte hit ratio. The byte hit ratio is measured in percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>97.03110726801242</para>
            /// </summary>
            [NameInMap("BytesHitRate")]
            [Validation(Required=false)]
            public string BytesHitRate { get; set; }

            /// <summary>
            /// <para>The peak bandwidth value. Unit: bit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0747912780000001E8</para>
            /// </summary>
            [NameInMap("MaxBps")]
            [Validation(Required=false)]
            public string MaxBps { get; set; }

            /// <summary>
            /// <para>The time when the bandwidth reached the peak value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-12-23 10:55:00</para>
            /// </summary>
            [NameInMap("MaxBpsTime")]
            [Validation(Required=false)]
            public string MaxBpsTime { get; set; }

            /// <summary>
            /// <para>The peak bandwidth value during back-to-origin routing. Unit: bit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>72584.072</para>
            /// </summary>
            [NameInMap("MaxSrcBps")]
            [Validation(Required=false)]
            public string MaxSrcBps { get; set; }

            /// <summary>
            /// <para>The time when the bandwidth during back-to-origin routing reached the peak value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-12-23 11:45:00</para>
            /// </summary>
            [NameInMap("MaxSrcBpsTime")]
            [Validation(Required=false)]
            public string MaxSrcBpsTime { get; set; }

            /// <summary>
            /// <para>The cache hit ratio that is calculated based on requests. The cache hit ratio is measured in percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>69.92610837438424</para>
            /// </summary>
            [NameInMap("RequestHitRate")]
            [Validation(Required=false)]
            public string RequestHitRate { get; set; }

            /// <summary>
            /// <para>The total amount of requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1319500</para>
            /// </summary>
            [NameInMap("TotalAccess")]
            [Validation(Required=false)]
            public string TotalAccess { get; set; }

            /// <summary>
            /// <para>The total amount of network traffic. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1117711832100</para>
            /// </summary>
            [NameInMap("TotalTraffic")]
            [Validation(Required=false)]
            public string TotalTraffic { get; set; }

        }

    }

}
