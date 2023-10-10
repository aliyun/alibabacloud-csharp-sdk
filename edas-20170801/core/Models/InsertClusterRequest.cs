// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class InsertClusterRequest : TeaModel {
        /// <summary>
        /// The name of the cluster.
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// The type of the cluster. Valid values:
        /// 
        /// *   2: Elastic Compute Service (ECS) cluster
        /// *   3: self-managed Kubernetes cluster in Enterprise Distributed Application Service (EDAS)
        /// *   5: Kubernetes cluster
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public int? ClusterType { get; set; }

        /// <summary>
        /// The provider of Infrastructure as a Service (IaaS) resources that are used in the cluster.
        /// 
        /// When you use Alibaba Cloud, set the value to `ALIYUN`. The value is case-sensitive.
        /// </summary>
        [NameInMap("IaasProvider")]
        [Validation(Required=false)]
        public string IaasProvider { get; set; }

        /// <summary>
        /// The ID of the custom namespace. The ID is in the `physical region ID:custom namespace identifier` format. Example: `cn-hangzhou:test`.
        /// </summary>
        [NameInMap("LogicalRegionId")]
        [Validation(Required=false)]
        public string LogicalRegionId { get; set; }

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
        /// **This parameter is deprecated.** The CPU overcommit ratio supported by a Docker cluster. Valid values:
        /// 
        /// *   2: 1:2, which means that resources are overcommitted by 1:2.
        /// *   4: 1:4, which means that resources are overcommitted by 1:4.
        /// *   8: 1:8, which means that resources are overcommitted by 1:8.
        /// </summary>
        [NameInMap("OversoldFactor")]
        [Validation(Required=false)]
        public int? OversoldFactor { get; set; }

        /// <summary>
        /// The ID of the VPC. This parameter is required if you set the NetworkMode parameter to 2.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
