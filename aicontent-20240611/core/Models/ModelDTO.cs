// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelDTO : TeaModel {
        /// <summary>
        /// <para>The API key preview.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sk-xxx****xxx</para>
        /// </summary>
        [NameInMap("apiKeyPreview")]
        [Validation(Required=false)]
        public string ApiKeyPreview { get; set; }

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
        /// <para>A value of 0 indicates enabled, and a non-zero value indicates disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("deleteTag")]
        [Validation(Required=false)]
        public int? DeleteTag { get; set; }

        /// <summary>
        /// <para>The model description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Qwen large language model</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("extensions")]
        [Validation(Required=false)]
        public string Extensions { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-01-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <para>The update time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-01-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>Indicates whether a billing rule is configured.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("hasBillingRule")]
        [Validation(Required=false)]
        public bool? HasBillingRule { get; set; }

        /// <summary>
        /// <para>ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("inOut")]
        [Validation(Required=false)]
        public string InOut { get; set; }

        /// <summary>
        /// <para>Indicates whether the model is custom.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("isCustom")]
        [Validation(Required=false)]
        public bool? IsCustom { get; set; }

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
        /// <para>The model identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen-turbo</para>
        /// </summary>
        [NameInMap("modelCode")]
        [Validation(Required=false)]
        public string ModelCode { get; set; }

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
        /// <para>Qwen</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The vendor symbol.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alibaba</para>
        /// </summary>
        [NameInMap("symbol")]
        [Validation(Required=false)]
        public string Symbol { get; set; }

        /// <summary>
        /// <para>The tag display names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Conversation, natural language processing</para>
        /// </summary>
        [NameInMap("tagNames")]
        [Validation(Required=false)]
        public string TagNames { get; set; }

        /// <summary>
        /// <para>The tags, separated by commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>chat,NLP</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// <para>The version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public int? Version { get; set; }

    }

}
