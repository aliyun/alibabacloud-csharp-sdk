// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class ListIndicesResponseBody : TeaModel {
        /// <summary>
        /// <para>HTTP status code</para>
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
                /// <para>The estimated length of chunks. Valid values: [1-2048].</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("ChunkSize")]
                [Validation(Required=false)]
                public int? ChunkSize { get; set; }

                [NameInMap("ConfgModel")]
                [Validation(Required=false)]
                public string ConfgModel { get; set; }

                /// <summary>
                /// <para>The description of the knowledge base.</para>
                /// 
                /// <b>Example:</b>
                /// <para>If each RAM user belongs to a RAM group, the configuration is considered compliant.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The list of the primary key IDs of the documents.</para>
                /// </summary>
                [NameInMap("DocumentIds")]
                [Validation(Required=false)]
                public List<string> DocumentIds { get; set; }

                /// <summary>
                /// <para>The name of the embedding model. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>text-embedding-v2</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>conv-rewrite-qwen-1.8b</para>
                /// </summary>
                [NameInMap("EmbeddingModelName")]
                [Validation(Required=false)]
                public string EmbeddingModelName { get; set; }

                [NameInMap("EnableRewrite")]
                [Validation(Required=false)]
                public bool? EnableRewrite { get; set; }

                /// <summary>
                /// <para>The primary key ID of the knowledge base, which is the <c>Data.Id</c> parameter returned by the <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-createindex">CreateIndex</a> operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>259899</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The name of the knowledge base.</para>
                /// 
                /// <b>Example:</b>
                /// <para>temp_mUB4j</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The overlap length. Valid values: [0-1024].</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("OverlapSize")]
                [Validation(Required=false)]
                public int? OverlapSize { get; set; }

                /// <summary>
                /// <para>Similarity Threshold Valid values: [0.01-1.00].</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.01</para>
                /// </summary>
                [NameInMap("RerankMinScore")]
                [Validation(Required=false)]
                public string RerankMinScore { get; set; }

                /// <summary>
                /// <para>The name of the rank model. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>gte-rerank-hybrid</description></item>
                /// <item><description>gte-rerank</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>gte-rerank-hybrid</para>
                /// </summary>
                [NameInMap("RerankModelName")]
                [Validation(Required=false)]
                public string RerankModelName { get; set; }

                /// <summary>
                /// <para>The clause identifier. Separate multiple clause identifiers with |. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>\n: line break</description></item>
                /// <item><description>，: Chinese comma</description></item>
                /// <item><description>,: English comma</description></item>
                /// <item><description>。 : Chinese full stop</description></item>
                /// <item><description>.: English full stop</description></item>
                /// <item><description>！ : Chinese exclamation point</description></item>
                /// <item><description>! : English exclamation point</description></item>
                /// <item><description>；: Chinese semicolon</description></item>
                /// <item><description>;: English semicolon</description></item>
                /// <item><description>？ : Chinese question mark</description></item>
                /// <item><description>?: English question mark</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>\n</para>
                /// </summary>
                [NameInMap("Separator")]
                [Validation(Required=false)]
                public string Separator { get; set; }

                /// <summary>
                /// <para>The ID of the vector storage instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gp-bp1gq62t1788yw2ol</para>
                /// </summary>
                [NameInMap("SinkInstanceId")]
                [Validation(Required=false)]
                public string SinkInstanceId { get; set; }

                /// <summary>
                /// <para>The region of the vector storage instance.</para>
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
                /// <item><description>ES: Built-in vector database.</description></item>
                /// <item><description>BUILT_IN: Built-in vector database.</description></item>
                /// <item><description>ADB: AnalyticDB for PostgreSQL database.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>es</para>
                /// </summary>
                [NameInMap("SinkType")]
                [Validation(Required=false)]
                public string SinkType { get; set; }

                /// <summary>
                /// <para>The data type of <a href="https://bailian.console.aliyun.com/#/data-center">Data Management</a>. For unstructured knowledge base, possible values:</para>
                /// <list type="bullet">
                /// <item><description>DATA_CENTER_CATEGORY: The category type.</description></item>
                /// <item><description>DATA_CENTER_FILE: The document type.</description></item>
                /// </list>
                /// <para>For structured knowledge base, possible values:</para>
                /// <list type="bullet">
                /// <item><description>DATA_CENTER_STRUCTURED_TABLE: The data table type.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DATA_CENTER_FILE</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The vector storage type of the knowledge base. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>UNSTRUCTURED</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>structured</para>
                /// </summary>
                [NameInMap("StructureType")]
                [Validation(Required=false)]
                public string StructureType { get; set; }

            }

            /// <summary>
            /// <para>The specified page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The specified number of documents on each page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of knowledge bases returned.</para>
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
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indications whether the API call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
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
