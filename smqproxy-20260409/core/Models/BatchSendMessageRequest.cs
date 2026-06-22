// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SMQProxy20260409.Models
{
    public class BatchSendMessageRequest : TeaModel {
        [NameInMap("Messages")]
        [Validation(Required=false)]
        public List<BatchSendMessageRequestMessages> Messages { get; set; }
        public class BatchSendMessageRequestMessages : TeaModel {
            [NameInMap("DelaySeconds")]
            [Validation(Required=false)]
            public int? DelaySeconds { get; set; }

            [NameInMap("MessageBody")]
            [Validation(Required=false)]
            public string MessageBody { get; set; }

            [NameInMap("MessageGroupId")]
            [Validation(Required=false)]
            public string MessageGroupId { get; set; }

            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

        }

    }

}
