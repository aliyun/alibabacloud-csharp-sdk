// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DescribeAIAgentInstanceResponseBody : TeaModel {
        [NameInMap("Instance")]
        [Validation(Required=false)]
        public DescribeAIAgentInstanceResponseBodyInstance Instance { get; set; }
        public class DescribeAIAgentInstanceResponseBodyInstance : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://example.com/call_logs/12345">https://example.com/call_logs/12345</a></para>
            /// </summary>
            [NameInMap("CallLogUrl")]
            [Validation(Required=false)]
            public string CallLogUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;VoiceChat&quot;:{&quot;AgentUserId&quot;:&quot;voice_agent_001&quot;,&quot;ChannelId&quot;:&quot;voice_channel_001&quot;,&quot;AuthToken&quot;:&quot;your_voice_chat_auth_token&quot;}}</para>
            /// </summary>
            [NameInMap("RuntimeConfig")]
            [Validation(Required=false)]
            public AIAgentRuntimeConfig RuntimeConfig { get; set; }

            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Finished</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;VoiceChat&quot;: {&quot;AppId&quot;: &quot;your_voice_chat_app_id&quot;}}</para>
            /// </summary>
            [NameInMap("TemplateConfig")]
            [Validation(Required=false)]
            public AIAgentTemplateConfig TemplateConfig { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;Email&quot;:&quot;<a href="mailto:johndoe@example.com">johndoe@example.com</a>&quot;,&quot;Preferences&quot;:{&quot;Language&quot;:&quot;en&quot;}}</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7B117AF5-2A16-412C-B127-FA6175ED1AD0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
