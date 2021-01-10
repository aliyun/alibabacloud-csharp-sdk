// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeForbidPushStreamRoomListResponseBody : TeaModel {
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RoomList")]
        [Validation(Required=false)]
        public List<DescribeForbidPushStreamRoomListResponseBodyRoomList> RoomList { get; set; }
        public class DescribeForbidPushStreamRoomListResponseBodyRoomList : TeaModel {
            [NameInMap("OpEndTime")]
            [Validation(Required=false)]
            public string OpEndTime { get; set; }

            [NameInMap("AnchorId")]
            [Validation(Required=false)]
            public string AnchorId { get; set; }

            [NameInMap("OpStartTime")]
            [Validation(Required=false)]
            public string OpStartTime { get; set; }

            [NameInMap("RoomId")]
            [Validation(Required=false)]
            public string RoomId { get; set; }

        }

    }

}
