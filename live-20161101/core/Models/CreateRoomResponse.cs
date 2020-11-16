// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class CreateRoomResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("AppId")]
        [Validation(Required=true)]
        public string AppId { get; set; }

        [NameInMap("RoomId")]
        [Validation(Required=true)]
        public string RoomId { get; set; }

        [NameInMap("AnchorId")]
        [Validation(Required=true)]
        public string AnchorId { get; set; }

    }

}
