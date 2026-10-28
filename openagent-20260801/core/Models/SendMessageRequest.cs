// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenAgent20260801.Models
{
    public class SendMessageRequest : TeaModel {
        /// <summary>
        /// <para>The message text in MESSAGE mode. This parameter cannot be empty. The type can be omitted in this mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Query the status of the sample resource without making any changes</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The list of interrupt replies. This parameter is required when <c>type</c> is set to <c>RESUME</c>. You must reply to all pending interrupts at once, and each <c>interruptId</c> can appear only once.</para>
        /// </summary>
        [NameInMap("resume")]
        [Validation(Required=false)]
        public List<SendMessageRequestResume> Resume { get; set; }
        public class SendMessageRequestResume : TeaModel {
            /// <summary>
            /// <para>The ID of the interrupt to be replied to. Obtain this value from <c>data.outcome.interrupts[].id</c> in the SSE <c>RUN_FINISHED</c> event or <c>data.outcome.interrupts[].id</c> in the <c>GetRun</c> response.</para>
            /// 
            /// <b>Example:</b>
            /// <para>interrupt_example_001</para>
            /// </summary>
            [NameInMap("interruptId")]
            [Validation(Required=false)]
            public string InterruptId { get; set; }

            /// <summary>
            /// <para>The interrupt handling result. This parameter is required when <c>status</c> is set to <c>resolved</c> and must conform to the <c>responseSchema</c> of the corresponding interrupt. Do not pass this parameter when <c>status</c> is set to <c>cancelled</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;region&quot;:&quot;cn-hangzhou&quot;}</para>
            /// </summary>
            [NameInMap("payload")]
            [Validation(Required=false)]
            public object Payload { get; set; }

            /// <summary>
            /// <para>The reply method for the current interrupt. <c>resolved</c> indicates that the answer, confirmation, or tool result required by the interrupt is submitted, and <c>payload</c> must be provided. <c>cancelled</c> indicates that the interrupt is canceled, and <c>payload</c> is not passed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>resolved</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The ID of the active run to resubscribe to. This parameter is required in RECONNECT mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>run_example_001</para>
        /// </summary>
        [NameInMap("runId")]
        [Validation(Required=false)]
        public string RunId { get; set; }

        /// <summary>
        /// <para>The request type. Valid values: <c>MESSAGE</c> (sends a message), <c>RESUME</c> (resumes a run), and <c>RECONNECT</c> (reconnects to a run). Default value: <c>MESSAGE</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MESSAGE</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
