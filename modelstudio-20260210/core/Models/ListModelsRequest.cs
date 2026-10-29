// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class ListModelsRequest : TeaModel {
        /// <summary>
        /// <para>The model type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Reasoning: Deep thinking.</description></item>
        /// <item><description>VU: Visual understanding.</description></item>
        /// <item><description>IG: Image generation.</description></item>
        /// <item><description>VG: Video generation.</description></item>
        /// <item><description>ASR: Speech recognition.</description></item>
        /// <item><description>TTS: Speech synthesis.</description></item>
        /// <item><description>ME: Multimodal embedding.</description></item>
        /// <item><description>Realtime-Omni: Real-time omni-modal.</description></item>
        /// <item><description>Multimodal-Omni: Omni-modal.</description></item>
        /// <item><description>Realtime-Text-to-Speech: Real-time speech synthesis.</description></item>
        /// <item><description>TG: Text generation.</description></item>
        /// <item><description>TR: Text embedding.</description></item>
        /// <item><description>Realtime-ASR: Real-time speech recognition.</description></item>
        /// <item><description>Realtime-Audio-Translate: Real-time audio translation.</description></item>
        /// <item><description>3D-generation: 3D generation.</description></item>
        /// <item><description>Realtime-Chatting: Real-time voice conversation.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("capabilities")]
        [Validation(Required=false)]
        public List<string> Capabilities { get; set; }

        /// <summary>
        /// <para>The context window size used to filter models with a context window smaller than this value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("contextWindow")]
        [Validation(Required=false)]
        public long? ContextWindow { get; set; }

        /// <summary>
        /// <para>The model capability. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>model-experience: Playground.</description></item>
        /// <item><description>function-calling: Function calling.</description></item>
        /// <item><description>structured-outputs: Structured output.</description></item>
        /// <item><description>web-search: Web search.</description></item>
        /// <item><description>prefix-completion: Partial mode.</description></item>
        /// <item><description>cache: Cache.</description></item>
        /// <item><description>batch: Batch inference.</description></item>
        /// <item><description>fine-tuning: Model fine-tuning.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("features")]
        [Validation(Required=false)]
        public List<string> Features { get; set; }

        /// <summary>
        /// <para>The language. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh-CN: Chinese.</description></item>
        /// <item><description>en-US: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return. Valid values: 0 to 200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The model name for exact match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen-plus</para>
        /// </summary>
        [NameInMap("model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>The model name for fuzzy match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen-plus</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The next token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lwytFRtLdNk=</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The provider. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>qwen: Alibaba Cloud - Qwen.</description></item>
        /// <item><description>zhipu-ai: Zhipu AI.</description></item>
        /// <item><description>wan: Alibaba Cloud - Wan.</description></item>
        /// <item><description>qwen-domain-model: Alibaba Cloud - Domain Model.</description></item>
        /// <item><description>mini-max: MiniMax.</description></item>
        /// <item><description>moonshot-ai: Moonshot AI.</description></item>
        /// <item><description>deepseek: DeepSeek.</description></item>
        /// <item><description>happyhorse: Alibaba Cloud - HappyHorse.</description></item>
        /// <item><description>kling: Kling AI.</description></item>
        /// <item><description>pixverse: PixVerse.</description></item>
        /// <item><description>vidu: Vidu.</description></item>
        /// <item><description>tripo: Tripo.</description></item>
        /// <item><description>xiaomi: Xiaomi MiMo.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("providers")]
        [Validation(Required=false)]
        public List<string> Providers { get; set; }

    }

}
