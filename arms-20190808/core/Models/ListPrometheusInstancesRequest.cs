// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListPrometheusInstancesRequest : TeaModel {
        /// <summary>
        /// Optional instance types (if left blank, all types of instances will be queried):
        /// - cloud-product-prometheus 
        /// - ManagedKubernetes
        /// - satellite
        /// - Ask
        /// - remote-write-prometheus
        /// - cloud-monitor-cmee
        /// - ExternalKubernetes
        /// - vpc-prometheus
        /// - cloud-monitor-direct
        /// - Edge Kubernetes
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// Specifies whether to query global aggregation instances. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("ShowGlobalView")]
        [Validation(Required=false)]
        public bool? ShowGlobalView { get; set; }

    }

}
