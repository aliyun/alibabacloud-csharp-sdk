// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeInspectionTaskReportResponseBody : TeaModel {
        /// <summary>
        /// <para>The task report.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeInspectionTaskReportResponseBodyData Data { get; set; }
        public class DescribeInspectionTaskReportResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of associated instance IDs.</para>
            /// </summary>
            [NameInMap("InstanceIds")]
            [Validation(Required=false)]
            public List<string> InstanceIds { get; set; }

            /// <summary>
            /// <para>The Markdown text of the report details.</para>
            /// 
            /// <b>Example:</b>
            /// <h1>Tair Intelligent Inspection Report\n\n## Overview..</h1>
            /// </summary>
            [NameInMap("MarkdownText")]
            [Validation(Required=false)]
            public string MarkdownText { get; set; }

            /// <summary>
            /// <para>The report language.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zh-CN</para>
            /// </summary>
            [NameInMap("ReportLanguage")]
            [Validation(Required=false)]
            public string ReportLanguage { get; set; }

            /// <summary>
            /// <para>The task status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCEEDED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The summary.</para>
            /// </summary>
            [NameInMap("Summary")]
            [Validation(Required=false)]
            public DescribeInspectionTaskReportResponseBodyDataSummary Summary { get; set; }
            public class DescribeInspectionTaskReportResponseBodyDataSummary : TeaModel {
                /// <summary>
                /// <para>The number of high-risk items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Error")]
                [Validation(Required=false)]
                public long? Error { get; set; }

                /// <summary>
                /// <para>The number of failed items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Failed")]
                [Validation(Required=false)]
                public long? Failed { get; set; }

                /// <summary>
                /// <para>The number of normal items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Normal")]
                [Validation(Required=false)]
                public long? Normal { get; set; }

                /// <summary>
                /// <para>The number of warning items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Warning")]
                [Validation(Required=false)]
                public long? Warning { get; set; }

            }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tit-dca42f85c73644e0ab5c80ef6412xxx</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>561AFBF1-BE20-44DB-9BD1-6988B53E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
