// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class LiveChannelTarget : TeaModel {
        [NameInMap("FragCount")]
        [Validation(Required=false)]
        public long? FragCount { get; set; }

        [NameInMap("FragDuration")]
        [Validation(Required=false)]
        public long? FragDuration { get; set; }

        [NameInMap("PlaylistName")]
        [Validation(Required=false)]
        public string PlaylistName { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
