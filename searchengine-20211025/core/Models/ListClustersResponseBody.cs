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
        /// The clusters.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListClustersResponseBodyResult> Result { get; set; }
        public class ListClustersResponseBodyResult : TeaModel {
            /// <summary>
            /// The configuration information.
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public Dictionary<string, Dictionary<string, object>> Config { get; set; }

            /// <summary>
            /// The time when the configuration was updated.
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
            /// The effective dictionary configuration version.
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
            /// The effective query configuration version.
            /// </summary>
            [NameInMap("currentOnlineQueryConfigVersion")]
            [Validation(Required=false)]
            public string CurrentOnlineQueryConfigVersion { get; set; }

            /// <summary>
            /// The information about Searcher workers.
            /// </summary>
            [NameInMap("dataNode")]
            [Validation(Required=false)]
            public ListClustersResponseBodyResultDataNode DataNode { get; set; }
            public class ListClustersResponseBodyResultDataNode : TeaModel {
                /// <summary>
                /// The name of the Searcher worker.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The number of Searcher workers.
                /// </summary>
                [NameInMap("number")]
                [Validation(Required=false)]
                public int? Number { get; set; }

                /// <summary>
                /// The ID of the partition that is stored on the Searcher worker.
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
            /// The latest dictionary configuration version.
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
            /// The latest query configuration version.
            /// </summary>
            [NameInMap("latestOnlineQueryConfigVersion")]
            [Validation(Required=false)]
            public string LatestOnlineQueryConfigVersion { get; set; }

            /// <summary>
            /// The cluster name.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The information about Query Result Searcher (QRS) workers.
            /// </summary>
            [NameInMap("queryNode")]
            [Validation(Required=false)]
            public ListClustersResponseBodyResultQueryNode QueryNode { get; set; }
            public class ListClustersResponseBodyResultQueryNode : TeaModel {
                /// <summary>
                /// The name of the QRS worker.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The number of QRS workers.
                /// </summary>
                [NameInMap("number")]
                [Validation(Required=false)]
                public int? Number { get; set; }

                /// <summary>
                /// The ID of the partition that is stored on the QRS worker.
                /// </summary>
                [NameInMap("partition")]
                [Validation(Required=false)]
                public int? Partition { get; set; }

            }

            /// <summary>
            /// The cluster status. Valid values: running: The cluster is running. starting: The cluster is being started. stopping: The cluster is being stopped. stopped: The cluster is stopped.
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
