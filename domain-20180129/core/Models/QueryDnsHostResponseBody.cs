// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryDnsHostResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DnsHostList")]
        [Validation(Required=false)]
        public List<QueryDnsHostResponseBodyDnsHostList> DnsHostList { get; set; }
        public class QueryDnsHostResponseBodyDnsHostList : TeaModel {
            [NameInMap("DnsName")]
            [Validation(Required=false)]
            public string DnsName { get; set; }

            [NameInMap("IpList")]
            [Validation(Required=false)]
            public List<string> IpList { get; set; }

        }

    }

}
