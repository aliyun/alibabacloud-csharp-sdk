// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class GetClusterRunTimeInfoResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The result.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetClusterRunTimeInfoResponseBodyResult> Result { get; set; }
        public class GetClusterRunTimeInfoResponseBodyResult : TeaModel {
            /// <summary>
            /// The cluster name.
            /// </summary>
            [NameInMap("clusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// The information about the Searcher workers.
            /// </summary>
            [NameInMap("dataNodes")]
            [Validation(Required=false)]
            public List<GetClusterRunTimeInfoResponseBodyResultDataNodes> DataNodes { get; set; }
            public class GetClusterRunTimeInfoResponseBodyResultDataNodes : TeaModel {
                /// <summary>
                /// The configuration status.
                /// </summary>
                [NameInMap("configStatusList")]
                [Validation(Required=false)]
                public List<GetClusterRunTimeInfoResponseBodyResultDataNodesConfigStatusList> ConfigStatusList { get; set; }
                public class GetClusterRunTimeInfoResponseBodyResultDataNodesConfigStatusList : TeaModel {
                    /// <summary>
                    /// The time when the configuration was last updated.
                    /// </summary>
                    [NameInMap("configUpdateTime")]
                    [Validation(Required=false)]
                    public string ConfigUpdateTime { get; set; }

                    /// <summary>
                    /// The configuration progress. Unit: percentage.
                    /// </summary>
                    [NameInMap("donePercent")]
                    [Validation(Required=false)]
                    public int? DonePercent { get; set; }

                    /// <summary>
                    /// The number of processed Searcher workers in the cluster.
                    /// </summary>
                    [NameInMap("doneSize")]
                    [Validation(Required=false)]
                    public int? DoneSize { get; set; }

                    /// <summary>
                    /// The cluster name.
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The total number of Searcher workers in the cluster.
                    /// </summary>
                    [NameInMap("totalSize")]
                    [Validation(Required=false)]
                    public int? TotalSize { get; set; }

                }

                /// <summary>
                /// The data of the Searcher worker.
                /// </summary>
                [NameInMap("dataStatusList")]
                [Validation(Required=false)]
                public List<GetClusterRunTimeInfoResponseBodyResultDataNodesDataStatusList> DataStatusList { get; set; }
                public class GetClusterRunTimeInfoResponseBodyResultDataNodesDataStatusList : TeaModel {
                    /// <summary>
                    /// The information about the advanced configuration.
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
                    /// The name of the worker that failed due to a deployment failure.
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
                    /// The configuration progress. Unit: percentage.
                    /// </summary>
                    [NameInMap("donePercent")]
                    [Validation(Required=false)]
                    public int? DonePercent { get; set; }

                    /// <summary>
                    /// The number of processed QRS workers in the cluster.
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
                    /// The time when full data in the index was last updated.
                    /// </summary>
                    [NameInMap("fullUpdateTime")]
                    [Validation(Required=false)]
                    public string FullUpdateTime { get; set; }

                    /// <summary>
                    /// The time when the full index version was generated.
                    /// </summary>
                    [NameInMap("fullVersion")]
                    [Validation(Required=false)]
                    public long? FullVersion { get; set; }

                    /// <summary>
                    /// The time when incremental data in the index was last updated.
                    /// </summary>
                    [NameInMap("incUpdateTime")]
                    [Validation(Required=false)]
                    public string IncUpdateTime { get; set; }

                    /// <summary>
                    /// The time when the incremental index version was generated.
                    /// </summary>
                    [NameInMap("incVersion")]
                    [Validation(Required=false)]
                    public long? IncVersion { get; set; }

                    /// <summary>
                    /// The information about the index configuration.
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
                    /// The index size.
                    /// </summary>
                    [NameInMap("indexSize")]
                    [Validation(Required=false)]
                    public long? IndexSize { get; set; }

                    /// <summary>
                    /// The name of the worker that failed due to insufficient disks.
                    /// </summary>
                    [NameInMap("lackDiskWorker")]
                    [Validation(Required=false)]
                    public List<string> LackDiskWorker { get; set; }

                    /// <summary>
                    /// The name of the worker that failed due to insufficient memory.
                    /// </summary>
                    [NameInMap("lackMemWorker")]
                    [Validation(Required=false)]
                    public List<string> LackMemWorker { get; set; }

                    /// <summary>
                    /// The name of the QRS worker.
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The total number of QRS workers in the cluster.
                    /// </summary>
                    [NameInMap("totalSize")]
                    [Validation(Required=false)]
                    public int? TotalSize { get; set; }

                }

                /// <summary>
                /// The service status of the QRS worker.
                /// </summary>
                [NameInMap("serviceStatus")]
                [Validation(Required=false)]
                public GetClusterRunTimeInfoResponseBodyResultDataNodesServiceStatus ServiceStatus { get; set; }
                public class GetClusterRunTimeInfoResponseBodyResultDataNodesServiceStatus : TeaModel {
                    /// <summary>
                    /// The process progress of QRS workers in the cluster. Unit: percentage.
                    /// </summary>
                    [NameInMap("donePercent")]
                    [Validation(Required=false)]
                    public int? DonePercent { get; set; }

                    /// <summary>
                    /// The number of processed QRS workers in the cluster.
                    /// </summary>
                    [NameInMap("doneSize")]
                    [Validation(Required=false)]
                    public int? DoneSize { get; set; }

                    /// <summary>
                    /// The name of the QRS worker.
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The total number of QRS workers in the cluster.
                    /// </summary>
                    [NameInMap("totalSize")]
                    [Validation(Required=false)]
                    public int? TotalSize { get; set; }

                }

            }

            /// <summary>
            /// The information about the Query Result Searcher (QRS) workers.
            /// </summary>
            [NameInMap("queryNode")]
            [Validation(Required=false)]
            public GetClusterRunTimeInfoResponseBodyResultQueryNode QueryNode { get; set; }
            public class GetClusterRunTimeInfoResponseBodyResultQueryNode : TeaModel {
                /// <summary>
                /// The configuration status.
                /// </summary>
                [NameInMap("configStatusList")]
                [Validation(Required=false)]
                public List<GetClusterRunTimeInfoResponseBodyResultQueryNodeConfigStatusList> ConfigStatusList { get; set; }
                public class GetClusterRunTimeInfoResponseBodyResultQueryNodeConfigStatusList : TeaModel {
                    /// <summary>
                    /// The time when the configuration was last updated.
                    /// </summary>
                    [NameInMap("configUpdateTime")]
                    [Validation(Required=false)]
                    public string ConfigUpdateTime { get; set; }

                    /// <summary>
                    /// The process progress of QRS workers in the cluster. Unit: percentage.
                    /// </summary>
                    [NameInMap("donePercent")]
                    [Validation(Required=false)]
                    public int? DonePercent { get; set; }

                    /// <summary>
                    /// The number of processed QRS workers in the cluster.
                    /// </summary>
                    [NameInMap("doneSize")]
                    [Validation(Required=false)]
                    public int? DoneSize { get; set; }

                    /// <summary>
                    /// The cluster name.
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The total number of QRS workers in the cluster.
                    /// </summary>
                    [NameInMap("totalSize")]
                    [Validation(Required=false)]
                    public int? TotalSize { get; set; }

                }

                /// <summary>
                /// The service status of the QRS worker.
                /// </summary>
                [NameInMap("serviceStatus")]
                [Validation(Required=false)]
                public GetClusterRunTimeInfoResponseBodyResultQueryNodeServiceStatus ServiceStatus { get; set; }
                public class GetClusterRunTimeInfoResponseBodyResultQueryNodeServiceStatus : TeaModel {
                    /// <summary>
                    /// The process progress of QRS workers in the cluster. Unit: percentage.
                    /// </summary>
                    [NameInMap("donePercent")]
                    [Validation(Required=false)]
                    public int? DonePercent { get; set; }

                    /// <summary>
                    /// The number of processed QRS workers in the cluster.
                    /// </summary>
                    [NameInMap("doneSize")]
                    [Validation(Required=false)]
                    public int? DoneSize { get; set; }

                    /// <summary>
                    /// The cluster name.
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The total number of QRS workers in the cluster.
                    /// </summary>
                    [NameInMap("totalSize")]
                    [Validation(Required=false)]
                    public int? TotalSize { get; set; }

                }

            }

        }

    }

}
