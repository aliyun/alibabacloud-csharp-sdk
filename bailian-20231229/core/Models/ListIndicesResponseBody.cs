// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class ListIndicesResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Index.InvalidParameter</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListIndicesResponseBodyData Data { get; set; }
        public class ListIndicesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of knowledge bases.</para>
            /// </summary>
            [NameInMap("Indices")]
            [Validation(Required=false)]
            public List<ListIndicesResponseBodyDataIndices> Indices { get; set; }
            public class ListIndicesResponseBodyDataIndices : TeaModel {
                /// <summary>
                /// <para>The estimated chunk length. Valid values: 1 to 2048.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("ChunkSize")]
                [Validation(Required=false)]
                public int? ChunkSize { get; set; }

                /// <summary>
                /// <para>The configuration mode used by this knowledge base. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>recommend: recommended configuration.</description></item>
                /// <item><description>user-defined: custom configuration.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>recommend</para>
                /// </summary>
                [NameInMap("ConfgModel")]
                [Validation(Required=false)]
                public string ConfgModel { get; set; }

                /// <summary>
                /// <para>The description of the knowledge base.</para>
                /// 
                /// <b>Example:</b>
                /// <para>清单中产品主要面向海外客户。</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The list of file IDs.</para>
                /// </summary>
                [NameInMap("DocumentIds")]
                [Validation(Required=false)]
                public List<string> DocumentIds { get; set; }

                /// <summary>
                /// <para>The name of the embedding model. Valid values:</para>
                /// <para>&lt;props=&quot;china&quot;&gt;</para>
                /// <list type="bullet">
                /// <item><description>text-embedding-v4: the text-embedding-v4 model.</description></item>
                /// <item><description>text-embedding-v3: the text-embedding-v3 model.</description></item>
                /// <item><description>text-embedding-v2: the text-embedding-v2 model.</description></item>
                /// </list>
                /// <para>&lt;props=&quot;intl&quot;&gt;</para>
                /// <list type="bullet">
                /// <item><description>text-embedding-v2: the text-embedding-v2 model.</description></item>
                /// </list>
                /// <para>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>text-embedding-v2</para>
                /// </summary>
                [NameInMap("EmbeddingModelName")]
                [Validation(Required=false)]
                public string EmbeddingModelName { get; set; }

                /// <summary>
                /// <para>Indicates whether &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/model-studio/use-cases/rag-optimization#b7031e2ad6cji">multi-turn conversation rewriting</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/model-studio/use-cases/rag-optimization#b7031e2ad6cji">multi-turn conversation rewriting</a> is enabled for this knowledge base. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Enabled.</description></item>
                /// <item><description>false: Disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("EnableRewrite")]
                [Validation(Required=false)]
                public bool? EnableRewrite { get; set; }

                /// <summary>
                /// <para>The knowledge base ID, which is the <c>Data.Id</c> returned by the <b>CreateIndex</b> operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lecxr5xxxx</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The name of the knowledge base.</para>
                /// 
                /// <b>Example:</b>
                /// <para>XXXX产品清单</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The chunk overlap length. Valid values: 0 to 1024.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("OverlapSize")]
                [Validation(Required=false)]
                public int? OverlapSize { get; set; }

                /// <summary>
                /// <para>The similarity threshold. Valid values: 0.01 to 1.00.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.01</para>
                /// </summary>
                [NameInMap("RerankMinScore")]
                [Validation(Required=false)]
                public string RerankMinScore { get; set; }

                /// <summary>
                /// <para>The name of the rerank model. Valid values:</para>
                /// <para>&lt;props=&quot;china&quot;&gt;</para>
                /// <list type="bullet">
                /// <item><description>qwen3-rerank-hybrid: qwen3-rerank (hybrid) reranking.</description></item>
                /// <item><description>qwen3-rerank: qwen3-rerank reranking.</description></item>
                /// <item><description>gte-rerank-hybrid: gte-rerank (hybrid) reranking.</description></item>
                /// <item><description>gte-rerank: gte-rerank reranking.</description></item>
                /// </list>
                /// <para>&lt;props=&quot;intl&quot;&gt;</para>
                /// <list type="bullet">
                /// <item><description>gte-rerank-hybrid: official reranking.</description></item>
                /// <item><description>gte-rerank: gte-rerank reranking.</description></item>
                /// </list>
                /// <para>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gte-rerank-hybrid</para>
                /// </summary>
                [NameInMap("RerankModelName")]
                [Validation(Required=false)]
                public string RerankModelName { get; set; }

                /// <summary>
                /// <para>The sentence separator. If multiple separators are used, they are separated by |. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>\
                /// : line break</description></item>
                /// <item><description>，: Chinese comma</description></item>
                /// <item><description>,: English comma</description></item>
                /// <item><description>。: Chinese period</description></item>
                /// <item><description>.: English period</description></item>
                /// <item><description>！: Chinese exclamation mark</description></item>
                /// <item><description>!: English exclamation mark</description></item>
                /// <item><description>；: Chinese semicolon</description></item>
                /// <item><description>;: English semicolon</description></item>
                /// <item><description>？: Chinese question mark</description></item>
                /// <item><description>?: English question mark.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>\n</para>
                /// </summary>
                [NameInMap("Separator")]
                [Validation(Required=false)]
                public string Separator { get; set; }

                /// <summary>
                /// <para>The instance ID of the vector storage for the knowledge base.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gp-bp1gq62t1788yxxxx</para>
                /// </summary>
                [NameInMap("SinkInstanceId")]
                [Validation(Required=false)]
                public string SinkInstanceId { get; set; }

                /// <summary>
                /// <para>The region of the vector storage instance for the knowledge base.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("SinkRegion")]
                [Validation(Required=false)]
                public string SinkRegion { get; set; }

                /// <summary>
                /// <para>The vector storage type of the knowledge base. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ES: built-in vector database.</description></item>
                /// <item><description>BUILT_IN: built-in vector database.</description></item>
                /// <item><description>ADB: AnalyticDB for PostgreSQL database.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>BUILT_IN</para>
                /// </summary>
                [NameInMap("SinkType")]
                [Validation(Required=false)]
                public string SinkType { get; set; }

                /// <summary>
                /// <para>The data type of Alibaba Cloud Model Studio &lt;props=&quot;china&quot;&gt;<a href="https://bailian.console.aliyun.com/?tab=app#/data-center">application data</a>&lt;props=&quot;intl&quot;&gt;<a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">application data</a>.</para>
                /// <para>For document search&lt;props=&quot;china&quot;&gt;/audio and video search knowledge bases, valid values:</para>
                /// <list type="bullet">
                /// <item><description>DATA_CENTER_CATEGORY: category type.</description></item>
                /// <item><description>DATA_CENTER_FILE: file type.</description></item>
                /// </list>
                /// <para>For data query/image Q&amp;A knowledge bases, valid values:</para>
                /// <list type="bullet">
                /// <item><description>DATA_CENTER_STRUCTURED_TABLE: data table type.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DATA_CENTER_FILE</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The type of the knowledge base. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>UNSTRUCTURED: document search.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>UNSTRUCTURED</para>
                /// </summary>
                [NameInMap("StructureType")]
                [Validation(Required=false)]
                public string StructureType { get; set; }

            }

            /// <summary>
            /// <para>The page number returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>48</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Required parameter(%s) missing or invalid, please check the request parameters.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17204B98-xxxx-4F9A-8464-2446A84821CA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status code returned by the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Successful.</description></item>
        /// <item><description>false: Failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
