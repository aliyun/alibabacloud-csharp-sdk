// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class CreateIndexShrinkRequest : TeaModel {
        /// <summary>
        /// <para>You can import files synchronously when you create a knowledge base. Here, you can import all files under a specified category by specifying the category ID. We recommend that you import no more than 500 files. If you have remaining files, you can call the <b>SubmitIndexAddDocumentsJob</b> operation to continue importing them later.</para>
        /// </summary>
        [NameInMap("CategoryIds")]
        [Validation(Required=false)]
        public string CategoryIdsShrink { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para>The chunk size, which is the maximum number of characters in each text chunk. If the text exceeds this length:</para>
        /// <list type="bullet">
        /// <item><description><b>Intelligent chunking</b> (chunkMode is not specified): The text is highly likely to be truncated.</description></item>
        /// <item><description><b>Custom chunking</b> (chunkMode is specified): The text is forcibly truncated.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;
        /// The chunk size, which is the maximum number of characters in each text chunk. If the text exceeds this length, it is highly likely to be truncated.</para>
        /// <para>Valid values: [1, 6000]. Default value: 500.</para>
        /// <remarks>
        /// <para>If you set ChunkSize to a value less than 100, you must also set OverlapSize. You can also leave these two parameters unspecified, and the system uses the default values.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>128</para>
        /// </summary>
        [NameInMap("ChunkSize")]
        [Validation(Required=false)]
        public int? ChunkSize { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;
        /// The structure of the data table, such as column names and types.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <remarks>
        /// <para>This parameter is not available. Do not pass this parameter.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Columns")]
        [Validation(Required=false)]
        public string ColumnsShrink { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is not available. Do not pass this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("CreateIndexType")]
        [Validation(Required=false)]
        public string CreateIndexType { get; set; }

        /// <summary>
        /// <para>The description of the knowledge base. The description must be 0 to 200 characters in length and can contain English and Chinese characters.
        /// Default value: empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The enterprise help document library includes important materials such as company policies and product lists</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>You can import files synchronously when you create a knowledge base. Here, you can specify the list of files to be imported by passing file IDs. We recommend that you import no more than 10,000 files. If you have remaining files, you can call the <b>SubmitIndexAddDocumentsJob</b> operation to continue importing them later.</para>
        /// </summary>
        [NameInMap("DocumentIds")]
        [Validation(Required=false)]
        public string DocumentIdsShrink { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para>The embedding model used by the knowledge base. The embedding model is used to transform the original input prompt and knowledge text into numerical vectors for similarity comparison. Compared with the text-embedding-v3 model, the text-embedding-v4 model is comprehensively upgraded in terms of language support, code snippet vectorization effect, and selection of vector dimensions, and is suitable for most scenarios. For more information, refer to <a href="https://help.aliyun.com/document_detail/2842587.html">Quantization</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>text-embedding-v4</description></item>
        /// <item><description>text-embedding-v3</description></item>
        /// </list>
        /// <para>Default value: empty. In this case, the text-embedding-v3 model is used.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <para>The embedding model used by the knowledge base. The embedding model is used to transform the original input prompt and knowledge text into numerical vectors for similarity comparison. The default text-embedding-v2 model (which cannot be changed at the moment) supports not only Chinese and English but also multiple other languages, and performs normalization on the vector results. For more information, refer to <a href="https://help.aliyun.com/document_detail/2842587.html">Quantization</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>text-embedding-v2</description></item>
        /// </list>
        /// <para>Default value: empty. In this case, the text-embedding-v2 model is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text-embedding-v4</para>
        /// </summary>
        [NameInMap("EmbeddingModelName")]
        [Validation(Required=false)]
        public string EmbeddingModelName { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable multi-turn conversation rewriting. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enabled.</description></item>
        /// <item><description>false: disabled.</description></item>
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
        /// <para>The name of the knowledge base. The name must be 1 to 20 characters in length and can contain Chinese characters, English letters, digits, underscores (_), hyphens (-), periods (.), and colons (:).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enterprise help document library</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The chunk overlap size, which indicates the number of overlapping characters between the current text chunk and the previous text chunk. Valid values: [0, 1024].</para>
        /// <para>Default value: 100.</para>
        /// <remarks>
        /// <para>OverlapSize must be less than ChunkSize. Otherwise, chunking exceptions occur.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("OverlapSize")]
        [Validation(Required=false)]
        public int? OverlapSize { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;intl&quot;&gt;This parameter is not available. Do not specify this parameter.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;Provides a natural language instruction to fine-tune the behavior of the reranking model.
        /// <notice>This parameter takes effect only when rerank_mode is set to &quot;custom&quot;.</notice></para>
        /// 
        /// <b>Example:</b>
        /// <para>Given a web search query, retrieve relevant passages that answer the query.</para>
        /// </summary>
        [NameInMap("RerankInstruct")]
        [Validation(Required=false)]
        public string RerankInstruct { get; set; }

        /// <summary>
        /// <para>The similarity threshold. Only text chunks with a similarity score greater than this value are recalled. This parameter is used to filter the text chunks returned by the reranking model. Valid values: [0.01, 1.00].</para>
        /// <para>Default value: 0.01.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.20</para>
        /// </summary>
        [NameInMap("RerankMinScore")]
        [Validation(Required=false)]
        public double? RerankMinScore { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;
        /// Specifies the instruction intervention mode of the reranking model to determine its scoring preference. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>qa</b>: question answering mode. This is the default value. The model tends to assign higher scores to candidates that can directly answer the query. We recommend that you use this mode in question answering scenarios.</para>
        /// </description></item>
        /// <item><description><para><b>similar</b>: similarity mode. The model tends to assign higher scores to candidates that are highly consistent with the query content. We recommend that you use this mode in matching and retrieval scenarios.</para>
        /// </description></item>
        /// <item><description><para><b>custom</b>: custom mode. The ranking behavior of the model is determined by the instruction in the rerank_instruct parameter.</para>
        /// </description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;This parameter is not available. Do not specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qa</para>
        /// </summary>
        [NameInMap("RerankMode")]
        [Validation(Required=false)]
        public string RerankMode { get; set; }

        /// <summary>
        /// <para>The reranking model used by the knowledge base. The reranking model is a scoring system external to the knowledge base. It calculates the similarity score between the user\&quot;s question and each text chunk in the knowledge base, sorts the chunks in descending order of the scores, and returns the top K text chunks with the highest scores. Valid values:</para>
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
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para>Default value: empty. In this case, qwen3-rerank is used.</para>
        /// <remarks>
        /// <para>If you only need semantic reranking, you can use qwen3-rerank. If you need both semantic reranking and text matching features to ensure relevance, use qwen3-rerank-hybrid.</para>
        /// </remarks>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <para>Default value: empty. In this case, gte-rerank-hybrid is used.</para>
        /// <remarks>
        /// <para>If you only need semantic reranking, you can use gte-rerank. If you need both semantic reranking and text matching features to ensure relevance, use gte-rerank-hybrid.</para>
        /// </remarks>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <remarks>
        /// <para>gte-rerank-hybrid and gte-rerank will stop receiving updates and are not recommended.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>gte-rerank-hybrid</para>
        /// </summary>
        [NameInMap("RerankModelName")]
        [Validation(Required=false)]
        public string RerankModelName { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para>The sentence separator. This parameter takes effect only when chunkMode is set to <b>regex</b>. In other modes, this parameter does not take effect even if it is passed. You can pass a regular expression (multiple regular expressions are not supported) to split the file into small text chunks.</para>
        /// <para>When you use intelligent chunking (chunkMode is not specified), leave this parameter empty.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <remarks>
        /// <para>This parameter is not available. Do not pass this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>(?&lt;=。)</para>
        /// </summary>
        [NameInMap("Separator")]
        [Validation(Required=false)]
        public string Separator { get; set; }

        /// <summary>
        /// <para>The ID of the AnalyticDB for PostgreSQL instance. This parameter is required only when SinkType is set to ADB. Go to the <a href="https://gpdbnext.console.aliyun.com/gpdb/list">AnalyticDB for PostgreSQL Instance List</a> page to obtain the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-bp32109xxxx</para>
        /// </summary>
        [NameInMap("SinkInstanceId")]
        [Validation(Required=false)]
        public string SinkInstanceId { get; set; }

        /// <summary>
        /// <para>The region where the AnalyticDB for PostgreSQL instance resides. This parameter is required only when SinkType is set to ADB. You can call the &lt;props=&quot;china&quot;&gt;<a href="https://www.alibabacloud.com/help/en/analyticdb-for-postgresql/developer-reference/api-gpdb-2016-05-03-describeregions">DescribeRegions</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/analyticdb/analyticdb-for-postgresql/developer-reference/api-gpdb-2016-05-03-describeregions?spm=a2c63.p38356.0.i3">DescribeRegions</a> operation to obtain the region list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("SinkRegion")]
        [Validation(Required=false)]
        public string SinkRegion { get; set; }

        /// <summary>
        /// <para>The vector storage type of the knowledge base. For more information, refer to <a href="https://help.aliyun.com/document_detail/2807740.html">Knowledge base</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>BUILT_IN: stores vector data in Alibaba Cloud Model Studio.</description></item>
        /// <item><description>ADB: AnalyticDB for PostgreSQL database. If you need advanced features such as managing, auditing, and monitoring the database, select ADB.<remarks>
        /// <para>If you have not used ADB storage in Alibaba Cloud Model Studio, go to the &lt;props=&quot;china&quot;&gt;<a href="https://bailian.console.aliyun.com/#/knowledge-base/create">Create Knowledge Base</a>&lt;props=&quot;intl&quot;&gt;<a href="https://bailian.console.alibabacloud.com/#/knowledge-base/create">Create Knowledge Base</a> page, select ADB-PG as the vector storage type, and complete the authorization as prompted. If you pass ADB, you must specify the SinkInstanceId and SinkRegion parameters.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BUILT_IN</para>
        /// </summary>
        [NameInMap("SinkType")]
        [Validation(Required=false)]
        public string SinkType { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>Notice: This parameter is required in the latest SDK version. Otherwise, an error is reported when you call the SubmitIndexJob operation: Required parameter(data_sources) missing or invalid.</notice></para>
        /// </remarks>
        /// <para>The source of the imported data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DATA_CENTER_CATEGORY: the category type. This value indicates that all files under a specified category in &lt;props=&quot;china&quot;&gt;<a href="https://bailian.console.aliyun.com/?tab=app#/data-center">Application Data</a>&lt;props=&quot;intl&quot;&gt;<a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">Application Data</a> are imported. You can import multiple categories at a time.</description></item>
        /// <item><description>DATA_CENTER_FILE: the file type. This value indicates that specified files in &lt;props=&quot;china&quot;&gt;<a href="https://bailian.console.aliyun.com/?tab=app#/data-center">Application Data</a>&lt;props=&quot;intl&quot;&gt;<a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">Application Data</a> are imported. You can import multiple files at a time.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you set this parameter to DATA_CENTER_CATEGORY, you must specify the CategoryIds parameter. If you set this parameter to DATA_CENTER_FILE, you must specify the DocumentIds parameter.</para>
        /// </remarks>
        /// <remarks>
        /// <para>To create an empty knowledge base, you can use an empty category that contains no files: set this parameter to DATA_CENTER_CATEGORY and set CategoryIds to the ID of the empty category.</para>
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
        /// <para>The type of the knowledge base.</para>
        /// <para><b>Valid values</b>:</para>
        /// <list type="bullet">
        /// <item><description>unstructured: a knowledge base for document search or audio and video. The default use scenario for the document search type is basic document question answering. &lt;props=&quot;china&quot;&gt;To create a knowledge base for other scenarios, you must also pass the knowledgeType and knowledgeScene parameters.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>structured: a knowledge base for data querying or image question answering.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Note that the type of a knowledge base cannot be changed after it is created.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>unstructured</para>
        /// </summary>
        [NameInMap("StructureType")]
        [Validation(Required=false)]
        public string StructureType { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para>You can obtain the ID by clicking the ID icon next to the table name on the Tables tab of the Table Connector in <a href="https://bailian.console.aliyun.com/cn-beijing?tab=app#/connector/list">Data Connection</a>. If the list contains multiple IDs, only the first one is used.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <remarks>
        /// <para>This parameter is not available. Do not pass this parameter.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("TableIds")]
        [Validation(Required=false)]
        public string TableIdsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>connector</para>
        /// </summary>
        [NameInMap("channelType")]
        [Validation(Required=false)]
        public string ChannelType { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para>Enables custom chunking and specifies the chunking strategy. For more information, refer to <a href="https://help.aliyun.com/document_detail/2807740.html">Knowledge base</a>.</para>
        /// <para>Valid values (you cannot pass multiple values at a time):</para>
        /// <list type="bullet">
        /// <item><description><b>length</b>: chunks by length. The text is strictly chunked according to the ChunkSize and OverlapSize you specify. If you do not pass these two parameters, the system uses the default values (ChunkSize is 500 and OverlapSize is 100). Chunking by length does not support Separator (it does not take effect even if passed).</description></item>
        /// <item><description><b>page</b>: chunks by page. If ChunkSize is specified, it is considered during chunking (if not passed, the default value 500 is used). Chunking by page does not support OverlapSize and Separator (they do not take effect even if passed).</description></item>
        /// <item><description><b>h1</b>: chunks by level-1 heading. If ChunkSize is specified, it is considered during chunking (if not passed, the default value 500 is used). Chunking by level-1 heading does not support OverlapSize and Separator (they do not take effect even if passed).</description></item>
        /// <item><description><b>h2</b>: chunks by level-2 heading. If ChunkSize is specified, it is considered during chunking (if not passed, the default value 500 is used). Chunking by level-2 heading does not support OverlapSize and Separator (they do not take effect even if passed).</description></item>
        /// <item><description><b>regex</b>: chunks by regular expression. In this case, you must specify the Separator parameter. If ChunkSize is specified, it is considered during chunking (if not passed, the default value 500 is used). Chunking by regular expression does not support OverlapSize (it does not take effect even if passed).</description></item>
        /// </list>
        /// <para>Default value: empty. In this case, intelligent chunking is used.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <remarks>
        /// <para>This parameter is not available. Do not pass this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>regex</para>
        /// </summary>
        [NameInMap("chunkMode")]
        [Validation(Required=false)]
        public string ChunkMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>conn_mysql_xxx_xxx</para>
        /// </summary>
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
        /// <para>Specifies whether to use the first row of all .xlsx and .xls files as the header and concatenate it to each text chunk to prevent the large language model from mistakenly treating the header as a normal data row.</para>
        /// <remarks>
        /// <para>Enable this feature only when all imported files are in .xlsx or .xls format and contain headers. Otherwise, do not enable it.</para>
        /// </remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enabled.</description></item>
        /// <item><description>false: disabled.</description></item>
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
        /// <para>&lt;props=&quot;china&quot;&gt;
        /// The specific knowledge type, which is used to further specify the type of data processed by the knowledge base.
        /// <notice>This parameter must be provided or omitted together with knowledgeScene. It cannot be set separately. If both are omitted, the system uses the default configurations based on structureType.</notice></para>
        /// <para><b>Settings</b> constraints: The value of this parameter must match the structureType you select and determines the active values for knowledgeScene.</para>
        /// <para><b>Valid values</b>:</para>
        /// <list type="bullet">
        /// <item><description>document: document search. Must be used with structureType: unstructured.</description></item>
        /// <item><description>table: data querying. Must be used with structureType: structured.</description></item>
        /// <item><description>image: image question answering. Must be used with structureType: structured.</description></item>
        /// <item><description>multimedia: audio and video search. Must be used with structureType: unstructured.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;This parameter is not available. Do not pass this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>document</para>
        /// </summary>
        [NameInMap("knowledgeType")]
        [Validation(Required=false)]
        public string KnowledgeType { get; set; }

        /// <summary>
        /// <para>The metadata extraction configuration. Metadata is a series of additional attributes related to the content of unstructured data. These attributes are integrated into text chunks in the form of key-value pairs. For more information, refer to <a href="https://help.aliyun.com/document_detail/2807740.html">Knowledge base</a>.</para>
        /// </summary>
        [NameInMap("metaExtractColumns")]
        [Validation(Required=false)]
        public string MetaExtractColumnsShrink { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;The number of RCUs for the knowledge base. This parameter is required only when pipelineCommercialType is set to enterprise. Valid values: [1, 200].</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <remarks>
        /// <para>This parameter is not available. Do not pass this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pipelineCommercialCu")]
        [Validation(Required=false)]
        public int? PipelineCommercialCu { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para>The <a href="https://help.aliyun.com/document_detail/2997110.html">edition</a> of the knowledge base. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>standard: Standard Edition</description></item>
        /// <item><description>enterprise: Ultimate Edition</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <remarks>
        /// <para>This parameter is not available. Do not pass this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("pipelineCommercialType")]
        [Validation(Required=false)]
        public string PipelineCommercialType { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;The throttling handling strategy for the knowledge base dependency link. This parameter is required only when pipelineCommercialType is set to enterprise.
        /// Valid values:
        /// downgrade: downgrade processing (switches to lightweight link retrieval).
        /// Default value: downgrade.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <remarks>
        /// <para>This parameter is not available. Do not pass this parameter.</para>
        /// </remarks>
        /// 
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
