// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class CreateLiveRoomShrinkRequest : TeaModel {
        [NameInMap("AnchorId")]
        [Validation(Required=false)]
        public string AnchorId { get; set; }

        [NameInMap("AnchorNick")]
        [Validation(Required=false)]
        public string AnchorNick { get; set; }

        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("CoverUrl")]
        [Validation(Required=false)]
        public string CoverUrl { get; set; }

        [NameInMap("EnableLinkMic")]
        [Validation(Required=false)]
        public bool? EnableLinkMic { get; set; }

        [NameInMap("Extension")]
        [Validation(Required=false)]
        public string ExtensionShrink { get; set; }

        [NameInMap("Notice")]
        [Validation(Required=false)]
        public string Notice { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
