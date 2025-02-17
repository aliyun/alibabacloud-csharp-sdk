// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDiagnosticReportsResponseBody : TeaModel {
        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The diagnostic reports.</para>
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
                /// <para>The time when the diagnostic report was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-07-11T12:00:00Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The end of the time range during which data was queried. The value is the EndTime value that was passed in when you called the <a href="https://help.aliyun.com/document_detail/442490.html">CreateDiagnosticReport</a> operation to create the diagnostic report.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-07-11T14:00:00Z</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The time when the diagnostic was complete.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-07-11T14:00:00Z</para>
                /// </summary>
                [NameInMap("FinishedTime")]
                [Validation(Required=false)]
                public string FinishedTime { get; set; }

                /// <summary>
                /// <para>The diagnosed issues.</para>
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
                        /// <para>The ID of the diagnosed issue, which is the unique identifier of the issue.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>GuestOS.CPU.HighUtiliz*****</para>
                        /// </summary>
                        [NameInMap("IssueId")]
                        [Validation(Required=false)]
                        public string IssueId { get; set; }

                        /// <summary>
                        /// <para>The category of the diagnostic metric.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ECSService.GuestOS</para>
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
                        /// <item><description>Info: Diagnostic information was recorded and may be related to exceptions.</description></item>
                        /// <item><description>Warn: Diagnostic information was recorded and may indicate exceptions.</description></item>
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
                /// <para>The ID of the diagnostic metric set.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dms-bp17p0qwtr72zmu*****</para>
                /// </summary>
                [NameInMap("MetricSetId")]
                [Validation(Required=false)]
                public string MetricSetId { get; set; }

                /// <summary>
                /// <para>The ID of the diagnostic report.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dr-uf6i0tv2refv8wz*****</para>
                /// </summary>
                [NameInMap("ReportId")]
                [Validation(Required=false)]
                public string ReportId { get; set; }

                /// <summary>
                /// <para>The ID of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-uf6i0tv2refv8wz*****</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The type of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>instance</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <para>The severity level of the diagnostic report. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Unknown: The diagnostic did not start, failed to run, or unexpectedly exited without a diagnosis.</description></item>
                /// <item><description>Normal: No exceptions were detected.</description></item>
                /// <item><description>Info: Diagnostic information was recorded and may be related to exceptions.</description></item>
                /// <item><description>Warn: Diagnostic information was recorded and may indicate exceptions.</description></item>
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
                /// <para>The beginning of the time range during which data was queried. The value is the StartTime value that was passed in when you called the <a href="https://help.aliyun.com/document_detail/442490.html">CreateDiagnosticReport</a> operation to create the diagnostic report.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-07-11T12:00:00Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The status of the diagnostic report.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
