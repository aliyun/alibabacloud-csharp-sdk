// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class AllocateIpv6AddressResponseBody : TeaModel {
        /// <summary>
        /// <para>The IPv6 address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2408:XXXX:153:3921:851c:c435:7b12:1c5f</para>
        /// </summary>
        [NameInMap("Ipv6Address")]
        [Validation(Required=false)]
        public string Ipv6Address { get; set; }

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
        /// <para>54B48E3D-DF70-471B-AA93-08E683A1B45</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxazdjdhd****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
