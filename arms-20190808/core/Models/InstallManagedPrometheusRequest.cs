// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class InstallManagedPrometheusRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the ASK cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc7a37ee31aea4ed1a059eff8034b****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The name of the cluster. This parameter is required if the ClusterType parameter is set to ecs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>prd-ecs</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>The cluster type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ecs: ECS</description></item>
        /// <item><description>one: ACK One</description></item>
        /// <item><description>ask: ASK</description></item>
        /// <item><description>pro: Container Monitoring Pro</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ask</para>
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// <para>The ID of the managed Grafana workspace that is associated with the cluster. If you set this parameter to free or leave this parameter empty, the cluster is associated with a shared Grafana workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>grafana-bp1*****</para>
        /// </summary>
        [NameInMap("GrafanaInstanceId")]
        [Validation(Required=false)]
        public string GrafanaInstanceId { get; set; }

        /// <summary>
        /// <para>This parameter is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("KubeConfig")]
        [Validation(Required=false)]
        public string KubeConfig { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rg-acfmxyexli2****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the security group to which the cluster belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp1********</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch that is used by the cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1*********</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        [NameInMap("VcExtraInfo")]
        [Validation(Required=false)]
        public string VcExtraInfo { get; set; }

        /// <summary>
        /// <para>The virtual private cloud (VPC) where the cluster resides.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-xxxxxx</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
