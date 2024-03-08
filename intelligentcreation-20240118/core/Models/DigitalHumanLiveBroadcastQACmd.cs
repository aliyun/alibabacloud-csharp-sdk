// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240118.Models
{
    public class DigitalHumanLiveBroadcastQACmd : TeaModel {
        [NameInMap("accountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        [NameInMap("history")]
        [Validation(Required=false)]
        public List<DigitalHumanLiveBroadcastQACmdHistory> History { get; set; }
        public class DigitalHumanLiveBroadcastQACmdHistory : TeaModel {
            [NameInMap("bot")]
            [Validation(Required=false)]
            public string Bot { get; set; }

            [NameInMap("user")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

        [NameInMap("question")]
        [Validation(Required=false)]
        public string Question { get; set; }

        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        [NameInMap("stream")]
        [Validation(Required=false)]
        public bool? Stream { get; set; }

        [NameInMap("subAccountId")]
        [Validation(Required=false)]
        public string SubAccountId { get; set; }

    }

}
