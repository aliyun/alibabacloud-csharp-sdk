// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeAddonsRequest : TeaModel {
        /// <summary>
        /// The cluster type. Valid values:
        /// 
        /// *   `Default`: ACK managed cluster
        /// *   `Serverless`: ACK Serverless cluster
        /// *   `Edge`: ACK Edge cluster
        /// </summary>
        [NameInMap("cluster_profile")]
        [Validation(Required=false)]
        public string ClusterProfile { get; set; }

        /// <summary>
        /// If you set `cluster_type` to `ManagedKubernetes` and specify `profile`, you can further specify the edition of the cluster. Valid values:
        /// 
        /// *   `ack.pro.small`: creates an ACK Pro cluster.
        /// *   `ack.standard`: creates an ACK Basic cluster. If you leave the parameter empty, an ACK Basic cluster is created.
        /// </summary>
        [NameInMap("cluster_spec")]
        [Validation(Required=false)]
        public string ClusterSpec { get; set; }

        /// <summary>
        /// *   `Kubernetes`: ACK dedicated cluster.
        /// *   `ManagedKubernetes`: ACK managed cluster. ACK managed clusters include ACK Basic clusters, ACK Pro clusters, ACK Serverless Basic clusters, ACK Serverless Pro clusters, ACK Edge Basic clusters, ACK Edge Pro clusters, and ACK Lingjun Pro clusters.
        /// *   `ExternalKubernetes`: registered cluster.
        /// </summary>
        [NameInMap("cluster_type")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// The cluster version.
        /// </summary>
        [NameInMap("cluster_version")]
        [Validation(Required=false)]
        public string ClusterVersion { get; set; }

        /// <summary>
        /// The region ID of the cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

    }

}
