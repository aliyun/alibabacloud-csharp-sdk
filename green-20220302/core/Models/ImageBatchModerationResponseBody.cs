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
            /// <para>The data ID of the moderated object.</para>
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
            /// <para>An array of results for the image moderation. The results contain parameters such as threat labels and confidence scores.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ImageBatchModerationResponseBodyDataResult> Result { get; set; }
            public class ImageBatchModerationResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>The confidence score. The value ranges from 0 to 100, with two decimal places. Some labels do not have a confidence score.</para>
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
                /// <para>未检测出风险</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The label returned after the image content moderation. An image may have multiple labels and scores.</para>
                /// 
                /// <b>Example:</b>
                /// <para>violent_explosion</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

            }

            /// <summary>
            /// <para>The detailed moderation results for each detection service. This is an array.</para>
            /// </summary>
            [NameInMap("Results")]
            [Validation(Required=false)]
            public List<ImageBatchModerationResponseBodyDataResults> Results { get; set; }
            public class ImageBatchModerationResponseBodyDataResults : TeaModel {
                /// <summary>
                /// <para>Additional reference information for the image.</para>
                /// </summary>
                [NameInMap("Ext")]
                [Validation(Required=false)]
                public ImageBatchModerationResponseBodyDataResultsExt Ext { get; set; }
                public class ImageBatchModerationResponseBodyDataResultsExt : TeaModel {
                    /// <summary>
                    /// <para>A list of hits in custom image libraries.</para>
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
                        /// <para>The ID of the custom library.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1965304870002</para>
                        /// </summary>
                        [NameInMap("LibId")]
                        [Validation(Required=false)]
                        public string LibId { get; set; }

                        /// <summary>
                        /// <para>The name of the hit custom image library.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>白名单</para>
                        /// </summary>
                        [NameInMap("LibName")]
                        [Validation(Required=false)]
                        public string LibName { get; set; }

                    }

                    /// <summary>
                    /// <para>Logo information.</para>
                    /// </summary>
                    [NameInMap("LogoData")]
                    [Validation(Required=false)]
                    public ImageBatchModerationResponseBodyDataResultsExtLogoData LogoData { get; set; }
                    public class ImageBatchModerationResponseBodyDataResultsExtLogoData : TeaModel {
                        /// <summary>
                        /// <para>The location of the recognized object.</para>
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
                            /// <para>The x-coordinate of the upper-left corner of the area, in pixels. The origin (0,0) is the upper-left corner of the image.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>11</para>
                            /// </summary>
                            [NameInMap("X")]
                            [Validation(Required=false)]
                            public int? X { get; set; }

                            /// <summary>
                            /// <para>The y-coordinate of the upper-left corner of the area, in pixels. The origin (0,0) is the upper-left corner of the image.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>22</para>
                            /// </summary>
                            [NameInMap("Y")]
                            [Validation(Required=false)]
                            public int? Y { get; set; }

                        }

                        /// <summary>
                        /// <para>Identity information.</para>
                        /// </summary>
                        [NameInMap("Logo")]
                        [Validation(Required=false)]
                        public List<ImageBatchModerationResponseBodyDataResultsExtLogoDataLogo> Logo { get; set; }
                        public class ImageBatchModerationResponseBodyDataResultsExtLogoDataLogo : TeaModel {
                            /// <summary>
                            /// <para>The confidence score. The value ranges from 0 to 100, with two decimal places.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>99.1</para>
                            /// </summary>
                            [NameInMap("Confidence")]
                            [Validation(Required=false)]
                            public float? Confidence { get; set; }

                            /// <summary>
                            /// <para>The category of the logo.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>logo_sns</para>
                            /// </summary>
                            [NameInMap("Label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                            /// <summary>
                            /// <para>The name of the logo.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>阿里云</para>
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>A list of public figures.</para>
                    /// </summary>
                    [NameInMap("PublicFigure")]
                    [Validation(Required=false)]
                    public List<ImageBatchModerationResponseBodyDataResultsExtPublicFigure> PublicFigure { get; set; }
                    public class ImageBatchModerationResponseBodyDataResultsExtPublicFigure : TeaModel {
                        /// <summary>
                        /// <para>The ID of the recognized public figure.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>12324222</para>
                        /// </summary>
                        [NameInMap("FigureId")]
                        [Validation(Required=false)]
                        public string FigureId { get; set; }

                        /// <summary>
                        /// <para>The name of the recognized public figure.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>xxxxx</para>
                        /// </summary>
                        [NameInMap("FigureName")]
                        [Validation(Required=false)]
                        public string FigureName { get; set; }

                        /// <summary>
                        /// <para>The location of the recognized object.</para>
                        /// </summary>
                        [NameInMap("Location")]
                        [Validation(Required=false)]
                        public List<ImageBatchModerationResponseBodyDataResultsExtPublicFigureLocation> Location { get; set; }
                        public class ImageBatchModerationResponseBodyDataResultsExtPublicFigureLocation : TeaModel {
                            /// <summary>
                            /// <para>The height of the area, in pixels.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>440</para>
                            /// </summary>
                            [NameInMap("H")]
                            [Validation(Required=false)]
                            public int? H { get; set; }

                            /// <summary>
                            /// <para>The width of the area, in pixels.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>330</para>
                            /// </summary>
                            [NameInMap("W")]
                            [Validation(Required=false)]
                            public int? W { get; set; }

                            /// <summary>
                            /// <para>The x-coordinate of the upper-left corner of the area, in pixels. The origin (0,0) is the upper-left corner of the image.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>11</para>
                            /// </summary>
                            [NameInMap("X")]
                            [Validation(Required=false)]
                            public int? X { get; set; }

                            /// <summary>
                            /// <para>The y-coordinate of the upper-left corner of the area, in pixels. The origin (0,0) is the upper-left corner of the image.</para>
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
                    /// <para>The text detected in the image.</para>
                    /// </summary>
                    [NameInMap("TextInImage")]
                    [Validation(Required=false)]
                    public ImageBatchModerationResponseBodyDataResultsExtTextInImage TextInImage { get; set; }
                    public class ImageBatchModerationResponseBodyDataResultsExtTextInImage : TeaModel {
                        /// <summary>
                        /// <para>If a custom text library is hit, the ID and name of the library, and the hit keywords are returned.</para>
                        /// </summary>
                        [NameInMap("CustomText")]
                        [Validation(Required=false)]
                        public List<ImageBatchModerationResponseBodyDataResultsExtTextInImageCustomText> CustomText { get; set; }
                        public class ImageBatchModerationResponseBodyDataResultsExtTextInImageCustomText : TeaModel {
                            /// <summary>
                            /// <para>The custom keywords. Separate multiple keywords with a comma.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>自定义词1,自定义词2</para>
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
                            /// <para>自定义库1</para>
                            /// </summary>
                            [NameInMap("LibName")]
                            [Validation(Required=false)]
                            public string LibName { get; set; }

                        }

                        /// <summary>
                        /// <para>The information for each line of text recognized in the image.</para>
                        /// </summary>
                        [NameInMap("OcrResult")]
                        [Validation(Required=false)]
                        public List<ImageBatchModerationResponseBodyDataResultsExtTextInImageOcrResult> OcrResult { get; set; }
                        public class ImageBatchModerationResponseBodyDataResultsExtTextInImageOcrResult : TeaModel {
                            /// <summary>
                            /// <para>The coordinates of the text line.</para>
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
                                /// <para>The x-coordinate of the upper-left corner of the text area, in pixels. The origin (0,0) is the upper-left corner of the image.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>11</para>
                                /// </summary>
                                [NameInMap("X")]
                                [Validation(Required=false)]
                                public int? X { get; set; }

                                /// <summary>
                                /// <para>The y-coordinate of the upper-left corner of the text area, in pixels. The origin (0,0) is the upper-left corner of the image.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>22</para>
                                /// </summary>
                                [NameInMap("Y")]
                                [Validation(Required=false)]
                                public int? Y { get; set; }

                            }

                            /// <summary>
                            /// <para>The text.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>abcd</para>
                            /// </summary>
                            [NameInMap("Text")]
                            [Validation(Required=false)]
                            public string Text { get; set; }

                        }

                        /// <summary>
                        /// <para>The detected risk keywords.</para>
                        /// </summary>
                        [NameInMap("RiskWord")]
                        [Validation(Required=false)]
                        public List<string> RiskWord { get; set; }

                    }

                }

                /// <summary>
                /// <para>The results of the image detection, including threat labels and confidence scores. This is an array.</para>
                /// </summary>
                [NameInMap("Result")]
                [Validation(Required=false)]
                public List<ImageBatchModerationResponseBodyDataResultsResult> Result { get; set; }
                public class ImageBatchModerationResponseBodyDataResultsResult : TeaModel {
                    /// <summary>
                    /// <para>The confidence score. The value ranges from 0 to 100, with two decimal places. Some labels do not have a confidence score.</para>
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
                    /// <para>未检测出风险</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The label returned after the image content moderation. An image may have multiple labels and scores.</para>
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
                /// <para>The detection service supported by Image Moderation Pro.</para>
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
        /// <para>The unique ID of the request. Alibaba Cloud generates this ID for each request. Use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6CF2815C-C8C7-4A01-B52E-FF6E24F53492</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
