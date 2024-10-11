// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class ListInstanceTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InternalServerError</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>An internal server error occurred</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8F81A922-6C81-46D6-B78C-CC35E16B1691</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The progress of the task that is running on the instance.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListInstanceTaskResponseBodyResult> Result { get; set; }
        public class ListInstanceTaskResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The name of the step. Example: DATA_IMPORT. The value indicates that data is being imported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DATA_IMPORT</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The information about the progress of subtasks.</para>
            /// </summary>
            [NameInMap("subProgressInfos")]
            [Validation(Required=false)]
            public List<ListInstanceTaskResponseBodyResultSubProgressInfos> SubProgressInfos { get; set; }
            public class ListInstanceTaskResponseBodyResultSubProgressInfos : TeaModel {
                /// <summary>
                /// <para>The detailed description of subtasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>data import progress info</para>
                /// </summary>
                [NameInMap("detail")]
                [Validation(Required=false)]
                public string Detail { get; set; }

                /// <summary>
                /// <para>The number of completed subtasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("finishedNum")]
                [Validation(Required=false)]
                public int? FinishedNum { get; set; }

                /// <summary>
                /// <para>The progress of subtasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("progress")]
                [Validation(Required=false)]
                public int? Progress { get; set; }

                /// <summary>
                /// <para>The total number of subtasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("totalNum")]
                [Validation(Required=false)]
                public int? TotalNum { get; set; }

                /// <summary>
                /// <para>The type of subtasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DATA_PROCESS</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The overall progress of the current task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("totalProgress")]
            [Validation(Required=false)]
            public int? TotalProgress { get; set; }

        }

    }

}
