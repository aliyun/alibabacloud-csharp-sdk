// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageseg20191230.Models
{
    public class SegmentClothResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public SegmentClothResponseBodyData Data { get; set; }
        public class SegmentClothResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<SegmentClothResponseBodyDataElements> Elements { get; set; }
            public class SegmentClothResponseBodyDataElements : TeaModel {
                public string ImageURL { get; set; }
            }
        };

    }

}
