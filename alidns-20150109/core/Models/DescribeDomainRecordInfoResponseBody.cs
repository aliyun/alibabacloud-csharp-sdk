// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDomainRecordInfoResponseBody : TeaModel {
        /// <summary>
        /// The ID of the domain name.
        /// </summary>
        [NameInMap("DomainId")]
        [Validation(Required=false)]
        public string DomainId { get; set; }

        /// <summary>
        /// The domain name.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The ID of the domain name group.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The name of the domain name group.
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// The resolution line.
        /// </summary>
        [NameInMap("Line")]
        [Validation(Required=false)]
        public string Line { get; set; }

        /// <summary>
        /// The lock status of the DNS record. Valid values: true and false.
        /// </summary>
        [NameInMap("Locked")]
        [Validation(Required=false)]
        public bool? Locked { get; set; }

        /// <summary>
        /// The priority of the MX-type DNS record.
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public long? Priority { get; set; }

        /// <summary>
        /// The punycode is only returned for Chinese domain names.
        /// </summary>
        [NameInMap("PunyCode")]
        [Validation(Required=false)]
        public string PunyCode { get; set; }

        /// <summary>
        /// The host record.
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

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The status of the DNS record. Valid values: Enable and Disable.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The TTL of the resolution.
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
        /// The value of the DNS record.
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
