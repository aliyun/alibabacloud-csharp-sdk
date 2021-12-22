// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudGameAPI20200728.Models
{
    public class CreateTokenResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateTokenResponseBodyData Data { get; set; }
        public class CreateTokenResponseBodyData : TeaModel {
            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
