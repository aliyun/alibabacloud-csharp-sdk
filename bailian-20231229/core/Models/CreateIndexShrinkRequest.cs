// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class CreateIndexShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of primary key IDs of the categories to be imported into the knowledge base.</para>
        /// </summary>
        [NameInMap("CategoryIds")]
        [Validation(Required=false)]
        public string CategoryIdsShrink { get; set; }

        /// <summary>
        /// <para>The estimated length of chunks. The maximum number of characters for a chunk. Texts exceeding this limit are splited. For more information, see <a href="https://www.alibabacloud.com/help/en/model-studio/user-guide/rag-knowledge-base">Create a knowledge base</a>. Valid values: [1-2048].</para>
        /// <para>The default value is empty, which means using the intelligent splitting method.</para>
        /// <remarks>
        /// <para> If you specify the <c>ChunkSize</c> parameter, you must also specify the <c>OverlapSize</c> and <c>Separator</c> parameters. If you do not specify these three parameters, the system uses the intelligent splitting method by default.</para>
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
        public string ColumnsShrink { get; set; }

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
        public string DataSourceShrink { get; set; }

        /// <summary>
        /// <para>The description of the knowledge base. The description must be 0 to 1,000 characters in length. This parameter is empty by default.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The list of primary key IDs of the documents to be imported into the knowledge base.</para>
        /// </summary>
        [NameInMap("DocumentIds")]
        [Validation(Required=false)]
        public string DocumentIdsShrink { get; set; }

        /// <summary>
        /// <para>The name of the embedding model. The embedding model converts the original input prompt and knowledge text into numerical vectors for similarity comparison. The default and only model available is DashScope text-embedding-v2. It supports multiple languages including Chinese and English and normalizes the vector results. For more information, see <a href="https://www.alibabacloud.com/help/en/model-studio/user-guide/rag-knowledge-base">Create a knowledge base</a>. Valid value:</para>
        /// <list type="bullet">
        /// <item><description>text-embedding-v2</description></item>
        /// </list>
        /// <para>The default value is null, which means using the text-embedding-v2 model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text-embedding-v2</para>
        /// </summary>
        [NameInMap("EmbeddingModelName")]
        [Validation(Required=false)]
        public string EmbeddingModelName { get; set; }

        [NameInMap("EnableRewrite")]
        [Validation(Required=false)]
        public bool? EnableRewrite { get; set; }

        /// <summary>
        /// <para>The name of the knowledge base. The name must be 1 to 20 characters in length and can contain characters classified as letter in Unicode, including English letters, Chinese characters, digits, among others. The name can also contain colons (:), underscores (_), periods (.), and hyphens (-).</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The overlap length. The number of overlapping characters between two consecutive chunks. For more information, see <a href="https://www.alibabacloud.com/help/en/model-studio/user-guide/rag-knowledge-base">Create a knowledge base</a>. Valid values: 0 to 1024.</para>
        /// <para>The default value is empty, which means using the intelligent splitting method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("OverlapSize")]
        [Validation(Required=false)]
        public int? OverlapSize { get; set; }

        /// <summary>
        /// <para>Similarity Threshold. The lowest similarity score of chunks that can be returned. This parameter is used to filter text chunks returned by the rank model. For more information, see <a href="https://www.alibabacloud.com/help/en/model-studio/user-guide/rag-knowledge-base">Create a knowledge base</a>. Valid values: [0.01-1.00].</para>
        /// <para>Default value: 0.20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.20</para>
        /// </summary>
        [NameInMap("RerankMinScore")]
        [Validation(Required=false)]
        public double? RerankMinScore { get; set; }

        /// <summary>
        /// <para>The name of the rank model. The rank model is a scoring system outside the knowledge base. It calculates the similarity score of each text chunk in the input question and knowledge base and ranks them in descending order. Then, the model returns the top K chunks with the highest scores. For more information, see <a href="https://www.alibabacloud.com/help/en/model-studio/user-guide/rag-knowledge-base">Create a knowledge base</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>gte-rerank-hybrid</description></item>
        /// <item><description>gte-rerank</description></item>
        /// </list>
        /// <para>The default value is empty, which means using the official gte-rerank-hybrid model.</para>
        /// <remarks>
        /// <para> If you need only semantic ranking, we recommend that you use gte-rerank. If you need both semantic ranking and text matching features to ensure relevance, we recommend that you use gte-rerank-hybrid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>gte-rerank-hybrid</para>
        /// </summary>
        [NameInMap("RerankModelName")]
        [Validation(Required=false)]
        public string RerankModelName { get; set; }

        /// <summary>
        /// <para>The clause identifier. The document is split into chunks based on this identifier. For more information, see <a href="https://www.alibabacloud.com/help/en/model-studio/user-guide/rag-knowledge-base">Create a knowledge base</a>. You can specify multiple identifiers and do not need to add any other characters to separate them. For example: !,\\\n. Valid values:</para>
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
        /// <item><description>？: Chinese question mark</description></item>
        /// <item><description>?: English question mark</description></item>
        /// </list>
        /// <para>The default value is empty, which means using the intelligent splitting method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>,</para>
        /// </summary>
        [NameInMap("Separator")]
        [Validation(Required=false)]
        public string Separator { get; set; }

        /// <summary>
        /// <para>The ID of the vector storage instance. This parameter is available only when SinkType is set to ADB. You can view the ID on the <a href="https://gpdbnext.console.aliyun.com/gpdb/list">Instances</a> page of AnalyticDB for PostgreSQL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-bp321093j84</para>
        /// </summary>
        [NameInMap("SinkInstanceId")]
        [Validation(Required=false)]
        public string SinkInstanceId { get; set; }

        /// <summary>
        /// <para>The region of the vector storage instance. This parameter is available only when SinkType is set to ADB. You can call the <a href="https://www.alibabacloud.com/help/en/analyticdb/analyticdb-for-postgresql/developer-reference/api-gpdb-2016-05-03-describeregions">DescribeRegions</a> operation to query the most recent region list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("SinkRegion")]
        [Validation(Required=false)]
        public string SinkRegion { get; set; }

        /// <summary>
        /// <para>The vector storage type of the knowledge base. For more information, see <a href="https://www.alibabacloud.com/help/en/model-studio/user-guide/rag-knowledge-base">Create a knowledge base</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DEFAULT: The built-in vector database.</description></item>
        /// <item><description>ADB: AnalyticDB for PostgreSQL database. If you need advanced features, such as managing, auditing, and monitoring, we recommend that you specify ADB.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you have not used AnalyticDB for AnalyticDB in Model Studio before, go to the <a href="https://bailian.console.aliyun.com/#/knowledge-base/create">Create Knowledge Base</a> page, select ADB-PG as Vector Storage Type, and follow the instructions to grant permissions. If you specify ADB, you must also specify the <c>SinkInstanceId</c> and <c>SinkRegion</c> parameters.</para>
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
        /// <para>The data type of <a href="https://bailian.console.aliyun.com/#/data-center">Data Management</a>. For more information, see <a href="https://www.alibabacloud.com/help/en/model-studio/user-guide/rag-knowledge-base">Create a knowledge base</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DATA_CENTER_CATEGORY: The category type. Import all documents from one or more categories in Data Center.</description></item>
        /// <item><description>DATA_CENTER_FILE: The document type. Import one or more documents from Data Center.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If this parameter is set to DATA_CENTER_CATEGORY, you must specify the <c>CategoryIds</c> parameter. If this parameter is set to DATA_CENTER_FILE, you must specify the <c>DocumentIds</c> parameter.</para>
        /// </remarks>
        /// <remarks>
        /// <para> If you want to create an empty knowledge base, you can use an empty category. Set this parameter to DATA_CENTER_CATEGORY. And specify the ID of an empty category for the <c>CategoryIds</c> parameter.</para>
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
        /// <para>The data type of the knowledge base. For more information, see <a href="https://www.alibabacloud.com/help/en/model-studio/user-guide/rag-knowledge-base">Create a knowledge base</a>. Valid value:</para>
        /// <list type="bullet">
        /// <item><description>unstructured</description></item>
        /// </list>
        /// <remarks>
        /// <para> After a knowledge base is created, its data type cannot be changed. You cannot create a structured knowledge base by calling an API operation. Use the console instead.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>structured</para>
        /// </summary>
        [NameInMap("StructureType")]
        [Validation(Required=false)]
        public string StructureType { get; set; }

        [NameInMap("TableIds")]
        [Validation(Required=false)]
        public string TableIdsShrink { get; set; }

        [NameInMap("chunkMode")]
        [Validation(Required=false)]
        public string ChunkMode { get; set; }

        [NameInMap("enableHeaders")]
        [Validation(Required=false)]
        public bool? EnableHeaders { get; set; }

        [NameInMap("metaExtractColumns")]
        [Validation(Required=false)]
        public string MetaExtractColumnsShrink { get; set; }

    }

}
