// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageseg20191230.Models
{
    public class SegmentHeadResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public SegmentHeadResponseBodyData Data { get; set; }
        public class SegmentHeadResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<SegmentHeadResponseBodyDataElements> Elements { get; set; }
            public class SegmentHeadResponseBodyDataElements : TeaModel {
                public string ImageURL { get; set; }
                public int? Width { get; set; }
                public int? Height { get; set; }
                public int? Y { get; set; }
                public int? X { get; set; }
            }
        };

    }

}
