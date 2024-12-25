// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class ModifyLoadBalancerInstanceSpecRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: automatically completes the payment.</description></item>
        /// <item><description><b>false</b> (default): If you select this option, you must complete the payment in the Order Center.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only for subscription instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The ID of the CLB instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-bp1b6c719df*********</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>The specification of the CLB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>slb.s1.small</b></description></item>
        /// <item><description><b>slb.s2.small</b></description></item>
        /// <item><description><b>slb.s2.medium</b></description></item>
        /// <item><description><b>slb.s3.small</b></description></item>
        /// <item><description><b>slb.s3.medium</b></description></item>
        /// <item><description><b>slb.s3.large</b></description></item>
        /// </list>
        /// <para>The specifications available vary by region. For more information about the specifications, see <a href="https://help.aliyun.com/document_detail/85931.html">High-performance CLB instance</a>.</para>
        /// <remarks>
        /// <para>When you switch a shared-resource CLB instance to a high-performance CLB instance, your service may be interrupted for 10 to 30 seconds. We recommend that you modify the specification during off-peak hours or use Alibaba Cloud DNS to schedule your workloads to another CLB instance before you modify the specification.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>slb.s2.small</para>
        /// </summary>
        [NameInMap("LoadBalancerSpec")]
        [Validation(Required=false)]
        public string LoadBalancerSpec { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the CLB instance.</para>
        /// <para>You can query the region ID from the <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a> list or by calling the <a href="https://help.aliyun.com/document_detail/27584.html">DescribeRegions</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
