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
        /// The configuration progress. Unit: percentage.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetClusterRunTimeInfoResponseBodyResult> Result { get; set; }
        public class GetClusterRunTimeInfoResponseBodyResult : TeaModel {
            /// <summary>
            /// The name of the cluster
            /// </summary>
            [NameInMap("clusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// dataNodes
            /// </summary>
            [NameInMap("dataNodes")]
            [Validation(Required=false)]
            public List<GetClusterRunTimeInfoResponseBodyResultDataNodes> DataNodes { get; set; }
            public class GetClusterRunTimeInfoResponseBodyResultDataNodes : TeaModel {
                [NameInMap("configStatusList")]
                [Validation(Required=false)]
                public List<GetClusterRunTimeInfoResponseBodyResultDataNodesConfigStatusList> ConfigStatusList { get; set; }
                public class GetClusterRunTimeInfoResponseBodyResultDataNodesConfigStatusList : TeaModel {
                    [NameInMap("configUpdateTime")]
                    [Validation(Required=false)]
                    public string ConfigUpdateTime { get; set; }

                    [NameInMap("donePercent")]
                    [Validation(Required=false)]
                    public int? DonePercent { get; set; }

                    [NameInMap("doneSize")]
                    [Validation(Required=false)]
                    public int? DoneSize { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("totalSize")]
                    [Validation(Required=false)]
                    public int? TotalSize { get; set; }

                }

                [NameInMap("dataStatusList")]
                [Validation(Required=false)]
                public List<GetClusterRunTimeInfoResponseBodyResultDataNodesDataStatusList> DataStatusList { get; set; }
                public class GetClusterRunTimeInfoResponseBodyResultDataNodesDataStatusList : TeaModel {
                    [NameInMap("advanceConfigInfo")]
                    [Validation(Required=false)]
                    public GetClusterRunTimeInfoResponseBodyResultDataNodesDataStatusListAdvanceConfigInfo AdvanceConfigInfo { get; set; }
                    public class GetClusterRunTimeInfoResponseBodyResultDataNodesDataStatusListAdvanceConfigInfo : TeaModel {
                        [NameInMap("configMetaName")]
                        [Validation(Required=false)]
                        public string ConfigMetaName { get; set; }

                        [NameInMap("version")]
                        [Validation(Required=false)]
                        public long? Version { get; set; }

                    }

                    [NameInMap("deployFailedWorker")]
                    [Validation(Required=false)]
                    public List<string> DeployFailedWorker { get; set; }

                    [NameInMap("docSize")]
                    [Validation(Required=false)]
                    public int? DocSize { get; set; }

                    [NameInMap("donePercent")]
                    [Validation(Required=false)]
                    public int? DonePercent { get; set; }

                    [NameInMap("doneSize")]
                    [Validation(Required=false)]
                    public int? DoneSize { get; set; }

                    [NameInMap("errorMsg")]
                    [Validation(Required=false)]
                    public string ErrorMsg { get; set; }

                    [NameInMap("fullUpdateTime")]
                    [Validation(Required=false)]
                    public string FullUpdateTime { get; set; }

                    [NameInMap("fullVersion")]
                    [Validation(Required=false)]
                    public long? FullVersion { get; set; }

                    [NameInMap("incUpdateTime")]
                    [Validation(Required=false)]
                    public string IncUpdateTime { get; set; }

                    [NameInMap("incVersion")]
                    [Validation(Required=false)]
                    public long? IncVersion { get; set; }

                    [NameInMap("indexConfigInfo")]
                    [Validation(Required=false)]
                    public GetClusterRunTimeInfoResponseBodyResultDataNodesDataStatusListIndexConfigInfo IndexConfigInfo { get; set; }
                    public class GetClusterRunTimeInfoResponseBodyResultDataNodesDataStatusListIndexConfigInfo : TeaModel {
                        [NameInMap("configMetaName")]
                        [Validation(Required=false)]
                        public string ConfigMetaName { get; set; }

                        [NameInMap("version")]
                        [Validation(Required=false)]
                        public long? Version { get; set; }

                    }

                    [NameInMap("indexSize")]
                    [Validation(Required=false)]
                    public long? IndexSize { get; set; }

                    [NameInMap("lackDiskWorker")]
                    [Validation(Required=false)]
                    public List<string> LackDiskWorker { get; set; }

                    [NameInMap("lackMemWorker")]
                    [Validation(Required=false)]
                    public List<string> LackMemWorker { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("totalSize")]
                    [Validation(Required=false)]
                    public int? TotalSize { get; set; }

                }

                [NameInMap("serviceStatus")]
                [Validation(Required=false)]
                public GetClusterRunTimeInfoResponseBodyResultDataNodesServiceStatus ServiceStatus { get; set; }
                public class GetClusterRunTimeInfoResponseBodyResultDataNodesServiceStatus : TeaModel {
                    [NameInMap("donePercent")]
                    [Validation(Required=false)]
                    public int? DonePercent { get; set; }

                    [NameInMap("doneSize")]
                    [Validation(Required=false)]
                    public int? DoneSize { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("totalSize")]
                    [Validation(Required=false)]
                    public int? TotalSize { get; set; }

                }

            }

            /// <summary>
            /// The specifications of the query node.
            /// </summary>
            [NameInMap("queryNode")]
            [Validation(Required=false)]
            public GetClusterRunTimeInfoResponseBodyResultQueryNode QueryNode { get; set; }
            public class GetClusterRunTimeInfoResponseBodyResultQueryNode : TeaModel {
                /// <summary>
                /// configStatusList
                /// </summary>
                [NameInMap("configStatusList")]
                [Validation(Required=false)]
                public List<GetClusterRunTimeInfoResponseBodyResultQueryNodeConfigStatusList> ConfigStatusList { get; set; }
                public class GetClusterRunTimeInfoResponseBodyResultQueryNodeConfigStatusList : TeaModel {
                    /// <summary>
                    /// configUpdateTime
                    /// </summary>
                    [NameInMap("configUpdateTime")]
                    [Validation(Required=false)]
                    public string ConfigUpdateTime { get; set; }

                    /// <summary>
                    /// donePercent
                    /// </summary>
                    [NameInMap("donePercent")]
                    [Validation(Required=false)]
                    public int? DonePercent { get; set; }

                    /// <summary>
                    /// doneSize
                    /// </summary>
                    [NameInMap("doneSize")]
                    [Validation(Required=false)]
                    public int? DoneSize { get; set; }

                    /// <summary>
                    /// name
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// totalSize
                    /// </summary>
                    [NameInMap("totalSize")]
                    [Validation(Required=false)]
                    public int? TotalSize { get; set; }

                }

                /// <summary>
                /// serviceStatus
                /// </summary>
                [NameInMap("serviceStatus")]
                [Validation(Required=false)]
                public GetClusterRunTimeInfoResponseBodyResultQueryNodeServiceStatus ServiceStatus { get; set; }
                public class GetClusterRunTimeInfoResponseBodyResultQueryNodeServiceStatus : TeaModel {
                    /// <summary>
                    /// donePercent
                    /// </summary>
                    [NameInMap("donePercent")]
                    [Validation(Required=false)]
                    public int? DonePercent { get; set; }

                    /// <summary>
                    /// doneSize
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
                    /// totalSize
                    /// </summary>
                    [NameInMap("totalSize")]
                    [Validation(Required=false)]
                    public int? TotalSize { get; set; }

                }

            }

        }

    }

}
