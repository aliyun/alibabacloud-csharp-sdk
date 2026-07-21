// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelRouterUpdateModelRequest : TeaModel {
        /// <summary>
        /// <para>The API key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sk-xxxx</para>
        /// </summary>
        [NameInMap("apiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// <para>The base URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://dashscope.aliyuncs.com">https://dashscope.aliyuncs.com</a></para>
        /// </summary>
        [NameInMap("baseUrl")]
        [Validation(Required=false)]
        public string BaseUrl { get; set; }

        /// <summary>
        /// <para>The model description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>通义千问大模型</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The maximum input length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8192</para>
        /// </summary>
        [NameInMap("maxInputLength")]
        [Validation(Required=false)]
        public string MaxInputLength { get; set; }

        /// <summary>
        /// <para>The maximum output length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2048</para>
        /// </summary>
        [NameInMap("maxOutputLength")]
        [Validation(Required=false)]
        public string MaxOutputLength { get; set; }

        /// <summary>
        /// <para>The model ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen-turbo</para>
        /// </summary>
        [NameInMap("modelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        /// <summary>
        /// <para>The model type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Chat</para>
        /// </summary>
        [NameInMap("modelType")]
        [Validation(Required=false)]
        public string ModelType { get; set; }

        /// <summary>
        /// <para>The model name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>通义千问</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The model status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The provider symbol.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alibaba</para>
        /// </summary>
        [NameInMap("symbol")]
        [Validation(Required=false)]
        public string Symbol { get; set; }

        /// <summary>
        /// <para>Comma-separated tags.</para>
        /// 
        /// <b>Example:</b>
        /// <para>chat,NLP</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

    }

}
