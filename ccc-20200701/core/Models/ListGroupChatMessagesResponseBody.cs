// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListGroupChatMessagesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListGroupChatMessagesResponseBodyData Data { get; set; }
        public class ListGroupChatMessagesResponseBodyData : TeaModel {
            [NameInMap("Messages")]
            [Validation(Required=false)]
            public List<ListGroupChatMessagesResponseBodyDataMessages> Messages { get; set; }
            public class ListGroupChatMessagesResponseBodyDataMessages : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                [NameInMap("Recalled")]
                [Validation(Required=false)]
                public bool? Recalled { get; set; }

                [NameInMap("SenderAvatarUrl")]
                [Validation(Required=false)]
                public string SenderAvatarUrl { get; set; }

                [NameInMap("SenderId")]
                [Validation(Required=false)]
                public string SenderId { get; set; }

                [NameInMap("SenderName")]
                [Validation(Required=false)]
                public string SenderName { get; set; }

                [NameInMap("SenderType")]
                [Validation(Required=false)]
                public string SenderType { get; set; }

                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

            }

            [NameInMap("NextPageToken")]
            [Validation(Required=false)]
            public string NextPageToken { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
