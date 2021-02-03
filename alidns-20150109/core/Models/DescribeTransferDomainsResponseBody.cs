// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeTransferDomainsResponseBody : TeaModel {
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

        [NameInMap("DomainTransfers")]
        [Validation(Required=false)]
        public DescribeTransferDomainsResponseBodyDomainTransfers DomainTransfers { get; set; }
        public class DescribeTransferDomainsResponseBodyDomainTransfers : TeaModel {
            [NameInMap("DomainTransfer")]
            [Validation(Required=false)]
            public List<DescribeTransferDomainsResponseBodyDomainTransfersDomainTransfer> DomainTransfer { get; set; }
            public class DescribeTransferDomainsResponseBodyDomainTransfersDomainTransfer : TeaModel {
                public long? FromUserId { get; set; }
                public string CreateTime { get; set; }
                public long? TargetUserId { get; set; }
                public string DomainName { get; set; }
                public long? Id { get; set; }
                public long? CreateTimestamp { get; set; }
            }
        };

    }

}
