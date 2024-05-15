// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDiagnosticReportAttributesResponseBody : TeaModel {
        /// <summary>
        /// The extended attributes of the diagnostic report.
        /// </summary>
        [NameInMap("Attributes")]
        [Validation(Required=false)]
        public string Attributes { get; set; }

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
        /// The time when the diagnostic report was complete.
        /// </summary>
        [NameInMap("FinishedTime")]
        [Validation(Required=false)]
        public string FinishedTime { get; set; }

        /// <summary>
        /// The results of all diagnostic metrics in the diagnostic metric set.
        /// </summary>
        [NameInMap("MetricResults")]
        [Validation(Required=false)]
        public DescribeDiagnosticReportAttributesResponseBodyMetricResults MetricResults { get; set; }
        public class DescribeDiagnosticReportAttributesResponseBodyMetricResults : TeaModel {
            [NameInMap("MetricResult")]
            [Validation(Required=false)]
            public List<DescribeDiagnosticReportAttributesResponseBodyMetricResultsMetricResult> MetricResult { get; set; }
            public class DescribeDiagnosticReportAttributesResponseBodyMetricResultsMetricResult : TeaModel {
                /// <summary>
                /// The diagnosed issues.
                /// </summary>
                [NameInMap("Issues")]
                [Validation(Required=false)]
                public DescribeDiagnosticReportAttributesResponseBodyMetricResultsMetricResultIssues Issues { get; set; }
                public class DescribeDiagnosticReportAttributesResponseBodyMetricResultsMetricResultIssues : TeaModel {
                    [NameInMap("Issue")]
                    [Validation(Required=false)]
                    public List<DescribeDiagnosticReportAttributesResponseBodyMetricResultsMetricResultIssuesIssue> Issue { get; set; }
                    public class DescribeDiagnosticReportAttributesResponseBodyMetricResultsMetricResultIssuesIssue : TeaModel {
                        /// <summary>
                        /// The additional data about the diagnosed issue. The value is a JSON string.
                        /// </summary>
                        [NameInMap("Additional")]
                        [Validation(Required=false)]
                        public string Additional { get; set; }

                        /// <summary>
                        /// The ID of the diagnosed issue, which is the unique identifier of the issue.
                        /// </summary>
                        [NameInMap("IssueId")]
                        [Validation(Required=false)]
                        public string IssueId { get; set; }

                        /// <summary>
                        /// The time when the diagnosed issue occurred.
                        /// </summary>
                        [NameInMap("OccurrenceTime")]
                        [Validation(Required=false)]
                        public string OccurrenceTime { get; set; }

                        /// <summary>
                        /// The severity level of the diagnosed issue. Valid values:
                        /// 
                        /// *   Info: Diagnostic information was recorded and may be related to exceptions.
                        /// *   Warn: Diagnostic information was recorded and may indicate potential exceptions.
                        /// *   Critical: Critical exceptions were detected.
                        /// </summary>
                        [NameInMap("Severity")]
                        [Validation(Required=false)]
                        public string Severity { get; set; }

                    }

                }

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
                /// *   Unknown: The diagnostic has not started, failed to run, or exited unexpectedly without a diagnosis.
                /// *   Normal: No exceptions were detected.
                /// *   Info: Diagnostic information was recorded and may be related to exceptions.
                /// *   NotSupport: The version of the guest operating system does support diagnosing the metric.
                /// *   Warn: Diagnostic information was recorded and may indicate potential exceptions.
                /// *   Critical: Critical exceptions were detected.
                /// </summary>
                [NameInMap("Severity")]
                [Validation(Required=false)]
                public string Severity { get; set; }

                /// <summary>
                /// The state of the diagnostic metric. Valid values:
                /// 
                /// *   InProgress.
                /// *   Finished.
                /// *   Failed.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// The ID of the diagnostic metric set.
        /// </summary>
        [NameInMap("MetricSetId")]
        [Validation(Required=false)]
        public string MetricSetId { get; set; }

        /// <summary>
        /// The ID of the diagnostic report, which is the unique identifier of the report.
        /// </summary>
        [NameInMap("ReportId")]
        [Validation(Required=false)]
        public string ReportId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The resource ID.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// The type of the resource. ResourceType can only be set to instance, which indicates that only instances are supported.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The severity level of the diagnostic report. The value of this parameter is determined by the highest severity level of all diagnostic metrics. Valid values:
        /// 
        /// *   Unknown: The diagnostic has not started, failed to run, or exited unexpectedly without a diagnosis.
        /// *   Normal: No exceptions were detected.
        /// *   Info: Diagnostic information was recorded and may be related to exceptions.
        /// *   Warn: Diagnostic information was recorded and may indicate potential exceptions.
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
        /// The state of the diagnostic report. Valid values:
        /// 
        /// *   InProgress: The diagnostic is in progress.
        /// *   Finished: The diagnostic is complete.
        /// *   Failed: The diagnostic failed.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
