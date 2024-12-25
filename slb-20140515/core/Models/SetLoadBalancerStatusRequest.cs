// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class SetLoadBalancerStatusRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the CLB instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-bp1b6c719dfa08e******</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>The state of the CLB instance. Valid values: <b>active</b> and <b>inactive</b>.</para>
        /// <list type="bullet">
        /// <item><description><para><b>active</b> (default)</para>
        /// <para>If a CLB instance is in the <b>active</b> state, listeners of the CLB instance can forward traffic based on forwarding rules.</para>
        /// <para>By default, newly created CLB instances are in the <b>active</b> state.</para>
        /// </description></item>
        /// <item><description><para><b>inactive</b></para>
        /// <para>If a CLB instance is in the <b>inactive</b> state, listeners of the CLB instance do not forward traffic.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para> If all listeners of a CLB instance are deleted, the CLB instance automatically switches to the <b>inactive</b> state.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>active</para>
        /// </summary>
        [NameInMap("LoadBalancerStatus")]
        [Validation(Required=false)]
        public string LoadBalancerStatus { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the CLB instance is deployed.</para>
        /// <para>You can query region IDs from the <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a> list or by calling the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation.</para>
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
