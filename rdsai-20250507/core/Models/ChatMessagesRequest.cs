// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class ChatMessagesRequest : TeaModel {
        /// <summary>
        /// <para>The conversation ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fea7bdca-e848-44dd-b1ae-852472b8****</para>
        /// </summary>
        [NameInMap("ConversationId")]
        [Validation(Required=false)]
        public string ConversationId { get; set; }

        /// <summary>
        /// <para>The event output type. Valid values: inline and separate. Default value: inline. When set to inline, tool invocation events, sub-node events, and document events are included in the answer field of the event = message response. When set to separate, tool invocation events, sub-node events, and document events each have their own event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>inline</para>
        /// </summary>
        [NameInMap("EventMode")]
        [Validation(Required=false)]
        public string EventMode { get; set; }

        [NameInMap("Files")]
        [Validation(Required=false)]
        public List<ChatMessagesRequestFiles> Files { get; set; }
        public class ChatMessagesRequestFiles : TeaModel {
            [NameInMap("TransferMethod")]
            [Validation(Required=false)]
            public string TransferMethod { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("UploadFileId")]
            [Validation(Required=false)]
            public string UploadFileId { get; set; }

        }

        /// <summary>
        /// <para>The task inputs.</para>
        /// </summary>
        [NameInMap("Inputs")]
        [Validation(Required=false)]
        public ChatMessagesRequestInputs Inputs { get; set; }
        public class ChatMessagesRequestInputs : TeaModel {
            /// <summary>
            /// <para>The custom agent ID for the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d1b7d639-f34e-44c7-8231-987da14d****</para>
            /// </summary>
            [NameInMap("CustomAgentId")]
            [Validation(Required=false)]
            public string CustomAgentId { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable deep thinking mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableThinking")]
            [Validation(Required=false)]
            public string EnableThinking { get; set; }

            /// <summary>
            /// <para>The conversation language.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zh-cn</para>
            /// </summary>
            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            /// <summary>
            /// <para>The model ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen3.7-max</para>
            /// </summary>
            [NameInMap("ModelId")]
            [Validation(Required=false)]
            public string ModelId { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The tool approval call ID for resuming execution. Pass this parameter after all decisions in the current approval round are completed in the console to continue the interrupted ChatMessage Loop. Do not pass this parameter for regular conversations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>call-example</para>
            /// </summary>
            [NameInMap("ResumeCallId")]
            [Validation(Required=false)]
            public string ResumeCallId { get; set; }

            /// <summary>
            /// <para>The thinking depth.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("ThinkEffort")]
            [Validation(Required=false)]
            public string ThinkEffort { get; set; }

            /// <summary>
            /// <para>The time zone. Default value: <b>Asia/Shanghai</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>UTC</para>
            /// </summary>
            [NameInMap("Timezone")]
            [Validation(Required=false)]
            public string Timezone { get; set; }

            /// <summary>
            /// <para>The tool approval mode for the current conversation. Valid values: read_only (read-only, write tools are rejected), manual (write tools require manual approval), and auto (the approval sub-agent automatically determines the action. If the result is needs_human, the approval is escalated to manual review). When this parameter is passed, the approval mode of the current conversation is updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>manual</para>
            /// </summary>
            [NameInMap("ToolApprovalMode")]
            [Validation(Required=false)]
            public string ToolApprovalMode { get; set; }

            /// <summary>
            /// <para>The ContextDB workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00000000-0000-4000-8000-000000000001</para>
            /// </summary>
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <para>The parent message ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>84dc9f9b-424a-404d-9c36-35e9d000****</para>
        /// </summary>
        [NameInMap("ParentMessageId")]
        [Validation(Required=false)]
        public string ParentMessageId { get; set; }

        /// <summary>
        /// <para>The query content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Check the disk usage of instance rm-bp14as9914vd3**** and whether storage expansion is needed</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

    }

}
