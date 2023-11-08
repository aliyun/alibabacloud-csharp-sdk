// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class ListWaypointsResponseBody : TeaModel {
        [NameInMap("Continue")]
        [Validation(Required=false)]
        public string Continue { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The list of waypoint proxy configurations.
        /// </summary>
        [NameInMap("Waypoints")]
        [Validation(Required=false)]
        public List<ListWaypointsResponseBodyWaypoints> Waypoints { get; set; }
        public class ListWaypointsResponseBodyWaypoints : TeaModel {
            /// <summary>
            /// Indicates whether Horizontal Pod Autoscaling (HPA) is enabled.
            /// </summary>
            [NameInMap("HPAEnabled")]
            [Validation(Required=false)]
            public string HPAEnabled { get; set; }

            /// <summary>
            /// The maximum number of waypoint proxy pods when HPA is enabled.
            /// </summary>
            [NameInMap("HPAMaxReplicas")]
            [Validation(Required=false)]
            public string HPAMaxReplicas { get; set; }

            /// <summary>
            /// The minimum number of waypoint proxy pods when HPA is enabled.
            /// </summary>
            [NameInMap("HPAMinReplicas")]
            [Validation(Required=false)]
            public string HPAMinReplicas { get; set; }

            /// <summary>
            /// The expected CPU utilization when HPA is enabled.
            /// </summary>
            [NameInMap("HPATargetCPU")]
            [Validation(Required=false)]
            public string HPATargetCPU { get; set; }

            /// <summary>
            /// The expected memory usage when HPA is enabled.
            /// </summary>
            [NameInMap("HPATargetMemory")]
            [Validation(Required=false)]
            public string HPATargetMemory { get; set; }

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
            /// The name of the gateway resource corresponding to the waypoint proxy. If the waypoint proxy takes effect on a service account, the name is the service account name. If the waypoint proxy takes effect for the entire namespace, the name is "namespace".
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
            /// Indicates whether waypoint proxy pods are deployed based on Elastic Container Instance (ECI).
            /// </summary>
            [NameInMap("PreferECI")]
            [Validation(Required=false)]
            public string PreferECI { get; set; }

            /// <summary>
            /// The number of waypoint proxy pods.
            /// </summary>
            [NameInMap("Replicas")]
            [Validation(Required=false)]
            public string Replicas { get; set; }

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
            /// The service account on which the waypoint proxy takes effect. If this parameter is not specified, the waypoint proxy takes effect for the entire namespace.
            /// </summary>
            [NameInMap("ServiceAccount")]
            [Validation(Required=false)]
            public string ServiceAccount { get; set; }

        }

    }

}
