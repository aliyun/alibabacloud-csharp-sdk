// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class CreateIndexShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of category IDs to import when creating the knowledge base. All files under the specified categories are imported. We recommend importing no more than 500 files. For remaining files, call the <b>SubmitIndexAddDocumentsJob</b> operation to continue importing.</para>
        /// </summary>
        [NameInMap("CategoryIds")]
        [Validation(Required=false)]
        public string CategoryIdsShrink { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para>The chunk size, which is the maximum number of characters per text chunk. When the text exceeds this length:</para>
        /// <list type="bullet">
        /// <item><description><b>Intelligent chunking</b> (<c>chunkMode</c> not specified): The text is likely to be truncated.</description></item>
        /// <item><description><b>Custom chunking</b> (<c>chunkMode</c> specified): The text is forcibly truncated.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;
        /// The chunk size, which is the maximum number of characters per text chunk. When the text exceeds this length, it is likely to be truncated.</para>
        /// <para>Valid values: [1-6000]. If not specified, the default value is 500.</para>
        /// <remarks>
        /// <para>If <c>ChunkSize</c> is set to a value less than 100, you must also set <c>OverlapSize</c>. You can also leave both parameters unspecified, and the system uses the default values.</para>
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
        /// The structure of the data table (column names, types, and so on).</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <remarks>
        /// <para>This parameter is not available. Do not pass in a value.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Columns")]
        [Validation(Required=false)]
        public string ColumnsShrink { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is not available. Do not pass in a value.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("CreateIndexType")]
        [Validation(Required=false)]
        public string CreateIndexType { get; set; }

        /// <summary>
        /// <para>The knowledge base description. The description can be up to 200 characters in length and can contain Chinese and English characters.
        /// Default value: empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The enterprise help document library includes important materials such as company policies and product catalogs</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The list of files to import when creating the knowledge base. Specify file IDs. We recommend importing no more than 10,000 files. For remaining files, call the <b>SubmitIndexAddDocumentsJob</b> operation to continue importing.</para>
        /// </summary>
        [NameInMap("DocumentIds")]
        [Validation(Required=false)]
        public string DocumentIdsShrink { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para>The embedding model used by the knowledge base. The embedding model is used to transform the original input prompt and knowledge text into numerical vectors for similarity comparison. The text-embedding-v4 model is a comprehensive upgrade over text-embedding-v3 in terms of language support, code snippet quantization, and vector dimension selection, and is suitable for most scenarios. For more information, see <a href="https://help.aliyun.com/document_detail/2842587.html">Vectorization</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>text-embedding-v4</description></item>
        /// <item><description>text-embedding-v3</description></item>
        /// </list>
        /// <para>Default value: empty, which uses the text-embedding-v3 model.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <para>The embedding model used by the knowledge base. The embedding model is used to transform the original input prompt and knowledge text into numerical vectors for similarity comparison. The default text-embedding-v2 model (cannot be changed) supports Chinese, English, and multiple other languages, and performs normalization on vector results. For more information, see <a href="https://help.aliyun.com/document_detail/2842587.html">Vectorization</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>text-embedding-v2</description></item>
        /// </list>
        /// <para>Default value: empty, which uses the text-embedding-v2 model.</para>
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
        /// <item><description>true: Enabled.</description></item>
        /// <item><description>false: Disabled.</description></item>
        /// </list>
        /// <para>If not specified, this feature is enabled by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableRewrite")]
        [Validation(Required=false)]
        public bool? EnableRewrite { get; set; }

        /// <summary>
        /// <para>The knowledge base name. The name must be 1 to 20 characters in length and can contain Chinese characters, letters, digits, underscores (_), hyphens (-), periods (.), and colons (:).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EnterpriseHelpDocLibrary</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The chunk overlap size, which is the number of overlapping characters between the current text chunk and the previous text chunk. Valid values: [0-1024].</para>
        /// <para>If not specified, the default value is 100.</para>
        /// <remarks>
        /// <para><c>OverlapSize</c> must be less than <c>ChunkSize</c>. Otherwise, chunking exceptions occur.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("OverlapSize")]
        [Validation(Required=false)]
        public int? OverlapSize { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;intl&quot;&gt;This parameter is not yet available. Do not pass in a value.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;Provides a natural language instruction to fine-tune the behavior of the reranking model.
        /// <notice>This parameter takes effect only when rerank_mode is set to &quot;custom&quot;.</para>
        /// </summary>
        [NameInMap("RerankInstruct")]
        [Validation(Required=false)]
        public string RerankInstruct { get; set; }

        /// <summary>
        /// <para>The similarity threshold. Only text chunks with similarity scores exceeding this value are recalled. This parameter filters the text chunks returned by the reranking model. Valid values: [0.01-1.00].</para>
        /// <para>If not specified, the default value is 0.01.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.20</para>
        /// </summary>
        [NameInMap("RerankMinScore")]
        [Validation(Required=false)]
        public double? RerankMinScore { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;
        /// Specifies the instruction intervention mode for the reranking model to determine its scoring preference.</para>
        /// <para><b>Valid values:</b></para>
        /// <list type="bullet">
        /// <item><description><para><b>qa</b>: (Default) Q&amp;A mode. The model tends to assign higher scores to candidates that directly answer the query. Recommended for Q&amp;A scenarios.</para>
        /// </description></item>
        /// <item><description><para><b>similar</b>: Similarity mode. The model tends to assign higher scores to candidates with high content consistency with the query. Recommended for matching and retrieval scenarios.</para>
        /// </description></item>
        /// <item><description><para><b>custom</b>: Custom mode. The model\&quot;s ranking behavior is determined by the instruction in the rerank_instruct parameter.</para>
        /// </description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;This parameter is not available. Do not pass in a value.
        /// [_single.params.RerankMode.enum.similar: 相似模式。]similar: Similarity mode.
        /// [_single.params.RerankMode.enum.custom: 自定义模式。]custom: Custom mode.
        /// [_single.params.RerankMode.enum.qa:（默认值） 问答模式。]qa: (Default) Q&amp;A mode.
        /// [parameters.33.schema.enumValueTitles.similar: 相似模式。]similar: Similarity mode.
        /// [parameters.33.schema.enumValueTitles.custom: 自定义模式。]custom: Custom mode.
        /// [parameters.33.schema.enumValueTitles.qa:（默认值） 问答模式。]qa: (Default) Q&amp;A mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qa</para>
        /// </summary>
        [NameInMap("RerankMode")]
        [Validation(Required=false)]
        public string RerankMode { get; set; }

        /// <summary>
        /// <para>The reranking model used by the knowledge base. The reranking model is an external scoring system that calculates the similarity score between the user query and each text chunk in the knowledge base, sorts them in descending order, and returns the top K text chunks with the highest scores. Valid values:</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>qwen3-rerank-hybrid: qwen3-rerank(hybrid) reranking.</description></item>
        /// <item><description>qwen3-rerank: qwen3-rerank reranking.</description></item>
        /// <item><description>gte-rerank-hybrid: gte-rerank(hybrid) reranking.</description></item>
        /// <item><description>gte-rerank: gte-rerank reranking.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>gte-rerank-hybrid: Official reranking.</description></item>
        /// <item><description>gte-rerank: gte-rerank reranking.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para>Default value: empty, which uses qwen3-rerank.</para>
        /// <remarks>
        /// <para>If you only need semantic reranking, use <c>qwen3-rerank</c>. If you need both semantic reranking and text matching features to ensure relevance, use <c>qwen3-rerank-hybrid</c>.</para>
        /// </remarks>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <para>Default value: empty, which uses gte-rerank-hybrid.</para>
        /// <remarks>
        /// <para>If you only need semantic reranking, use <c>gte-rerank</c>. If you need both semantic reranking and text matching features to ensure relevance, use <c>gte-rerank-hybrid</c>.</para>
        /// </remarks>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <remarks>
        /// <para><c>gte-rerank-hybrid</c> and <c>gte-rerank</c> will no longer be updated. We do not recommend using them.</para>
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
        /// <para>The sentence separator. This parameter takes effect only when <c>chunkMode</c>=<b>regex</b> (it does not take effect in other modes even if specified). You can pass in a single regular expression (multiple expressions are not supported) to split files into small text chunks.</para>
        /// <para>When using intelligent chunking (<c>chunkMode</c> not specified), keep the default empty value.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <remarks>
        /// <para>This parameter is not available. Do not pass in a value.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>(?&lt;=。)</para>
        /// </summary>
        [NameInMap("Separator")]
        [Validation(Required=false)]
        public string Separator { get; set; }

        /// <summary>
        /// <para>The AnalyticDB for PostgreSQL instance ID (required only when <c>SinkType</c> is set to ADB). Obtain this ID from the <a href="https://gpdbnext.console.aliyun.com/gpdb/list">AnalyticDB for PostgreSQL instance list</a> page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-bp32109xxxx</para>
        /// </summary>
        [NameInMap("SinkInstanceId")]
        [Validation(Required=false)]
        public string SinkInstanceId { get; set; }

        /// <summary>
        /// <para>The region of the AnalyticDB for PostgreSQL instance (required only when <c>SinkType</c> is set to ADB). Call &lt;props=&quot;china&quot;&gt;<a href="https://www.alibabacloud.com/help/en/analyticdb-for-postgresql/developer-reference/api-gpdb-2016-05-03-describeregions">DescribeRegions</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/analyticdb/analyticdb-for-postgresql/developer-reference/api-gpdb-2016-05-03-describeregions?spm=a2c63.p38356.0.i3">DescribeRegions</a> to obtain the list of regions.</para>
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
        /// <item><description>BUILT_IN: Vector data is hosted on the Alibaba Cloud Model Studio platform.</description></item>
        /// <item><description>ADB: AnalyticDB for PostgreSQL database. If you need advanced features such as database management, auditing, and monitoring, select ADB.<remarks>
        /// <para>If you have not used ADB storage on Alibaba Cloud Model Studio before, go to the &lt;props=&quot;china&quot;&gt;<a href="https://bailian.console.aliyun.com/#/knowledge-base/create">Create Knowledge Base</a>&lt;props=&quot;intl&quot;&gt;<a href="https://bailian.console.alibabacloud.com/#/knowledge-base/create">Create Knowledge Base</a> page, set the vector storage type to ADB-PG, and complete the authorization as prompted. If you pass in ADB, you must specify the <c>SinkInstanceId</c> and <c>SinkRegion</c> parameters.</para>
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
        /// <para>Notice: This parameter is required in the latest SDK version. Otherwise, calling the SubmitIndexJob operation returns the error: Required parameter(data_sources) missing or invalid.</para>
        /// </remarks>
        /// <para>The data source type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DATA_CENTER_CATEGORY: Category type. Imports all files under specified categories in &lt;props=&quot;china&quot;&gt;<a href="https://bailian.console.aliyun.com/?tab=app#/data-center">Application Data</a>&lt;props=&quot;intl&quot;&gt;<a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">Application Data</a>. You can import multiple categories at the same time.</description></item>
        /// <item><description>DATA_CENTER_FILE: File type. Imports specified files from &lt;props=&quot;china&quot;&gt;<a href="https://bailian.console.aliyun.com/?tab=app#/data-center">Application Data</a>&lt;props=&quot;intl&quot;&gt;<a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">Application Data</a>. You can import multiple files at the same time.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter is set to DATA_CENTER_CATEGORY, you must specify the <c>CategoryIds</c> parameter. If this parameter is set to DATA_CENTER_FILE, you must specify the <c>DocumentIds</c> parameter.</para>
        /// </remarks>
        /// <remarks>
        /// <para>To create an empty knowledge base, use an empty category that contains no files: set this parameter to DATA_CENTER_CATEGORY and pass the empty category ID to <c>CategoryIds</c>.</para>
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
        /// <para>The knowledge base type.</para>
        /// <para><b>Valid values:</b></para>
        /// <list type="bullet">
        /// <item><description>unstructured: A document search or audio/video knowledge base. The default scenario for the document search type is basic document Q&amp;A. &lt;props=&quot;china&quot;&gt;To create other scenarios, you must also pass the knowledgeType and knowledgeScene parameters.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>structured: A data query or image-based Q&amp;A knowledge base.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The knowledge base type cannot be changed after creation.</para>
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
        /// <para>Obtained by clicking the ID icon next to the table name on the Tables tab of <a href="https://bailian.console.aliyun.com/cn-beijing?tab=app#/connector/list">Data Connection</a> table connector. If the list contains multiple IDs, only the first one is used.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <remarks>
        /// <para>This parameter is not available. Do not pass in a value.</para>
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
        /// <para>Enables custom chunking and specifies the chunking strategy. For more information, see <a href="https://help.aliyun.com/document_detail/2807740.html">Knowledge base</a>.</para>
        /// <para>Valid values (only one value can be passed at a time):</para>
        /// <list type="bullet">
        /// <item><description><b>length</b>: Chunk by length. Strictly chunks according to the specified <c>ChunkSize</c> and <c>OverlapSize</c>. If you do not pass in these two parameters, the system uses the default values (<c>ChunkSize</c> of 500 and <c>OverlapSize</c> of 100). Chunking by length does not support <c>Separator</c> (it does not take effect even if specified).</description></item>
        /// <item><description><b>page</b>: Chunk by page. If <c>ChunkSize</c> is specified, it is also considered during chunking (if not specified, the default value of 500 is used). Chunking by page does not support <c>OverlapSize</c> or <c>Separator</c> (they do not take effect even if specified).</description></item>
        /// <item><description><b>h1</b>: Chunk by first-level headings. If <c>ChunkSize</c> is specified, it is also considered during chunking (if not specified, the default value of 500 is used). Chunking by first-level headings does not support <c>OverlapSize</c> or <c>Separator</c> (they do not take effect even if specified).</description></item>
        /// <item><description><b>h2</b>: Chunk by second-level headings. If <c>ChunkSize</c> is specified, it is also considered during chunking (if not specified, the default value of 500 is used). Chunking by second-level headings does not support <c>OverlapSize</c> or <c>Separator</c> (they do not take effect even if specified).</description></item>
        /// <item><description><b>regex</b>: Chunk by regular expression. You must specify the <c>Separator</c> parameter. If <c>ChunkSize</c> is specified, it is also considered during chunking (if not specified, the default value of 500 is used). Chunking by regular expression does not support <c>OverlapSize</c> (it does not take effect even if specified).</description></item>
        /// </list>
        /// <para>If not specified, intelligent chunking is used by default.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <remarks>
        /// <para>This parameter is not available. Do not pass in a value.</para>
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
        /// <para>Specifies whether to treat the first row of all xlsx and xls files as headers and append them to each text chunk, preventing the large language model from treating headers as regular data rows.</para>
        /// <remarks>
        /// <para>Enable this feature only when all imported files are in .xlsx or .xls format and contain headers. Otherwise, do not enable it.</para>
        /// </remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Enabled.</description></item>
        /// <item><description>false: Disabled.</description></item>
        /// </list>
        /// <para>If not specified, this feature is disabled by default.</para>
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
        /// The specific knowledge type that further specifies the data type processed by the knowledge base.
        /// <notice>This parameter and knowledgeScene must be provided together or omitted together. They cannot be set individually. If both are omitted, the system uses the default configurations based on structureType.</para>
        /// <para><b>Settings constraint</b>: The value of this parameter must match the selected structureType and determines the active values for knowledgeScene.</para>
        /// <para><b>Valid values:</b></para>
        /// <list type="bullet">
        /// <item><description>document: Document search. Must be used with structureType: unstructured.</description></item>
        /// <item><description>table: Data query. Must be used with structureType: structured.</description></item>
        /// <item><description>image: Image-based Q&amp;A. Must be used with structureType: structured.</description></item>
        /// <item><description>multimedia: Audio/video search. Must be used with structureType: unstructured.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;This parameter is not available. Do not pass in a value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>document</para>
        /// </summary>
        [NameInMap("knowledgeType")]
        [Validation(Required=false)]
        public string KnowledgeType { get; set; }

        /// <summary>
        /// <para>The metadata extraction configuration. Metadata consists of additional attributes related to unstructured data content. These attributes are integrated into text chunks as key-value pairs. For more information, see <a href="https://help.aliyun.com/document_detail/2807740.html">Knowledge base</a>.</para>
        /// </summary>
        [NameInMap("metaExtractColumns")]
        [Validation(Required=false)]
        public string MetaExtractColumnsShrink { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;The number of RCUs for the knowledge base (required only when pipelineCommercialType is set to enterprise). Valid values: [1-200].</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <remarks>
        /// <para>This parameter is not available. Do not pass in a value.</para>
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
        /// <item><description>standard: Standard Edition.</description></item>
        /// <item><description>enterprise: Ultimate Edition.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <remarks>
        /// <para>This parameter is not available. Do not pass in a value.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("pipelineCommercialType")]
        [Validation(Required=false)]
        public string PipelineCommercialType { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;The rate limiting strategy for the knowledge base dependency chain (required only when pipelineCommercialType is set to enterprise).
        /// Valid values:
        /// downgrade: Downgrade processing (switch to lightweight chain retrieval).
        /// If not specified, the default value is downgrade.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <remarks>
        /// <para>This parameter is not available. Do not pass in a value.</para>
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
