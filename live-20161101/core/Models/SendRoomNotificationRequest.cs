// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class SendRoomNotificationRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=true)]
        public string AppId { get; set; }

        [NameInMap("RoomId")]
        [Validation(Required=true)]
        public string RoomId { get; set; }

        [NameInMap("AppUid")]
        [Validation(Required=false)]
        public string AppUid { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public string Data { get; set; }

        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

    }

}
