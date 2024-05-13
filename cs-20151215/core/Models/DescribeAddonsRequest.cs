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
        /// The edition of the cluster. If you set the cluster type to `ManagedKubernetes`, the following editions are supported:
        /// 
        /// *   `ack.pro.small`: ACK Pro cluster
        /// *   `ack.standard`: ACK Basic cluster
        /// 
        /// By default, this parameter is left empty. If you leave this parameter empty, clusters are not filtered by edition.
        /// </summary>
        [NameInMap("cluster_spec")]
        [Validation(Required=false)]
        public string ClusterSpec { get; set; }

        /// <summary>
        /// The type of cluster. Valid values:
        /// 
        /// *   `Kubernetes`: ACK dedicated cluster.
        /// *   `ManagedKubernetes`: ACK managed cluster. ACK managed clusters include ACK Pro clusters, ACK Basic clusters, ACK Serverless Pro clusters, ACK Serverless Basic clusters, ACK Edge Pro clusters, and ACK Edge Basic clusters.
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
