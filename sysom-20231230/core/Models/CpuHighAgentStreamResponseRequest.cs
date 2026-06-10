// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class CpuHighAgentStreamResponseRequest : TeaModel {
        /// <summary>
        /// <para>Input parameter for interfacing with the high-CPU agent service. Refer to the standard LLM API input parameter dictionary, convert it into a string, and pass it in the <c>llmParamString</c> field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;llmParamString&quot;: &quot;{\&quot;messages\&quot;: [{\&quot;role\&quot;: \&quot;user\&quot;, \&quot;content\&quot;: \&quot;用户12345的机器i-67890，最近2分钟CPU使用率高，请结合最近2分钟的火焰图信息，分析原因\&quot;}]}&quot;</para>
        /// </summary>
        [NameInMap("llmParamString")]
        [Validation(Required=false)]
        public string LlmParamString { get; set; }

    }

}
