// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveUserDomainsResponseBody : TeaModel {
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public DescribeLiveUserDomainsResponseBodyDomains Domains { get; set; }
        public class DescribeLiveUserDomainsResponseBodyDomains : TeaModel {
            [NameInMap("PageData")]
            [Validation(Required=false)]
            public List<DescribeLiveUserDomainsResponseBodyDomainsPageData> PageData { get; set; }
            public class DescribeLiveUserDomainsResponseBodyDomainsPageData : TeaModel {
                public string GmtCreated { get; set; }
                public string LiveDomainType { get; set; }
                public string LiveDomainStatus { get; set; }
                public string RegionName { get; set; }
                public string Description { get; set; }
                public string Cname { get; set; }
                public string GmtModified { get; set; }
                public string DomainName { get; set; }
            }
        };

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

    }

}
