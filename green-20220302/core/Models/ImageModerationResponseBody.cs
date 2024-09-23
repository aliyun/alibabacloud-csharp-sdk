// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class ImageModerationResponseBody : TeaModel {
        /// <summary>
        /// The returned HTTP status code. The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The moderation results.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ImageModerationResponseBodyData Data { get; set; }
        public class ImageModerationResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the moderated object.
            /// 
            /// >  If you specify the dataId parameter in the request, the value of the dataId parameter is returned in the response.
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
                /// The returned face attribute information
                /// </summary>
                [NameInMap("FaceData")]
                [Validation(Required=false)]
                public List<ImageModerationResponseBodyDataExtFaceData> FaceData { get; set; }
                public class ImageModerationResponseBodyDataExtFaceData : TeaModel {
                    /// <summary>
                    /// The age recognition result.
                    /// </summary>
                    [NameInMap("Age")]
                    [Validation(Required=false)]
                    public int? Age { get; set; }

                    /// <summary>
                    /// Indicates whether the recognition result of bangs is available.
                    /// </summary>
                    [NameInMap("Bang")]
                    [Validation(Required=false)]
                    public ImageModerationResponseBodyDataExtFaceDataBang Bang { get; set; }
                    public class ImageModerationResponseBodyDataExtFaceDataBang : TeaModel {
                        /// <summary>
                        /// The confidence level of the bang recognition result. Valid values: 0 to 100. A higher value indicates a more credible result.
                        /// </summary>
                        [NameInMap("Confidence")]
                        [Validation(Required=false)]
                        public float? Confidence { get; set; }

                        /// <summary>
                        /// Indicates whether the recognition result of bangs is available.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// The gender recognition result.
                    /// </summary>
                    [NameInMap("Gender")]
                    [Validation(Required=false)]
                    public ImageModerationResponseBodyDataExtFaceDataGender Gender { get; set; }
                    public class ImageModerationResponseBodyDataExtFaceDataGender : TeaModel {
                        /// <summary>
                        /// The confidence level of the gender recognition result. Valid values: 0 to 100. A higher value indicates a more credible result.
                        /// </summary>
                        [NameInMap("Confidence")]
                        [Validation(Required=false)]
                        public float? Confidence { get; set; }

                        /// <summary>
                        /// The gender recognition result. Valid values:
                        /// 
                        /// - Male
                        /// 
                        /// - FeMale
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// The recognition result of whether to wear glasses.
                    /// 
                    /// - None: No glasses.
                    /// 
                    /// - Wear: Wear glasses.
                    /// 
                    /// - Sunglass: Wear sunglasses.
                    /// </summary>
                    [NameInMap("Glasses")]
                    [Validation(Required=false)]
                    public string Glasses { get; set; }

                    /// <summary>
                    /// The hairstyle recognition result.
                    /// </summary>
                    [NameInMap("Hairstyle")]
                    [Validation(Required=false)]
                    public ImageModerationResponseBodyDataExtFaceDataHairstyle Hairstyle { get; set; }
                    public class ImageModerationResponseBodyDataExtFaceDataHairstyle : TeaModel {
                        /// <summary>
                        /// The confidence level of the hairstyle recognition result. Valid values: 0 to 100. A higher value indicates a more credible result.
                        /// </summary>
                        [NameInMap("Confidence")]
                        [Validation(Required=false)]
                        public float? Confidence { get; set; }

                        /// <summary>
                        /// The hairstyle recognition result. Valid values:
                        /// 
                        /// - Bald: bald head.
                        /// 
                        /// - Long: Long hair.
                        /// 
                        /// - Short: Short hair.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// The recognition result of whether to wear a hat.
                    /// </summary>
                    [NameInMap("Hat")]
                    [Validation(Required=false)]
                    public ImageModerationResponseBodyDataExtFaceDataHat Hat { get; set; }
                    public class ImageModerationResponseBodyDataExtFaceDataHat : TeaModel {
                        /// <summary>
                        /// The confidence level of the result of wearing the hat. Valid values: 0 to 100. A higher value indicates a more credible result.
                        /// </summary>
                        [NameInMap("Confidence")]
                        [Validation(Required=false)]
                        public float? Confidence { get; set; }

                        /// <summary>
                        /// The recognition result of whether to wear the hat. Valid values:
                        /// 
                        /// - Wear: Wear a hat.
                        /// 
                        /// - None: No hat.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// The location of the face.
                    /// </summary>
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public ImageModerationResponseBodyDataExtFaceDataLocation Location { get; set; }
                    public class ImageModerationResponseBodyDataExtFaceDataLocation : TeaModel {
                        /// <summary>
                        /// The height of the face area. Unit: pixels.
                        /// </summary>
                        [NameInMap("H")]
                        [Validation(Required=false)]
                        public int? H { get; set; }

                        /// <summary>
                        /// The width of the face area. Unit: pixels.
                        /// </summary>
                        [NameInMap("W")]
                        [Validation(Required=false)]
                        public int? W { get; set; }

                        /// <summary>
                        /// The distance from the upper-left corner of the face area to the y-axis with the upper-left corner of the image as the coordinate origin. Unit: pixels.
                        /// </summary>
                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public int? X { get; set; }

                        /// <summary>
                        /// The distance from the upper-left corner of the face area to the x-axis with the upper-left corner of the image as the coordinate origin. Unit: pixels.
                        /// </summary>
                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public int? Y { get; set; }

                    }

                    /// <summary>
                    /// The recognition result of whether to wear a mask.
                    /// </summary>
                    [NameInMap("Mask")]
                    [Validation(Required=false)]
                    public ImageModerationResponseBodyDataExtFaceDataMask Mask { get; set; }
                    public class ImageModerationResponseBodyDataExtFaceDataMask : TeaModel {
                        /// <summary>
                        /// The confidence level of the result of wearing the mask. Valid values: 0 to 100. A higher value indicates a more credible result.
                        /// </summary>
                        [NameInMap("Confidence")]
                        [Validation(Required=false)]
                        public float? Confidence { get; set; }

                        /// <summary>
                        /// The recognition result of whether to wear a mask. Valid values:
                        /// 
                        /// - Wear a mask.
                        /// 
                        ///  - None: No mask.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// The identification result of whether there is a beard.
                    /// </summary>
                    [NameInMap("Mustache")]
                    [Validation(Required=false)]
                    public ImageModerationResponseBodyDataExtFaceDataMustache Mustache { get; set; }
                    public class ImageModerationResponseBodyDataExtFaceDataMustache : TeaModel {
                        /// <summary>
                        /// The confidence level of the result of the beard. Valid values: 0 to 100. A higher value indicates a more credible result.
                        /// </summary>
                        [NameInMap("Confidence")]
                        [Validation(Required=false)]
                        public float? Confidence { get; set; }

                        /// <summary>
                        /// The identification result of whether there is a beard.Valid values:
                        /// 
                        /// - Has:have a beard.
                        /// 
                        /// - None:No beard.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// The quality information of the face image.
                    /// </summary>
                    [NameInMap("Quality")]
                    [Validation(Required=false)]
                    public ImageModerationResponseBodyDataExtFaceDataQuality Quality { get; set; }
                    public class ImageModerationResponseBodyDataExtFaceDataQuality : TeaModel {
                        /// <summary>
                        /// The blur of the face image. Valid values: 0 to 100. The higher the score, the more fuzzy it is.
                        /// Recommended values: 0 to 25.
                        /// </summary>
                        [NameInMap("Blur")]
                        [Validation(Required=false)]
                        public float? Blur { get; set; }

                        /// <summary>
                        /// The integrity of the human face. Recommended values:80 to 100.
                        /// </summary>
                        [NameInMap("Integrity")]
                        [Validation(Required=false)]
                        public float? Integrity { get; set; }

                        /// <summary>
                        /// The head-up or head-down angle of the face.
                        /// Recommended values:-30 to 30.
                        /// </summary>
                        [NameInMap("Pitch")]
                        [Validation(Required=false)]
                        public float? Pitch { get; set; }

                        /// <summary>
                        /// The plane rotation angle of the face.
                        /// Recommended values:-30 to 30.
                        /// </summary>
                        [NameInMap("Roll")]
                        [Validation(Required=false)]
                        public float? Roll { get; set; }

                        /// <summary>
                        /// The left and right shaking angle of the human face.
                        /// Recommended values:-30 to 30.
                        /// </summary>
                        [NameInMap("Yaw")]
                        [Validation(Required=false)]
                        public float? Yaw { get; set; }

                    }

                    /// <summary>
                    /// The smiling degree of the face.
                    /// </summary>
                    [NameInMap("Smile")]
                    [Validation(Required=false)]
                    public float? Smile { get; set; }

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

                    /// <summary>
                    /// the data array of location info
                    /// </summary>
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public List<ImageModerationResponseBodyDataExtPublicFigureLocation> Location { get; set; }
                    public class ImageModerationResponseBodyDataExtPublicFigureLocation : TeaModel {
                        /// <summary>
                        /// The height
                        /// </summary>
                        [NameInMap("H")]
                        [Validation(Required=false)]
                        public int? H { get; set; }

                        /// <summary>
                        /// The weight
                        /// </summary>
                        [NameInMap("W")]
                        [Validation(Required=false)]
                        public int? W { get; set; }

                        /// <summary>
                        /// X coordinate
                        /// </summary>
                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public int? X { get; set; }

                        /// <summary>
                        /// Y coordinate
                        /// </summary>
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
            /// The results of image moderation parameters such as the label parameter and the confidence parameter, which are an array structure.
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
                /// The description of the result.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The labels returned after the image moderation. Multiple risk labels and the corresponding scores of confidence levels may be returned for an image.
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
        /// The request ID, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
