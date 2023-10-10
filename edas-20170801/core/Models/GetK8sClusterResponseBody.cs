// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetK8sClusterResponseBody : TeaModel {
        /// <summary>
        /// The cluster data that is returned by page.
        /// </summary>
        [NameInMap("ClusterPage")]
        [Validation(Required=false)]
        public GetK8sClusterResponseBodyClusterPage ClusterPage { get; set; }
        public class GetK8sClusterResponseBodyClusterPage : TeaModel {
            /// <summary>
            /// The list of clusters.
            /// </summary>
            [NameInMap("ClusterList")]
            [Validation(Required=false)]
            public GetK8sClusterResponseBodyClusterPageClusterList ClusterList { get; set; }
            public class GetK8sClusterResponseBodyClusterPageClusterList : TeaModel {
                [NameInMap("Cluster")]
                [Validation(Required=false)]
                public List<GetK8sClusterResponseBodyClusterPageClusterListCluster> Cluster { get; set; }
                public class GetK8sClusterResponseBodyClusterPageClusterListCluster : TeaModel {
                    /// <summary>
                    /// The ID of the cluster.
                    /// </summary>
                    [NameInMap("ClusterId")]
                    [Validation(Required=false)]
                    public string ClusterId { get; set; }

                    /// <summary>
                    /// The import state of the cluster. Valid values:
                    /// 
                    /// *   0: The cluster is not imported.
                    /// *   1: The cluster is imported.
                    /// *   2: The cluster fails to be imported.
                    /// *   3: The cluster is being imported.
                    /// *   4: The cluster is deleted.
                    /// </summary>
                    [NameInMap("ClusterImportStatus")]
                    [Validation(Required=false)]
                    public int? ClusterImportStatus { get; set; }

                    /// <summary>
                    /// The name of the cluster.
                    /// </summary>
                    [NameInMap("ClusterName")]
                    [Validation(Required=false)]
                    public string ClusterName { get; set; }

                    /// <summary>
                    /// The status of the cluster. Valid values:
                    /// 
                    /// *   1: The cluster runs as expected.
                    /// *   2: The cluster does not run as expected.
                    /// *   3: The cluster is offline.
                    /// </summary>
                    [NameInMap("ClusterStatus")]
                    [Validation(Required=false)]
                    public int? ClusterStatus { get; set; }

                    /// <summary>
                    /// The type of the cluster. Valid values:
                    /// 
                    /// *   2: Elastic Compute Service (ECS) cluster
                    /// *   5: ACK cluster or Serverless Kubernetes cluster
                    /// </summary>
                    [NameInMap("ClusterType")]
                    [Validation(Required=false)]
                    public int? ClusterType { get; set; }

                    /// <summary>
                    /// The total number of CPU cores.
                    /// </summary>
                    [NameInMap("Cpu")]
                    [Validation(Required=false)]
                    public int? Cpu { get; set; }

                    /// <summary>
                    /// The ID of the ACK cluster.
                    /// </summary>
                    [NameInMap("CsClusterId")]
                    [Validation(Required=false)]
                    public string CsClusterId { get; set; }

                    /// <summary>
                    /// The state of the ACK cluster. Valid values:
                    /// 
                    /// *   initial: The cluster is being initialized.
                    /// *   failed: The cluster fails to be created.
                    /// *   running: The cluster is running.
                    /// *   updating: The cluster is being updated.
                    /// *   scaling: The cluster is being scaled out.
                    /// *   removing: Nodes are being removed from the cluster.
                    /// *   upgrading: The cluster is being upgraded.
                    /// *   deleting: The cluster is being deleted.
                    /// *   delete_failed: The cluster fails to be deleted.
                    /// *   deleted: The cluster is deleted. The deleted cluster is invisible to users.
                    /// </summary>
                    [NameInMap("CsClusterStatus")]
                    [Validation(Required=false)]
                    public string CsClusterStatus { get; set; }

                    /// <summary>
                    /// The description of the cluster.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The total size of memory. Unit: MB.
                    /// </summary>
                    [NameInMap("Mem")]
                    [Validation(Required=false)]
                    public int? Mem { get; set; }

                    /// <summary>
                    /// The network type of the cluster. Valid values:
                    /// 
                    /// *   1: classic network
                    /// *   2: VPC
                    /// </summary>
                    [NameInMap("NetworkMode")]
                    [Validation(Required=false)]
                    public int? NetworkMode { get; set; }

                    /// <summary>
                    /// The number of nodes.
                    /// </summary>
                    [NameInMap("NodeNum")]
                    [Validation(Required=false)]
                    public int? NodeNum { get; set; }

                    /// <summary>
                    /// The ID of the namespace.
                    /// </summary>
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    /// <summary>
                    /// The subtype of the cluster. Valid values:
                    /// 
                    /// *   Ask: Serverless Kubernetes cluster
                    /// *   ManagedKubernetes: ACK cluster
                    /// </summary>
                    [NameInMap("SubClusterType")]
                    [Validation(Required=false)]
                    public string SubClusterType { get; set; }

                    /// <summary>
                    /// The CIDR block of the subnet.
                    /// </summary>
                    [NameInMap("SubNetCidr")]
                    [Validation(Required=false)]
                    public string SubNetCidr { get; set; }

                    /// <summary>
                    /// The ID of the virtual private cloud (VPC).
                    /// </summary>
                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                    /// <summary>
                    /// The ID of the vSwitch.
                    /// </summary>
                    [NameInMap("VswitchId")]
                    [Validation(Required=false)]
                    public string VswitchId { get; set; }

                }

            }

            /// <summary>
            /// The number of the returned page. Default value: 1.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries returned per page. Default value: 1000.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of pages that are returned.
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The additional information that is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
