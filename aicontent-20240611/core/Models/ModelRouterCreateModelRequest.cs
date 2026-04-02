// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelRouterCreateModelRequest : TeaModel {
        /// <summary>
        /// <para>API Key</para>
        /// 
        /// <b>Example:</b>
        /// <para>sk-xxxx</para>
        /// </summary>
        [NameInMap("apiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// <para>Base URL</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://dashscope.aliyuncs.com">https://dashscope.aliyuncs.com</a></para>
        /// </summary>
        [NameInMap("baseUrl")]
        [Validation(Required=false)]
        public string BaseUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>通义千问大模型</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("extensions")]
        [Validation(Required=false)]
        public string Extensions { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("inOut")]
        [Validation(Required=false)]
        public string InOut { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>32K</para>
        /// </summary>
        [NameInMap("maxInputLength")]
        [Validation(Required=false)]
        public string MaxInputLength { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8K</para>
        /// </summary>
        [NameInMap("maxOutputLength")]
        [Validation(Required=false)]
        public string MaxOutputLength { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>qwen-turbo</para>
        /// </summary>
        [NameInMap("modelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Chat</para>
        /// </summary>
        [NameInMap("modelType")]
        [Validation(Required=false)]
        public string ModelType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>通义千问</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>alibaba</para>
        /// </summary>
        [NameInMap("symbol")]
        [Validation(Required=false)]
        public string Symbol { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TXT_GEN,DEEP_THINK</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

    }

}
