// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class DetectPedestrianResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectPedestrianResponseBodyData Data { get; set; }
        public class DetectPedestrianResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<DetectPedestrianResponseBodyDataElements> Elements { get; set; }
            public class DetectPedestrianResponseBodyDataElements : TeaModel {
                [NameInMap("Boxes")]
                [Validation(Required=false)]
                public List<int?> Boxes { get; set; }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("Height")]
            [Validation(Required=false)]
            public int? Height { get; set; }

            [NameInMap("Width")]
            [Validation(Required=false)]
            public int? Width { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
