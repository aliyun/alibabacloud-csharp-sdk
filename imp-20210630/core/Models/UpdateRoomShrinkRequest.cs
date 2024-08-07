// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class UpdateRoomShrinkRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("Extension")]
        [Validation(Required=false)]
        public string ExtensionShrink { get; set; }

        [NameInMap("Notice")]
        [Validation(Required=false)]
        public string Notice { get; set; }

        [NameInMap("RoomId")]
        [Validation(Required=false)]
        public string RoomId { get; set; }

        [NameInMap("RoomOwnerId")]
        [Validation(Required=false)]
        public string RoomOwnerId { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
