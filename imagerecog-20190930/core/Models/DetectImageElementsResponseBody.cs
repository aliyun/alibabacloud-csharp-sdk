// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imagerecog20190930.Models
{
    public class DetectImageElementsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectImageElementsResponseBodyData Data { get; set; }
        public class DetectImageElementsResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<DetectImageElementsResponseBodyDataElements> Elements { get; set; }
            public class DetectImageElementsResponseBodyDataElements : TeaModel {
                public string Type { get; set; }
                public int? Width { get; set; }
                public int? Height { get; set; }
                public int? Y { get; set; }
                public float? Score { get; set; }
                public int? X { get; set; }
            }
        };

    }

}
