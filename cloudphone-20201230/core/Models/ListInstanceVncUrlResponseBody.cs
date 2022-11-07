// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudphone20201230.Models
{
    public class ListInstanceVncUrlResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("VncUrl")]
        [Validation(Required=false)]
        public string VncUrl { get; set; }

        [NameInMap("WebRtcToken")]
        [Validation(Required=false)]
        public string WebRtcToken { get; set; }

    }

}
