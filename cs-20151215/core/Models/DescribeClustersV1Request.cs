// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClustersV1Request : TeaModel {
        /// <summary>
        /// The cluster ID.
        /// </summary>
        [NameInMap("cluster_id")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The cluster type, which is available only when the cluster type is set to `ManagedKubernetes`. Valid values:
        /// 
        /// *   `ack.pro.small`: ACK Pro cluster
        /// *   `ack.standard`: ACK Basic cluster
        /// 
        /// By default, this parameter is left empty, which means that ACK clusters are not filtered by this parameter.
        /// </summary>
        [NameInMap("cluster_spec")]
        [Validation(Required=false)]
        public string ClusterSpec { get; set; }

        /// <summary>
        /// The cluster type. Valid values:
        /// 
        /// *   `Kubernetes`: ACK dedicated cluster.
        /// *   `ManagedKubernetes`: ACK managed cluster. ACK managed clusters include ACK Pro clusters, ACK Basic clusters, ACK Serverless Pro clusters, ACK Serverless Basic clusters, ACK Edge Pro clusters, and ACK Edge Basic clusters.
        /// *   `ExternalKubernetes`: registered cluster.
        /// </summary>
        [NameInMap("cluster_type")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// The cluster name.
        /// 
        /// The name must be 1 to 63 characters in length, and can contain digits, letters, and hyphens (-). The name cannot start with a hyphen (-).
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("page_number")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("page_size")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The identifier of the cluster. Valid values when the cluster_type parameter is set to `ManagedKubernetes`:
        /// 
        /// *   `Default`: ACK managed cluster
        /// *   `Serverless`: ACK Serverless cluster
        /// *   `Edge`: ACK Edge cluster
        /// 
        /// Valid values when the cluster_type parameter is set to `Ask`:
        /// 
        /// `ask.v2`: ACK Serverless cluster
        /// 
        /// By default, this parameter is left empty. If you leave this parameter empty, ACK clusters are not filtered by identifier.
        /// </summary>
        [NameInMap("profile")]
        [Validation(Required=false)]
        public string Profile { get; set; }

        /// <summary>
        /// The region ID of the clusters. You can use this parameter to query all clusters in the specified region.
        /// </summary>
        [NameInMap("region_id")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
