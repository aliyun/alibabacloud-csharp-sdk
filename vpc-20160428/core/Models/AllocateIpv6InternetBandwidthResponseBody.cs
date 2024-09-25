// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class AllocateIpv6InternetBandwidthResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the Internet bandwidth that you purchased for the IPv6 gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipv6bw-uf6hcyzu65v98v3du****</para>
        /// </summary>
        [NameInMap("InternetBandwidthId")]
        [Validation(Required=false)]
        public string InternetBandwidthId { get; set; }

        /// <summary>
        /// <para>The ID of the IPv6 address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipv6-2zen5j4axcp5l5qyy****</para>
        /// </summary>
        [NameInMap("Ipv6AddressId")]
        [Validation(Required=false)]
        public string Ipv6AddressId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6972A26E-99B1-4367-9890-FBDEBB0F5E7D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
