// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DetectFaceAttributesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectFaceAttributesResponseBodyData Data { get; set; }
        public class DetectFaceAttributesResponseBodyData : TeaModel {
            [NameInMap("FaceInfos")]
            [Validation(Required=false)]
            public DetectFaceAttributesResponseBodyDataFaceInfos FaceInfos { get; set; }
            public class DetectFaceAttributesResponseBodyDataFaceInfos : TeaModel {
                [NameInMap("FaceAttributesDetectInfo")]
                [Validation(Required=false)]
                public List<DetectFaceAttributesResponseBodyDataFaceInfosFaceAttributesDetectInfo> FaceAttributesDetectInfo { get; set; }
                public class DetectFaceAttributesResponseBodyDataFaceInfosFaceAttributesDetectInfo : TeaModel {
                    [NameInMap("FaceAttributes")]
                    [Validation(Required=false)]
                    public DetectFaceAttributesResponseBodyDataFaceInfosFaceAttributesDetectInfoFaceAttributes FaceAttributes { get; set; }
                    public class DetectFaceAttributesResponseBodyDataFaceInfosFaceAttributesDetectInfoFaceAttributes : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0.1419367790222168</para>
                        /// </summary>
                        [NameInMap("Blur")]
                        [Validation(Required=false)]
                        public float? Blur { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>60</para>
                        /// </summary>
                        [NameInMap("Facequal")]
                        [Validation(Required=false)]
                        public float? Facequal { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Face</para>
                        /// </summary>
                        [NameInMap("Facetype")]
                        [Validation(Required=false)]
                        public string Facetype { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>None</para>
                        /// </summary>
                        [NameInMap("Glasses")]
                        [Validation(Required=false)]
                        public string Glasses { get; set; }

                        [NameInMap("Headpose")]
                        [Validation(Required=false)]
                        public DetectFaceAttributesResponseBodyDataFaceInfosFaceAttributesDetectInfoFaceAttributesHeadpose Headpose { get; set; }
                        public class DetectFaceAttributesResponseBodyDataFaceInfosFaceAttributesDetectInfoFaceAttributesHeadpose : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>-1.5683923959732056</para>
                            /// </summary>
                            [NameInMap("PitchAngle")]
                            [Validation(Required=false)]
                            public float? PitchAngle { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>7.163370132446289</para>
                            /// </summary>
                            [NameInMap("RollAngle")]
                            [Validation(Required=false)]
                            public float? RollAngle { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>-6.925303936004639</para>
                            /// </summary>
                            [NameInMap("YawAngle")]
                            [Validation(Required=false)]
                            public float? YawAngle { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>70</para>
                        /// </summary>
                        [NameInMap("Integrity")]
                        [Validation(Required=false)]
                        public int? Integrity { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Wear</para>
                        /// </summary>
                        [NameInMap("Respirator")]
                        [Validation(Required=false)]
                        public string Respirator { get; set; }

                        [NameInMap("Smiling")]
                        [Validation(Required=false)]
                        public DetectFaceAttributesResponseBodyDataFaceInfosFaceAttributesDetectInfoFaceAttributesSmiling Smiling { get; set; }
                        public class DetectFaceAttributesResponseBodyDataFaceInfosFaceAttributesDetectInfoFaceAttributesSmiling : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>95</para>
                            /// </summary>
                            [NameInMap("Threshold")]
                            [Validation(Required=false)]
                            public float? Threshold { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>97</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public float? Value { get; set; }

                        }

                    }

                    [NameInMap("FaceRect")]
                    [Validation(Required=false)]
                    public DetectFaceAttributesResponseBodyDataFaceInfosFaceAttributesDetectInfoFaceRect FaceRect { get; set; }
                    public class DetectFaceAttributesResponseBodyDataFaceInfosFaceAttributesDetectInfoFaceRect : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>473</para>
                        /// </summary>
                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public int? Height { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>354</para>
                        /// </summary>
                        [NameInMap("Left")]
                        [Validation(Required=false)]
                        public int? Left { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>453</para>
                        /// </summary>
                        [NameInMap("Top")]
                        [Validation(Required=false)]
                        public int? Top { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>473</para>
                        /// </summary>
                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public int? Width { get; set; }

                    }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1920</para>
            /// </summary>
            [NameInMap("ImgHeight")]
            [Validation(Required=false)]
            public int? ImgHeight { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1080</para>
            /// </summary>
            [NameInMap("ImgWidth")]
            [Validation(Required=false)]
            public int? ImgWidth { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Error.InternalError</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
