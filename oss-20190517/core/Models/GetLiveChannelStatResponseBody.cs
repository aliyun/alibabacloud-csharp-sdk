// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class GetLiveChannelStatResponseBody : TeaModel {
        [NameInMap("Audio")]
        [Validation(Required=false)]
        public LiveChannelAudio Audio { get; set; }

        [NameInMap("ConnectedTime")]
        [Validation(Required=false)]
        public string ConnectedTime { get; set; }

        [NameInMap("RemoteAddr")]
        [Validation(Required=false)]
        public string RemoteAddr { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Video")]
        [Validation(Required=false)]
        public LiveChannelVideo Video { get; set; }

    }

}
