// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeEcdReportTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The report export tasks.</para>
        /// </summary>
        [NameInMap("ExportTaskList")]
        [Validation(Required=false)]
        public List<DescribeEcdReportTasksResponseBodyExportTaskList> ExportTaskList { get; set; }
        public class DescribeEcdReportTasksResponseBodyExportTaskList : TeaModel {
            /// <summary>
            /// <para>The download URL of the report file.</para>
            /// </summary>
            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            /// <summary>
            /// <para>The error code returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>No Data.</para>
            /// </summary>
            [NameInMap("ErrorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            /// <summary>
            /// <para>The time when the task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-07-14T07:46:49.000+00:00</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the task was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-07-14T07:46:49.000+00:00</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The progress of the report export task. Unit: %.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public float? Progress { get; set; }

            /// <summary>
            /// <para>The name of the report file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestFileName</para>
            /// </summary>
            [NameInMap("ReportFileName")]
            [Validation(Required=false)]
            public string ReportFileName { get; set; }

            /// <summary>
            /// <para>The task status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The sub-type of the report export task.</para>
            /// <para>Valid value:</para>
            /// <list type="bullet">
            /// <item><description>DESKTOP: cloud computer</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DESKTOP</para>
            /// </summary>
            [NameInMap("SubType")]
            [Validation(Required=false)]
            public string SubType { get; set; }

            /// <summary>
            /// <para>The ID of the report export task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ret-asdfkjg*****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The type of the report.</para>
            /// <para>Valid value:</para>
            /// <list type="bullet">
            /// <item><description>RESOURCE_REPORT</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RESOURCE_REPORT</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
