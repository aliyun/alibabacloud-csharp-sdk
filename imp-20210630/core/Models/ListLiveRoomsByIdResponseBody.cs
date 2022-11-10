// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class ListLiveRoomsByIdResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListLiveRoomsByIdResponseBodyResult Result { get; set; }
        public class ListLiveRoomsByIdResponseBodyResult : TeaModel {
            [NameInMap("LiveList")]
            [Validation(Required=false)]
            public List<ListLiveRoomsByIdResponseBodyResultLiveList> LiveList { get; set; }
            public class ListLiveRoomsByIdResponseBodyResultLiveList : TeaModel {
                [NameInMap("AnchorId")]
                [Validation(Required=false)]
                public string AnchorId { get; set; }

                [NameInMap("AnchorNick")]
                [Validation(Required=false)]
                public string AnchorNick { get; set; }

                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                [NameInMap("ChatId")]
                [Validation(Required=false)]
                public string ChatId { get; set; }

                [NameInMap("CoverUrl")]
                [Validation(Required=false)]
                public string CoverUrl { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                [NameInMap("Extension")]
                [Validation(Required=false)]
                public Dictionary<string, string> Extension { get; set; }

                [NameInMap("LiveId")]
                [Validation(Required=false)]
                public string LiveId { get; set; }

                [NameInMap("Notice")]
                [Validation(Required=false)]
                public string Notice { get; set; }

                [NameInMap("OnlineCount")]
                [Validation(Required=false)]
                public long? OnlineCount { get; set; }

                [NameInMap("Pv")]
                [Validation(Required=false)]
                public long? Pv { get; set; }

                [NameInMap("RoomId")]
                [Validation(Required=false)]
                public string RoomId { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("Uv")]
                [Validation(Required=false)]
                public long? Uv { get; set; }

            }

        }

    }

}
