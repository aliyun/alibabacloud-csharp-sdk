// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class GetTotalPublicUrlResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTotalPublicUrlResponseBodyData Data { get; set; }
        public class GetTotalPublicUrlResponseBodyData : TeaModel {
            [NameInMap("RingPublicUrl")]
            [Validation(Required=false)]
            public string RingPublicUrl { get; set; }
            [NameInMap("PhonePublicUrl")]
            [Validation(Required=false)]
            public string PhonePublicUrl { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
