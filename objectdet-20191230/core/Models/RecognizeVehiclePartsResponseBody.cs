// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Objectdet20191230.Models
{
    public class RecognizeVehiclePartsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeVehiclePartsResponseBodyData Data { get; set; }
        public class RecognizeVehiclePartsResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<RecognizeVehiclePartsResponseBodyDataElements> Elements { get; set; }
            public class RecognizeVehiclePartsResponseBodyDataElements : TeaModel {
                public List<string> Boxes { get; set; }
                public float? Score { get; set; }
                public string Type { get; set; }
            }
            [NameInMap("OriginShapes")]
            [Validation(Required=false)]
            public List<string> OriginShapes { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
