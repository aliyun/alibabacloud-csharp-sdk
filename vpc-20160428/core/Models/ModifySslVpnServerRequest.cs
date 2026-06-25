// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifySslVpnServerRequest : TeaModel {
        /// <summary>
        /// <para>The encryption algorithm used by SSL-VPN. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>AES-128-CBC</b> (default): AES-128-CBC algorithm.</para>
        /// </description></item>
        /// <item><description><para><b>AES-192-CBC</b>: AES-192-CBC algorithm.</para>
        /// </description></item>
        /// <item><description><para><b>AES-256-CBC</b>: AES-256-CBC algorithm.</para>
        /// </description></item>
        /// <item><description><para><b>none</b>: No encryption algorithm is used.</para>
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
        /// <para>This is the CIDR block used to allocate IP addresses to the virtual network interface of the client, not the existing internal CIDR block of the client.</para>
        /// <para>When the client accesses the local end through an SSL-VPN connection, the VPN gateway allocates an IP address from the specified client CIDR block to the client. The client uses the allocated IP address to access cloud resources.</para>
        /// <para>When you specify the client CIDR block, make sure that the number of IP addresses in the client CIDR block is at least four times the number of SSL connections of the current VPN gateway.</para>
        /// <details>
        /// <summary>Click to view the reason.</summary>
        /// For example, if the client CIDR block you specify is 192.168.0.0/24, when the system allocates IP addresses to the client, it first divides a subnet with a 30-bit subnet mask from the 192.168.0.0/24 CIDR block, such as 192.168.0.4/30, and then allocates one IP address from 192.168.0.4/30 for the client to use. The remaining three IP addresses are occupied by the system to ensure network communication. In this case, one client consumes 4 IP addresses. Therefore, to ensure that all your clients can be allocated IP addresses, make sure that the number of IP addresses in the client CIDR block you specify is at least four times the number of SSL connections of the VPN gateway.
        /// </details>
        /// 
        /// <details>
        /// <summary>Click to view unsupported CIDR blocks.</summary>
        /// 
        /// <list type="bullet">
        /// <item><description>100.64.0.0~100.127.255.255</description></item>
        /// <item><description>127.0.0.0~127.255.255.255</description></item>
        /// <item><description>169.254.0.0~169.254.255.255</description></item>
        /// <item><description>224.0.0.0~239.255.255.255</description></item>
        /// <item><description>255.0.0.0~255.255.255.255</description></item>
        /// </list>
        /// </details>
        /// 
        /// <details>
        /// <summary>Click to view recommended client CIDR blocks for each SSL connection count.</summary>
        /// 
        /// <list type="bullet">
        /// <item><description>If the number of SSL connections is 5, the subnet mask of the client CIDR block should be less than or equal to 27 bits. For example: 10.0.0.0/27 or 10.0.0.0/26.</description></item>
        /// <item><description>If the number of SSL connections is 10, the subnet mask of the client CIDR block should be less than or equal to 26 bits. For example: 10.0.0.0/26 or 10.0.0.0/25.</description></item>
        /// <item><description>If the number of SSL connections is 20, the subnet mask of the client CIDR block should be less than or equal to 25 bits. For example: 10.0.0.0/25 or 10.0.0.0/24.</description></item>
        /// <item><description>If the number of SSL connections is 50, the subnet mask of the client CIDR block should be less than or equal to 24 bits. For example: 10.0.0.0/24 or 10.0.0.0/23.</description></item>
        /// <item><description>If the number of SSL connections is 100, the subnet mask of the client CIDR block should be less than or equal to 23 bits. For example: 10.0.0.0/23 or 10.0.0.0/22.</description></item>
        /// <item><description>If the number of SSL connections is 200, the subnet mask of the client CIDR block should be less than or equal to 22 bits. For example: 10.0.0.0/22 or 10.0.0.0/21.</description></item>
        /// <item><description>If the number of SSL connections is 500, the subnet mask of the client CIDR block should be less than or equal to 21 bits. For example: 10.0.0.0/21 or 10.0.0.0/20.</description></item>
        /// <item><description>If the number of SSL connections is 1000, the subnet mask of the client CIDR block should be less than or equal to 20 bits. For example: 10.0.0.0/20 or 10.0.0.0/19.</description></item>
        /// </list>
        /// </details>
        /// 
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The subnet mask of the client CIDR block must be between 16 and 29 bits.</description></item>
        /// <item><description>Make sure that the client CIDR block does not overlap with the local subnet, VPC CIDR block, or any route CIDR blocks associated with the client terminal.</description></item>
        /// <item><description>When specifying the client CIDR block, we recommend that you use the 10.0.0.0/8, 172.16.0.0/12, and 192.168.0.0/16 CIDR blocks and their subnets. If you need to specify a public CIDR block as the client CIDR block, you must set the public CIDR block as a user CIDR block of the VPC to ensure that the VPC can access the public CIDR block. For more information about user CIDR blocks, see <a href="https://help.aliyun.com/document_detail/185311.html">VPC FAQ</a>.</description></item>
        /// <item><description>After the SSL server is created, the system automatically adds routes for the client CIDR block to the route table of the VPC instance. Do not manually add routes for the client CIDR block to the route table of the VPC instance. Otherwise, SSL-VPN connection traffic transmission will be abnormal.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10.30.30.0/24</para>
        /// </summary>
        [NameInMap("ClientIpPool")]
        [Validation(Required=false)]
        public string ClientIpPool { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotency of the request.</para>
        /// <para>Generate a parameter value from your client to ensure uniqueness across different requests. ClientToken supports only ASCII characters.</para>
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
        /// <para>Specifies whether to compress the communication. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b> (default): Compresses the communication.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Does not compress the communication.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Compress")]
        [Validation(Required=false)]
        public bool? Compress { get; set; }

        [NameInMap("DnsServers")]
        [Validation(Required=false)]
        public string DnsServers { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run, without actually modifying the configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Sends a check request without modifying the SSL server configuration. The check items include whether all required parameters are specified, request format, and service limits. If the check fails, the corresponding error is returned. If the check passes, the error code <c>DryRunOperation</c> is returned.</description></item>
        /// <item><description><b>false</b> (default): Sends a normal request. After the check passes, an HTTP 2xx status code is returned, and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable two-factor authentication. If you choose to enable two-factor authentication, you also need to configure <b>IDaaSInstanceId</b>, <b>IDaaSRegionId</b>, and <b>IDaaSApplicationId</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Not enabled.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you are using the two-factor authentication feature for the first time, complete the <a href="https://ram.console.aliyun.com/role/authorization?request=%7B%22Services%22%3A%5B%7B%22Service%22%3A%22VPN%22%2C%22Roles%22%3A%5B%7B%22RoleName%22%3A%22AliyunVpnAccessingIdaasRole%22%2C%22TemplateId%22%3A%22IdaasRole%22%7D%5D%7D%5D%2C%22ReturnUrl%22%3A%22https%3A%2F%2Fvpc.console.aliyun.com%2Fsslvpn%2Fcn-shanghai%2Fvpn-servers%22%7D">authorization</a> before creating the SSL server.</description></item>
        /// <item><description>When creating an SSL server in the UAE (Dubai) region, we recommend that you bind an IDaaS EIAM 2.0 instance in the Singapore region to reduce cross-region latency.</description></item>
        /// <item><description>IDaaS EIAM 1.0 instances are no longer available for purchase. If your Alibaba Cloud account has existing IDaaS EIAM 1.0 instances, you can still bind them after enabling two-factor authentication. If your Alibaba Cloud account does not have IDaaS EIAM 1.0 instances, only IDaaS EIAM 2.0 instances can be bound after enabling two-factor authentication.</description></item>
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
        /// <item><description>If you bind an IDaaS EIAM 2.0 instance, you must enter the IDaaS application ID.</description></item>
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
        /// <para>idaas-cn-hangzhou-****</para>
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
        /// <para>The local subnet.</para>
        /// <para>The CIDR block that the client needs to access through the SSL-VPN connection.</para>
        /// <para>The local subnet can be the CIDR block of a VPC, a vSwitch, an IDC interconnected with the VPC through Express Connect, or a cloud service such as Object Storage Service (OSS).</para>
        /// <para>The subnet mask of the local subnet must be between 8 and 32 bits. The following CIDR blocks cannot be specified as local subnets:</para>
        /// <list type="bullet">
        /// <item><description>127.0.0.0~127.255.255.255</description></item>
        /// <item><description>169.254.0.0~169.254.255.255</description></item>
        /// <item><description>224.0.0.0~239.255.255.255</description></item>
        /// <item><description>255.0.0.0~255.255.255.255</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10.20.20.0/24</para>
        /// </summary>
        [NameInMap("LocalSubnet")]
        [Validation(Required=false)]
        public string LocalSubnet { get; set; }

        /// <summary>
        /// <para>The name of the SSL-VPN server.</para>
        /// <para>The name must be 1 to 100 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
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
        /// <item><description><para><b>TCP</b> (default): TCP protocol.</para>
        /// </description></item>
        /// <item><description><para><b>UDP</b>: UDP protocol.</para>
        /// </description></item>
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
        /// <para>The ID of the SSL-VPN server instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vss-bp18q7hzj6largv4v****</para>
        /// </summary>
        [NameInMap("SslVpnServerId")]
        [Validation(Required=false)]
        public string SslVpnServerId { get; set; }

    }

}
