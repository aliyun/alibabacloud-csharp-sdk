// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainsUsageByDayResponseBody : TeaModel {
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        [NameInMap("UsageTotal")]
        [Validation(Required=false)]
        public DescribeDomainsUsageByDayResponseBodyUsageTotal UsageTotal { get; set; }
        public class DescribeDomainsUsageByDayResponseBodyUsageTotal : TeaModel {
            [NameInMap("MaxSrcBpsTime")]
            [Validation(Required=false)]
            public string MaxSrcBpsTime { get; set; }
            [NameInMap("RequestHitRate")]
            [Validation(Required=false)]
            public string RequestHitRate { get; set; }
            [NameInMap("MaxBps")]
            [Validation(Required=false)]
            public string MaxBps { get; set; }
            [NameInMap("TotalAccess")]
            [Validation(Required=false)]
            public string TotalAccess { get; set; }
            [NameInMap("BytesHitRate")]
            [Validation(Required=false)]
            public string BytesHitRate { get; set; }
            [NameInMap("TotalTraffic")]
            [Validation(Required=false)]
            public string TotalTraffic { get; set; }
            [NameInMap("MaxBpsTime")]
            [Validation(Required=false)]
            public string MaxBpsTime { get; set; }
            [NameInMap("MaxSrcBps")]
            [Validation(Required=false)]
            public string MaxSrcBps { get; set; }
        };

        [NameInMap("UsageByDays")]
        [Validation(Required=false)]
        public DescribeDomainsUsageByDayResponseBodyUsageByDays UsageByDays { get; set; }
        public class DescribeDomainsUsageByDayResponseBodyUsageByDays : TeaModel {
            [NameInMap("UsageByDay")]
            [Validation(Required=false)]
            public List<DescribeDomainsUsageByDayResponseBodyUsageByDaysUsageByDay> UsageByDay { get; set; }
            public class DescribeDomainsUsageByDayResponseBodyUsageByDaysUsageByDay : TeaModel {
                public string MaxSrcBpsTime { get; set; }
                public string Qps { get; set; }
                public string RequestHitRate { get; set; }
                public string MaxBps { get; set; }
                public string TotalAccess { get; set; }
                public string TimeStamp { get; set; }
                public string BytesHitRate { get; set; }
                public string TotalTraffic { get; set; }
                public string MaxSrcBps { get; set; }
                public string MaxBpsTime { get; set; }
            }
        };

    }

}
