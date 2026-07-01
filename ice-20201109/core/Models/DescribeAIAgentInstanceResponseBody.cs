// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DescribeAIAgentInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>Information about the AI agent instance.</para>
        /// </summary>
        [NameInMap("Instance")]
        [Validation(Required=false)]
        public DescribeAIAgentInstanceResponseBodyInstance Instance { get; set; }
        public class DescribeAIAgentInstanceResponseBodyInstance : TeaModel {
            /// <summary>
            /// <para>The configuration of the AI agent.</para>
            /// </summary>
            [NameInMap("AgentConfig")]
            [Validation(Required=false)]
            public AIAgentConfig AgentConfig { get; set; }

            /// <summary>
            /// <para>Information about the call.</para>
            /// </summary>
            [NameInMap("CallInfo")]
            [Validation(Required=false)]
            public AIAgentCallInfo CallInfo { get; set; }

            /// <summary>
            /// <para>The URL of the call log.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/call_logs/12345">https://example.com/call_logs/12345</a></para>
            /// </summary>
            [NameInMap("CallLogUrl")]
            [Validation(Required=false)]
            public string CallLogUrl { get; set; }

            /// <summary>
            /// <para>The creation time (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-07-18T06:39:08.000+00:00</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The modification time (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-07-18T06:40:12.000+00:00</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The runtime configuration of the AI agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;VoiceChat&quot;:{&quot;AgentUserId&quot;:&quot;voice_agent_001&quot;,&quot;ChannelId&quot;:&quot;voice_channel_001&quot;,&quot;AuthToken&quot;:&quot;your_voice_chat_auth_token&quot;}}</para>
            /// </summary>
            [NameInMap("RuntimeConfig")]
            [Validation(Required=false)]
            public AIAgentRuntimeConfig RuntimeConfig { get; set; }

            /// <summary>
            /// <para>The session ID for the conversation. This parameter is empty by default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>955535**************</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>The status of the AI agent instance, such as <c>Finished</c> or <c>Executing</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Finished</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The AI agent template configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;VoiceChat&quot;: {&quot;AppId&quot;: &quot;your_voice_chat_app_id&quot;}}</para>
            /// </summary>
            [NameInMap("TemplateConfig")]
            [Validation(Required=false)]
            [Obsolete]
            public AIAgentTemplateConfig TemplateConfig { get; set; }

            /// <summary>
            /// <para>The user data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;Email&quot;:&quot;<a href="mailto:johndoe@example.com">johndoe@example.com</a>&quot;,&quot;Preferences&quot;:{&quot;Language&quot;:&quot;en&quot;}}</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7B117AF5-2A16-412C-B127-FA6175ED1AD0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
