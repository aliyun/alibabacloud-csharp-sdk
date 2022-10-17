// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imagerecog20190930.Models
{
    public class DetectFruitsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectFruitsResponseBodyData Data { get; set; }
        public class DetectFruitsResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<DetectFruitsResponseBodyDataElements> Elements { get; set; }
            public class DetectFruitsResponseBodyDataElements : TeaModel {
                [NameInMap("Box")]
                [Validation(Required=false)]
                public List<float?> Box { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
