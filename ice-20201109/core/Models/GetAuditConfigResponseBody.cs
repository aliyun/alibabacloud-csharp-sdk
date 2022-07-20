// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetAuditConfigResponseBody : TeaModel {
        [NameInMap("Audit")]
        [Validation(Required=false)]
        public GetAuditConfigResponseBodyAudit Audit { get; set; }
        public class GetAuditConfigResponseBodyAudit : TeaModel {
            [NameInMap("Channel")]
            [Validation(Required=false)]
            public string Channel { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }
            [NameInMap("LegalSwitch")]
            [Validation(Required=false)]
            public string LegalSwitch { get; set; }
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
