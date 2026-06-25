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
        /// <item><description><para>If the client uses Tunnelblick or OpenVPN 2.4.0 or later, the SSL server and the client dynamically negotiate the encryption algorithm and preferentially use the encryption algorithm with the highest security level that is supported by both parties. The encryption algorithm that you specify for the SSL server does not take effect.</para>
        /// </description></item>
        /// <item><description><para>If the client uses OpenVPN earlier than 2.4.0, the SSL server and the client use the encryption algorithm that you specify for the SSL server. The SSL server supports the following encryption algorithms:</para>
        /// <list type="bullet">
        /// <item><description><para><b>AES-128-CBC</b> (default): AES-128-CBC algorithm.</para>
        /// </description></item>
        /// <item><description><para><b>AES-192-CBC</b>: AES-192-CBC algorithm.</para>
        /// </description></item>
        /// <item><description><para><b>AES-256-CBC</b>: AES-256-CBC algorithm.</para>
        /// </description></item>
        /// <item><description><para><b>none</b>: no encryption algorithm is used.</para>
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
        /// <para>The client CIDR block is used to allocate IP addresses to virtual network interface controllers (NICs) of clients. It does not refer to the existing internal network CIDR block of the client.</para>
        /// <para>When a client accesses the local network through an SSL-VPN connection, the VPN gateway allocates an IP address from the specified client CIDR block to the client. The client uses the allocated IP address to access cloud resources.</para>
        /// <para>When you specify the client CIDR block, make sure that the number of IP addresses in the client CIDR block is at least four times the number of SSL-VPN connections supported by the VPN gateway.</para>
        /// <details>
        /// <summary>Click to view the reason</summary>
        /// 
        /// <para>For example, if you specify 192.168.0.0/24 as the client CIDR block, the system first divides a subnet with a 30-bit subnet mask from the 192.168.0.0/24 CIDR block, such as 192.168.0.4/30, and then allocates one IP address from 192.168.0.4/30 to the client. The remaining three IP addresses are used by the system to ensure network communication. In this case, one client consumes four IP addresses. Therefore, to ensure that all clients can be allocated IP addresses, make sure that the number of IP addresses in the client CIDR block is at least four times the number of SSL-VPN connections supported by the VPN gateway.</para>
        /// </details>
        /// 
        /// <details>
        /// <summary>Click to view unsupported CIDR blocks</summary>
        /// 
        /// <list type="bullet">
        /// <item><description>100.64.0.0 to 100.127.255.255</description></item>
        /// <item><description>127.0.0.0 to 127.255.255.255</description></item>
        /// <item><description>169.254.0.0 to 169.254.255.255</description></item>
        /// <item><description>224.0.0.0 to 239.255.255.255</description></item>
        /// <item><description>255.0.0.0 to 255.255.255.255</details></description></item>
        /// </list>
        /// <details>
        /// <summary>Click to view recommended client CIDR blocks for each number of SSL-VPN connections</summary>
        /// 
        /// <list type="bullet">
        /// <item><description>If the number of SSL-VPN connections is 5, the subnet mask of the client CIDR block must be 27 bits or less. Example: 10.0.0.0/27 or 10.0.0.0/26.</description></item>
        /// <item><description>If the number of SSL-VPN connections is 10, the subnet mask of the client CIDR block must be 26 bits or less. Example: 10.0.0.0/26 or 10.0.0.0/25.</description></item>
        /// <item><description>If the number of SSL-VPN connections is 20, the subnet mask of the client CIDR block must be 25 bits or less. Example: 10.0.0.0/25 or 10.0.0.0/24.</description></item>
        /// <item><description>If the number of SSL-VPN connections is 50, the subnet mask of the client CIDR block must be 24 bits or less. Example: 10.0.0.0/24 or 10.0.0.0/23.</description></item>
        /// <item><description>If the number of SSL-VPN connections is 100, the subnet mask of the client CIDR block must be 23 bits or less. Example: 10.0.0.0/23 or 10.0.0.0/22.</description></item>
        /// <item><description>If the number of SSL-VPN connections is 200, the subnet mask of the client CIDR block must be 22 bits or less. Example: 10.0.0.0/22 or 10.0.0.0/21.</description></item>
        /// <item><description>If the number of SSL-VPN connections is 500, the subnet mask of the client CIDR block must be 21 bits or less. Example: 10.0.0.0/21 or 10.0.0.0/20.</description></item>
        /// <item><description>If the number of SSL-VPN connections is 1000, the subnet mask of the client CIDR block must be 20 bits or less. Example: 10.0.0.0/20 or 10.0.0.0/19.</description></item>
        /// </list>
        /// </details>
        /// 
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The subnet mask of the client CIDR block must be 16 to 29 bits.</description></item>
        /// <item><description>Make sure that the client CIDR block does not overlap with the local CIDR block, the virtual private cloud (VPC) CIDR block, or any routing CIDR block associated with the client terminal.</description></item>
        /// <item><description>When you specify the client CIDR block, use 10.0.0.0/8, 172.16.0.0/12, 192.168.0.0/16, or their subnets. If you want to specify a public CIDR block as the client CIDR block, set the public CIDR block as a user CIDR block of the VPC to ensure that the VPC can access the public CIDR block. For more information about user CIDR blocks, see <a href="https://help.aliyun.com/document_detail/185311.html">VPC FAQ</a>.</description></item>
        /// <item><description>After the SSL server is created, the system automatically adds the routing of the client CIDR block to the route table of the VPC instance. Do not manually add the routing of the client CIDR block to the route table of the VPC instance. Otherwise, SSL-VPN connection traffic may be abnormal.</description></item>
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
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> may be different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-0016e04115b</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to compress communication data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: compresses communication data.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): does not compress communication data.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Compress")]
        [Validation(Required=false)]
        public bool? Compress { get; set; }

        [NameInMap("DnsServers")]
        [Validation(Required=false)]
        public string DnsServers { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: performs a dry run without performing the actual request. The system checks the required parameters, request syntax, and limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): performs a dry run and performs the actual request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable two-factor authentication. If you enable two-factor authentication, you must also configure <c>IDaaSInstanceId</c>, <c>IDaaSRegionId</c>, and <c>IDaaSApplicationId</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: enabled.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): disabled.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you use two-factor authentication for the first time, complete <a href="https://ram.console.aliyun.com/role/authorization?request=%7B%22Services%22%3A%5B%7B%22Service%22%3A%22VPN%22%2C%22Roles%22%3A%5B%7B%22RoleName%22%3A%22AliyunVpnAccessingIdaasRole%22%2C%22TemplateId%22%3A%22IdaasRole%22%7D%5D%7D%5D%2C%22ReturnUrl%22%3A%22https%3A%2F%2Fvpc.console.aliyun.com%2Fsslvpn%2Fcn-shanghai%2Fvpn-servers%22%7D">authorization</a> before creating the SSL server.</description></item>
        /// <item><description>When you create an SSL server in the UAE (Dubai) region, bind an IDaaS EIAM 2.0 instance in the Singapore region to reduce cross-region latency.</description></item>
        /// <item><description>IDaaS EIAM 1.0 instances are no longer available for purchase. If your Alibaba Cloud account has IDaaS EIAM 1.0 instances, you can still bind IDaaS EIAM 1.0 instances after enabling two-factor authentication. If your Alibaba Cloud account does not have IDaaS EIAM 1.0 instances, you can bind only IDaaS EIAM 2.0 instances after enabling two-factor authentication.</description></item>
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
        /// <item><description>If you bind an IDaaS EIAM 2.0 instance, enter the IDaaS application ID.</description></item>
        /// <item><description>If you bind an IDaaS EIAM 1.0 instance, you do not need to enter the IDaaS application ID.</description></item>
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
        /// <para>The local CIDR block is the CIDR block that the client needs to access through the SSL-VPN connection.</para>
        /// <para>The local CIDR block can be the CIDR block of a VPC, the CIDR block of a vSwitch, the CIDR block of an on-premises data center that is connected to a VPC through an Express Connect circuit, or the CIDR block of a cloud service such as Object Storage Service (OSS).</para>
        /// <para>The subnet mask of the local CIDR block must be 8 to 32 bits. The following CIDR blocks cannot be specified as the local CIDR block:</para>
        /// <list type="bullet">
        /// <item><description>127.0.0.0 to 127.255.255.255</description></item>
        /// <item><description>169.254.0.0 to 169.254.255.255</description></item>
        /// <item><description>224.0.0.0 to 239.255.255.255</description></item>
        /// <item><description>255.0.0.0 to 255.255.255.255.</description></item>
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
        /// <para>The name of the SSL server.</para>
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
        /// <para>The port used by the SSL server. Valid values: <b>1</b> to <b>65535</b>. Default value: <b>1194</b>.</para>
        /// <para>The following ports are not supported: <b>22</b>, <b>2222</b>, <b>22222</b>, <b>9000</b>, <b>9001</b>, <b>9002</b>, <b>7505</b>, <b>80</b>, <b>443</b>, <b>53</b>, <b>68</b>, <b>123</b>, <b>4510</b>, <b>4560</b>, <b>500</b>, or <b>4500</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1194</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// <para>The protocol used by the SSL server. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>TCP</b> (default): TCP protocol.</description></item>
        /// <item><description><b>UDP</b>: UDP protocol.</description></item>
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
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> to query the most recent region list.</para>
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
