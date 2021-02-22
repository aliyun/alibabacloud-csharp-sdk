// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageseg20191230.Models
{
    public class SegmentVehicleResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public SegmentVehicleResponseBodyData Data { get; set; }
        public class SegmentVehicleResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<SegmentVehicleResponseBodyDataElements> Elements { get; set; }
            public class SegmentVehicleResponseBodyDataElements : TeaModel {
                public string ImageURL { get; set; }
                public string OriginImageURL { get; set; }
            }
        };

    }

}
