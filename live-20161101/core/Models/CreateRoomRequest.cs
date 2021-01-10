// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class CreateRoomRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("RoomId")]
        [Validation(Required=false)]
        public string RoomId { get; set; }

        [NameInMap("AnchorId")]
        [Validation(Required=false)]
        public string AnchorId { get; set; }

        [NameInMap("TemplateIds")]
        [Validation(Required=false)]
        public string TemplateIds { get; set; }

        [NameInMap("UseAppTranscode")]
        [Validation(Required=false)]
        public bool? UseAppTranscode { get; set; }

    }

}
