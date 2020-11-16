// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeForbidPushStreamRoomListResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("TotalNum")]
        [Validation(Required=true)]
        public int? TotalNum { get; set; }

        [NameInMap("TotalPage")]
        [Validation(Required=true)]
        public int? TotalPage { get; set; }

        [NameInMap("RoomList")]
        [Validation(Required=true)]
        public List<DescribeForbidPushStreamRoomListResponseRoomList> RoomList { get; set; }
        public class DescribeForbidPushStreamRoomListResponseRoomList : TeaModel {
            [NameInMap("RoomId")]
            [Validation(Required=true)]
            public string RoomId { get; set; }

            [NameInMap("AnchorId")]
            [Validation(Required=true)]
            public string AnchorId { get; set; }

            [NameInMap("OpStartTime")]
            [Validation(Required=true)]
            public string OpStartTime { get; set; }

            [NameInMap("OpEndTime")]
            [Validation(Required=true)]
            public string OpEndTime { get; set; }

        }

    }

}
