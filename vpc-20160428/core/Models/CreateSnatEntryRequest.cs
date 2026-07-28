// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateSnatEntryRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The <c>ClientToken</c> value can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system uses the <b>RequestId</b> as the <b>ClientToken</b>. The <b>RequestId</b> may be different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: performs a dry run without creating the SNAT entry. The system checks the AccessKey pair, the authorization of the Resource Access Management (RAM) user, and the required parameters. If the check fails, the corresponding error is returned. If the check succeeds, the error code <c>DryRunOperation</c> is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): sends a Normal request, and the SNAT entry is created after the check succeeds. A 2xx HTTP status code is returned.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable EIP affinity. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b> (default): disables EIP affinity.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: enables EIP affinity.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>After EIP affinity is enabled, if the SNAT entry is bindded with multiple EIPs or NAT IP addresses, the same client uses the same EIP or NAT IP address to access the same destination IP address. Otherwise, the client randomly selects an EIP or NAT IP address from the bindded ones.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EipAffinity")]
        [Validation(Required=false)]
        public int? EipAffinity { get; set; }

        /// <summary>
        /// <para>The ID of the elastic network interface (ENI).</para>
        /// <remarks>
        /// <para>The IPv4 address set of the ENI is used as the SNAT address.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>eni-gw8g131ef2dnbu3k****</para>
        /// </summary>
        [NameInMap("NetworkInterfaceId")]
        [Validation(Required=false)]
        public string NetworkInterfaceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the NAT gateway. </para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the region ID.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>The name of the SNAT entry.</para>
        /// <para>The name must be 2 to 128 characters in length and must start with a letter or Chinese character. It cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SnatEntry-1</para>
        /// </summary>
        [NameInMap("SnatEntryName")]
        [Validation(Required=false)]
        public string SnatEntryName { get; set; }

        /// <summary>
        /// <para>When you add an SNAT entry for an Internet NAT gateway:</para>
        /// <list type="bullet">
        /// <item><description><para>The SnatIp parameter is required.</para>
        /// </description></item>
        /// <item><description><para>This parameter specifies the EIPs in the SNAT entry. Separate multiple EIPs with commas (,).</para>
        /// </description></item>
        /// <item><description><para>If SnatIp specifies only one public IP address, the ECS instance uses the specified public IP address to access the Internet.</para>
        /// </description></item>
        /// <item><description><para>If SnatIp specifies multiple public IP addresses, the ECS instance randomly uses one of the public IP addresses in SnatIp to access the Internet.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you specify multiple EIPs to configure an SNAT IP IPAM pool, connections are allocated to multiple EIPs by using a hash algorithm. Because the traffic of each connection varies, service traffic may be unevenly distributed among the EIPs. Add each EIP to the same Internet Shared Bandwidth instance to prevent service interruptions caused by bandwidth exhaustion on a single EIP.</para>
        /// </remarks>
        /// <para>When you add an SNAT entry for a VPC NAT gateway:</para>
        /// <list type="bullet">
        /// <item><description><para>This parameter specifies the NAT IP addresses in the SNAT entry. Separate multiple NAT IP addresses with commas (,).</para>
        /// </description></item>
        /// <item><description><para>You must specify one of the SnatIp and NetworkInterfaceId parameters, but you cannot specify both.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>47.98.XX.XX</para>
        /// </summary>
        [NameInMap("SnatIp")]
        [Validation(Required=false)]
        public string SnatIp { get; set; }

        /// <summary>
        /// <para>The ID of the SNAT table.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>stb-bp190wu8io1vgev****</para>
        /// </summary>
        [NameInMap("SnatTableId")]
        [Validation(Required=false)]
        public string SnatTableId { get; set; }

        /// <summary>
        /// <para>The CIDR block of a VPC, vSwitch, or ECS instance. You can also specify a custom CIDR block.</para>
        /// <para>SNAT entries support the following granularities: </para>
        /// <list type="bullet">
        /// <item><description><para>VPC granularity: the CIDR block of the VPC to which the NAT gateway belongs. All ECS instances in the VPC can access the Internet or external networks by using the SNAT rule.</para>
        /// </description></item>
        /// <item><description><para>vSwitch granularity: the CIDR block of a specified vSwitch (such as 192.168.1.0/24). ECS instances in the vSwitch can access the Internet or external networks by using the SNAT rule.</para>
        /// </description></item>
        /// <item><description><para>ECS granularity: the IP address of a specified ECS instance (such as 192.168.1.1/32). The ECS instance can access the Internet or external networks by using the SNAT rule.</para>
        /// </description></item>
        /// <item><description><para>Custom CIDR block: all ECS instances in the specified CIDR block can access the Internet or external networks by using the SNAT service.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You must specify one of the <b>SourceCIDR</b> and <b>SourceVSwitchId</b> parameters, but you cannot specify both.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10.1.1.0/24</para>
        /// </summary>
        [NameInMap("SourceCIDR")]
        [Validation(Required=false)]
        public string SourceCIDR { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch.</para>
        /// <list type="bullet">
        /// <item><description><para>When you add an SNAT entry for an Internet NAT gateway, this parameter specifies that ECS instances in the vSwitch can access the Internet by using the SNAT rule. If you specify multiple EIPs to configure an SNAT IP IPAM pool, connections are allocated to multiple EIPs by using a hash algorithm. Because the traffic of each connection varies, service traffic may be unevenly distributed among the EIPs. Add each EIP to the same Internet Shared Bandwidth instance to prevent service interruptions caused by bandwidth exhaustion on a single EIP.</para>
        /// </description></item>
        /// <item><description><para>When you add an SNAT entry for a VPC NAT gateway, this parameter specifies that ECS instances in the vSwitch can access external networks by using the SNAT rule.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You must specify one of the <b>SourceCIDR</b> and <b>SourceVSwitchId</b> parameters, but you cannot specify both.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1nhx2s9ui5o****</para>
        /// </summary>
        [NameInMap("SourceVSwitchId")]
        [Validation(Required=false)]
        public string SourceVSwitchId { get; set; }

    }

}
