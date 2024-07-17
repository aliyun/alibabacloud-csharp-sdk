// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class GetDeployGraphResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The results returned.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetDeployGraphResponseBodyResult Result { get; set; }
        public class GetDeployGraphResponseBodyResult : TeaModel {
            /// <summary>
            /// The deployment information.
            /// </summary>
            [NameInMap("graph")]
            [Validation(Required=false)]
            public GetDeployGraphResponseBodyResultGraph Graph { get; set; }
            public class GetDeployGraphResponseBodyResultGraph : TeaModel {
                /// <summary>
                /// The index metadata.
                /// </summary>
                [NameInMap("indexMetas")]
                [Validation(Required=false)]
                public List<GetDeployGraphResponseBodyResultGraphIndexMetas> IndexMetas { get; set; }
                public class GetDeployGraphResponseBodyResultGraphIndexMetas : TeaModel {
                    /// <summary>
                    /// The name of the data center.
                    /// </summary>
                    [NameInMap("domainName")]
                    [Validation(Required=false)]
                    public string DomainName { get; set; }

                    /// <summary>
                    /// The index name.
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The deployment ID of the table.
                    /// </summary>
                    [NameInMap("tableDeployId")]
                    [Validation(Required=false)]
                    public long? TableDeployId { get; set; }

                    /// <summary>
                    /// The name of the data source.
                    /// </summary>
                    [NameInMap("tableName")]
                    [Validation(Required=false)]
                    public string TableName { get; set; }

                    /// <summary>
                    /// The tag.
                    /// </summary>
                    [NameInMap("tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                    /// <summary>
                    /// The name of the QRS worker.
                    /// </summary>
                    [NameInMap("zoneName")]
                    [Validation(Required=false)]
                    public string ZoneName { get; set; }

                }

                /// <summary>
                /// The metadata of online clusters.
                /// </summary>
                [NameInMap("onlineMaster")]
                [Validation(Required=false)]
                public List<GetDeployGraphResponseBodyResultGraphOnlineMaster> OnlineMaster { get; set; }
                public class GetDeployGraphResponseBodyResultGraphOnlineMaster : TeaModel {
                    /// <summary>
                    /// The name of the data center.
                    /// </summary>
                    [NameInMap("domainName")]
                    [Validation(Required=false)]
                    public string DomainName { get; set; }

                    /// <summary>
                    /// The resource ID.
                    /// </summary>
                    [NameInMap("hippoId")]
                    [Validation(Required=false)]
                    public string HippoId { get; set; }

                    /// <summary>
                    /// The ID of the data center.
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// The name of the online cluster.
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// The association relationships between data sources and indexes.
                /// </summary>
                [NameInMap("tableIndexRelation")]
                [Validation(Required=false)]
                public Dictionary<string, List<string>> TableIndexRelation { get; set; }

                /// <summary>
                /// The metadata of data sources.
                /// </summary>
                [NameInMap("tableMetas")]
                [Validation(Required=false)]
                public List<GetDeployGraphResponseBodyResultGraphTableMetas> TableMetas { get; set; }
                public class GetDeployGraphResponseBodyResultGraphTableMetas : TeaModel {
                    /// <summary>
                    /// The ID of the offline deployment.
                    /// </summary>
                    [NameInMap("buildDeployId")]
                    [Validation(Required=false)]
                    public long? BuildDeployId { get; set; }

                    /// <summary>
                    /// The name of the data center.
                    /// </summary>
                    [NameInMap("domainName")]
                    [Validation(Required=false)]
                    public string DomainName { get; set; }

                    /// <summary>
                    /// The name of the data source.
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The deployment ID of the table.
                    /// </summary>
                    [NameInMap("tableDeployId")]
                    [Validation(Required=false)]
                    public long? TableDeployId { get; set; }

                    /// <summary>
                    /// The tag.
                    /// </summary>
                    [NameInMap("tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                    /// <summary>
                    /// The type of the data source.
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// The association relationships between zones and indexes.
                /// </summary>
                [NameInMap("zoneIndexRelation")]
                [Validation(Required=false)]
                public Dictionary<string, List<string>> ZoneIndexRelation { get; set; }

                /// <summary>
                /// The zone metadata.
                /// </summary>
                [NameInMap("zoneMetas")]
                [Validation(Required=false)]
                public List<GetDeployGraphResponseBodyResultGraphZoneMetas> ZoneMetas { get; set; }
                public class GetDeployGraphResponseBodyResultGraphZoneMetas : TeaModel {
                    /// <summary>
                    /// The name of the data center.
                    /// </summary>
                    [NameInMap("domainInfo")]
                    [Validation(Required=false)]
                    public string DomainInfo { get; set; }

                    /// <summary>
                    /// The name of the Query Result Searcher (QRS) worker.
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The name of the service that is used to manage the relationships between online clusters and indexes.
                    /// </summary>
                    [NameInMap("suezAdminName")]
                    [Validation(Required=false)]
                    public string SuezAdminName { get; set; }

                    /// <summary>
                    /// The tag.
                    /// </summary>
                    [NameInMap("tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                    /// <summary>
                    /// The node type.
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

        }

    }

}
