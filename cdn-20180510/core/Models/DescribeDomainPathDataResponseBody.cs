// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainPathDataResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("PathDataPerInterval")]
        [Validation(Required=false)]
        public DescribeDomainPathDataResponseBodyPathDataPerInterval PathDataPerInterval { get; set; }
        public class DescribeDomainPathDataResponseBodyPathDataPerInterval : TeaModel {
            [NameInMap("UsageData")]
            [Validation(Required=false)]
            public List<DescribeDomainPathDataResponseBodyPathDataPerIntervalUsageData> UsageData { get; set; }
            public class DescribeDomainPathDataResponseBodyPathDataPerIntervalUsageData : TeaModel {
                public string Time { get; set; }
                public int? Acc { get; set; }
                public int? Traffic { get; set; }
                public string Path { get; set; }
            }
        };

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

    }

}
