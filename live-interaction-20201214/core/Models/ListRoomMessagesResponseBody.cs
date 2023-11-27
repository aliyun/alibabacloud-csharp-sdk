// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class ListRoomMessagesResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResponseSuccess")]
        [Validation(Required=false)]
        public bool? ResponseSuccess { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListRoomMessagesResponseBodyResult Result { get; set; }
        public class ListRoomMessagesResponseBodyResult : TeaModel {
            [NameInMap("HasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("RoomMessageList")]
            [Validation(Required=false)]
            public List<ListRoomMessagesResponseBodyResultRoomMessageList> RoomMessageList { get; set; }
            public class ListRoomMessagesResponseBodyResultRoomMessageList : TeaModel {
                [NameInMap("Body")]
                [Validation(Required=false)]
                public string Body { get; set; }

                [NameInMap("MessageId")]
                [Validation(Required=false)]
                public string MessageId { get; set; }

                [NameInMap("RoomId")]
                [Validation(Required=false)]
                public string RoomId { get; set; }

                [NameInMap("SendTimeMillis")]
                [Validation(Required=false)]
                public long? SendTimeMillis { get; set; }

                [NameInMap("SenderId")]
                [Validation(Required=false)]
                public string SenderId { get; set; }

                [NameInMap("SubType")]
                [Validation(Required=false)]
                public int? SubType { get; set; }

            }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

    }

}
