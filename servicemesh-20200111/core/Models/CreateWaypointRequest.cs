// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class CreateWaypointRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster on the data plane.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cb8963379255149cb98c8686f274x****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Horizontal Pod Autoscaling (HPA).</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("HPAEnabled")]
        [Validation(Required=false)]
        public bool? HPAEnabled { get; set; }

        /// <summary>
        /// <para>The maximum number of waypoint proxy pods when HPA is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("HPAMaxReplicas")]
        [Validation(Required=false)]
        public int? HPAMaxReplicas { get; set; }

        /// <summary>
        /// <para>The minimum number of waypoint proxy pods when HPA is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("HPAMinReplicas")]
        [Validation(Required=false)]
        public int? HPAMinReplicas { get; set; }

        /// <summary>
        /// <para>The expected CPU utilization when HPA is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>93</para>
        /// </summary>
        [NameInMap("HPATargetCPU")]
        [Validation(Required=false)]
        public int? HPATargetCPU { get; set; }

        /// <summary>
        /// <para>The expected memory usage when HPA is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>91</para>
        /// </summary>
        [NameInMap("HPATargetMemory")]
        [Validation(Required=false)]
        public int? HPATargetMemory { get; set; }

        /// <summary>
        /// <para>The maximum number of CPU cores that are available to the waypoint proxy pods.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000m</para>
        /// </summary>
        [NameInMap("LimitCPU")]
        [Validation(Required=false)]
        public string LimitCPU { get; set; }

        /// <summary>
        /// <para>The maximum size of the memory that is available to the waypoint proxy pods.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024Mi</para>
        /// </summary>
        [NameInMap("LimitMemory")]
        [Validation(Required=false)]
        public string LimitMemory { get; set; }

        /// <summary>
        /// <para>The namespace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>Specifies whether to deploy waypoint proxy pods based on Elastic Container Instance (ECI).</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PreferECI")]
        [Validation(Required=false)]
        public bool? PreferECI { get; set; }

        /// <summary>
        /// <para>The number of waypoint proxy pods.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Replicas")]
        [Validation(Required=false)]
        public int? Replicas { get; set; }

        /// <summary>
        /// <para>The number of CPU cores requested by the waypoint proxy pods.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100m</para>
        /// </summary>
        [NameInMap("RequestCPU")]
        [Validation(Required=false)]
        public string RequestCPU { get; set; }

        /// <summary>
        /// <para>The size of the memory requested by the waypoint proxy pods.</para>
        /// 
        /// <b>Example:</b>
        /// <para>128Mi</para>
        /// </summary>
        [NameInMap("RequestMemory")]
        [Validation(Required=false)]
        public string RequestMemory { get; set; }

        /// <summary>
        /// <para>The service account on which the waypoint proxy takes effect. If you do not specify this parameter, the waypoint proxy takes effect for the entire namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bookinfo-productpage</para>
        /// </summary>
        [NameInMap("ServiceAccount")]
        [Validation(Required=false)]
        public string ServiceAccount { get; set; }

        /// <summary>
        /// <para>The Service Mesh (ASM) instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ce134b0727aa2492db69f6c3880e****</para>
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

    }

}
