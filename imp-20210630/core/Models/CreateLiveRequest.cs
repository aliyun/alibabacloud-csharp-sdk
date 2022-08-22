// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class CreateLiveRequest : TeaModel {
        [NameInMap("AnchorId")]
        [Validation(Required=false)]
        public string AnchorId { get; set; }

        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("CodeLevel")]
        [Validation(Required=false)]
        public int? CodeLevel { get; set; }

        [NameInMap("Introduction")]
        [Validation(Required=false)]
        public string Introduction { get; set; }

        [NameInMap("LiveId")]
        [Validation(Required=false)]
        public string LiveId { get; set; }

        [NameInMap("RoomId")]
        [Validation(Required=false)]
        public string RoomId { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
