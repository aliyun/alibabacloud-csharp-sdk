// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class AccessTokenResponseBody : TeaModel {
        /// <summary>
        /// 错误码
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public AccessTokenResponseBodyData Data { get; set; }
        public class AccessTokenResponseBodyData : TeaModel {
            [NameInMap("expire")]
            [Validation(Required=false)]
            public long? Expire { get; set; }
            [NameInMap("token")]
            [Validation(Required=false)]
            public string Token { get; set; }
        };

        /// <summary>
        /// 错误信息
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
