// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListWaitingChatsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListWaitingChatsResponseBodyData> Data { get; set; }
        public class ListWaitingChatsResponseBodyData : TeaModel {
            [NameInMap("AccessChannelId")]
            [Validation(Required=false)]
            public string AccessChannelId { get; set; }

            [NameInMap("AccessChannelType")]
            [Validation(Required=false)]
            public string AccessChannelType { get; set; }

            [NameInMap("BeingAssigned")]
            [Validation(Required=false)]
            public bool? BeingAssigned { get; set; }

            [NameInMap("ChatConversationId")]
            [Validation(Required=false)]
            public string ChatConversationId { get; set; }

            [NameInMap("EnqueueTime")]
            [Validation(Required=false)]
            public long? EnqueueTime { get; set; }

            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            [NameInMap("Messages")]
            [Validation(Required=false)]
            public List<ListWaitingChatsResponseBodyDataMessages> Messages { get; set; }
            public class ListWaitingChatsResponseBodyDataMessages : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("SenderId")]
                [Validation(Required=false)]
                public string SenderId { get; set; }

                [NameInMap("SenderType")]
                [Validation(Required=false)]
                public string SenderType { get; set; }

            }

            [NameInMap("SkillGroupId")]
            [Validation(Required=false)]
            public string SkillGroupId { get; set; }

            [NameInMap("UserList")]
            [Validation(Required=false)]
            public List<ListWaitingChatsResponseBodyDataUserList> UserList { get; set; }
            public class ListWaitingChatsResponseBodyDataUserList : TeaModel {
                [NameInMap("AvatarUrl")]
                [Validation(Required=false)]
                public string AvatarUrl { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

                [NameInMap("UserType")]
                [Validation(Required=false)]
                public string UserType { get; set; }

            }

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
