// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudGameAPI20200728.Models
{
    public class GetOutAccountBindDetailResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetOutAccountBindDetailResponseBodyData Data { get; set; }
        public class GetOutAccountBindDetailResponseBodyData : TeaModel {
            [NameInMap("BindStatus")]
            [Validation(Required=false)]
            public int? BindStatus { get; set; }
            [NameInMap("OutAccountId")]
            [Validation(Required=false)]
            public string OutAccountId { get; set; }
            [NameInMap("OutAccountType")]
            [Validation(Required=false)]
            public string OutAccountType { get; set; }
            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }
            [NameInMap("TokenExpireTime")]
            [Validation(Required=false)]
            public long? TokenExpireTime { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
