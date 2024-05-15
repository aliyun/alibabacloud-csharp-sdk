// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDiagnosticReportsResponseBody : TeaModel {
        /// <summary>
        /// The query token returned in this call.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The list of reports.
        /// </summary>
        [NameInMap("Reports")]
        [Validation(Required=false)]
        public DescribeDiagnosticReportsResponseBodyReports Reports { get; set; }
        public class DescribeDiagnosticReportsResponseBodyReports : TeaModel {
            [NameInMap("Report")]
            [Validation(Required=false)]
            public List<DescribeDiagnosticReportsResponseBodyReportsReport> Report { get; set; }
            public class DescribeDiagnosticReportsResponseBodyReportsReport : TeaModel {
                /// <summary>
                /// The time when the diagnostic report was created.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The end of the reporting period of the diagnostic report. The value is the EndTime value that was passed in when you called the [CreateDiagnosticReport](https://help.aliyun.com/document_detail/442490.html) operation to create the diagnostic report.
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// The time when the diagnostic was complete.
                /// </summary>
                [NameInMap("FinishedTime")]
                [Validation(Required=false)]
                public string FinishedTime { get; set; }

                /// <summary>
                /// The list of issues.
                /// </summary>
                [NameInMap("Issues")]
                [Validation(Required=false)]
                public DescribeDiagnosticReportsResponseBodyReportsReportIssues Issues { get; set; }
                public class DescribeDiagnosticReportsResponseBodyReportsReportIssues : TeaModel {
                    [NameInMap("Issue")]
                    [Validation(Required=false)]
                    public List<DescribeDiagnosticReportsResponseBodyReportsReportIssuesIssue> Issue { get; set; }
                    public class DescribeDiagnosticReportsResponseBodyReportsReportIssuesIssue : TeaModel {
                        /// <summary>
                        /// The unique ID of the diagnosed issue.
                        /// </summary>
                        [NameInMap("IssueId")]
                        [Validation(Required=false)]
                        public string IssueId { get; set; }

                        /// <summary>
                        /// The category of the diagnostic metric.
                        /// </summary>
                        [NameInMap("MetricCategory")]
                        [Validation(Required=false)]
                        public string MetricCategory { get; set; }

                        /// <summary>
                        /// The ID of the diagnostic metric.
                        /// </summary>
                        [NameInMap("MetricId")]
                        [Validation(Required=false)]
                        public string MetricId { get; set; }

                        /// <summary>
                        /// The severity level of the diagnostic metric. Valid values:
                        /// 
                        /// *   Info: Diagnostic information was recorded and may be related to exceptions.
                        /// *   Warn: Diagnostic information was recorded and may indicate exceptions.
                        /// *   Critical: Critical exceptions were detected.
                        /// </summary>
                        [NameInMap("Severity")]
                        [Validation(Required=false)]
                        public string Severity { get; set; }

                    }

                }

                /// <summary>
                /// The ID of the diagnostic metric set.
                /// </summary>
                [NameInMap("MetricSetId")]
                [Validation(Required=false)]
                public string MetricSetId { get; set; }

                /// <summary>
                /// The ID of the diagnostic report.
                /// </summary>
                [NameInMap("ReportId")]
                [Validation(Required=false)]
                public string ReportId { get; set; }

                /// <summary>
                /// The ID of the resource.
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// The type of the resource.
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// The severity level of the diagnostic report. Valid values:
                /// 
                /// *   Unknown: The diagnostic has not started, failed to run, or exited unexpectedly without a diagnosis.
                /// *   Normal: No exceptions were detected.
                /// *   Info: Diagnostic information was recorded and may be related to exceptions.
                /// *   Warn: Diagnostic information was recorded and may indicate exceptions.
                /// *   Critical: Critical exceptions were detected.
                /// </summary>
                [NameInMap("Severity")]
                [Validation(Required=false)]
                public string Severity { get; set; }

                /// <summary>
                /// The beginning of the reporting period of the diagnostic report. The value is the StartTime value that was passed in when you called the [CreateDiagnosticReport](https://help.aliyun.com/document_detail/442490.html) operation to create the diagnostic report.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// The state of the diagnostic report.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
