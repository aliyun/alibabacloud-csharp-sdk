// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class ListCommonLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the returned logs.</para>
        /// </summary>
        [NameInMap("Logs")]
        [Validation(Required=false)]
        public List<ListCommonLogsResponseBodyLogs> Logs { get; set; }
        public class ListCommonLogsResponseBodyLogs : TeaModel {
            /// <summary>
            /// <para>The name of the action corresponding to the log.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CreaterCluster</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ehpc-hz-9T3xPNezoS</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The log type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Operation</para>
            /// </summary>
            [NameInMap("LogType")]
            [Validation(Required=false)]
            public string LogType { get; set; }

            /// <summary>
            /// <para>The message of the log.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ok</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The ID of the user who performed the action.</para>
            /// 
            /// <b>Example:</b>
            /// <para>137***</para>
            /// </summary>
            [NameInMap("OperatorUid")]
            [Validation(Required=false)]
            public string OperatorUid { get; set; }

            /// <summary>
            /// <para>The request ID associated with the action that generated the log.</para>
            /// 
            /// <b>Example:</b>
            /// <para>04F0F334-1335-436C-A1D7-6C044FE7****</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <para>The action state in the log. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>InProgress: The action is being performed.</description></item>
            /// <item><description>Finished: The action is completed.</description></item>
            /// <item><description>Failed: The action failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Finished</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The involved resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-abc***</para>
            /// </summary>
            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            /// <summary>
            /// <para>The time when the log was generated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-08-22 14:21:54</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>464E9919-D04F-4D1D-B375-15989492****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>137***</para>
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

    }

}
