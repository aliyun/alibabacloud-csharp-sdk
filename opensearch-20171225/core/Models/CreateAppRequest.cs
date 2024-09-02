// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class CreateAppRequest : TeaModel {
        [NameInMap("autoSwitch")]
        [Validation(Required=false)]
        public bool? AutoSwitch { get; set; }

        [NameInMap("cluster")]
        [Validation(Required=false)]
        public CreateAppRequestCluster Cluster { get; set; }
        public class CreateAppRequestCluster : TeaModel {
            [NameInMap("maxQueryClauseLength")]
            [Validation(Required=false)]
            public int? MaxQueryClauseLength { get; set; }

            [NameInMap("maxTimeoutMS")]
            [Validation(Required=false)]
            public int? MaxTimeoutMS { get; set; }

        }

        [NameInMap("dataSources")]
        [Validation(Required=false)]
        public List<CreateAppRequestDataSources> DataSources { get; set; }
        public class CreateAppRequestDataSources : TeaModel {
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
        public CreateAppRequestDomain Domain { get; set; }
        public class CreateAppRequestDomain : TeaModel {
            [NameInMap("category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("functions")]
            [Validation(Required=false)]
            public Dictionary<string, object> Functions { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("fetchFields")]
        [Validation(Required=false)]
        public List<string> FetchFields { get; set; }

        [NameInMap("firstRanks")]
        [Validation(Required=false)]
        public List<CreateAppRequestFirstRanks> FirstRanks { get; set; }
        public class CreateAppRequestFirstRanks : TeaModel {
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

        [NameInMap("networkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        [NameInMap("queryProcessors")]
        [Validation(Required=false)]
        public List<CreateAppRequestQueryProcessors> QueryProcessors { get; set; }
        public class CreateAppRequestQueryProcessors : TeaModel {
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

        [NameInMap("schema")]
        [Validation(Required=false)]
        public CreateAppRequestSchema Schema { get; set; }
        public class CreateAppRequestSchema : TeaModel {
            [NameInMap("indexSortConfig")]
            [Validation(Required=false)]
            public List<CreateAppRequestSchemaIndexSortConfig> IndexSortConfig { get; set; }
            public class CreateAppRequestSchemaIndexSortConfig : TeaModel {
                [NameInMap("direction")]
                [Validation(Required=false)]
                public string Direction { get; set; }

                [NameInMap("field")]
                [Validation(Required=false)]
                public string Field { get; set; }

            }

            [NameInMap("indexes")]
            [Validation(Required=false)]
            public CreateAppRequestSchemaIndexes Indexes { get; set; }
            public class CreateAppRequestSchemaIndexes : TeaModel {
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
            public CreateAppRequestSchemaTtlField TtlField { get; set; }
            public class CreateAppRequestSchemaTtlField : TeaModel {
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
        public List<CreateAppRequestSchemas> Schemas { get; set; }
        public class CreateAppRequestSchemas : TeaModel {
            [NameInMap("indexSortConfig")]
            [Validation(Required=false)]
            public List<CreateAppRequestSchemasIndexSortConfig> IndexSortConfig { get; set; }
            public class CreateAppRequestSchemasIndexSortConfig : TeaModel {
                [NameInMap("direction")]
                [Validation(Required=false)]
                public string Direction { get; set; }

                [NameInMap("field")]
                [Validation(Required=false)]
                public string Field { get; set; }

            }

            [NameInMap("indexes")]
            [Validation(Required=false)]
            public CreateAppRequestSchemasIndexes Indexes { get; set; }
            public class CreateAppRequestSchemasIndexes : TeaModel {
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
            public CreateAppRequestSchemasTtlField TtlField { get; set; }
            public class CreateAppRequestSchemasTtlField : TeaModel {
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
        public List<CreateAppRequestSecondRanks> SecondRanks { get; set; }
        public class CreateAppRequestSecondRanks : TeaModel {
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

        [NameInMap("summaries")]
        [Validation(Required=false)]
        public List<CreateAppRequestSummaries> Summaries { get; set; }
        public class CreateAppRequestSummaries : TeaModel {
            [NameInMap("meta")]
            [Validation(Required=false)]
            public List<CreateAppRequestSummariesMeta> Meta { get; set; }
            public class CreateAppRequestSummariesMeta : TeaModel {
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
        /// Specifies whether to perform a dry run. This parameter is only used to check whether the data source is valid. Valid values: true and false.
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

    }

}
