// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainPathDataResponseBody : TeaModel {
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PathDataPerInterval")]
        [Validation(Required=false)]
        public DescribeDomainPathDataResponseBodyPathDataPerInterval PathDataPerInterval { get; set; }
        public class DescribeDomainPathDataResponseBodyPathDataPerInterval : TeaModel {
            [NameInMap("UsageData")]
            [Validation(Required=false)]
            public List<DescribeDomainPathDataResponseBodyPathDataPerIntervalUsageData> UsageData { get; set; }
            public class DescribeDomainPathDataResponseBodyPathDataPerIntervalUsageData : TeaModel {
                [NameInMap("Acc")]
                [Validation(Required=false)]
                public int? Acc { get; set; }

                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

                [NameInMap("Traffic")]
                [Validation(Required=false)]
                public int? Traffic { get; set; }

            }

        }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
