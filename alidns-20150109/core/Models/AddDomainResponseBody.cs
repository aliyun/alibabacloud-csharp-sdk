// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class AddDomainResponseBody : TeaModel {
        [NameInMap("DnsServers")]
        [Validation(Required=false)]
        public AddDomainResponseBodyDnsServers DnsServers { get; set; }
        public class AddDomainResponseBodyDnsServers : TeaModel {
            [NameInMap("DnsServer")]
            [Validation(Required=false)]
            public List<string> DnsServer { get; set; }

        }

        [NameInMap("DomainId")]
        [Validation(Required=false)]
        public string DomainId { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        [NameInMap("PunyCode")]
        [Validation(Required=false)]
        public string PunyCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
