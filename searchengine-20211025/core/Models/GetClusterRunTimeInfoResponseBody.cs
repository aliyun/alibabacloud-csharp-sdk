// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class GetClusterRunTimeInfoResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The result set.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetClusterRunTimeInfoResponseBodyResult> Result { get; set; }
        public class GetClusterRunTimeInfoResponseBodyResult : TeaModel {
            /// <summary>
            /// The name of the cluster.
            /// </summary>
            [NameInMap("clusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// The information about the data node.
            /// </summary>
            [NameInMap("dataNodes")]
            [Validation(Required=false)]
            public List<GetClusterRunTimeInfoResponseBodyResultDataNodes> DataNodes { get; set; }
            public class GetClusterRunTimeInfoResponseBodyResultDataNodes : TeaModel {
                /// <summary>
                /// The configuration status list.
                /// </summary>
                [NameInMap("configStatusList")]
                [Validation(Required=false)]
                public List<GetClusterRunTimeInfoResponseBodyResultDataNodesConfigStatusList> ConfigStatusList { get; set; }
                public class GetClusterRunTimeInfoResponseBodyResultDataNodesConfigStatusList : TeaModel {
                    /// <summary>
                    /// The time when the cluster was updated.
                    /// </summary>
                    [NameInMap("configUpdateTime")]
                    [Validation(Required=false)]
                    public string ConfigUpdateTime { get; set; }

                    /// <summary>
                    /// The overall progress.
                    /// </summary>
                    [NameInMap("donePercent")]
                    [Validation(Required=false)]
                    public int? DonePercent { get; set; }

                    /// <summary>
                    /// The number of nodes that are configured.
                    /// </summary>
                    [NameInMap("doneSize")]
                    [Validation(Required=false)]
                    public int? DoneSize { get; set; }

                    /// <summary>
                    /// The name of the cluster.
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The total number of nodes that you specify when you create the cluster.
                    /// </summary>
                    [NameInMap("totalSize")]
                    [Validation(Required=false)]
                    public int? TotalSize { get; set; }

                }

                /// <summary>
                /// The dataStatusList.
                /// </summary>
                [NameInMap("dataStatusList")]
                [Validation(Required=false)]
                public List<GetClusterRunTimeInfoResponseBodyResultDataNodesDataStatusList> DataStatusList { get; set; }
                public class GetClusterRunTimeInfoResponseBodyResultDataNodesDataStatusList : TeaModel {
                    /// <summary>
                    /// The information about advanced configurations.
                    /// </summary>
                    [NameInMap("advanceConfigInfo")]
                    [Validation(Required=false)]
                    public GetClusterRunTimeInfoResponseBodyResultDataNodesDataStatusListAdvanceConfigInfo AdvanceConfigInfo { get; set; }
                    public class GetClusterRunTimeInfoResponseBodyResultDataNodesDataStatusListAdvanceConfigInfo : TeaModel {
                        /// <summary>
                        /// The name of the index configuration.
                        /// </summary>
                        [NameInMap("configMetaName")]
                        [Validation(Required=false)]
                        public string ConfigMetaName { get; set; }

                        /// <summary>
                        /// The version number.
                        /// </summary>
                        [NameInMap("version")]
                        [Validation(Required=false)]
                        public long? Version { get; set; }

                    }

                    /// <summary>
                    /// The name of the worker that failed because of a deployment failure.
                    /// </summary>
                    [NameInMap("deployFailedWorker")]
                    [Validation(Required=false)]
                    public List<string> DeployFailedWorker { get; set; }

                    /// <summary>
                    /// The storage capacity. Unit: GB.
                    /// </summary>
                    [NameInMap("docSize")]
                    [Validation(Required=false)]
                    public int? DocSize { get; set; }

                    /// <summary>
                    /// The overall progress.
                    /// </summary>
                    [NameInMap("donePercent")]
                    [Validation(Required=false)]
                    public int? DonePercent { get; set; }

                    /// <summary>
                    /// The number of nodes that are configured.
                    /// </summary>
                    [NameInMap("doneSize")]
                    [Validation(Required=false)]
                    public int? DoneSize { get; set; }

                    /// <summary>
                    /// The error message.
                    /// </summary>
                    [NameInMap("errorMsg")]
                    [Validation(Required=false)]
                    public string ErrorMsg { get; set; }

                    /// <summary>
                    /// The time when the full data was updated.
                    /// </summary>
                    [NameInMap("fullUpdateTime")]
                    [Validation(Required=false)]
                    public string FullUpdateTime { get; set; }

                    /// <summary>
                    /// The full version.
                    /// </summary>
                    [NameInMap("fullVersion")]
                    [Validation(Required=false)]
                    public long? FullVersion { get; set; }

                    /// <summary>
                    /// The time when the incremental data was updated.
                    /// </summary>
                    [NameInMap("incUpdateTime")]
                    [Validation(Required=false)]
                    public string IncUpdateTime { get; set; }

                    /// <summary>
                    /// The incremental version.
                    /// </summary>
                    [NameInMap("incVersion")]
                    [Validation(Required=false)]
                    public long? IncVersion { get; set; }

                    /// <summary>
                    /// The configuration information of the index.
                    /// </summary>
                    [NameInMap("indexConfigInfo")]
                    [Validation(Required=false)]
                    public GetClusterRunTimeInfoResponseBodyResultDataNodesDataStatusListIndexConfigInfo IndexConfigInfo { get; set; }
                    public class GetClusterRunTimeInfoResponseBodyResultDataNodesDataStatusListIndexConfigInfo : TeaModel {
                        /// <summary>
                        /// The name of the index configuration.
                        /// </summary>
                        [NameInMap("configMetaName")]
                        [Validation(Required=false)]
                        public string ConfigMetaName { get; set; }

                        /// <summary>
                        /// The version of the index template.
                        /// </summary>
                        [NameInMap("version")]
                        [Validation(Required=false)]
                        public long? Version { get; set; }

                    }

                    /// <summary>
                    /// The size of the index.
                    /// </summary>
                    [NameInMap("indexSize")]
                    [Validation(Required=false)]
                    public long? IndexSize { get; set; }

                    /// <summary>
                    /// The name of the worker that failed because of insufficient disk space.
                    /// </summary>
                    [NameInMap("lackDiskWorker")]
                    [Validation(Required=false)]
                    public List<string> LackDiskWorker { get; set; }

                    /// <summary>
                    /// The name of the worker that failed because of insufficient memory.
                    /// </summary>
                    [NameInMap("lackMemWorker")]
                    [Validation(Required=false)]
                    public List<string> LackMemWorker { get; set; }

                    /// <summary>
                    /// The name of the node.
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The total number of nodes that you specify when you create the cluster.
                    /// </summary>
                    [NameInMap("totalSize")]
                    [Validation(Required=false)]
                    public int? TotalSize { get; set; }

                }

                /// <summary>
                /// The service status.
                /// </summary>
                [NameInMap("serviceStatus")]
                [Validation(Required=false)]
                public GetClusterRunTimeInfoResponseBodyResultDataNodesServiceStatus ServiceStatus { get; set; }
                public class GetClusterRunTimeInfoResponseBodyResultDataNodesServiceStatus : TeaModel {
                    /// <summary>
                    /// The overall progress.
                    /// </summary>
                    [NameInMap("donePercent")]
                    [Validation(Required=false)]
                    public int? DonePercent { get; set; }

                    /// <summary>
                    /// The number of nodes being processed in the cluster.
                    /// </summary>
                    [NameInMap("doneSize")]
                    [Validation(Required=false)]
                    public int? DoneSize { get; set; }

                    /// <summary>
                    /// The name.
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The total number of nodes in the cluster.
                    /// </summary>
                    [NameInMap("totalSize")]
                    [Validation(Required=false)]
                    public int? TotalSize { get; set; }

                }

            }

            /// <summary>
            /// The information about the query node.
            /// </summary>
            [NameInMap("queryNode")]
            [Validation(Required=false)]
            public GetClusterRunTimeInfoResponseBodyResultQueryNode QueryNode { get; set; }
            public class GetClusterRunTimeInfoResponseBodyResultQueryNode : TeaModel {
                /// <summary>
                /// The dataStatusList.
                /// </summary>
                [NameInMap("configStatusList")]
                [Validation(Required=false)]
                public List<GetClusterRunTimeInfoResponseBodyResultQueryNodeConfigStatusList> ConfigStatusList { get; set; }
                public class GetClusterRunTimeInfoResponseBodyResultQueryNodeConfigStatusList : TeaModel {
                    /// <summary>
                    /// The time when the cluster was updated.
                    /// </summary>
                    [NameInMap("configUpdateTime")]
                    [Validation(Required=false)]
                    public string ConfigUpdateTime { get; set; }

                    /// <summary>
                    /// The progress.
                    /// </summary>
                    [NameInMap("donePercent")]
                    [Validation(Required=false)]
                    public int? DonePercent { get; set; }

                    /// <summary>
                    /// The number of nodes that are configured.
                    /// </summary>
                    [NameInMap("doneSize")]
                    [Validation(Required=false)]
                    public int? DoneSize { get; set; }

                    /// <summary>
                    /// The name of the cluster.
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The total number of nodes that you specify when you create the cluster.
                    /// </summary>
                    [NameInMap("totalSize")]
                    [Validation(Required=false)]
                    public int? TotalSize { get; set; }

                }

                /// <summary>
                /// The service status.
                /// </summary>
                [NameInMap("serviceStatus")]
                [Validation(Required=false)]
                public GetClusterRunTimeInfoResponseBodyResultQueryNodeServiceStatus ServiceStatus { get; set; }
                public class GetClusterRunTimeInfoResponseBodyResultQueryNodeServiceStatus : TeaModel {
                    /// <summary>
                    /// The progress.
                    /// </summary>
                    [NameInMap("donePercent")]
                    [Validation(Required=false)]
                    public int? DonePercent { get; set; }

                    /// <summary>
                    /// The number of nodes that are configured.
                    /// </summary>
                    [NameInMap("doneSize")]
                    [Validation(Required=false)]
                    public int? DoneSize { get; set; }

                    /// <summary>
                    /// The name of the cluster.
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The total number of nodes that you specify when you create the cluster.
                    /// </summary>
                    [NameInMap("totalSize")]
                    [Validation(Required=false)]
                    public int? TotalSize { get; set; }

                }

            }

        }

    }

}
