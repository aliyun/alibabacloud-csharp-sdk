// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adcp20220101.Models
{
    public class DescribeManagedClustersResponseBody : TeaModel {
        /// <summary>
        /// The status of the associated clusters. Valid values: - initial: The associated clusters are being initialized. - failed: The associated clustersfailed to be created. - running: The associated clusters are running. - inactive: The associated clusters are inactive. - deleting: The associated clusters are being deleted. - deleted: The associated clusters are deleted.
        /// </summary>
        [NameInMap("Clusters")]
        [Validation(Required=false)]
        public List<DescribeManagedClustersResponseBodyClusters> Clusters { get; set; }
        public class DescribeManagedClustersResponseBodyClusters : TeaModel {
            /// <summary>
            /// The name of the master instance.
            /// </summary>
            [NameInMap("Cluster")]
            [Validation(Required=false)]
            public DescribeManagedClustersResponseBodyClustersCluster Cluster { get; set; }
            public class DescribeManagedClustersResponseBodyClustersCluster : TeaModel {
                /// <summary>
                /// Information about the master instance.
                /// </summary>
                [NameInMap("ClusterID")]
                [Validation(Required=false)]
                public string ClusterID { get; set; }

                /// <summary>
                /// The ID of the master instance.
                /// </summary>
                [NameInMap("ClusterSpec")]
                [Validation(Required=false)]
                public string ClusterSpec { get; set; }

                /// <summary>
                /// The time when the master instance was created.
                /// </summary>
                [NameInMap("ClusterType")]
                [Validation(Required=false)]
                public string ClusterType { get; set; }

                /// <summary>
                /// The ID of the master instance.
                /// </summary>
                [NameInMap("Created")]
                [Validation(Required=false)]
                public string Created { get; set; }

                /// <summary>
                /// The name of the master instance.
                /// </summary>
                [NameInMap("CurrentVersion")]
                [Validation(Required=false)]
                public string CurrentVersion { get; set; }

                /// <summary>
                /// The specification of the master instance. Valid values: - ack.pro.small: ACK Pro.
                /// </summary>
                [NameInMap("InitVersion")]
                [Validation(Required=false)]
                public string InitVersion { get; set; }

                /// <summary>
                /// The status information.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The ID of the request.
                /// </summary>
                [NameInMap("Profile")]
                [Validation(Required=false)]
                public string Profile { get; set; }

                /// <summary>
                /// The ID of the master instance.
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// The name of the master instance.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The current Kubernetes version of the master instance.
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// The ID of the vSwitch.
                /// </summary>
                [NameInMap("Updated")]
                [Validation(Required=false)]
                public string Updated { get; set; }

                /// <summary>
                /// The original Kubernetes version of the master instance.
                /// </summary>
                [NameInMap("VSwitchID")]
                [Validation(Required=false)]
                public string VSwitchID { get; set; }

                /// <summary>
                /// The status of the association between the clusters and the master instance. Valid values: - Installing: The clusters are being associated with the master instance. - Successed: The clusters are associated with the master instance. - Failed: The clusters failed to be associated with the master instance. - Deleting: The clusters are being disassociated from the master instance. - Deleted: The clusters are disassociated from the master instance.
                /// </summary>
                [NameInMap("VpcID")]
                [Validation(Required=false)]
                public string VpcID { get; set; }

            }

            /// <summary>
            /// Zhishi
            /// </summary>
            [NameInMap("MeshStatus")]
            [Validation(Required=false)]
            public DescribeManagedClustersResponseBodyClustersMeshStatus MeshStatus { get; set; }
            public class DescribeManagedClustersResponseBodyClustersMeshStatus : TeaModel {
                [NameInMap("InMesh")]
                [Validation(Required=false)]
                public bool? InMesh { get; set; }

            }

            /// <summary>
            /// Example 1
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public DescribeManagedClustersResponseBodyClustersStatus Status { get; set; }
            public class DescribeManagedClustersResponseBodyClustersStatus : TeaModel {
                /// <summary>
                /// Query the clusters that are associated with a master instance.
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// You can call the DescribeManagedClusters operation to query the clusters that are associated with a master instance.
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

            }

        }

        /// <summary>
        /// VPC ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
