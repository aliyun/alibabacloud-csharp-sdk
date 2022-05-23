// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220517.Models
{
    public class TakeAccessTokenResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public TakeAccessTokenResponseBodyData Data { get; set; }
        public class TakeAccessTokenResponseBodyData : TeaModel {
            [NameInMap("access_token")]
            [Validation(Required=false)]
            public string AccessToken { get; set; }
            [NameInMap("expire")]
            [Validation(Required=false)]
            public long? Expire { get; set; }
        };

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
