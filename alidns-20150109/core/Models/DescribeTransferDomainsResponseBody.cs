// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeTransferDomainsResponseBody : TeaModel {
        /// <summary>
        /// The list of domain names that were transferred between accounts.
        /// </summary>
        [NameInMap("DomainTransfers")]
        [Validation(Required=false)]
        public DescribeTransferDomainsResponseBodyDomainTransfers DomainTransfers { get; set; }
        public class DescribeTransferDomainsResponseBodyDomainTransfers : TeaModel {
            [NameInMap("DomainTransfer")]
            [Validation(Required=false)]
            public List<DescribeTransferDomainsResponseBodyDomainTransfersDomainTransfer> DomainTransfer { get; set; }
            public class DescribeTransferDomainsResponseBodyDomainTransfersDomainTransfer : TeaModel {
                /// <summary>
                /// The time when the task for transferring domain names was created.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The UNIX timestamp representing when the task for transferring domain names was created.
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

                /// <summary>
                /// The ID of the user from which the domain name was transferred.
                /// </summary>
                [NameInMap("FromUserId")]
                [Validation(Required=false)]
                public long? FromUserId { get; set; }

                /// <summary>
                /// The ID of the domain name that was transferred.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The ID of the user to which the domain name was transferred.
                /// </summary>
                [NameInMap("TargetUserId")]
                [Validation(Required=false)]
                public long? TargetUserId { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
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
        /// The total number of domain names.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
