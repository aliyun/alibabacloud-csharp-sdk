// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ListClusterInspectReportsResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>405b99e5411f9a4e7148506e45</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The list of inspection reports.</para>
        /// </summary>
        [NameInMap("reports")]
        [Validation(Required=false)]
        public List<ListClusterInspectReportsResponseBodyReports> Reports { get; set; }
        public class ListClusterInspectReportsResponseBodyReports : TeaModel {
            /// <summary>
            /// <para>The report completion time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-12-18T19:40:16.778333+08:00</para>
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>An inspection report ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>782df89346054a0000562063a6****</para>
            /// </summary>
            [NameInMap("reportId")]
            [Validation(Required=false)]
            public string ReportId { get; set; }

            /// <summary>
            /// <para>The report start time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-12-18T19:40:16.778333+08:00</para>
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The inspection report status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>completed</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The inspection summary.</para>
            /// </summary>
            [NameInMap("summary")]
            [Validation(Required=false)]
            public ListClusterInspectReportsResponseBodyReportsSummary Summary { get; set; }
            public class ListClusterInspectReportsResponseBodyReportsSummary : TeaModel {
                /// <summary>
                /// <para>The number of items whose result is advice.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("adviceCount")]
                [Validation(Required=false)]
                public int? AdviceCount { get; set; }

                /// <summary>
                /// <para>Aggregated inspection task result code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>warning</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The number of items whose result is error.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("errorCount")]
                [Validation(Required=false)]
                public int? ErrorCount { get; set; }

                /// <summary>
                /// <para>The number of items whose result is normal.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("normalCount")]
                [Validation(Required=false)]
                public int? NormalCount { get; set; }

                /// <summary>
                /// <para>The number of items whose result is warning.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("warnCount")]
                [Validation(Required=false)]
                public int? WarnCount { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>49511F2D-D56A-5C24-B9AE-C8491E09B***</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
