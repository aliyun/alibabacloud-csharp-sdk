// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class IPConfig : TeaModel {
        /// <summary>
        /// <para>The description of the IP rule. The description can be up to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Office network egress address</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The IPv4 address or CIDR block. IPv6 is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>203.0.113.25/32</para>
        /// </summary>
        [NameInMap("ipAddress")]
        [Validation(Required=false)]
        public string IpAddress { get; set; }

    }

}
