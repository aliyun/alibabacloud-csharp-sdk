// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class DescribeAppResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the version.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public DescribeAppResponseBodyResult Result { get; set; }
        public class DescribeAppResponseBodyResult : TeaModel {
            /// <summary>
            /// Indicates whether the version is automatically published to the online environment.
            /// </summary>
            [NameInMap("autoSwitch")]
            [Validation(Required=false)]
            public bool? AutoSwitch { get; set; }

            [NameInMap("cluster")]
            [Validation(Required=false)]
            public DescribeAppResponseBodyResultCluster Cluster { get; set; }
            public class DescribeAppResponseBodyResultCluster : TeaModel {
                [NameInMap("maxQueryClauseLength")]
                [Validation(Required=false)]
                public int? MaxQueryClauseLength { get; set; }

                [NameInMap("maxTimeoutMS")]
                [Validation(Required=false)]
                public int? MaxTimeoutMS { get; set; }

            }

            /// <summary>
            /// The name of the cluster.
            /// </summary>
            [NameInMap("clusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            [NameInMap("dataSources")]
            [Validation(Required=false)]
            public List<DescribeAppResponseBodyResultDataSources> DataSources { get; set; }
            public class DescribeAppResponseBodyResultDataSources : TeaModel {
                [NameInMap("fields")]
                [Validation(Required=false)]
                public List<Dictionary<string, object>> Fields { get; set; }

                [NameInMap("keyField")]
                [Validation(Required=false)]
                public string KeyField { get; set; }

                [NameInMap("parameters")]
                [Validation(Required=false)]
                public Dictionary<string, object> Parameters { get; set; }

                [NameInMap("plugins")]
                [Validation(Required=false)]
                public Dictionary<string, object> Plugins { get; set; }

                [NameInMap("schemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                [NameInMap("tableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The description of the version.
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The type of the industry. Valid values:
            /// 
            /// *   GENERAL
            /// *   ECOMMERCE
            /// *   IT_CONTENT
            /// </summary>
            [NameInMap("domain")]
            [Validation(Required=false)]
            public DescribeAppResponseBodyResultDomain Domain { get; set; }
            public class DescribeAppResponseBodyResultDomain : TeaModel {
                /// <summary>
                /// The category. By default, this parameter is left empty.
                /// </summary>
                [NameInMap("category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// search functions
                /// </summary>
                [NameInMap("functions")]
                [Validation(Required=false)]
                public DescribeAppResponseBodyResultDomainFunctions Functions { get; set; }
                public class DescribeAppResponseBodyResultDomainFunctions : TeaModel {
                    /// <summary>
                    /// Algorithm structure
                    /// </summary>
                    [NameInMap("algo")]
                    [Validation(Required=false)]
                    public List<string> Algo { get; set; }

                    /// <summary>
                    /// Queryprocessor description
                    /// </summary>
                    [NameInMap("qp")]
                    [Validation(Required=false)]
                    public List<string> Qp { get; set; }

                    /// <summary>
                    /// Function description
                    /// </summary>
                    [NameInMap("service")]
                    [Validation(Required=false)]
                    public List<string> Service { get; set; }

                }

                /// <summary>
                /// The name
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// The default display fields.
            /// </summary>
            [NameInMap("fetchFields")]
            [Validation(Required=false)]
            public List<string> FetchFields { get; set; }

            [NameInMap("firstRanks")]
            [Validation(Required=false)]
            public List<DescribeAppResponseBodyResultFirstRanks> FirstRanks { get; set; }
            public class DescribeAppResponseBodyResultFirstRanks : TeaModel {
                [NameInMap("active")]
                [Validation(Required=false)]
                public bool? Active { get; set; }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("meta")]
                [Validation(Required=false)]
                public object Meta { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The ID of the version.
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("interpretations")]
            [Validation(Required=false)]
            public Dictionary<string, object> Interpretations { get; set; }

            [NameInMap("isCurrent")]
            [Validation(Required=false)]
            public bool? IsCurrent { get; set; }

            /// <summary>
            /// The progress of data import, in percentage. For example, a value of 83 indicates 83%.
            /// </summary>
            [NameInMap("progressPercent")]
            [Validation(Required=false)]
            public int? ProgressPercent { get; set; }

            [NameInMap("prompts")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Prompts { get; set; }

            [NameInMap("queryProcessors")]
            [Validation(Required=false)]
            public List<DescribeAppResponseBodyResultQueryProcessors> QueryProcessors { get; set; }
            public class DescribeAppResponseBodyResultQueryProcessors : TeaModel {
                [NameInMap("active")]
                [Validation(Required=false)]
                public bool? Active { get; set; }

                [NameInMap("category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                [NameInMap("indexes")]
                [Validation(Required=false)]
                public List<string> Indexes { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("processors")]
                [Validation(Required=false)]
                public List<Dictionary<string, object>> Processors { get; set; }

            }

            /// <summary>
            /// The quota information about the version.
            /// </summary>
            [NameInMap("quota")]
            [Validation(Required=false)]
            public DescribeAppResponseBodyResultQuota Quota { get; set; }
            public class DescribeAppResponseBodyResultQuota : TeaModel {
                /// <summary>
                /// The computing resources. Unit: logical computing units (LCUs).
                /// </summary>
                [NameInMap("computeResource")]
                [Validation(Required=false)]
                public int? ComputeResource { get; set; }

                /// <summary>
                /// The storage capacity. Unit: GB.
                /// </summary>
                [NameInMap("docSize")]
                [Validation(Required=false)]
                public int? DocSize { get; set; }

                /// <summary>
                /// The number of search requests per second. You are charged based on the number of search requests per second in the earlier billing model.
                /// </summary>
                [NameInMap("qps")]
                [Validation(Required=false)]
                public int? Qps { get; set; }

                /// <summary>
                /// The specifications of the application. Valid values:
                /// 
                /// *   opensearch.share.junior: basic
                /// *   opensearch.share.common: shared general-purpose
                /// *   opensearch.share.compute: shared computing
                /// *   opensearch.share.storage: shared storage
                /// *   opensearch.private.common: exclusive general-purpose
                /// *   opensearch.private.compute: exclusive computing
                /// *   opensearch.private.storage: exclusive storage
                /// </summary>
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

            }

            /// <summary>
            /// The application schema.
            /// </summary>
            [NameInMap("schema")]
            [Validation(Required=false)]
            public DescribeAppResponseBodyResultSchema Schema { get; set; }
            public class DescribeAppResponseBodyResultSchema : TeaModel {
                [NameInMap("indexSortConfig")]
                [Validation(Required=false)]
                public List<DescribeAppResponseBodyResultSchemaIndexSortConfig> IndexSortConfig { get; set; }
                public class DescribeAppResponseBodyResultSchemaIndexSortConfig : TeaModel {
                    [NameInMap("direction")]
                    [Validation(Required=false)]
                    public string Direction { get; set; }

                    [NameInMap("field")]
                    [Validation(Required=false)]
                    public string Field { get; set; }

                }

                [NameInMap("indexes")]
                [Validation(Required=false)]
                public DescribeAppResponseBodyResultSchemaIndexes Indexes { get; set; }
                public class DescribeAppResponseBodyResultSchemaIndexes : TeaModel {
                    [NameInMap("filterFields")]
                    [Validation(Required=false)]
                    public List<string> FilterFields { get; set; }

                    [NameInMap("searchFields")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> SearchFields { get; set; }

                }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("routeField")]
                [Validation(Required=false)]
                public string RouteField { get; set; }

                [NameInMap("routeFieldValues")]
                [Validation(Required=false)]
                public List<string> RouteFieldValues { get; set; }

                [NameInMap("secondRouteField")]
                [Validation(Required=false)]
                public string SecondRouteField { get; set; }

                [NameInMap("tables")]
                [Validation(Required=false)]
                public Dictionary<string, object> Tables { get; set; }

                [NameInMap("ttlField")]
                [Validation(Required=false)]
                public DescribeAppResponseBodyResultSchemaTtlField TtlField { get; set; }
                public class DescribeAppResponseBodyResultSchemaTtlField : TeaModel {
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("ttl")]
                    [Validation(Required=false)]
                    public long? Ttl { get; set; }

                }

            }

            [NameInMap("schemas")]
            [Validation(Required=false)]
            public List<DescribeAppResponseBodyResultSchemas> Schemas { get; set; }
            public class DescribeAppResponseBodyResultSchemas : TeaModel {
                [NameInMap("indexSortConfig")]
                [Validation(Required=false)]
                public List<DescribeAppResponseBodyResultSchemasIndexSortConfig> IndexSortConfig { get; set; }
                public class DescribeAppResponseBodyResultSchemasIndexSortConfig : TeaModel {
                    [NameInMap("direction")]
                    [Validation(Required=false)]
                    public string Direction { get; set; }

                    [NameInMap("field")]
                    [Validation(Required=false)]
                    public string Field { get; set; }

                }

                [NameInMap("indexes")]
                [Validation(Required=false)]
                public DescribeAppResponseBodyResultSchemasIndexes Indexes { get; set; }
                public class DescribeAppResponseBodyResultSchemasIndexes : TeaModel {
                    [NameInMap("filterFields")]
                    [Validation(Required=false)]
                    public List<string> FilterFields { get; set; }

                    [NameInMap("searchFields")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> SearchFields { get; set; }

                }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("routeField")]
                [Validation(Required=false)]
                public string RouteField { get; set; }

                [NameInMap("routeFieldValues")]
                [Validation(Required=false)]
                public List<string> RouteFieldValues { get; set; }

                [NameInMap("secondRouteField")]
                [Validation(Required=false)]
                public string SecondRouteField { get; set; }

                [NameInMap("tables")]
                [Validation(Required=false)]
                public Dictionary<string, object> Tables { get; set; }

                [NameInMap("ttlField")]
                [Validation(Required=false)]
                public DescribeAppResponseBodyResultSchemasTtlField TtlField { get; set; }
                public class DescribeAppResponseBodyResultSchemasTtlField : TeaModel {
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("ttl")]
                    [Validation(Required=false)]
                    public long? Ttl { get; set; }

                }

            }

            [NameInMap("secondRanks")]
            [Validation(Required=false)]
            public List<DescribeAppResponseBodyResultSecondRanks> SecondRanks { get; set; }
            public class DescribeAppResponseBodyResultSecondRanks : TeaModel {
                [NameInMap("active")]
                [Validation(Required=false)]
                public bool? Active { get; set; }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("meta")]
                [Validation(Required=false)]
                public object Meta { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// The status of the version. Valid values:
            /// 
            /// *   ok
            /// *   stopped
            /// *   frozen
            /// *   initializing
            /// *   unavailable
            /// *   data_waiting
            /// *   data_preparing
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("summaries")]
            [Validation(Required=false)]
            public List<DescribeAppResponseBodyResultSummaries> Summaries { get; set; }
            public class DescribeAppResponseBodyResultSummaries : TeaModel {
                [NameInMap("meta")]
                [Validation(Required=false)]
                public List<DescribeAppResponseBodyResultSummariesMeta> Meta { get; set; }
                public class DescribeAppResponseBodyResultSummariesMeta : TeaModel {
                    [NameInMap("element")]
                    [Validation(Required=false)]
                    public string Element { get; set; }

                    [NameInMap("ellipsis")]
                    [Validation(Required=false)]
                    public string Ellipsis { get; set; }

                    [NameInMap("field")]
                    [Validation(Required=false)]
                    public string Field { get; set; }

                    [NameInMap("len")]
                    [Validation(Required=false)]
                    public int? Len { get; set; }

                    [NameInMap("snippet")]
                    [Validation(Required=false)]
                    public string Snippet { get; set; }

                }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// The type of the application. Valid values:
            /// 
            /// *   standard: a standard application.
            /// *   advance: an advanced application which is of an old application type. New applications cannot be of this type.
            /// *   enhanced: an advanced application which is of a new application type.
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
