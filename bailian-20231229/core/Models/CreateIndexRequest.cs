// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class CreateIndexRequest : TeaModel {
        /// <summary>
        /// <para>The files to imported to the knowledge base. Specify the category IDs. All files under the categories will be imported (up to 10,000 files). To add more files later, call <b>SubmitIndexAddDocumentsJob</b>.</para>
        /// </summary>
        [NameInMap("CategoryIds")]
        [Validation(Required=false)]
        public List<string> CategoryIds { get; set; }

        /// <summary>
        /// <para>The chunk size, which is the maximum number of characters in each chunk. Text exceeding this length may be truncated.</para>
        /// <para>Valid values: 1 to 6000. Default value: 500.</para>
        /// <remarks>
        /// <para>If <c>ChunkSize</c> is set to a value less than 100, <c>OverlapSize</c> is required. Or, if you do not pass these two parameters, the system uses the default values of the two.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>128</para>
        /// </summary>
        [NameInMap("ChunkSize")]
        [Validation(Required=false)]
        public int? ChunkSize { get; set; }

        [NameInMap("Columns")]
        [Validation(Required=false)]
        public List<CreateIndexRequestColumns> Columns { get; set; }
        public class CreateIndexRequestColumns : TeaModel {
            [NameInMap("Column")]
            [Validation(Required=false)]
            public string Column { get; set; }

            [NameInMap("IsRecall")]
            [Validation(Required=false)]
            public bool? IsRecall { get; set; }

            [NameInMap("IsSearch")]
            [Validation(Required=false)]
            public bool? IsSearch { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is not available. Do not specify this parameter.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("CreateIndexType")]
        [Validation(Required=false)]
        public string CreateIndexType { get; set; }

        /// <summary>
        /// <remarks>
        /// <para> This parameter is not available. Do not specify this parameter.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("DataSource")]
        [Validation(Required=false)]
        public CreateIndexRequestDataSource DataSource { get; set; }
        public class CreateIndexRequestDataSource : TeaModel {
            /// <summary>
            /// <remarks>
            /// <para> This parameter is not available. Do not specify this parameter.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("CredentialId")]
            [Validation(Required=false)]
            public string CredentialId { get; set; }

            /// <summary>
            /// <remarks>
            /// <para> This parameter is not available. Do not specify this parameter.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("CredentialKey")]
            [Validation(Required=false)]
            public string CredentialKey { get; set; }

            /// <summary>
            /// <remarks>
            /// <para> This parameter is not available. Do not specify this parameter.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Database")]
            [Validation(Required=false)]
            public string Database { get; set; }

            /// <summary>
            /// <remarks>
            /// <para> This parameter is not available. Do not specify this parameter.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <remarks>
            /// <para> This parameter is not available. Do not specify this parameter.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("IsPrivateLink")]
            [Validation(Required=false)]
            public bool? IsPrivateLink { get; set; }

            /// <summary>
            /// <remarks>
            /// <para> This parameter is not available. Do not specify this parameter.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <remarks>
            /// <para> This parameter is not available. Do not specify this parameter.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("SubPath")]
            [Validation(Required=false)]
            public string SubPath { get; set; }

            /// <summary>
            /// <remarks>
            /// <para> This parameter is not available. Do not specify this parameter.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("SubType")]
            [Validation(Required=false)]
            public string SubType { get; set; }

            /// <summary>
            /// <remarks>
            /// <para> This parameter is not available. Do not specify this parameter.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Table")]
            [Validation(Required=false)]
            public string Table { get; set; }

            /// <summary>
            /// <remarks>
            /// <para> This parameter is not available. Do not specify this parameter.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The description of the knowledge base. The description must be 0 to 1,000 characters in length. This parameter is empty by default.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The files to imported to the knowledge base. Specify the file IDs to import (up to 10,000 files). To add more files later, call <b>SubmitIndexAddDocumentsJob</b>.</para>
        /// </summary>
        [NameInMap("DocumentIds")]
        [Validation(Required=false)]
        public List<string> DocumentIds { get; set; }

        /// <summary>
        /// <para>The embedding model used in the knowledge base. The embedding model converts the original input prompt and knowledge text into numerical embeddings for similarity comparison. The default and only model available is text-embedding-v2. It supports multiple languages including Chinese and English and normalizes the embedding results. For more information, see <a href="https://help.aliyun.com/document_detail/2842587.html">Embedding</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>text-embedding-v2</description></item>
        /// </list>
        /// <para>The default value is null, which means using text-embedding-v2.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text-embedding-v2</para>
        /// </summary>
        [NameInMap("EmbeddingModelName")]
        [Validation(Required=false)]
        public string EmbeddingModelName { get; set; }

        /// <summary>
        /// <para>Whether to enable rewriting for multi-turn conversations. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableRewrite")]
        [Validation(Required=false)]
        public bool? EnableRewrite { get; set; }

        /// <summary>
        /// <para>The name of the knowledge base. The name must be 1 to 20 characters in length, and can contain Chinese characters, letters, digits, underscores (_), hyphens (-), periods (.), and colons (:).</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The overlap size, which is the number of overlapping characters between two consecutive chunks. Valid values: 0 to 1024.</para>
        /// <para>Default value: 100.</para>
        /// <remarks>
        /// <para><c>OverlapSize</c> must be less than <c>ChunkSize</c>. Otherwise, chunking errors may occur.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("OverlapSize")]
        [Validation(Required=false)]
        public int? OverlapSize { get; set; }

        /// <summary>
        /// <para>The similarity threshold. Only chunks with a similarity score higher than this value can be recalled. This parameter is used to filter chunks returned by the re-rank model. Valid values: 0.01 to 1.00.</para>
        /// <para>Default value: 0.01.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.20</para>
        /// </summary>
        [NameInMap("RerankMinScore")]
        [Validation(Required=false)]
        public double? RerankMinScore { get; set; }

        /// <summary>
        /// <para>The re-ranking model used in the knowledge base. The re-rank model is a scoring system outside the knowledge base. It calculates the similarity score of the query and text chunks in the knowledge base and ranks them in descending order. Then, the model returns the top K chunks with the highest scores. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>gte-rerank-hybrid</description></item>
        /// <item><description>gte-rerank</description></item>
        /// </list>
        /// <para>The default value is empty, which means using gte-rerank-hybrid.</para>
        /// <remarks>
        /// <para>If you need only semantic ranking, we recommend gte-rerank. If you need both semantic ranking and text matching features to ensure relevance, we recommend gte-rerank-hybrid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>gte-rerank-hybrid</para>
        /// </summary>
        [NameInMap("RerankModelName")]
        [Validation(Required=false)]
        public string RerankModelName { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is not available. Do not specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>,</para>
        /// </summary>
        [NameInMap("Separator")]
        [Validation(Required=false)]
        public string Separator { get; set; }

        /// <summary>
        /// <para>The ID of the AnalyticDB for PostgreSQL instance. Required only when <c>SinkType</c> is set to ADB. Get the ID on the <a href="https://gpdbnext.console.aliyun.com/gpdb/list">Instances</a> page of AnalyticDB for PostgreSQL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-bp321093j84</para>
        /// </summary>
        [NameInMap("SinkInstanceId")]
        [Validation(Required=false)]
        public string SinkInstanceId { get; set; }

        /// <summary>
        /// <para>The region of the AnalyticDB for PostgreSQL instance. Required only when <c>SinkType</c> is set to ADB. Call <a href="https://www.alibabacloud.com/help/zh/analyticdb/analyticdb-for-postgresql/developer-reference/api-gpdb-2016-05-03-describeregions?spm=a2c63.p38356.0.i3">DescribeRegions</a> to obtain the region list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("SinkRegion")]
        [Validation(Required=false)]
        public string SinkRegion { get; set; }

        /// <summary>
        /// <para>The vector storage type of the knowledge base. For more information, see <a href="https://help.aliyun.com/document_detail/2807740.html">Knowledge base</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>BUILT_IN: The vector data is hosted by Alibaba Cloud Model Studio.</description></item>
        /// <item><description>ADB: AnalyticDB for PostgreSQL database. If you need advanced features, such as managing, auditing, and monitoring, we recommend ADB.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you have not used AnalyticDB for AnalyticDB in Model Studio before, go to the <a href="https://bailian.console.alibabacloud.com/#/knowledge-base/create">Create Knowledge Base</a> page, select ADB-PG as Vector Storage Type, and follow the instructions to grant permissions. If you specify ADB, the <c>SinkInstanceId</c> and <c>SinkRegion</c> parameters are required.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DEFAULT</para>
        /// </summary>
        [NameInMap("SinkType")]
        [Validation(Required=false)]
        public string SinkType { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is required in the latest version of the SDK. Otherwise, when you call SubmitIndexJob, an error will occur: Required parameter(data_sources) missing or invalid.</para>
        /// </remarks>
        /// <para>The source of the imported data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DATA_CENTER_CATEGORY: The category type, that is to import all files in one or more specified categories in <a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">Application Data</a>.</description></item>
        /// <item><description>DATA_CENTER_FILE: The file type, that is to import one or more specified files in <a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">Application Data</a>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If set to DATA_CENTER_CATEGORY, <c>CategoryIds</c> is required. If set to DATA_CENTER_FILE, <c>DocumentIds</c> is required.</para>
        /// </remarks>
        /// <remarks>
        /// <para>To create an empty knowledge base, you can use an empty category with no files: Set this parameter to DATA_CENTER_CATEGORY, and <c>CategoryIds</c> to the ID of an empty category.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>DATA_CENTER_FILE</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The type of the knowledge base. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>unstructured: The document search type.</description></item>
        /// </list>
        /// <remarks>
        /// <para>After you create a knowledge base, its type cannot be changed. This operation does not support data query and image Q\&amp;A types. Use the console instead.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>structured</para>
        /// </summary>
        [NameInMap("StructureType")]
        [Validation(Required=false)]
        public string StructureType { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is not available. Do not specify this parameter.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("TableIds")]
        [Validation(Required=false)]
        public List<string> TableIds { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is not available. Do not specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>regex</para>
        /// </summary>
        [NameInMap("chunkMode")]
        [Validation(Required=false)]
        public string ChunkMode { get; set; }

        [NameInMap("connectId")]
        [Validation(Required=false)]
        public string ConnectId { get; set; }

        [NameInMap("database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        [NameInMap("datasourceCode")]
        [Validation(Required=false)]
        public string DatasourceCode { get; set; }

        /// <summary>
        /// <para>Whether to treat the first row of all .xlsx and .xls files as headers and concatenate them into each text chunk. This prevents the models from mistakenly interpreting headers as regular data rows.</para>
        /// <remarks>
        /// <para>Enable this feature only when all imported files are in .xlsx or .xls format and contain headers. Otherwise, leave it disabled.</para>
        /// </remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enableHeaders")]
        [Validation(Required=false)]
        public bool? EnableHeaders { get; set; }

        [NameInMap("knowledgeScene")]
        [Validation(Required=false)]
        public string KnowledgeScene { get; set; }

        /// <summary>
        /// <para>The metadata extraction configurations. Metadata refers to a set of additional attributes associated with unstructured data, which are integrated into text chunks in key-value pairs. For more information, see <a href="https://help.aliyun.com/document_detail/2807740.html">Knowledge base</a>.</para>
        /// </summary>
        [NameInMap("metaExtractColumns")]
        [Validation(Required=false)]
        public List<CreateIndexRequestMetaExtractColumns> MetaExtractColumns { get; set; }
        public class CreateIndexRequestMetaExtractColumns : TeaModel {
            /// <summary>
            /// <para>The description of the metadata field. The description must be 0 to 1,000 characters in length, and can contain Chinese characters, letters, digits, underscores (_), hyphens (-), periods (.), and colons (:). This parameter is left empty by default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AuthorName</para>
            /// </summary>
            [NameInMap("Desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            /// <summary>
            /// <para>When set to true, the key and value of this metadata filed will participate in the generation process of the model, together with the chunk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// <para>Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableLlm")]
            [Validation(Required=false)]
            public bool? EnableLlm { get; set; }

            /// <summary>
            /// <para>When set to true, the key and value of this metadata filed will participate in the knowledge base retrieval, together with the chunk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// <para>Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableSearch")]
            [Validation(Required=false)]
            public bool? EnableSearch { get; set; }

            /// <summary>
            /// <para>The metadata key. It must be 1 to 50 characters in length and must be English letters or underscores. If you specify this parameter, the <c>Value</c> and <c>Type</c> parameters are required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>author</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The type of the metadata field. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>constant</description></item>
            /// <item><description>variable</description></item>
            /// <item><description>custom_prompt</description></item>
            /// <item><description>regular</description></item>
            /// <item><description>keywords</description></item>
            /// </list>
            /// <para>Enumerated value:</para>
            /// <list type="bullet">
            /// <item><description>constant: constant extraction.</description></item>
            /// <item><description>keywords: keyword extraction.</description></item>
            /// <item><description>custom_prompt: LLM.</description></item>
            /// <item><description>variable: variable extraction.</description></item>
            /// <item><description>regular: regular expression.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>constant</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The metadata value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Tim</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pipelineCommercialCu")]
        [Validation(Required=false)]
        public int? PipelineCommercialCu { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("pipelineCommercialType")]
        [Validation(Required=false)]
        public string PipelineCommercialType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>downgrade</para>
        /// </summary>
        [NameInMap("pipelineRetrieveRateLimitStrategy")]
        [Validation(Required=false)]
        public string PipelineRetrieveRateLimitStrategy { get; set; }

        [NameInMap("table")]
        [Validation(Required=false)]
        public string Table { get; set; }

    }

}
