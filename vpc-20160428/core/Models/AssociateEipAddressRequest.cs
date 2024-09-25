// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class AssociateEipAddressRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the EIP that you want to associate with an instance.</para>
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
        /// <para>You can use the client to generate a token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the <b>request ID</b> as the <b>client token</b>. The <b>request ID</b> may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88e9fe63****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the instance with which you want to associate the EIP.</para>
        /// <para>You can enter the ID of a NAT gateway, CLB instance, ECS instance, secondary ENI, HAVIP, or IP address.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-2zebb08phyczzawe****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the instance with which you want to associate the EIP resides.</para>
        /// <remarks>
        /// <para> This parameter is required only when the EIP is added to a shared Global Accelerator (GA) instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("InstanceRegionId")]
        [Validation(Required=false)]
        public string InstanceRegionId { get; set; }

        /// <summary>
        /// <para>The type of the instance with which you want to associate the EIP. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Nat</b>: NAT gateway</description></item>
        /// <item><description><b>SlbInstance</b>: CLB instance</description></item>
        /// <item><description><b>EcsInstance</b> (default): ECS instance</description></item>
        /// <item><description><b>NetworkInterface</b>: secondary ENI</description></item>
        /// <item><description><b>HaVip</b>: HAVIP</description></item>
        /// <item><description><b>IpAddress</b>: IP address</description></item>
        /// </list>
        /// <remarks>
        /// <para> The default value is <b>EcsInstance</b>. If the instance with which you want to associate the EIP is not an ECS instance, this parameter is required.</para>
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
        /// <item><description><b>NAT</b> (default): NAT mode</description></item>
        /// <item><description><b>MULTI_BINDED</b>: multi-EIP-to-ENI mode</description></item>
        /// <item><description><b>BINDED</b>: cut-network interface controller mode</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is required only when <b>InstanceType</b> is set to <b>NetworkInterface</b>.</para>
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
        /// <para>The IP address in the CIDR block of the vSwitch.</para>
        /// <para>If you leave this parameter empty, the system allocates a private IP address based on the VPC ID and vSwitch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>The ID of the region to which the EIP belongs.</para>
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
        /// <para>The ID of the VPC in which an IPv4 gateway is created. The VPC and the EIP must be in the same region.</para>
        /// <para>When you associate an EIP with an IP address, the system can enable the IP address to access the Internet based on VPC route configurations.</para>
        /// <remarks>
        /// <para> This parameter is required if <b>InstanceType</b> is set to <b>IpAddress</b>, which indicates that the EIP is to be associated with an IP address.</para>
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
