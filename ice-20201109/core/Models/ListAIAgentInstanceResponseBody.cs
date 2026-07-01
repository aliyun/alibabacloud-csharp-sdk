// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListAIAgentInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>List of agent instance objects.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<ListAIAgentInstanceResponseBodyInstances> Instances { get; set; }
        public class ListAIAgentInstanceResponseBodyInstances : TeaModel {
            /// <summary>
            /// <para>Template configuration used by the agent instance.</para>
            /// </summary>
            [NameInMap("AgentConfig")]
            [Validation(Required=false)]
            public AIAgentConfig AgentConfig { get; set; }

            /// <summary>
            /// <para>URL of the call log file. The file contains a JSON-formatted CallLog structure.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/call_logs/12345.json">https://example.com/call_logs/12345.json</a></para>
            /// </summary>
            [NameInMap("CallLogUrl")]
            [Validation(Required=false)]
            public string CallLogUrl { get; set; }

            /// <summary>
            /// <para>Runtime configuration required by the agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;VoiceChat&quot;:{&quot;AgentUserId&quot;:&quot;voice_agent_001&quot;,&quot;ChannelId&quot;:&quot;voice_channel_001&quot;,&quot;AuthToken&quot;:&quot;your_voice_chat_auth_token&quot;}}</para>
            /// </summary>
            [NameInMap("RuntimeConfig")]
            [Validation(Required=false)]
            public AIAgentRuntimeConfig RuntimeConfig { get; set; }

            /// <summary>
            /// <para>Instance status:</para>
            /// <list type="bullet">
            /// <item><description><para>Created: The call started but no connection was established between both ends.</para>
            /// </description></item>
            /// <item><description><para>Executing: The call is in progress and a connection is established between both ends.</para>
            /// </description></item>
            /// <item><description><para>Finished: The call ended.</para>
            /// </description></item>
            /// </list>
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
            /// <para>Template configuration used by the agent instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;VoiceChat&quot;: {&quot;VoiceId&quot;: &quot;zhixiaoxia&quot;}}</para>
            /// </summary>
            [NameInMap("TemplateConfig")]
            [Validation(Required=false)]
            [Obsolete]
            public AIAgentTemplateConfig TemplateConfig { get; set; }

            /// <summary>
            /// <para>User-defined information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;Email&quot;:&quot;<a href="mailto:johndoe@example.com">johndoe@example.com</a>&quot;,&quot;Preferences&quot;:{&quot;Language&quot;:&quot;en&quot;}}</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7B117AF5-2A16-412C-B127-FA6175ED1AD0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
