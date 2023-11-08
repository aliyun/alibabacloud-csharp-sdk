// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeServiceMeshClustersResponseBody : TeaModel {
        /// <summary>
        /// The queried clusters.
        /// </summary>
        [NameInMap("Clusters")]
        [Validation(Required=false)]
        public List<DescribeServiceMeshClustersResponseBodyClusters> Clusters { get; set; }
        public class DescribeServiceMeshClustersResponseBodyClusters : TeaModel {
            /// <summary>
            /// The domain name of the cluster.
            /// </summary>
            [NameInMap("ClusterDomain")]
            [Validation(Required=false)]
            public string ClusterDomain { get; set; }

            /// <summary>
            /// The cluster ID.
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// The cluster type.
            /// </summary>
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            /// <summary>
            /// The time when the cluster was created.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The error message about the cluster.
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// Indicates that the cluster is available or the reason why the cluster cannot be added to the ASM instance. Valid values:
            /// 
            /// *   `0`: The cluster can be added to the ASM instance.
            /// *   `1`: The cluster cannot be added to the ASM instance because you do not have administrator permissions on the cluster.
            /// *   `2`: The cluster cannot be added to the ASM instance because the cluster and the ASM instance reside in different VPCs between which no private connections are built.
            /// *   `3`: The CIDR block of the cluster conflicts with that of the ASM instance.
            /// *   `4`: The cluster has a namespace that is named istio-system.
            /// </summary>
            [NameInMap("ForbiddenFlag")]
            [Validation(Required=false)]
            public long? ForbiddenFlag { get; set; }

            /// <summary>
            /// The reason why the cluster on the data plane cannot be added to the ASM instance. The value is a JSON string in the following format:
            /// 
            ///     [
            ///       {
            ///         "cluster": "cdd55bd6e054b4c6ca18ec02614******",
            ///         "object": "Pod",
            ///         "cidr": "172.16.0.0/24"
            ///       },
            ///       {
            ///         "cluster": "cfa37fdf7cb1641e1976f8293ac******",
            ///         "object": "Pod",
            ///         "cidr": "172.16.0.0/24"
            ///       }
            ///     ]
            /// 
            /// In the preceding example, the CIDR block `172.16.0.0/24` of the pod in the `cdd55bd6e054b4c6ca18ec02614******` cluster conflicts with the CIDR block `172.16.0.0/24` of the pod in the `cfa37fdf7cb1641e1976f8293ac******` cluster.
            /// 
            /// Valid values of the `object` parameter:
            /// 
            /// *   `Pod`
            /// *   `Service`
            /// *   `VSwitch`
            /// *   `VPC`
            /// *   `VPC CIDR`
            /// </summary>
            [NameInMap("ForbiddenInfo")]
            [Validation(Required=false)]
            public string ForbiddenInfo { get; set; }

            /// <summary>
            /// The name of the cluster.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The ID of the region in which the cluster resides.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The ASM instance ID.
            /// </summary>
            [NameInMap("ServiceMeshId")]
            [Validation(Required=false)]
            public string ServiceMeshId { get; set; }

            /// <summary>
            /// The ID of the security group.
            /// </summary>
            [NameInMap("SgId")]
            [Validation(Required=false)]
            public string SgId { get; set; }

            /// <summary>
            /// The state of the cluster. Valid values:
            /// 
            /// *   `running`: The cluster is running.
            /// *   `starting`: The cluster is starting.
            /// *   `stopping`: The cluster is being stopped.
            /// *   `stopped`: The cluster is stopped.
            /// *   `failed`: The cluster fails to be run.
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// The time when the cluster was last modified.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// The version number of the cluster.
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// The ID of the virtual private cloud (VPC).
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        [NameInMap("NumberOfClusters")]
        [Validation(Required=false)]
        public long? NumberOfClusters { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
