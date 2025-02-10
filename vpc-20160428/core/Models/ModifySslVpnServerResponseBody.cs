// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifySslVpnServerResponseBody : TeaModel {
        /// <summary>
        /// <para>The encryption algorithm.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AES-128-CBC</para>
        /// </summary>
        [NameInMap("Cipher")]
        [Validation(Required=false)]
        public string Cipher { get; set; }

        /// <summary>
        /// <para>The client CIDR block.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.30.30.0/24</para>
        /// </summary>
        [NameInMap("ClientIpPool")]
        [Validation(Required=false)]
        public string ClientIpPool { get; set; }

        /// <summary>
        /// <para>Indicates whether data compression is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Compress")]
        [Validation(Required=false)]
        public bool? Compress { get; set; }

        /// <summary>
        /// <para>The total number of current connections.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Connections")]
        [Validation(Required=false)]
        public int? Connections { get; set; }

        /// <summary>
        /// <para>The time when the SSL server was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1492753580000</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>Indicates whether two-factor authentication is enabled.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b> (default)</description></item>
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
        /// <para>The version of the IDaaS EIAM instance.</para>
        /// <list type="bullet">
        /// <item><description>This parameter is returned only if the SSL server is associated with an IDaaS EIAM 2.0 instance. Only <b>EIAM 2.0</b> is returned.</description></item>
        /// <item><description>If the SSL server is associated with an IDaaS EIAM 1.0 instance, no value is returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>EIAM 2.0</para>
        /// </summary>
        [NameInMap("IDaaSInstanceVersion")]
        [Validation(Required=false)]
        public string IDaaSInstanceVersion { get; set; }

        /// <summary>
        /// <para>The public IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>47.98.XX.XX</para>
        /// </summary>
        [NameInMap("InternetIp")]
        [Validation(Required=false)]
        public string InternetIp { get; set; }

        /// <summary>
        /// <para>The local CIDR block.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.20.20.0/24</para>
        /// </summary>
        [NameInMap("LocalSubnet")]
        [Validation(Required=false)]
        public string LocalSubnet { get; set; }

        /// <summary>
        /// <para>The maximum number of connections.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("MaxConnections")]
        [Validation(Required=false)]
        public int? MaxConnections { get; set; }

        /// <summary>
        /// <para>The name of the SSL server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The port that is used by the SSL server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1194</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// <para>The protocol that is used by the SSL server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UDP</para>
        /// </summary>
        [NameInMap("Proto")]
        [Validation(Required=false)]
        public string Proto { get; set; }

        /// <summary>
        /// <para>The ID of the region where the SSL server is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DF11D6F6-E35A-41C3-9B20-6FC8A901FE65</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the SSL server belongs.</para>
        /// <para>The SSL server and the VPN gateway associated with the SSL server belong to the same resource group. You can call the <a href="https://help.aliyun.com/document_detail/158855.html">ListResourceGroups</a> operation to query resource groups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzs372yg****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the SSL server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vss-bp18q7hzj6largv4v****</para>
        /// </summary>
        [NameInMap("SslVpnServerId")]
        [Validation(Required=false)]
        public string SslVpnServerId { get; set; }

        /// <summary>
        /// <para>The ID of the VPN gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpn-bp1q8bgx4xnkm2ogj****</para>
        /// </summary>
        [NameInMap("VpnGatewayId")]
        [Validation(Required=false)]
        public string VpnGatewayId { get; set; }

    }

}
