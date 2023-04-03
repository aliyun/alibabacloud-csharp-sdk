// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDohSubDomainStatisticsSummaryResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
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
        /// The statistics list.
        /// </summary>
        [NameInMap("Statistics")]
        [Validation(Required=false)]
        public List<DescribeDohSubDomainStatisticsSummaryResponseBodyStatistics> Statistics { get; set; }
        public class DescribeDohSubDomainStatisticsSummaryResponseBodyStatistics : TeaModel {
            /// <summary>
            /// The number of HTTP requests.
            /// </summary>
            [NameInMap("HttpCount")]
            [Validation(Required=false)]
            public long? HttpCount { get; set; }

            /// <summary>
            /// The number of HTTPS requests.
            /// </summary>
            [NameInMap("HttpsCount")]
            [Validation(Required=false)]
            public long? HttpsCount { get; set; }

            /// <summary>
            /// The number of IP addresses.
            /// </summary>
            [NameInMap("IpCount")]
            [Validation(Required=false)]
            public long? IpCount { get; set; }

            /// <summary>
            /// The subdomain.
            /// </summary>
            [NameInMap("SubDomain")]
            [Validation(Required=false)]
            public string SubDomain { get; set; }

            /// <summary>
            /// Total number of requests.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

            /// <summary>
            /// The number of IPv4-based HTTP requests.
            /// </summary>
            [NameInMap("V4HttpCount")]
            [Validation(Required=false)]
            public long? V4HttpCount { get; set; }

            /// <summary>
            /// The number of IPv4-based HTTPS requests.
            /// </summary>
            [NameInMap("V4HttpsCount")]
            [Validation(Required=false)]
            public long? V4HttpsCount { get; set; }

            /// <summary>
            /// The number of IPv6-based HTTP requests.
            /// </summary>
            [NameInMap("V6HttpCount")]
            [Validation(Required=false)]
            public long? V6HttpCount { get; set; }

            /// <summary>
            /// The number of IPv6-based HTTPS requests.
            /// </summary>
            [NameInMap("V6HttpsCount")]
            [Validation(Required=false)]
            public long? V6HttpsCount { get; set; }

        }

        /// <summary>
        /// Total number of entries returned.
        /// </summary>
        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        /// <summary>
        /// Total number of pages returned.
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
