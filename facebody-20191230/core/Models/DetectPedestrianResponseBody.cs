// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class DetectPedestrianResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectPedestrianResponseBodyData Data { get; set; }
        public class DetectPedestrianResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<DetectPedestrianResponseBodyDataElements> Elements { get; set; }
            public class DetectPedestrianResponseBodyDataElements : TeaModel {
                public string Type { get; set; }
                public List<string> Boxes { get; set; }
                public float? Score { get; set; }
            }
            [NameInMap("Width")]
            [Validation(Required=false)]
            public int? Width { get; set; }
            [NameInMap("Height")]
            [Validation(Required=false)]
            public int? Height { get; set; }
        };

    }

}
