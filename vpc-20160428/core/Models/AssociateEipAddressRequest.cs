// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class AssociateEipAddressRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the EIP to be associated with the cloud resource instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eip-2zeerraiwb7ujsxdc****</para>
        /// </summary>
        [NameInMap("AllocationId")]
        [Validation(Required=false)]
        public string AllocationId { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> may be different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88e9fe63****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The instance ID of the instance to be associated with the EIP.</para>
        /// <para>You can enter the instance ID of a NAT gateway, a Classic Load Balancer (CLB) instance, an Elastic Compute Service (ECS) instance, a secondary elastic network interface controller (NIC) instance, a high-availability virtual IP address instance, or an IP address.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-2zebb08phyczzawe****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The region ID of the instance to be associated with the EIP.</para>
        /// <remarks>
        /// <para>This parameter is required only after the EIP is added to a shared-bandwidth Global Accelerator (GA) instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("InstanceRegionId")]
        [Validation(Required=false)]
        public string InstanceRegionId { get; set; }

        /// <summary>
        /// <para>The type of the instance to be associated with the EIP. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Nat</b>: NAT gateway.</para>
        /// </description></item>
        /// <item><description><para><b>SlbInstance</b>: Classic Load Balancer (CLB).</para>
        /// </description></item>
        /// <item><description><para><b>EcsInstance</b> (default): Elastic Compute Service (ECS).</para>
        /// </description></item>
        /// <item><description><para><b>NetworkInterface</b>: secondary elastic network interface controller (NIC).</para>
        /// </description></item>
        /// <item><description><para><b>HaVip</b>: high-availability virtual IP address. </para>
        /// </description></item>
        /// <item><description><para><b>IpAddress</b>: IP address.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The default instance type is <b>EcsInstance</b>. If the instance type is not <b>EcsInstance</b>, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>EcsInstance</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The association mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>NAT</b> (default): NAT mode (standard mode).</para>
        /// </description></item>
        /// <item><description><para><b>MULTI_BINDED</b>: multi-EIP-to-ENI mode.</para>
        /// </description></item>
        /// <item><description><para><b>BINDED</b>: EIP-to-ENI mode.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required only when <b>InstanceType</b> is set to <b>NetworkInterface</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>NAT</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>An IP address in the vSwitch CIDR block.</para>
        /// <para>If you do not specify this parameter, the system automatically assigns a private IP address based on the VPC ID and vSwitch ID.</para>
        /// <remarks>
        /// <para>If <b>InstanceType</b> is set to <b>NetworkInterface</b>, this parameter is required. Enter the private IP address to be associated.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>The region ID of the EIP to be associated with the cloud resource instance.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the region ID.</para>
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

        /// <summary>
        /// <para>The ID of the VPC that has the IPv4 gateway feature enabled and is in the same region as the EIP.</para>
        /// <para>When the EIP is associated with an IP address, the system can use the route configuration of the VPC to enable public network access for the associated IP address.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>InstanceType</b> is set to <b>IpAddress</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-257gqcdfvx6n****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
