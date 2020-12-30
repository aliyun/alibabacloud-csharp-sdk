// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class GetConversationListResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Conversations")]
        [Validation(Required=false)]
        public List<GetConversationListResponseBodyConversations> Conversations { get; set; }
        public class GetConversationListResponseBodyConversations : TeaModel {
            [NameInMap("Summary")]
            [Validation(Required=false)]
            public List<GetConversationListResponseBodyConversationsSummary> Summary { get; set; }
            public class GetConversationListResponseBodyConversationsSummary : TeaModel {
                [NameInMap("SummaryName")]
                [Validation(Required=false)]
                public string SummaryName { get; set; }

                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

            }

            [NameInMap("Speaker")]
            [Validation(Required=false)]
            public string Speaker { get; set; }

            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

            [NameInMap("Script")]
            [Validation(Required=false)]
            public string Script { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
