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
        /// <para>The event output mode. Valid values: inline and separate. Default value: inline. When set to inline, tool invoke events, child node events, and document events are unified into the answer field of the event where event = message. When set to separate, tool invoke events, child node events, and document events have their own respective events.</para>
        /// 
        /// <b>Example:</b>
        /// <para>inline</para>
        /// </summary>
        [NameInMap("EventMode")]
        [Validation(Required=false)]
        public string EventMode { get; set; }

        /// <summary>
        /// <para>The list of attachments included in the current conversation round. References uploaded files by using UploadFileId.</para>
        /// </summary>
        [NameInMap("Files")]
        [Validation(Required=false)]
        public List<ChatMessagesRequestFiles> Files { get; set; }
        public class ChatMessagesRequestFiles : TeaModel {
            /// <summary>
            /// <para>The file transfer method. Set this parameter to local_file and provide the UploadFileId when referencing an uploaded file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>local_file</para>
            /// </summary>
            [NameInMap("TransferMethod")]
            [Validation(Required=false)]
            public string TransferMethod { get; set; }

            /// <summary>
            /// <para>The attachment type. A value of image indicates an image. The actual supported types are determined by the file upload configuration of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>image</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The identifier of the uploaded file. The ContextDB management agent can use the UploadFileId returned by the knowledge base of the current workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00000000-0000-4000-8000-000000000001</para>
            /// </summary>
            [NameInMap("UploadFileId")]
            [Validation(Required=false)]
            public string UploadFileId { get; set; }

            /// <summary>
            /// <para>The image URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://other-general-huadong1.oss-cn-hangzhou.aliyuncs.com/uploadWidget/BirthCertification_0.jpeg">https://other-general-huadong1.oss-cn-hangzhou.aliyuncs.com/uploadWidget/BirthCertification_0.jpeg</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>The task input.</para>
        /// </summary>
        [NameInMap("Inputs")]
        [Validation(Required=false)]
        public ChatMessagesRequestInputs Inputs { get; set; }
        public class ChatMessagesRequestInputs : TeaModel {
            /// <summary>
            /// <para>The custom agent ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d1b7d639-f34e-44c7-8231-987da14d****</para>
            /// </summary>
            [NameInMap("CustomAgentId")]
            [Validation(Required=false)]
            public string CustomAgentId { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the deep thinking mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableThinking")]
            [Validation(Required=false)]
            public string EnableThinking { get; set; }

            /// <summary>
            /// <para>The IM flow ID. Used to bind messages to a registered IM channel when a conversation is initiated through an IM channel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>flow-xxxxxxxxxx</para>
            /// </summary>
            [NameInMap("FlowId")]
            [Validation(Required=false)]
            public string FlowId { get; set; }

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
            /// <para>The tool approval call ID for resuming execution. Pass this parameter after the console completes all decisions for the current approval round to continue the interrupted ChatMessage loop. Do not pass this parameter for normal conversations.</para>
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
            /// <para>Specifies the tool approval mode for the current conversation. Valid values: read_only (read-only, rejects write tools), manual (write tools require manual approval), and auto (automatically determined by the approval sub-agent; escalated to manual approval when needs_human is returned). If specified, updates the approval mode of the current conversation.</para>
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
        /// <para>Disk usage of instance rm-bp14as9914vd3****, and whether it needs to be scaled up</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

    }

}
