// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeAuditLogConfigResponseBody : TeaModel {
        [NameInMap("DbAudit")]
        [Validation(Required=false)]
        public string DbAudit { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Retention")]
        [Validation(Required=false)]
        public string Retention { get; set; }

    }

}
