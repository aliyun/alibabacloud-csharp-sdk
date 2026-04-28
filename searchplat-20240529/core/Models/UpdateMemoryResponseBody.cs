// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240529.Models
{
    public class UpdateMemoryResponseBody : TeaModel {
        [NameInMap("latency")]
        [Validation(Required=false)]
        public int? Latency { get; set; }

        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public UpdateMemoryResponseBodyResult Result { get; set; }
        public class UpdateMemoryResponseBodyResult : TeaModel {
            [NameInMap("memory")]
            [Validation(Required=false)]
            public string Memory { get; set; }

            [NameInMap("memory_id")]
            [Validation(Required=false)]
            public string MemoryId { get; set; }

            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
