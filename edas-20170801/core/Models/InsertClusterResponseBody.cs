// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class InsertClusterResponseBody : TeaModel {
        /// <summary>
        /// The information about the cluster that was created.
        /// </summary>
        [NameInMap("Cluster")]
        [Validation(Required=false)]
        public InsertClusterResponseBodyCluster Cluster { get; set; }
        public class InsertClusterResponseBodyCluster : TeaModel {
            /// <summary>
            /// The ID of cluster.
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// The name of the cluster.
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// The type of the cluster. Valid values:
            /// 
            /// *   2: ECS cluster
            /// *   3: self-managed Kubernetes cluster in EDAS
            /// *   5: Kubernetes cluster
            /// </summary>
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public int? ClusterType { get; set; }

            /// <summary>
            /// The provider of the IaaS resources that are used in the cluster.
            /// </summary>
            [NameInMap("IaasProvider")]
            [Validation(Required=false)]
            public string IaasProvider { get; set; }

            /// <summary>
            /// The network type of the cluster. Valid values:
            /// 
            /// *   1: classic network
            /// *   2\. VPC
            /// </summary>
            [NameInMap("NetworkMode")]
            [Validation(Required=false)]
            public int? NetworkMode { get; set; }

            /// <summary>
            /// **This parameter is deprecated.** The CPU overcommit ratio supported by the Docker cluster. Valid values:
            /// 
            /// *   2: 1:2, which means that resources are overcommitted by 1:2.
            /// *   4: 1:4, which means that resources are overcommitted by 1:4.
            /// *   8: 1:8, which means that resources are overcommitted by 1:8.
            /// </summary>
            [NameInMap("OversoldFactor")]
            [Validation(Required=false)]
            public int? OversoldFactor { get; set; }

            /// <summary>
            /// The ID of the region in which the cluster resides.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The ID of the VPC.
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

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
