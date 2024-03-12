// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class InsertInterveneGlobalReplyRequest : TeaModel {
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        [NameInMap("ReplyMessagList")]
        [Validation(Required=false)]
        public List<InsertInterveneGlobalReplyRequestReplyMessagList> ReplyMessagList { get; set; }
        public class InsertInterveneGlobalReplyRequestReplyMessagList : TeaModel {
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("ReplyType")]
            [Validation(Required=false)]
            public string ReplyType { get; set; }

        }

    }

}
