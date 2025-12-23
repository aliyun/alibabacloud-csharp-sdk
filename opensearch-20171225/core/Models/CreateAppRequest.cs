// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class CreateAppRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically switch the created version to an online version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("autoSwitch")]
        [Validation(Required=false)]
        public bool? AutoSwitch { get; set; }

        /// <summary>
        /// <para>The capability opening configurations.</para>
        /// </summary>
        [NameInMap("cluster")]
        [Validation(Required=false)]
        public CreateAppRequestCluster Cluster { get; set; }
        public class CreateAppRequestCluster : TeaModel {
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>ops-text-embedding-002</para>
            /// </summary>
            [NameInMap("textEmbeddingModel")]
            [Validation(Required=false)]
            public string TextEmbeddingModel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ops-text-sparse-embedding-001</para>
            /// </summary>
            [NameInMap("textSparseEmbeddingModel")]
            [Validation(Required=false)]
            public string TextSparseEmbeddingModel { get; set; }

            [NameInMap("vectorIndexConfigs")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> VectorIndexConfigs { get; set; }

        }

        [NameInMap("configItems")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> ConfigItems { get; set; }

        /// <summary>
        /// <para>The configurations of data sources.</para>
        /// </summary>
        [NameInMap("dataSources")]
        [Validation(Required=false)]
        public List<CreateAppRequestDataSources> DataSources { get; set; }
        public class CreateAppRequestDataSources : TeaModel {
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
        /// <para>The version description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;Version description&quot;</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The industry model module.</para>
        /// </summary>
        [NameInMap("domain")]
        [Validation(Required=false)]
        public CreateAppRequestDomain Domain { get; set; }
        public class CreateAppRequestDomain : TeaModel {
            /// <summary>
            /// <para>The industry category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>general</para>
            /// </summary>
            [NameInMap("category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The selected feature category. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>qp: query analysis</description></item>
            /// <item><description>algo: sort policy</description></item>
            /// <item><description>service: service</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;qp&quot;:[&quot;spellcheck&quot;],&quot;algo&quot;:[&quot;pop&quot;],&quot;service&quot;:[&quot;suggest&quot;]}</para>
            /// </summary>
            [NameInMap("functions")]
            [Validation(Required=false)]
            public Dictionary<string, object> Functions { get; set; }

            /// <summary>
            /// <para>The industry type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecommerce</para>
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
        public List<CreateAppRequestFirstRanks> FirstRanks { get; set; }
        public class CreateAppRequestFirstRanks : TeaModel {
            /// <summary>
            /// <para>Specifies whether the expression is the default one.</para>
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
            /// <list type="bullet">
            /// <item><description>STRUCT: The content of the expression is a structure.</description></item>
            /// <item><description>STRING (default): You can configure a custom formula.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>STRING</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("interpretations")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Interpretations { get; set; }

        /// <summary>
        /// <para>The zone identifier. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>vpc</description></item>
        /// <item><description>oxs</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vpc</para>
        /// </summary>
        [NameInMap("networkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        [NameInMap("prompts")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Prompts { get; set; }

        /// <summary>
        /// <para>The query intent understanding configurations.</para>
        /// </summary>
        [NameInMap("queryProcessors")]
        [Validation(Required=false)]
        public List<CreateAppRequestQueryProcessors> QueryProcessors { get; set; }
        public class CreateAppRequestQueryProcessors : TeaModel {
            /// <summary>
            /// <para>Specifies whether the rule is the default one.</para>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
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
            /// <para>ECOMMERCE</para>
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
            /// <para>name</para>
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

        [NameInMap("realtimeShared")]
        [Validation(Required=false)]
        public bool? RealtimeShared { get; set; }

        /// <summary>
        /// <para>The single-table schema.</para>
        /// </summary>
        [NameInMap("schema")]
        [Validation(Required=false)]
        public CreateAppRequestSchema Schema { get; set; }
        public class CreateAppRequestSchema : TeaModel {
            /// <summary>
            /// <para>The sort configurations.</para>
            /// </summary>
            [NameInMap("indexSortConfig")]
            [Validation(Required=false)]
            public List<CreateAppRequestSchemaIndexSortConfig> IndexSortConfig { get; set; }
            public class CreateAppRequestSchemaIndexSortConfig : TeaModel {
                /// <summary>
                /// <para>The sort method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ASC;
                /// DESC;</para>
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
            public CreateAppRequestSchemaIndexes Indexes { get; set; }
            public class CreateAppRequestSchemaIndexes : TeaModel {
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
            /// <para>table_name</para>
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
            /// <para>The name of the level-2 routing field. This parameter takes effect only when the <c>routeFieldValues</c> parameter is configured. By default, the wide-table primary key field is used as the level-2 routing field.</para>
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
            public CreateAppRequestSchemaTtlField TtlField { get; set; }
            public class CreateAppRequestSchemaTtlField : TeaModel {
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
        public List<CreateAppRequestSchemas> Schemas { get; set; }
        public class CreateAppRequestSchemas : TeaModel {
            /// <summary>
            /// <para>The sort configurations.</para>
            /// </summary>
            [NameInMap("indexSortConfig")]
            [Validation(Required=false)]
            public List<CreateAppRequestSchemasIndexSortConfig> IndexSortConfig { get; set; }
            public class CreateAppRequestSchemasIndexSortConfig : TeaModel {
                /// <summary>
                /// <para>The sort method.</para>
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
            public CreateAppRequestSchemasIndexes Indexes { get; set; }
            public class CreateAppRequestSchemasIndexes : TeaModel {
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
            /// <para>table_name</para>
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
            public CreateAppRequestSchemasTtlField TtlField { get; set; }
            public class CreateAppRequestSchemasTtlField : TeaModel {
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
        /// <para>The configurations of fine sort.</para>
        /// </summary>
        [NameInMap("secondRanks")]
        [Validation(Required=false)]
        public List<CreateAppRequestSecondRanks> SecondRanks { get; set; }
        public class CreateAppRequestSecondRanks : TeaModel {
            /// <summary>
            /// <para>Specifies whether the expression is the default one.</para>
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
        /// <para>The summary configurations of search results.</para>
        /// </summary>
        [NameInMap("summaries")]
        [Validation(Required=false)]
        public List<CreateAppRequestSummaries> Summaries { get; set; }
        public class CreateAppRequestSummaries : TeaModel {
            /// <summary>
            /// <para>The collection of summary configurations.</para>
            /// </summary>
            [NameInMap("meta")]
            [Validation(Required=false)]
            public List<CreateAppRequestSummariesMeta> Meta { get; set; }
            public class CreateAppRequestSummariesMeta : TeaModel {
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
                /// <para>1</para>
                /// </summary>
                [NameInMap("snippet")]
                [Validation(Required=false)]
                public string Snippet { get; set; }

            }

            /// <summary>
            /// <para>The group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. This parameter is only used to check whether the data source is valid. Valid values: true and false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

    }

}
