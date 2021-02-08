// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class PedestrianDetectAttributeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public PedestrianDetectAttributeResponseBodyData Data { get; set; }
        public class PedestrianDetectAttributeResponseBodyData : TeaModel {
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public List<PedestrianDetectAttributeResponseBodyDataAttributes> Attributes { get; set; }
            public class PedestrianDetectAttributeResponseBodyDataAttributes : TeaModel {
                [NameInMap("Score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }
            [NameInMap("Boxes")]
            [Validation(Required=false)]
            public List<PedestrianDetectAttributeResponseBodyDataBoxes> Boxes { get; set; }
            public class PedestrianDetectAttributeResponseBodyDataBoxes : TeaModel {
                public float? BottomRightX { get; set; }
                public float? TopLeftY { get; set; }
                public float? Score { get; set; }
                public float? TopLeftX { get; set; }
                public float? BottomRightY { get; set; }
            }
            [NameInMap("PersonNumber")]
            [Validation(Required=false)]
            public int? PersonNumber { get; set; }
            [NameInMap("Width")]
            [Validation(Required=false)]
            public long? Width { get; set; }
            [NameInMap("Height")]
            [Validation(Required=false)]
            public long? Height { get; set; }
        };

    }

}
