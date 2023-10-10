// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListClusterResponseBody : TeaModel {
        /// <summary>
        /// The clusters.
        /// </summary>
        [NameInMap("ClusterList")]
        [Validation(Required=false)]
        public ListClusterResponseBodyClusterList ClusterList { get; set; }
        public class ListClusterResponseBodyClusterList : TeaModel {
            [NameInMap("Cluster")]
            [Validation(Required=false)]
            public List<ListClusterResponseBodyClusterListCluster> Cluster { get; set; }
            public class ListClusterResponseBodyClusterListCluster : TeaModel {
                /// <summary>
                /// The ID of the cluster in EDAS.
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
                /// *   0: regular Docker cluster
                /// *   1: Swarm cluster
                /// *   2: Elastic Compute Service (ECS) cluster
                /// *   3: self-managed Kubernetes cluster in Enterprise Distributed Application Service (EDAS)
                /// *   4: cluster in which Pandora automatically registers applications
                /// *   5: ACK cluster
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
                /// The number of used CPU cores.
                /// </summary>
                [NameInMap("CpuUsed")]
                [Validation(Required=false)]
                public int? CpuUsed { get; set; }

                /// <summary>
                /// The timestamp when the cluster was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// The ID of the cluster in Container Service for Kubernetes (ACK).
                /// </summary>
                [NameInMap("CsClusterId")]
                [Validation(Required=false)]
                public string CsClusterId { get; set; }

                /// <summary>
                /// The description of the cluster.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The provider of the cluster.
                /// </summary>
                [NameInMap("IaasProvider")]
                [Validation(Required=false)]
                public string IaasProvider { get; set; }

                /// <summary>
                /// The total size of memory. Unit: MB.
                /// </summary>
                [NameInMap("Mem")]
                [Validation(Required=false)]
                public int? Mem { get; set; }

                /// <summary>
                /// The size of used memory. Unit: MB.
                /// </summary>
                [NameInMap("MemUsed")]
                [Validation(Required=false)]
                public int? MemUsed { get; set; }

                /// <summary>
                /// The network type of the cluster. Valid values:
                /// 
                /// *   1: classic network
                /// *   2: virtual private cloud (VPC)
                /// </summary>
                [NameInMap("NetworkMode")]
                [Validation(Required=false)]
                public int? NetworkMode { get; set; }

                /// <summary>
                /// The number of instances.
                /// </summary>
                [NameInMap("NodeNum")]
                [Validation(Required=false)]
                public int? NodeNum { get; set; }

                /// <summary>
                /// The CPU overcommit ratio that is supported by a Docker cluster. Valid values:
                /// 
                /// *   1: 1:1, which means that CPU resources are not overcommitted.
                /// *   2: 1:2, which means that CPU resources are overcommitted by 1:2.
                /// *   4: 1:4, which means that CPU resources are overcommitted by 1:4.
                /// *   8: 1:8, which means that CPU resources are overcommitted by 1:8.
                /// </summary>
                [NameInMap("OversoldFactor")]
                [Validation(Required=false)]
                public int? OversoldFactor { get; set; }

                /// <summary>
                /// The ID of the region.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The ID of the resource group.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The timestamp when the cluster was last modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                /// <summary>
                /// VPC ID
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

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
