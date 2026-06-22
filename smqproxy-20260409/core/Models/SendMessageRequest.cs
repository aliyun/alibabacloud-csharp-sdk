// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SMQProxy20260409.Models
{
    public class SendMessageRequest : TeaModel {
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

        [NameInMap("UserProperties")]
        [Validation(Required=false)]
        public string UserProperties { get; set; }

    }

}
