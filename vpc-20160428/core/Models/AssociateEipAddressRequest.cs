// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class AssociateEipAddressRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the EIP that you want to associate with the cloud service instance.</para>
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
        /// <para>You can use the client to generate the value, but you must make sure that it is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request is unique.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88e9fe63****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the instance to which you want to attach the EIP.</para>
        /// <para>You can enter the instance ID of a NAT gateway, a Classic Load Balancing (CLB) instance, an ECS server instance, a secondary elastic network interface controller (NIC), a high-availability (active) virtual IP address, or an IP address.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-2zebb08phyczzawe****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The region ID of the instance to which you want to attach the EIP.</para>
        /// <remarks>
        /// <para>This parameter is required only when the EIP is added to an Alibaba Cloud Global Accelerator (GA) instance with shared bandwidth.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("InstanceRegionId")]
        [Validation(Required=false)]
        public string InstanceRegionId { get; set; }

        /// <summary>
        /// <para>The type of the instance to which you want to attach the EIP. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Nat</b>: NAT gateway.</para>
        /// </description></item>
        /// <item><description><para><b>SlbInstance</b>: Classic Load Balancing (CLB).</para>
        /// </description></item>
        /// <item><description><para><b>EcsInstance</b> (default): Elastic Compute Service server.</para>
        /// </description></item>
        /// <item><description><para><b>NetworkInterface</b>: secondary elastic network interface controller (NIC).</para>
        /// </description></item>
        /// <item><description><para><b>HaVip</b>: high-availability (active) virtual IP address. </para>
        /// </description></item>
        /// <item><description><para><b>IpAddress</b>: IP address.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>By default, the instance type is <b>EcsInstance</b>. If you want to attach the EIP to an instance of a different type, this parameter is required.</para>
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
        /// <item><description><para><b>NAT</b> (default): NAT mode.</para>
        /// </description></item>
        /// <item><description><para><b>MULTI_BINDED</b>: multi-EIP passthrough mode.</para>
        /// </description></item>
        /// <item><description><para><b>BINDED</b>: EIP passthrough mode.</para>
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
        /// <para>An IP address within the vSwitch CIDR block.</para>
        /// <para>If you do not specify this parameter, the system automatically allocates a private IP address based on the VPC ID and vSwitch ID.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>InstanceType</b> is set to <b>NetworkInterface</b>. You must specify the private IP address to be attached.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>The region ID of the EIP that you want to associate with the cloud service instance.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query region IDs.</para>
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
        /// <para>When you attach the EIP to an IP address, the system can enable public network access for the attached IP address based on the routing configurations of the VPC.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>InstanceType</b> is set to <b>IpAddress</b>, which means you want to attach the EIP to an IP address.</para>
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
