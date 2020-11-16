// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveUserDomainsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=true)]
        public long PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public long PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public long TotalCount { get; set; }

        [NameInMap("Domains")]
        [Validation(Required=true)]
        public DescribeLiveUserDomainsResponseDomains Domains { get; set; }
        public class DescribeLiveUserDomainsResponseDomains : TeaModel {
            [NameInMap("PageData")]
            [Validation(Required=true)]
            public List<DescribeLiveUserDomainsResponseDomainsPageData> PageData { get; set; }
            public class DescribeLiveUserDomainsResponseDomainsPageData : TeaModel {
                public string DomainName { get; set; }
                public string Cname { get; set; }
                public string LiveDomainType { get; set; }
                public string GmtCreated { get; set; }
                public string GmtModified { get; set; }
                public string Description { get; set; }
                public string LiveDomainStatus { get; set; }
                public string RegionName { get; set; }
            }
        };

    }

}
