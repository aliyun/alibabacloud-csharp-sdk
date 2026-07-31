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
        /// <para>The end time. This parameter was specified when you called the <a href="https://help.aliyun.com/document_detail/442490.html">CreateDiagnosticReport</a> operation to create the diagnostic report.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-11T14:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The time when the diagnostic report was completed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-11T14:00:00Z</para>
        /// </summary>
        [NameInMap("FinishedTime")]
        [Validation(Required=false)]
        public string FinishedTime { get; set; }

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
        /// <para>The ID of the diagnostic metric set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dms-bp17p0qwtr72zmu*****</para>
        /// </summary>
        [NameInMap("MetricSetId")]
        [Validation(Required=false)]
        public string MetricSetId { get; set; }

        /// <summary>
        /// <para>The diagnostic report ID. The unique identifier of the resource diagnostic report.</para>
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
        /// <para>The resource type. The supported type is instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The severity level of the report. This value represents the most severe level among all metrics. The severity levels in ascending order are:</para>
        /// <list type="bullet">
        /// <item><description>Unknown: The initial state, which indicates that the diagnosis has not started or the diagnosis process exited abnormally. No diagnostic conclusion is available.</description></item>
        /// <item><description>Normal: The diagnosis is normal. No issues were found.</description></item>
        /// <item><description>Info: Related information is available and may be associated with an exception.</description></item>
        /// <item><description>Warn: Related information is available and may cause an exception.</description></item>
        /// <item><description>Critical: A critical exception exists.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("Severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        /// <summary>
        /// <para>The start time. This parameter was specified when you called the <a href="https://help.aliyun.com/document_detail/442490.html">CreateDiagnosticReport</a> operation to create the diagnostic report.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-11T12:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The status of the diagnostic report. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>InProgress: The diagnosis is in progress.</description></item>
        /// <item><description>Finished: The diagnosis is complete.</description></item>
        /// <item><description>Failed: The diagnosis failed.</description></item>
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
