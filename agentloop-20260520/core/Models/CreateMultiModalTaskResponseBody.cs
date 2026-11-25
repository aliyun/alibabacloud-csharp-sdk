// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class CreateMultiModalTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The evaluation message. It is the description returned by the backend upon success, or the customer-visible error message upon failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The image is complete and the inspection is passed</para>
        /// </summary>
        [NameInMap("msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <para>The score, ranging from 0 to 1. It is null when the evaluation fails. If the backend returns a percentage score greater than 1, it is converted to score/100 and rounded to a maximum of 4 decimal places.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("score")]
        [Validation(Required=false)]
        public float? Score { get; set; }

        /// <summary>
        /// <para>The task ID, in the format of eval-task-&lt;32hex&gt;. It can be used for tracing in the console or query API. It is null if the failure occurs before the task is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eval-task-0123456789abcdef0123456789abcdef</para>
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The task name used for this call. It is also returned upon failure if the request body has been parsed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agentloop-media-process</para>
        /// </summary>
        [NameInMap("taskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
