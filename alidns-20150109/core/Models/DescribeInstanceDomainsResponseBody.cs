// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeInstanceDomainsResponseBody : TeaModel {
        /// <summary>
        /// The domain names that are bound to the instance.
        /// </summary>
        [NameInMap("InstanceDomains")]
        [Validation(Required=false)]
        public List<DescribeInstanceDomainsResponseBodyInstanceDomains> InstanceDomains { get; set; }
        public class DescribeInstanceDomainsResponseBodyInstanceDomains : TeaModel {
            /// <summary>
            /// The time when the domain name was bound with the instance.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The UNIX timestamp that indicates when the domain name was bound with the instance.
            /// </summary>
            [NameInMap("CreateTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

            /// <summary>
            /// The domain name.
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

        }

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
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        /// <summary>
        /// The total number of pages returned.
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
