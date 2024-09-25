// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class AllocateVpcIpv6CidrResponseBody : TeaModel {
        /// <summary>
        /// <para>The IPv6 CIDR block that is reserved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2408:XXXX:0:a600::/56</para>
        /// </summary>
        [NameInMap("Ipv6CidrBlock")]
        [Validation(Required=false)]
        public string Ipv6CidrBlock { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D20C13EA-2584-53BC-8393-69DE6D98EFF1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
