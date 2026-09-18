// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AISC20260101.Models
{
    public class CreateTargetScanTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The creation result, which contains the TaskId of the new scan task.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateTargetScanTaskResponseBodyData Data { get; set; }
        public class CreateTargetScanTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The unique identifier of the scan task. The initial task status is PREPARING (asynchronous preparation in progress). You can call ListScanTasksByTarget to query the task status and progress.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task-abc123def4567</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The unique identifier of the request, which is used for troubleshooting and log tracing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1EBD0C05-6C1F-4C95-9C63-XXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
