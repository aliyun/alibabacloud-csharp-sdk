// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentTeams20260605.Models
{
    public class UpdateInstanceAsyncTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code in the success response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The details of the asynchronous task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateInstanceAsyncTaskResponseBodyData Data { get; set; }
        public class UpdateInstanceAsyncTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The time when the task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-06-01T12:00:00Z</para>
            /// </summary>
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The current step.</para>
            /// 
            /// <b>Example:</b>
            /// <para>create-cms-workspace</para>
            /// </summary>
            [NameInMap("CurrentStep")]
            [Validation(Required=false)]
            public string CurrentStep { get; set; }

            /// <summary>
            /// <para>The time when the task was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-06-01T12:05:00Z</para>
            /// </summary>
            [NameInMap("ModifiedAt")]
            [Validation(Required=false)]
            public string ModifiedAt { get; set; }

            /// <summary>
            /// <para>The asynchronous task code. Only \&quot;agentteams:pay-order:create\&quot; is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>agentteams:pay-order:create: create instance task.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>agentteams:pay-order:create</para>
            /// </summary>
            [NameInMap("TaskCode")]
            [Validation(Required=false)]
            public string TaskCode { get; set; }

            /// <summary>
            /// <para>The asynchronous task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task-xxx</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The asynchronous task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PENDING: pending.</description></item>
            /// <item><description>RUNNING: running.</description></item>
            /// <item><description>PAUSED: paused.</description></item>
            /// <item><description>COMPLETED: completed.</description></item>
            /// <item><description>FAILED: failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether the task is waiting for user action.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("WaitingForUserAction")]
            [Validation(Required=false)]
            public bool? WaitingForUserAction { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para><b>message</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para><b>requestId</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>req-xxx</para>
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
