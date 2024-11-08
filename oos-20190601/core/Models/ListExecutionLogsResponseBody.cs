// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListExecutionLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The logs of the execution.</para>
        /// </summary>
        [NameInMap("ExecutionLogs")]
        [Validation(Required=false)]
        public List<ListExecutionLogsResponseBodyExecutionLogs> ExecutionLogs { get; set; }
        public class ListExecutionLogsResponseBodyExecutionLogs : TeaModel {
            /// <summary>
            /// <para>The log type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>System</para>
            /// </summary>
            [NameInMap("LogType")]
            [Validation(Required=false)]
            public string LogType { get; set; }

            /// <summary>
            /// <para>The details of the task execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The task CheckDiskCategory completed.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The task execution ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exec-1234567zxcvb.t0010</para>
            /// </summary>
            [NameInMap("TaskExecutionId")]
            [Validation(Required=false)]
            public string TaskExecutionId { get; set; }

            /// <summary>
            /// <para>The timestamp when the task was run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-05-24T:02:29:07Z</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the log is truncated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gAAAAABdpsGWjX8dJ-a6dl_pvoS7AFxNHSNJKHLCAJJ0ylgA53nWW5V4HTEZKCYTaEPNOrxFir4z43UTOjE150cFr8AGTifA==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14A07460-EBE7-47CA-9757-12CC4761D47A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
