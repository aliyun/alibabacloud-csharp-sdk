// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDeletedDomainsResponseBody : TeaModel {
        /// <summary>
        /// The information about the accelerated domain name.
        /// </summary>
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public DescribeDcdnDeletedDomainsResponseBodyDomains Domains { get; set; }
        public class DescribeDcdnDeletedDomainsResponseBodyDomains : TeaModel {
            [NameInMap("PageData")]
            [Validation(Required=false)]
            public List<DescribeDcdnDeletedDomainsResponseBodyDomainsPageData> PageData { get; set; }
            public class DescribeDcdnDeletedDomainsResponseBodyDomainsPageData : TeaModel {
                /// <summary>
                /// The accelerated domain name.
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// The time when the accelerated domain name was modified. The time follows the ISO 8601 standard in the yyyy-MM-ddThh:mm:ssZ format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page, which is the same as the **PageNumber** parameter in request parameters.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of domain names returned per page, which is the same as the **PageSize** parameter in request parameters.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of domain names returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
