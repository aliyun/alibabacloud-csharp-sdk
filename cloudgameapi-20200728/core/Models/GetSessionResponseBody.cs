// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudGameAPI20200728.Models
{
    public class GetSessionResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSessionResponseBodyData Data { get; set; }
        public class GetSessionResponseBodyData : TeaModel {
            [NameInMap("Session")]
            [Validation(Required=false)]
            public string Session { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
