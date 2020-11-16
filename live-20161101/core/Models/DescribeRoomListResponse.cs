// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeRoomListResponse : TeaModel {
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
        public List<DescribeRoomListResponseRoomList> RoomList { get; set; }
        public class DescribeRoomListResponseRoomList : TeaModel {
            [NameInMap("RoomId")]
            [Validation(Required=true)]
            public string RoomId { get; set; }

            [NameInMap("AnchorId")]
            [Validation(Required=true)]
            public string AnchorId { get; set; }

            [NameInMap("RoomStatus")]
            [Validation(Required=true)]
            public int? RoomStatus { get; set; }

            [NameInMap("ForbidStream")]
            [Validation(Required=true)]
            public string ForbidStream { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=true)]
            public string CreateTime { get; set; }

        }

    }

}
