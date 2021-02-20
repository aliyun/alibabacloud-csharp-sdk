// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Avds20171129.Models
{
    public class DescribeScanSessionsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageCount")]
        [Validation(Required=false)]
        public int? PageCount { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("List")]
        [Validation(Required=false)]
        public List<DescribeScanSessionsResponseBodyList> List { get; set; }
        public class DescribeScanSessionsResponseBodyList : TeaModel {
            [NameInMap("ReportStatus")]
            [Validation(Required=false)]
            public string ReportStatus { get; set; }

            [NameInMap("FinishedAt")]
            [Validation(Required=false)]
            public long? FinishedAt { get; set; }

            [NameInMap("Targets")]
            [Validation(Required=false)]
            public List<string> Targets { get; set; }

            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public long? CreatedAt { get; set; }

            [NameInMap("ScanId")]
            [Validation(Required=false)]
            public string ScanId { get; set; }

            [NameInMap("Period")]
            [Validation(Required=false)]
            public string Period { get; set; }

            [NameInMap("TriggerType")]
            [Validation(Required=false)]
            public string TriggerType { get; set; }

            [NameInMap("ReportUrl")]
            [Validation(Required=false)]
            public string ReportUrl { get; set; }

            [NameInMap("JobStatus")]
            [Validation(Required=false)]
            public string JobStatus { get; set; }

            [NameInMap("RunPercent")]
            [Validation(Required=false)]
            public float? RunPercent { get; set; }

            [NameInMap("Interval")]
            [Validation(Required=false)]
            public int? Interval { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

        }

        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

    }

}
