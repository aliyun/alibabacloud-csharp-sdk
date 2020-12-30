// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ivpd20190625.Models
{
    public class SegmentHairResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public SegmentHairResponseBodyData Data { get; set; }
        public class SegmentHairResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<SegmentHairResponseBodyDataElements> Elements { get; set; }
            public class SegmentHairResponseBodyDataElements : TeaModel {
                public string ImageURL { get; set; }
                public int? Width { get; set; }
                public int? Height { get; set; }
                public int? Y { get; set; }
                public int? X { get; set; }
            }
        };

    }

}
