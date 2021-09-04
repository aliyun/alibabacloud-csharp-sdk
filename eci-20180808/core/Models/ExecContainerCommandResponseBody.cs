// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class ExecContainerCommandResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("WebSocketUri")]
        [Validation(Required=false)]
        public string WebSocketUri { get; set; }

        [NameInMap("HttpUrl")]
        [Validation(Required=false)]
        public string HttpUrl { get; set; }

        [NameInMap("SyncResponse")]
        [Validation(Required=false)]
        public string SyncResponse { get; set; }

    }

}
