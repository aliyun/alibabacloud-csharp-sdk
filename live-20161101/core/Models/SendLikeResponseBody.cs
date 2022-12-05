// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class SendLikeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public SendLikeResponseBodyResult Result { get; set; }
        public class SendLikeResponseBodyResult : TeaModel {
            [NameInMap("LikeCount")]
            [Validation(Required=false)]
            public int? LikeCount { get; set; }

        }

    }

}
