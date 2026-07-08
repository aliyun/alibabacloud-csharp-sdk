// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunAiHelperWritingShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to generate the text step by step.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DistributeWriting")]
        [Validation(Required=false)]
        public bool? DistributeWriting { get; set; }

        /// <summary>
        /// <para>The prompt, which specifies the subject for the AI to write about.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>请帮我写一篇关于人工智能发展趋势的文章</para>
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// <para>The prompt pattern. For example, PE indicates the advanced pattern and Template indicates the template pattern.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Template</para>
        /// </summary>
        [NameInMap("PromptMode")]
        [Validation(Required=false)]
        public string PromptMode { get; set; }

        /// <summary>
        /// <para>The <a href="https://help.aliyun.com/document_detail/2782167.html">workspace</a> ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-xxxxx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// <para>The writing parameters from the previous form, specified as key-value pairs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;wordCount&quot;: &quot;1000&quot;, &quot;tone&quot;: &quot;formal&quot;}</para>
        /// </summary>
        [NameInMap("WritingParams")]
        [Validation(Required=false)]
        public string WritingParamsShrink { get; set; }

        /// <summary>
        /// <para>The writing scenario. Valid values: government, media, market, office, and custom.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>media</para>
        /// </summary>
        [NameInMap("WritingScene")]
        [Validation(Required=false)]
        public string WritingScene { get; set; }

        /// <summary>
        /// <para>The unique key for the writing style. Call the <a href="https://help.aliyun.com/document_detail/2922609.html">ListWritingStyles</a> operation to get a list of styles for the specified scenario.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>通知</para>
        /// </summary>
        [NameInMap("WritingStyle")]
        [Validation(Required=false)]
        public string WritingStyle { get; set; }

    }

}
