// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imagerecog20190930.Models
{
    public class DetectFruitsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectFruitsResponseBodyData Data { get; set; }
        public class DetectFruitsResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<DetectFruitsResponseBodyDataElements> Elements { get; set; }
            public class DetectFruitsResponseBodyDataElements : TeaModel {
                public float? Score { get; set; }
                public List<string> Box { get; set; }
                public string Name { get; set; }
            }
        };

    }

}
