// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class ModifyHichinaDomainDNSResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("NewDnsServers")]
        [Validation(Required=false)]
        public ModifyHichinaDomainDNSResponseBodyNewDnsServers NewDnsServers { get; set; }
        public class ModifyHichinaDomainDNSResponseBodyNewDnsServers : TeaModel {
            [NameInMap("DnsServer")]
            [Validation(Required=false)]
            public List<string> DnsServer { get; set; }
        };

        [NameInMap("OriginalDnsServers")]
        [Validation(Required=false)]
        public ModifyHichinaDomainDNSResponseBodyOriginalDnsServers OriginalDnsServers { get; set; }
        public class ModifyHichinaDomainDNSResponseBodyOriginalDnsServers : TeaModel {
            [NameInMap("DnsServer")]
            [Validation(Required=false)]
            public List<string> DnsServer { get; set; }
        };

    }

}
