// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnIpaDomainCidrResponseBody : TeaModel {
        /// <summary>
        /// <para>The back-to-origin IPv4 and IPv6 CIDR blocks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;1.1.1.0/24&quot;,&quot;2.2.2.0/24&quot;,&quot;1111:2222:3333:4444:5555:0:0:0/80&quot;]</para>
        /// </summary>
        [NameInMap("Cidr")]
        [Validation(Required=false)]
        public List<string> Cidr { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
