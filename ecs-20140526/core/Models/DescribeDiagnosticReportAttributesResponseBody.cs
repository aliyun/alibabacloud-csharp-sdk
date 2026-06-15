// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDiagnosticReportAttributesResponseBody : TeaModel {
        /// <summary>
        /// <para>The extended attributes of the diagnostic report.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;OfflineDiagReportStatus&quot;:&quot;CONFIRMED&quot;}</para>
        /// </summary>
        [NameInMap("Attributes")]
        [Validation(Required=false)]
        public string Attributes { get; set; }

        /// <summary>
        /// <para>The time when the diagnostic report was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-11T12:00:00Z</para>
        /// </summary>
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// <para>The end of the diagnostic time range. This value corresponds to the <c>EndTime</c> parameter you provided when calling the <a href="https://help.aliyun.com/document_detail/442490.html">CreateDiagnosticReport</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-11T14:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The time when the diagnosis was complete.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-11T14:00:00Z</para>
        /// </summary>
        [NameInMap("FinishedTime")]
        [Validation(Required=false)]
        public string FinishedTime { get; set; }

        /// <summary>
        /// <para>The diagnostic results for the metrics.</para>
        /// </summary>
        [NameInMap("MetricResults")]
        [Validation(Required=false)]
        public DescribeDiagnosticReportAttributesResponseBodyMetricResults MetricResults { get; set; }
        public class DescribeDiagnosticReportAttributesResponseBodyMetricResults : TeaModel {
            [NameInMap("MetricResult")]
            [Validation(Required=false)]
            public List<DescribeDiagnosticReportAttributesResponseBodyMetricResultsMetricResult> MetricResult { get; set; }
            public class DescribeDiagnosticReportAttributesResponseBodyMetricResultsMetricResult : TeaModel {
                [NameInMap("Issues")]
                [Validation(Required=false)]
                public DescribeDiagnosticReportAttributesResponseBodyMetricResultsMetricResultIssues Issues { get; set; }
                public class DescribeDiagnosticReportAttributesResponseBodyMetricResultsMetricResultIssues : TeaModel {
                    [NameInMap("Issue")]
                    [Validation(Required=false)]
                    public List<DescribeDiagnosticReportAttributesResponseBodyMetricResultsMetricResultIssuesIssue> Issue { get; set; }
                    public class DescribeDiagnosticReportAttributesResponseBodyMetricResultsMetricResultIssuesIssue : TeaModel {
                        [NameInMap("Additional")]
                        [Validation(Required=false)]
                        public string Additional { get; set; }

                        [NameInMap("IssueId")]
                        [Validation(Required=false)]
                        public string IssueId { get; set; }

                        [NameInMap("OccurrenceTime")]
                        [Validation(Required=false)]
                        public string OccurrenceTime { get; set; }

                        [NameInMap("RepairStatus")]
                        [Validation(Required=false)]
                        public string RepairStatus { get; set; }

                        [NameInMap("Repairable")]
                        [Validation(Required=false)]
                        public bool? Repairable { get; set; }

                        [NameInMap("Severity")]
                        [Validation(Required=false)]
                        public string Severity { get; set; }

                    }

                }

                [NameInMap("MetricCategory")]
                [Validation(Required=false)]
                public string MetricCategory { get; set; }

                [NameInMap("MetricId")]
                [Validation(Required=false)]
                public string MetricId { get; set; }

                [NameInMap("Severity")]
                [Validation(Required=false)]
                public string Severity { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The metric set ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dms-bp17p0qwtr72zmu*****</para>
        /// </summary>
        [NameInMap("MetricSetId")]
        [Validation(Required=false)]
        public string MetricSetId { get; set; }

        /// <summary>
        /// <para>The unique ID of the diagnostic report.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dr-uf6i0tv2refv8wz*****</para>
        /// </summary>
        [NameInMap("ReportId")]
        [Validation(Required=false)]
        public string ReportId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resource ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-uf6i0tv2refv8wz*****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The resource type. Only <c>instance</c> is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The overall severity level of the diagnostic report. This is the highest severity level among all metrics in the report. Valid values are listed below, from lowest to highest severity:</para>
        /// <list type="bullet">
        /// <item><description><para>Unknown: The initial state. The diagnosis has not started or exited unexpectedly, so the result is inconclusive.</para>
        /// </description></item>
        /// <item><description><para>Normal: The resource is healthy, and no issues were found.</para>
        /// </description></item>
        /// <item><description><para>Info: Informational messages were found that may be relevant to an issue.</para>
        /// </description></item>
        /// <item><description><para>Warn: Warnings were found that may lead to an issue.</para>
        /// </description></item>
        /// <item><description><para>Critical: Critical issues were found.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("Severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        /// <summary>
        /// <para>The start of the diagnostic time range. This value corresponds to the <c>StartTime</c> parameter you provided when calling the <a href="https://help.aliyun.com/document_detail/442490.html">CreateDiagnosticReport</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-11T12:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The status of the diagnostic report. Possible values:</para>
        /// <list type="bullet">
        /// <item><description><para>InProgress: The diagnosis is in progress.</para>
        /// </description></item>
        /// <item><description><para>Finished: The diagnosis is complete.</para>
        /// </description></item>
        /// <item><description><para>Failed: The diagnosis failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Finished</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
