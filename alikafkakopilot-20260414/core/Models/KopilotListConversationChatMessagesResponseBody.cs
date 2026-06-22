// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AlikafkaKopilot20260414.Models
{
    public class KopilotListConversationChatMessagesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public KopilotListConversationChatMessagesResponseBodyData Data { get; set; }
        public class KopilotListConversationChatMessagesResponseBodyData : TeaModel {
            [NameInMap("HasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("Messages")]
            [Validation(Required=false)]
            public List<KopilotListConversationChatMessagesResponseBodyDataMessages> Messages { get; set; }
            public class KopilotListConversationChatMessagesResponseBodyDataMessages : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Feedback")]
                [Validation(Required=false)]
                public string Feedback { get; set; }

                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                [NameInMap("TurnId")]
                [Validation(Required=false)]
                public string TurnId { get; set; }

            }

            [NameInMap("NextBeforeTurnId")]
            [Validation(Required=false)]
            public long? NextBeforeTurnId { get; set; }

            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            [NameInMap("TotalTurns")]
            [Validation(Required=false)]
            public long? TotalTurns { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
