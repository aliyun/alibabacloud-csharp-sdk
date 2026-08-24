// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class SendChatMessageShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The agent ID. This is a required field. You can obtain the current AgentID from the response of the CreateAgentSession operation. Agent resources have a lifecycle, so the AgentID you need to specify may change with each request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent_***</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>The Data Management unit you are currently in. If you choose to analyze a database, this information is used to correctly connect to your Data Management instance. Go to the DAS console to view your current Data Management unit. If you are a user of the Alibaba Cloud China Website (<a href="http://www.aliyun.com">www.aliyun.com</a>), enter cn-hangzhou.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DMSUnit")]
        [Validation(Required=false)]
        public string DMSUnit { get; set; }

        /// <summary>
        /// <para>The data source information. This parameter can be left empty. Only one data source can be specified for this parameter. Use the DataSources parameter instead.</para>
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
        /// <para>The message content to send to the Agent.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>what can you do?</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The message type. Default value: <c>[primary]</c>.  </para>
        /// <list type="bullet">
        /// <item><description><para>For regular interactions with the Agent, the message type is <c>[primary]</c>.</para>
        /// </description></item>
        /// <item><description><para>When the message is a response to the Agent\&quot;s Human-in-Loop question, the type should be <c>[additional]</c>.</para>
        /// </description></item>
        /// <item><description><para>When the message is to trigger a report generation, the type should be <c>[report]</c>.</para>
        /// </description></item>
        /// <item><description><para>When the message is to cancel the current session, the type should be <c>[cancel]</c>.</para>
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
        /// <para>A required field when the message type is <c>additional</c>. Specifies the specific question that the Agent asks the user through Human-in-Loop.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Please provide the criteria for calculating GMV</para>
        /// </summary>
        [NameInMap("Question")]
        [Validation(Required=false)]
        public string Question { get; set; }

        /// <summary>
        /// <para>The quoted content, typically used during interactions with the Agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;version&quot;:&quot;v0&quot;}</para>
        /// </summary>
        [NameInMap("QuotedMessage")]
        [Validation(Required=false)]
        public string QuotedMessage { get; set; }

        /// <summary>
        /// <para><b>Important</b></para>
        /// <para>When this message is a reply to an Agent message (for example, the Agent asks a clarifying question through ASK_HUMAN), reply_to should be set to the exact Checkpoint sequence number carried by that Agent message. If this message is not a targeted reply, such as requesting the Agent to perform further in-depth analysis after analysis is complete, reply_to can be left empty or set to &quot;0&quot;.  </para>
        /// <para>This field affects how the Agent decides to process the message. Passing an incorrect value may result in analysis results that do not meet expectations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ReplyTo")]
        [Validation(Required=false)]
        public string ReplyTo { get; set; }

        /// <summary>
        /// <para>The special configuration for this session. For the same session, only the configuration passed with the first SendMessage call takes effect.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("SessionConfig")]
        [Validation(Required=false)]
        public string SessionConfigShrink { get; set; }

        /// <summary>
        /// <para>The session ID. This is a required field. You can obtain the SessionId by calling CreateAgentSession.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sess_***</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The configuration items that affect only the current task.</para>
        /// </summary>
        [NameInMap("TaskConfig")]
        [Validation(Required=false)]
        public string TaskConfigShrink { get; set; }

        /// <summary>
        /// <para>The user\&quot;s OSS bucket. If left empty, analysis data is securely stored in the built-in storage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-bucket</para>
        /// </summary>
        [NameInMap("UserOssBucket")]
        [Validation(Required=false)]
        public string UserOssBucket { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c1p71ne***baexrt3o</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
