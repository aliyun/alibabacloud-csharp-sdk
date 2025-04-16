// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QuanMiaoLightApp20240801.Models
{
    public class RunEnterpriseVocAnalysisShrinkRequest : TeaModel {
        /// <summary>
        /// <para>需要进行VOC分析的文本内容（content、contents、url、fileKey 四选一。优先级从小到大）</para>
        /// 
        /// <b>Example:</b>
        /// <para>这是一段需要分析的文本内容</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("extraInfo")]
        [Validation(Required=false)]
        public string ExtraInfo { get; set; }

        /// <summary>
        /// <para>过滤标签，用于筛选符合条件的内容。</para>
        /// </summary>
        [NameInMap("filterTags")]
        [Validation(Required=false)]
        public string FilterTagsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>qwen-max</para>
        /// </summary>
        [NameInMap("modelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        /// <summary>
        /// <para>指定返回结果的格式，支持json或text</para>
        /// 
        /// <b>Example:</b>
        /// <para>按照如下格式输出：{&quot;text1&quot;: &quot;xxxx&quot;, &quot;text2&quot;: &quot;xxxx&quot;}</para>
        /// </summary>
        [NameInMap("outputFormat")]
        [Validation(Required=false)]
        public string OutputFormat { get; set; }

        /// <summary>
        /// <para>业务标签体系，用于对文本内容进行分类和分析。</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>你是一名经验丰富的数据分析师，擅长从文本评论中提取结构化信息。你需要从用户评论列表中识别和提取出与以下四个维度相关的关键词和短语：</para>
        /// <pre><c>        索引：输入评论JSON数组中的索引（从零开始）表示针对该条索引抽取的维度。
        ///         购买动机：描述用户购买产品的原因、需求或驱动力的关键词或短语。
        ///         未满足需求点：用户在使用产品过程中提到的未满足需求或问题的关键词或短语。
        ///         使用场景：用户提到的具体使用场景、使用方式或环境的关键词或短语。
        ///         正负面观点：明确表示用户对产品或服务的正面或负面看法的关键词或短语。
        /// </c></pre>
        /// </summary>
        [NameInMap("taskDescription")]
        [Validation(Required=false)]
        public string TaskDescription { get; set; }

    }

}
