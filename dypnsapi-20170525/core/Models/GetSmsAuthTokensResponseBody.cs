// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class GetSmsAuthTokensResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSmsAuthTokensResponseBodyData Data { get; set; }
        public class GetSmsAuthTokensResponseBodyData : TeaModel {
            [NameInMap("BizToken")]
            [Validation(Required=false)]
            public string BizToken { get; set; }
            [NameInMap("StsAccessKeySecret")]
            [Validation(Required=false)]
            public string StsAccessKeySecret { get; set; }
            [NameInMap("StsAccessKeyId")]
            [Validation(Required=false)]
            public string StsAccessKeyId { get; set; }
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }
            [NameInMap("StsToken")]
            [Validation(Required=false)]
            public string StsToken { get; set; }
        };

    }

}
