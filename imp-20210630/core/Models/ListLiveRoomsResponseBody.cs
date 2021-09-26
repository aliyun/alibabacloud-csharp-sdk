// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class ListLiveRoomsResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 创建场景化直播返回的结果。
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListLiveRoomsResponseBodyResult Result { get; set; }
        public class ListLiveRoomsResponseBodyResult : TeaModel {
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
            [NameInMap("PageTotal")]
            [Validation(Required=false)]
            public int? PageTotal { get; set; }
            [NameInMap("HasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }
            [NameInMap("LiveList")]
            [Validation(Required=false)]
            public List<ListLiveRoomsResponseBodyResultLiveList> LiveList { get; set; }
            public class ListLiveRoomsResponseBodyResultLiveList : TeaModel {
                public string AppId { get; set; }
                public string LiveId { get; set; }
                public int? Status { get; set; }
                public string RoomId { get; set; }
                public string ChatId { get; set; }
                public string Title { get; set; }
                public string Notice { get; set; }
                public string CoverUrl { get; set; }
                public string AnchorId { get; set; }
                public long? Uv { get; set; }
                public Dictionary<string, string> Extension { get; set; }
                public string AnchorNick { get; set; }
            }
        };

    }

}
