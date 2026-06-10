// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class GenerateCopilotResponseRequest : TeaModel {
        /// <summary>
        /// <para>Input parameter for integrating with the copilot LLM service. Refer to the standard LLM API input parameter dict, convert it into a string, and pass it in llmParamString.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;{\&quot;model\&quot;:\&quot;Qwen-7B-Chat\&quot;,\&quot;temperature\&quot;:0.9,\&quot;max_tokens\&quot;:1000,\&quot;top_p\&quot;:1,\&quot;frequency_penalty\&quot;:0.0,\&quot;presence_penalty\&quot;:0.6,\&quot;messages\&quot;:[{\&quot;role\&quot;:\&quot;user\&quot;,\&quot;content\&quot;:\&quot;我是os工程师\&quot;},{\&quot;role\&quot;:\&quot;assistant\&quot;,\&quot;content\&quot;:\&quot;您好。我是AI语言模型，很高兴为您服 务。有什么我能帮助您的呢\&quot;},{\&quot;role\&quot;:\&quot;user\&quot;,\&quot;content\&quot;:\&quot;你知道什么是alinux吗\&quot;}]}&quot;</para>
        /// </summary>
        [NameInMap("llmParamString")]
        [Validation(Required=false)]
        public string LlmParamString { get; set; }

    }

}
