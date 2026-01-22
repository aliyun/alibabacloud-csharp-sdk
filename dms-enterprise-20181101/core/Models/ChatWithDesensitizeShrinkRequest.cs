// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ChatWithDesensitizeShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Output audio voice and format; only applicable to the Qwen-Omni model, provided that the modalities parameter is set to [&quot;text&quot;, &quot;audio&quot;].</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AudioJson")]
        [Validation(Required=false)]
        public string AudioJson { get; set; }

        /// <summary>
        /// <para>Masking category. Required when needDataMasking is true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UserInfo</para>
        /// </summary>
        [NameInMap("DesensitizationRule")]
        [Validation(Required=false)]
        public string DesensitizationRule { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the code interpreter feature. Takes effect only when model is qwen3-max-preview and enable_thinking is true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableCodeInterpreter")]
        [Validation(Required=false)]
        public bool? EnableCodeInterpreter { get; set; }

        /// <summary>
        /// <para>Whether to enable web search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableSearch")]
        [Validation(Required=false)]
        public bool? EnableSearch { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Thinking Mode when using hybrid thinking models.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableThinking")]
        [Validation(Required=false)]
        public bool? EnableThinking { get; set; }

        /// <summary>
        /// <para>The ID of the instance, used to specify the corresponding data masking rules. You can call the <a href="https://help.aliyun.com/document_detail/141936.html">ListInstances</a> or <a href="https://help.aliyun.com/document_detail/141567.html">GetInstance</a> operation to query the ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public long? InstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the log probabilities of the output tokens.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Logprobs")]
        [Validation(Required=false)]
        public bool? Logprobs { get; set; }

        /// <summary>
        /// <para>Limits the maximum number of tokens the model can generate. If the output exceeds this value, generation will be truncated. Suitable for scenarios where you need to control the output length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>256</para>
        /// </summary>
        [NameInMap("MaxTokens")]
        [Validation(Required=false)]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// <para>The conversation context passed to the model, arranged in chronological order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///     {
        ///         &quot;content&quot;: &quot;你好&quot;,
        ///         &quot;role&quot;: &quot;user&quot;
        ///     }
        /// ]</para>
        /// </summary>
        [NameInMap("Messages")]
        [Validation(Required=false)]
        public string MessagesShrink { get; set; }

        /// <summary>
        /// <para>Output data modality; only applicable to the Qwen-Omni model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;text&quot;,&quot;audio&quot;]</para>
        /// </summary>
        [NameInMap("ModalitiesList")]
        [Validation(Required=false)]
        public string ModalitiesListShrink { get; set; }

        /// <summary>
        /// <para>The model name. Supported Models: Qwen series text-only Large Language Models (Commercial and Open-source). Multi-modal models are not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen-plus</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>Whether to enable data masking. Defaults to false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NeedDesensitization")]
        [Validation(Required=false)]
        public bool? NeedDesensitization { get; set; }

        /// <summary>
        /// <para>Controls the degree of repetition in generated text. Valid values: [-2.0, 2.0]. Positive values decrease repetition, while negative values increase it.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0</para>
        /// </summary>
        [NameInMap("PresencePenalty")]
        [Validation(Required=false)]
        public string PresencePenalty { get; set; }

        /// <summary>
        /// <para>The format of the returned content. Valid values: text: Plain text response; json_object: Standardized JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("ResponseFormat")]
        [Validation(Required=false)]
        public string ResponseFormat { get; set; }

        /// <summary>
        /// <para>Web search strategy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("SearchOptions")]
        [Validation(Required=false)]
        public string SearchOptionsShrink { get; set; }

        /// <summary>
        /// <para>Random seed. Used to ensure the reproducibility of results under the same input and parameters. Valid values: [0, 2^31−1].</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Seed")]
        [Validation(Required=false)]
        public int? Seed { get; set; }

        /// <summary>
        /// <para>Stop sequences.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;\n&quot;]</para>
        /// </summary>
        [NameInMap("Stop")]
        [Validation(Required=false)]
        public string StopShrink { get; set; }

        /// <summary>
        /// <para>The sampling temperature controls the diversity of the generated text. The higher the temperature, the more diverse the generated text, and conversely, the more deterministic the generated text. Valid values: [0, 2).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Temperature")]
        [Validation(Required=false)]
        public string Temperature { get; set; }

        /// <summary>
        /// <para>The maximum number of tokens allowed for the model\&quot;s internal reasoning process.</para>
        /// 
        /// <b>Example:</b>
        /// <para>256</para>
        /// </summary>
        [NameInMap("ThinkingBudget")]
        [Validation(Required=false)]
        public int? ThinkingBudget { get; set; }

        /// <summary>
        /// <para>Specifies the number of candidate tokens to consider during sampling. Higher values increase randomness, while lower values make the output more deterministic. Set to null or a value greater than 100 to disable.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TopK")]
        [Validation(Required=false)]
        public int? TopK { get; set; }

        /// <summary>
        /// <para>Specifies the number of most likely candidate tokens to return at each generation step. Valid values: [0, 5].</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TopLogprobs")]
        [Validation(Required=false)]
        public int? TopLogprobs { get; set; }

        /// <summary>
        /// <para>The probability threshold for nucleus sampling, used to control the diversity of the generated text. Higher Top-P values result in more diverse generated text. Valid values: (0,1.0].</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.5</para>
        /// </summary>
        [NameInMap("TopP")]
        [Validation(Required=false)]
        public string TopP { get; set; }

        /// <summary>
        /// <para>Specifies whether to increase the maximum pixel limit of input images to the equivalent of 16,384 tokens.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("VlHighResolutionImages")]
        [Validation(Required=false)]
        public bool? VlHighResolutionImages { get; set; }

        /// <summary>
        /// <para>Specifies whether to further identify non-compliant information in both input and output content, building upon the built-in content safety capabilities of the Tongyi Qianwen API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("XDashScopeDataInspection")]
        [Validation(Required=false)]
        public string XDashScopeDataInspection { get; set; }

    }

}
