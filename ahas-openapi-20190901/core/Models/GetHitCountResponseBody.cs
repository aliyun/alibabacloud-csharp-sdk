// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ahas_openapi20190901.Models
{
    public class GetHitCountResponseBody : TeaModel {
        [NameInMap("Hits")]
        [Validation(Required=false)]
        public List<GetHitCountResponseBodyHits> Hits { get; set; }
        public class GetHitCountResponseBodyHits : TeaModel {
            [NameInMap("HostIp")]
            [Validation(Required=false)]
            public string HostIp { get; set; }

            [NameInMap("Count")]
            [Validation(Required=false)]
            public float? Count { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
