// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyVpnGatewayAttributeRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the automatic route propagation feature for the VPN gateway. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: enables the feature.</para>
        /// <para>  After automatic route propagation is enabled, the VPN gateway instance automatically learns system routes in the system route table of the VPC and automatically propagates routes of the on-premises data center to the system route table of the VPC.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: disables the feature.</para>
        /// <para>  Before you disable automatic route propagation, make sure that the BGP dynamic route feature is disabled for all IPsec-VPN connections under the VPN gateway.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPropagate")]
        [Validation(Required=false)]
        public bool? AutoPropagate { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can generate the parameter value on your client to ensure that the value is unique among different requests. The client token only supports ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the RequestId of the API request as the client token. The RequestId of each API request is different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-4266****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The new description of the VPN gateway.  </para>
        /// <para>The description must be 1 to 100 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The new name of the VPN gateway.  </para>
        /// <para>The name must be 2 to 100 characters in length. It cannot start with <c>http://</c> or <c>https://</c>. It must start with a letter and can contain letters, digits, underscores (_), hyphens (-), and periods (.). Other special characters are not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myvpn</para>
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
        /// <para>The region ID of the VPN gateway. You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query region IDs.</para>
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
        /// <para>The ID of the VPN gateway.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpn-bp1q8bgx4xnkm2ogj****</para>
        /// </summary>
        [NameInMap("VpnGatewayId")]
        [Validation(Required=false)]
        public string VpnGatewayId { get; set; }

    }

}
