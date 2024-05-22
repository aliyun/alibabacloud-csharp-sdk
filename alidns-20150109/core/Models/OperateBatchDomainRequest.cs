// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class OperateBatchDomainRequest : TeaModel {
        /// <summary>
        /// The DNS records. You can submit up to 1000 DNS records.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DomainRecordInfo")]
        [Validation(Required=false)]
        public List<OperateBatchDomainRequestDomainRecordInfo> DomainRecordInfo { get; set; }
        public class OperateBatchDomainRequestDomainRecordInfo : TeaModel {
            /// <summary>
            /// The domain name.
            /// 
            /// >  You can submit 1 to 1,000 domain names. Due to the limit on the length of HTTP request headers, excessive domain names are ignored. Do not enter more than 1,000 domain names.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// The resolution line. Default value: default.
            /// </summary>
            [NameInMap("Line")]
            [Validation(Required=false)]
            public string Line { get; set; }

            [NameInMap("NewRr")]
            [Validation(Required=false)]
            public string NewRr { get; set; }

            [NameInMap("NewType")]
            [Validation(Required=false)]
            public string NewType { get; set; }

            [NameInMap("NewValue")]
            [Validation(Required=false)]
            public string NewValue { get; set; }

            /// <summary>
            /// The priority of the mail exchanger (MX) record.
            /// 
            /// This parameter is required if the type of the DNS record is MX. Default value: 10.
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// The hostname.
            /// 
            /// >  This parameter is required if you set Type to **RR_ADD** or **RR_DEL**.
            /// </summary>
            [NameInMap("Rr")]
            [Validation(Required=false)]
            public string Rr { get; set; }

            /// <summary>
            /// The time-to-live (TTL) value of the cached DNS record. Unit: seconds. Default value: ***600***.
            /// </summary>
            [NameInMap("Ttl")]
            [Validation(Required=false)]
            public int? Ttl { get; set; }

            /// <summary>
            /// The type of the DNS record. Valid values: A, AAAA, TXT, MX, and CNAME.
            /// 
            /// >  This parameter is required if you set Type to **RR_ADD** or **RR_DEL**.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The record value.
            /// 
            /// >  This parameter is required if you set Type to **RR_ADD** or **RR_DEL**.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The language.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The type of the batch operation. Valid values:
        /// 
        /// *   **DOMAIN_ADD**: adds domain names in batches.
        /// *   **DOMAIN_DEL**: deletes domain names in batches.
        /// *   **RR_ADD**: adds DNS records in batches.
        /// *   **RR_DEL**: deletes DNS records in batches. This operation deletes the DNS records with the specified hostname or record value. If you do not specify the Rr and Value parameters, this operation deletes the DNS records that are added for the specified domain names.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
