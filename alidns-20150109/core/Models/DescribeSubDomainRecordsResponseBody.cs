// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeSubDomainRecordsResponseBody : TeaModel {
        /// <summary>
        /// The list of DNS records returned.
        /// </summary>
        [NameInMap("DomainRecords")]
        [Validation(Required=false)]
        public DescribeSubDomainRecordsResponseBodyDomainRecords DomainRecords { get; set; }
        public class DescribeSubDomainRecordsResponseBodyDomainRecords : TeaModel {
            [NameInMap("Record")]
            [Validation(Required=false)]
            public List<DescribeSubDomainRecordsResponseBodyDomainRecordsRecord> Record { get; set; }
            public class DescribeSubDomainRecordsResponseBodyDomainRecordsRecord : TeaModel {
                /// <summary>
                /// The domain name.
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// The resolution line.
                /// </summary>
                [NameInMap("Line")]
                [Validation(Required=false)]
                public string Line { get; set; }

                /// <summary>
                /// Indicates whether the DNS record is locked.
                /// </summary>
                [NameInMap("Locked")]
                [Validation(Required=false)]
                public bool? Locked { get; set; }

                /// <summary>
                /// The priority of the MX record.
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public long? Priority { get; set; }

                /// <summary>
                /// The hostname.
                /// </summary>
                [NameInMap("RR")]
                [Validation(Required=false)]
                public string RR { get; set; }

                /// <summary>
                /// The ID of the DNS record.
                /// </summary>
                [NameInMap("RecordId")]
                [Validation(Required=false)]
                public string RecordId { get; set; }

                /// <summary>
                /// The description of the DNS record.
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// The status of the DNS record.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The Time-to-Live (TTL) of the DNS record.
                /// </summary>
                [NameInMap("TTL")]
                [Validation(Required=false)]
                public long? TTL { get; set; }

                /// <summary>
                /// The type of the DNS record.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The record value.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                /// <summary>
                /// The weight of the DNS record.
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

        }

        /// <summary>
        /// The number of the returned page.
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
        /// The total number of DNS records returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
