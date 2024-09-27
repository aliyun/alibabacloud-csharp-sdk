// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class ModifyHichinaDomainDNSResponseBody : TeaModel {
        /// <summary>
        /// <para>The DNS server names after modification.</para>
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
        /// <para>The DNS server names before modification.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>536E9CAD-DB30-4647-AC87-AA5CC38C5382</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
