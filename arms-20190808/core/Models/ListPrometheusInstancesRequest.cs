// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListPrometheusInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The cluster type. If you do not specify this parameter, all cluster types are queried. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>cloud-product-prometheus: Prometheus instance for cloud services</para>
        /// </description></item>
        /// <item><description><para>ManagedKubernetes: ACK managed cluster</para>
        /// </description></item>
        /// <item><description><para>satellite: Prometheus instance for ARMS OpenTelemetry</para>
        /// </description></item>
        /// <item><description><para>Ask: ACK Serverless cluster</para>
        /// </description></item>
        /// <item><description><para>remote-write-prometheus: general-purpose Prometheus instance</para>
        /// </description></item>
        /// <item><description><para>cloud-monitor-cmee: Hybrid Cloud Monitoring</para>
        /// </description></item>
        /// <item><description><para>ExternalKubernetes: external Kubernetes cluster registered in ACK</para>
        /// </description></item>
        /// <item><description><para>vpc-prometheus: Prometheus instance for ECS</para>
        /// </description></item>
        /// <item><description><para>cloud-monitor-direct: cloud service self-monitoring</para>
        /// </description></item>
        /// <item><description><para>Edge Kubernetes: ACK Edge cluster</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cloud-product-prometheus</para>
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to obtain global aggregation instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true</para>
        /// </description></item>
        /// <item><description><para>false</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ShowGlobalView")]
        [Validation(Required=false)]
        public bool? ShowGlobalView { get; set; }

    }

}
