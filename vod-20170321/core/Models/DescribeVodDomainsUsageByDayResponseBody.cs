// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainsUsageByDayResponseBody : TeaModel {
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("UsageByDays")]
        [Validation(Required=false)]
        public DescribeVodDomainsUsageByDayResponseBodyUsageByDays UsageByDays { get; set; }
        public class DescribeVodDomainsUsageByDayResponseBodyUsageByDays : TeaModel {
            [NameInMap("UsageByDay")]
            [Validation(Required=false)]
            public List<DescribeVodDomainsUsageByDayResponseBodyUsageByDaysUsageByDay> UsageByDay { get; set; }
            public class DescribeVodDomainsUsageByDayResponseBodyUsageByDaysUsageByDay : TeaModel {
                [NameInMap("BytesHitRate")]
                [Validation(Required=false)]
                public string BytesHitRate { get; set; }

                [NameInMap("MaxBps")]
                [Validation(Required=false)]
                public string MaxBps { get; set; }

                [NameInMap("MaxBpsTime")]
                [Validation(Required=false)]
                public string MaxBpsTime { get; set; }

                [NameInMap("MaxSrcBps")]
                [Validation(Required=false)]
                public string MaxSrcBps { get; set; }

                [NameInMap("MaxSrcBpsTime")]
                [Validation(Required=false)]
                public string MaxSrcBpsTime { get; set; }

                [NameInMap("Qps")]
                [Validation(Required=false)]
                public string Qps { get; set; }

                [NameInMap("RequestHitRate")]
                [Validation(Required=false)]
                public string RequestHitRate { get; set; }

                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                [NameInMap("TotalAccess")]
                [Validation(Required=false)]
                public string TotalAccess { get; set; }

                [NameInMap("TotalTraffic")]
                [Validation(Required=false)]
                public string TotalTraffic { get; set; }

            }

        }

        [NameInMap("UsageTotal")]
        [Validation(Required=false)]
        public DescribeVodDomainsUsageByDayResponseBodyUsageTotal UsageTotal { get; set; }
        public class DescribeVodDomainsUsageByDayResponseBodyUsageTotal : TeaModel {
            [NameInMap("BytesHitRate")]
            [Validation(Required=false)]
            public string BytesHitRate { get; set; }

            [NameInMap("MaxBps")]
            [Validation(Required=false)]
            public string MaxBps { get; set; }

            [NameInMap("MaxBpsTime")]
            [Validation(Required=false)]
            public string MaxBpsTime { get; set; }

            [NameInMap("MaxSrcBps")]
            [Validation(Required=false)]
            public string MaxSrcBps { get; set; }

            [NameInMap("MaxSrcBpsTime")]
            [Validation(Required=false)]
            public string MaxSrcBpsTime { get; set; }

            [NameInMap("RequestHitRate")]
            [Validation(Required=false)]
            public string RequestHitRate { get; set; }

            [NameInMap("TotalAccess")]
            [Validation(Required=false)]
            public string TotalAccess { get; set; }

            [NameInMap("TotalTraffic")]
            [Validation(Required=false)]
            public string TotalTraffic { get; set; }

        }

    }

}
