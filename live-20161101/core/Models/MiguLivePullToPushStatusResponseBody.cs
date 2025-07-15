// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class MiguLivePullToPushStatusResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public MiguLivePullToPushStatusResponseBodyData Data { get; set; }
        public class MiguLivePullToPushStatusResponseBodyData : TeaModel {
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("timestamp")]
        [Validation(Required=false)]
        public string Timestamp { get; set; }

    }

}
