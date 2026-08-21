// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class GenerateCopilotStreamResponseRequest : TeaModel {
        [NameInMap("X-Debug-Id")]
        [Validation(Required=false)]
        public string XDebugId { get; set; }

        /// <summary>
        /// <para>The input parameter for the Copilot LLM service. Refer to the standard LLM interface input parameter dict. Convert it to a string and pass it to llmParamString.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;{\&quot;model\&quot;:\&quot;Qwen-7B-Chat\&quot;,\&quot;temperature\&quot;:0.9,\&quot;max_tokens\&quot;:1000,\&quot;top_p\&quot;:1,\&quot;frequency_penalty\&quot;:0.0,\&quot;presence_penalty\&quot;:0.6,\&quot;messages\&quot;:[{\&quot;role\&quot;:\&quot;user\&quot;,\&quot;content\&quot;:\&quot;I am an OS engineer\&quot;},{\&quot;role\&quot;:\&quot;assistant\&quot;,\&quot;content\&quot;:\&quot;Hello. I am an AI language model, happy to help you. What can I do for you?\&quot;},{\&quot;role\&quot;:\&quot;user\&quot;,\&quot;content\&quot;:\&quot;Do you know what Alinux is?\&quot;}]}&quot;</para>
        /// </summary>
        [NameInMap("llmParamString")]
        [Validation(Required=false)]
        public string LlmParamString { get; set; }

        [NameInMap("x-sysom-invoke-source")]
        [Validation(Required=false)]
        public string XSysomInvokeSource { get; set; }

    }

}
