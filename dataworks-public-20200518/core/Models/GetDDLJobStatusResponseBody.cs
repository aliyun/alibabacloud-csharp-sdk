// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetDDLJobStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the task.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDDLJobStatusResponseBodyData Data { get; set; }
        public class GetDDLJobStatusResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The content of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The ID of the ongoing task. If no value is returned for this parameter, all subtasks are complete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc1</para>
            /// </summary>
            [NameInMap("NextTaskId")]
            [Validation(Required=false)]
            public string NextTaskId { get; set; }

            /// <summary>
            /// <para>The status of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
