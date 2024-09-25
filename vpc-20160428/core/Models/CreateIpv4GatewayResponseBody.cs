// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateIpv4GatewayResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the IPv4 gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipv4gw-5tsnc6s4ogsedtp3k****</para>
        /// </summary>
        [NameInMap("Ipv4GatewayId")]
        [Validation(Required=false)]
        public string Ipv4GatewayId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F282742B-1BBB-5F63-A3AF-E92EC575A1A6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxazb4ph6aiy****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
