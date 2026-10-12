// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class InvokeAIAgentRequest : TeaModel {
        /// <summary>
        /// <para>The agent name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>slsLogDiagnose</para>
        /// </summary>
        [NameInMap("agentName")]
        [Validation(Required=false)]
        public string AgentName { get; set; }

        /// <summary>
        /// <para>The business parameters. Each agent performs custom validation on these parameters, such as the SLS context passed for log diagnostics.</para>
        /// </summary>
        [NameInMap("bizParams")]
        [Validation(Required=false)]
        public Dictionary<string, string> BizParams { get; set; }

        /// <summary>
        /// <para>The conversation history. Each element contains role (user/assistant) and content. The role and content fields in each element cannot be empty.</para>
        /// </summary>
        [NameInMap("history")]
        [Validation(Required=false)]
        public List<InvokeAIAgentRequestHistory> History { get; set; }
        public class InvokeAIAgentRequestHistory : TeaModel {
            /// <summary>
            /// <para>The content of the message. The returned data is in rich text format.</para>
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
        /// <para>The output language. When set to en, fallback error messages are displayed in English.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh / en</para>
        /// </summary>
        [NameInMap("outputLanguage")]
        [Validation(Required=false)]
        public string OutputLanguage { get; set; }

        /// <summary>
        /// <para>The user input for the current turn. If left empty, a default prompt is used based on the scenario, such as &quot;Start&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Help me diagnose this error log</para>
        /// </summary>
        [NameInMap("prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

    }

}
