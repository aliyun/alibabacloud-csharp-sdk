// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class CreateAppResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The returned results.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateAppResponseBodyResult Result { get; set; }
        public class CreateAppResponseBodyResult : TeaModel {
            [NameInMap("autoSwitch")]
            [Validation(Required=false)]
            public bool? AutoSwitch { get; set; }

            [NameInMap("cluster")]
            [Validation(Required=false)]
            public CreateAppResponseBodyResultCluster Cluster { get; set; }
            public class CreateAppResponseBodyResultCluster : TeaModel {
                [NameInMap("maxQueryClauseLength")]
                [Validation(Required=false)]
                public int? MaxQueryClauseLength { get; set; }

                [NameInMap("maxTimeoutMS")]
                [Validation(Required=false)]
                public int? MaxTimeoutMS { get; set; }

            }

            [NameInMap("clusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            [NameInMap("dataSources")]
            [Validation(Required=false)]
            public List<CreateAppResponseBodyResultDataSources> DataSources { get; set; }
            public class CreateAppResponseBodyResultDataSources : TeaModel {
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

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("domain")]
            [Validation(Required=false)]
            public CreateAppResponseBodyResultDomain Domain { get; set; }
            public class CreateAppResponseBodyResultDomain : TeaModel {
                [NameInMap("category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("functions")]
                [Validation(Required=false)]
                public CreateAppResponseBodyResultDomainFunctions Functions { get; set; }
                public class CreateAppResponseBodyResultDomainFunctions : TeaModel {
                    [NameInMap("algo")]
                    [Validation(Required=false)]
                    public List<string> Algo { get; set; }

                    [NameInMap("qp")]
                    [Validation(Required=false)]
                    public List<string> Qp { get; set; }

                    [NameInMap("service")]
                    [Validation(Required=false)]
                    public List<string> Service { get; set; }

                }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("fetchFields")]
            [Validation(Required=false)]
            public List<string> FetchFields { get; set; }

            [NameInMap("firstRanks")]
            [Validation(Required=false)]
            public List<CreateAppResponseBodyResultFirstRanks> FirstRanks { get; set; }
            public class CreateAppResponseBodyResultFirstRanks : TeaModel {
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

            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("interpretations")]
            [Validation(Required=false)]
            public Dictionary<string, object> Interpretations { get; set; }

            [NameInMap("isCurrent")]
            [Validation(Required=false)]
            public bool? IsCurrent { get; set; }

            [NameInMap("progressPercent")]
            [Validation(Required=false)]
            public int? ProgressPercent { get; set; }

            [NameInMap("prompts")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Prompts { get; set; }

            [NameInMap("queryProcessors")]
            [Validation(Required=false)]
            public List<CreateAppResponseBodyResultQueryProcessors> QueryProcessors { get; set; }
            public class CreateAppResponseBodyResultQueryProcessors : TeaModel {
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

            [NameInMap("quota")]
            [Validation(Required=false)]
            public CreateAppResponseBodyResultQuota Quota { get; set; }
            public class CreateAppResponseBodyResultQuota : TeaModel {
                [NameInMap("computeResource")]
                [Validation(Required=false)]
                public int? ComputeResource { get; set; }

                [NameInMap("docSize")]
                [Validation(Required=false)]
                public int? DocSize { get; set; }

                [NameInMap("qps")]
                [Validation(Required=false)]
                public int? Qps { get; set; }

                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

            }

            [NameInMap("schema")]
            [Validation(Required=false)]
            public CreateAppResponseBodyResultSchema Schema { get; set; }
            public class CreateAppResponseBodyResultSchema : TeaModel {
                [NameInMap("indexSortConfig")]
                [Validation(Required=false)]
                public List<CreateAppResponseBodyResultSchemaIndexSortConfig> IndexSortConfig { get; set; }
                public class CreateAppResponseBodyResultSchemaIndexSortConfig : TeaModel {
                    [NameInMap("direction")]
                    [Validation(Required=false)]
                    public string Direction { get; set; }

                    [NameInMap("field")]
                    [Validation(Required=false)]
                    public string Field { get; set; }

                }

                [NameInMap("indexes")]
                [Validation(Required=false)]
                public CreateAppResponseBodyResultSchemaIndexes Indexes { get; set; }
                public class CreateAppResponseBodyResultSchemaIndexes : TeaModel {
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
                public CreateAppResponseBodyResultSchemaTtlField TtlField { get; set; }
                public class CreateAppResponseBodyResultSchemaTtlField : TeaModel {
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
            public List<CreateAppResponseBodyResultSchemas> Schemas { get; set; }
            public class CreateAppResponseBodyResultSchemas : TeaModel {
                [NameInMap("indexSortConfig")]
                [Validation(Required=false)]
                public List<CreateAppResponseBodyResultSchemasIndexSortConfig> IndexSortConfig { get; set; }
                public class CreateAppResponseBodyResultSchemasIndexSortConfig : TeaModel {
                    [NameInMap("direction")]
                    [Validation(Required=false)]
                    public string Direction { get; set; }

                    [NameInMap("field")]
                    [Validation(Required=false)]
                    public string Field { get; set; }

                }

                [NameInMap("indexes")]
                [Validation(Required=false)]
                public CreateAppResponseBodyResultSchemasIndexes Indexes { get; set; }
                public class CreateAppResponseBodyResultSchemasIndexes : TeaModel {
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
                public CreateAppResponseBodyResultSchemasTtlField TtlField { get; set; }
                public class CreateAppResponseBodyResultSchemasTtlField : TeaModel {
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
            public List<CreateAppResponseBodyResultSecondRanks> SecondRanks { get; set; }
            public class CreateAppResponseBodyResultSecondRanks : TeaModel {
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

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("summaries")]
            [Validation(Required=false)]
            public List<CreateAppResponseBodyResultSummaries> Summaries { get; set; }
            public class CreateAppResponseBodyResultSummaries : TeaModel {
                [NameInMap("meta")]
                [Validation(Required=false)]
                public List<CreateAppResponseBodyResultSummariesMeta> Meta { get; set; }
                public class CreateAppResponseBodyResultSummariesMeta : TeaModel {
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

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
