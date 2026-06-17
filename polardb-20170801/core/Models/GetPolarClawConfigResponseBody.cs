// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class GetPolarClawConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The configuration object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;models&quot;: &quot;{\&quot;mode\&quot;:\&quot;merge\&quot;,\&quot;providers\&quot;:{\&quot;bailian\&quot;:{\&quot;models\&quot;:[{\&quot;input\&quot;:[\&quot;text\&quot;,\&quot;image\&quot;],\&quot;name\&quot;:\&quot;qwen3.6-plus\&quot;,\&quot;api\&quot;:\&quot;openai-completions\&quot;,\&quot;id\&quot;:\&quot;qwen3.6-plus\&quot;,\&quot;compat\&quot;:{\&quot;supportsUsageInStreaming\&quot;:true}}],\&quot;baseUrl\&quot;:\&quot;<a href="https://dashscope.aliyuncs.com/compatible-mode/v1%5C%5C%22,%5C%5C%22apiKey%5C%5C%22:%5C%5C%22__OPENCLAW_REDACTED__%5C%5C%22,%5C%5C%22api%5C%5C%22:%5C%5C%22openai-completions%5C%5C%22%7D,%5C%5C%22polardbCustom%5C%5C%22:%7B%5C%5C%22models%5C%5C%22:%5B%7B%5C%5C%22name%5C%5C%22:%5C%5C%22qwen3-max%5C%5C%22,%5C%5C%22api%5C%5C%22:%5C%5C%22openai-completions%5C%5C%22,%5C%5C%22id%5C%5C%22:%5C%5C%22qwen3-max%5C%5C%22%7D%5D,%5C%5C%22baseUrl%5C%5C%22:%5C%5C%22https://dashscope.aliyuncs.com/compatible-mode/v1%5C%5C%22,%5C%5C%22apiKey%5C%5C%22:%5C%5C%22__OPENCLAW_REDACTED__%5C%5C%22,%5C%5C%22api%5C%5C%22:%5C%5C%22openai-completions%5C%5C%22%7D,%5C%5C%22polardb%5C%5C%22:%7B%5C%5C%22models%5C%5C%22:%5B%5D,%5C%5C%22baseUrl%5C%5C%22:%5C%5C%22https://dashscope.aliyuncs.com/compatible-mode/v1%5C%5C%22,%5C%5C%22api%5C%5C%22:%5C%5C%22openai-completions%5C%5C%22%7D%7D%7D">https://dashscope.aliyuncs.com/compatible-mode/v1\\&quot;,\\&quot;apiKey\\&quot;:\\&quot;__OPENCLAW_REDACTED__\\&quot;,\\&quot;api\\&quot;:\\&quot;openai-completions\\&quot;},\\&quot;polardbCustom\\&quot;:{\\&quot;models\\&quot;:[{\\&quot;name\\&quot;:\\&quot;qwen3-max\\&quot;,\\&quot;api\\&quot;:\\&quot;openai-completions\\&quot;,\\&quot;id\\&quot;:\\&quot;qwen3-max\\&quot;}],\\&quot;baseUrl\\&quot;:\\&quot;https://dashscope.aliyuncs.com/compatible-mode/v1\\&quot;,\\&quot;apiKey\\&quot;:\\&quot;__OPENCLAW_REDACTED__\\&quot;,\\&quot;api\\&quot;:\\&quot;openai-completions\\&quot;},\\&quot;polardb\\&quot;:{\\&quot;models\\&quot;:[],\\&quot;baseUrl\\&quot;:\\&quot;https://dashscope.aliyuncs.com/compatible-mode/v1\\&quot;,\\&quot;api\\&quot;:\\&quot;openai-completions\\&quot;}}}</a>&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public Dictionary<string, object> Config { get; set; }

        /// <summary>
        /// <para>The configuration hash.</para>
        /// 
        /// <b>Example:</b>
        /// <para>005b55a8e870aaf866598e48a6af0bdbfa3fef704770c5e1cbad99648beaa661</para>
        /// </summary>
        [NameInMap("Hash")]
        [Validation(Required=false)]
        public string Hash { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The version of OpenClaw.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026.3.28</para>
        /// </summary>
        [NameInMap("OpenclawVersion")]
        [Validation(Required=false)]
        public string OpenclawVersion { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CD3FA5F3-FAF3-44CA-AFFF-BAF869******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
