// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListClustersResponseBody : TeaModel {
        /// <summary>
        /// id of request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The list of clusters.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListClustersResponseBodyResult> Result { get; set; }
        public class ListClustersResponseBodyResult : TeaModel {
            [NameInMap("config")]
            [Validation(Required=false)]
            public Dictionary<string, Dictionary<string, object>> Config { get; set; }

            /// <summary>
            /// The time when the configuration was updated.
            /// </summary>
            [NameInMap("configUpdateTime")]
            [Validation(Required=false)]
            public string ConfigUpdateTime { get; set; }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The effective advanced version.
            /// </summary>
            [NameInMap("currentAdvanceConfigVersion")]
            [Validation(Required=false)]
            public string CurrentAdvanceConfigVersion { get; set; }

            /// <summary>
            /// 词典配置生效版本
            /// </summary>
            [NameInMap("currentOfflineDictConfigVersion")]
            [Validation(Required=false)]
            public string CurrentOfflineDictConfigVersion { get; set; }

            /// <summary>
            /// The effective online configuration version.
            /// </summary>
            [NameInMap("currentOnlineConfigVersion")]
            [Validation(Required=false)]
            public string CurrentOnlineConfigVersion { get; set; }

            /// <summary>
            /// 查询配置生效版本
            /// </summary>
            [NameInMap("currentOnlineQueryConfigVersion")]
            [Validation(Required=false)]
            public string CurrentOnlineQueryConfigVersion { get; set; }

            /// <summary>
            /// The information about the node in the cluster.
            /// </summary>
            [NameInMap("dataNode")]
            [Validation(Required=false)]
            public ListClustersResponseBodyResultDataNode DataNode { get; set; }
            public class ListClustersResponseBodyResultDataNode : TeaModel {
                /// <summary>
                /// The name of the node.
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
                /// The partition ID of the node.
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
            /// 词典配置最新版本
            /// </summary>
            [NameInMap("latestOfflineDictConfigVersion")]
            [Validation(Required=false)]
            public string LatestOfflineDictConfigVersion { get; set; }

            /// <summary>
            /// The latest online configuration version.
            /// </summary>
            [NameInMap("latestOnlineConfigVersion")]
            [Validation(Required=false)]
            public string LatestOnlineConfigVersion { get; set; }

            /// <summary>
            /// 查询配置最新版本
            /// </summary>
            [NameInMap("latestOnlineQueryConfigVersion")]
            [Validation(Required=false)]
            public string LatestOnlineQueryConfigVersion { get; set; }

            /// <summary>
            /// The name of the cluster.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The query node of the cluster.
            /// </summary>
            [NameInMap("queryNode")]
            [Validation(Required=false)]
            public ListClustersResponseBodyResultQueryNode QueryNode { get; set; }
            public class ListClustersResponseBodyResultQueryNode : TeaModel {
                /// <summary>
                /// The name of the node.
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
                /// The number o replicas.
                /// </summary>
                [NameInMap("partition")]
                [Validation(Required=false)]
                public int? Partition { get; set; }

            }

            /// <summary>
            /// The status of the cluster. Valid values: running, starting, stopping, and stopped. running indicates the cluster is running, starting indicates the cluster is starting, stopping indicates the cluster is stopping, and stopped indicates the cluster has stopped.
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
