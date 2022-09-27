// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDiagnosticReportsResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("Reports")]
        [Validation(Required=false)]
        public List<DescribeDiagnosticReportsResponseBodyReports> Reports { get; set; }
        public class DescribeDiagnosticReportsResponseBodyReports : TeaModel {
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("FinishedTime")]
            [Validation(Required=false)]
            public string FinishedTime { get; set; }

            [NameInMap("Issues")]
            [Validation(Required=false)]
            public List<DescribeDiagnosticReportsResponseBodyReportsIssues> Issues { get; set; }
            public class DescribeDiagnosticReportsResponseBodyReportsIssues : TeaModel {
                [NameInMap("IssueId")]
                [Validation(Required=false)]
                public string IssueId { get; set; }

                [NameInMap("MetricCategory")]
                [Validation(Required=false)]
                public string MetricCategory { get; set; }

                [NameInMap("MetricId")]
                [Validation(Required=false)]
                public string MetricId { get; set; }

                [NameInMap("Severity")]
                [Validation(Required=false)]
                public string Severity { get; set; }

            }

            [NameInMap("MetricSetId")]
            [Validation(Required=false)]
            public string MetricSetId { get; set; }

            [NameInMap("ReportId")]
            [Validation(Required=false)]
            public string ReportId { get; set; }

            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            [NameInMap("Severity")]
            [Validation(Required=false)]
            public string Severity { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
