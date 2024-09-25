// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateIpsecServerResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the IPsec server was created.</para>
        /// <para>T is used as a delimiter. Z indicates that the time is in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-02-22T03:24:28Z</para>
        /// </summary>
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// <para>The IPsec server ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>iss-bp1jougp8cfsbo8y9****</para>
        /// </summary>
        [NameInMap("IpsecServerId")]
        [Validation(Required=false)]
        public string IpsecServerId { get; set; }

        /// <summary>
        /// <para>The IPsec server name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("IpsecServerName")]
        [Validation(Required=false)]
        public string IpsecServerName { get; set; }

        /// <summary>
        /// <para>The ID of the region where the VPN gateway is deployed.</para>
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
        /// <para>690A967E-D4CD-4B69-8C78-94FE828BA10B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the VPN gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpn-bp17lofy9fd0dnvzv****</para>
        /// </summary>
        [NameInMap("VpnGatewayId")]
        [Validation(Required=false)]
        public string VpnGatewayId { get; set; }

    }

}
