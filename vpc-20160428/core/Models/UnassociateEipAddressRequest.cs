// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class UnassociateEipAddressRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the EIP to disassociate.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eip-2zeerraiwb7uj6i0d****</para>
        /// </summary>
        [NameInMap("AllocationId")]
        [Validation(Required=false)]
        public string AllocationId { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> as the <b>ClientToken</b>. The <b>RequestId</b> may be different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcefully disassociate the EIP when the EIP is associated with a NAT gateway that has DNAT or SNAT entries configured. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>false</b> (default): does not forcefully disassociate the EIP.</para>
        /// </description></item>
        /// <item><description><para><b>true</b>: forcefully disassociates the EIP.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// <para>The instance ID of the cloud resource from which to disassociate the EIP.
        /// You can enter the instance ID of a NAT gateway, Classic Load Balancer (CLB) instance, ECS instance, secondary elastic network interface controller (NIC), high availability virtual IP address instance, or an IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-hp3akk9irtd69jad****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The type of the cloud resource from which to disassociate the EIP. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><para><b>EcsInstance</b> (default): an ECS instance in a virtual private cloud (VPC).   </para>
        /// </description></item>
        /// <item><description><para><b>SlbInstance</b>: a load balancing instance in a virtual private cloud (VPC).   </para>
        /// </description></item>
        /// <item><description><para><b>NetworkInterface</b>: a secondary elastic network interface controller (NIC) in a virtual private cloud (VPC).</para>
        /// </description></item>
        /// <item><description><para><b>Nat</b>: a NAT gateway.  </para>
        /// </description></item>
        /// <item><description><para><b>HaVip</b>: a high availability virtual IP address.</para>
        /// </description></item>
        /// <item><description><para><b>IpAddress</b>: an IP address.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>EcsInstance</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The private IP address of the ECS instance or secondary elastic network interface controller (NIC) instance from which to disassociate the EIP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.XX.XX.2</para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>The region ID of the EIP to disassociate.
        ///  You can call <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> to query region IDs.</para>
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
