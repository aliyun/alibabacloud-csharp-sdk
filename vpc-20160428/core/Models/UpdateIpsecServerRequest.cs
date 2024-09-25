// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class UpdateIpsecServerRequest : TeaModel {
        /// <summary>
        /// <para>The client CIDR block from which an IP address is allocated to the virtual network interface controller (NIC) of the client.</para>
        /// <remarks>
        /// <para> The client CIDR block must not overlap with the CIDR blocks of the VPC.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.0/24</para>
        /// </summary>
        [NameInMap("ClientIpPool")]
        [Validation(Required=false)]
        public string ClientIpPool { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate a value, and you must make sure that each request has a unique token value. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the value of <b>RequestId</b> as the value of <b>ClientToken</b>. The <b>request ID</b> may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to only precheck this request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: prechecks the request without modifying the configurations of the IPsec server. The system checks the required parameters, request format, and service limits. If the request fails to pass the precheck, an error code is returned. If the request passes the precheck, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b>: sends the request. This is the default value. If the request passes the precheck, the system modifies the configurations of the IPsec server.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public string DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether to delete the negotiated IPsec tunnel and initiate the negotiation again. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: immediately initiates negotiations after the configuration is complete.</description></item>
        /// <item><description><b>false</b>: initiates negotiations when inbound traffic is detected.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EffectImmediately")]
        [Validation(Required=false)]
        public bool? EffectImmediately { get; set; }

        /// <summary>
        /// <para>The configuration of Phase 1 negotiations. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>IkeVersion</b>: The IKE version. Valid values: <b>ikev1</b> and <b>ikev2</b>.</description></item>
        /// <item><description><b>IkeMode</b>: The IKE negotiation mode. Default value: <b>main</b>.</description></item>
        /// <item><description><b>IkeEncAlg</b>: the encryption algorithm that is used in Phase 1 negotiation. Default value: <b>aes</b>.</description></item>
        /// <item><description><b>IkeAuthAlg</b>: the authentication algorithm that is used in Phase 1 negotiation. Default value: <b>sha1</b>.</description></item>
        /// <item><description><b>IkePfs</b>: The Diffie-Hellman key exchange algorithm that is used in Phase 1 negotiations. Default value: <b>group2</b>.</description></item>
        /// <item><description><b>IkeLifetime</b>: The SA lifetime determined by Phase 1 negotiations. Unit: seconds. Valid values: <b>0</b> to <b>86400</b>. Default value: <b>86400</b>.</description></item>
        /// <item><description><b>LocalId</b>: The identifier of the IPsec server. Only FQDN and IP address formats are supported.</description></item>
        /// <item><description><b>RemoteId</b>: the peer identifier. Only FQDN and IP address formats are supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;IkeVersion&quot;:&quot;ikev2&quot;,&quot;IkeMode&quot;:&quot;main&quot;,&quot;IkeEncAlg&quot;:&quot;aes&quot;,&quot;IkeAuthAlg&quot;:&quot;sha1&quot;,&quot;IkePfs&quot;:&quot;group2&quot;,&quot;IkeLifetime&quot;:86400}</para>
        /// </summary>
        [NameInMap("IkeConfig")]
        [Validation(Required=false)]
        public string IkeConfig { get; set; }

        /// <summary>
        /// <para>The configuration of Phase 2 negotiation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>IpsecEncAlg</b>: the encryption algorithm that is used in Phase 2 negotiation. Default value: <b>aes</b>.</description></item>
        /// <item><description><b>IpsecAuthAlg</b>: the authentication algorithm that is used in Phase 2 negotiation. Default value: <b>sha1</b>.</description></item>
        /// <item><description><b>IpsecPfs</b>: forwards packets of all protocols. The Diffie-Hellman key exchange algorithm that is used in Phase 2 negotiation. Default value: <b>group2</b>.</description></item>
        /// <item><description><b>IpsecLifetime</b>: the SA lifetime determined by Phase 2 negotiation. Unit: seconds. Valid values: <b>0</b> to <b>86400</b>. Default value: <b>86400</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;IpsecEncAlg&quot;:&quot;aes&quot;,&quot;IpsecAuthAlg&quot;:&quot;sha1&quot;,&quot;IpsecPfs&quot;:&quot;group2&quot;,&quot;IpsecLifetime&quot;:86400}</para>
        /// </summary>
        [NameInMap("IpsecConfig")]
        [Validation(Required=false)]
        public string IpsecConfig { get; set; }

        /// <summary>
        /// <para>The IPsec server ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>iss-bp1bo3xuvcxo7ixll****</para>
        /// </summary>
        [NameInMap("IpsecServerId")]
        [Validation(Required=false)]
        public string IpsecServerId { get; set; }

        /// <summary>
        /// <para>The name of the IPsec server.</para>
        /// <para>It must be 1 to 100 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("IpsecServerName")]
        [Validation(Required=false)]
        public string IpsecServerName { get; set; }

        /// <summary>
        /// <para>The local CIDR blocks, which are the CIDR blocks of the virtual private cloud (VPC) for the client to access.</para>
        /// <para>Multiple CIDR blocks are separated with commas (,). Example: 192.168.1.0/24,192.168.2.0/24.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.0/24,172.17.0.0/16</para>
        /// </summary>
        [NameInMap("LocalSubnet")]
        [Validation(Required=false)]
        public string LocalSubnet { get; set; }

        /// <summary>
        /// <para>The pre-shared key.</para>
        /// <para>The pre-shared key that is used for authentication between the IPsec-VPN server and the client. It must be 1 to 100 characters in length.</para>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/2794120.html">ListIpsecServers</a> to query keys generated by the system.</para>
        /// <remarks>
        /// <para> The pre-shared key of the IPsec server key must be the same as that of the client. Otherwise, the connection between the IPsec server and the client cannot be established.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Cfd123****</para>
        /// </summary>
        [NameInMap("Psk")]
        [Validation(Required=false)]
        public string Psk { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable pre-shared key authentication. If you set the value to <b>true</b>, pre-shared key authentication is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("PskEnabled")]
        [Validation(Required=false)]
        public bool? PskEnabled { get; set; }

        /// <summary>
        /// <para>The ID of the region where the IPsec server is created.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
