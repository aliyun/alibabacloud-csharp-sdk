// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20171011.Models
{
    public class ListConversationLogsResponseBody : TeaModel {
        [NameInMap("ChatLogs")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> ChatLogs { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Rounds")]
        [Validation(Required=false)]
        public long? Rounds { get; set; }

    }

}
