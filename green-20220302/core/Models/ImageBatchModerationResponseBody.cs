// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class ImageBatchModerationResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code. A value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The results of the image content moderation.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ImageBatchModerationResponseBodyData Data { get; set; }
        public class ImageBatchModerationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The data ID of the moderation object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>26769ada6e264e7ba9aa048241e12be9</para>
            /// </summary>
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            /// <summary>
            /// <para>The ID of the manual review task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxx-xxxxx</para>
            /// </summary>
            [NameInMap("ManualTaskId")]
            [Validation(Required=false)]
            public string ManualTaskId { get; set; }

            /// <summary>
            /// <para>The array of parameter results, such as risk labels and confidence scores, for image detection.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ImageBatchModerationResponseBodyDataResult> Result { get; set; }
            public class ImageBatchModerationResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>The confidence score, ranging from 0 to 100, rounded to two decimal places. Some labels do not have a confidence score.</para>
                /// 
                /// <b>Example:</b>
                /// <para>81.22</para>
                /// </summary>
                [NameInMap("Confidence")]
                [Validation(Required=false)]
                public float? Confidence { get; set; }

                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>No risk detected</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The label returned after image content detection. Multiple labels and scores may be detected for the same image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>violent_explosion</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

            }

            /// <summary>
            /// <para>The array of parameter results, such as risk labels and confidence scores, for image detection of each service.</para>
            /// </summary>
            [NameInMap("Results")]
            [Validation(Required=false)]
            public List<ImageBatchModerationResponseBodyDataResults> Results { get; set; }
            public class ImageBatchModerationResponseBodyDataResults : TeaModel {
                /// <summary>
                /// <para>The auxiliary reference information for the image.</para>
                /// </summary>
                [NameInMap("Ext")]
                [Validation(Required=false)]
                public ImageBatchModerationResponseBodyDataResultsExt Ext { get; set; }
                public class ImageBatchModerationResponseBodyDataResultsExt : TeaModel {
                    /// <summary>
                    /// <para>The list of hits in custom image libraries.</para>
                    /// </summary>
                    [NameInMap("CustomImage")]
                    [Validation(Required=false)]
                    public List<ImageBatchModerationResponseBodyDataResultsExtCustomImage> CustomImage { get; set; }
                    public class ImageBatchModerationResponseBodyDataResultsExtCustomImage : TeaModel {
                        /// <summary>
                        /// <para>The ID of the matched custom image.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1965304870002</para>
                        /// </summary>
                        [NameInMap("ImageId")]
                        [Validation(Required=false)]
                        public string ImageId { get; set; }

                        /// <summary>
                        /// <para>The ID of the custom library.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1965304870002</para>
                        /// </summary>
                        [NameInMap("LibId")]
                        [Validation(Required=false)]
                        public string LibId { get; set; }

                        /// <summary>
                        /// <para>The name of the matched custom image library.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Whitelist</para>
                        /// </summary>
                        [NameInMap("LibName")]
                        [Validation(Required=false)]
                        public string LibName { get; set; }

                    }

                    /// <summary>
                    /// <para>The logo information.</para>
                    /// </summary>
                    [NameInMap("LogoData")]
                    [Validation(Required=false)]
                    public ImageBatchModerationResponseBodyDataResultsExtLogoData LogoData { get; set; }
                    public class ImageBatchModerationResponseBodyDataResultsExtLogoData : TeaModel {
                        /// <summary>
                        /// <para>The location information of the logo.</para>
                        /// </summary>
                        [NameInMap("Location")]
                        [Validation(Required=false)]
                        public ImageBatchModerationResponseBodyDataResultsExtLogoDataLocation Location { get; set; }
                        public class ImageBatchModerationResponseBodyDataResultsExtLogoDataLocation : TeaModel {
                            /// <summary>
                            /// <para>The height of the logo area, in pixels.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>440</para>
                            /// </summary>
                            [NameInMap("H")]
                            [Validation(Required=false)]
                            public int? H { get; set; }

                            /// <summary>
                            /// <para>The width of the logo area, in pixels.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>330</para>
                            /// </summary>
                            [NameInMap("W")]
                            [Validation(Required=false)]
                            public int? W { get; set; }

                            /// <summary>
                            /// <para>The distance from the upper-left corner of the text area to the y-axis, with the upper-left corner of the image as the coordinate origin, in pixels.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>11</para>
                            /// </summary>
                            [NameInMap("X")]
                            [Validation(Required=false)]
                            public int? X { get; set; }

                            /// <summary>
                            /// <para>The distance from the upper-left corner of the text area to the x-axis, with the upper-left corner of the image as the coordinate origin, in pixels.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>22</para>
                            /// </summary>
                            [NameInMap("Y")]
                            [Validation(Required=false)]
                            public int? Y { get; set; }

                        }

                        /// <summary>
                        /// <para>The logo information.</para>
                        /// </summary>
                        [NameInMap("Logo")]
                        [Validation(Required=false)]
                        public List<ImageBatchModerationResponseBodyDataResultsExtLogoDataLogo> Logo { get; set; }
                        public class ImageBatchModerationResponseBodyDataResultsExtLogoDataLogo : TeaModel {
                            /// <summary>
                            /// <para>The confidence score, ranging from 0 to 100, rounded to two decimal places.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>99.1</para>
                            /// </summary>
                            [NameInMap("Confidence")]
                            [Validation(Required=false)]
                            public float? Confidence { get; set; }

                            /// <summary>
                            /// <para>The logo category.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>logo_sns</para>
                            /// </summary>
                            [NameInMap("Label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                            /// <summary>
                            /// <para>The logo name.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Alibaba Cloud</para>
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The list of public figures.</para>
                    /// </summary>
                    [NameInMap("PublicFigure")]
                    [Validation(Required=false)]
                    public List<ImageBatchModerationResponseBodyDataResultsExtPublicFigure> PublicFigure { get; set; }
                    public class ImageBatchModerationResponseBodyDataResultsExtPublicFigure : TeaModel {
                        /// <summary>
                        /// <para>The ID of the recognized figure.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>12324222</para>
                        /// </summary>
                        [NameInMap("FigureId")]
                        [Validation(Required=false)]
                        public string FigureId { get; set; }

                        /// <summary>
                        /// <para>The name of the recognized figure.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>xxxxx</para>
                        /// </summary>
                        [NameInMap("FigureName")]
                        [Validation(Required=false)]
                        public string FigureName { get; set; }

                        /// <summary>
                        /// <para>The location information of the logo.</para>
                        /// </summary>
                        [NameInMap("Location")]
                        [Validation(Required=false)]
                        public List<ImageBatchModerationResponseBodyDataResultsExtPublicFigureLocation> Location { get; set; }
                        public class ImageBatchModerationResponseBodyDataResultsExtPublicFigureLocation : TeaModel {
                            /// <summary>
                            /// <para>The height of the text area, in pixels.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>440</para>
                            /// </summary>
                            [NameInMap("H")]
                            [Validation(Required=false)]
                            public int? H { get; set; }

                            /// <summary>
                            /// <para>The width of the text area, in pixels.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>330</para>
                            /// </summary>
                            [NameInMap("W")]
                            [Validation(Required=false)]
                            public int? W { get; set; }

                            /// <summary>
                            /// <para>The distance from the upper-left corner of the text area to the y-axis, with the upper-left corner of the image as the coordinate origin, in pixels.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>11</para>
                            /// </summary>
                            [NameInMap("X")]
                            [Validation(Required=false)]
                            public int? X { get; set; }

                            /// <summary>
                            /// <para>The distance from the upper-left corner of the text area to the x-axis, with the upper-left corner of the image as the coordinate origin, in pixels.</para>
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
                    /// <para>The text information detected in the image.</para>
                    /// </summary>
                    [NameInMap("TextInImage")]
                    [Validation(Required=false)]
                    public ImageBatchModerationResponseBodyDataResultsExtTextInImage TextInImage { get; set; }
                    public class ImageBatchModerationResponseBodyDataResultsExtTextInImage : TeaModel {
                        /// <summary>
                        /// <para>The custom library ID, custom library name, and custom words returned when a custom text library is matched.</para>
                        /// </summary>
                        [NameInMap("CustomText")]
                        [Validation(Required=false)]
                        public List<ImageBatchModerationResponseBodyDataResultsExtTextInImageCustomText> CustomText { get; set; }
                        public class ImageBatchModerationResponseBodyDataResultsExtTextInImageCustomText : TeaModel {
                            /// <summary>
                            /// <para>The custom words. Separate multiple words with commas.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Custom word 1,Custom word 2</para>
                            /// </summary>
                            [NameInMap("KeyWords")]
                            [Validation(Required=false)]
                            public string KeyWords { get; set; }

                            /// <summary>
                            /// <para>The ID of the custom library.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>123456</para>
                            /// </summary>
                            [NameInMap("LibId")]
                            [Validation(Required=false)]
                            public string LibId { get; set; }

                            /// <summary>
                            /// <para>The name of the custom library.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Custom library 1</para>
                            /// </summary>
                            [NameInMap("LibName")]
                            [Validation(Required=false)]
                            public string LibName { get; set; }

                        }

                        /// <summary>
                        /// <para>The text information of each line recognized in the image.</para>
                        /// </summary>
                        [NameInMap("OcrResult")]
                        [Validation(Required=false)]
                        public List<ImageBatchModerationResponseBodyDataResultsExtTextInImageOcrResult> OcrResult { get; set; }
                        public class ImageBatchModerationResponseBodyDataResultsExtTextInImageOcrResult : TeaModel {
                            /// <summary>
                            /// <para>The coordinate information of the text line.</para>
                            /// </summary>
                            [NameInMap("Location")]
                            [Validation(Required=false)]
                            public ImageBatchModerationResponseBodyDataResultsExtTextInImageOcrResultLocation Location { get; set; }
                            public class ImageBatchModerationResponseBodyDataResultsExtTextInImageOcrResultLocation : TeaModel {
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
                                /// <para>The distance from the upper-left corner of the text area to the y-axis, with the upper-left corner of the image as the coordinate origin, in pixels.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>11</para>
                                /// </summary>
                                [NameInMap("X")]
                                [Validation(Required=false)]
                                public int? X { get; set; }

                                /// <summary>
                                /// <para>The distance from the upper-left corner of the text area to the x-axis, with the upper-left corner of the image as the coordinate origin, in pixels.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>22</para>
                                /// </summary>
                                [NameInMap("Y")]
                                [Validation(Required=false)]
                                public int? Y { get; set; }

                            }

                            /// <summary>
                            /// <para>The text information.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>abcd</para>
                            /// </summary>
                            [NameInMap("Text")]
                            [Validation(Required=false)]
                            public string Text { get; set; }

                        }

                        /// <summary>
                        /// <para>The matched risk keywords.</para>
                        /// </summary>
                        [NameInMap("RiskWord")]
                        [Validation(Required=false)]
                        public List<string> RiskWord { get; set; }

                    }

                }

                /// <summary>
                /// <para>The array of parameter results, such as risk labels and confidence scores, for image detection.</para>
                /// </summary>
                [NameInMap("Result")]
                [Validation(Required=false)]
                public List<ImageBatchModerationResponseBodyDataResultsResult> Result { get; set; }
                public class ImageBatchModerationResponseBodyDataResultsResult : TeaModel {
                    /// <summary>
                    /// <para>The confidence score, ranging from 0 to 100, rounded to two decimal places. Some labels do not have a confidence score.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>81.22</para>
                    /// </summary>
                    [NameInMap("Confidence")]
                    [Validation(Required=false)]
                    public float? Confidence { get; set; }

                    /// <summary>
                    /// <para>The description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>No risk detected</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The label returned after image content detection. Multiple labels and scores may be detected for the same image.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>violent_explosion</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                }

                /// <summary>
                /// <para>The risk level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>high</para>
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

                /// <summary>
                /// <para>The detection service supported by Image Moderation Enhanced Edition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>baselineCheck</para>
                /// </summary>
                [NameInMap("Service")]
                [Validation(Required=false)]
                public string Service { get; set; }

            }

            /// <summary>
            /// <para>The risk level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

        }

        /// <summary>
        /// <para>The response message for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <para>The ID of the request. It is a unique identifier generated by Alibaba Cloud for the request and can be used to troubleshoot and locate issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6CF2815C-C8C7-4A01-B52E-FF6E24F53492</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
