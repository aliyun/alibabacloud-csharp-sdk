// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class ImageQueueModerationResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ImageQueueModerationResponseBodyData Data { get; set; }
        public class ImageQueueModerationResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>data1234</para>
            /// </summary>
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            [NameInMap("Ext")]
            [Validation(Required=false)]
            public ImageQueueModerationResponseBodyDataExt Ext { get; set; }
            public class ImageQueueModerationResponseBodyDataExt : TeaModel {
                [NameInMap("CustomImage")]
                [Validation(Required=false)]
                public List<ImageQueueModerationResponseBodyDataExtCustomImage> CustomImage { get; set; }
                public class ImageQueueModerationResponseBodyDataExtCustomImage : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>123456</para>
                    /// </summary>
                    [NameInMap("ImageId")]
                    [Validation(Required=false)]
                    public string ImageId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>图库123</para>
                    /// </summary>
                    [NameInMap("LibId")]
                    [Validation(Required=false)]
                    public string LibId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>图库123</para>
                    /// </summary>
                    [NameInMap("LibName")]
                    [Validation(Required=false)]
                    public string LibName { get; set; }

                }

                [NameInMap("FaceData")]
                [Validation(Required=false)]
                public List<ImageQueueModerationResponseBodyDataExtFaceData> FaceData { get; set; }
                public class ImageQueueModerationResponseBodyDataExtFaceData : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>18</para>
                    /// </summary>
                    [NameInMap("Age")]
                    [Validation(Required=false)]
                    public int? Age { get; set; }

                    [NameInMap("Bang")]
                    [Validation(Required=false)]
                    public ImageQueueModerationResponseBodyDataExtFaceDataBang Bang { get; set; }
                    public class ImageQueueModerationResponseBodyDataExtFaceDataBang : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>81.88</para>
                        /// </summary>
                        [NameInMap("Confidence")]
                        [Validation(Required=false)]
                        public float? Confidence { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Has</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    [NameInMap("Gender")]
                    [Validation(Required=false)]
                    public ImageQueueModerationResponseBodyDataExtFaceDataGender Gender { get; set; }
                    public class ImageQueueModerationResponseBodyDataExtFaceDataGender : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>81.88</para>
                        /// </summary>
                        [NameInMap("Confidence")]
                        [Validation(Required=false)]
                        public float? Confidence { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>FeMale</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Common</para>
                    /// </summary>
                    [NameInMap("Glasses")]
                    [Validation(Required=false)]
                    public string Glasses { get; set; }

                    [NameInMap("Hairstyle")]
                    [Validation(Required=false)]
                    public ImageQueueModerationResponseBodyDataExtFaceDataHairstyle Hairstyle { get; set; }
                    public class ImageQueueModerationResponseBodyDataExtFaceDataHairstyle : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>81.88</para>
                        /// </summary>
                        [NameInMap("Confidence")]
                        [Validation(Required=false)]
                        public float? Confidence { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Short</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    [NameInMap("Hat")]
                    [Validation(Required=false)]
                    public ImageQueueModerationResponseBodyDataExtFaceDataHat Hat { get; set; }
                    public class ImageQueueModerationResponseBodyDataExtFaceDataHat : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>88.88</para>
                        /// </summary>
                        [NameInMap("Confidence")]
                        [Validation(Required=false)]
                        public float? Confidence { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Wear</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public ImageQueueModerationResponseBodyDataExtFaceDataLocation Location { get; set; }
                    public class ImageQueueModerationResponseBodyDataExtFaceDataLocation : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>26</para>
                        /// </summary>
                        [NameInMap("H")]
                        [Validation(Required=false)]
                        public int? H { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>83</para>
                        /// </summary>
                        [NameInMap("W")]
                        [Validation(Required=false)]
                        public int? W { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>41</para>
                        /// </summary>
                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public int? X { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>84</para>
                        /// </summary>
                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public int? Y { get; set; }

                    }

                    [NameInMap("Mask")]
                    [Validation(Required=false)]
                    public ImageQueueModerationResponseBodyDataExtFaceDataMask Mask { get; set; }
                    public class ImageQueueModerationResponseBodyDataExtFaceDataMask : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>99.99</para>
                        /// </summary>
                        [NameInMap("Confidence")]
                        [Validation(Required=false)]
                        public float? Confidence { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Wear</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    [NameInMap("Mustache")]
                    [Validation(Required=false)]
                    public ImageQueueModerationResponseBodyDataExtFaceDataMustache Mustache { get; set; }
                    public class ImageQueueModerationResponseBodyDataExtFaceDataMustache : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>99.99</para>
                        /// </summary>
                        [NameInMap("Confidence")]
                        [Validation(Required=false)]
                        public float? Confidence { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Has</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    [NameInMap("Quality")]
                    [Validation(Required=false)]
                    public ImageQueueModerationResponseBodyDataExtFaceDataQuality Quality { get; set; }
                    public class ImageQueueModerationResponseBodyDataExtFaceDataQuality : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>5.88</para>
                        /// </summary>
                        [NameInMap("Blur")]
                        [Validation(Required=false)]
                        public float? Blur { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>100.0</para>
                        /// </summary>
                        [NameInMap("Integrity")]
                        [Validation(Required=false)]
                        public float? Integrity { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>5.88</para>
                        /// </summary>
                        [NameInMap("Pitch")]
                        [Validation(Required=false)]
                        public float? Pitch { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>5.18</para>
                        /// </summary>
                        [NameInMap("Roll")]
                        [Validation(Required=false)]
                        public float? Roll { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>5.18</para>
                        /// </summary>
                        [NameInMap("Yaw")]
                        [Validation(Required=false)]
                        public float? Yaw { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>85.88</para>
                    /// </summary>
                    [NameInMap("Smile")]
                    [Validation(Required=false)]
                    public float? Smile { get; set; }

                }

                [NameInMap("LogoData")]
                [Validation(Required=false)]
                public List<ImageQueueModerationResponseBodyDataExtLogoData> LogoData { get; set; }
                public class ImageQueueModerationResponseBodyDataExtLogoData : TeaModel {
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public ImageQueueModerationResponseBodyDataExtLogoDataLocation Location { get; set; }
                    public class ImageQueueModerationResponseBodyDataExtLogoDataLocation : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>440</para>
                        /// </summary>
                        [NameInMap("H")]
                        [Validation(Required=false)]
                        public int? H { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>330</para>
                        /// </summary>
                        [NameInMap("W")]
                        [Validation(Required=false)]
                        public int? W { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>11</para>
                        /// </summary>
                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public int? X { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>22</para>
                        /// </summary>
                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public int? Y { get; set; }

                    }

                    [NameInMap("Logo")]
                    [Validation(Required=false)]
                    public List<ImageQueueModerationResponseBodyDataExtLogoDataLogo> Logo { get; set; }
                    public class ImageQueueModerationResponseBodyDataExtLogoDataLogo : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>99.1</para>
                        /// </summary>
                        [NameInMap("Confidence")]
                        [Validation(Required=false)]
                        public float? Confidence { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>logo_sns</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>钉钉</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                }

                [NameInMap("OcrResult")]
                [Validation(Required=false)]
                public List<ImageQueueModerationResponseBodyDataExtOcrResult> OcrResult { get; set; }
                public class ImageQueueModerationResponseBodyDataExtOcrResult : TeaModel {
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public ImageQueueModerationResponseBodyDataExtOcrResultLocation Location { get; set; }
                    public class ImageQueueModerationResponseBodyDataExtOcrResultLocation : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>44</para>
                        /// </summary>
                        [NameInMap("H")]
                        [Validation(Required=false)]
                        public int? H { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>33</para>
                        /// </summary>
                        [NameInMap("W")]
                        [Validation(Required=false)]
                        public int? W { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>11</para>
                        /// </summary>
                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public int? X { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>22</para>
                        /// </summary>
                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public int? Y { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>abcd</para>
                    /// </summary>
                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                }

                [NameInMap("PublicFigure")]
                [Validation(Required=false)]
                public List<ImageQueueModerationResponseBodyDataExtPublicFigure> PublicFigure { get; set; }
                public class ImageQueueModerationResponseBodyDataExtPublicFigure : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>xxx001</para>
                    /// </summary>
                    [NameInMap("FigureId")]
                    [Validation(Required=false)]
                    public string FigureId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>yzazhzou</para>
                    /// </summary>
                    [NameInMap("FigureName")]
                    [Validation(Required=false)]
                    public string FigureName { get; set; }

                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public List<ImageQueueModerationResponseBodyDataExtPublicFigureLocation> Location { get; set; }
                    public class ImageQueueModerationResponseBodyDataExtPublicFigureLocation : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>440</para>
                        /// </summary>
                        [NameInMap("H")]
                        [Validation(Required=false)]
                        public int? H { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>330</para>
                        /// </summary>
                        [NameInMap("W")]
                        [Validation(Required=false)]
                        public int? W { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>11</para>
                        /// </summary>
                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public int? X { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>22</para>
                        /// </summary>
                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public int? Y { get; set; }

                    }

                }

                [NameInMap("Recognition")]
                [Validation(Required=false)]
                public List<ImageQueueModerationResponseBodyDataExtRecognition> Recognition { get; set; }
                public class ImageQueueModerationResponseBodyDataExtRecognition : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>办公大楼</para>
                    /// </summary>
                    [NameInMap("Classification")]
                    [Validation(Required=false)]
                    public string Classification { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>81.22</para>
                    /// </summary>
                    [NameInMap("Confidence")]
                    [Validation(Required=false)]
                    public float? Confidence { get; set; }

                }

                [NameInMap("TextInImage")]
                [Validation(Required=false)]
                public ImageQueueModerationResponseBodyDataExtTextInImage TextInImage { get; set; }
                public class ImageQueueModerationResponseBodyDataExtTextInImage : TeaModel {
                    [NameInMap("CustomText")]
                    [Validation(Required=false)]
                    public List<ImageQueueModerationResponseBodyDataExtTextInImageCustomText> CustomText { get; set; }
                    public class ImageQueueModerationResponseBodyDataExtTextInImageCustomText : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>自定义词1,自定义词2</para>
                        /// </summary>
                        [NameInMap("KeyWords")]
                        [Validation(Required=false)]
                        public string KeyWords { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>123456</para>
                        /// </summary>
                        [NameInMap("LibId")]
                        [Validation(Required=false)]
                        public string LibId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>自定义库1</para>
                        /// </summary>
                        [NameInMap("LibName")]
                        [Validation(Required=false)]
                        public string LibName { get; set; }

                    }

                    [NameInMap("OcrResult")]
                    [Validation(Required=false)]
                    public List<ImageQueueModerationResponseBodyDataExtTextInImageOcrResult> OcrResult { get; set; }
                    public class ImageQueueModerationResponseBodyDataExtTextInImageOcrResult : TeaModel {
                        [NameInMap("Location")]
                        [Validation(Required=false)]
                        public ImageQueueModerationResponseBodyDataExtTextInImageOcrResultLocation Location { get; set; }
                        public class ImageQueueModerationResponseBodyDataExtTextInImageOcrResultLocation : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>33</para>
                            /// </summary>
                            [NameInMap("H")]
                            [Validation(Required=false)]
                            public int? H { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>44</para>
                            /// </summary>
                            [NameInMap("W")]
                            [Validation(Required=false)]
                            public int? W { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>11</para>
                            /// </summary>
                            [NameInMap("X")]
                            [Validation(Required=false)]
                            public int? X { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>22</para>
                            /// </summary>
                            [NameInMap("Y")]
                            [Validation(Required=false)]
                            public int? Y { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>abcd</para>
                        /// </summary>
                        [NameInMap("Text")]
                        [Validation(Required=false)]
                        public string Text { get; set; }

                    }

                    [NameInMap("RiskWord")]
                    [Validation(Required=false)]
                    public List<string> RiskWord { get; set; }

                }

                [NameInMap("VlContent")]
                [Validation(Required=false)]
                public ImageQueueModerationResponseBodyDataExtVlContent VlContent { get; set; }
                public class ImageQueueModerationResponseBodyDataExtVlContent : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>这是一段描述</para>
                    /// </summary>
                    [NameInMap("OutputText")]
                    [Validation(Required=false)]
                    public string OutputText { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxxx-xxxxx</para>
            /// </summary>
            [NameInMap("ManualTaskId")]
            [Validation(Required=false)]
            public string ManualTaskId { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ImageQueueModerationResponseBodyDataResult> Result { get; set; }
            public class ImageQueueModerationResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>81.22</para>
                /// </summary>
                [NameInMap("Confidence")]
                [Validation(Required=false)]
                public float? Confidence { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>未检测出风险</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>violent_explosion</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>high</para>
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
