// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class CreateRoomRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=true)]
        public string AppId { get; set; }

        [NameInMap("RoomId")]
        [Validation(Required=true)]
        public string RoomId { get; set; }

        [NameInMap("AnchorId")]
        [Validation(Required=true)]
        public string AnchorId { get; set; }

        [NameInMap("TemplateIds")]
        [Validation(Required=false)]
        public string TemplateIds { get; set; }

        [NameInMap("UseAppTranscode")]
        [Validation(Required=false)]
        public bool? UseAppTranscode { get; set; }

    }

}
