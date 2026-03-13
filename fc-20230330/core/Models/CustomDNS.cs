// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class CustomDNS : TeaModel {
        /// <summary>
        /// <para>The DNS resolution configurations in the resolv.conf file. Each item corresponds to a key-value pair in the key:value format, in which the key is required.</para>
        /// </summary>
        [NameInMap("dnsOptions")]
        [Validation(Required=false)]
        public List<DNSOption> DnsOptions { get; set; }

        /// <summary>
        /// <para>The IP addresses of the DNS server.</para>
        /// </summary>
        [NameInMap("nameServers")]
        [Validation(Required=false)]
        public List<string> NameServers { get; set; }

        /// <summary>
        /// <para>The search domains of DNS server.</para>
        /// </summary>
        [NameInMap("searches")]
        [Validation(Required=false)]
        public List<string> Searches { get; set; }

    }

}
