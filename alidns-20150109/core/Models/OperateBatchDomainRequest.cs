// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class OperateBatchDomainRequest : TeaModel {
        [NameInMap("DomainRecordInfo")]
        [Validation(Required=false)]
        public List<OperateBatchDomainRequestDomainRecordInfo> DomainRecordInfo { get; set; }
        public class OperateBatchDomainRequestDomainRecordInfo : TeaModel {
            /// <summary>
            /// The resolution line of DNS record N. Default value: default.
            /// 
            /// For more information, see [Resolution line enumeration](https://www.alibabacloud.com/help/zh/doc-detail/29807.htm).
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// The host record corresponding to DNS record N.
            /// 
            /// >  If you set the Type parameter to **RR_ADD**, you must also specify this parameter.
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
            /// The ID of the task.
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// The priority of MX-type DNS record N.
            /// 
            /// This parameter must be specified if the type of the DNS record is MX. Default value: 10.
            /// </summary>
            [NameInMap("Rr")]
            [Validation(Required=false)]
            public string Rr { get; set; }

            /// <summary>
            /// The domain name corresponding to DNS record N.
            /// 
            /// >  N is specified by users. **N** starts from **1**. The maximum value of N is **1000**. Extra data entries are ignored.
            /// </summary>
            [NameInMap("Ttl")]
            [Validation(Required=false)]
            public int? Ttl { get; set; }

            /// <summary>
            /// The value of DNS record N.
            /// 
            /// >  If you set the Type parameter to **RR_ADD**, you must also specify this parameter.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The TTL of DNS record N. Unit: seconds. Default value: **600**.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The type of the batch operation. Valid values:
        /// 
        /// *   **DOMAIN_ADD**: adds domain names in batches.
        /// *   **DOMAIN_DEL**: deletes domain names in batches.
        /// *   **RR_ADD**: adds DNS records in batches.
        /// *   **RR_DEL**: deletes DNS records in batches. (If RR or VALUE exists, DNS records corresponding to the specified RR or VALUE are deleted. If both of them exist, DNS records corresponding to the specified RR and VALUE are deleted. If no RR or VALUE is specified, the DNS records corresponding to the DomainName parameter are deleted.)
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The type of DNS record N. For the DNS record types supported by Alibaba Cloud DNS, see [Resolution record type formats](https://www.alibabacloud.com/help/zh/doc-detail/29805.htm).
        /// 
        /// >  If you set the Type parameter to **RR_ADD**, you must also specify this parameter.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
