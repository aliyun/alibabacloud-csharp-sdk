// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DiagnoseVpnGatewayRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the request ID as the client token. The request ID may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-001****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The configuration when you check the connectivity of the IPsec-VPN connection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PrivateSourceIp</b>: the source IP address used when you check the connectivity of the IPsec-VPN connection. The source IP address must be on the VPC side.</description></item>
        /// <item><description><b>PrivateDestinationIp</b>: the destination IP address used when you check the connectivity of the IPsec-VPN connection. The destination IP address must be on the data center side.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;PrivateSourceIp&quot;:&quot;192.168.1.1&quot;,&quot;PrivateDestinationIp&quot;:&quot;192.168.0.1&quot;}</para>
        /// </summary>
        [NameInMap("IPsecExtendInfo")]
        [Validation(Required=false)]
        public string IPsecExtendInfo { get; set; }

        /// <summary>
        /// <para>The region ID of the VPN gateway.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-qingdao</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource to be diagnosed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vco-uf66xniofskqtuoz1****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The type of the resource.</para>
        /// <para>Set the value to <b>Ipsec</b>, which specifies an IPsec-VPN connection.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IPsec</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The ID of the VPN gateway.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpn-m5efhj0k1p47ctuhl****</para>
        /// </summary>
        [NameInMap("VpnGatewayId")]
        [Validation(Required=false)]
        public string VpnGatewayId { get; set; }

    }

}
