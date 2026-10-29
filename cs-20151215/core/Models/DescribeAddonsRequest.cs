// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeAddonsRequest : TeaModel {
        /// <summary>
        /// <para>The cluster profile. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Default: managed cluster.</description></item>
        /// <item><description>Serverless: Serverless cluster.</description></item>
        /// <item><description>Edge: edge cluster.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Default</para>
        /// </summary>
        [NameInMap("cluster_profile")]
        [Validation(Required=false)]
        public string ClusterProfile { get; set; }

        /// <summary>
        /// <para>The cluster specifications. You can specify this parameter when you set cluster_type to ManagedKubernetes and configure profile. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ack.pro.small: ACK Pro.</para>
        /// </description></item>
        /// <item><description><para>ack.standard: ACK Basic. This is the default value if this parameter is left empty.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ack.pro.small</para>
        /// </summary>
        [NameInMap("cluster_spec")]
        [Validation(Required=false)]
        public string ClusterSpec { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>Kubernetes: ACK dedicated cluster.</para>
        /// </description></item>
        /// <item><description><para>ManagedKubernetes: ACK ACK clusters, including ACK ACK clusters (ACK Pro and ACK Basic), ACK Serverless clusters (Pro and Basic), ACK Edge clusters (Pro and Basic), and ACK Lingjun clusters (Pro).</para>
        /// </description></item>
        /// <item><description><para>ExternalKubernetes: registered cluster.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ManagedKubernetes</para>
        /// </summary>
        [NameInMap("cluster_type")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// <para>The cluster version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.24.6-aliyun.1</para>
        /// </summary>
        [NameInMap("cluster_version")]
        [Validation(Required=false)]
        public string ClusterVersion { get; set; }

        /// <summary>
        /// <para>The ID of the region where the cluster is deployed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

    }

}
