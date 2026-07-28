// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class UpdateIpsecServerRequest : TeaModel {
        /// <summary>
        /// <para>The client CIDR block, which is the CIDR block from which IP addresses are assigned to virtual network interface controllers (NICs) of the client.</para>
        /// <remarks>
        /// <para>The client CIDR block cannot conflict with the VPC CIDR block.</para>
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
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> may be different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: performs a dry run without modifying the IPsec server configuration. The system checks the required parameters, request format, and service limits. If the check fails, the corresponding error message is returned. If the check succeeds, <c>DryRunOperation</c> is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): performs a dry run and sends the request. After the check succeeds, the IPsec server configuration is modified.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public string DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether to delete the currently negotiated IPsec tunnel and re-initiate negotiation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Negotiation is initiated immediately after the configuration is complete.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Negotiation is initiated when inbound traffic is detected.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EffectImmediately")]
        [Validation(Required=false)]
        public bool? EffectImmediately { get; set; }

        /// <summary>
        /// <para>The Phase 1 negotiation parameter settings. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>IkeVersion</b>: The version of the IKE protocol. Valid values: <b>ikev1</b> or <b>ikev2</b>.</para>
        /// </description></item>
        /// <item><description><para><b>IkeMode</b>: The negotiation pattern of the IKE version. Default value: <b>main</b>.</para>
        /// </description></item>
        /// <item><description><para><b>IkeEncAlg</b>: The encryption algorithm used in Phase 1 negotiations. Default value: <b>aes</b>.</para>
        /// </description></item>
        /// <item><description><para><b>IkeAuthAlg</b>: The authentication algorithm used in Phase 1 negotiations. Default value: <b>sha1</b>.</para>
        /// </description></item>
        /// <item><description><para><b>IkePfs</b>: The Diffie-Hellman key exchange algorithm used in Phase 1 negotiations. Default value: <b>group2</b>.</para>
        /// </description></item>
        /// <item><description><para><b>IkeLifetime</b>: The epoch of the SA negotiated in Phase 1. Unit: seconds. Valid values: <b>0</b> to <b>86400</b>. Default value: <b>86400</b>.</para>
        /// </description></item>
        /// <item><description><para><b>LocalId</b>: The identity of the IPsec server. FQDN and IP address formats are supported.</para>
        /// </description></item>
        /// <item><description><para><b>RemoteId</b>: The identity of the peer. FQDN and IP address formats are supported.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;IkeVersion&quot;:&quot;ikev2&quot;,&quot;IkeMode&quot;:&quot;main&quot;,&quot;IkeEncAlg&quot;:&quot;aes&quot;,&quot;IkeAuthAlg&quot;:&quot;sha1&quot;,&quot;IkePfs&quot;:&quot;group2&quot;,&quot;IkeLifetime&quot;:86400}</para>
        /// </summary>
        [NameInMap("IkeConfig")]
        [Validation(Required=false)]
        public string IkeConfig { get; set; }

        /// <summary>
        /// <para>The Phase 2 negotiation parameter settings. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>IpsecEncAlg</b>: The encryption algorithm used in Phase 2 negotiations. Default value: <b>aes</b>.</para>
        /// </description></item>
        /// <item><description><para><b>IpsecAuthAlg</b>: The authentication algorithm used in Phase 2 negotiations. Default value: <b>sha1</b>.</para>
        /// </description></item>
        /// <item><description><para><b>IpsecPfs</b>: Forward all protocol packets. The Diffie-Hellman key exchange algorithm used in Phase 2 negotiations. Default value: <b>group2</b>.</para>
        /// </description></item>
        /// <item><description><para><b>IpsecLifetime</b>: The epoch of the SA negotiated in Phase 2. Unit: seconds. Valid values: <b>0</b> to <b>86400</b>. Default value: <b>86400</b>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;IpsecEncAlg&quot;:&quot;aes&quot;,&quot;IpsecAuthAlg&quot;:&quot;sha1&quot;,&quot;IpsecPfs&quot;:&quot;group2&quot;,&quot;IpsecLifetime&quot;:86400}</para>
        /// </summary>
        [NameInMap("IpsecConfig")]
        [Validation(Required=false)]
        public string IpsecConfig { get; set; }

        /// <summary>
        /// <para>The ID of the IPsec server.</para>
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
        /// <para>The name must be 1 to 100 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("IpsecServerName")]
        [Validation(Required=false)]
        public string IpsecServerName { get; set; }

        /// <summary>
        /// <para>The local CIDR block, which is the CIDR block on the VPC side that needs to communicate with the client CIDR block.</para>
        /// <para>Separate multiple CIDR blocks with commas (,). Example: 192.168.1.0/24,192.168.2.0/24.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.0/24,172.17.0.0/16</para>
        /// </summary>
        [NameInMap("LocalSubnet")]
        [Validation(Required=false)]
        public string LocalSubnet { get; set; }

        /// <summary>
        /// <para>The pre-shared key.</para>
        /// <para>The pre-shared key is used for identity authentication between the IPsec server and the client. The key must be 1 to 100 characters in length.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2794120.html">ListIpsecServers</a> operation to query the key generated by the system.</para>
        /// <remarks>
        /// <para>The pre-shared key of the IPsec server must be the same as the authentication key of the client. Otherwise, a connection cannot be established between the IPsec server and the client.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Cfd123****</para>
        /// </summary>
        [NameInMap("Psk")]
        [Validation(Required=false)]
        public string Psk { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable pre-shared key authentication. Valid values: <b>true</b>, which indicates that pre-shared key authentication is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("PskEnabled")]
        [Validation(Required=false)]
        public bool? PskEnabled { get; set; }

        /// <summary>
        /// <para>The region ID of the IPsec server.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the region ID.</para>
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
