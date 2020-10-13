// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class PedestrianDetectAttributeResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public PedestrianDetectAttributeResponseData Data { get; set; }
        public class PedestrianDetectAttributeResponseData : TeaModel {
            [NameInMap("PersonNumber")]
            [Validation(Required=true)]
            public int? PersonNumber { get; set; }
            [NameInMap("Attributes")]
            [Validation(Required=true)]
            public List<PedestrianDetectAttributeResponseDataAttributes> Attributes { get; set; }
            public class PedestrianDetectAttributeResponseDataAttributes : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=true)]
                public string Name { get; set; }

                [NameInMap("Score")]
                [Validation(Required=true)]
                public float? Score { get; set; }

            }
            [NameInMap("Boxes")]
            [Validation(Required=true)]
            public List<PedestrianDetectAttributeResponseDataBoxes> Boxes { get; set; }
            public class PedestrianDetectAttributeResponseDataBoxes : TeaModel {
                public float? Score { get; set; }
                public float? TopLeftX { get; set; }
                public float? TopLeftY { get; set; }
                public float? BottomRightX { get; set; }
                public float? BottomRightY { get; set; }
            }
        };

    }

}
