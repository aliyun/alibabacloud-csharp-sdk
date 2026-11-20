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
            /// <para>File.xlsx</para>
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
        /// <para>The MESSAGE commands. A skill command must include <c>payload.skillId</c>. A compact command must be sent separately without a body or attachments.</para>
        /// </summary>
        [NameInMap("commands")]
        [Validation(Required=false)]
        public List<SendMessageRequestCommands> Commands { get; set; }
        public class SendMessageRequestCommands : TeaModel {
            /// <summary>
            /// <para>The parameter object corresponding to the command type. For a skill command, you must specify the skill to be executed by using <c>skillId</c>. The <c>name</c> parameter is optional and is used only to save a snapshot of the display name. It is not used for execution or authorization checks. For a compact command, omit this object.</para>
            /// </summary>
            [NameInMap("payload")]
            [Validation(Required=false)]
            public SendMessageRequestCommandsPayload Payload { get; set; }
            public class SendMessageRequestCommandsPayload : TeaModel {
                /// <summary>
                /// <para>The skill name snapshot.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Intelligent analysis</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The skill ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>agentcore_example</para>
                /// </summary>
                [NameInMap("skillId")]
                [Validation(Required=false)]
                public string SkillId { get; set; }

            }

            /// <summary>
            /// <para>The command type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>skill</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

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
        /// <para>The list of interrupt replies. This parameter is required when <c>type</c> is set to <c>RESUME</c>. You must reply to all pending interrupts at once. Each <c>interruptId</c> can appear only once.</para>
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
            /// <para>The interrupt processing result. This parameter is required when <c>status</c> is set to <c>resolved</c> and must conform to the <c>responseSchema</c> of the corresponding interrupt. Do not provide this parameter when <c>status</c> is set to <c>cancelled</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;region&quot;:&quot;cn-hangzhou&quot;}</para>
            /// </summary>
            [NameInMap("payload")]
            [Validation(Required=false)]
            public object Payload { get; set; }

            /// <summary>
            /// <para>The reply method for the current interrupt. A value of <c>resolved</c> indicates that the answer, confirmation, or tool result required by the interrupt is submitted, and <c>payload</c> must be provided. A value of <c>cancelled</c> indicates that the interrupt is canceled, and <c>payload</c> is not provided.</para>
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
