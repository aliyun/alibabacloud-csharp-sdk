// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class CancelOperationAuditRequest : TeaModel {
        [NameInMap("AuditRecordId")]
        [Validation(Required=false)]
        public long? AuditRecordId { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
