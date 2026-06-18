// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class CreateIndexRequest : TeaModel {
        /// <summary>
        /// <para>You can import files when you create a knowledge base. Specify category IDs to import all files under the corresponding categories. We recommend importing no more than 10,000 files. If you have more files, you can call the <b>SubmitIndexAddDocumentsJob</b> operation to import them later.</para>
        /// </summary>
        [NameInMap("CategoryIds")]
        [Validation(Required=false)]
        public List<string> CategoryIds { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para>The chunk size, which is the maximum number of characters for each text chunk. If this length is exceeded:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Smart chunking</b> (the \<c>chunkMode\\</c> parameter is not specified): The text is likely to be truncated.</para>
        /// </description></item>
        /// <item><description><para><b>Custom chunking</b> (the \<c>chunkMode\\</c> parameter is specified): The text is forcibly truncated.</para>
        /// </description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <para>The chunk size, which is the maximum number of characters for each text chunk. If this length is exceeded, the text is likely to be truncated.</para>
        /// <para>The value must be between 1 and 6000. If you do not specify this parameter, the default value 500 is used.</para>
        /// <remarks>
        /// <para>If you set \<c>ChunkSize\\</c> to a value less than 100, you must also set \<c>OverlapSize\\</c>. You can also leave both parameters unspecified, and the system will use the default values.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>128</para>
        /// </summary>
        [NameInMap("ChunkSize")]
        [Validation(Required=false)]
        public int? ChunkSize { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para>The structure of the data table (column names, types, etc.).</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <remarks>
        /// <para>This parameter is not yet available. Do not specify it.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Columns")]
        [Validation(Required=false)]
        public List<CreateIndexRequestColumns> Columns { get; set; }
        public class CreateIndexRequestColumns : TeaModel {
            /// <summary>
            /// <remarks>
            /// <para>This parameter is not yet available. Do not specify it.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>school</para>
            /// </summary>
            [NameInMap("Column")]
            [Validation(Required=false)]
            public string Column { get; set; }

            /// <summary>
            /// <para>&lt;props=&quot;china&quot;&gt;</para>
            /// <para>Specifies whether to participate in model response generation. If enabled, the retrieval results from this column are used as input for the LLM to generate an answer. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enabled.</para>
            /// </description></item>
            /// <item><description><para>false: Disabled.</para>
            /// </description></item>
            /// </list>
            /// <para>&lt;props=&quot;intl&quot;&gt;</para>
            /// <remarks>
            /// <para>This parameter is not yet available. Do not specify it.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsRecall")]
            [Validation(Required=false)]
            public bool? IsRecall { get; set; }

            /// <summary>
            /// <para>&lt;props=&quot;china&quot;&gt;</para>
            /// <para>Specifies whether to participate in knowledge base retrieval. If enabled, the knowledge base is allowed to search for data in this column. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enabled.</para>
            /// </description></item>
            /// <item><description><para>false: Disabled.</para>
            /// </description></item>
            /// </list>
            /// <para>&lt;props=&quot;intl&quot;&gt;</para>
            /// <remarks>
            /// <para>This parameter is not yet available. Do not specify it.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsSearch")]
            [Validation(Required=false)]
            public bool? IsSearch { get; set; }

            /// <summary>
            /// <para>&lt;props=&quot;china&quot;&gt;</para>
            /// <para>The field name. It must be consistent with the table header of the data table created in Application Data.</para>
            /// <para>&lt;props=&quot;intl&quot;&gt;</para>
            /// <remarks>
            /// <para>This parameter is not yet available. Do not specify it.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>学校</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>&lt;props=&quot;china&quot;&gt;</para>
            /// <para>The field type. It must be consistent with the table header of the data table created in Application Data. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>string</para>
            /// </description></item>
            /// <item><description><para>double</para>
            /// </description></item>
            /// <item><description><para>long</para>
            /// </description></item>
            /// <item><description><para>datetime</para>
            /// </description></item>
            /// <item><description><para>image_url</para>
            /// </description></item>
            /// </list>
            /// <para>&lt;props=&quot;intl&quot;&gt;</para>
            /// <remarks>
            /// <para>This parameter is not yet available. Do not specify it.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>string</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is not yet available. Do not specify it.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("CreateIndexType")]
        [Validation(Required=false)]
        public string CreateIndexType { get; set; }

        /// <summary>
        /// <para>The description of the knowledge base. The description can be 0 to 1,000 English or Chinese characters in length.
        /// The default value is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>企业帮助文档库包括了公司制度、产品清单等重要资料。</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>You can import files when you create a knowledge base. Specify a list of files to import by providing their IDs. We recommend importing no more than 10,000 files. If you have more files, you can call the <b>SubmitIndexAddDocumentsJob</b> operation to import them later.</para>
        /// </summary>
        [NameInMap("DocumentIds")]
        [Validation(Required=false)]
        public List<string> DocumentIds { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para>The vector model used by the knowledge base. A vector model converts the original input prompt and knowledge text into numerical vectors to compare their similarity. The text-embedding-v4 model is a comprehensive upgrade over the text-embedding-v3 model in terms of language support, vectorization of code snippets, and vector dimension selection. It is suitable for most scenarios. For more information, see <a href="https://help.aliyun.com/document_detail/2842587.html">Vectorization</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>text-embedding-v4</para>
        /// </description></item>
        /// <item><description><para>text-embedding-v3</para>
        /// </description></item>
        /// </list>
        /// <para>If you do not specify this parameter, \<c>text-embedding-v3\\</c> is used.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><para>The vector model used by the knowledge base. A vector model converts the original input prompt and knowledge text into numerical vectors to compare their similarity. The default text-embedding-v2 model (which cannot be changed for now) supports both Chinese and English, along with multiple other languages, and normalizes the vector results. For more information, see <a href="https://help.aliyun.com/document_detail/2842587.html">Vectorization</a>. Valid values:</para>
        /// </description></item>
        /// <item><description><para>text-embedding-v2</para>
        /// </description></item>
        /// </list>
        /// <para>If you do not specify this parameter, \<c>text-embedding-v2\\</c> is used.</para>
        /// </summary>
        [NameInMap("EmbeddingModelName")]
        [Validation(Required=false)]
        public string EmbeddingModelName { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable multi-turn conversation rewriting. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enabled.</para>
        /// </description></item>
        /// <item><description><para>false: Disabled.</para>
        /// </description></item>
        /// </list>
        /// <para>If you do not specify this parameter, this feature is enabled by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableRewrite")]
        [Validation(Required=false)]
        public bool? EnableRewrite { get; set; }

        /// <summary>
        /// <para>The name of the knowledge base. The name can be 1 to 20 characters in length and can contain Chinese characters, letters, digits, underscores (_), hyphens (-), periods (.), and colons (:).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>企业帮助文档库</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The overlap size, which is the number of overlapping characters between the current text chunk and the previous one. The value must be between 0 and 1024.</para>
        /// <para>If you do not specify this parameter, the default value 100 is used.</para>
        /// <remarks>
        /// <para>\<c>OverlapSize\\</c> must be smaller than \<c>ChunkSize\\</c>. Otherwise, chunking errors will occur.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("OverlapSize")]
        [Validation(Required=false)]
        public int? OverlapSize { get; set; }

        /// <summary>
        /// <para>The name of the database. This parameter is required when creating a data query knowledge base.</para>
        /// <para>The database must exist in the data source specified by \<c>datasourceCode\\</c>.</para>
        /// </summary>
        [NameInMap("RerankInstruct")]
        [Validation(Required=false)]
        public string RerankInstruct { get; set; }

        /// <summary>
        /// <para>The similarity threshold. Only text chunks with a similarity score greater than this value are recalled. This is used to filter the text chunks returned by the reranking model. The value must be between 0.01 and 1.00.</para>
        /// <para>If you do not specify this parameter, the default value 0.01 is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.20</para>
        /// </summary>
        [NameInMap("RerankMinScore")]
        [Validation(Required=false)]
        public double? RerankMinScore { get; set; }

        /// <summary>
        /// <para>The name of the data table. This parameter is required when creating a data query knowledge base.</para>
        /// <para>The data table must exist in the data source specified by \<c>connectId\\</c> or \<c>datasourceCode\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qa</para>
        /// </summary>
        [NameInMap("RerankMode")]
        [Validation(Required=false)]
        public string RerankMode { get; set; }

        /// <summary>
        /// <para>The reranking model used by the knowledge base. The reranking model is an external scoring system that calculates a similarity score between the user\&quot;s question and each text chunk in the knowledge base, sorts them in descending order, and returns the top K text chunks. Valid values:</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><para>qwen3-rerank-hybrid: qwen3-rerank (hybrid) reranking.</para>
        /// </description></item>
        /// <item><description><para>qwen3-rerank: qwen3-rerank reranking.</para>
        /// </description></item>
        /// <item><description><para>gte-rerank-hybrid: gte-rerank (hybrid) reranking.</para>
        /// </description></item>
        /// <item><description><para>gte-rerank: gte-rerank reranking.</para>
        /// </description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><para>gte-rerank-hybrid: Official reranking.</para>
        /// </description></item>
        /// <item><description><para>gte-rerank: gte-rerank reranking.</para>
        /// </description></item>
        /// </list>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para>If you do not specify this parameter, \<c>qwen3-rerank\\</c> is used.</para>
        /// <remarks>
        /// <para>Use \<c>qwen3-rerank\\</c> if you only need semantic sorting. Use \<c>qwen3-rerank-hybrid\\</c> if you need both semantic sorting and text-matching features to ensure relevance.</para>
        /// </remarks>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <para>If you do not specify this parameter, \<c>gte-rerank-hybrid\\</c> is used.</para>
        /// <remarks>
        /// <para>Use \<c>gte-rerank\\</c> if you only need semantic sorting. Use \<c>gte-rerank-hybrid\\</c> if you need both semantic sorting and text-matching features to ensure relevance.</para>
        /// </remarks>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <remarks>
        /// <para>The \<c>gte-rerank-hybrid\\</c> and \<c>gte-rerank\\</c> models are no longer updated and are not recommended.</para>
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
        /// <para>The sentence separator. This parameter takes effect only when \<c>chunkMode\\</c> is set to <b>regex</b>. It is ignored in other modes, even if specified. You can enter a regular expression (multiple expressions are not supported) to split the file into smaller text chunks.</para>
        /// <para>For smart chunking (the \<c>chunkMode\\</c> parameter is not specified), you can leave this parameter empty.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <remarks>
        /// <para>This parameter is not yet available. Do not specify it.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>(?&lt;=。)</para>
        /// </summary>
        [NameInMap("Separator")]
        [Validation(Required=false)]
        public string Separator { get; set; }

        /// <summary>
        /// <para>The ID of the AnalyticDB for PostgreSQL instance. This parameter is required only when \<c>SinkType\\</c> is set to ADB. Go to the <a href="https://gpdbnext.console.aliyun.com/gpdb/list">AnalyticDB for PostgreSQL instance list</a> page to obtain this ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-bp32109xxxx</para>
        /// </summary>
        [NameInMap("SinkInstanceId")]
        [Validation(Required=false)]
        public string SinkInstanceId { get; set; }

        /// <summary>
        /// <para>The region where the AnalyticDB for PostgreSQL instance is located. This parameter is required only when \<c>SinkType\\</c> is set to ADB. You can call the &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/analyticdb/analyticdb-for-postgresql/developer-reference/api-gpdb-2016-05-03-describeregions?spm=a2c63.p38356.0.i3">DescribeRegions </a>operation to obtain a list of regions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("SinkRegion")]
        [Validation(Required=false)]
        public string SinkRegion { get; set; }

        /// <summary>
        /// <para>The storage class for the knowledge base vectors. For more information, see <a href="https://help.aliyun.com/document_detail/2807740.html">Knowledge bases</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>BUILT_IN: Hosts the vector data on the Alibaba Cloud Model Studio platform.</para>
        /// </description></item>
        /// <item><description><para>ADB: AnalyticDB for PostgreSQL. We recommend choosing ADB if you need advanced features such as database management, auditing, and monitoring.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you have not used ADB storage on Alibaba Cloud Model Studio, go to the &lt;props=&quot;intl&quot;&gt;<a href="https://bailian.console.alibabacloud.com/#/knowledge-base/create">Create Knowledge Base</a> page, set the vector storage class to ADB-PG, and follow the on-screen instructions to grant the required permissions. If you set this parameter to ADB, you must specify the \<c>SinkInstanceId\\</c> and \<c>SinkRegion\\</c> parameters.</para>
        /// </remarks>
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
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>In the latest SDK version, this parameter is required. Otherwise, calling the SubmitIndexJob operation will result in the error: Required parameter(data_sources) missing or invalid.</para>
        /// <para>The source of the imported data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>DATA_CENTER_CATEGORY: Category type. Imports all files under the specified categories in &lt;props=&quot;intl&quot;&gt;<a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">Application Data</a>. You can import multiple categories at the same time.</para>
        /// </description></item>
        /// <item><description><para>DATA_CENTER_FILE: File type. Imports the specified files from &lt;props=&quot;intl&quot;&gt;<a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">Application Data</a>. You can import multiple files at the same time.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you set this parameter to DATA_CENTER_CATEGORY, you must specify the \<c>CategoryIds\\</c> parameter. If you set this parameter to DATA_CENTER_FILE, you must specify the \<c>DocumentIds\\</c> parameter.</para>
        /// </remarks>
        /// <remarks>
        /// <para>To create an empty knowledge base, use an empty category that contains no files. Set this parameter to DATA_CENTER_CATEGORY and specify the ID of the empty category for \<c>CategoryIds\\</c>.</para>
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
        /// <item><description>unstructured: A knowledge base for document search, audio, or video. The default scenario for document search is basic document Q\&amp;A.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>structured: A knowledge base for data query or image Q\&amp;A.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The type of a knowledge base cannot be changed after it is created.</para>
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
        /// <para>Obtain the table ID on the Tables tab of the table connector in Data Connections by clicking the ID icon next to the table name. If the list contains multiple IDs, only the first one is used.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <remarks>
        /// <para>This parameter is not yet available. Do not specify it.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("TableIds")]
        [Validation(Required=false)]
        public List<string> TableIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>connector</para>
        /// </summary>
        [NameInMap("channelType")]
        [Validation(Required=false)]
        public string ChannelType { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para>Enables custom chunking and specifies the chunking policy. For more information, see <a href="https://help.aliyun.com/document_detail/2807740.html">Knowledge bases</a>.</para>
        /// <para>Possible values (only one value can be specified at a time):</para>
        /// <list type="bullet">
        /// <item><description><para><b>length</b>: Chunks by length. The text is strictly chunked according to the \<c>ChunkSize\\</c> and \<c>OverlapSize\\</c> you specify. If you do not specify these two parameters, the system uses the default values (\<c>ChunkSize\\</c> is 500, \<c>OverlapSize\\</c> is 100). Chunking by length does not support \<c>Separator\\</c> (it is ignored even if specified).</para>
        /// </description></item>
        /// <item><description><para><b>page</b>: Chunks by page. If \<c>ChunkSize\\</c> is specified, it is also considered during chunking (if not specified, the default value 500 is used). Chunking by page does not support \<c>OverlapSize\\</c> or \<c>Separator\\</c> (they are ignored even if specified).</para>
        /// </description></item>
        /// <item><description><para><b>h1</b>: Chunks by level-1 heading. If \<c>ChunkSize\\</c> is specified, it is also considered during chunking (if not specified, the default value 500 is used). Chunking by level-1 heading does not support \<c>OverlapSize\\</c> or \<c>Separator\\</c> (they are ignored even if specified).</para>
        /// </description></item>
        /// <item><description><para><b>h2</b>: Chunks by level-2 heading. If \<c>ChunkSize\\</c> is specified, it is also considered during chunking (if not specified, the default value 500 is used). Chunking by level-2 heading does not support \<c>OverlapSize\\</c> or \<c>Separator\\</c> (they are ignored even if specified).</para>
        /// </description></item>
        /// <item><description><para><b>regex</b>: Chunks by regular expression. You must specify the \<c>Separator\\</c> parameter. If \<c>ChunkSize\\</c> is specified, it is also considered during chunking (if not specified, the default value 500 is used). Chunking by regular expression does not support \<c>OverlapSize\\</c> (it is ignored even if specified).</para>
        /// </description></item>
        /// </list>
        /// <para>If you do not specify this parameter, smart chunking is used by default.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <remarks>
        /// <para>This parameter is not yet available. Do not specify it.</para>
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
        /// <para>Specifies whether to treat the first row of all .xlsx and .xls files as the table header and append it to each text chunk. This prevents the LLM from treating the header as a regular data row.</para>
        /// <remarks>
        /// <para>We recommend enabling this feature only when all imported files are in .xlsx or .xls format and contain a header. Otherwise, do not enable it.</para>
        /// </remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enabled.</para>
        /// </description></item>
        /// <item><description><para>false: Disabled.</para>
        /// </description></item>
        /// </list>
        /// <para>If you do not specify this parameter, this feature is disabled by default.</para>
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
        /// <para>The data source code. This parameter is required when creating a data query knowledge base and is used with \<c>table\\</c> and \<c>database\\</c>.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para>We recommend using the new \<c>connectId\\</c> parameter, which you can obtain from the data connector card on the <a href="https://modelstudio.console.alibabacloud.com/?tab=app#/connector/list">Data Connections</a> page. This parameter is still compatible but will no longer be maintained in the future.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This operation does not support associating custom databases. Use the Alibaba Cloud Model Studio console to create them.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>document</para>
        /// </summary>
        [NameInMap("knowledgeType")]
        [Validation(Required=false)]
        public string KnowledgeType { get; set; }

        /// <summary>
        /// <para>The metadata extraction configuration. Metadata is a series of additional attributes related to unstructured data content. These attributes are integrated into text chunks as key-value pairs. For more information, see <a href="https://help.aliyun.com/document_detail/2807740.html">Knowledge bases</a>.</para>
        /// </summary>
        [NameInMap("metaExtractColumns")]
        [Validation(Required=false)]
        public List<CreateIndexRequestMetaExtractColumns> MetaExtractColumns { get; set; }
        public class CreateIndexRequestMetaExtractColumns : TeaModel {
            /// <summary>
            /// <para>The Chinese description of the metadata field. The description can be 0 to 1,000 characters in length and can contain Chinese characters, letters, digits, underscores (_), hyphens (-), periods (.), and colons (:). The default value is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>作者名</para>
            /// </summary>
            [NameInMap("Desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            /// <summary>
            /// <para>If enabled, the metadata field and its value are used along with the text chunk content in the answer generation process of the LLM. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enabled.</para>
            /// </description></item>
            /// <item><description><para>false: Disabled.</para>
            /// </description></item>
            /// </list>
            /// <para>The default value is false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableLlm")]
            [Validation(Required=false)]
            public bool? EnableLlm { get; set; }

            /// <summary>
            /// <para>If enabled, the metadata field and its value are used along with the text chunk content in the knowledge base retrieval process. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enabled.</para>
            /// </description></item>
            /// <item><description><para>false: Disabled.</para>
            /// </description></item>
            /// </list>
            /// <para>The default value is false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableSearch")]
            [Validation(Required=false)]
            public bool? EnableSearch { get; set; }

            /// <summary>
            /// <para>The metadata field. The field name can be 1 to 50 characters in length and must consist of letters or underscores. If you specify this parameter, you must also specify the \<c>Value\\</c> and \<c>Type\\</c> parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>author</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The method for obtaining the value of the metadata field. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>constant: Constant.</para>
            /// </description></item>
            /// <item><description><para>variable: Variable.</para>
            /// </description></item>
            /// <item><description><para>custom_prompt: Large Language Model (LLM).</para>
            /// </description></item>
            /// <item><description><para>regular: Regular expression.</para>
            /// </description></item>
            /// <item><description><para>keywords: Keyword search.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>constant</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The value of the metadata field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Tim</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para>The number of RCUs for the knowledge base. This parameter is required only when \<c>pipelineCommercialType\\</c> is set to \<c>enterprise\\</c>. The value must be between 1 and 200.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <remarks>
        /// <para>This parameter is not yet available. Do not specify it.</para>
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
        /// <para>The <a href="https://help.aliyun.com/document_detail/2997110.html">edition type</a> of the knowledge base. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>standard: Standard Edition</para>
        /// </description></item>
        /// <item><description><para>enterprise: Ultimate Edition</para>
        /// </description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <remarks>
        /// <para>This parameter is not yet available. Do not specify it.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("pipelineCommercialType")]
        [Validation(Required=false)]
        public string PipelineCommercialType { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para>The rate limiting policy for the knowledge base dependency chain. This parameter is required only when \<c>pipelineCommercialType\\</c> is set to \<c>enterprise\\</c>.
        /// Value:
        /// downgrade: Degrades the service (switches to using a lightweight retrieval chain).
        /// If you do not specify this parameter, the default value \<c>downgrade\\</c> is used.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <remarks>
        /// <para>This parameter is not yet available. Do not specify it.</para>
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
