// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class DescribeMessageResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public DescribeMessageResponseBodyMessage Message { get; set; }
        public class DescribeMessageResponseBodyMessage : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }
            [NameInMap("AppKey")]
            [Validation(Required=false)]
            public string AppKey { get; set; }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }
            [NameInMap("SendStatus")]
            [Validation(Required=false)]
            public int? SendStatus { get; set; }
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }
            [NameInMap("Desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }
            [NameInMap("Uri")]
            [Validation(Required=false)]
            public string Uri { get; set; }
            [NameInMap("Parameter")]
            [Validation(Required=false)]
            public string Parameter { get; set; }
            [NameInMap("PredictSendCnt")]
            [Validation(Required=false)]
            public int? PredictSendCnt { get; set; }
            [NameInMap("AckCnt")]
            [Validation(Required=false)]
            public int? AckCnt { get; set; }
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public long? GmtCreateTime { get; set; }
            [NameInMap("ExipiredTime")]
            [Validation(Required=false)]
            public long? ExipiredTime { get; set; }
            [NameInMap("Audit")]
            [Validation(Required=false)]
            public int? Audit { get; set; }
            [NameInMap("AuditMsg")]
            [Validation(Required=false)]
            public string AuditMsg { get; set; }
        };

    }

}
