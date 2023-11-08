// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class UpdateWaypointRequest : TeaModel {
        /// <summary>
        /// The ID of the cluster on the data plane.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// Specifies whether to enable Horizontal Pod Autoscaling (HPA).
        /// </summary>
        [NameInMap("HPAEnabled")]
        [Validation(Required=false)]
        public bool? HPAEnabled { get; set; }

        /// <summary>
        /// The maximum number of waypoint proxy pods when HPA is enabled.
        /// </summary>
        [NameInMap("HPAMaxReplicas")]
        [Validation(Required=false)]
        public int? HPAMaxReplicas { get; set; }

        /// <summary>
        /// The minimum number of waypoint proxy pods when HPA is enabled.
        /// </summary>
        [NameInMap("HPAMinReplicas")]
        [Validation(Required=false)]
        public int? HPAMinReplicas { get; set; }

        /// <summary>
        /// The expected CPU utilization when HPA is enabled.
        /// </summary>
        [NameInMap("HPATargetCPU")]
        [Validation(Required=false)]
        public int? HPATargetCPU { get; set; }

        /// <summary>
        /// The expected memory usage when HPA is enabled.
        /// </summary>
        [NameInMap("HPATargetMemory")]
        [Validation(Required=false)]
        public int? HPATargetMemory { get; set; }

        /// <summary>
        /// The maximum number of CPU cores that are available to the waypoint proxy pods.
        /// </summary>
        [NameInMap("LimitCPU")]
        [Validation(Required=false)]
        public string LimitCPU { get; set; }

        /// <summary>
        /// The maximum size of the memory that is available to the waypoint proxy pods.
        /// </summary>
        [NameInMap("LimitMemory")]
        [Validation(Required=false)]
        public string LimitMemory { get; set; }

        /// <summary>
        /// Waypoint名称。
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The namespace.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// Specifies whether to deploy waypoint proxy pods based on Elastic Container Instance (ECI).
        /// </summary>
        [NameInMap("PreferECI")]
        [Validation(Required=false)]
        public bool? PreferECI { get; set; }

        /// <summary>
        /// The number of waypoint proxy pods.
        /// </summary>
        [NameInMap("Replicas")]
        [Validation(Required=false)]
        public int? Replicas { get; set; }

        /// <summary>
        /// The number of CPU cores requested by the waypoint proxy pods.
        /// </summary>
        [NameInMap("RequestCPU")]
        [Validation(Required=false)]
        public string RequestCPU { get; set; }

        /// <summary>
        /// The size of the memory requested by the waypoint proxy pods.
        /// </summary>
        [NameInMap("RequestMemory")]
        [Validation(Required=false)]
        public string RequestMemory { get; set; }

        /// <summary>
        /// The Service Mesh (ASM) instance ID.
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

    }

}
