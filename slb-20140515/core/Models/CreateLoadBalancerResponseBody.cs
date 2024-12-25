// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class CreateLoadBalancerResponseBody : TeaModel {
        /// <summary>
        /// <para>The IP address that is allocated to the CLB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>42.XX.XX.6</para>
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// <para>The IP version that is used by the CLB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipv4</para>
        /// </summary>
        [NameInMap("AddressIPVersion")]
        [Validation(Required=false)]
        public string AddressIPVersion { get; set; }

        /// <summary>
        /// <para>The CLB instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-hddhfjg****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>The CLB instance name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-bp1o94dp5i6ea****</para>
        /// </summary>
        [NameInMap("LoadBalancerName")]
        [Validation(Required=false)]
        public string LoadBalancerName { get; set; }

        /// <summary>
        /// <para>The network type of the CLB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>vpc</b></description></item>
        /// <item><description><b>classic</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>classic</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// <para>The order ID of the subscription CLB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20212961978****</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>365F4154-92F6-4AE4-92F8-7FF34B540710</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the CLB instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-atstuj3rto****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch to which the CLB instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-255ecr****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC to which the CLB instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-25dvzy9****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
