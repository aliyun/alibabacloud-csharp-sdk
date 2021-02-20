// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class CreateChannelResponseBody : TeaModel {
        [NameInMap("Nonce")]
        [Validation(Required=false)]
        public string Nonce { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ChannelKey")]
        [Validation(Required=false)]
        public string ChannelKey { get; set; }

        [NameInMap("Timestamp")]
        [Validation(Required=false)]
        public int? Timestamp { get; set; }

    }

}
