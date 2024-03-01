// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class AddDomainRecordRequest : TeaModel {
        /// <summary>
        /// The domain name.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The language.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The DNS resolution line. Default value: **default**. For more information, see
        /// 
        /// [DNS lines](https://www.alibabacloud.com/help/zh/doc-detail/29807.htm).
        /// </summary>
        [NameInMap("Line")]
        [Validation(Required=false)]
        public string Line { get; set; }

        /// <summary>
        /// The priority of the mail exchanger (MX) record. Valid values: `1 to 50`.
        /// 
        /// This parameter must be specified if the type of the DNS record is MX. A smaller value indicates a higher priority.
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public long? Priority { get; set; }

        /// <summary>
        /// The hostname.
        /// 
        /// For example, if you want to resolve @.example.com, you must set RR to an at sign (@) instead of leaving it empty.
        /// </summary>
        [NameInMap("RR")]
        [Validation(Required=false)]
        public string RR { get; set; }

        /// <summary>
        /// The time-to-live (TTL) of the DNS record. Default value: 600. Unit: seconds. For more information, see
        /// 
        /// [TTL definition](https://www.alibabacloud.com/help/zh/doc-detail/29806.htm).
        /// </summary>
        [NameInMap("TTL")]
        [Validation(Required=false)]
        public long? TTL { get; set; }

        /// <summary>
        /// The type of the DNS record. For more information, see
        /// 
        /// [DNS record types](https://www.alibabacloud.com/help/zh/doc-detail/29805.htm).
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// The IP address of the client.
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

        /// <summary>
        /// The record value.
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
