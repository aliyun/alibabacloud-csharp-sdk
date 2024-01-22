// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class CustomDNS : TeaModel {
        [NameInMap("dnsOptions")]
        [Validation(Required=false)]
        public List<DNSOption> DnsOptions { get; set; }

        [NameInMap("nameServers")]
        [Validation(Required=false)]
        public List<string> NameServers { get; set; }

        [NameInMap("searches")]
        [Validation(Required=false)]
        public List<string> Searches { get; set; }

    }

}
