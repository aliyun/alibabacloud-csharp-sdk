// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudGameAPI20200728.Models
{
    public class StartGameLiveShrinkRequest : TeaModel {
        [NameInMap("Extension")]
        [Validation(Required=false)]
        public string ExtensionShrink { get; set; }

        [NameInMap("GameSession")]
        [Validation(Required=false)]
        public string GameSession { get; set; }

        [NameInMap("VideoPushAddress")]
        [Validation(Required=false)]
        public string VideoPushAddress { get; set; }

    }

}
