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
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Age18-60</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.99590516090393066</para>
                    /// </summary>
                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                }

                [NameInMap("Backpack")]
                [Validation(Required=false)]
                public PedestrianDetectAttributeResponseBodyDataAttributesBackpack Backpack { get; set; }
                public class PedestrianDetectAttributeResponseBodyDataAttributesBackpack : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>No</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.96486538648605347</para>
                    /// </summary>
                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                }

                [NameInMap("Gender")]
                [Validation(Required=false)]
                public PedestrianDetectAttributeResponseBodyDataAttributesGender Gender { get; set; }
                public class PedestrianDetectAttributeResponseBodyDataAttributesGender : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>female</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.97989875078201294</para>
                    /// </summary>
                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                }

                [NameInMap("Glasses")]
                [Validation(Required=false)]
                public PedestrianDetectAttributeResponseBodyDataAttributesGlasses Glasses { get; set; }
                public class PedestrianDetectAttributeResponseBodyDataAttributesGlasses : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>No</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.87284471094608307</para>
                    /// </summary>
                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                }

                [NameInMap("Handbag")]
                [Validation(Required=false)]
                public PedestrianDetectAttributeResponseBodyDataAttributesHandbag Handbag { get; set; }
                public class PedestrianDetectAttributeResponseBodyDataAttributesHandbag : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Yes</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.55011671781539917</para>
                    /// </summary>
                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                }

                [NameInMap("Hat")]
                [Validation(Required=false)]
                public PedestrianDetectAttributeResponseBodyDataAttributesHat Hat { get; set; }
                public class PedestrianDetectAttributeResponseBodyDataAttributesHat : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>No</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.98272394016385078</para>
                    /// </summary>
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

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.69961744546890259</para>
                    /// </summary>
                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                }

                [NameInMap("LowerWear")]
                [Validation(Required=false)]
                public PedestrianDetectAttributeResponseBodyDataAttributesLowerWear LowerWear { get; set; }
                public class PedestrianDetectAttributeResponseBodyDataAttributesLowerWear : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Trousers</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.6424860954284668</para>
                    /// </summary>
                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                }

                [NameInMap("Orient")]
                [Validation(Required=false)]
                public PedestrianDetectAttributeResponseBodyDataAttributesOrient Orient { get; set; }
                public class PedestrianDetectAttributeResponseBodyDataAttributesOrient : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Front</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.97838658094406128</para>
                    /// </summary>
                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                }

                [NameInMap("ShoulderBag")]
                [Validation(Required=false)]
                public PedestrianDetectAttributeResponseBodyDataAttributesShoulderBag ShoulderBag { get; set; }
                public class PedestrianDetectAttributeResponseBodyDataAttributesShoulderBag : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>No</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.91198787838220596</para>
                    /// </summary>
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

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.97796273231506348</para>
                    /// </summary>
                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                }

                [NameInMap("UpperWear")]
                [Validation(Required=false)]
                public PedestrianDetectAttributeResponseBodyDataAttributesUpperWear UpperWear { get; set; }
                public class PedestrianDetectAttributeResponseBodyDataAttributesUpperWear : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ShortSleeve</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.89291918277740479</para>
                    /// </summary>
                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                }

            }

            [NameInMap("Boxes")]
            [Validation(Required=false)]
            public List<PedestrianDetectAttributeResponseBodyDataBoxes> Boxes { get; set; }
            public class PedestrianDetectAttributeResponseBodyDataBoxes : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>584</para>
                /// </summary>
                [NameInMap("BottomRightX")]
                [Validation(Required=false)]
                public float? BottomRightX { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>218</para>
                /// </summary>
                [NameInMap("BottomRightY")]
                [Validation(Required=false)]
                public float? BottomRightY { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.88381063938140869</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>36</para>
                /// </summary>
                [NameInMap("TopLeftX")]
                [Validation(Required=false)]
                public float? TopLeftX { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>27</para>
                /// </summary>
                [NameInMap("TopLeftY")]
                [Validation(Required=false)]
                public float? TopLeftY { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>584</para>
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public long? Height { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PersonNumber")]
            [Validation(Required=false)]
            public int? PersonNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>264</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public long? Width { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4F609A30-F645-481E-A513-CADAA14DFB0A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
