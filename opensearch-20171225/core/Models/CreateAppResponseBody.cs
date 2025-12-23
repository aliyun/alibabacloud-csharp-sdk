// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class CreateAppResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABCDEFG</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The response parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateAppResponseBodyResult Result { get; set; }
        public class CreateAppResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The capability opening configurations.</para>
            /// </summary>
            [NameInMap("cluster")]
            [Validation(Required=false)]
            public CreateAppResponseBodyResultCluster Cluster { get; set; }
            public class CreateAppResponseBodyResultCluster : TeaModel {
                [NameInMap("chunkModels")]
                [Validation(Required=false)]
                public List<Dictionary<string, object>> ChunkModels { get; set; }

                [NameInMap("graphRag")]
                [Validation(Required=false)]
                public Dictionary<string, object> GraphRag { get; set; }

                [NameInMap("imageContentRecognizerModels")]
                [Validation(Required=false)]
                public List<Dictionary<string, object>> ImageContentRecognizerModels { get; set; }

                /// <summary>
                /// <para>The maximum length of the query clause.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("maxQueryClauseLength")]
                [Validation(Required=false)]
                public int? MaxQueryClauseLength { get; set; }

                /// <summary>
                /// <para>The timeout period. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>750</para>
                /// </summary>
                [NameInMap("maxTimeoutMS")]
                [Validation(Required=false)]
                public int? MaxTimeoutMS { get; set; }

                [NameInMap("textEmbeddingModel")]
                [Validation(Required=false)]
                public string TextEmbeddingModel { get; set; }

                [NameInMap("textSparseEmbeddingModel")]
                [Validation(Required=false)]
                public string TextSparseEmbeddingModel { get; set; }

                [NameInMap("vectorIndexConfigs")]
                [Validation(Required=false)]
                public List<Dictionary<string, object>> VectorIndexConfigs { get; set; }

            }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The name of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc_sh_domain_1</para>
            /// </summary>
            [NameInMap("clusterName")]
            [Validation(Required=false)]
            [Obsolete]
            public string ClusterName { get; set; }

            [NameInMap("configItems")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> ConfigItems { get; set; }

            [NameInMap("created")]
            [Validation(Required=false)]
            public long? Created { get; set; }

            /// <summary>
            /// <para>The configurations of the data sources.</para>
            /// </summary>
            [NameInMap("dataSources")]
            [Validation(Required=false)]
            public List<CreateAppResponseBodyResultDataSources> DataSources { get; set; }
            public class CreateAppResponseBodyResultDataSources : TeaModel {
                /// <summary>
                /// <para>The information about field mappings.</para>
                /// </summary>
                [NameInMap("fields")]
                [Validation(Required=false)]
                public List<Dictionary<string, object>> Fields { get; set; }

                /// <summary>
                /// <para>The primary key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>id</para>
                /// </summary>
                [NameInMap("keyField")]
                [Validation(Required=false)]
                public string KeyField { get; set; }

                /// <summary>
                /// <para>The information about the data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///   &quot;instanceId&quot;: &quot;rds-instance-id&quot;,
                ///   &quot;dbName&quot;: &quot;my_db&quot;,
                ///   &quot;dbTableName&quot;: &quot;my_table&quot;,
                ///   &quot;dbUser&quot;: &quot;my&quot;,
                ///   &quot;dbPassword&quot;: &quot;my_passwd&quot;,
                ///   &quot;filter&quot;:&quot;&quot;,
                ///   &quot;autoSync&quot;: true
                /// }</para>
                /// </summary>
                [NameInMap("parameters")]
                [Validation(Required=false)]
                public Dictionary<string, object> Parameters { get; set; }

                /// <summary>
                /// <para>The plug-ins that are used for data processing.</para>
                /// <para>name:</para>
                /// <list type="bullet">
                /// <item><description>JsonKeyValueExtractor</description></item>
                /// <item><description>MultiValueSpliter</description></item>
                /// <item><description>KeyValueExtractor</description></item>
                /// <item><description>StringCatenateExtractor</description></item>
                /// <item><description>HTMLTagRemover</description></item>
                /// </list>
                /// <para>parameters:</para>
                /// <list type="bullet">
                /// <item><description>JsonKeyValueExtractor</description></item>
                /// <item><description>MultiValueSpliter</description></item>
                /// <item><description>KeyValueExtractor</description></item>
                /// <item><description>StringCatenateExtractor</description></item>
                /// <item><description>HTMLTagRemover</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///   &quot;name&quot;: &quot;JsonKeyValueExtractor&quot;,
                ///   &quot;parameters&quot;: {
                ///   &quot;key&quot;: &quot;my_field&quot;
                /// }
                /// }</para>
                /// </summary>
                [NameInMap("plugins")]
                [Validation(Required=false)]
                public Dictionary<string, object> Plugins { get; set; }

                /// <summary>
                /// <para>The name of the wide table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>table_name</para>
                /// </summary>
                [NameInMap("schemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                /// <summary>
                /// <para>The name of the table in the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>main</para>
                /// </summary>
                [NameInMap("tableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                /// <summary>
                /// <para>The type of the data source. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>rds</description></item>
                /// <item><description>odps</description></item>
                /// <item><description>opensearch</description></item>
                /// <item><description>polardb</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>rds</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The description of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>My application</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The industry model module.</para>
            /// </summary>
            [NameInMap("domain")]
            [Validation(Required=false)]
            public CreateAppResponseBodyResultDomain Domain { get; set; }
            public class CreateAppResponseBodyResultDomain : TeaModel {
                /// <summary>
                /// <para>The industry category.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The selected features.</para>
                /// </summary>
                [NameInMap("functions")]
                [Validation(Required=false)]
                public CreateAppResponseBodyResultDomainFunctions Functions { get; set; }
                public class CreateAppResponseBodyResultDomainFunctions : TeaModel {
                    /// <summary>
                    /// <para>The features of the sort policy category.</para>
                    /// </summary>
                    [NameInMap("algo")]
                    [Validation(Required=false)]
                    public List<string> Algo { get; set; }

                    /// <summary>
                    /// <para>The features of the query analysis category.</para>
                    /// </summary>
                    [NameInMap("qp")]
                    [Validation(Required=false)]
                    public List<string> Qp { get; set; }

                    /// <summary>
                    /// <para>The features of the service category.</para>
                    /// </summary>
                    [NameInMap("service")]
                    [Validation(Required=false)]
                    public List<string> Service { get; set; }

                }

                /// <summary>
                /// <para>The industry type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>GENERAL</description></item>
                /// <item><description>ECOMMERCE</description></item>
                /// <item><description>IT_CONTENT</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>GENERAL</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The default display fields.</para>
            /// </summary>
            [NameInMap("fetchFields")]
            [Validation(Required=false)]
            public List<string> FetchFields { get; set; }

            /// <summary>
            /// <para>The configurations of rough sort.</para>
            /// </summary>
            [NameInMap("firstRanks")]
            [Validation(Required=false)]
            public List<CreateAppResponseBodyResultFirstRanks> FirstRanks { get; set; }
            public class CreateAppResponseBodyResultFirstRanks : TeaModel {
                /// <summary>
                /// <para>Indicates whether the expression is the default one.</para>
                /// 
                /// <b>Example:</b>
                /// <para>False</para>
                /// </summary>
                [NameInMap("active")]
                [Validation(Required=false)]
                public bool? Active { get; set; }

                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Description</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The information about the expression. The information can be of the array or string type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>String :&quot;random()*100+now()&quot;;
                /// Array: [
                ///     {
                ///       &quot;attribute&quot;: &quot;static_bm25()&quot;,
                ///       &quot;arg&quot;: &quot;&quot;,
                ///       &quot;weight&quot;: 10
                ///     }
                ///   ]</para>
                /// </summary>
                [NameInMap("meta")]
                [Validation(Required=false)]
                public object Meta { get; set; }

                /// <summary>
                /// <para>The name of the rough sort expression.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The expression type. Valid values:</para>
                /// <para>STRUCT: The content of the expression is a structure. STRING (default): You can configure a custom formula.</para>
                /// 
                /// <b>Example:</b>
                /// <para>STRING</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12888</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The descriptions of the LLM table fields.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{ &quot;name&quot;: &quot;longyu_llm_1&quot;, &quot;schemas&quot;: [], &quot;interpretations&quot;: [ { &quot;table&quot;: &quot;table1&quot;, &quot;fields&quot;: [ { &quot;name&quot;: &quot;field1&quot;, &quot;interpretation&quot;: &quot;Title&quot; }, { &quot;name&quot;: &quot;field2&quot;, &quot;interpretation&quot;: &quot;Number&quot; } ] } ] }</para>
            /// </summary>
            [NameInMap("interpretations")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Interpretations { get; set; }

            /// <summary>
            /// <para>Indicates whether the version is an online version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12333</para>
            /// </summary>
            [NameInMap("isCurrent")]
            [Validation(Required=false)]
            public bool? IsCurrent { get; set; }

            /// <summary>
            /// <para>The percentage for the data import progress.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("progressPercent")]
            [Validation(Required=false)]
            public int? ProgressPercent { get; set; }

            /// <summary>
            /// <para>The prompt configurations</para>
            /// </summary>
            [NameInMap("prompts")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Prompts { get; set; }

            /// <summary>
            /// <para>The query intent understanding configurations.</para>
            /// </summary>
            [NameInMap("queryProcessors")]
            [Validation(Required=false)]
            public List<CreateAppResponseBodyResultQueryProcessors> QueryProcessors { get; set; }
            public class CreateAppResponseBodyResultQueryProcessors : TeaModel {
                /// <summary>
                /// <para>Indicates whether the rule is the default one.</para>
                /// 
                /// <b>Example:</b>
                /// <para>False</para>
                /// </summary>
                [NameInMap("active")]
                [Validation(Required=false)]
                public bool? Active { get; set; }

                /// <summary>
                /// <para>The industry category.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The industry type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>GENERAL</description></item>
                /// <item><description>ECOMMERCE</description></item>
                /// <item><description>IT_CONTENT</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>GENERAL</para>
                /// </summary>
                [NameInMap("domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// <para>The index range.</para>
                /// </summary>
                [NameInMap("indexes")]
                [Validation(Required=false)]
                public List<string> Indexes { get; set; }

                /// <summary>
                /// <para>The rule name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The features.</para>
                /// </summary>
                [NameInMap("processors")]
                [Validation(Required=false)]
                public List<Dictionary<string, object>> Processors { get; set; }

            }

            /// <summary>
            /// <para>The quota.</para>
            /// </summary>
            [NameInMap("quota")]
            [Validation(Required=false)]
            public CreateAppResponseBodyResultQuota Quota { get; set; }
            public class CreateAppResponseBodyResultQuota : TeaModel {
                /// <summary>
                /// <para>The computing resources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("computeResource")]
                [Validation(Required=false)]
                public int? ComputeResource { get; set; }

                /// <summary>
                /// <para>The storage capacity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("docSize")]
                [Validation(Required=false)]
                public int? DocSize { get; set; }

                /// <summary>
                /// <para>The search request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("qps")]
                [Validation(Required=false)]
                public int? Qps { get; set; }

                /// <summary>
                /// <para>The specifications. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>opensearch.share.junior: basic</description></item>
                /// <item><description>opensearch.share.common: shared general-purpose</description></item>
                /// <item><description>opensearch.share.compute: shared computing</description></item>
                /// <item><description>opensearch.share.storage: shared storage</description></item>
                /// <item><description>opensearch.private.common: exclusive general-purpose</description></item>
                /// <item><description>opensearch.private.compute: exclusive computing</description></item>
                /// <item><description>opensearch.private.storage: exclusive storage</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>opensearch.share.common</para>
                /// </summary>
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("usedComputeResource")]
                [Validation(Required=false)]
                public int? UsedComputeResource { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("usedDocSize")]
                [Validation(Required=false)]
                public double? UsedDocSize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("usedQps")]
                [Validation(Required=false)]
                public int? UsedQps { get; set; }

            }

            /// <summary>
            /// <para>The single-table schema.</para>
            /// </summary>
            [NameInMap("schema")]
            [Validation(Required=false)]
            public CreateAppResponseBodyResultSchema Schema { get; set; }
            public class CreateAppResponseBodyResultSchema : TeaModel {
                /// <summary>
                /// <para>The sort configurations.</para>
                /// </summary>
                [NameInMap("indexSortConfig")]
                [Validation(Required=false)]
                public List<CreateAppResponseBodyResultSchemaIndexSortConfig> IndexSortConfig { get; set; }
                public class CreateAppResponseBodyResultSchemaIndexSortConfig : TeaModel {
                    /// <summary>
                    /// <para>The sort method. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>ASC</description></item>
                    /// <item><description>DESC</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DESC</para>
                    /// </summary>
                    [NameInMap("direction")]
                    [Validation(Required=false)]
                    public string Direction { get; set; }

                    /// <summary>
                    /// <para>The sort field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>field1</para>
                    /// </summary>
                    [NameInMap("field")]
                    [Validation(Required=false)]
                    public string Field { get; set; }

                }

                /// <summary>
                /// <para>The index schema.</para>
                /// </summary>
                [NameInMap("indexes")]
                [Validation(Required=false)]
                public CreateAppResponseBodyResultSchemaIndexes Indexes { get; set; }
                public class CreateAppResponseBodyResultSchemaIndexes : TeaModel {
                    /// <summary>
                    /// <para>The attribute fields.</para>
                    /// </summary>
                    [NameInMap("filterFields")]
                    [Validation(Required=false)]
                    public List<string> FilterFields { get; set; }

                    /// <summary>
                    /// <para>The index fields.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{
                    ///   &quot;fields&quot;: [&quot;title&quot;],
                    ///   &quot;analyzer&quot;: &quot;chn_standard&quot;
                    /// }</para>
                    /// </summary>
                    [NameInMap("searchFields")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> SearchFields { get; set; }

                }

                /// <summary>
                /// <para>The name of the wide table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The name of the level-1 routing field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>field1</para>
                /// </summary>
                [NameInMap("routeField")]
                [Validation(Required=false)]
                public string RouteField { get; set; }

                /// <summary>
                /// <para>The name of the level-2 routing field. This parameter takes effect only when the routeFieldValues parameter is configured. By default, the wide-table primary key field is used as the level-2 routing field.</para>
                /// </summary>
                [NameInMap("routeFieldValues")]
                [Validation(Required=false)]
                public List<string> RouteFieldValues { get; set; }

                /// <summary>
                /// <para>The name of the level-2 routing field. This parameter takes effect only when the routeFieldValues parameter is configured. By default, the wide-table primary key field is used as the level-2 routing field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>field2</para>
                /// </summary>
                [NameInMap("secondRouteField")]
                [Validation(Required=false)]
                public string SecondRouteField { get; set; }

                /// <summary>
                /// <para>The table schema.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///     &quot;primaryTable&quot;: true,
                ///     &quot;name&quot;: &quot;main&quot;,
                ///     &quot;fields&quot;: {
                ///         &quot;id&quot;: {
                ///             &quot;name&quot;: &quot;id&quot;,
                ///             &quot;type&quot;: &quot;LITERAL&quot;,
                ///             &quot;primaryKey&quot;: true
                ///         },
                ///         &quot;title&quot;: {
                ///             &quot;name&quot;: &quot;title&quot;,
                ///             &quot;type&quot;: &quot;TEXT&quot;,
                ///             &quot;primaryKey&quot;: false
                ///         },
                ///         &quot;buy&quot;: {
                ///             &quot;name&quot;: &quot;buy&quot;,
                ///             &quot;type&quot;: &quot;INT&quot;,
                ///             &quot;primaryKey&quot;: false
                ///         },
                ///         &quot;cate_id&quot;: {
                ///             &quot;name&quot;: &quot;cate_id&quot;,
                ///             &quot;type&quot;: &quot;INT&quot;,
                ///             &quot;primaryKey&quot;: false
                ///         },
                ///         &quot;cate_name&quot;: {
                ///             &quot;name&quot;: &quot;cate_name&quot;,
                ///             &quot;type&quot;: &quot;LITERAL&quot;,
                ///             &quot;primaryKey&quot;: false
                ///         }
                ///     }
                /// }</para>
                /// </summary>
                [NameInMap("tables")]
                [Validation(Required=false)]
                public Dictionary<string, object> Tables { get; set; }

                /// <summary>
                /// <para>The document clearing configurations.</para>
                /// </summary>
                [NameInMap("ttlField")]
                [Validation(Required=false)]
                public CreateAppResponseBodyResultSchemaTtlField TtlField { get; set; }
                public class CreateAppResponseBodyResultSchemaTtlField : TeaModel {
                    /// <summary>
                    /// <para>The name of the document time field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>text1</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The TTL. Unit: milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("ttl")]
                    [Validation(Required=false)]
                    public long? Ttl { get; set; }

                }

            }

            /// <summary>
            /// <para>The multi-table schema.</para>
            /// </summary>
            [NameInMap("schemas")]
            [Validation(Required=false)]
            public List<CreateAppResponseBodyResultSchemas> Schemas { get; set; }
            public class CreateAppResponseBodyResultSchemas : TeaModel {
                /// <summary>
                /// <para>The sort configurations.</para>
                /// </summary>
                [NameInMap("indexSortConfig")]
                [Validation(Required=false)]
                public List<CreateAppResponseBodyResultSchemasIndexSortConfig> IndexSortConfig { get; set; }
                public class CreateAppResponseBodyResultSchemasIndexSortConfig : TeaModel {
                    /// <summary>
                    /// <para>The sort method. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>ASC</description></item>
                    /// <item><description>DESC</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DESC</para>
                    /// </summary>
                    [NameInMap("direction")]
                    [Validation(Required=false)]
                    public string Direction { get; set; }

                    /// <summary>
                    /// <para>The sort field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>fIeld1</para>
                    /// </summary>
                    [NameInMap("field")]
                    [Validation(Required=false)]
                    public string Field { get; set; }

                }

                /// <summary>
                /// <para>The index schema.</para>
                /// </summary>
                [NameInMap("indexes")]
                [Validation(Required=false)]
                public CreateAppResponseBodyResultSchemasIndexes Indexes { get; set; }
                public class CreateAppResponseBodyResultSchemasIndexes : TeaModel {
                    /// <summary>
                    /// <para>The attribute fields.</para>
                    /// </summary>
                    [NameInMap("filterFields")]
                    [Validation(Required=false)]
                    public List<string> FilterFields { get; set; }

                    /// <summary>
                    /// <para>The index fields.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{
                    ///   &quot;fields&quot;: [&quot;title&quot;],
                    ///   &quot;analyzer&quot;: &quot;chn_standard&quot;
                    /// }</para>
                    /// </summary>
                    [NameInMap("searchFields")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> SearchFields { get; set; }

                }

                /// <summary>
                /// <para>The name of the wide table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>main</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The name of the level-1 routing field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>field1</para>
                /// </summary>
                [NameInMap("routeField")]
                [Validation(Required=false)]
                public string RouteField { get; set; }

                /// <summary>
                /// <para>The hot values of the level-1 routing field. After you configure this parameter, level-2 routing is enabled.</para>
                /// </summary>
                [NameInMap("routeFieldValues")]
                [Validation(Required=false)]
                public List<string> RouteFieldValues { get; set; }

                /// <summary>
                /// <para>The name of the level-2 routing field. This parameter takes effect only when the routeFieldValues parameter is configured. By default, the wide-table primary key field is used as the level-2 routing field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>field2</para>
                /// </summary>
                [NameInMap("secondRouteField")]
                [Validation(Required=false)]
                public string SecondRouteField { get; set; }

                /// <summary>
                /// <para>The table schema.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///     &quot;primaryTable&quot;: true,
                ///     &quot;name&quot;: &quot;main&quot;,
                ///     &quot;fields&quot;: {
                ///         &quot;id&quot;: {
                ///             &quot;name&quot;: &quot;id&quot;,
                ///             &quot;type&quot;: &quot;LITERAL&quot;,
                ///             &quot;primaryKey&quot;: true
                ///         },
                ///         &quot;title&quot;: {
                ///             &quot;name&quot;: &quot;title&quot;,
                ///             &quot;type&quot;: &quot;TEXT&quot;,
                ///             &quot;primaryKey&quot;: false
                ///         },
                ///         &quot;buy&quot;: {
                ///             &quot;name&quot;: &quot;buy&quot;,
                ///             &quot;type&quot;: &quot;INT&quot;,
                ///             &quot;primaryKey&quot;: false
                ///         },
                ///         &quot;cate_id&quot;: {
                ///             &quot;name&quot;: &quot;cate_id&quot;,
                ///             &quot;type&quot;: &quot;INT&quot;,
                ///             &quot;primaryKey&quot;: false
                ///         },
                ///         &quot;cate_name&quot;: {
                ///             &quot;name&quot;: &quot;cate_name&quot;,
                ///             &quot;type&quot;: &quot;LITERAL&quot;,
                ///             &quot;primaryKey&quot;: false
                ///         }
                ///     }
                /// }</para>
                /// </summary>
                [NameInMap("tables")]
                [Validation(Required=false)]
                public Dictionary<string, object> Tables { get; set; }

                /// <summary>
                /// <para>The document clearing configurations.</para>
                /// </summary>
                [NameInMap("ttlField")]
                [Validation(Required=false)]
                public CreateAppResponseBodyResultSchemasTtlField TtlField { get; set; }
                public class CreateAppResponseBodyResultSchemasTtlField : TeaModel {
                    /// <summary>
                    /// <para>The name of the document time field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>fIeld1</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The TTL. Unit: milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("ttl")]
                    [Validation(Required=false)]
                    public long? Ttl { get; set; }

                }

            }

            /// <summary>
            /// <para>The configurations of fine sort.</para>
            /// </summary>
            [NameInMap("secondRanks")]
            [Validation(Required=false)]
            public List<CreateAppResponseBodyResultSecondRanks> SecondRanks { get; set; }
            public class CreateAppResponseBodyResultSecondRanks : TeaModel {
                /// <summary>
                /// <para>Indicates whether the expression is the default one.</para>
                /// 
                /// <b>Example:</b>
                /// <para>False</para>
                /// </summary>
                [NameInMap("active")]
                [Validation(Required=false)]
                public bool? Active { get; set; }

                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The fine sort expression. You can define an expression that contains fields, feature functions, and mathematical functions to implement complex sort logic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;cate_id &gt; 0 and cate_id &lt; 1000&quot;</para>
                /// </summary>
                [NameInMap("meta")]
                [Validation(Required=false)]
                public object Meta { get; set; }

                /// <summary>
                /// <para>The name of the fine sort expression.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The status of the application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>OK</description></item>
            /// <item><description>STOPPED</description></item>
            /// <item><description>FROZEN</description></item>
            /// <item><description>INITIALIZING</description></item>
            /// <item><description>UNAVAILABLE</description></item>
            /// <item><description>DATA_WAITING</description></item>
            /// <item><description>DATA_PREPARING</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The summary configurations of search results.</para>
            /// </summary>
            [NameInMap("summaries")]
            [Validation(Required=false)]
            public List<CreateAppResponseBodyResultSummaries> Summaries { get; set; }
            public class CreateAppResponseBodyResultSummaries : TeaModel {
                /// <summary>
                /// <para>The collection of summary configurations.</para>
                /// </summary>
                [NameInMap("meta")]
                [Validation(Required=false)]
                public List<CreateAppResponseBodyResultSummariesMeta> Meta { get; set; }
                public class CreateAppResponseBodyResultSummariesMeta : TeaModel {
                    /// <summary>
                    /// <para>The element that is used for highlighting.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>em</para>
                    /// </summary>
                    [NameInMap("element")]
                    [Validation(Required=false)]
                    public string Element { get; set; }

                    /// <summary>
                    /// <para>The connector that is used to connect segments.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>...</para>
                    /// </summary>
                    [NameInMap("ellipsis")]
                    [Validation(Required=false)]
                    public string Ellipsis { get; set; }

                    /// <summary>
                    /// <para>The field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>field1</para>
                    /// </summary>
                    [NameInMap("field")]
                    [Validation(Required=false)]
                    public string Field { get; set; }

                    /// <summary>
                    /// <para>The length of the segment. Valid values: 1 to 300.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("len")]
                    [Validation(Required=false)]
                    public int? Len { get; set; }

                    /// <summary>
                    /// <para>The number of segments. Valid values: 1 to 5.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("snippet")]
                    [Validation(Required=false)]
                    public string Snippet { get; set; }

                }

                /// <summary>
                /// <para>The group name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fefault</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("switchTime")]
            [Validation(Required=false)]
            public long? SwitchTime { get; set; }

            /// <summary>
            /// <para>The type of the application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>standard</description></item>
            /// <item><description>enhanced</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>standard</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("updated")]
            [Validation(Required=false)]
            public long? Updated { get; set; }

        }

    }

}
