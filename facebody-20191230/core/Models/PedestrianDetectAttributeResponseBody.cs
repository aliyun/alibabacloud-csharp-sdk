// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class PedestrianDetectAttributeResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public PedestrianDetectAttributeResponseBodyData Data { get; set; }
        public class PedestrianDetectAttributeResponseBodyData : TeaModel {
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public List<PedestrianDetectAttributeResponseBodyDataAttributes> Attributes { get; set; }
            public class PedestrianDetectAttributeResponseBodyDataAttributes : TeaModel {
                public PedestrianDetectAttributeResponseBodyDataAttributesAge Age { get; set; }
                public class PedestrianDetectAttributeResponseBodyDataAttributesAge : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                }
                public PedestrianDetectAttributeResponseBodyDataAttributesBackpack Backpack { get; set; }
                public class PedestrianDetectAttributeResponseBodyDataAttributesBackpack : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                }
                public PedestrianDetectAttributeResponseBodyDataAttributesGender Gender { get; set; }
                public class PedestrianDetectAttributeResponseBodyDataAttributesGender : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                }
                public PedestrianDetectAttributeResponseBodyDataAttributesGlasses Glasses { get; set; }
                public class PedestrianDetectAttributeResponseBodyDataAttributesGlasses : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                }
                public PedestrianDetectAttributeResponseBodyDataAttributesHandbag Handbag { get; set; }
                public class PedestrianDetectAttributeResponseBodyDataAttributesHandbag : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                }
                public PedestrianDetectAttributeResponseBodyDataAttributesHat Hat { get; set; }
                public class PedestrianDetectAttributeResponseBodyDataAttributesHat : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                }
                public PedestrianDetectAttributeResponseBodyDataAttributesLowerColor LowerColor { get; set; }
                public class PedestrianDetectAttributeResponseBodyDataAttributesLowerColor : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                }
                public PedestrianDetectAttributeResponseBodyDataAttributesLowerWear LowerWear { get; set; }
                public class PedestrianDetectAttributeResponseBodyDataAttributesLowerWear : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                }
                public PedestrianDetectAttributeResponseBodyDataAttributesOrient Orient { get; set; }
                public class PedestrianDetectAttributeResponseBodyDataAttributesOrient : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                }
                public PedestrianDetectAttributeResponseBodyDataAttributesShoulderBag ShoulderBag { get; set; }
                public class PedestrianDetectAttributeResponseBodyDataAttributesShoulderBag : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                }
                public PedestrianDetectAttributeResponseBodyDataAttributesUpperColor UpperColor { get; set; }
                public class PedestrianDetectAttributeResponseBodyDataAttributesUpperColor : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                }
                public PedestrianDetectAttributeResponseBodyDataAttributesUpperWear UpperWear { get; set; }
                public class PedestrianDetectAttributeResponseBodyDataAttributesUpperWear : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                }
            }
            [NameInMap("Boxes")]
            [Validation(Required=false)]
            public List<PedestrianDetectAttributeResponseBodyDataBoxes> Boxes { get; set; }
            public class PedestrianDetectAttributeResponseBodyDataBoxes : TeaModel {
                public float? BottomRightX { get; set; }
                public float? BottomRightY { get; set; }
                public float? Score { get; set; }
                public float? TopLeftX { get; set; }
                public float? TopLeftY { get; set; }
            }
            [NameInMap("Height")]
            [Validation(Required=false)]
            public long? Height { get; set; }
            [NameInMap("PersonNumber")]
            [Validation(Required=false)]
            public int? PersonNumber { get; set; }
            [NameInMap("Width")]
            [Validation(Required=false)]
            public long? Width { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
