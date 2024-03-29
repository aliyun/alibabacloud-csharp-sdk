// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class CorpTokenResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public CorpTokenResponseBodyData Data { get; set; }
        public class CorpTokenResponseBodyData : TeaModel {
            [NameInMap("expire")]
            [Validation(Required=false)]
            public long? Expire { get; set; }

            [NameInMap("token")]
            [Validation(Required=false)]
            public string Token { get; set; }

        }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public CorpTokenResponseBodyModule Module { get; set; }
        public class CorpTokenResponseBodyModule : TeaModel {
            [NameInMap("expire")]
            [Validation(Required=false)]
            public long? Expire { get; set; }

            [NameInMap("start")]
            [Validation(Required=false)]
            public long? Start { get; set; }

            [NameInMap("token")]
            [Validation(Required=false)]
            public string Token { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// traceId
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
