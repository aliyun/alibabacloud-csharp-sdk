// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QuanMiaoLightApp20240801.Models
{
    public class RunMarketingInformationWritingShrinkRequest : TeaModel {
        [NameInMap("apiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>标题长度不超过30个字符</para>
        /// </summary>
        [NameInMap("customLimitation")]
        [Validation(Required=false)]
        public string CustomLimitation { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>请根据商品特点生成吸引人的标题</para>
        /// </summary>
        [NameInMap("customPrompt")]
        [Validation(Required=false)]
        public string CustomPrompt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///               &quot;minWordLength&quot;: &quot;10&quot;,
        ///               &quot;maxWordLength&quot;: &quot;50&quot;,
        ///               &quot;enableThinking&quot;: &quot;true&quot;,
        ///               &quot;thinkingBudget&quot;: &quot;2000&quot;
        ///             }</para>
        /// </summary>
        [NameInMap("extParameters")]
        [Validation(Required=false)]
        public string ExtParametersShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("generateCount")]
        [Validation(Required=false)]
        public string GenerateCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>商品特点：透气、减震、舒适</para>
        /// </summary>
        [NameInMap("inputExample")]
        [Validation(Required=false)]
        public string InputExample { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>运动鞋 透气 减震 跑步</para>
        /// </summary>
        [NameInMap("keywords")]
        [Validation(Required=false)]
        public string Keywords { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>qwen-max
        /// qwen-plus</para>
        /// </summary>
        [NameInMap("modelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>要求标题简洁有力，突出产品特点</para>
        /// </summary>
        [NameInMap("otherRequirements")]
        [Validation(Required=false)]
        public string OtherRequirements { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>透气减震运动鞋，舒适跑步首选</para>
        /// </summary>
        [NameInMap("outputExample")]
        [Validation(Required=false)]
        public string OutputExample { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>请根据关键词生成吸引人的商品标题</para>
        /// </summary>
        [NameInMap("prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>时尚休闲运动鞋</para>
        /// </summary>
        [NameInMap("sourceMaterial")]
        [Validation(Required=false)]
        public string SourceMaterial { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10-20</para>
        /// </summary>
        [NameInMap("wordCountRange")]
        [Validation(Required=false)]
        public string WordCountRange { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>generateProductTitle</para>
        /// </summary>
        [NameInMap("writingType")]
        [Validation(Required=false)]
        public string WritingType { get; set; }

    }

}
