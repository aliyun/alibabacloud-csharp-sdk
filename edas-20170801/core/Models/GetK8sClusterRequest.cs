// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetK8sClusterRequest : TeaModel {
        /// <summary>
        /// The type of the Kubernetes cluster. Valid values:
        /// 
        /// *   5: ACK cluster
        /// *   7: self-managed Kubernetes cluster
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public int? ClusterType { get; set; }

        /// <summary>
        /// The number of the page to return. Default value: 1.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: 1000.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RegionTag")]
        [Validation(Required=false)]
        public string RegionTag { get; set; }

        /// <summary>
        /// The subtype of the cluster. Valid values:
        /// 
        /// *   Ask: Serverless Kubernetes cluster
        /// *   ManagedKubernetes: ACK cluster
        /// </summary>
        [NameInMap("SubClusterType")]
        [Validation(Required=false)]
        public string SubClusterType { get; set; }

    }

}
