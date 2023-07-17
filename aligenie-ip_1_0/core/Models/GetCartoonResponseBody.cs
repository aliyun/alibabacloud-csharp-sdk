// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class GetCartoonResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetCartoonResponseBodyResult Result { get; set; }
        public class GetCartoonResponseBodyResult : TeaModel {
            [NameInMap("StartVideoMd5")]
            [Validation(Required=false)]
            public string StartVideoMd5 { get; set; }

            [NameInMap("StartVideoUrl")]
            [Validation(Required=false)]
            public string StartVideoUrl { get; set; }

        }

        [NameInMap("StatusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

    }

}
