// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class ListWaypointsResponseBody : TeaModel {
        /// <summary>
        /// <para>Base64 encoded string. If it is empty, it means that all waypoints have been obtained; if it is not empty, this value should be included in the next list, and you can continue to obtain it from the offset that ends this time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJ2IjoibWV0YS5rOHMuaW8vdjEiLCJydiI6MjY4Njc5Miwic3RhcnQiOiJkZWZhdWx0L2Jvb2tpbmZvLXByb2R1Y3RwYWdlXHUwMDAwIn0</para>
        /// </summary>
        [NameInMap("Continue")]
        [Validation(Required=false)]
        public string Continue { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BD65C0AD-D3C6-48D3-8D93-38D2015C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The configurations of waypoint proxies.</para>
        /// </summary>
        [NameInMap("Waypoints")]
        [Validation(Required=false)]
        public List<ListWaypointsResponseBodyWaypoints> Waypoints { get; set; }
        public class ListWaypointsResponseBodyWaypoints : TeaModel {
            /// <summary>
            /// <para>Indicates whether Horizontal Pod Autoscaling (HPA) is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HPAEnabled")]
            [Validation(Required=false)]
            public string HPAEnabled { get; set; }

            /// <summary>
            /// <para>The maximum number of waypoint proxy pods when HPA is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("HPAMaxReplicas")]
            [Validation(Required=false)]
            public string HPAMaxReplicas { get; set; }

            /// <summary>
            /// <para>The minimum number of waypoint proxy pods when HPA is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("HPAMinReplicas")]
            [Validation(Required=false)]
            public string HPAMinReplicas { get; set; }

            /// <summary>
            /// <para>The expected CPU utilization when HPA is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>93</para>
            /// </summary>
            [NameInMap("HPATargetCPU")]
            [Validation(Required=false)]
            public string HPATargetCPU { get; set; }

            /// <summary>
            /// <para>The expected memory usage when HPA is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>91</para>
            /// </summary>
            [NameInMap("HPATargetMemory")]
            [Validation(Required=false)]
            public string HPATargetMemory { get; set; }

            /// <summary>
            /// <para>The maximum amount of CPU resources that are available to the waypoint proxy pods.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000m</para>
            /// </summary>
            [NameInMap("LimitCPU")]
            [Validation(Required=false)]
            public string LimitCPU { get; set; }

            /// <summary>
            /// <para>The maximum amount of memory resources that are available to the waypoint proxy pods.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024Mi</para>
            /// </summary>
            [NameInMap("LimitMemory")]
            [Validation(Required=false)]
            public string LimitMemory { get; set; }

            /// <summary>
            /// <para>The name of the gateway resource for the waypoint proxy. If the waypoint proxy applies to a service account, the name is the service account name. If the waypoint proxy applies to the entire namespace, the name is <c>namespace</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>namespace</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>Indicates whether waypoint proxy pods are preferentially scheduled to elastic container instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("PreferECI")]
            [Validation(Required=false)]
            public string PreferECI { get; set; }

            /// <summary>
            /// <para>The number of waypoint proxy pods.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Replicas")]
            [Validation(Required=false)]
            public string Replicas { get; set; }

            /// <summary>
            /// <para>The amount of CPU resources requested by the waypoint proxy pods.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100m</para>
            /// </summary>
            [NameInMap("RequestCPU")]
            [Validation(Required=false)]
            public string RequestCPU { get; set; }

            /// <summary>
            /// <para>The amount of memory resources requested by the waypoint proxy pods.</para>
            /// 
            /// <b>Example:</b>
            /// <para>128Mi</para>
            /// </summary>
            [NameInMap("RequestMemory")]
            [Validation(Required=false)]
            public string RequestMemory { get; set; }

            /// <summary>
            /// <para>The service account to which the waypoint proxy applies. If no value is returned for this parameter, the waypoint proxy applies to the entire namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bookinfo-productpage</para>
            /// </summary>
            [NameInMap("ServiceAccount")]
            [Validation(Required=false)]
            public string ServiceAccount { get; set; }

        }

    }

}
