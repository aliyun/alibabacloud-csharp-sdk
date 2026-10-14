// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class ModelParameters : TeaModel {
        /// <summary>
        /// <para>The frequency penalty. Positive values reduce repetition. Valid values: -2.0 to 2.0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.2</para>
        /// </summary>
        [NameInMap("frequencyPenalty")]
        [Validation(Required=false)]
        public float? FrequencyPenalty { get; set; }

        /// <summary>
        /// <para>The maximum number of output tokens.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("maxTokens")]
        [Validation(Required=false)]
        public long? MaxTokens { get; set; }

        /// <summary>
        /// <para>The presence penalty. Positive values encourage new topics. Valid values: -2.0 to 2.0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.1</para>
        /// </summary>
        [NameInMap("presencePenalty")]
        [Validation(Required=false)]
        public float? PresencePenalty { get; set; }

        /// <summary>
        /// <para>The stop sequences. Generation stops immediately when any of these sequences is encountered.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;END&quot;]</para>
        /// </summary>
        [NameInMap("stopSequences")]
        [Validation(Required=false)]
        public List<string> StopSequences { get; set; }

        /// <summary>
        /// <para>The temperature parameter that controls the randomness of the output. Valid values: 0 to 2.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.7</para>
        /// </summary>
        [NameInMap("temperature")]
        [Validation(Required=false)]
        public float? Temperature { get; set; }

        /// <summary>
        /// <para>The top-k sampling parameter. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("topK")]
        [Validation(Required=false)]
        public int? TopK { get; set; }

        /// <summary>
        /// <para>The top-p sampling parameter. Valid values: 0 to 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.9</para>
        /// </summary>
        [NameInMap("topP")]
        [Validation(Required=false)]
        public float? TopP { get; set; }

    }

}
