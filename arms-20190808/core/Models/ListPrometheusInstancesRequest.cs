// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListPrometheusInstancesRequest : TeaModel {
        /// <summary>
        /// The cluster type. If you do not specify this parameter, all cluster types are queried. Valid values:
        /// 
        /// *   cloud-product-prometheus: Prometheus instance for cloud services
        /// *   ManagedKubernetes: ACK managed cluster
        /// *   satellite: Prometheus instance for ARMS OpenTelemetry
        /// *   Ask: ACK Serverless cluster
        /// *   remote-write-prometheus: general-purpose Prometheus instance
        /// *   cloud-monitor-cmee: Hybrid Cloud Monitoring
        /// *   ExternalKubernetes: external Kubernetes cluster registered in ACK
        /// *   vpc-prometheus: Prometheus instance for ECS
        /// *   cloud-monitor-direct: cloud service self-monitoring
        /// *   Edge Kubernetes: ACK Edge cluster
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// Specifies whether to obtain global aggregation instances. Valid values:
        /// 
        /// *   true
        /// *   false
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ShowGlobalView")]
        [Validation(Required=false)]
        public bool? ShowGlobalView { get; set; }

    }

}
