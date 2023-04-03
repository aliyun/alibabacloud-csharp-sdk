// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateDomainRecordRequest : TeaModel {
        /// <summary>
        /// The language type.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The resolution line. Default value: **default**.
        /// </summary>
        [NameInMap("Line")]
        [Validation(Required=false)]
        public string Line { get; set; }

        /// <summary>
        /// The priority of an MX-type DNS record. Valid values: `[1,50]`.
        /// 
        /// This parameter must be specified if the type of the DNS record is MX.
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public long? Priority { get; set; }

        /// <summary>
        /// The host record.
        /// 
        /// For example, to resolve @.example.com, you must set RR to an at sign (@) instead of leaving it blank.
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
        /// The TTL of the resolution. Default value: 600. Unit: seconds.
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
        /// The IP address of the client.
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

        /// <summary>
        /// The value of the DNS record.
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
