// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class ListRoomLivesResponseBody : TeaModel {
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
        public ListRoomLivesResponseBodyResult Result { get; set; }
        public class ListRoomLivesResponseBodyResult : TeaModel {
            [NameInMap("HasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }
            [NameInMap("LiveList")]
            [Validation(Required=false)]
            public List<ListRoomLivesResponseBodyResultLiveList> LiveList { get; set; }
            public class ListRoomLivesResponseBodyResultLiveList : TeaModel {
                public string AppId { get; set; }
                public Dictionary<string, string> Extension { get; set; }
                public string LiveId { get; set; }
                public string Notice { get; set; }
                public long? OnlineCount { get; set; }
                public long? Pv { get; set; }
                public string RoomId { get; set; }
                public string RoomOwnerId { get; set; }
                public int? Status { get; set; }
                public string Title { get; set; }
                public long? Uv { get; set; }
            }
            [NameInMap("NextQueryTimestamp")]
            [Validation(Required=false)]
            public long? NextQueryTimestamp { get; set; }
        };

    }

}
