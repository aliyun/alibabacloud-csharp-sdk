// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class GetClassDetailResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetClassDetailResponseBodyResult Result { get; set; }
        public class GetClassDetailResponseBodyResult : TeaModel {
            [NameInMap("ClassId")]
            [Validation(Required=false)]
            public string ClassId { get; set; }

            [NameInMap("ConfId")]
            [Validation(Required=false)]
            public string ConfId { get; set; }

            [NameInMap("CreateNickname")]
            [Validation(Required=false)]
            public string CreateNickname { get; set; }

            [NameInMap("CreateUserId")]
            [Validation(Required=false)]
            public string CreateUserId { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("LiveId")]
            [Validation(Required=false)]
            public string LiveId { get; set; }

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

            [NameInMap("WhiteboardId")]
            [Validation(Required=false)]
            public string WhiteboardId { get; set; }

            [NameInMap("WhiteboardRecordId")]
            [Validation(Required=false)]
            public string WhiteboardRecordId { get; set; }

        }

    }

}
