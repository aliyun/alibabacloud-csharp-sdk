// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class ListRoomUsersResponseBody : TeaModel {
        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// API请求的返回结果结构体。
        /// </summary>
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
                public Dictionary<string, string> Extension { get; set; }
                public string Nick { get; set; }
                public string UserId { get; set; }
            }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

    }

}
