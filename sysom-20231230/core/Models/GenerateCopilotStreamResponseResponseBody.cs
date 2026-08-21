// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class GenerateCopilotStreamResponseResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SysomOpenAPI.ServerError</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data returned by the LLM service. The data is of the string type. If it is a dict, convert and parse it yourself.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;choices\&quot;: [{\&quot;finish_reason\&quot;: \&quot;stop\&quot;, \&quot;index\&quot;: 0, \&quot;message\&quot;: {\&quot;content\&quot;: \&quot;Alinux is a Linux-based open-source operating system primarily developed and maintained by Alibaba Group, designed specifically for large-scale cloud computing and big data processing environments. The system has been deeply customized and optimized for high concurrency, low latency, and resource utilization to meet the complex and massive business demands within Alibaba. Due to its excellent performance and stability, Alinux has gradually been adopted by external enterprises and research institutions, particularly in areas that require handling high-load scenarios. Compared to standard Linux distributions, Alinux may include specific kernel patches, optimization toolsets, and other features developed internally by Alibaba. However, it is worth noting that although the &quot;Ali&quot; in the name may suggest a close relationship with Alibaba, Alinux as a project became a sub-project under the OpenAtom Foundation in 2021, known as OpenAnolis, marking its progression toward community-driven and broader adoption.\&quot;, \&quot;role\&quot;: \&quot;assistant\&quot;}}], \&quot;model\&quot;: \&quot;Qwen1.5\&quot;, \&quot;sentiment\&quot;: [], \&quot;status_code\&quot;: 200, \&quot;time\&quot;: 6.836989402770996, \&quot;usage\&quot;: {\&quot;completion_tokens\&quot;: 180, \&quot;prompt_tokens\&quot;: 176, \&quot;time_dict\&quot;: {\&quot;auto_regression_time\&quot;: 0.03798324399524265, \&quot;speed\&quot;: 26.327398474054736, \&quot;total_generate_time\&quot;: 6.836983919143677}, \&quot;total_tokens\&quot;: 356}}</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The error code description. This field is empty if no error occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Requests for llm service failed</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>2D693121-C925-5154-8DF6-C09A8B369822</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
