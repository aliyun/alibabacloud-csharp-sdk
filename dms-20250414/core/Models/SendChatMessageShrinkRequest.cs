// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class SendChatMessageShrinkRequest : TeaModel {
        /// <summary>
        /// <para><b>[Deprecated]</b> This field is now automatically obtained by the backend. You do not need to specify this field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent_***</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para><b>[Deprecated]</b> This field is now automatically obtained by the backend. You do not need to specify this field when calling the API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DMSUnit")]
        [Validation(Required=false)]
        public string DMSUnit { get; set; }

        /// <summary>
        /// <para>The data source information. This parameter can be left empty. This parameter supports only one data source. Use the DataSources parameter instead.</para>
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
        /// <para>The content of the message to send to the Agent.</para>
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
        /// <item><description><para>For regular interactions with the Agent, set the message type to <c>[primary]</c>.</para>
        /// </description></item>
        /// <item><description><para>When the message is a response to the Agent\&quot;s human-in-the-loop question, set the type to <c>[additional]</c>.</para>
        /// </description></item>
        /// <item><description><para>When the message triggers a report generation, set the type to <c>[report]</c>.</para>
        /// </description></item>
        /// <item><description><para>When the message cancels the current session, set the type to <c>[cancel]</c>.</para>
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
        /// <para>This field is required when the message type is <c>additional</c>. Specify the specific question that the Agent asks the user through the human-in-the-loop mechanism.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Provide the criteria for calculating GMV</para>
        /// </summary>
        [NameInMap("Question")]
        [Validation(Required=false)]
        public string Question { get; set; }

        /// <summary>
        /// <para>The quoted content. This is typically used during interactions with the Agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;version&quot;:&quot;v0&quot;}</para>
        /// </summary>
        [NameInMap("QuotedMessage")]
        [Validation(Required=false)]
        public string QuotedMessage { get; set; }

        /// <summary>
        /// <para><b>Important</b></para>
        /// <para>When this message is a reply to an Agent message (for example, the Agent asks a clarifying question through ASK_HUMAN), set reply_to to the exact Checkpoint sequence number carried in that Agent message. If this message is not a targeted reply, such as requesting the Agent to perform further in-depth analysis after the analysis is complete, leave reply_to empty or set it to &quot;0&quot;.  </para>
        /// <para>This field affects how the Agent decides to process the message. Passing an incorrect value may cause the analysis results to be less effective than expected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ReplyTo")]
        [Validation(Required=false)]
        public string ReplyTo { get; set; }

        /// <summary>
        /// <para>The special configuration for the current session. For the same session, only the configuration included in the first SendMessage call takes effect.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("SessionConfig")]
        [Validation(Required=false)]
        public string SessionConfigShrink { get; set; }

        /// <summary>
        /// <para>The session ID. This is an optional field used for multi-turn conversations.</para>
        /// <list type="bullet">
        /// <item><description>You can start a session without specifying this field. The response includes the SessionID for the current session.</description></item>
        /// <item><description>You can also manually create a session ID by calling the CreateDataAgentSession operation and include the ID when initiating a session.</description></item>
        /// <item><description>If you need multi-turn conversations (such as follow-up questions or confirming execution plans), include the SessionID returned by the previous SendChatMessage call.</description></item>
        /// </list>
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
        /// <para>The OSS bucket of the user. If this field is left empty, the analysis data is securely stored in the built-in storage.</para>
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
