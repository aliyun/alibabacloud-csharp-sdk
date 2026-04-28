// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240529.Models
{
    public class GetMemoryHealthResponseBody : TeaModel {
        [NameInMap("latency")]
        [Validation(Required=false)]
        public int? Latency { get; set; }

        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public GetMemoryHealthResponseBodyResult Result { get; set; }
        public class GetMemoryHealthResponseBodyResult : TeaModel {
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
