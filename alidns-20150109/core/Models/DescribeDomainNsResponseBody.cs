// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDomainNsResponseBody : TeaModel {
        [NameInMap("AllAliDns")]
        [Validation(Required=false)]
        public bool? AllAliDns { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ExpectDnsServers")]
        [Validation(Required=false)]
        public List<string> ExpectDnsServers { get; set; }

        [NameInMap("DnsServers")]
        [Validation(Required=false)]
        public List<string> DnsServers { get; set; }

        [NameInMap("IncludeAliDns")]
        [Validation(Required=false)]
        public bool? IncludeAliDns { get; set; }

    }

}
