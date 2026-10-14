// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class CpuHighAgentStreamResponseRequest : TeaModel {
        /// <summary>
        /// <para>The input parameter for the CPU high agent service. Refer to the standard LLM API input parameter dict. Convert it to a string and pass it in llmParamString.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;llmParamString&quot;: &quot;{\&quot;messages\&quot;: [{\&quot;role\&quot;: \&quot;user\&quot;, \&quot;content\&quot;: \&quot;The CPU utilization of instance i-67890 for user 12345 has been high in the last 2 minutes. Analyze the cause based on the flame graph information from the last 2 minutes.\&quot;}]}&quot;</para>
        /// </summary>
        [NameInMap("llmParamString")]
        [Validation(Required=false)]
        public string LlmParamString { get; set; }

    }

}
