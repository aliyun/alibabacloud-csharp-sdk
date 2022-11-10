// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class ListRoomUsersResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListRoomUsersResponseBodyResult Result { get; set; }
        public class ListRoomUsersResponseBodyResult : TeaModel {
            [NameInMap("HasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("PageTotal")]
            [Validation(Required=false)]
            public int? PageTotal { get; set; }

            [NameInMap("RoomUserList")]
            [Validation(Required=false)]
            public List<ListRoomUsersResponseBodyResultRoomUserList> RoomUserList { get; set; }
            public class ListRoomUsersResponseBodyResultRoomUserList : TeaModel {
                [NameInMap("Extension")]
                [Validation(Required=false)]
                public Dictionary<string, string> Extension { get; set; }

                [NameInMap("Nick")]
                [Validation(Required=false)]
                public string Nick { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

    }

}
