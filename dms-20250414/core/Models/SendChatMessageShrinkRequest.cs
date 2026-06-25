// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class SendChatMessageShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The agent ID. This is a required field. You can obtain the current AgentId from the return value of the CreateAgentSession operation. Agent resources have a lifecycle, so the AgentId you need to pass in each request may change.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent_***</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>The DMS unit you are currently in. If you choose to analyze a database, this information will be used to correctly connect to your DMS instance through DMS. You can go to the DMS console to check your current DMS unit. If you are a China site user of Alibaba Cloud, you can directly enter cn-hangzhou.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DMSUnit")]
        [Validation(Required=false)]
        public string DMSUnit { get; set; }

        /// <summary>
        /// <para>The data source information. This parameter can be left empty. Only one data source can be passed in through this parameter. We recommend that you use the DataSources parameter instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("DataSource")]
        [Validation(Required=false)]
        public string DataSourceShrink { get; set; }

        /// <summary>
        /// <para>The detailed data source information. This parameter can be left empty.</para>
        /// </summary>
        [NameInMap("DataSources")]
        [Validation(Required=false)]
        public string DataSourcesShrink { get; set; }

        /// <summary>
        /// <para>The content of the message to be sent to the Agent.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>what can you do?</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The message type. Default value: <c>[primary]</c>.</para>
        /// <list type="bullet">
        /// <item><description><para>In normal cases, when interacting with the Agent, the message type is <c>[primary]</c>.</para>
        /// </description></item>
        /// <item><description><para>When the message is a response to the Agent\&quot;s Human-in-Loop question, the type should be <c>[additional]</c>.</para>
        /// </description></item>
        /// <item><description><para>When the message is intended to trigger a report generation, the type should be <c>[report]</c>.</para>
        /// </description></item>
        /// <item><description><para>When the message is intended to cancel the current session, the type should be <c>[cancel]</c>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>primary</para>
        /// </summary>
        [NameInMap("MessageType")]
        [Validation(Required=false)]
        public string MessageType { get; set; }

        /// <summary>
        /// <para>The parent session ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20qrliuoo7p2vlsfg*****</para>
        /// </summary>
        [NameInMap("ParentSessionId")]
        [Validation(Required=false)]
        public string ParentSessionId { get; set; }

        /// <summary>
        /// <para>This field is required when the message type is <c>additional</c>. Pass in the specific question that the Agent asked the user through Human-in-Loop.</para>
        /// 
        /// <b>Example:</b>
        /// <para>请提供计算GMV的口径。</para>
        /// </summary>
        [NameInMap("Question")]
        [Validation(Required=false)]
        public string Question { get; set; }

        /// <summary>
        /// <para>Pass in the current quoted content, typically used when interacting with the Agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;version&quot;:&quot;v0&quot;}</para>
        /// </summary>
        [NameInMap("QuotedMessage")]
        [Validation(Required=false)]
        public string QuotedMessage { get; set; }

        /// <summary>
        /// <para><b>Important</b></para>
        /// <para>When this message is a reply to an Agent message (for example, when the Agent asks for clarification through ASK_HUMAN), reply_to must be set to the exact Checkpoint number carried in that Agent message. If this message is not a specific reply, such as requesting the Agent for further in-depth analysis after analysis is completed, reply_to can be left empty or set to &quot;0&quot;.</para>
        /// <para>This field affects how the Agent decides to process the message. Passing an incorrect value may lead to analysis results that do not meet expectations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ReplyTo")]
        [Validation(Required=false)]
        public string ReplyTo { get; set; }

        /// <summary>
        /// <para>The special configuration for this session. For the same session, only the configuration passed in the first SendMessage call takes effect.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("SessionConfig")]
        [Validation(Required=false)]
        public string SessionConfigShrink { get; set; }

        /// <summary>
        /// <para>The session ID. This is a required field. You can obtain the SessionId by calling CreateAgentSession.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sess_***</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The configuration items that only affect the current task.</para>
        /// </summary>
        [NameInMap("TaskConfig")]
        [Validation(Required=false)]
        public string TaskConfigShrink { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
