// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDNSSLBSubDomainsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("SlbSubDomains")]
        [Validation(Required=false)]
        public List<DescribeDNSSLBSubDomainsResponseBodySlbSubDomains> SlbSubDomains { get; set; }
        public class DescribeDNSSLBSubDomainsResponseBodySlbSubDomains : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("RecordCount")]
            [Validation(Required=false)]
            public long? RecordCount { get; set; }

            [NameInMap("Open")]
            [Validation(Required=false)]
            public bool? Open { get; set; }

            [NameInMap("SubDomain")]
            [Validation(Required=false)]
            public string SubDomain { get; set; }

        }

    }

}
