// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class InvokeAIAgentRequest : TeaModel {
        /// <summary>
        /// <para>The name of the agent.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>slsLogDiagnose</para>
        /// </summary>
        [NameInMap("agentName")]
        [Validation(Required=false)]
        public string AgentName { get; set; }

        /// <summary>
        /// <para>The business parameters. Each agent performs custom validation. For example, pass the Simple Log Service context for log diagnostics.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;app&quot;:&quot;log-diagnosis&quot;,&quot;logStore&quot;:&quot;apig-logstore&quot;}</para>
        /// </summary>
        [NameInMap("bizParams")]
        [Validation(Required=false)]
        public Dictionary<string, string> BizParams { get; set; }

        /// <summary>
        /// <para>The conversation history, which includes the role (user or assistant) and content. The role and content in each element cannot be empty.</para>
        /// </summary>
        [NameInMap("history")]
        [Validation(Required=false)]
        public List<InvokeAIAgentRequestHistory> History { get; set; }
        public class InvokeAIAgentRequestHistory : TeaModel {
            /// <summary>
            /// <para>The content. The returned data is in rich text format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Previous question</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

        }

        /// <summary>
        /// <para>The output language. If this parameter is set to en, the default error message is displayed in English.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh / en</para>
        /// </summary>
        [NameInMap("outputLanguage")]
        [Validation(Required=false)]
        public string OutputLanguage { get; set; }

        /// <summary>
        /// <para>The current user input. If this parameter is empty, a default value is used based on the scenario, such as Start.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Help me diagnose this error log</para>
        /// </summary>
        [NameInMap("prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

    }

}
