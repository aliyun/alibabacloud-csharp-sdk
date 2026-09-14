// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeDiagnoseReportResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination token returned in this call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f07b150eadfa1d7a</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The list of diagnostic reports.</para>
        /// </summary>
        [NameInMap("Reports")]
        [Validation(Required=false)]
        public List<DescribeDiagnoseReportResponseBodyReports> Reports { get; set; }
        public class DescribeDiagnoseReportResponseBodyReports : TeaModel {
            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>196380451****</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The time when the diagnostic report was created, in Unix/POSIX timestamp (seconds).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1727239294</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public long? CreationTime { get; set; }

            /// <summary>
            /// <para>The end timestamp of the resource diagnosis.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1727239294</para>
            /// </summary>
            [NameInMap("DiagnoseEndTime")]
            [Validation(Required=false)]
            public long? DiagnoseEndTime { get; set; }

            /// <summary>
            /// <para>The start timestamp of the resource diagnosis.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1727229294</para>
            /// </summary>
            [NameInMap("DiagnoseStartTime")]
            [Validation(Required=false)]
            public long? DiagnoseStartTime { get; set; }

            /// <summary>
            /// <para>The type of diagnosis.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Performance</para>
            /// </summary>
            [NameInMap("DiagnoseType")]
            [Validation(Required=false)]
            public string DiagnoseType { get; set; }

            /// <summary>
            /// <para>The list of diagnosed issues.</para>
            /// </summary>
            [NameInMap("Events")]
            [Validation(Required=false)]
            public List<DescribeDiagnoseReportResponseBodyReportsEvents> Events { get; set; }
            public class DescribeDiagnoseReportResponseBodyReportsEvents : TeaModel {
                /// <summary>
                /// <para>The event description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The issue name. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NoSnapshot: data protection</description></item>
                /// <item><description>BurstIOTriggered: I/O burst</description></item>
                /// <item><description>CostOptimizationNeeded: cost optimization</description></item>
                /// <item><description>DiskSpecNotMatchedWithInstance: instance and cloud disk specification mismatch</description></item>
                /// <item><description>DiskIONo4kAligned: non-4K-aligned read/write</description></item>
                /// <item><description>DiskIOHang: IOHang occurred on the cloud disk</description></item>
                /// <item><description>InstanceIOPSExceedInstanceMaxLimit: instance IOPS reached the upper limit</description></item>
                /// <item><description>InstanceBPSExceedInstanceMaxLimit: instance BPS reached the upper limit</description></item>
                /// <item><description>DiskIOPSExceedInstanceMaxLimit: cloud disk IOPS reached the instance upper limit</description></item>
                /// <item><description>DiskBPSExceedInstanceMaxLimit: cloud disk BPS reached the instance upper limit</description></item>
                /// <item><description>DiskIOPSExceedDiskMaxLimit: cloud disk IOPS reached the cloud disk upper limit</description></item>
                /// <item><description>DiskBPSExceedDiskMaxLimit: cloud disk BPS reached the cloud disk upper limit</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DiskIOPSExceedDiskMaxLimit</para>
                /// </summary>
                [NameInMap("EventName")]
                [Validation(Required=false)]
                public string EventName { get; set; }

                /// <summary>
                /// <para>The recommended action after the event occurs. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ModifyDiskSpec: change cloud disk specifications</description></item>
                /// <item><description>CreateSnapshot: create a snapshot</description></item>
                /// <item><description>ResizeDisk: expand the cloud disk</description></item>
                /// <item><description>AdjustProvision: adjust provisioned performance</description></item>
                /// <item><description>ModifyInstanceSpec: change instance specifications</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ResizeDisk</para>
                /// </summary>
                [NameInMap("RecommendAction")]
                [Validation(Required=false)]
                public string RecommendAction { get; set; }

                /// <summary>
                /// <para>The parameters for the recommended action after the event occurs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4096</para>
                /// </summary>
                [NameInMap("RecommendParams")]
                [Validation(Required=false)]
                public string RecommendParams { get; set; }

                /// <summary>
                /// <para>The severity level of the diagnosed issue. The severity levels in ascending order are:</para>
                /// <list type="bullet">
                /// <item><description>Info: Associated information that may be related to an anomaly.</description></item>
                /// <item><description>Warn: Associated information that may cause an anomaly.</description></item>
                /// <item><description>Critical: A critical anomaly exists.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Warn</para>
                /// </summary>
                [NameInMap("Severity")]
                [Validation(Required=false)]
                public string Severity { get; set; }

                /// <summary>
                /// <para>The start timestamp of the event, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1755756214000</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

            }

            /// <summary>
            /// <para>The time when the diagnostic report was completed, in Unix/POSIX timestamp (seconds).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1727239295</para>
            /// </summary>
            [NameInMap("FinishedTime")]
            [Validation(Required=false)]
            public long? FinishedTime { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-zhangjiakou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The diagnostic report ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>report-sag8d****</para>
            /// </summary>
            [NameInMap("ReportId")]
            [Validation(Required=false)]
            public string ReportId { get; set; }

            /// <summary>
            /// <para>The resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d-wz95ycu****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The resource type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Disk</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Disk</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The severity level of the diagnosis. The severity levels in ascending order are:</para>
            /// <list type="bullet">
            /// <item><description>Info: Associated information that may be related to an anomaly.</description></item>
            /// <item><description>Warn: Associated information that may cause an anomaly.</description></item>
            /// <item><description>Critical: A critical anomaly exists.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Warn</para>
            /// </summary>
            [NameInMap("Severity")]
            [Validation(Required=false)]
            public string Severity { get; set; }

            /// <summary>
            /// <para>The status of the diagnostic report. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Running</description></item>
            /// <item><description>Success</description></item>
            /// <item><description>TimeOut</description></item>
            /// <item><description>Fail</description></item>
            /// </list>
            /// <para>The Severity and Events fields are valid only when Status is set to Success.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAA478A0-BEE6-1D42-BEB6-A9CFEAD6****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
