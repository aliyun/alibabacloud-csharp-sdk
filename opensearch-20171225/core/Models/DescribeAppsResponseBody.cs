// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class DescribeAppsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>77CAA411-0010-4DB9-82E2-1C384E590AFF</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<DescribeAppsResponseBodyResult> Result { get; set; }
        public class DescribeAppsResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Indicates whether the version is automatically switched to an online version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("autoSwitch")]
            [Validation(Required=false)]
            public bool? AutoSwitch { get; set; }

            /// <summary>
            /// <para>The capability opening configurations.</para>
            /// </summary>
            [NameInMap("cluster")]
            [Validation(Required=false)]
            public DescribeAppsResponseBodyResultCluster Cluster { get; set; }
            public class DescribeAppsResponseBodyResultCluster : TeaModel {
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

            }

            /// <summary>
            /// <para>The cluster name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc_sh_domain_1</para>
            /// </summary>
            [NameInMap("clusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The configurations of data sources.</para>
            /// </summary>
            [NameInMap("dataSources")]
            [Validation(Required=false)]
            public List<DescribeAppsResponseBodyResultDataSources> DataSources { get; set; }
            public class DescribeAppsResponseBodyResultDataSources : TeaModel {
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
                /// </summary>
                [NameInMap("plugins")]
                [Validation(Required=false)]
                public Dictionary<string, object> Plugins { get; set; }

                /// <summary>
                /// <para>The name of the wide table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>name</para>
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
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The type of the industry. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>GENERAL</description></item>
            /// <item><description>ECOMMERCE</description></item>
            /// <item><description>IT_CONTENT</description></item>
            /// </list>
            /// </summary>
            [NameInMap("domain")]
            [Validation(Required=false)]
            public DescribeAppsResponseBodyResultDomain Domain { get; set; }
            public class DescribeAppsResponseBodyResultDomain : TeaModel {
                /// <summary>
                /// <para>The type of the edition. Valid values: standard, advance, and enhanced. A value of standard indicates a standard edition. A value of advance indicates an advanced edition which is of an old version. New version is not supported for this edition. A value of enhanced indicates an advanced edition which is of a new version.</para>
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
                /// <para>The search results.</para>
                /// </summary>
                [NameInMap("functions")]
                [Validation(Required=false)]
                public DescribeAppsResponseBodyResultDomainFunctions Functions { get; set; }
                public class DescribeAppsResponseBodyResultDomainFunctions : TeaModel {
                    /// <summary>
                    /// <para>Structure 1.</para>
                    /// </summary>
                    [NameInMap("algo")]
                    [Validation(Required=false)]
                    public List<string> Algo { get; set; }

                    /// <summary>
                    /// <para>Information 1.</para>
                    /// </summary>
                    [NameInMap("qp")]
                    [Validation(Required=false)]
                    public List<string> Qp { get; set; }

                    /// <summary>
                    /// <para>Feature 1.</para>
                    /// </summary>
                    [NameInMap("service")]
                    [Validation(Required=false)]
                    public List<string> Service { get; set; }

                }

                /// <summary>
                /// <para>The name (in English).</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
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
            public List<DescribeAppsResponseBodyResultFirstRanks> FirstRanks { get; set; }
            public class DescribeAppsResponseBodyResultFirstRanks : TeaModel {
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
                /// <para>The information about the expression. The information is displayed in the array or string format.</para>
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
                /// <para>STRUCT: The content of the expression is a structure. STRING (default): a custom formula.</para>
                /// 
                /// <b>Example:</b>
                /// <para>STRING</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100302881</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The field model.</para>
            /// </summary>
            [NameInMap("interpretations")]
            [Validation(Required=false)]
            public Dictionary<string, object> Interpretations { get; set; }

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
            /// <para>The progress of data import, in percentage. For example, a value of 83 indicates 83%.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("progressPercent")]
            [Validation(Required=false)]
            public int? ProgressPercent { get; set; }

            /// <summary>
            /// <para>The prompt configurations.</para>
            /// </summary>
            [NameInMap("prompts")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Prompts { get; set; }

            /// <summary>
            /// <para>The query intent understanding configurations.</para>
            /// </summary>
            [NameInMap("queryProcessors")]
            [Validation(Required=false)]
            public List<DescribeAppsResponseBodyResultQueryProcessors> QueryProcessors { get; set; }
            public class DescribeAppsResponseBodyResultQueryProcessors : TeaModel {
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
                /// <para>The type of the industry. Valid values:</para>
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
                /// <para>The indexes.</para>
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
            /// <para>The quota information.</para>
            /// </summary>
            [NameInMap("quota")]
            [Validation(Required=false)]
            public DescribeAppsResponseBodyResultQuota Quota { get; set; }
            public class DescribeAppsResponseBodyResultQuota : TeaModel {
                /// <summary>
                /// <para>The computing resources. Unit: logical computing unit (LCU).</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("computeResource")]
                [Validation(Required=false)]
                public int? ComputeResource { get; set; }

                /// <summary>
                /// <para>The storage capacity. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("docSize")]
                [Validation(Required=false)]
                public int? DocSize { get; set; }

                /// <summary>
                /// <para>The number of search requests per second. You are charged based on the number of search requests per second in the earlier billing model.</para>
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

            }

            /// <summary>
            /// <para>The application schema.</para>
            /// </summary>
            [NameInMap("schema")]
            [Validation(Required=false)]
            public DescribeAppsResponseBodyResultSchema Schema { get; set; }
            public class DescribeAppsResponseBodyResultSchema : TeaModel {
                /// <summary>
                /// <para>The sort configurations.</para>
                /// </summary>
                [NameInMap("indexSortConfig")]
                [Validation(Required=false)]
                public List<DescribeAppsResponseBodyResultSchemaIndexSortConfig> IndexSortConfig { get; set; }
                public class DescribeAppsResponseBodyResultSchemaIndexSortConfig : TeaModel {
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
                public DescribeAppsResponseBodyResultSchemaIndexes Indexes { get; set; }
                public class DescribeAppsResponseBodyResultSchemaIndexes : TeaModel {
                    /// <summary>
                    /// <para>The attribute fields.</para>
                    /// </summary>
                    [NameInMap("filterFields")]
                    [Validation(Required=false)]
                    public List<string> FilterFields { get; set; }

                    /// <summary>
                    /// <para>The index fields.</para>
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
                /// <para>The level-1 routing field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>field1</para>
                /// </summary>
                [NameInMap("routeField")]
                [Validation(Required=false)]
                public string RouteField { get; set; }

                /// <summary>
                /// <para>The hot values of the level-1 routing field.</para>
                /// </summary>
                [NameInMap("routeFieldValues")]
                [Validation(Required=false)]
                public List<string> RouteFieldValues { get; set; }

                /// <summary>
                /// <para>The level-2 routing field. This parameter is returned if the routeFieldValues parameter is returned. By default, the wide-table primary key field is used as the level-2 routing field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>field2</para>
                /// </summary>
                [NameInMap("secondRouteField")]
                [Validation(Required=false)]
                public string SecondRouteField { get; set; }

                /// <summary>
                /// <para>The table schema.</para>
                /// </summary>
                [NameInMap("tables")]
                [Validation(Required=false)]
                public Dictionary<string, object> Tables { get; set; }

                /// <summary>
                /// <para>The document clearing configurations.</para>
                /// </summary>
                [NameInMap("ttlField")]
                [Validation(Required=false)]
                public DescribeAppsResponseBodyResultSchemaTtlField TtlField { get; set; }
                public class DescribeAppsResponseBodyResultSchemaTtlField : TeaModel {
                    /// <summary>
                    /// <para>The document clearing field.</para>
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
            /// <para>The single-table schema.</para>
            /// </summary>
            [NameInMap("schemas")]
            [Validation(Required=false)]
            public List<DescribeAppsResponseBodyResultSchemas> Schemas { get; set; }
            public class DescribeAppsResponseBodyResultSchemas : TeaModel {
                /// <summary>
                /// <para>The sort configurations.</para>
                /// </summary>
                [NameInMap("indexSortConfig")]
                [Validation(Required=false)]
                public List<DescribeAppsResponseBodyResultSchemasIndexSortConfig> IndexSortConfig { get; set; }
                public class DescribeAppsResponseBodyResultSchemasIndexSortConfig : TeaModel {
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
                public DescribeAppsResponseBodyResultSchemasIndexes Indexes { get; set; }
                public class DescribeAppsResponseBodyResultSchemasIndexes : TeaModel {
                    /// <summary>
                    /// <para>The attribute fields.</para>
                    /// </summary>
                    [NameInMap("filterFields")]
                    [Validation(Required=false)]
                    public List<string> FilterFields { get; set; }

                    /// <summary>
                    /// <para>The index fields.</para>
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
                /// <para>The level-1 routing field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>field1</para>
                /// </summary>
                [NameInMap("routeField")]
                [Validation(Required=false)]
                public string RouteField { get; set; }

                /// <summary>
                /// <para>The hot values of the level-1 routing field.</para>
                /// </summary>
                [NameInMap("routeFieldValues")]
                [Validation(Required=false)]
                public List<string> RouteFieldValues { get; set; }

                /// <summary>
                /// <para>The level-2 routing field. This parameter is returned if the routeFieldValues parameter is returned. By default, the wide-table primary key field is used as the level-2 routing field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>field2</para>
                /// </summary>
                [NameInMap("secondRouteField")]
                [Validation(Required=false)]
                public string SecondRouteField { get; set; }

                /// <summary>
                /// <para>The table schema.</para>
                /// </summary>
                [NameInMap("tables")]
                [Validation(Required=false)]
                public Dictionary<string, object> Tables { get; set; }

                /// <summary>
                /// <para>The document clearing configurations.</para>
                /// </summary>
                [NameInMap("ttlField")]
                [Validation(Required=false)]
                public DescribeAppsResponseBodyResultSchemasTtlField TtlField { get; set; }
                public class DescribeAppsResponseBodyResultSchemasTtlField : TeaModel {
                    /// <summary>
                    /// <para>The document time field.</para>
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
            public List<DescribeAppsResponseBodyResultSecondRanks> SecondRanks { get; set; }
            public class DescribeAppsResponseBodyResultSecondRanks : TeaModel {
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
                /// <para>The fine sort expression. You can define an expression that consists of fields, feature functions, and mathematical functions to implement complex sort logic.</para>
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
            /// <para>The status of the version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ok: The version is normal.</description></item>
            /// <item><description>stopped: The version is suspended.</description></item>
            /// <item><description>frozen: The version is frozen.</description></item>
            /// <item><description>initializing: The version is being initialized.</description></item>
            /// <item><description>unavailable: The version is invalid.</description></item>
            /// <item><description>data_waiting: Data is to be initialized.</description></item>
            /// <item><description>data_preparing: Data is being initialized.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The search result summary configurations.</para>
            /// </summary>
            [NameInMap("summaries")]
            [Validation(Required=false)]
            public List<DescribeAppsResponseBodyResultSummaries> Summaries { get; set; }
            public class DescribeAppsResponseBodyResultSummaries : TeaModel {
                /// <summary>
                /// <para>The summary configurations.</para>
                /// </summary>
                [NameInMap("meta")]
                [Validation(Required=false)]
                public List<DescribeAppsResponseBodyResultSummariesMeta> Meta { get; set; }
                public class DescribeAppsResponseBodyResultSummariesMeta : TeaModel {
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

            /// <summary>
            /// <para>The type of the application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>standard: a standard edition application.</description></item>
            /// <item><description>advance: an advanced edition application of an old version. New versions are not supported for this edition.</description></item>
            /// <item><description>enhanced: an advanced edition application of a new version.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enhanced</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
