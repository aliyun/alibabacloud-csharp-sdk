// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateIpsecServerRequest : TeaModel {
        /// <summary>
        /// <para>The client CIDR block from which an IP address is allocated to the virtual network interface controller (NIC) of the client.</para>
        /// <remarks>
        /// <para> The client CIDR block must not overlap with the CIDR blocks of the VPC.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.0/24</para>
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
        /// <para>d7d24a21-f4ba-4454-9173-b38****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to only precheck this request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: prechecks the request without creating the IPsec server. The system checks the required parameters, request format, and service limits. If the request fails to pass the precheck, an error code is returned. If the request passes the precheck, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): sends the request. This is the default value. If the request passes the precheck, the system creates the IPsec server.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public string DryRun { get; set; }

        /// <summary>
        /// <para>Specify whether to start connection negotiations immediately. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: immediately initiates negotiations after the configuration is complete.</description></item>
        /// <item><description><b>false</b> (default): initiates negotiations when inbound traffic is detected. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EffectImmediately")]
        [Validation(Required=false)]
        public bool? EffectImmediately { get; set; }

        /// <summary>
        /// <para>The configuration of Phase 1 negotiation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>IkeVersion</b>: the IKE version. Valid values: <b>ikev1</b> and <b>ikev2</b>. Default value: <b>ikev2</b>.</description></item>
        /// <item><description><b>IkeMode</b>: the IKE negotiation mode. Default value: <b>main</b>.</description></item>
        /// <item><description><b>IkeEncAlg</b>: the encryption algorithm that is used in Phase 1 negotiation. Default value: <b>aes</b>.</description></item>
        /// <item><description><b>IkeAuthAlg</b>: the authentication algorithm that is used in Phase 1 negotiation. Default value: <b>sha1</b>.</description></item>
        /// <item><description><b>IkePfs</b>: the Diffie-Hellman key exchange algorithm that is used in Phase 1 negotiation. Default value: <b>group2</b>.</description></item>
        /// <item><description><b>IkeLifetime</b>: the security association (SA) lifetime determined by Phase 1 negotiation. Unit: seconds. Valid values: <b>0</b> to <b>86400</b>. Default value: <b>86400</b>.</description></item>
        /// <item><description><b>LocalId</b>: the identifier of the IPsec server. The value can be a fully qualified domain name (FQDN) or an IP address. The default value is the public IP address of the VPN gateway.</description></item>
        /// <item><description><b>RemoteId</b>: the peer identifier. The value can be an FQDN or an IP address. The default value is empty.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;IkeVersion&quot;:&quot;ikev2&quot;,&quot;IkeMode&quot;:&quot;main&quot;,&quot;IkeEncAlg&quot;:&quot;aes&quot;,&quot;IkeAuthAlg&quot;:&quot;sha1&quot;,&quot;IkePfs&quot;:&quot;group2&quot;,&quot;IkeLifetime&quot;:86400}</para>
        /// </summary>
        [NameInMap("IkeConfig")]
        [Validation(Required=false)]
        public string IkeConfig { get; set; }

        /// <summary>
        /// <para>The name of the IPsec server.</para>
        /// <para>The name must be 1 to 100 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("IpSecServerName")]
        [Validation(Required=false)]
        public string IpSecServerName { get; set; }

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
        /// <para>The local CIDR blocks, which are the CIDR blocks of the virtual private cloud (VPC) for the client to access.</para>
        /// <para>Multiple CIDR blocks are separated with commas (,). Example: 192.168.1.0/24,192.168.2.0/24.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.0/24</para>
        /// </summary>
        [NameInMap("LocalSubnet")]
        [Validation(Required=false)]
        public string LocalSubnet { get; set; }

        /// <summary>
        /// <para>The pre-shared key.</para>
        /// <para>The pre-shared key is used for identity authentication between the IPsec server and the client. The key must be 1 to 100 characters in length.</para>
        /// <para>If you do not specify a pre-shared key, the system randomly generates a 16-character string as the pre-shared key. You can call the <a href="https://help.aliyun.com/document_detail/2794120.html">ListIpsecServers</a> operation to query the pre-shared keys that are generated by the system.</para>
        /// <remarks>
        /// <para> The pre-shared key of the IPsec server must be the same as the client key. Otherwise, the IPsec server cannot be connected to the client.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Cfd123****</para>
        /// </summary>
        [NameInMap("Psk")]
        [Validation(Required=false)]
        public string Psk { get; set; }

        /// <summary>
        /// <para>Indicates whether pre-shared key authentication is enabled. If you set the value to <b>true</b>, pre-shared key authentication is enabled.</para>
        /// <remarks>
        /// <para> This parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("PskEnabled")]
        [Validation(Required=false)]
        public bool? PskEnabled { get; set; }

        /// <summary>
        /// <para>The ID of the region where the VPN gateway is deployed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the VPN gateway.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpn-bp17lofy9fd0dnvzv****</para>
        /// </summary>
        [NameInMap("VpnGatewayId")]
        [Validation(Required=false)]
        public string VpnGatewayId { get; set; }

    }

}
