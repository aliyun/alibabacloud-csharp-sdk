// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class GetLiveRoomUserStatisticsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetLiveRoomUserStatisticsResponseBodyResult Result { get; set; }
        public class GetLiveRoomUserStatisticsResponseBodyResult : TeaModel {
            [NameInMap("HasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }
            [NameInMap("LiveId")]
            [Validation(Required=false)]
            public string LiveId { get; set; }
            [NameInMap("PageTotal")]
            [Validation(Required=false)]
            public int? PageTotal { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
            [NameInMap("UserStatisticsList")]
            [Validation(Required=false)]
            public List<GetLiveRoomUserStatisticsResponseBodyResultUserStatisticsList> UserStatisticsList { get; set; }
            public class GetLiveRoomUserStatisticsResponseBodyResultUserStatisticsList : TeaModel {
                public int? CommentCount { get; set; }
                public int? LikeCount { get; set; }
                public string UserId { get; set; }
                public long? WatchLiveTime { get; set; }
            }
        };

    }

}
