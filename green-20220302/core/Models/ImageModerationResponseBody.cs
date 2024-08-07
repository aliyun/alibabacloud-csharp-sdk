// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class ImageModerationResponseBody : TeaModel {
        /// <summary>
        /// The returned HTTP status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ImageModerationResponseBodyData Data { get; set; }
        public class ImageModerationResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the moderated object.
            /// </summary>
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            /// <summary>
            /// Auxiliary reference information.
            /// </summary>
            [NameInMap("Ext")]
            [Validation(Required=false)]
            public ImageModerationResponseBodyDataExt Ext { get; set; }
            public class ImageModerationResponseBodyDataExt : TeaModel {
                /// <summary>
                /// If a custom image library is hit, information about the hit custom image library is returned.
                /// </summary>
                [NameInMap("CustomImage")]
                [Validation(Required=false)]
                public List<ImageModerationResponseBodyDataExtCustomImage> CustomImage { get; set; }
                public class ImageModerationResponseBodyDataExtCustomImage : TeaModel {
                    /// <summary>
                    /// The image ID.
                    /// </summary>
                    [NameInMap("ImageId")]
                    [Validation(Required=false)]
                    public string ImageId { get; set; }

                    /// <summary>
                    /// The image library ID.
                    /// </summary>
                    [NameInMap("LibId")]
                    [Validation(Required=false)]
                    public string LibId { get; set; }

                    /// <summary>
                    /// The image library name.
                    /// </summary>
                    [NameInMap("LibName")]
                    [Validation(Required=false)]
                    public string LibName { get; set; }

                }

                /// <summary>
                /// Logo information.
                /// </summary>
                [NameInMap("LogoData")]
                [Validation(Required=false)]
                public List<ImageModerationResponseBodyDataExtLogoData> LogoData { get; set; }
                public class ImageModerationResponseBodyDataExtLogoData : TeaModel {
                    /// <summary>
                    /// Location information.
                    /// </summary>
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public ImageModerationResponseBodyDataExtLogoDataLocation Location { get; set; }
                    public class ImageModerationResponseBodyDataExtLogoDataLocation : TeaModel {
                        /// <summary>
                        /// The height of the text area, in pixels.
                        /// </summary>
                        [NameInMap("H")]
                        [Validation(Required=false)]
                        public int? H { get; set; }

                        /// <summary>
                        /// The width of the text area, in pixels.
                        /// </summary>
                        [NameInMap("W")]
                        [Validation(Required=false)]
                        public int? W { get; set; }

                        /// <summary>
                        /// The distance between the upper-left corner of the text area and the y-axis, using the upper-left corner of the image as the coordinate origin, in pixels.
                        /// </summary>
                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public int? X { get; set; }

                        /// <summary>
                        /// The distance between the upper left corner of the text area and the x-axis, with the upper left corner of the image as the coordinate origin, in pixels.
                        /// </summary>
                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public int? Y { get; set; }

                    }

                    /// <summary>
                    /// Logo information.
                    /// </summary>
                    [NameInMap("Logo")]
                    [Validation(Required=false)]
                    public List<ImageModerationResponseBodyDataExtLogoDataLogo> Logo { get; set; }
                    public class ImageModerationResponseBodyDataExtLogoDataLogo : TeaModel {
                        /// <summary>
                        /// The score of the confidence level. Valid values: 0 to 100. The value is accurate to two decimal places. Some labels do not have scores of confidence levels.
                        /// </summary>
                        [NameInMap("Confidence")]
                        [Validation(Required=false)]
                        public float? Confidence { get; set; }

                        /// <summary>
                        /// Logo category.
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// Logo name.
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                }

                /// <summary>
                /// Returns the text information in the recognized image.
                /// </summary>
                [NameInMap("OcrResult")]
                [Validation(Required=false)]
                public List<ImageModerationResponseBodyDataExtOcrResult> OcrResult { get; set; }
                public class ImageModerationResponseBodyDataExtOcrResult : TeaModel {
                    /// <summary>
                    /// Location information.
                    /// </summary>
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public ImageModerationResponseBodyDataExtOcrResultLocation Location { get; set; }
                    public class ImageModerationResponseBodyDataExtOcrResultLocation : TeaModel {
                        /// <summary>
                        /// The height of the text area, in pixels.
                        /// </summary>
                        [NameInMap("H")]
                        [Validation(Required=false)]
                        public int? H { get; set; }

                        /// <summary>
                        /// The width of the text area, in pixels.
                        /// </summary>
                        [NameInMap("W")]
                        [Validation(Required=false)]
                        public int? W { get; set; }

                        /// <summary>
                        /// The distance between the upper-left corner of the text area and the y-axis, using the upper-left corner of the image as the coordinate origin, in pixels.
                        /// </summary>
                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public int? X { get; set; }

                        /// <summary>
                        /// The distance between the upper left corner of the text area and the x-axis, with the upper left corner of the image as the coordinate origin, in pixels.
                        /// </summary>
                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public int? Y { get; set; }

                    }

                    /// <summary>
                    /// The text information in the recognized image.
                    /// </summary>
                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                }

                /// <summary>
                /// Person information list.
                /// </summary>
                [NameInMap("PublicFigure")]
                [Validation(Required=false)]
                public List<ImageModerationResponseBodyDataExtPublicFigure> PublicFigure { get; set; }
                public class ImageModerationResponseBodyDataExtPublicFigure : TeaModel {
                    /// <summary>
                    /// Identified person coding information.
                    /// </summary>
                    [NameInMap("FigureId")]
                    [Validation(Required=false)]
                    public string FigureId { get; set; }

                    /// <summary>
                    /// Identified person name information.
                    /// </summary>
                    [NameInMap("FigureName")]
                    [Validation(Required=false)]
                    public string FigureName { get; set; }

                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public List<ImageModerationResponseBodyDataExtPublicFigureLocation> Location { get; set; }
                    public class ImageModerationResponseBodyDataExtPublicFigureLocation : TeaModel {
                        [NameInMap("H")]
                        [Validation(Required=false)]
                        public int? H { get; set; }

                        [NameInMap("W")]
                        [Validation(Required=false)]
                        public int? W { get; set; }

                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public int? X { get; set; }

                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public int? Y { get; set; }

                    }

                }

                /// <summary>
                /// The result of image recognition.
                /// </summary>
                [NameInMap("Recognition")]
                [Validation(Required=false)]
                public List<ImageModerationResponseBodyDataExtRecognition> Recognition { get; set; }
                public class ImageModerationResponseBodyDataExtRecognition : TeaModel {
                    /// <summary>
                    /// The category of image recognition.
                    /// </summary>
                    [NameInMap("Classification")]
                    [Validation(Required=false)]
                    public string Classification { get; set; }

                    /// <summary>
                    /// The score of the confidence level. Valid values: 0 to 100. The value is accurate to two decimal places. Some labels do not have scores of confidence levels.
                    /// </summary>
                    [NameInMap("Confidence")]
                    [Validation(Required=false)]
                    public float? Confidence { get; set; }

                }

                /// <summary>
                /// Returns the text information in the hit image.
                /// </summary>
                [NameInMap("TextInImage")]
                [Validation(Required=false)]
                public ImageModerationResponseBodyDataExtTextInImage TextInImage { get; set; }
                public class ImageModerationResponseBodyDataExtTextInImage : TeaModel {
                    /// <summary>
                    /// When a custom text library is hit, the custom library ID, custom library name, and custom word are returned.
                    /// </summary>
                    [NameInMap("CustomText")]
                    [Validation(Required=false)]
                    public List<ImageModerationResponseBodyDataExtTextInImageCustomText> CustomText { get; set; }
                    public class ImageModerationResponseBodyDataExtTextInImageCustomText : TeaModel {
                        /// <summary>
                        /// Custom words, multiple words separated by commas.
                        /// </summary>
                        [NameInMap("KeyWords")]
                        [Validation(Required=false)]
                        public string KeyWords { get; set; }

                        /// <summary>
                        /// Custom library ID.
                        /// </summary>
                        [NameInMap("LibId")]
                        [Validation(Required=false)]
                        public string LibId { get; set; }

                        /// <summary>
                        /// Custom library name.
                        /// </summary>
                        [NameInMap("LibName")]
                        [Validation(Required=false)]
                        public string LibName { get; set; }

                    }

                    /// <summary>
                    /// Returns the text information in the recognized image.
                    /// </summary>
                    [NameInMap("OcrResult")]
                    [Validation(Required=false)]
                    public List<ImageModerationResponseBodyDataExtTextInImageOcrResult> OcrResult { get; set; }
                    public class ImageModerationResponseBodyDataExtTextInImageOcrResult : TeaModel {
                        /// <summary>
                        /// Location information.
                        /// </summary>
                        [NameInMap("Location")]
                        [Validation(Required=false)]
                        public ImageModerationResponseBodyDataExtTextInImageOcrResultLocation Location { get; set; }
                        public class ImageModerationResponseBodyDataExtTextInImageOcrResultLocation : TeaModel {
                            /// <summary>
                            /// The height of the text area, in pixels.
                            /// </summary>
                            [NameInMap("H")]
                            [Validation(Required=false)]
                            public int? H { get; set; }

                            /// <summary>
                            /// The width of the text area, in pixels.
                            /// </summary>
                            [NameInMap("W")]
                            [Validation(Required=false)]
                            public int? W { get; set; }

                            /// <summary>
                            /// The distance between the upper-left corner of the text area and the y-axis, using the upper-left corner of the image as the coordinate origin, in pixels.
                            /// </summary>
                            [NameInMap("X")]
                            [Validation(Required=false)]
                            public int? X { get; set; }

                            /// <summary>
                            /// The distance between the upper left corner of the text area and the x-axis, with the upper left corner of the image as the coordinate origin, in pixels.
                            /// </summary>
                            [NameInMap("Y")]
                            [Validation(Required=false)]
                            public int? Y { get; set; }

                        }

                        /// <summary>
                        /// The text information in the recognized image.
                        /// </summary>
                        [NameInMap("Text")]
                        [Validation(Required=false)]
                        public string Text { get; set; }

                    }

                    /// <summary>
                    /// The risk words that are hit. Multiple words are separated by commas (,).
                    /// </summary>
                    [NameInMap("RiskWord")]
                    [Validation(Required=false)]
                    public List<string> RiskWord { get; set; }

                }

            }

            /// <summary>
            /// The results of image moderation parameters such as the label parameter and the confidence parameter.
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ImageModerationResponseBodyDataResult> Result { get; set; }
            public class ImageModerationResponseBodyDataResult : TeaModel {
                /// <summary>
                /// The score of the confidence level. Valid values: 0 to 100. The value is accurate to two decimal places. Some labels do not have scores of confidence levels.
                /// </summary>
                [NameInMap("Confidence")]
                [Validation(Required=false)]
                public float? Confidence { get; set; }

                /// <summary>
                /// The labels returned after the image moderation.
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

            }

            /// <summary>
            /// Risk Level.
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

        }

        /// <summary>
        /// The message that is returned in response to the request.
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
