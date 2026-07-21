// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelRouterUpdateBillingRuleRequest : TeaModel {
        /// <summary>
        /// <para>The billing type. Must be <c>configurable</c>.</para>
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
        /// <para>The billing configuration, specified as a JSON object.</para>
        /// <ol>
        /// <item><description><para><b>Token-based tiered pricing (<c>token_tiered</c>)</b><br>Applies to <c>Chat</c> models. Billing is tiered based on the token count, with separate rates for standard mode, thinking mode, and cache hits. The JSON format is as follows:<br>
        /// json
        /// {
        /// &quot;tiers&quot;: [
        /// {
        /// &quot;min_tokens&quot;: 0,
        /// &quot;max_tokens&quot;: 32000,
        /// &quot;input_price&quot;: 2.5,
        /// &quot;output_price&quot;: 10,
        /// &quot;thinking_input_price&quot;: 2.5,
        /// &quot;thinking_output_price&quot;: 10,
        /// &quot;cached_input_price&quot;: 2.5
        /// },
        /// {
        /// &quot;min_tokens&quot;: 32000,
        /// &quot;max_tokens&quot;: 128000,
        /// &quot;input_price&quot;: 4,
        /// &quot;output_price&quot;: 16,
        /// &quot;thinking_input_price&quot;: 4,
        /// &quot;thinking_output_price&quot;: 16,
        /// &quot;cached_input_price&quot;: 4
        /// }
        /// ]
        /// }
        /// <b>Field descriptions:</b><br>
        /// Field | Type | Required | Description | Unit<br>
        /// \---|---|---|---|---<br>
        /// <c>tiers</c> | array | Yes | A required array of tiered pricing objects. | -<br>
        /// <c>tiers[].min_tokens</c> | integer | Yes | The lower bound (inclusive) of the token count for the current tier. | token<br>
        /// <c>tiers[].max_tokens</c> | integer | Yes | The upper bound (exclusive) of the token count for the current tier. A value of 0 indicates no upper limit. | token<br>
        /// <c>tiers[].input_price</c> | number | Yes | The unit price for input tokens in standard mode. | CNY / million tokens<br>
        /// <c>tiers[].output_price</c> | number | Yes | The unit price for output tokens in standard mode. | CNY / million tokens<br>
        /// <c>tiers[].thinking_input_price</c> | number | No | The unit price for input tokens in thinking mode. | CNY / million tokens<br>
        /// <c>tiers[].thinking_output_price</c> | number | No | The unit price for output tokens in thinking mode. | CNY / million tokens<br>
        /// <c>tiers[].cached_input_price</c> | number | No | The unit price for input tokens on a cache hit. | CNY / million tokens<br>
        /// <c>thinking_mode_tiers</c> | array | No | Dedicated tiers for thinking mode. The structure is the same as <c>tiers</c>. If a request includes a <c>reasoning_tokens</c> field and this array is not empty, this array overrides the default <c>tiers</c>. | -<br>
        /// <b>Constraints:</b><br><br><br><br><br><br><br><br><br><br><br><br><br><br></para>
        /// </description></item>
        /// <item><description><para><b>Per-image billing (<c>per_image</c>)</b><br>Applies to <c>ImageGeneration</c> and <c>ImageEdit</c> models. Billing is based on the number of images generated or processed. The JSON format is as follows:<br>
        /// json
        /// {
        /// &quot;price_per_image&quot;: 0.2
        /// }
        /// <b>Field descriptions:</b><br>
        /// Field | Type | Required | Description | Unit<br>
        /// \---|---|---|---|---<br>
        /// <c>price_per_image</c> | number | Yes | The unit price per image. | CNY / image<br><br><br><br><br></para>
        /// </description></item>
        /// <item><description><para><b>Video matrix billing (<c>video_matrix</c>)</b><br>Applies to <c>VideoGeneration</c> and <c>VideoImageGeneration</c> models. Pricing is based on a combination of video resolution and the presence of audio.<br>
        /// <b>Note:</b> The server automatically converts the <c>matrix</c> field, used by the frontend UI, to the <c>tiers</c> field required by the API.<br>
        /// The JSON format is as follows:<br>
        /// json
        /// {
        /// &quot;tiers&quot;: [
        /// {
        /// &quot;resolution&quot;: 480,
        /// &quot;has_audio&quot;: 0,
        /// &quot;price_per_second&quot;: 0.24
        /// },
        /// {
        /// &quot;resolution&quot;: 480,
        /// &quot;has_audio&quot;: 1,
        /// &quot;price_per_second&quot;: 0.24
        /// },
        /// {
        /// &quot;resolution&quot;: 720,
        /// &quot;has_audio&quot;: 0,
        /// &quot;price_per_second&quot;: 0.24
        /// },
        /// {
        /// &quot;resolution&quot;: 720,
        /// &quot;has_audio&quot;: 1,
        /// &quot;price_per_second&quot;: 0.24
        /// }
        /// ],
        /// &quot;default_price_per_second&quot;: 0.24
        /// }
        /// <b>Field descriptions:</b><br>
        /// Field | Type | Required | Description | Unit<br>
        /// \---|---|---|---|---<br>
        /// <c>tiers</c> | array | Yes | An array of video matrix pricing objects. | -<br>
        /// <c>tiers[].resolution</c> | integer | Yes | The video resolution. Valid values: 480, 720, and 1080. | Pixel height (p)<br>
        /// <c>tiers[].has_audio</c> | integer | Yes | Indicates whether audio is included. Valid values: 0 (no audio) and 1 (with audio). | -<br>
        /// <c>tiers[].price_per_second</c> | number | Yes | The unit price per second for this combination. | CNY / second<br>
        /// <c>default_price_per_second</c> | number | No | The default unit price per second, applied if the request\&quot;s parameters do not match any item in the <c>tiers</c> array. | CNY / second<br>
        /// <b>Constraints:</b><br><br><br><br><br><br><br><br><br><br><br><br></para>
        /// </description></item>
        /// <item><description><para><b>Per-duration billing (<c>per_duration</c>)</b><br>Applies to speech recognition (ASR) models. Billing is based on the duration of the audio. The JSON format is as follows:<br>
        /// json
        /// {
        /// &quot;price_per_unit&quot;: 0.00022
        /// }
        /// <b>Field descriptions:</b><br>
        /// Field | Type | Required | Description | Unit<br>
        /// \---|---|---|---|---<br>
        /// <c>price_per_unit</c> | number | Yes | The unit price per second of audio. | CNY / second<br><br><br><br><br></para>
        /// </description></item>
        /// <item><description><para><b>Per-character billing (<c>per_character</c>)</b><br>Applies to speech synthesis (TTS) models. Billing is based on the number of characters in the synthesized text. The JSON format is as follows:<br>
        /// json
        /// {
        /// &quot;price_per_unit&quot;: 0.8
        /// }
        /// <b>Field descriptions:</b><br>
        /// Field | Type | Required | Description | Unit<br>
        /// \---|---|---|---|---<br>
        /// <c>price_per_unit</c> | number | Yes | The unit price per 10,000 characters. | CNY / 10,000 characters<br><br><br><br><br></para>
        /// </description></item>
        /// <item><description><para><b>Flat-rate token billing (<c>token_flat</c>)</b><br>Applies to <c>Embedding</c>, <c>Rerank</c>, <c>MultimodalEmbedding</c>, and <c>MultimodalRerank</c> models. This method uses a single unit price without tiers. The JSON format is as follows:<br>
        /// json
        /// {
        /// &quot;input_price&quot;: 0.5,
        /// &quot;multimodal_input_price&quot;: 0.5
        /// }
        /// <b>Field descriptions:</b><br>
        /// Field | Type | Required | Description | Unit<br>
        /// \---|---|---|---|---<br>
        /// <c>input_price</c> | number | Yes | The unit price for text-only input tokens. | CNY / million tokens<br>
        /// <c>multimodal_input_price</c> | number | No | The unit price for multimodal input tokens. | CNY / million tokens<br><br><br><br><br><br></para>
        /// </description></item>
        /// <item><description><para><b>Omni-modal multi-dimension billing (<c>omni_multimodal</c>)</b><br>Applies to omni-modal models, such as <c>ChatFullmodal</c> (for example, <c>qwen3.5-omni-plus</c>). Prices are set separately for different input and output modalities, such as text, audio, images, and videos. The JSON format is as follows:<br>
        /// json
        /// {
        /// &quot;text_input_price&quot;: 7,
        /// &quot;audio_input_price&quot;: 53,
        /// &quot;image_input_price&quot;: 7,
        /// &quot;video_input_price&quot;: 7,
        /// &quot;text_output_price&quot;: 40,
        /// &quot;audio_output_price&quot;: 213,
        /// &quot;multi_text_output_price&quot;: 0
        /// }
        /// <b>Field descriptions:</b><br>
        /// Field | Type | Required | Description | Unit<br>
        /// \---|---|---|---|---<br>
        /// <c>text_input_price</c> | number | Yes | The unit price for text input tokens. | CNY / million tokens<br>
        /// <c>audio_input_price</c> | number | Yes | The unit price for audio input tokens. | CNY / million tokens<br>
        /// <c>image_input_price</c> | number | No | The unit price for image input tokens. | CNY / million tokens<br>
        /// <c>video_input_price</c> | number | No | The unit price for video input tokens. | CNY / million tokens<br>
        /// <c>text_output_price</c> | number | Yes | The unit price for text output tokens. | CNY / million tokens<br>
        /// <c>audio_output_price</c> | number | No | The unit price for audio output tokens. | CNY / million tokens<br>
        /// <c>multi_text_output_price</c> | number | No | The unit price for text output tokens when the input is multimodal (contains images, audio, or video). | CNY / million tokens<br><br>
        /// <b>Automatic billing type mapping</b><br>
        /// Model type (<c>model_type</c>) | Auto-detected billing type | Key identifying field in <c>pricingConfig</c><br>
        /// \---|---|---<br>
        /// <c>Chat</c> | <c>token_tiered</c> | The <c>tiers</c> field is present.<br>
        /// <c>ChatFullmodal</c> | <c>omni_multimodal</c> | The <c>text_input_price</c> or <c>audio_input_price</c> field is present.<br>
        /// <c>ImageGeneration</c> / <c>ImageEdit</c> | <c>per_image</c> | The <c>price_per_image</c> field is present.<br>
        /// <c>VideoGeneration</c> / <c>VideoImageGeneration</c> | <c>video_matrix</c> | The <c>tiers</c> field is present, and its elements contain <c>resolution</c>.<br>
        /// <c>ASR</c> | <c>per_duration</c> | The <c>price_per_unit</c> field is present (ASR scenario).<br>
        /// <c>TTS</c> | <c>per_character</c> | The <c>price_per_unit</c> field is present (TTS scenario).<br>
        /// <c>Embedding</c> / <c>Rerank</c> / <c>MultimodalEmbedding</c> / <c>MultimodalRerank</c> | <c>token_flat</c> | The <c>input_price</c> field is present.<br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br></para>
        /// </description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;tiers&quot;: [
        ///     {
        ///       &quot;min_tokens&quot;: 0,
        ///       &quot;max_tokens&quot;: 32000,
        ///       &quot;input_price&quot;: 2.5,
        ///       &quot;output_price&quot;: 2.5,
        ///       &quot;thinking_output_price&quot;: 10,
        ///       &quot;cached_input_price&quot;: 1.25
        ///     },
        ///     {
        ///       &quot;min_tokens&quot;: 32000,
        ///       &quot;max_tokens&quot;: 0,
        ///       &quot;input_price&quot;: 1.25,
        ///       &quot;output_price&quot;: 1.25,
        ///       &quot;thinking_output_price&quot;: 5,
        ///       &quot;cached_input_price&quot;: 0.625
        ///     }
        ///   ]
        /// }</para>
        /// </summary>
        [NameInMap("pricingConfig")]
        [Validation(Required=false)]
        public object PricingConfig { get; set; }

        /// <summary>
        /// <para>The status of the billing rule. Use this field to enable or disable the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The version number of the billing rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public int? Version { get; set; }

    }

}
