// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateSslVpnServerRequest : TeaModel {
        /// <summary>
        /// <para>The encryption algorithm used by the SSL-VPN connection.</para>
        /// <list type="bullet">
        /// <item><description><para>If the client uses Tunnelblick or OpenVPN 2.4.0 or later, the SSL server and the client dynamically negotiate the encryption algorithm and prefer the highest-security encryption algorithm supported by both parties. The encryption algorithm that you specify for the SSL server does not take effect.</para>
        /// </description></item>
        /// <item><description><para>If the client uses OpenVPN earlier than 2.4.0, the SSL server and the client use the encryption algorithm that you specify for the SSL server. The SSL server supports the following encryption algorithms:</para>
        /// <list type="bullet">
        /// <item><description><para><b>AES-128-CBC</b> (default): AES-128-CBC</para>
        /// </description></item>
        /// <item><description><para><b>AES-192-CBC</b>: AES-192-CBC</para>
        /// </description></item>
        /// <item><description><para><b>AES-256-CBC</b>: AES-256-CBC</para>
        /// </description></item>
        /// <item><description><para><b>none</b>: No encryption algorithm is used.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AES-128-CBC</para>
        /// </summary>
        [NameInMap("Cipher")]
        [Validation(Required=false)]
        public string Cipher { get; set; }

        /// <summary>
        /// <para>The client CIDR block.</para>
        /// <para>This is the CIDR block from which IP addresses are allocated to the virtual network interface controller (NIC) of clients. It is not the existing internal network CIDR block of the clients.</para>
        /// <para>When a client accesses the local network through an SSL-VPN connection, the VPN gateway allocates an IP address from the specified client CIDR block to the client. The client uses the allocated IP address to access cloud resources.</para>
        /// <para>When you specify the client CIDR block, make sure that the number of IP addresses included in the client CIDR block is at least four times the number of SSL connections supported by the current VPN gateway.</para>
        /// <details>
        /// <summary>Click to view the reason</summary>
        /// 
        /// <para>For example, if you specify 192.168.0.0/24 as the client CIDR block, the system first divides a subnet with a subnet mask of 30 from the 192.168.0.0/24 CIDR block, such as 192.168.0.4/30. Then, the system allocates an IP address from 192.168.0.4/30 for the client to use. The remaining three IP addresses are occupied by the system to ensure network communication. In this case, one client consumes four IP addresses. Therefore, to ensure that all your clients can be allocated IP addresses, make sure that the number of IP addresses included in the specified client CIDR block is at least four times the number of SSL connections supported by the VPN gateway.</para>
        /// </details>
        /// 
        /// <details>
        /// <summary>Click to view the CIDR blocks that are not supported</summary>
        /// 
        /// <list type="bullet">
        /// <item><description>100.64.0.0 to 100.127.255.255</description></item>
        /// <item><description>127.0.0.0 to 127.255.255.255</description></item>
        /// <item><description>169.254.0.0 to 169.254.255.255</description></item>
        /// <item><description>224.0.0.0 to 239.255.255.255</description></item>
        /// <item><description>255.0.0.0 to 255.255.255.255</details></description></item>
        /// </list>
        /// <details>
        /// <summary>Click to view the recommended client CIDR blocks for each number of SSL connections</summary>
        /// 
        /// <list type="bullet">
        /// <item><description>If the number of SSL connections is 5, we recommend that the subnet mask of the client CIDR block be 27 bits or less. Examples: 10.0.0.0/27 and 10.0.0.0/26.</description></item>
        /// <item><description>If the number of SSL connections is 10, we recommend that the subnet mask of the client CIDR block be 26 bits or less. Examples: 10.0.0.0/26 and 10.0.0.0/25.</description></item>
        /// <item><description>If the number of SSL connections is 20, we recommend that the subnet mask of the client CIDR block be 25 bits or less. Examples: 10.0.0.0/25 and 10.0.0.0/24.</description></item>
        /// <item><description>If the number of SSL connections is 50, we recommend that the subnet mask of the client CIDR block be 24 bits or less. Examples: 10.0.0.0/24 and 10.0.0.0/23.</description></item>
        /// <item><description>If the number of SSL connections is 100, we recommend that the subnet mask of the client CIDR block be 23 bits or less. Examples: 10.0.0.0/23 and 10.0.0.0/22.</description></item>
        /// <item><description>If the number of SSL connections is 200, we recommend that the subnet mask of the client CIDR block be 22 bits or less. Examples: 10.0.0.0/22 and 10.0.0.0/21.</description></item>
        /// <item><description>If the number of SSL connections is 500, we recommend that the subnet mask of the client CIDR block be 21 bits or less. Examples: 10.0.0.0/21 and 10.0.0.0/20.</description></item>
        /// <item><description>If the number of SSL connections is 1000, we recommend that the subnet mask of the client CIDR block be 20 bits or less. Examples: 10.0.0.0/20 and 10.0.0.0/19.</description></item>
        /// </list>
        /// </details>
        /// 
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The subnet mask of the client CIDR block must be 16 to 29 bits in length.</description></item>
        /// <item><description>Make sure that the client CIDR block does not overlap with the local CIDR block, the VPC CIDR block, or any routing CIDR block associated with the client terminal.</description></item>
        /// <item><description>When you specify the client CIDR block, we recommend that you use the 10.0.0.0/8, 172.16.0.0/12, and 192.168.0.0/16 CIDR blocks and their subnets. If you need to specify a public CIDR block as the client CIDR block, you must add the public CIDR block to the user CIDR block Settings of the VPC to ensure that the VPC can access the public CIDR block. For more information about user CIDR blocks, see <a href="https://help.aliyun.com/document_detail/185311.html">virtual private cloud (VPC) FAQ</a>.</description></item>
        /// <item><description>After you create an SSL server, the system automatically adds routing for the client CIDR block in the route table of the VPC instance. Do not manually add routing for the client CIDR block in the route table of the VPC instance. Otherwise, SSL-VPN connection traffic transmission exceptions may occur.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.1.0/24</para>
        /// </summary>
        [NameInMap("ClientIpPool")]
        [Validation(Required=false)]
        public string ClientIpPool { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can generate a parameter value on your client to ensure that the value is unique across different requests. The ClientToken parameter supports only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request is different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-0016e04115b</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to compress communication. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Compresses communication.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): Does not compress communication.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Compress")]
        [Validation(Required=false)]
        public bool? Compress { get; set; }

        /// <summary>
        /// <para>The DNS server addresses configured for the client. You can enter up to two addresses, separated by commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>223.5.5.5,114.114.114.114</para>
        /// </summary>
        [NameInMap("DnsServers")]
        [Validation(Required=false)]
        public string DnsServers { get; set; }

        /// <summary>
        /// <para>Specifies whether to only precheck the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Prechecks the request without performing the operation. The system prechecks required parameters, request syntax, and limits. If the request fails the precheck, an error message is returned. If the request passes the precheck, the <c>DryRunOperation</c> error code is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): Sends the request. After the request passes the precheck, a 2xx HTTP status code is returned and the operation is performed.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable two-factor authentication. If you enable two-factor authentication, you must also configure the <c>IDaaSInstanceId</c>, <c>IDaaSRegionId</c>, and <c>IDaaSApplicationId</c> parameters. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enables two-factor authentication.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): Disables two-factor authentication.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you use the two-factor authentication feature for the first time, complete the <a href="https://ram.console.aliyun.com/role/authorization?request=%7B%22Services%22%3A%5B%7B%22Service%22%3A%22VPN%22%2C%22Roles%22%3A%5B%7B%22RoleName%22%3A%22AliyunVpnAccessingIdaasRole%22%2C%22TemplateId%22%3A%22IdaasRole%22%7D%5D%7D%5D%2C%22ReturnUrl%22%3A%22https%3A%2F%2Fvpc.console.aliyun.com%2Fsslvpn%2Fcn-shanghai%2Fvpn-servers%22%7D">authorization</a> before you create an SSL server.</description></item>
        /// <item><description>When you create an SSL server in the UAE (Dubai) region, we recommend that you bind an IDaaS EIAM 2.0 instance in the Singapore region to reduce cross-region latency.</description></item>
        /// <item><description>IDaaS EIAM 1.0 instances are no longer available for purchase. If your Alibaba Cloud account has an IDaaS EIAM 1.0 instance, you can still bind the IDaaS EIAM 1.0 instance after you enable two-factor authentication. If your Alibaba Cloud account does not have an IDaaS EIAM 1.0 instance, you can only bind an IDaaS EIAM 2.0 instance after you enable two-factor authentication.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableMultiFactorAuth")]
        [Validation(Required=false)]
        public bool? EnableMultiFactorAuth { get; set; }

        /// <summary>
        /// <para>The ID of the IDaaS application.</para>
        /// <list type="bullet">
        /// <item><description>If you bind an IDaaS EIAM 2.0 instance, you must enter the ID of the IDaaS application.</description></item>
        /// <item><description>If you bind an IDaaS EIAM 1.0 instance, you do not need to enter the ID of the IDaaS application.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>app_my6g4qmvnwxzj2f****</para>
        /// </summary>
        [NameInMap("IDaaSApplicationId")]
        [Validation(Required=false)]
        public string IDaaSApplicationId { get; set; }

        /// <summary>
        /// <para>The ID of the IDaaS EIAM instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas-cn-hangzhou-p****</para>
        /// </summary>
        [NameInMap("IDaaSInstanceId")]
        [Validation(Required=false)]
        public string IDaaSInstanceId { get; set; }

        /// <summary>
        /// <para>The region ID of the IDaaS EIAM instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("IDaaSRegionId")]
        [Validation(Required=false)]
        public string IDaaSRegionId { get; set; }

        /// <summary>
        /// <para>The local CIDR block.</para>
        /// <para>This is the CIDR block that the client wants to access through the SSL-VPN connection.</para>
        /// <para>The local CIDR block can be the CIDR block of a VPC, the CIDR block of a vSwitch, the CIDR block of a data center that is connected to the VPC through an Express Connect circuit, or the CIDR block of a cloud service such as Object Storage Service (OSS).</para>
        /// <para>The subnet mask of the local CIDR block must be 8 to 32 bits in length. The following CIDR blocks cannot be specified as the local CIDR block:</para>
        /// <list type="bullet">
        /// <item><description>127.0.0.0 to 127.255.255.255</description></item>
        /// <item><description>169.254.0.0 to 169.254.255.255</description></item>
        /// <item><description>224.0.0.0 to 239.255.255.255</description></item>
        /// <item><description>255.0.0.0 to 255.255.255.255</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.0/8</para>
        /// </summary>
        [NameInMap("LocalSubnet")]
        [Validation(Required=false)]
        public string LocalSubnet { get; set; }

        /// <summary>
        /// <para>The name of the SSL-VPN server.</para>
        /// <para>The name must be 1 to 100 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sslvpnname</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The port used by the SSL-VPN server. Valid values: <b>1</b> to <b>65535</b>. Default value: <b>1194</b>.</para>
        /// <para>The following ports are not supported: <b>22</b>, <b>2222</b>, <b>22222</b>, <b>9000</b>, <b>9001</b>, <b>9002</b>, <b>7505</b>, <b>80</b>, <b>443</b>, <b>53</b>, <b>68</b>, <b>123</b>, <b>4510</b>, <b>4560</b>, <b>500</b>, and <b>4500</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1194</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// <para>The protocol used by the SSL-VPN server. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>TCP</b> (default): TCP</description></item>
        /// <item><description><b>UDP</b>: UDP</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>UDP</para>
        /// </summary>
        [NameInMap("Proto")]
        [Validation(Required=false)]
        public string Proto { get; set; }

        /// <summary>
        /// <para>The region ID of the VPN gateway.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query region IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
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
        /// <para>The ID of the VPN gateway.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpn-bp1hgim8by0kc9nga****</para>
        /// </summary>
        [NameInMap("VpnGatewayId")]
        [Validation(Required=false)]
        public string VpnGatewayId { get; set; }

    }

}
