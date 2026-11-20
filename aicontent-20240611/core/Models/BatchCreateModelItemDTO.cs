// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class BatchCreateModelItemDTO : TeaModel {
        /// <summary>
        /// <para>The model description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Qwen Max</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The extension configuration parameters in JSON string format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("extensions")]
        [Validation(Required=false)]
        public string Extensions { get; set; }

        /// <summary>
        /// <para>The supported input and output data types, separated by commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("inOut")]
        [Validation(Required=false)]
        public string InOut { get; set; }

        /// <summary>
        /// <para>The maximum input length in tokens.</para>
        /// 
        /// <b>Example:</b>
        /// <para>128000</para>
        /// </summary>
        [NameInMap("maxInputLength")]
        [Validation(Required=false)]
        public string MaxInputLength { get; set; }

        /// <summary>
        /// <para>The maximum output length in tokens.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8192</para>
        /// </summary>
        [NameInMap("maxOutputLength")]
        [Validation(Required=false)]
        public string MaxOutputLength { get; set; }

        /// <summary>
        /// <para>The model identifier. This parameter is required and corresponds to the model ID on the vendor side. If the identifier is duplicated, the backend automatically increments the version by using v1 or v2.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen-max</para>
        /// </summary>
        [NameInMap("modelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        /// <summary>
        /// <para>The model type. This parameter is required. Valid values: Chat, Embedding, Rerank, Image, Audio, and Video.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Chat</para>
        /// </summary>
        [NameInMap("modelType")]
        [Validation(Required=false)]
        public string ModelType { get; set; }

        /// <summary>
        /// <para>The model name. This parameter is required. If the identifier is duplicated, add -v1 or -v2 to distinguish the models.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen-max</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The tags, separated by commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>chat,NLP</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

    }

}
