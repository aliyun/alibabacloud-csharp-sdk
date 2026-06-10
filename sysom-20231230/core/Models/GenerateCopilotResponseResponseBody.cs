// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class GenerateCopilotResponseResponseBody : TeaModel {
        /// <summary>
        /// <para>error code</para>
        /// 
        /// <b>Example:</b>
        /// <para>SysomOpenAPI.ServerError</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Data returned by the LLM service, in string format. If it is a dict, you must perform conversion and parsing yourself.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;choices\&quot;: [{\&quot;finish_reason\&quot;: \&quot;stop\&quot;, \&quot;index\&quot;: 0, \&quot;message\&quot;: {\&quot;content\&quot;: \&quot;Alinux是一个基于Linux的开源操作系统，它主要由阿里巴巴集团开发和维护，专为大规模云计算和大数据处理环境设计。这个系统针对高并发、低延迟以及资源利用率优化进行了深度定制和改良，以适应阿里内部复杂且庞大的业务需求。由于其在性能和稳定性方面的优秀表现，Alinux也在逐渐被外部的一些企业和研究机构采用，特别是在需要处理高负载场景的领域。与标准Linux发行版相比，Alinux可能包含特定的内核补丁、优化工具集以及其他阿里巴巴内部研发的特性。然而，值得注意的是，尽管名称中的“Ali”可能让人联想到与阿里巴巴的紧密关系，但Alinux作为一个项目，已经于2021年成为开放原子开源基金会（OpenAtom Foundation）下的一个子项目，即 OpenAnolis，这标志着它的社区化和广泛化的进程。\&quot;, \&quot;role\&quot;: \&quot;assistant\&quot;}}], \&quot;model\&quot;: \&quot;Qwen1.5\&quot;, \&quot;sentiment\&quot;: [], \&quot;status_code\&quot;: 200, \&quot;time\&quot;: 6.836989402770996, \&quot;usage\&quot;: {\&quot;completion_tokens\&quot;: 180, \&quot;prompt_tokens\&quot;: 176, \&quot;time_dict\&quot;: {\&quot;auto_regression_time\&quot;: 0.03798324399524265, \&quot;speed\&quot;: 26.327398474054736, \&quot;total_generate_time\&quot;: 6.836983919143677}, \&quot;total_tokens\&quot;: 356}}</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>Description of the error code. This field is empty if there is no error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Requests for llm service failed</para>
        /// </summary>
        [NameInMap("massage")]
        [Validation(Required=false)]
        public string Massage { get; set; }

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
