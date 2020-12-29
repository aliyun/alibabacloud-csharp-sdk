// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateDomainRecordRequest : TeaModel {
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

        [NameInMap("RecordId")]
        [Validation(Required=false)]
        public string RecordId { get; set; }

        [NameInMap("RR")]
        [Validation(Required=false)]
        public string RR { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        [NameInMap("TTL")]
        [Validation(Required=false)]
        public long? TTL { get; set; }

        [NameInMap("Priority")]
        [Validation(Required=false)]
        public long? Priority { get; set; }

        [NameInMap("Line")]
        [Validation(Required=false)]
        public string Line { get; set; }

    }

}
