// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class PauseAgentTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E38B41A8-8E00-5AE4-A957-6636ACB8****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<PauseAgentTaskResponseBodyTasks> Tasks { get; set; }
        public class PauseAgentTaskResponseBodyTasks : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>PAUSING</para>
            /// </summary>
            [NameInMap("CurrentStatus")]
            [Validation(Required=false)]
            public string CurrentStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Task status [COMPLETED] does not support pause, only RUNNING tasks can be paused.</para>
            /// </summary>
            [NameInMap("FailedReason")]
            [Validation(Required=false)]
            public string FailedReason { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>acp-anzzuho371azi44xr</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-04-13T17:42:19Z</para>
            /// </summary>
            [NameInMap("PausingAt")]
            [Validation(Required=false)]
            public string PausingAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("PreviousStatus")]
            [Validation(Required=false)]
            public string PreviousStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>t-imr0fufqd7cle****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

    }

}
