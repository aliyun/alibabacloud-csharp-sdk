// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ListAddonsRequest : TeaModel {
        /// <summary>
        /// The cluster ID. If you specify a cluster ID, only components used in the specified cluster are queried. Other parameters are ignored.
        /// </summary>
        [NameInMap("cluster_id")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The specifications of the cluster. If cluster_id is specified, this parameter is ignored. You must specify the region_id, cluster_type, profile, cluster_spec, and cluster_version parameters at the same time.
        /// </summary>
        [NameInMap("cluster_spec")]
        [Validation(Required=false)]
        public string ClusterSpec { get; set; }

        /// <summary>
        /// The type of the cluster. If cluster_id is specified, this parameter is ignored. You must specify the region_id, cluster_type, profile, cluster_spec, and cluster_version parameters at the same time.
        /// </summary>
        [NameInMap("cluster_type")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// The version of the cluster. If cluster_id is specified, this parameter is ignored. You must specify the region_id, cluster_type, profile, cluster_spec, and cluster_version parameters at the same time.
        /// </summary>
        [NameInMap("cluster_version")]
        [Validation(Required=false)]
        public string ClusterVersion { get; set; }

        /// <summary>
        /// The subtype of the cluster. If cluster_id is specified, this parameter is ignored. You must specify the region_id, cluster_type, profile, cluster_spec, and cluster_version parameters at the same time.
        /// </summary>
        [NameInMap("profile")]
        [Validation(Required=false)]
        public string Profile { get; set; }

        /// <summary>
        /// The region of the cluster. If cluster_id is specified, this parameter is ignored. You must specify the region_id, cluster_type, profile, cluster_spec, and cluster_version parameters at the same time.
        /// </summary>
        [NameInMap("region_id")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
