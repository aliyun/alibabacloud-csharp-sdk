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
                [NameInMap("Age")]
                [Validation(Required=false)]
                public PedestrianDetectAttributeResponseBodyDataAttributesAge Age { get; set; }
                public class PedestrianDetectAttributeResponseBodyDataAttributesAge : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                }

                [NameInMap("Backpack")]
                [Validation(Required=false)]
                public PedestrianDetectAttributeResponseBodyDataAttributesBackpack Backpack { get; set; }
                public class PedestrianDetectAttributeResponseBodyDataAttributesBackpack : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                }

                [NameInMap("Gender")]
                [Validation(Required=false)]
                public PedestrianDetectAttributeResponseBodyDataAttributesGender Gender { get; set; }
                public class PedestrianDetectAttributeResponseBodyDataAttributesGender : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                }

                [NameInMap("Glasses")]
                [Validation(Required=false)]
                public PedestrianDetectAttributeResponseBodyDataAttributesGlasses Glasses { get; set; }
                public class PedestrianDetectAttributeResponseBodyDataAttributesGlasses : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                }

                [NameInMap("Handbag")]
                [Validation(Required=false)]
                public PedestrianDetectAttributeResponseBodyDataAttributesHandbag Handbag { get; set; }
                public class PedestrianDetectAttributeResponseBodyDataAttributesHandbag : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                }

                [NameInMap("Hat")]
                [Validation(Required=false)]
                public PedestrianDetectAttributeResponseBodyDataAttributesHat Hat { get; set; }
                public class PedestrianDetectAttributeResponseBodyDataAttributesHat : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                }

                [NameInMap("LowerColor")]
                [Validation(Required=false)]
                public PedestrianDetectAttributeResponseBodyDataAttributesLowerColor LowerColor { get; set; }
                public class PedestrianDetectAttributeResponseBodyDataAttributesLowerColor : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                }

                [NameInMap("LowerWear")]
                [Validation(Required=false)]
                public PedestrianDetectAttributeResponseBodyDataAttributesLowerWear LowerWear { get; set; }
                public class PedestrianDetectAttributeResponseBodyDataAttributesLowerWear : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                }

                [NameInMap("Orient")]
                [Validation(Required=false)]
                public PedestrianDetectAttributeResponseBodyDataAttributesOrient Orient { get; set; }
                public class PedestrianDetectAttributeResponseBodyDataAttributesOrient : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                }

                [NameInMap("ShoulderBag")]
                [Validation(Required=false)]
                public PedestrianDetectAttributeResponseBodyDataAttributesShoulderBag ShoulderBag { get; set; }
                public class PedestrianDetectAttributeResponseBodyDataAttributesShoulderBag : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                }

                [NameInMap("UpperColor")]
                [Validation(Required=false)]
                public PedestrianDetectAttributeResponseBodyDataAttributesUpperColor UpperColor { get; set; }
                public class PedestrianDetectAttributeResponseBodyDataAttributesUpperColor : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                }

                [NameInMap("UpperWear")]
                [Validation(Required=false)]
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
                [NameInMap("BottomRightX")]
                [Validation(Required=false)]
                public float? BottomRightX { get; set; }

                [NameInMap("BottomRightY")]
                [Validation(Required=false)]
                public float? BottomRightY { get; set; }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

                [NameInMap("TopLeftX")]
                [Validation(Required=false)]
                public float? TopLeftX { get; set; }

                [NameInMap("TopLeftY")]
                [Validation(Required=false)]
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

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
