// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageseg20191230.Models
{
    public class SegmentFaceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public SegmentFaceResponseBodyData Data { get; set; }
        public class SegmentFaceResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<SegmentFaceResponseBodyDataElements> Elements { get; set; }
            public class SegmentFaceResponseBodyDataElements : TeaModel {
                public string ImageURL { get; set; }
                public int? Width { get; set; }
                public int? Height { get; set; }
                public int? Y { get; set; }
                public int? X { get; set; }
            }
        };

    }

}
