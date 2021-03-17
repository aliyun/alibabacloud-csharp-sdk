// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageenhan20190930.Models
{
    public class AssessCompositionResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public AssessCompositionResponseBodyData Data { get; set; }
        public class AssessCompositionResponseBodyData : TeaModel {
            [NameInMap("Score")]
            [Validation(Required=false)]
            public float? Score { get; set; }
        };

    }

}
