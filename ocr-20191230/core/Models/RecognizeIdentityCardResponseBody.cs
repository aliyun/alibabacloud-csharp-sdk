// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizeIdentityCardResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeIdentityCardResponseBodyData Data { get; set; }
        public class RecognizeIdentityCardResponseBodyData : TeaModel {
            [NameInMap("BackResult")]
            [Validation(Required=false)]
            public RecognizeIdentityCardResponseBodyDataBackResult BackResult { get; set; }
            public class RecognizeIdentityCardResponseBodyDataBackResult : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>19800101</para>
                /// </summary>
                [NameInMap("EndDate")]
                [Validation(Required=false)]
                public string EndDate { get; set; }

                [NameInMap("Issue")]
                [Validation(Required=false)]
                public string Issue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>19970101</para>
                /// </summary>
                [NameInMap("StartDate")]
                [Validation(Required=false)]
                public string StartDate { get; set; }

            }

            [NameInMap("FrontResult")]
            [Validation(Required=false)]
            public RecognizeIdentityCardResponseBodyDataFrontResult FrontResult { get; set; }
            public class RecognizeIdentityCardResponseBodyDataFrontResult : TeaModel {
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>19960111</para>
                /// </summary>
                [NameInMap("BirthDate")]
                [Validation(Required=false)]
                public string BirthDate { get; set; }

                [NameInMap("CardAreas")]
                [Validation(Required=false)]
                public List<RecognizeIdentityCardResponseBodyDataFrontResultCardAreas> CardAreas { get; set; }
                public class RecognizeIdentityCardResponseBodyDataFrontResultCardAreas : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>40</para>
                    /// </summary>
                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public float? X { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>81</para>
                    /// </summary>
                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public float? Y { get; set; }

                }

                [NameInMap("FaceRectVertices")]
                [Validation(Required=false)]
                public List<RecognizeIdentityCardResponseBodyDataFrontResultFaceRectVertices> FaceRectVertices { get; set; }
                public class RecognizeIdentityCardResponseBodyDataFrontResultFaceRectVertices : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>429.46124267578125</para>
                    /// </summary>
                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public float? X { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>164.23321533203125</para>
                    /// </summary>
                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public float? Y { get; set; }

                }

                [NameInMap("FaceRectangle")]
                [Validation(Required=false)]
                public RecognizeIdentityCardResponseBodyDataFrontResultFaceRectangle FaceRectangle { get; set; }
                public class RecognizeIdentityCardResponseBodyDataFrontResultFaceRectangle : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>-87.710586547851562</para>
                    /// </summary>
                    [NameInMap("Angle")]
                    [Validation(Required=false)]
                    public float? Angle { get; set; }

                    [NameInMap("Center")]
                    [Validation(Required=false)]
                    public RecognizeIdentityCardResponseBodyDataFrontResultFaceRectangleCenter Center { get; set; }
                    public class RecognizeIdentityCardResponseBodyDataFrontResultFaceRectangleCenter : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>475.59390258789062</para>
                        /// </summary>
                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public float? X { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>225.20643615722656</para>
                        /// </summary>
                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public float? Y { get; set; }

                    }

                    [NameInMap("Size")]
                    [Validation(Required=false)]
                    public RecognizeIdentityCardResponseBodyDataFrontResultFaceRectangleSize Size { get; set; }
                    public class RecognizeIdentityCardResponseBodyDataFrontResultFaceRectangleSize : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>97.063156127929688</para>
                        /// </summary>
                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public float? Height { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>118.16333770751953</para>
                        /// </summary>
                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public float? Width { get; set; }

                    }

                }

                [NameInMap("Gender")]
                [Validation(Required=false)]
                public string Gender { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>310228199601115411</para>
                /// </summary>
                [NameInMap("IDNumber")]
                [Validation(Required=false)]
                public string IDNumber { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Nationality")]
                [Validation(Required=false)]
                public string Nationality { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D3F5BA69-79C4-46A4-B02B-58C4EEBC4C33</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
