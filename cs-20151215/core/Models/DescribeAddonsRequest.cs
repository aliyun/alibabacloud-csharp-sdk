// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeAddonsRequest : TeaModel {
        /// <summary>
        /// <para>The cluster type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>Default</c>: managed cluster.</description></item>
        /// <item><description><c>Serverless</c>: serverless cluster.</description></item>
        /// <item><description><c>Edge</c>: edge cluster.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Default</para>
        /// </summary>
        [NameInMap("cluster_profile")]
        [Validation(Required=false)]
        public string ClusterProfile { get; set; }

        /// <summary>
        /// <para>After you set <c>cluster_type</c> to <c>ManagedKubernetes</c> and configure <c>profile</c>, you can further specify the cluster specification.</para>
        /// <list type="bullet">
        /// <item><description><para><c>ack.pro.small</c>: Pro cluster.</para>
        /// </description></item>
        /// <item><description><para><c>ack.standard</c>: Basic cluster (selected by default if this parameter is left empty).</para>
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
        /// <item><description><para><c>Kubernetes</c>: ACK dedicated cluster.</para>
        /// </description></item>
        /// <item><description><para><c>ManagedKubernetes</c>: ACK managed cluster types, including ACK managed clusters (ACK Pro and ACK Basic), ACK Serverless clusters (Pro and Basic), ACK Edge clusters (Pro and Basic), and ACK Lingjun clusters (Pro).</para>
        /// </description></item>
        /// <item><description><para><c>ExternalKubernetes</c>: registered cluster.</para>
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
        /// <para>The ID of the region where the cluster resides.</para>
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
