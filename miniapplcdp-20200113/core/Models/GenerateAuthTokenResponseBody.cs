// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Miniapplcdp20200113.Models
{
    public class GenerateAuthTokenResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GenerateAuthTokenResponseBodyData Data { get; set; }
        public class GenerateAuthTokenResponseBodyData : TeaModel {
            [NameInMap("JwtToken")]
            [Validation(Required=false)]
            public string JwtToken { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
