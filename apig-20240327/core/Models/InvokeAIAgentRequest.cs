// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class InvokeAIAgentRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>slsLogDiagnose</para>
        /// </summary>
        [NameInMap("agentName")]
        [Validation(Required=false)]
        public string AgentName { get; set; }

        [NameInMap("bizParams")]
        [Validation(Required=false)]
        public Dictionary<string, string> BizParams { get; set; }

        [NameInMap("history")]
        [Validation(Required=false)]
        public List<InvokeAIAgentRequestHistory> History { get; set; }
        public class InvokeAIAgentRequestHistory : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>上一轮问题</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh / en</para>
        /// </summary>
        [NameInMap("outputLanguage")]
        [Validation(Required=false)]
        public string OutputLanguage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>帮我诊断这个错误日志</para>
        /// </summary>
        [NameInMap("prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

    }

}
