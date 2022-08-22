// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class PublishLiveResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public PublishLiveResponseBodyResult Result { get; set; }
        public class PublishLiveResponseBodyResult : TeaModel {
            [NameInMap("AnchorId")]
            [Validation(Required=false)]
            public string AnchorId { get; set; }
            [NameInMap("LiveId")]
            [Validation(Required=false)]
            public string LiveId { get; set; }
            [NameInMap("LiveUrl")]
            [Validation(Required=false)]
            public string LiveUrl { get; set; }
            [NameInMap("PushUrl")]
            [Validation(Required=false)]
            public string PushUrl { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
        };

    }

}
