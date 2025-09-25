// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DetectFaceAttributesResponseBody : TeaModel {
        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectFaceAttributesResponseBodyData Data { get; set; }
        public class DetectFaceAttributesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Face detection results.</para>
            /// </summary>
            [NameInMap("FaceInfos")]
            [Validation(Required=false)]
            public DetectFaceAttributesResponseBodyDataFaceInfos FaceInfos { get; set; }
            public class DetectFaceAttributesResponseBodyDataFaceInfos : TeaModel {
                [NameInMap("FaceAttributesDetectInfo")]
                [Validation(Required=false)]
                public List<DetectFaceAttributesResponseBodyDataFaceInfosFaceAttributesDetectInfo> FaceAttributesDetectInfo { get; set; }
                public class DetectFaceAttributesResponseBodyDataFaceInfosFaceAttributesDetectInfo : TeaModel {
                    /// <summary>
                    /// <para>Face attributes.</para>
                    /// </summary>
                    [NameInMap("FaceAttributes")]
                    [Validation(Required=false)]
                    public DetectFaceAttributesResponseBodyDataFaceInfosFaceAttributesDetectInfoFaceAttributes FaceAttributes { get; set; }
                    public class DetectFaceAttributesResponseBodyDataFaceInfosFaceAttributesDetectInfoFaceAttributes : TeaModel {
                        /// <summary>
                        /// <para>Face blur level, with higher values indicating more blurriness. Typically, a value ≥2.0 is considered quite blurry. It is recommended to adjust based on actual business data testing.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0.1419367790222168</para>
                        /// </summary>
                        [NameInMap("Blur")]
                        [Validation(Required=false)]
                        public float? Blur { get; set; }

                        /// <summary>
                        /// <para>A score ranging from 0 to 100. The higher the score, the better the quality. It is recommended to consider a score of 50 or above as acceptable quality.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>60</para>
                        /// </summary>
                        [NameInMap("Facequal")]
                        [Validation(Required=false)]
                        public float? Facequal { get; set; }

                        /// <summary>
                        /// <para>Whether it is a human face. Values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>None</b>: Not a human face</description></item>
                        /// <item><description><b>Face</b>: Human face</description></item>
                        /// <item><description><b>Profile</b>: Profile (head turned left or right by more than 30°)</description></item>
                        /// </list>
                        /// <remarks>
                        /// <para>If no face is detected, the <c>faceInfos</c> in the response will be empty; here, <c>None</c> means that a face was detected but is considered to be a cartoon, pet, etc.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Face</para>
                        /// </summary>
                        [NameInMap("Facetype")]
                        [Validation(Required=false)]
                        public string Facetype { get; set; }

                        /// <summary>
                        /// <para>Whether wearing glasses. Values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>None</b>: Not wearing glasses</description></item>
                        /// <item><description><b>Wear</b>: Wearing regular glasses</description></item>
                        /// <item><description><b>Sunglass</b>: Wearing sunglasses</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>None</para>
                        /// </summary>
                        [NameInMap("Glasses")]
                        [Validation(Required=false)]
                        public string Glasses { get; set; }

                        /// <summary>
                        /// <para>Face pose.</para>
                        /// </summary>
                        [NameInMap("Headpose")]
                        [Validation(Required=false)]
                        public DetectFaceAttributesResponseBodyDataFaceInfosFaceAttributesDetectInfoFaceAttributesHeadpose Headpose { get; set; }
                        public class DetectFaceAttributesResponseBodyDataFaceInfosFaceAttributesDetectInfoFaceAttributesHeadpose : TeaModel {
                            /// <summary>
                            /// <para>Pitch angle, in degrees.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>-1.5683923959732056</para>
                            /// </summary>
                            [NameInMap("PitchAngle")]
                            [Validation(Required=false)]
                            public float? PitchAngle { get; set; }

                            /// <summary>
                            /// <para>Roll angle, in degrees.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>7.163370132446289</para>
                            /// </summary>
                            [NameInMap("RollAngle")]
                            [Validation(Required=false)]
                            public float? RollAngle { get; set; }

                            /// <summary>
                            /// <para>Yaw angle, in degrees.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>-6.925303936004639</para>
                            /// </summary>
                            [NameInMap("YawAngle")]
                            [Validation(Required=false)]
                            public float? YawAngle { get; set; }

                        }

                        /// <summary>
                        /// <para>A score ranging from 0 to 100. The higher the score, the more complete the face. It is recommended to consider a score of 70 or above as acceptable completeness.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>70</para>
                        /// </summary>
                        [NameInMap("Integrity")]
                        [Validation(Required=false)]
                        public int? Integrity { get; set; }

                        /// <summary>
                        /// <para>Whether wearing a mask. Values:</para>
                        /// <list type="bullet">
                        /// <item><description>Wear: Wearing a mask.</description></item>
                        /// <item><description>None: Not wearing a mask.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Wear</para>
                        /// </summary>
                        [NameInMap("Respirator")]
                        [Validation(Required=false)]
                        public string Respirator { get; set; }

                        /// <summary>
                        /// <para>Whether smiling.</para>
                        /// </summary>
                        [NameInMap("Smiling")]
                        [Validation(Required=false)]
                        public DetectFaceAttributesResponseBodyDataFaceInfosFaceAttributesDetectInfoFaceAttributesSmiling Smiling { get; set; }
                        public class DetectFaceAttributesResponseBodyDataFaceInfosFaceAttributesDetectInfoFaceAttributesSmiling : TeaModel {
                            /// <summary>
                            /// <para>Smile threshold.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>95</para>
                            /// </summary>
                            [NameInMap("Threshold")]
                            [Validation(Required=false)]
                            public float? Threshold { get; set; }

                            /// <summary>
                            /// <para>Smile score.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>97</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public float? Value { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>Position of the face in the original image.</para>
                    /// </summary>
                    [NameInMap("FaceRect")]
                    [Validation(Required=false)]
                    public DetectFaceAttributesResponseBodyDataFaceInfosFaceAttributesDetectInfoFaceRect FaceRect { get; set; }
                    public class DetectFaceAttributesResponseBodyDataFaceInfosFaceAttributesDetectInfoFaceRect : TeaModel {
                        /// <summary>
                        /// <para>Height of the face rectangle.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>473</para>
                        /// </summary>
                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public int? Height { get; set; }

                        /// <summary>
                        /// <para>Distance from the top-left corner of the face rectangle to the left edge of the original image, in pixels.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>354</para>
                        /// </summary>
                        [NameInMap("Left")]
                        [Validation(Required=false)]
                        public int? Left { get; set; }

                        /// <summary>
                        /// <para>Distance from the top-left corner of the face rectangle to the top edge of the original image, in pixels.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>453</para>
                        /// </summary>
                        [NameInMap("Top")]
                        [Validation(Required=false)]
                        public int? Top { get; set; }

                        /// <summary>
                        /// <para>Width of the face rectangle.</para>
                        /// 
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
            /// <para>Original image height, in pixels.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1920</para>
            /// </summary>
            [NameInMap("ImgHeight")]
            [Validation(Required=false)]
            public int? ImgHeight { get; set; }

            /// <summary>
            /// <para>Original image width, in pixels.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1080</para>
            /// </summary>
            [NameInMap("ImgWidth")]
            [Validation(Required=false)]
            public int? ImgWidth { get; set; }

        }

        /// <summary>
        /// <para>Error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Error.InternalError</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>ID of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Whether the response was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
