// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelRouterBatchCreateModelRequest : TeaModel {
        /// <summary>
        /// <para>The API key. This parameter is required. The key is shared by the same provider and reused by all models.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sk-xxxxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("apiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// <para>The base URL. This parameter is optional. Specify this parameter when you use a custom gateway address. If you do not specify this parameter, the default address of the provider is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://dashscope.aliyuncs.com/compatible-mode/v1">https://dashscope.aliyuncs.com/compatible-mode/v1</a></para>
        /// </summary>
        [NameInMap("baseUrl")]
        [Validation(Required=false)]
        public string BaseUrl { get; set; }

        /// <summary>
        /// <para>The list of models to create in batches. This parameter is required. At least one item must be specified.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("models")]
        [Validation(Required=false)]
        public List<BatchCreateModelItemDTO> Models { get; set; }

        /// <summary>
        /// <para>The provider symbol. This parameter is required. All models items share the same provider.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen</para>
        /// </summary>
        [NameInMap("symbol")]
        [Validation(Required=false)]
        public string Symbol { get; set; }

    }

}
