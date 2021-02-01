// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imagerecog20190930.Models
{
    public class RecognizeVehicleTypeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeVehicleTypeResponseBodyData Data { get; set; }
        public class RecognizeVehicleTypeResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<RecognizeVehicleTypeResponseBodyDataElements> Elements { get; set; }
            public class RecognizeVehicleTypeResponseBodyDataElements : TeaModel {
                public float? Score { get; set; }
                public string Name { get; set; }
            }
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public float? Threshold { get; set; }
        };

    }

}
