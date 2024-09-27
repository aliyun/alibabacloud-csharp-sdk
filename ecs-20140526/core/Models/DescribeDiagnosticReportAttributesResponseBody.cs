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
        /// <para>{
        ///     &quot;OfflineDiagReportStatus&quot;:&quot;CONFIRMED&quot;
        /// }</para>
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
        /// <para>The end of the reporting period of the diagnostic report. The value is the EndTime value that was passed in when you called the <a href="https://help.aliyun.com/document_detail/442490.html">CreateDiagnosticReport</a> operation to create the diagnostic report.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-11T14:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The time when the diagnostic report was complete.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-11T14:00:00Z</para>
        /// </summary>
        [NameInMap("FinishedTime")]
        [Validation(Required=false)]
        public string FinishedTime { get; set; }

        /// <summary>
        /// <para>The results of all diagnostic metrics in the diagnostic metric set.</para>
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
                /// <para>The diagnosed issues.</para>
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
                        /// <para>The additional data about the diagnosed issue. The value is a JSON string.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{
                        ///   &quot;TotalPercent&quot;: 95,
                        ///   &quot;TopUtilizationProcesses&quot;: [
                        ///     {
                        ///       &quot;Pid&quot;: &quot;1223&quot;,
                        ///       &quot;CommandName&quot;: &quot;/usr/bin/mem.py&quot;,
                        ///       &quot;PhysicalMemoryPercent&quot;: 50
                        ///     }
                        ///   ]
                        /// }</para>
                        /// </summary>
                        [NameInMap("Additional")]
                        [Validation(Required=false)]
                        public string Additional { get; set; }

                        /// <summary>
                        /// <para>The ID of the diagnosed issue, which is the unique identifier of the issue.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>GuestOS.CPU.HighUtiliz*****</para>
                        /// </summary>
                        [NameInMap("IssueId")]
                        [Validation(Required=false)]
                        public string IssueId { get; set; }

                        /// <summary>
                        /// <para>The time when the diagnosed issue occurred.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2022-07-11T14:00:00Z</para>
                        /// </summary>
                        [NameInMap("OccurrenceTime")]
                        [Validation(Required=false)]
                        public string OccurrenceTime { get; set; }

                        /// <summary>
                        /// <para>The severity level of the diagnosed issue. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>Info: Diagnostic information was recorded and may be related to exceptions.</description></item>
                        /// <item><description>Warn: Diagnostic information was recorded and may indicate potential exceptions.</description></item>
                        /// <item><description>Critical: Critical exceptions were detected.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Info</para>
                        /// </summary>
                        [NameInMap("Severity")]
                        [Validation(Required=false)]
                        public string Severity { get; set; }

                    }

                }

                /// <summary>
                /// <para>The category of the diagnostic metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CPU</para>
                /// </summary>
                [NameInMap("MetricCategory")]
                [Validation(Required=false)]
                public string MetricCategory { get; set; }

                /// <summary>
                /// <para>The ID of the diagnostic metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GuestOS.WinFirewall</para>
                /// </summary>
                [NameInMap("MetricId")]
                [Validation(Required=false)]
                public string MetricId { get; set; }

                /// <summary>
                /// <para>The severity level of the diagnostic metric. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Unknown: The diagnostic has not started, failed to run, or exited unexpectedly without a diagnosis.</description></item>
                /// <item><description>Normal: No exceptions were detected.</description></item>
                /// <item><description>Info: Diagnostic information was recorded and may be related to exceptions.</description></item>
                /// <item><description>NotSupport: The version of the guest operating system does support diagnosing the metric.</description></item>
                /// <item><description>Warn: Diagnostic information was recorded and may indicate potential exceptions.</description></item>
                /// <item><description>Critical: Critical exceptions were detected.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("Severity")]
                [Validation(Required=false)]
                public string Severity { get; set; }

                /// <summary>
                /// <para>The state of the diagnostic metric. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>InProgress.</description></item>
                /// <item><description>Finished.</description></item>
                /// <item><description>Failed.</description></item>
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
        /// <para>The ID of the diagnostic report, which is the unique identifier of the report.</para>
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
        /// <para>The type of the resource. ResourceType can only be set to instance, which indicates that only instances are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The severity level of the diagnostic report. The value of this parameter is determined by the highest severity level of all diagnostic metrics. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Unknown: The diagnostic has not started, failed to run, or exited unexpectedly without a diagnosis.</description></item>
        /// <item><description>Normal: No exceptions were detected.</description></item>
        /// <item><description>Info: Diagnostic information was recorded and may be related to exceptions.</description></item>
        /// <item><description>Warn: Diagnostic information was recorded and may indicate potential exceptions.</description></item>
        /// <item><description>Critical: Critical exceptions were detected.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("Severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        /// <summary>
        /// <para>The beginning of the reporting period of the diagnostic report. The value is the StartTime value that was passed in when you called the <a href="https://help.aliyun.com/document_detail/442490.html">CreateDiagnosticReport</a> operation to create the diagnostic report.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-11T12:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The state of the diagnostic report. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>InProgress: The diagnostic is in progress.</description></item>
        /// <item><description>Finished: The diagnostic is complete.</description></item>
        /// <item><description>Failed: The diagnostic failed.</description></item>
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
