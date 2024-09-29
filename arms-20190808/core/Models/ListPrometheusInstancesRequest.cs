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
        /// <item><description>cloud-product-prometheus: Prometheus instance for cloud services</description></item>
        /// <item><description>ManagedKubernetes: ACK managed cluster</description></item>
        /// <item><description>satellite: Prometheus instance for ARMS OpenTelemetry</description></item>
        /// <item><description>Ask: ACK Serverless cluster</description></item>
        /// <item><description>remote-write-prometheus: general-purpose Prometheus instance</description></item>
        /// <item><description>cloud-monitor-cmee: Hybrid Cloud Monitoring</description></item>
        /// <item><description>ExternalKubernetes: external Kubernetes cluster registered in ACK</description></item>
        /// <item><description>vpc-prometheus: Prometheus instance for ECS</description></item>
        /// <item><description>cloud-monitor-direct: cloud service self-monitoring</description></item>
        /// <item><description>Edge Kubernetes: ACK Edge cluster</description></item>
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
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
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
