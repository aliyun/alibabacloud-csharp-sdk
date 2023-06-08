// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafDomainsResponseBody : TeaModel {
        /// <summary>
        /// The protected domain name.
        /// </summary>
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public List<DescribeDcdnWafDomainsResponseBodyDomains> Domains { get; set; }
        public class DescribeDcdnWafDomainsResponseBodyDomains : TeaModel {
            /// <summary>
            /// The header of IP address of the client that is connected to the point of presence (POP).
            /// </summary>
            [NameInMap("ClientIpTag")]
            [Validation(Required=false)]
            public string ClientIpTag { get; set; }

            /// <summary>
            /// The protected domain name.
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// The number of protection policies that were configured for the protected domain name.
            /// </summary>
            [NameInMap("PolicyCount")]
            [Validation(Required=false)]
            public int? PolicyCount { get; set; }

        }

        /// <summary>
        /// The page number of the returned page, which is the same as the PageNumber parameter in request parameters.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of domain names returned per page, which is the same as the PageSize parameter in request parameters.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of protected domain names.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
