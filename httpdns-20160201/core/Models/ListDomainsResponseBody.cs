// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Httpdns20160201.Models
{
    public class ListDomainsResponseBody : TeaModel {
        [NameInMap("DomainInfos")]
        [Validation(Required=false)]
        public ListDomainsResponseBodyDomainInfos DomainInfos { get; set; }
        public class ListDomainsResponseBodyDomainInfos : TeaModel {
            [NameInMap("DomainInfo")]
            [Validation(Required=false)]
            public List<ListDomainsResponseBodyDomainInfosDomainInfo> DomainInfo { get; set; }
            public class ListDomainsResponseBodyDomainInfosDomainInfo : TeaModel {
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("Resolved")]
                [Validation(Required=false)]
                public long? Resolved { get; set; }

                [NameInMap("Resolved6")]
                [Validation(Required=false)]
                public long? Resolved6 { get; set; }

                [NameInMap("ResolvedHttps")]
                [Validation(Required=false)]
                public long? ResolvedHttps { get; set; }

                [NameInMap("ResolvedHttps6")]
                [Validation(Required=false)]
                public long? ResolvedHttps6 { get; set; }

                [NameInMap("TimeModified")]
                [Validation(Required=false)]
                public long? TimeModified { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
