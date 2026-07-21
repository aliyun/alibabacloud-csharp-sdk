// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelRouterCreateBillingRuleRequest : TeaModel {
        /// <summary>
        /// <para>The billing type. The value must be <c>configurable</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>configurable</para>
        /// </summary>
        [NameInMap("billingType")]
        [Validation(Required=false)]
        public string BillingType { get; set; }

        /// <summary>
        /// <para>The effective time, in RFC3339 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-01-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("effectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// <para>The expiration time, in RFC3339 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("expireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>The model ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("modelId")]
        [Validation(Required=false)]
        public long? ModelId { get; set; }

        /// <summary>
        /// <para>The <c>pricingConfig</c> is a JSON object whose internal field structure varies depending on the billing type.</para>
        /// <ol>
        /// <item><description><para><b>Tiered token billing</b><br>Applicable to chat models. This type uses tiered pricing based on the number of input tokens and supports different rates for standard mode, thinking mode, and cache hits.<br>JSON format:<br><br><br></para>
        /// <para>Field descriptions:Constraints:</para>
        /// </description></item>
        /// <item><description><para><b>Per-image billing</b><br>Applicable to <c>ImageGeneration</c> and <c>ImageEdit</c> models. Billing is based on the number of images generated or processed.<br>JSON format:<br><br><br></para>
        /// <para>Field descriptions:</para>
        /// </description></item>
        /// <item><description><para><b>Video matrix billing</b><br>Applicable to <c>VideoGeneration</c> and <c>VideoImageGeneration</c> models. Pricing is based on a combination of video resolution and the presence of an audio track.<br>Note: While the frontend UI may use a <c>matrix</c> field, API calls must use the <c>tiers</c> field to save the configuration. The <c>matrix</c> field is automatically converted to <c>tiers</c> on the server side. The format below is the standard API format.<br>JSON format:<br><br><br><br></para>
        /// <para>Field descriptions:Constraints:</para>
        /// </description></item>
        /// <item><description><para><b>Billing by duration</b><br>Applicable to automatic speech recognition (ASR) models. Billing is based on the audio duration.<br>JSON format:<br><br><br></para>
        /// <para>Field descriptions:</para>
        /// </description></item>
        /// <item><description><para><b>Per-character billing</b><br>Applicable to text-to-speech (TTS) models. Billing is based on the number of characters in the synthesized text.<br>JSON format:<br><br><br></para>
        /// <para>Field descriptions:</para>
        /// </description></item>
        /// <item><description><para><b>Flat-rate token billing</b><br>Applicable to models such as <c>Embedding</c>, <c>Rerank</c>, <c>MultimodalEmbedding</c>, and <c>MultimodalRerank</c>. This type uses a flat-rate pricing model without tiers.<br>JSON format:<br><br><br></para>
        /// <para>Field descriptions:</para>
        /// </description></item>
        /// <item><description><para><b>Full-modal multi-dimensional billing</b><br>Applicable to full-modal models such as <c>ChatFullmodal</c> (e.g., <c>qwen3.5-omni-plus</c>). It sets separate prices for the input and output of different modalities, such as text, audio, images, and video.<br>JSON format:<br><br><br></para>
        /// <para>Field descriptions:</para>
        /// </description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///                 &quot;tiers&quot;:[
        ///                     {
        ///                         &quot;input_price&quot;:2.5,
        ///                         &quot;cached_input_price&quot;:2.5,
        ///                         &quot;max_tokens&quot;:32000,
        ///                         &quot;output_price&quot;:10,
        ///                         &quot;thinking_output_price&quot;:10,
        ///                         &quot;thinking_input_price&quot;:2.5,
        ///                         &quot;min_tokens&quot;:0
        ///                     },
        ///                     {
        ///                         &quot;input_price&quot;:4,
        ///                         &quot;cached_input_price&quot;:4,
        ///                         &quot;max_tokens&quot;:128000,
        ///                         &quot;output_price&quot;:16,
        ///                         &quot;thinking_output_price&quot;:16,
        ///                         &quot;thinking_input_price&quot;:4,
        ///                         &quot;min_tokens&quot;:32000
        ///                     },
        ///                     {
        ///                         &quot;input_price&quot;:7,
        ///                         &quot;cached_input_price&quot;:7,
        ///                         &quot;max_tokens&quot;:252000,
        ///                         &quot;output_price&quot;:28,
        ///                         &quot;thinking_output_price&quot;:28,
        ///                         &quot;thinking_input_price&quot;:7,
        ///                         &quot;min_tokens&quot;:128000
        ///                     }
        ///                 ]
        ///             }</para>
        /// </summary>
        [NameInMap("pricingConfig")]
        [Validation(Required=false)]
        public object PricingConfig { get; set; }

        /// <summary>
        /// <para>The billing rule version number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public int? Version { get; set; }

    }

}
