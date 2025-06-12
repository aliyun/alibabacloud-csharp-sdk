// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class ImageBatchModerationResponseBody : TeaModel {
        /// <summary>
        /// <para>Return code. A return of 200 represents success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The result of image content detection.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ImageBatchModerationResponseBodyData Data { get; set; }
        public class ImageBatchModerationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>To detect the data ID corresponding to the object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>26769ada6e264e7ba9aa048241e12be9</para>
            /// </summary>
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            [NameInMap("ManualTaskId")]
            [Validation(Required=false)]
            public string ManualTaskId { get; set; }

            /// <summary>
            /// <para>The risk labels, confidence scores, and other parameters of image detection results, in an array structure.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ImageBatchModerationResponseBodyDataResult> Result { get; set; }
            public class ImageBatchModerationResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>Confidence score, ranging from 0 to 100, retained to two decimal places. Some labels do not have a confidence score.</para>
                /// 
                /// <b>Example:</b>
                /// <para>81.22</para>
                /// </summary>
                [NameInMap("Confidence")]
                [Validation(Required=false)]
                public float? Confidence { get; set; }

                /// <summary>
                /// <para>Description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>No risk detected</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The labels returned after image content detection. A single image may be associated with multiple labels and corresponding scores.</para>
                /// 
                /// <b>Example:</b>
                /// <para>violent_explosion</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

            }

            /// <summary>
            /// <para>The risk labels, confidence scores, and other parameters for each service\&quot;s image detection, in an array structure.</para>
            /// </summary>
            [NameInMap("Results")]
            [Validation(Required=false)]
            public List<ImageBatchModerationResponseBodyDataResults> Results { get; set; }
            public class ImageBatchModerationResponseBodyDataResults : TeaModel {
                /// <summary>
                /// <para>Image supplementary reference information.</para>
                /// </summary>
                [NameInMap("Ext")]
                [Validation(Required=false)]
                public ImageBatchModerationResponseBodyDataResultsExt Ext { get; set; }
                public class ImageBatchModerationResponseBodyDataResultsExt : TeaModel {
                    /// <summary>
                    /// <para>Custom image library hit information list.</para>
                    /// </summary>
                    [NameInMap("CustomImage")]
                    [Validation(Required=false)]
                    public List<ImageBatchModerationResponseBodyDataResultsExtCustomImage> CustomImage { get; set; }
                    public class ImageBatchModerationResponseBodyDataResultsExtCustomImage : TeaModel {
                        /// <summary>
                        /// <para>The ID of the hit custom image.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1965304870002</para>
                        /// </summary>
                        [NameInMap("ImageId")]
                        [Validation(Required=false)]
                        public string ImageId { get; set; }

                        /// <summary>
                        /// <para>Custom library ID</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1965304870002</para>
                        /// </summary>
                        [NameInMap("LibId")]
                        [Validation(Required=false)]
                        public string LibId { get; set; }

                        /// <summary>
                        /// <para>The name of the hit custom gallery.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Whitelist</para>
                        /// </summary>
                        [NameInMap("LibName")]
                        [Validation(Required=false)]
                        public string LibName { get; set; }

                    }

                    /// <summary>
                    /// <para>Logo identification information.</para>
                    /// </summary>
                    [NameInMap("LogoData")]
                    [Validation(Required=false)]
                    public ImageBatchModerationResponseBodyDataResultsExtLogoData LogoData { get; set; }
                    public class ImageBatchModerationResponseBodyDataResultsExtLogoData : TeaModel {
                        /// <summary>
                        /// <para>The location information of the identifier.</para>
                        /// </summary>
                        [NameInMap("Location")]
                        [Validation(Required=false)]
                        public ImageBatchModerationResponseBodyDataResultsExtLogoDataLocation Location { get; set; }
                        public class ImageBatchModerationResponseBodyDataResultsExtLogoDataLocation : TeaModel {
                            /// <summary>
                            /// <para>The width of the text area, in pixels.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>440</para>
                            /// </summary>
                            [NameInMap("H")]
                            [Validation(Required=false)]
                            public int? H { get; set; }

                            /// <summary>
                            /// <para>The height of the text area, in pixels.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>330</para>
                            /// </summary>
                            [NameInMap("W")]
                            [Validation(Required=false)]
                            public int? W { get; set; }

                            /// <summary>
                            /// <para>The distance from the top-left corner of the text area to the y-axis, with the top-left corner of the image as the origin, in pixels.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>11</para>
                            /// </summary>
                            [NameInMap("X")]
                            [Validation(Required=false)]
                            public int? X { get; set; }

                            /// <summary>
                            /// <para>The distance from the top-left corner of the text area to the x-axis, with the top-left corner of the image as the origin, in pixels.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>22</para>
                            /// </summary>
                            [NameInMap("Y")]
                            [Validation(Required=false)]
                            public int? Y { get; set; }

                        }

                        /// <summary>
                        /// <para>identification information</para>
                        /// </summary>
                        [NameInMap("Logo")]
                        [Validation(Required=false)]
                        public List<ImageBatchModerationResponseBodyDataResultsExtLogoDataLogo> Logo { get; set; }
                        public class ImageBatchModerationResponseBodyDataResultsExtLogoDataLogo : TeaModel {
                            /// <summary>
                            /// <para>Confidence score, from 0 to 100, rounded to two decimal places.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>99.1</para>
                            /// </summary>
                            [NameInMap("Confidence")]
                            [Validation(Required=false)]
                            public float? Confidence { get; set; }

                            /// <summary>
                            /// <para>Identify the category.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>logo_sns</para>
                            /// </summary>
                            [NameInMap("Label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                            /// <summary>
                            /// <para>identifier  name.</para>
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
                    /// <para>List of character information.</para>
                    /// </summary>
                    [NameInMap("PublicFigure")]
                    [Validation(Required=false)]
                    public List<ImageBatchModerationResponseBodyDataResultsExtPublicFigure> PublicFigure { get; set; }
                    public class ImageBatchModerationResponseBodyDataResultsExtPublicFigure : TeaModel {
                        /// <summary>
                        /// <para>Identify the encoded information of the person.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>12324222</para>
                        /// </summary>
                        [NameInMap("FigureId")]
                        [Validation(Required=false)]
                        public string FigureId { get; set; }

                        /// <summary>
                        /// <para>The identified person\&quot;s name information.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>xxxxx</para>
                        /// </summary>
                        [NameInMap("FigureName")]
                        [Validation(Required=false)]
                        public string FigureName { get; set; }

                        /// <summary>
                        /// <para>The location information of the identifier.</para>
                        /// </summary>
                        [NameInMap("Location")]
                        [Validation(Required=false)]
                        public List<ImageBatchModerationResponseBodyDataResultsExtPublicFigureLocation> Location { get; set; }
                        public class ImageBatchModerationResponseBodyDataResultsExtPublicFigureLocation : TeaModel {
                            /// <summary>
                            /// <para>The width of the text area, in pixels.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>440</para>
                            /// </summary>
                            [NameInMap("H")]
                            [Validation(Required=false)]
                            public int? H { get; set; }

                            /// <summary>
                            /// <para>The height of the text area, in pixels.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>330</para>
                            /// </summary>
                            [NameInMap("W")]
                            [Validation(Required=false)]
                            public int? W { get; set; }

                            /// <summary>
                            /// <para>The distance from the top-left corner of the text area to the y-axis, with the top-left corner of the image as the origin, in pixels.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>11</para>
                            /// </summary>
                            [NameInMap("X")]
                            [Validation(Required=false)]
                            public int? X { get; set; }

                            /// <summary>
                            /// <para>The distance from the top-left corner of the text area to the x-axis, with the top-left corner of the image as the origin, in pixels.</para>
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
                    /// <para>Return the text information from the recognized images.</para>
                    /// </summary>
                    [NameInMap("TextInImage")]
                    [Validation(Required=false)]
                    public ImageBatchModerationResponseBodyDataResultsExtTextInImage TextInImage { get; set; }
                    public class ImageBatchModerationResponseBodyDataResultsExtTextInImage : TeaModel {
                        /// <summary>
                        /// <para>When a custom text library is matched, return the custom library ID, custom library name, and custom words.</para>
                        /// </summary>
                        [NameInMap("CustomText")]
                        [Validation(Required=false)]
                        public List<ImageBatchModerationResponseBodyDataResultsExtTextInImageCustomText> CustomText { get; set; }
                        public class ImageBatchModerationResponseBodyDataResultsExtTextInImageCustomText : TeaModel {
                            /// <summary>
                            /// <para>Custom words, separate multiple words with commas.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Custom Word 1  and  Custom Word 2</para>
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
                            /// <para>Custom Library 1</para>
                            /// </summary>
                            [NameInMap("LibName")]
                            [Validation(Required=false)]
                            public string LibName { get; set; }

                        }

                        /// <summary>
                        /// <para>Return the text information of each line recognized in the image.</para>
                        /// </summary>
                        [NameInMap("OcrResult")]
                        [Validation(Required=false)]
                        public List<ImageBatchModerationResponseBodyDataResultsExtTextInImageOcrResult> OcrResult { get; set; }
                        public class ImageBatchModerationResponseBodyDataResultsExtTextInImageOcrResult : TeaModel {
                            /// <summary>
                            /// <para>Text line coordinate information.</para>
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
                                /// <para>The distance from the top-left corner of the text area to the y-axis, with the top-left corner of the image as the origin, in pixels.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>11</para>
                                /// </summary>
                                [NameInMap("X")]
                                [Validation(Required=false)]
                                public int? X { get; set; }

                                /// <summary>
                                /// <para>The distance from the top-left corner of the text area to the x-axis, with the top-left corner of the image as the origin, in pixels.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>22</para>
                                /// </summary>
                                [NameInMap("Y")]
                                [Validation(Required=false)]
                                public int? Y { get; set; }

                            }

                            /// <summary>
                            /// <para>Text information.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>abcd</para>
                            /// </summary>
                            [NameInMap("Text")]
                            [Validation(Required=false)]
                            public string Text { get; set; }

                        }

                        /// <summary>
                        /// <para>hit risk keywords</para>
                        /// </summary>
                        [NameInMap("RiskWord")]
                        [Validation(Required=false)]
                        public List<string> RiskWord { get; set; }

                    }

                }

                /// <summary>
                /// <para>The risk labels, confidence scores, and other parameters of image detection results, in an array structure.</para>
                /// </summary>
                [NameInMap("Result")]
                [Validation(Required=false)]
                public List<ImageBatchModerationResponseBodyDataResultsResult> Result { get; set; }
                public class ImageBatchModerationResponseBodyDataResultsResult : TeaModel {
                    /// <summary>
                    /// <para>Confidence score, ranging from 0 to 100, rounded to two decimal places. Some labels do not have a confidence score.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>81.22</para>
                    /// </summary>
                    [NameInMap("Confidence")]
                    [Validation(Required=false)]
                    public float? Confidence { get; set; }

                    /// <summary>
                    /// <para>Description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>No risk detected</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The labels returned after image content detection. A single image may have multiple labels and corresponding scores detected.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>violent_explosion</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                }

                /// <summary>
                /// <para>Risk level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>high</para>
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

                /// <summary>
                /// <para>The enhanced image detection service supports various detection services.</para>
                /// 
                /// <b>Example:</b>
                /// <para>baselineCheck</para>
                /// </summary>
                [NameInMap("Service")]
                [Validation(Required=false)]
                public string Service { get; set; }

            }

            /// <summary>
            /// <para>Risk level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

        }

        /// <summary>
        /// <para>The response message for this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <para>The ID of this invocation request, generated by Alibaba Cloud as a unique identifier for the request, can be used for troubleshooting and pinpointing issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6CF2815C-C8C7-4A01-B52E-FF6E24F53492</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
