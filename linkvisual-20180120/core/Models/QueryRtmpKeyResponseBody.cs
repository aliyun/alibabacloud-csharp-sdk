// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20180120.Models
{
    public class QueryRtmpKeyResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryRtmpKeyResponseBodyData Data { get; set; }
        public class QueryRtmpKeyResponseBodyData : TeaModel {
            [NameInMap("PullAuthKey")]
            [Validation(Required=false)]
            public string PullAuthKey { get; set; }

            [NameInMap("PullKeyExpireTime")]
            [Validation(Required=false)]
            public int? PullKeyExpireTime { get; set; }

            [NameInMap("PushAuthKey")]
            [Validation(Required=false)]
            public string PushAuthKey { get; set; }

            [NameInMap("PushKeyExpireTime")]
            [Validation(Required=false)]
            public int? PushKeyExpireTime { get; set; }

            [NameInMap("StreamName")]
            [Validation(Required=false)]
            public string StreamName { get; set; }

        }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
