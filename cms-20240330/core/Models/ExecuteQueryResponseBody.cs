// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ExecuteQueryResponseBody : TeaModel {
        /// <summary>
        /// <para>The log data array. Each element corresponds to a log entry.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<Dictionary<string, string>> Data { get; set; }

        /// <summary>
        /// <para>The metadata.</para>
        /// </summary>
        [NameInMap("meta")]
        [Validation(Required=false)]
        public ExecuteQueryResponseBodyMeta Meta { get; set; }
        public class ExecuteQueryResponseBodyMeta : TeaModel {
            /// <summary>
            /// <para>The number of log entries scanned or processed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("affectedRows")]
            [Validation(Required=false)]
            public int? AffectedRows { get; set; }

            /// <summary>
            /// <para>The number of log entries returned by the query request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The execution duration in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1231243</para>
            /// </summary>
            [NameInMap("elapsedMillisecond")]
            [Validation(Required=false)]
            public long? ElapsedMillisecond { get; set; }

            /// <summary>
            /// <para>Indicates whether the query results are complete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Complete</para>
            /// </summary>
            [NameInMap("progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3B311FD9-A60B-55E0-A896-A0C73*********</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
