// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateSslVpnServerRequest : TeaModel {
        /// <summary>
        /// <para>The encryption algorithm that is used by the SSL-VPN connection.</para>
        /// <list type="bullet">
        /// <item><description><para>If the client uses Tunnelblick or OpenVPN 2.4.0 or later, the SSL server dynamically negotiates with the client about the encryption algorithm and uses the most secure encryption algorithm that is supported by the SSL server and the client. The encryption algorithm that you specify for the SSL server does not take effect.</para>
        /// </description></item>
        /// <item><description><para>If the client uses OpenVPN of a version that is earlier than 2.4.0, the SSL server and the client use the encryption algorithm that you specify for the SSL server. You can specify one of the following encryption algorithms for the SSL server:</para>
        /// <list type="bullet">
        /// <item><description><b>AES-128-CBC</b> (default)</description></item>
        /// <item><description><b>AES-192-CBC</b></description></item>
        /// <item><description><b>AES-256-CBC</b></description></item>
        /// <item><description><b>none</b></description></item>
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
        /// <para>It is the CIDR block from which an IP address is allocated to the virtual network interface controller (NIC) of the client. It is not the private CIDR block of the client.</para>
        /// <para>If the client accesses the SSL server over an SSL-VPN connection, the VPN gateway assigns an IP address from the specified client CIDR block to the client. The client uses the assigned IP address to access cloud resources.</para>
        /// <para>Make sure that the number of IP addresses in the client CIDR block is at least four times the maximum number of SSL-VPN connections supported by the VPN gateway.</para>
        /// <details>
        /// <summary>Click to view the reason.</summary>
        /// 
        /// <para>For example, if you specify 192.168.0.0/24 as the client CIDR block, the system first divides a subnet CIDR block with a subnet mask of 30 from 192.168.0.0/24, such as 192.168.0.4/30. This subnet provides up to four IP addresses. Then, the system allocates an IP address from 192.168.0.4/30 to the client and uses the other three IP addresses to ensure network communication. In this case, one client consumes four IP addresses. Therefore, to ensure that an IP address is assigned to your client, you must make sure that the number of IP addresses in the client CIDR block is at least four times the maximum number of SSL-VPN connections supported by the VPN gateway with which the SSL server is associated.</para>
        /// </details>
        /// 
        /// <details>
        /// <summary>Click to view the CIDR blocks that are not supported.</summary>
        /// 
        /// <list type="bullet">
        /// <item><description>100.64.0.0~100.127.255.255</description></item>
        /// <item><description>127.0.0.0~127.255.255.255</description></item>
        /// <item><description>169.254.0.0~169.254.255.255</description></item>
        /// <item><description>224.0.0.0~239.255.255.255</description></item>
        /// <item><description>255.0.0.0~255.255.255.255</details></description></item>
        /// </list>
        /// <details>
        /// <summary>Click to view the recommended client CIDR blocks for different numbers of SSL-VPN connections.</summary>
        /// 
        /// <list type="bullet">
        /// <item><description>If the number of SSL-VPN connections is 5, we recommend that you specify a client CIDR block with a subnet mask that is less than or equal to 27 bits in length. Examples: 10.0.0.0/27 and 10.0.0.0/26.</description></item>
        /// <item><description>If the number of SSL-VPN connections is 10, we recommend that you specify a client CIDR block with a subnet mask that is less than or equal to 26 bits in length. Examples: 10.0.0.0/26 and 10.0.0.0/25.</description></item>
        /// <item><description>If the number of SSL-VPN connections is 20, we recommend that you specify a client CIDR block with a subnet mask that is less than or equal to 25 bits in length. Examples: 10.0.0.0/25 and 10.0.0.0/24.</description></item>
        /// <item><description>If the number of SSL-VPN connections is 50, we recommend that you specify a client CIDR block with a subnet mask that is less than or equal to 24 bits in length. Examples: 10.0.0.0/24 and 10.0.0.0/23.</description></item>
        /// <item><description>If the number of SSL-VPN connections is 100, we recommend that you specify a client CIDR block with a subnet mask that is less than or equal to 23 bits in length. Examples: 10.0.0.0/23 and 10.0.0.0/22.</description></item>
        /// <item><description>If the number of SSL-VPN connections is 200, we recommend that you specify a client CIDR block with a subnet mask that is less than or equal to 22 bits in length. Examples: 10.0.0.0/22 and 10.0.0.0/21.</description></item>
        /// <item><description>If the number of SSL-VPN connections is 500, we recommend that you specify a client CIDR block with a subnet mask that is less than or equal to 21 bits in length. Examples: 10.0.0.0/21 and 10.0.0.0/20.</description></item>
        /// <item><description>If the number of SSL-VPN connections is 1,000, we recommend that you specify a client CIDR block with a subnet mask that is less than or equal to 20 bits in length. Examples: 10.0.0.0/20 and 10.0.0.0/19.</details></description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The subnet mask of the client CIDR block must be 16 to 29 bits in length.</description></item>
        /// <item><description>Make sure that the local CIDR block and the client CIDR block do not overlap with each other.</description></item>
        /// <item><description>We recommend that you use 10.0.0.0/8, 172.16.0.0/12, 192.168.0.0/16, or one of their subnets as the client CIDR block. If you want to specify a public CIDR block as the client CIDR block, you must specify the public CIDR block as the user CIDR block of the virtual private cloud (VPC). This way, the VPC can access the public CIDR block. For more information, see <a href="https://help.aliyun.com/document_detail/185311.html">VPC FAQ</a>.</description></item>
        /// <item><description>After you create an SSL server, the system automatically adds routes that point to the client CIDR block to the VPC route table, which is not displayed in the console by default. Do not add routes that point to the client CIDR block to the VPC route table again. Otherwise, SSL-VPN connections cannot work as expected.</description></item>
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
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the <b>request ID</b> as the <b>client token</b>. The <b>request ID</b> may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-0016e04115b</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable data compression. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b> (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Compress")]
        [Validation(Required=false)]
        public bool? Compress { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable two-factor authentication. To enable two-factor authentication, you need to specify <c>IDaaSInstanceId</c>, <c>IDaaSRegionId</c>, and <c>IDaaSApplicationId</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b> (default)</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If you use two-factor authentication for the first time, you need to complete <a href="https://ram.console.aliyun.com/role/authorization?request=%7B%22Services%22%3A%5B%7B%22Service%22%3A%22VPN%22%2C%22Roles%22%3A%5B%7B%22RoleName%22%3A%22AliyunVpnAccessingIdaasRole%22%2C%22TemplateId%22%3A%22IdaasRole%22%7D%5D%7D%5D%2C%22ReturnUrl%22%3A%22https%3A%2F%2Fvpc.console.aliyun.com%2Fsslvpn%2Fcn-shanghai%2Fvpn-servers%22%7D">authorization</a> before you create an SSL server.</para>
        /// </description></item>
        /// <item><description><para>IDaaS EIAM 1.0 instances are no longer available for purchase. If your Alibaba Cloud account has IDaaS EIAM 1.0 instances, IDaaS EIAM 1.0 instances can be associated after two-factor authentication is enabled. If your Alibaba Cloud account does not have IDaaS EIAM 1.0 instances, only IDaaS EIAM 2.0 instances can be associated after two-factor authentication is enabled.</para>
        /// </description></item>
        /// </list>
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
        /// <item><description>If an IDaaS EIAM 2.0 instance is associated, you need to specify an IDaaS application ID.</description></item>
        /// <item><description>If an IDaaS EIAM 1.0 instance is associated, you do not need to specify an IDaaS application ID.</description></item>
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
        /// <para>It is the CIDR block that your client needs to access by using the SSL-VPN connection.</para>
        /// <para>This value can be the CIDR block of a VPC, a vSwitch, a data center that is connected to a VPC by using an Express Connect circuit, or an Alibaba Cloud service such as Object Storage Service (OSS).</para>
        /// <para>The subnet mask of the specified local CIDR block must be 8 to 32 bits in length. You cannot specify the following CIDR blocks as the local CIDR blocks:</para>
        /// <list type="bullet">
        /// <item><description>100.64.0.0~100.127.255.255</description></item>
        /// <item><description>127.0.0.0~127.255.255.255</description></item>
        /// <item><description>169.254.0.0~169.254.255.255</description></item>
        /// <item><description>224.0.0.0~239.255.255.255</description></item>
        /// <item><description>255.0.0.0~255.255.255.255</description></item>
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
        /// <para>The SSL server name.</para>
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
        /// <para>The port that is used by the SSL server. Valid values of port numbers: <b>1</b> to <b>65535</b>. Default value: <b>1194</b>.</para>
        /// <para>The following ports are not supported: <b>22</b>, <b>2222</b>, <b>22222</b>, <b>9000</b>, <b>9001</b>, <b>9002</b>, <b>7505</b>, <b>80</b>, <b>443</b>, <b>53</b>, <b>68</b>, <b>123</b>, <b>4510</b>, <b>4560</b>, <b>500</b>, and <b>4500</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1194</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// <para>The protocol that is used by the SSL server. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>TCP</b> (default)</description></item>
        /// <item><description><b>UDP</b></description></item>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
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
