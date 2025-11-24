// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeReusableSlbRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster on the data plane. If you specify this parameter, you cannot specify ServiceMeshId. This parameter and ServiceMeshId cannot be left empty at the same time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca2cfe41fefeb489d9b9dba18a7c5****</para>
        /// </summary>
        [NameInMap("K8sClusterId")]
        [Validation(Required=false)]
        public string K8sClusterId { get; set; }

        /// <summary>
        /// <para>Load balancer type, value:</para>
        /// <list type="bullet">
        /// <item><description><para><c>clb</c>: Classic Load Balancer</para>
        /// </description></item>
        /// <item><description><para><c>nlb</c>: Network Load Balancer</para>
        /// </description></item>
        /// </list>
        /// <para>default is <c>clb</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>clb</para>
        /// </summary>
        [NameInMap("LbType")]
        [Validation(Required=false)]
        public string LbType { get; set; }

        /// <summary>
        /// <para>The network type of the SLB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>intranet</c></description></item>
        /// <item><description><c>internet</c></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internet</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// <para>The ID of the Service Mesh (ASM) instance. If you specify this parameter, you cannot specify K8sClusterId. This parameter and K8sClusterId cannot be left empty at the same time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cb8963379255149cb98c8686f274x****</para>
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

    }

}
