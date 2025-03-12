// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class ListAsyncTaskResponseBody : TeaModel {
        [NameInMap("AsyncTasks")]
        [Validation(Required=false)]
        public List<ListAsyncTaskResponseBodyAsyncTasks> AsyncTasks { get; set; }
        public class ListAsyncTaskResponseBodyAsyncTasks : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1533866201000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1533866201000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;instanceId&quot;: &quot;ddoscoo-1234-qrq2134&quot;}</para>
            /// </summary>
            [NameInMap("TaskParams")]
            [Validation(Required=false)]
            public string TaskParams { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;instanceId&quot;: &quot;ddoscoo-1234-qrq2134&quot;, &quot;url&quot;: &quot;<a href="https://oss.xxx.xxx%22%7D">https://oss.xxx.xxx&quot;}</a></para>
            /// </summary>
            [NameInMap("TaskResult")]
            [Validation(Required=false)]
            public string TaskResult { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public int? TaskStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public int? TaskType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CF33B4C3-196E-4015-AADD-5CAD00057B80</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
