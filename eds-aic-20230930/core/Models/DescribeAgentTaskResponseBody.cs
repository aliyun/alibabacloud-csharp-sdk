// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeAgentTaskResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>310A783E-CC46-5452-A8A3-71AE5DB5****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<DescribeAgentTaskResponseBodyTasks> Tasks { get; set; }
        public class DescribeAgentTaskResponseBodyTasks : TeaModel {
            [NameInMap("CurrentStatus")]
            [Validation(Required=false)]
            public string CurrentStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>acp-anzzuho371azi44xr</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("RunningAt")]
            [Validation(Required=false)]
            public string RunningAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Steps")]
            [Validation(Required=false)]
            public string Steps { get; set; }

            [NameInMap("TaskDuration")]
            [Validation(Required=false)]
            public string TaskDuration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>t-imr0fufqd7cle****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("TaskResult")]
            [Validation(Required=false)]
            public string TaskResult { get; set; }

            [NameInMap("UserPrompt")]
            [Validation(Required=false)]
            public string UserPrompt { get; set; }

        }

    }

}
