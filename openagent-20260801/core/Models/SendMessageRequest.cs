// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenAgent20260801.Models
{
    public class SendMessageRequest : TeaModel {
        /// <summary>
        /// <para>The list of attachments.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("attachments")]
        [Validation(Required=false)]
        public List<SendMessageRequestAttachments> Attachments { get; set; }
        public class SendMessageRequestAttachments : TeaModel {
            /// <summary>
            /// <para>The file name extension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xlsx</para>
            /// </summary>
            [NameInMap("fileExtension")]
            [Validation(Required=false)]
            public string FileExtension { get; set; }

            /// <summary>
            /// <para>The ID of the file after it is uploaded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>att_12345678</para>
            /// </summary>
            [NameInMap("fileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <para>The original name of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>file.xlsx</para>
            /// </summary>
            [NameInMap("sourceName")]
            [Validation(Required=false)]
            public string SourceName { get; set; }

            /// <summary>
            /// <para>The workspace path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>source/att_12345678.xlsx</para>
            /// </summary>
            [NameInMap("workspacePath")]
            [Validation(Required=false)]
            public string WorkspacePath { get; set; }

        }

        /// <summary>
        /// <para>The message text in MESSAGE mode. This parameter cannot be empty. The type parameter can be omitted in this mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Query the status of the sample resource without making changes</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The list of interrupt replies. This parameter is required when type is set to RESUME. You must reply to all pending interrupts at once. Each interruptId can appear only once.</para>
        /// </summary>
        [NameInMap("resume")]
        [Validation(Required=false)]
        public List<SendMessageRequestResume> Resume { get; set; }
        public class SendMessageRequestResume : TeaModel {
            /// <summary>
            /// <para>The ID of the interrupt to be replied to. Obtain this value from data.outcome.interrupts[].id in the SSE RUN_FINISHED event or the GetRun response.</para>
            /// 
            /// <b>Example:</b>
            /// <para>interrupt_example_001</para>
            /// </summary>
            [NameInMap("interruptId")]
            [Validation(Required=false)]
            public string InterruptId { get; set; }

            /// <summary>
            /// <para>The interrupt handling result. This parameter is required when status is set to resolved and must conform to the responseSchema of the corresponding interrupt. Do not pass this parameter when status is set to cancelled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;region&quot;:&quot;cn-hangzhou&quot;}</para>
            /// </summary>
            [NameInMap("payload")]
            [Validation(Required=false)]
            public object Payload { get; set; }

            /// <summary>
            /// <para>The reply method for the interrupt. Valid values: resolved (submits the answer, confirmation, or tool result required by the interrupt, and must include payload) and cancelled (cancels the interrupt without passing payload).</para>
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
        /// <para>The request type. Valid values: MESSAGE (sends a message), RESUME (resumes a run), and RECONNECT (reconnects to a run). Default value: MESSAGE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MESSAGE</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
