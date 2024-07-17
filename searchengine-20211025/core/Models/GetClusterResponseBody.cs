// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class GetClusterResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The clusters.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetClusterResponseBodyResult Result { get; set; }
        public class GetClusterResponseBodyResult : TeaModel {
            /// <summary>
            /// The configuration information.
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public Dictionary<string, Dictionary<string, object>> Config { get; set; }

            /// <summary>
            /// The time when the cluster was updated.
            /// </summary>
            [NameInMap("configUpdateTime")]
            [Validation(Required=false)]
            public string ConfigUpdateTime { get; set; }

            /// <summary>
            /// The time when the cluster was created.
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The effective advanced configuration version.
            /// </summary>
            [NameInMap("currentAdvanceConfigVersion")]
            [Validation(Required=false)]
            public string CurrentAdvanceConfigVersion { get; set; }

            /// <summary>
            /// The effective online configuration version.
            /// </summary>
            [NameInMap("currentOnlineConfigVersion")]
            [Validation(Required=false)]
            public string CurrentOnlineConfigVersion { get; set; }

            /// <summary>
            /// The specifications of Searcher workers.
            /// </summary>
            [NameInMap("dataNode")]
            [Validation(Required=false)]
            public GetClusterResponseBodyResultDataNode DataNode { get; set; }
            public class GetClusterResponseBodyResultDataNode : TeaModel {
                /// <summary>
                /// The name of the Searcher worker.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The number of replicas.
                /// </summary>
                [NameInMap("number")]
                [Validation(Required=false)]
                public int? Number { get; set; }

                /// <summary>
                /// The number of partitions.
                /// </summary>
                [NameInMap("partition")]
                [Validation(Required=false)]
                public int? Partition { get; set; }

            }

            /// <summary>
            /// The description of the cluster.
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The latest advanced configuration version.
            /// </summary>
            [NameInMap("latestAdvanceConfigVersion")]
            [Validation(Required=false)]
            public string LatestAdvanceConfigVersion { get; set; }

            /// <summary>
            /// The latest online configuration version.
            /// </summary>
            [NameInMap("latestOnlineConfigVersion")]
            [Validation(Required=false)]
            public string LatestOnlineConfigVersion { get; set; }

            /// <summary>
            /// The cluster name.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The specifications of Query Result Searcher (QRS) workers.
            /// </summary>
            [NameInMap("queryNode")]
            [Validation(Required=false)]
            public GetClusterResponseBodyResultQueryNode QueryNode { get; set; }
            public class GetClusterResponseBodyResultQueryNode : TeaModel {
                /// <summary>
                /// The name of the QRS worker.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The number of nodes.
                /// </summary>
                [NameInMap("number")]
                [Validation(Required=false)]
                public int? Number { get; set; }

                /// <summary>
                /// The number of replicas.
                /// </summary>
                [NameInMap("partition")]
                [Validation(Required=false)]
                public int? Partition { get; set; }

            }

            /// <summary>
            /// The creation status of the cluster. Valid values: NEW and PUBLISH. NEW indicates that the cluster is being created. PUBLISH indicates that the cluster is created.
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
