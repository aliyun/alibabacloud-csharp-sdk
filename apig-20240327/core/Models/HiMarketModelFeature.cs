// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HiMarketModelFeature : TeaModel {
        /// <summary>
        /// <para>Indicates whether multimodal input is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enableMultiModal")]
        [Validation(Required=false)]
        public bool? EnableMultiModal { get; set; }

        /// <summary>
        /// <para>Indicates whether chain-of-thought (Thinking) is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enableThinking")]
        [Validation(Required=false)]
        public bool? EnableThinking { get; set; }

        /// <summary>
        /// <para>The maximum number of tokens supported by the model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8192</para>
        /// </summary>
        [NameInMap("maxTokens")]
        [Validation(Required=false)]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// <para>The model name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen-max</para>
        /// </summary>
        [NameInMap("model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>Indicates whether streaming output is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("streaming")]
        [Validation(Required=false)]
        public bool? Streaming { get; set; }

        /// <summary>
        /// <para>The temperature parameter that controls the randomness of generation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.7</para>
        /// </summary>
        [NameInMap("temperature")]
        [Validation(Required=false)]
        public float? Temperature { get; set; }

        /// <summary>
        /// <para>Indicates whether web search is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("webSearch")]
        [Validation(Required=false)]
        public bool? WebSearch { get; set; }

    }

}
