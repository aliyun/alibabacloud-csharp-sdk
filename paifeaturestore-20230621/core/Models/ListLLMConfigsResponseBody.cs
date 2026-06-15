// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class ListLLMConfigsResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of LLM configuration objects.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("LLMConfigs")]
        [Validation(Required=false)]
        public List<ListLLMConfigsResponseBodyLLMConfigs> LLMConfigs { get; set; }
        public class ListLLMConfigsResponseBodyLLMConfigs : TeaModel {
            /// <summary>
            /// <para>The API key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>apikey-abcdxy</para>
            /// </summary>
            [NameInMap("ApiKey")]
            [Validation(Required=false)]
            public string ApiKey { get; set; }

            /// <summary>
            /// <para>The base URL for API calls.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://dashscope.aliyuncs.com/compatible-mode/v1">https://dashscope.aliyuncs.com/compatible-mode/v1</a></para>
            /// </summary>
            [NameInMap("BaseUrl")]
            [Validation(Required=false)]
            public string BaseUrl { get; set; }

            /// <summary>
            /// <para>The batch size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("BatchSize")]
            [Validation(Required=false)]
            public int? BatchSize { get; set; }

            /// <summary>
            /// <para>The embedding dimension. If this parameter is empty or set to 0, the system uses the model\&quot;s default dimension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("EmbeddingDimension")]
            [Validation(Required=false)]
            public int? EmbeddingDimension { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the Fusion feature.</para>
            /// </summary>
            [NameInMap("EnableFusion")]
            [Validation(Required=false)]
            public bool? EnableFusion { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-07-04T11:26:09.036+08:00</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <para>The modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-07-04T11:26:09.036+08:00</para>
            /// </summary>
            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            /// <summary>
            /// <para>The LLM configuration ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>llm_config1</para>
            /// </summary>
            [NameInMap("LLMConfigId")]
            [Validation(Required=false)]
            public string LLMConfigId { get; set; }

            /// <summary>
            /// <para>The maximum number of tokens to process for a single input.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2048</para>
            /// </summary>
            [NameInMap("MaxTokens")]
            [Validation(Required=false)]
            public int? MaxTokens { get; set; }

            /// <summary>
            /// <para>The model name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>text-embedding-v1</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <para>The model type.</para>
            /// </summary>
            [NameInMap("ModelType")]
            [Validation(Required=false)]
            public string ModelType { get; set; }

            /// <summary>
            /// <para>The name of the LLM configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>llm_config_name1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aek2vtzqjaohzqi</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The maximum number of requests per second (RPS).</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Rps")]
            [Validation(Required=false)]
            public int? Rps { get; set; }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>234</para>
            /// </summary>
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of results returned in this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for retrieving the next page of results. If this parameter is not returned, no more results are available. To retrieve the next page, pass this value in the <c>NextToken</c> parameter of a subsequent request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6mbU5D/SFHCHMApYkMcWlp5</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>898DB17C-09E9-5C41-909D-269BA183EB92</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
