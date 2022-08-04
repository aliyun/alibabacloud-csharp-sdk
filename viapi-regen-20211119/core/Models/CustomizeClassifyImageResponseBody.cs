// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Viapi_regen20211119.Models
{
    public class CustomizeClassifyImageResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CustomizeClassifyImageResponseBodyData Data { get; set; }
        public class CustomizeClassifyImageResponseBodyData : TeaModel {
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }
            [NameInMap("Score")]
            [Validation(Required=false)]
            public float? Score { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
