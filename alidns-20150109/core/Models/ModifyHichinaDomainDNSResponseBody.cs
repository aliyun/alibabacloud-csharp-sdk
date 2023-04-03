// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class ModifyHichinaDomainDNSResponseBody : TeaModel {
        /// <summary>
        /// The list of DNS servers after the domain name is changed.
        /// </summary>
        [NameInMap("NewDnsServers")]
        [Validation(Required=false)]
        public ModifyHichinaDomainDNSResponseBodyNewDnsServers NewDnsServers { get; set; }
        public class ModifyHichinaDomainDNSResponseBodyNewDnsServers : TeaModel {
            [NameInMap("DnsServer")]
            [Validation(Required=false)]
            public List<string> DnsServer { get; set; }

        }

        /// <summary>
        /// The list of DNS servers before the domain name is changed.
        /// </summary>
        [NameInMap("OriginalDnsServers")]
        [Validation(Required=false)]
        public ModifyHichinaDomainDNSResponseBodyOriginalDnsServers OriginalDnsServers { get; set; }
        public class ModifyHichinaDomainDNSResponseBodyOriginalDnsServers : TeaModel {
            [NameInMap("DnsServer")]
            [Validation(Required=false)]
            public List<string> DnsServer { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
