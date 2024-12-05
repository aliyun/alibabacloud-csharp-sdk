// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class GetClusterRunTimeInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E45380E8-994A-5402-9806-F114B3295FCF</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetClusterRunTimeInfoResponseBodyResult> Result { get; set; }
        public class GetClusterRunTimeInfoResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The cluster name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc_hz_domain_1</para>
            /// </summary>
            [NameInMap("clusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The information about the Searcher workers.</para>
            /// </summary>
            [NameInMap("dataNodes")]
            [Validation(Required=false)]
            public List<GetClusterRunTimeInfoResponseBodyResultDataNodes> DataNodes { get; set; }
            public class GetClusterRunTimeInfoResponseBodyResultDataNodes : TeaModel {
                /// <summary>
                /// <para>The configuration status.</para>
                /// </summary>
                [NameInMap("configStatusList")]
                [Validation(Required=false)]
                public List<GetClusterRunTimeInfoResponseBodyResultDataNodesConfigStatusList> ConfigStatusList { get; set; }
                public class GetClusterRunTimeInfoResponseBodyResultDataNodesConfigStatusList : TeaModel {
                    /// <summary>
                    /// <para>The time when the configuration was last updated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;&quot;</para>
                    /// </summary>
                    [NameInMap("configUpdateTime")]
                    [Validation(Required=false)]
                    public string ConfigUpdateTime { get; set; }

                    /// <summary>
                    /// <para>The configuration progress. Unit: percentage.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("donePercent")]
                    [Validation(Required=false)]
                    public int? DonePercent { get; set; }

                    /// <summary>
                    /// <para>The number of processed Searcher workers in the cluster.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("doneSize")]
                    [Validation(Required=false)]
                    public int? DoneSize { get; set; }

                    /// <summary>
                    /// <para>The cluster name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test_0704</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The total number of Searcher workers in the cluster.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("totalSize")]
                    [Validation(Required=false)]
                    public int? TotalSize { get; set; }

                }

                /// <summary>
                /// <para>The data of the Searcher worker.</para>
                /// </summary>
                [NameInMap("dataStatusList")]
                [Validation(Required=false)]
                public List<GetClusterRunTimeInfoResponseBodyResultDataNodesDataStatusList> DataStatusList { get; set; }
                public class GetClusterRunTimeInfoResponseBodyResultDataNodesDataStatusList : TeaModel {
                    /// <summary>
                    /// <para>The information about the advanced configuration.</para>
                    /// </summary>
                    [NameInMap("advanceConfigInfo")]
                    [Validation(Required=false)]
                    public GetClusterRunTimeInfoResponseBodyResultDataNodesDataStatusListAdvanceConfigInfo AdvanceConfigInfo { get; set; }
                    public class GetClusterRunTimeInfoResponseBodyResultDataNodesDataStatusListAdvanceConfigInfo : TeaModel {
                        /// <summary>
                        /// <para>The name of the index configuration.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>index_meta_name</para>
                        /// </summary>
                        [NameInMap("configMetaName")]
                        [Validation(Required=false)]
                        public string ConfigMetaName { get; set; }

                        /// <summary>
                        /// <para>The version number.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1.0</para>
                        /// </summary>
                        [NameInMap("version")]
                        [Validation(Required=false)]
                        public long? Version { get; set; }

                    }

                    /// <summary>
                    /// <para>The name of the worker that failed due to a deployment failure.</para>
                    /// </summary>
                    [NameInMap("deployFailedWorker")]
                    [Validation(Required=false)]
                    public List<string> DeployFailedWorker { get; set; }

                    /// <summary>
                    /// <para>The storage capacity. Unit: GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("docSize")]
                    [Validation(Required=false)]
                    public int? DocSize { get; set; }

                    /// <summary>
                    /// <para>The configuration progress. Unit: percentage.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("donePercent")]
                    [Validation(Required=false)]
                    public int? DonePercent { get; set; }

                    /// <summary>
                    /// <para>The number of processed QRS workers in the cluster.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("doneSize")]
                    [Validation(Required=false)]
                    public int? DoneSize { get; set; }

                    /// <summary>
                    /// <para>The error message.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0A3B1C48006A6C0905F6375F4821EB50</para>
                    /// </summary>
                    [NameInMap("errorMsg")]
                    [Validation(Required=false)]
                    public string ErrorMsg { get; set; }

                    /// <summary>
                    /// <para>The time when full data in the index was last updated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot; &quot;</para>
                    /// </summary>
                    [NameInMap("fullUpdateTime")]
                    [Validation(Required=false)]
                    public string FullUpdateTime { get; set; }

                    /// <summary>
                    /// <para>The time when the full index version was generated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123423</para>
                    /// </summary>
                    [NameInMap("fullVersion")]
                    [Validation(Required=false)]
                    public long? FullVersion { get; set; }

                    /// <summary>
                    /// <para>The time when incremental data in the index was last updated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;&quot;</para>
                    /// </summary>
                    [NameInMap("incUpdateTime")]
                    [Validation(Required=false)]
                    public string IncUpdateTime { get; set; }

                    /// <summary>
                    /// <para>The time when the incremental index version was generated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123423</para>
                    /// </summary>
                    [NameInMap("incVersion")]
                    [Validation(Required=false)]
                    public long? IncVersion { get; set; }

                    /// <summary>
                    /// <para>The information about the index configuration.</para>
                    /// </summary>
                    [NameInMap("indexConfigInfo")]
                    [Validation(Required=false)]
                    public GetClusterRunTimeInfoResponseBodyResultDataNodesDataStatusListIndexConfigInfo IndexConfigInfo { get; set; }
                    public class GetClusterRunTimeInfoResponseBodyResultDataNodesDataStatusListIndexConfigInfo : TeaModel {
                        /// <summary>
                        /// <para>The name of the index configuration.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>index_meta_name</para>
                        /// </summary>
                        [NameInMap("configMetaName")]
                        [Validation(Required=false)]
                        public string ConfigMetaName { get; set; }

                        /// <summary>
                        /// <para>The version of the index template.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1.0.0</para>
                        /// </summary>
                        [NameInMap("version")]
                        [Validation(Required=false)]
                        public long? Version { get; set; }

                    }

                    /// <summary>
                    /// <para>The index size.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("indexSize")]
                    [Validation(Required=false)]
                    public long? IndexSize { get; set; }

                    /// <summary>
                    /// <para>The name of the worker that failed due to insufficient disks.</para>
                    /// </summary>
                    [NameInMap("lackDiskWorker")]
                    [Validation(Required=false)]
                    public List<string> LackDiskWorker { get; set; }

                    /// <summary>
                    /// <para>The name of the worker that failed due to insufficient memory.</para>
                    /// </summary>
                    [NameInMap("lackMemWorker")]
                    [Validation(Required=false)]
                    public List<string> LackMemWorker { get; set; }

                    /// <summary>
                    /// <para>The name of the QRS worker.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ha-cn-c4d2rq7nt04_qrs</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The total number of QRS workers in the cluster.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("totalSize")]
                    [Validation(Required=false)]
                    public int? TotalSize { get; set; }

                }

                /// <summary>
                /// <para>The service status of the QRS worker.</para>
                /// </summary>
                [NameInMap("serviceStatus")]
                [Validation(Required=false)]
                public GetClusterRunTimeInfoResponseBodyResultDataNodesServiceStatus ServiceStatus { get; set; }
                public class GetClusterRunTimeInfoResponseBodyResultDataNodesServiceStatus : TeaModel {
                    /// <summary>
                    /// <para>The process progress of QRS workers in the cluster. Unit: percentage.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("donePercent")]
                    [Validation(Required=false)]
                    public int? DonePercent { get; set; }

                    /// <summary>
                    /// <para>The number of processed QRS workers in the cluster.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("doneSize")]
                    [Validation(Required=false)]
                    public int? DoneSize { get; set; }

                    /// <summary>
                    /// <para>The name of the QRS worker.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ha-cn-0ju2s170b03_qrs</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The total number of QRS workers in the cluster.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("totalSize")]
                    [Validation(Required=false)]
                    public int? TotalSize { get; set; }

                }

            }

            /// <summary>
            /// <para>The information about the Query Result Searcher (QRS) workers.</para>
            /// </summary>
            [NameInMap("queryNode")]
            [Validation(Required=false)]
            public GetClusterRunTimeInfoResponseBodyResultQueryNode QueryNode { get; set; }
            public class GetClusterRunTimeInfoResponseBodyResultQueryNode : TeaModel {
                /// <summary>
                /// <para>The configuration status.</para>
                /// </summary>
                [NameInMap("configStatusList")]
                [Validation(Required=false)]
                public List<GetClusterRunTimeInfoResponseBodyResultQueryNodeConfigStatusList> ConfigStatusList { get; set; }
                public class GetClusterRunTimeInfoResponseBodyResultQueryNodeConfigStatusList : TeaModel {
                    /// <summary>
                    /// <para>The time when the configuration was last updated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot; &quot;</para>
                    /// </summary>
                    [NameInMap("configUpdateTime")]
                    [Validation(Required=false)]
                    public string ConfigUpdateTime { get; set; }

                    /// <summary>
                    /// <para>The process progress of QRS workers in the cluster. Unit: percentage.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("donePercent")]
                    [Validation(Required=false)]
                    public int? DonePercent { get; set; }

                    /// <summary>
                    /// <para>The number of processed QRS workers in the cluster.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("doneSize")]
                    [Validation(Required=false)]
                    public int? DoneSize { get; set; }

                    /// <summary>
                    /// <para>The cluster name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ha-cn-zvp2qr1sk01_qrs</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The total number of QRS workers in the cluster.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>6</para>
                    /// </summary>
                    [NameInMap("totalSize")]
                    [Validation(Required=false)]
                    public int? TotalSize { get; set; }

                }

                /// <summary>
                /// <para>The service status of the QRS worker.</para>
                /// </summary>
                [NameInMap("serviceStatus")]
                [Validation(Required=false)]
                public GetClusterRunTimeInfoResponseBodyResultQueryNodeServiceStatus ServiceStatus { get; set; }
                public class GetClusterRunTimeInfoResponseBodyResultQueryNodeServiceStatus : TeaModel {
                    /// <summary>
                    /// <para>The process progress of QRS workers in the cluster. Unit: percentage.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("donePercent")]
                    [Validation(Required=false)]
                    public int? DonePercent { get; set; }

                    /// <summary>
                    /// <para>The number of processed QRS workers in the cluster.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("doneSize")]
                    [Validation(Required=false)]
                    public int? DoneSize { get; set; }

                    /// <summary>
                    /// <para>The cluster name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ha-cn-c4d2rq7nt04_qrs</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The total number of QRS workers in the cluster.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("totalSize")]
                    [Validation(Required=false)]
                    public int? TotalSize { get; set; }

                }

            }

        }

    }

}
