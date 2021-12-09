// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class PutLiveChannelResponseBody : TeaModel {
        [NameInMap("PlayUrls")]
        [Validation(Required=false)]
        public LiveChannelPlayUrls PlayUrls { get; set; }

        [NameInMap("PublishUrls")]
        [Validation(Required=false)]
        public LiveChannelPublishUrls PublishUrls { get; set; }

    }

}
