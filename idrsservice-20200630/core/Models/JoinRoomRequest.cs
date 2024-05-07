// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idrsservice20200630.Models
{
    public class JoinRoomRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("RoomId")]
        [Validation(Required=false)]
        public string RoomId { get; set; }

        [NameInMap("RoomToken")]
        [Validation(Required=false)]
        public string RoomToken { get; set; }

        [NameInMap("StreamId")]
        [Validation(Required=false)]
        public string StreamId { get; set; }

    }

}
