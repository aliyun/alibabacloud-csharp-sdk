// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class ImageModerationResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned HTTP status code. The status code 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The moderation results.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ImageModerationResponseBodyData Data { get; set; }
        public class ImageModerationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the moderated object.</para>
            /// <remarks>
            /// <para> If you specify the dataId parameter in the request, the value of the dataId parameter is returned in the response.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>fb5ffab1-993b-449f-b8d6-b97d5e3331f2</para>
            /// </summary>
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            /// <summary>
            /// <para>Auxiliary reference information.</para>
            /// </summary>
            [NameInMap("Ext")]
            [Validation(Required=false)]
            public ImageModerationResponseBodyDataExt Ext { get; set; }
            public class ImageModerationResponseBodyDataExt : TeaModel {
                /// <summary>
                /// <para>If a custom image library is hit, information about the hit custom image library is returned.</para>
                /// </summary>
                [NameInMap("CustomImage")]
                [Validation(Required=false)]
                public List<ImageModerationResponseBodyDataExtCustomImage> CustomImage { get; set; }
                public class ImageModerationResponseBodyDataExtCustomImage : TeaModel {
                    /// <summary>
                    /// <para>The image ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123456</para>
                    /// </summary>
                    [NameInMap("ImageId")]
                    [Validation(Required=false)]
                    public string ImageId { get; set; }

                    /// <summary>
                    /// <para>The image library ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>lib_123456</para>
                    /// </summary>
                    [NameInMap("LibId")]
                    [Validation(Required=false)]
                    public string LibId { get; set; }

                    /// <summary>
                    /// <para>The image library name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xx</para>
                    /// </summary>
                    [NameInMap("LibName")]
                    [Validation(Required=false)]
                    public string LibName { get; set; }

                }

                /// <summary>
                /// <para>The returned face attribute information</para>
                /// </summary>
                [NameInMap("FaceData")]
                [Validation(Required=false)]
                public List<ImageModerationResponseBodyDataExtFaceData> FaceData { get; set; }
                public class ImageModerationResponseBodyDataExtFaceData : TeaModel {
                    /// <summary>
                    /// <para>The age recognition result.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>18</para>
                    /// </summary>
                    [NameInMap("Age")]
                    [Validation(Required=false)]
                    public int? Age { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the recognition result of bangs is available.</para>
                    /// </summary>
                    [NameInMap("Bang")]
                    [Validation(Required=false)]
                    public ImageModerationResponseBodyDataExtFaceDataBang Bang { get; set; }
                    public class ImageModerationResponseBodyDataExtFaceDataBang : TeaModel {
                        /// <summary>
                        /// <para>The confidence level of the bang recognition result. Valid values: 0 to 100. A higher value indicates a more credible result.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>81.88</para>
                        /// </summary>
                        [NameInMap("Confidence")]
                        [Validation(Required=false)]
                        public float? Confidence { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the recognition result of bangs is available.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Has</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The gender recognition result.</para>
                    /// </summary>
                    [NameInMap("Gender")]
                    [Validation(Required=false)]
                    public ImageModerationResponseBodyDataExtFaceDataGender Gender { get; set; }
                    public class ImageModerationResponseBodyDataExtFaceDataGender : TeaModel {
                        /// <summary>
                        /// <para>The confidence level of the gender recognition result. Valid values: 0 to 100. A higher value indicates a more credible result.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>81.88</para>
                        /// </summary>
                        [NameInMap("Confidence")]
                        [Validation(Required=false)]
                        public float? Confidence { get; set; }

                        /// <summary>
                        /// <para>The gender recognition result. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><para>Male</para>
                        /// </description></item>
                        /// <item><description><para>FeMale</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>FeMale</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The recognition result of whether to wear glasses.</para>
                    /// <list type="bullet">
                    /// <item><description><para>None: No glasses.</para>
                    /// </description></item>
                    /// <item><description><para>Wear: Wear glasses.</para>
                    /// </description></item>
                    /// <item><description><para>Sunglass: Wear sunglasses.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Common</para>
                    /// </summary>
                    [NameInMap("Glasses")]
                    [Validation(Required=false)]
                    public string Glasses { get; set; }

                    /// <summary>
                    /// <para>The hairstyle recognition result.</para>
                    /// </summary>
                    [NameInMap("Hairstyle")]
                    [Validation(Required=false)]
                    public ImageModerationResponseBodyDataExtFaceDataHairstyle Hairstyle { get; set; }
                    public class ImageModerationResponseBodyDataExtFaceDataHairstyle : TeaModel {
                        /// <summary>
                        /// <para>The confidence level of the hairstyle recognition result. Valid values: 0 to 100. A higher value indicates a more credible result.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>81.88</para>
                        /// </summary>
                        [NameInMap("Confidence")]
                        [Validation(Required=false)]
                        public float? Confidence { get; set; }

                        /// <summary>
                        /// <para>The hairstyle recognition result. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><para>Bald: bald head.</para>
                        /// </description></item>
                        /// <item><description><para>Long: Long hair.</para>
                        /// </description></item>
                        /// <item><description><para>Short: Short hair.</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Short</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The recognition result of whether to wear a hat.</para>
                    /// </summary>
                    [NameInMap("Hat")]
                    [Validation(Required=false)]
                    public ImageModerationResponseBodyDataExtFaceDataHat Hat { get; set; }
                    public class ImageModerationResponseBodyDataExtFaceDataHat : TeaModel {
                        /// <summary>
                        /// <para>The confidence level of the result of wearing the hat. Valid values: 0 to 100. A higher value indicates a more credible result.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>88.88</para>
                        /// </summary>
                        [NameInMap("Confidence")]
                        [Validation(Required=false)]
                        public float? Confidence { get; set; }

                        /// <summary>
                        /// <para>The recognition result of whether to wear the hat. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><para>Wear: Wear a hat.</para>
                        /// </description></item>
                        /// <item><description><para>None: No hat.</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Wear</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The location of the face.</para>
                    /// </summary>
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public ImageModerationResponseBodyDataExtFaceDataLocation Location { get; set; }
                    public class ImageModerationResponseBodyDataExtFaceDataLocation : TeaModel {
                        /// <summary>
                        /// <para>The height of the face area. Unit: pixels.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>26</para>
                        /// </summary>
                        [NameInMap("H")]
                        [Validation(Required=false)]
                        public int? H { get; set; }

                        /// <summary>
                        /// <para>The width of the face area. Unit: pixels.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>83</para>
                        /// </summary>
                        [NameInMap("W")]
                        [Validation(Required=false)]
                        public int? W { get; set; }

                        /// <summary>
                        /// <para>The distance from the upper-left corner of the face area to the y-axis with the upper-left corner of the image as the coordinate origin. Unit: pixels.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>41</para>
                        /// </summary>
                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public int? X { get; set; }

                        /// <summary>
                        /// <para>The distance from the upper-left corner of the face area to the x-axis with the upper-left corner of the image as the coordinate origin. Unit: pixels.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>84</para>
                        /// </summary>
                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public int? Y { get; set; }

                    }

                    /// <summary>
                    /// <para>The recognition result of whether to wear a mask.</para>
                    /// </summary>
                    [NameInMap("Mask")]
                    [Validation(Required=false)]
                    public ImageModerationResponseBodyDataExtFaceDataMask Mask { get; set; }
                    public class ImageModerationResponseBodyDataExtFaceDataMask : TeaModel {
                        /// <summary>
                        /// <para>The confidence level of the result of wearing the mask. Valid values: 0 to 100. A higher value indicates a more credible result.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>99.99</para>
                        /// </summary>
                        [NameInMap("Confidence")]
                        [Validation(Required=false)]
                        public float? Confidence { get; set; }

                        /// <summary>
                        /// <para>The recognition result of whether to wear a mask. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><para>Wear a mask.</para>
                        /// </description></item>
                        /// <item><description><para>None: No mask.</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Wear</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The identification result of whether there is a beard.</para>
                    /// </summary>
                    [NameInMap("Mustache")]
                    [Validation(Required=false)]
                    public ImageModerationResponseBodyDataExtFaceDataMustache Mustache { get; set; }
                    public class ImageModerationResponseBodyDataExtFaceDataMustache : TeaModel {
                        /// <summary>
                        /// <para>The confidence level of the result of the beard. Valid values: 0 to 100. A higher value indicates a more credible result.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>99.99</para>
                        /// </summary>
                        [NameInMap("Confidence")]
                        [Validation(Required=false)]
                        public float? Confidence { get; set; }

                        /// <summary>
                        /// <para>The identification result of whether there is a beard.Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><para>Has:have a beard.</para>
                        /// </description></item>
                        /// <item><description><para>None:No beard.</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Has</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The quality information of the face image.</para>
                    /// </summary>
                    [NameInMap("Quality")]
                    [Validation(Required=false)]
                    public ImageModerationResponseBodyDataExtFaceDataQuality Quality { get; set; }
                    public class ImageModerationResponseBodyDataExtFaceDataQuality : TeaModel {
                        /// <summary>
                        /// <para>The blur of the face image. Valid values: 0 to 100. The higher the score, the more fuzzy it is.
                        /// Recommended values: 0 to 25.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>5.88</para>
                        /// </summary>
                        [NameInMap("Blur")]
                        [Validation(Required=false)]
                        public float? Blur { get; set; }

                        /// <summary>
                        /// <para>The integrity of the human face. Recommended values:80 to 100.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100.0</para>
                        /// </summary>
                        [NameInMap("Integrity")]
                        [Validation(Required=false)]
                        public float? Integrity { get; set; }

                        /// <summary>
                        /// <para>The head-up or head-down angle of the face.
                        /// Recommended values:-30 to 30.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>5.88</para>
                        /// </summary>
                        [NameInMap("Pitch")]
                        [Validation(Required=false)]
                        public float? Pitch { get; set; }

                        /// <summary>
                        /// <para>The plane rotation angle of the face.
                        /// Recommended values:-30 to 30.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>5.18</para>
                        /// </summary>
                        [NameInMap("Roll")]
                        [Validation(Required=false)]
                        public float? Roll { get; set; }

                        /// <summary>
                        /// <para>The left and right shaking angle of the human face.
                        /// Recommended values:-30 to 30.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>5.18</para>
                        /// </summary>
                        [NameInMap("Yaw")]
                        [Validation(Required=false)]
                        public float? Yaw { get; set; }

                    }

                    /// <summary>
                    /// <para>The smiling degree of the face.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>85.88</para>
                    /// </summary>
                    [NameInMap("Smile")]
                    [Validation(Required=false)]
                    public float? Smile { get; set; }

                }

                /// <summary>
                /// <para>Logo information.</para>
                /// </summary>
                [NameInMap("LogoData")]
                [Validation(Required=false)]
                public List<ImageModerationResponseBodyDataExtLogoData> LogoData { get; set; }
                public class ImageModerationResponseBodyDataExtLogoData : TeaModel {
                    /// <summary>
                    /// <para>Location information.</para>
                    /// </summary>
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public ImageModerationResponseBodyDataExtLogoDataLocation Location { get; set; }
                    public class ImageModerationResponseBodyDataExtLogoDataLocation : TeaModel {
                        /// <summary>
                        /// <para>The height of the text area, in pixels.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>44</para>
                        /// </summary>
                        [NameInMap("H")]
                        [Validation(Required=false)]
                        public int? H { get; set; }

                        /// <summary>
                        /// <para>The width of the text area, in pixels.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>33</para>
                        /// </summary>
                        [NameInMap("W")]
                        [Validation(Required=false)]
                        public int? W { get; set; }

                        /// <summary>
                        /// <para>The distance between the upper-left corner of the text area and the y-axis, using the upper-left corner of the image as the coordinate origin, in pixels.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>11</para>
                        /// </summary>
                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public int? X { get; set; }

                        /// <summary>
                        /// <para>The distance between the upper left corner of the text area and the x-axis, with the upper left corner of the image as the coordinate origin, in pixels.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>22</para>
                        /// </summary>
                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public int? Y { get; set; }

                    }

                    /// <summary>
                    /// <para>Logo information.</para>
                    /// </summary>
                    [NameInMap("Logo")]
                    [Validation(Required=false)]
                    public List<ImageModerationResponseBodyDataExtLogoDataLogo> Logo { get; set; }
                    public class ImageModerationResponseBodyDataExtLogoDataLogo : TeaModel {
                        /// <summary>
                        /// <para>The score of the confidence level. Valid values: 0 to 100. The value is accurate to two decimal places. Some labels do not have scores of confidence levels.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>99.01</para>
                        /// </summary>
                        [NameInMap("Confidence")]
                        [Validation(Required=false)]
                        public float? Confidence { get; set; }

                        /// <summary>
                        /// <para>Logo category.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>xx</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// <para>Logo name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>xx</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                }

                /// <summary>
                /// <para>Returns the text information in the recognized image.</para>
                /// </summary>
                [NameInMap("OcrResult")]
                [Validation(Required=false)]
                public List<ImageModerationResponseBodyDataExtOcrResult> OcrResult { get; set; }
                public class ImageModerationResponseBodyDataExtOcrResult : TeaModel {
                    /// <summary>
                    /// <para>Location information.</para>
                    /// </summary>
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public ImageModerationResponseBodyDataExtOcrResultLocation Location { get; set; }
                    public class ImageModerationResponseBodyDataExtOcrResultLocation : TeaModel {
                        /// <summary>
                        /// <para>The height of the text area, in pixels.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>44</para>
                        /// </summary>
                        [NameInMap("H")]
                        [Validation(Required=false)]
                        public int? H { get; set; }

                        /// <summary>
                        /// <para>The width of the text area, in pixels.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>33</para>
                        /// </summary>
                        [NameInMap("W")]
                        [Validation(Required=false)]
                        public int? W { get; set; }

                        /// <summary>
                        /// <para>The distance between the upper-left corner of the text area and the y-axis, using the upper-left corner of the image as the coordinate origin, in pixels.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>11</para>
                        /// </summary>
                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public int? X { get; set; }

                        /// <summary>
                        /// <para>The distance between the upper left corner of the text area and the x-axis, with the upper left corner of the image as the coordinate origin, in pixels.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>22</para>
                        /// </summary>
                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public int? Y { get; set; }

                    }

                    /// <summary>
                    /// <para>The text information in the recognized image.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xx</para>
                    /// </summary>
                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                }

                /// <summary>
                /// <para>Person information list.</para>
                /// </summary>
                [NameInMap("PublicFigure")]
                [Validation(Required=false)]
                public List<ImageModerationResponseBodyDataExtPublicFigure> PublicFigure { get; set; }
                public class ImageModerationResponseBodyDataExtPublicFigure : TeaModel {
                    /// <summary>
                    /// <para>Identified person coding information.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xx</para>
                    /// </summary>
                    [NameInMap("FigureId")]
                    [Validation(Required=false)]
                    public string FigureId { get; set; }

                    /// <summary>
                    /// <para>Identified person name information.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xx</para>
                    /// </summary>
                    [NameInMap("FigureName")]
                    [Validation(Required=false)]
                    public string FigureName { get; set; }

                    /// <summary>
                    /// <para>the data array of location info</para>
                    /// </summary>
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public List<ImageModerationResponseBodyDataExtPublicFigureLocation> Location { get; set; }
                    public class ImageModerationResponseBodyDataExtPublicFigureLocation : TeaModel {
                        /// <summary>
                        /// <para>The height</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>44</para>
                        /// </summary>
                        [NameInMap("H")]
                        [Validation(Required=false)]
                        public int? H { get; set; }

                        /// <summary>
                        /// <para>The weight</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>33</para>
                        /// </summary>
                        [NameInMap("W")]
                        [Validation(Required=false)]
                        public int? W { get; set; }

                        /// <summary>
                        /// <para>X coordinate</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>11</para>
                        /// </summary>
                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public int? X { get; set; }

                        /// <summary>
                        /// <para>Y coordinate</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>22</para>
                        /// </summary>
                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public int? Y { get; set; }

                    }

                }

                /// <summary>
                /// <para>The result of image recognition.</para>
                /// </summary>
                [NameInMap("Recognition")]
                [Validation(Required=false)]
                public List<ImageModerationResponseBodyDataExtRecognition> Recognition { get; set; }
                public class ImageModerationResponseBodyDataExtRecognition : TeaModel {
                    /// <summary>
                    /// <para>The category of image recognition.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xx</para>
                    /// </summary>
                    [NameInMap("Classification")]
                    [Validation(Required=false)]
                    public string Classification { get; set; }

                    /// <summary>
                    /// <para>The score of the confidence level. Valid values: 0 to 100. The value is accurate to two decimal places. Some labels do not have scores of confidence levels.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>99.01</para>
                    /// </summary>
                    [NameInMap("Confidence")]
                    [Validation(Required=false)]
                    public float? Confidence { get; set; }

                }

                /// <summary>
                /// <para>Returns the text information in the hit image.</para>
                /// </summary>
                [NameInMap("TextInImage")]
                [Validation(Required=false)]
                public ImageModerationResponseBodyDataExtTextInImage TextInImage { get; set; }
                public class ImageModerationResponseBodyDataExtTextInImage : TeaModel {
                    /// <summary>
                    /// <para>When a custom text library is hit, the custom library ID, custom library name, and custom word are returned.</para>
                    /// </summary>
                    [NameInMap("CustomText")]
                    [Validation(Required=false)]
                    public List<ImageModerationResponseBodyDataExtTextInImageCustomText> CustomText { get; set; }
                    public class ImageModerationResponseBodyDataExtTextInImageCustomText : TeaModel {
                        /// <summary>
                        /// <para>Custom words, multiple words separated by commas.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>aaa,bbb</para>
                        /// </summary>
                        [NameInMap("KeyWords")]
                        [Validation(Required=false)]
                        public string KeyWords { get; set; }

                        /// <summary>
                        /// <para>Custom library ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>123456</para>
                        /// </summary>
                        [NameInMap("LibId")]
                        [Validation(Required=false)]
                        public string LibId { get; set; }

                        /// <summary>
                        /// <para>Custom library name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>xxxx</para>
                        /// </summary>
                        [NameInMap("LibName")]
                        [Validation(Required=false)]
                        public string LibName { get; set; }

                    }

                    /// <summary>
                    /// <para>Returns the text information in the recognized image.</para>
                    /// </summary>
                    [NameInMap("OcrResult")]
                    [Validation(Required=false)]
                    public List<ImageModerationResponseBodyDataExtTextInImageOcrResult> OcrResult { get; set; }
                    public class ImageModerationResponseBodyDataExtTextInImageOcrResult : TeaModel {
                        /// <summary>
                        /// <para>Location information.</para>
                        /// </summary>
                        [NameInMap("Location")]
                        [Validation(Required=false)]
                        public ImageModerationResponseBodyDataExtTextInImageOcrResultLocation Location { get; set; }
                        public class ImageModerationResponseBodyDataExtTextInImageOcrResultLocation : TeaModel {
                            /// <summary>
                            /// <para>The height of the text area, in pixels.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>33</para>
                            /// </summary>
                            [NameInMap("H")]
                            [Validation(Required=false)]
                            public int? H { get; set; }

                            /// <summary>
                            /// <para>The width of the text area, in pixels.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>44</para>
                            /// </summary>
                            [NameInMap("W")]
                            [Validation(Required=false)]
                            public int? W { get; set; }

                            /// <summary>
                            /// <para>The distance between the upper-left corner of the text area and the y-axis, using the upper-left corner of the image as the coordinate origin, in pixels.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>11</para>
                            /// </summary>
                            [NameInMap("X")]
                            [Validation(Required=false)]
                            public int? X { get; set; }

                            /// <summary>
                            /// <para>The distance between the upper left corner of the text area and the x-axis, with the upper left corner of the image as the coordinate origin, in pixels.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>22</para>
                            /// </summary>
                            [NameInMap("Y")]
                            [Validation(Required=false)]
                            public int? Y { get; set; }

                        }

                        /// <summary>
                        /// <para>The text information in the recognized image.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>xx</para>
                        /// </summary>
                        [NameInMap("Text")]
                        [Validation(Required=false)]
                        public string Text { get; set; }

                    }

                    /// <summary>
                    /// <para>The risk words that are hit. Multiple words are separated by commas (,).</para>
                    /// </summary>
                    [NameInMap("RiskWord")]
                    [Validation(Required=false)]
                    public List<string> RiskWord { get; set; }

                }

            }

            /// <summary>
            /// <para>The results of image moderation parameters such as the label parameter and the confidence parameter, which are an array structure.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ImageModerationResponseBodyDataResult> Result { get; set; }
            public class ImageModerationResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>The score of the confidence level. Valid values: 0 to 100. The value is accurate to two decimal places. Some labels do not have scores of confidence levels.</para>
                /// 
                /// <b>Example:</b>
                /// <para>81.22</para>
                /// </summary>
                [NameInMap("Confidence")]
                [Validation(Required=false)]
                public float? Confidence { get; set; }

                /// <summary>
                /// <para>The description of the result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>no risk</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The labels returned after the image moderation. Multiple risk labels and the corresponding scores of confidence levels may be returned for an image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>violent_explosion</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

            }

            /// <summary>
            /// <para>Risk Level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

        }

        /// <summary>
        /// <para>The message that is returned in response to the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <para>The request ID, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6CF2815C-C8C7-4A01-B52E-FF6E24F53492</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
