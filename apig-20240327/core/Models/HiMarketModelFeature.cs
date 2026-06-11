// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HiMarketModelFeature : TeaModel {
        /// <summary>
        /// <para>Indicates whether to enable multi-modal capabilities. If set to <c>true</c>, the model can process requests that include multiple data types, such as text and images.</para>
        /// </summary>
        [NameInMap("enableMultiModal")]
        [Validation(Required=false)]
        public bool? EnableMultiModal { get; set; }

        /// <summary>
        /// <para>Indicates whether to include the model\&quot;s reasoning process in the response. If set to <c>true</c>, the output may contain intermediate steps that show how the model arrived at a conclusion.</para>
        /// </summary>
        [NameInMap("enableThinking")]
        [Validation(Required=false)]
        public bool? EnableThinking { get; set; }

        /// <summary>
        /// <para>The maximum number of tokens to generate in the response. A token is a unit of text processed by the model.</para>
        /// </summary>
        [NameInMap("maxTokens")]
        [Validation(Required=false)]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// <para>The identifier of the model to use for inference.</para>
        /// </summary>
        [NameInMap("model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>Indicates whether to deliver the response as a continuous stream. If set to <c>true</c>, results are sent incrementally.</para>
        /// </summary>
        [NameInMap("streaming")]
        [Validation(Required=false)]
        public bool? Streaming { get; set; }

        /// <summary>
        /// <para>Controls the randomness of the output. Valid values range from 0 to 1. Higher values, such as 0.8, make the output more random. Lower values, such as 0.2, make the output more deterministic.</para>
        /// </summary>
        [NameInMap("temperature")]
        [Validation(Required=false)]
        public float? Temperature { get; set; }

        /// <summary>
        /// <para>Indicates whether the model can search the web to provide more up-to-date responses.</para>
        /// </summary>
        [NameInMap("webSearch")]
        [Validation(Required=false)]
        public bool? WebSearch { get; set; }

    }

}
