// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class CreateCopilotChatRequest : TeaModel {
        /// <summary>
        /// <para>The client conversation ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>54b6c969-4b75-47be-9f43-71f88aeb****</para>
        /// </summary>
        [NameInMap("ClientConversationId")]
        [Validation(Required=false)]
        public string ClientConversationId { get; set; }

        /// <summary>
        /// <para>The client message ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>366932fb-9a83-4a2d-94dd-c925b35f****</para>
        /// </summary>
        [NameInMap("ClientMessageId")]
        [Validation(Required=false)]
        public string ClientMessageId { get; set; }

        /// <summary>
        /// <para>The conversation ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>54b6c969-4b75-47be-9f43-71f88aeb****</para>
        /// </summary>
        [NameInMap("ConversationId")]
        [Validation(Required=false)]
        public string ConversationId { get; set; }

        /// <summary>
        /// <para>The conversation creation configuration.</para>
        /// </summary>
        [NameInMap("CreateConversation")]
        [Validation(Required=false)]
        public CreateCopilotChatRequestCreateConversation CreateConversation { get; set; }
        public class CreateCopilotChatRequestCreateConversation : TeaModel {
            /// <summary>
            /// <para>The model identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen3.7-max</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <para>The planning configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("PlanMode")]
            [Validation(Required=false)]
            public string PlanMode { get; set; }

            /// <summary>
            /// <para>The security project ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>project-incident-****</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <para>The deep thinking configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("ThinkingMode")]
            [Validation(Required=false)]
            public string ThinkingMode { get; set; }

            /// <summary>
            /// <para>The conversation title.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Security incident investigation</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>The language of the returned messages. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The list of messages.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Messages")]
        [Validation(Required=false)]
        public List<CreateCopilotChatRequestMessages> Messages { get; set; }
        public class CreateCopilotChatRequestMessages : TeaModel {
            /// <summary>
            /// <para>The message content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Investigate abnormal login activities in the last hour</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The message role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

        }

        /// <summary>
        /// <para>The model identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen3.7-max</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>The planning configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("PlanMode")]
        [Validation(Required=false)]
        public string PlanMode { get; set; }

        /// <summary>
        /// <para>The security project ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>project-incident-****</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The region of the data management center for threat analysis. Specify the management center based on the region where your assets reside. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: Your assets reside in the Chinese mainland.</description></item>
        /// <item><description>ap-southeast-1: Your assets reside in regions outside the Chinese mainland.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the conversation turn to replace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dc18b894-19a3-45ee-8768-a59478e0****</para>
        /// </summary>
        [NameInMap("ReplaceTurnId")]
        [Validation(Required=false)]
        public string ReplaceTurnId { get; set; }

        /// <summary>
        /// <para>The route target identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>security-agent-route-****</para>
        /// </summary>
        [NameInMap("RouteTarget")]
        [Validation(Required=false)]
        public string RouteTarget { get; set; }

        /// <summary>
        /// <para>The request source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>console</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable streaming responses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Stream")]
        [Validation(Required=false)]
        public bool? Stream { get; set; }

        /// <summary>
        /// <para>The deep thinking configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("ThinkingMode")]
        [Validation(Required=false)]
        public string ThinkingMode { get; set; }

        /// <summary>
        /// <para>The trace ID, which is used to query specific call information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>550e8400e29b41d4a71644665544****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
