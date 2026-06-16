// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class ImageTranslationProResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. A value of 200 indicates success. For other response codes, see the error codes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The translation result data. ResultList contains the URL of the translation result. GenFiles contains EditInfo with the recognized text information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ImageTranslationProResponseBodyData Data { get; set; }
        public class ImageTranslationProResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The editor protocol, which contains the translation result files and editing information.</para>
            /// </summary>
            [NameInMap("GenFiles")]
            [Validation(Required=false)]
            public List<ImageTranslationProResponseBodyDataGenFiles> GenFiles { get; set; }
            public class ImageTranslationProResponseBodyDataGenFiles : TeaModel {
                /// <summary>
                /// <para>The editor information, which contains recognized information such as text areas, product areas, and fonts.</para>
                /// </summary>
                [NameInMap("EditInfo")]
                [Validation(Required=false)]
                public ImageTranslationProResponseBodyDataGenFilesEditInfo EditInfo { get; set; }
                public class ImageTranslationProResponseBodyDataGenFilesEditInfo : TeaModel {
                    /// <summary>
                    /// <para>The list of font types.</para>
                    /// </summary>
                    [NameInMap("Font")]
                    [Validation(Required=false)]
                    public List<string> Font { get; set; }

                    /// <summary>
                    /// <para>The coordinate information of the product bounding box area.</para>
                    /// </summary>
                    [NameInMap("GoodsRects")]
                    [Validation(Required=false)]
                    public ImageTranslationProResponseBodyDataGenFilesEditInfoGoodsRects GoodsRects { get; set; }
                    public class ImageTranslationProResponseBodyDataGenFilesEditInfoGoodsRects : TeaModel {
                        /// <summary>
                        /// <para>The rotation angle of the text box in degrees. A value less than 1 indicates a horizontal text box.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Degree")]
                        [Validation(Required=false)]
                        public int? Degree { get; set; }

                        /// <summary>
                        /// <para>The height.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public int? Height { get; set; }

                        /// <summary>
                        /// <para>The left coordinate.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Left")]
                        [Validation(Required=false)]
                        public int? Left { get; set; }

                        /// <summary>
                        /// <para>The top coordinate.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Top")]
                        [Validation(Required=false)]
                        public int? Top { get; set; }

                        /// <summary>
                        /// <para>The width.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public int? Width { get; set; }

                    }

                    /// <summary>
                    /// <para>The list of target languages for translation.</para>
                    /// </summary>
                    [NameInMap("Languages")]
                    [Validation(Required=false)]
                    public List<string> Languages { get; set; }

                    /// <summary>
                    /// <para>The URL of the image with all text removed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://dashscope-a717.oss-cn-beijing.aliyuncs.com/repaired.png">http://dashscope-a717.oss-cn-beijing.aliyuncs.com/repaired.png</a></para>
                    /// </summary>
                    [NameInMap("RepairedUrl")]
                    [Validation(Required=false)]
                    public string RepairedUrl { get; set; }

                    /// <summary>
                    /// <para>The collection of global IDs of translated images.</para>
                    /// </summary>
                    [NameInMap("ResultImageIds")]
                    [Validation(Required=false)]
                    public List<string> ResultImageIds { get; set; }

                    /// <summary>
                    /// <para>The list of text boxes, which contains information about all recognized text areas.</para>
                    /// </summary>
                    [NameInMap("TextAreas")]
                    [Validation(Required=false)]
                    public List<ImageTranslationProResponseBodyDataGenFilesEditInfoTextAreas> TextAreas { get; set; }
                    public class ImageTranslationProResponseBodyDataGenFilesEditInfoTextAreas : TeaModel {
                        /// <summary>
                        /// <para>The text color, such as #ffffff.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>#515151</para>
                        /// </summary>
                        [NameInMap("Color")]
                        [Validation(Required=false)]
                        public string Color { get; set; }

                        /// <summary>
                        /// <para>The original text before translation.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>萌趣造型·清脆响铃</para>
                        /// </summary>
                        [NameInMap("Content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }

                        /// <summary>
                        /// <para>The font size.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>32</para>
                        /// </summary>
                        [NameInMap("Fontsize")]
                        [Validation(Required=false)]
                        public int? Fontsize { get; set; }

                        /// <summary>
                        /// <para>The horizontal layout. Valid values: center, left, right.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>left</para>
                        /// </summary>
                        [NameInMap("HorizontalLayout")]
                        [Validation(Required=false)]
                        public string HorizontalLayout { get; set; }

                        /// <summary>
                        /// <para>The number of lines in the text box.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("LineCount")]
                        [Validation(Required=false)]
                        public int? LineCount { get; set; }

                        /// <summary>
                        /// <para>The list of translated texts. Each element corresponds to the translation result for a target language.</para>
                        /// </summary>
                        [NameInMap("Texts")]
                        [Validation(Required=false)]
                        public List<ImageTranslationProResponseBodyDataGenFilesEditInfoTextAreasTexts> Texts { get; set; }
                        public class ImageTranslationProResponseBodyDataGenFilesEditInfoTextAreasTexts : TeaModel {
                            /// <summary>
                            /// <para>The color of the translated text.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>#515151</para>
                            /// </summary>
                            [NameInMap("Color")]
                            [Validation(Required=false)]
                            public string Color { get; set; }

                            /// <summary>
                            /// <para>The font size of the translated text.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>29</para>
                            /// </summary>
                            [NameInMap("Fontsize")]
                            [Validation(Required=false)]
                            public int? Fontsize { get; set; }

                            /// <summary>
                            /// <para>The horizontal layout. Valid values: center, left, right.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>center</para>
                            /// </summary>
                            [NameInMap("HorizontalLayout")]
                            [Validation(Required=false)]
                            public string HorizontalLayout { get; set; }

                            /// <summary>
                            /// <para>The coordinates of the image repair area.</para>
                            /// </summary>
                            [NameInMap("ImageRect")]
                            [Validation(Required=false)]
                            public ImageTranslationProResponseBodyDataGenFilesEditInfoTextAreasTextsImageRect ImageRect { get; set; }
                            public class ImageTranslationProResponseBodyDataGenFilesEditInfoTextAreasTextsImageRect : TeaModel {
                                /// <summary>
                                /// <para>The rotation angle of the text box in degrees. A value less than 1 indicates a horizontal text box.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>0</para>
                                /// </summary>
                                [NameInMap("Degree")]
                                [Validation(Required=false)]
                                public int? Degree { get; set; }

                                /// <summary>
                                /// <para>The height.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>54</para>
                                /// </summary>
                                [NameInMap("Height")]
                                [Validation(Required=false)]
                                public int? Height { get; set; }

                                /// <summary>
                                /// <para>The left coordinate.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>43</para>
                                /// </summary>
                                [NameInMap("Left")]
                                [Validation(Required=false)]
                                public int? Left { get; set; }

                                /// <summary>
                                /// <para>The top coordinate.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>83</para>
                                /// </summary>
                                [NameInMap("Top")]
                                [Validation(Required=false)]
                                public int? Top { get; set; }

                                /// <summary>
                                /// <para>The width.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>418</para>
                                /// </summary>
                                [NameInMap("Width")]
                                [Validation(Required=false)]
                                public int? Width { get; set; }

                            }

                            /// <summary>
                            /// <para>The target language code for translation.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>en</para>
                            /// </summary>
                            [NameInMap("Language")]
                            [Validation(Required=false)]
                            public string Language { get; set; }

                            /// <summary>
                            /// <para>The number of lines in the text box.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("LineCount")]
                            [Validation(Required=false)]
                            public int? LineCount { get; set; }

                            /// <summary>
                            /// <para>The Ovis model error message and execution time.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>| ovis time: 0.748</para>
                            /// </summary>
                            [NameInMap("OvisErrMsg")]
                            [Validation(Required=false)]
                            public string OvisErrMsg { get; set; }

                            /// <summary>
                            /// <para>The coordinates of the text box area.</para>
                            /// </summary>
                            [NameInMap("TextRect")]
                            [Validation(Required=false)]
                            public ImageTranslationProResponseBodyDataGenFilesEditInfoTextAreasTextsTextRect TextRect { get; set; }
                            public class ImageTranslationProResponseBodyDataGenFilesEditInfoTextAreasTextsTextRect : TeaModel {
                                /// <summary>
                                /// <para>The rotation angle of the text box in degrees. A value less than 1 indicates a horizontal text box.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>0</para>
                                /// </summary>
                                [NameInMap("Degree")]
                                [Validation(Required=false)]
                                public int? Degree { get; set; }

                                /// <summary>
                                /// <para>The height.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>30</para>
                                /// </summary>
                                [NameInMap("Height")]
                                [Validation(Required=false)]
                                public int? Height { get; set; }

                                /// <summary>
                                /// <para>The left coordinate.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>8</para>
                                /// </summary>
                                [NameInMap("Left")]
                                [Validation(Required=false)]
                                public int? Left { get; set; }

                                /// <summary>
                                /// <para>The top coordinate.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>95</para>
                                /// </summary>
                                [NameInMap("Top")]
                                [Validation(Required=false)]
                                public int? Top { get; set; }

                                /// <summary>
                                /// <para>The width.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>488</para>
                                /// </summary>
                                [NameInMap("Width")]
                                [Validation(Required=false)]
                                public int? Width { get; set; }

                            }

                            /// <summary>
                            /// <para>Indicates whether the TextItem is valid. The item is invalid if this value does not exist or is false.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
                            [NameInMap("Valid")]
                            [Validation(Required=false)]
                            public bool? Valid { get; set; }

                            /// <summary>
                            /// <para>The translated text content.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Adorable Design · Crisp Bell Sound</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                            /// <summary>
                            /// <para>The vertical layout. Valid values: center, top, down.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>center</para>
                            /// </summary>
                            [NameInMap("VerticalLayout")]
                            [Validation(Required=false)]
                            public string VerticalLayout { get; set; }

                        }

                        /// <summary>
                        /// <para>The vertical layout. Valid values: center, top, down.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>center</para>
                        /// </summary>
                        [NameInMap("VerticalLayout")]
                        [Validation(Required=false)]
                        public string VerticalLayout { get; set; }

                    }

                }

                /// <summary>
                /// <para>The collection of translation results.</para>
                /// </summary>
                [NameInMap("ResultList")]
                [Validation(Required=false)]
                public List<ImageTranslationProResponseBodyDataGenFilesResultList> ResultList { get; set; }
                public class ImageTranslationProResponseBodyDataGenFilesResultList : TeaModel {
                    /// <summary>
                    /// <para>The URL of the translated image file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://dashscope-a717.oss-cn-beijing.aliyuncs.com/xxx.jpg">http://dashscope-a717.oss-cn-beijing.aliyuncs.com/xxx.jpg</a></para>
                    /// </summary>
                    [NameInMap("FileUrl")]
                    [Validation(Required=false)]
                    public string FileUrl { get; set; }

                    /// <summary>
                    /// <para>The target language for translation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>en</para>
                    /// </summary>
                    [NameInMap("Language")]
                    [Validation(Required=false)]
                    public string Language { get; set; }

                }

                /// <summary>
                /// <para>The URL of the original image.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://img.alicdn.com/imgextra/i3/O1CN01HTDhDi28Fd85ZYs7H_!!6000000007903-0-tps-800-800.jpg">https://img.alicdn.com/imgextra/i3/O1CN01HTDhDi28Fd85ZYs7H_!!6000000007903-0-tps-800-800.jpg</a></para>
                /// </summary>
                [NameInMap("SrcImage")]
                [Validation(Required=false)]
                public string SrcImage { get; set; }

            }

            /// <summary>
            /// <para>The list of image translation results.</para>
            /// </summary>
            [NameInMap("ResultList")]
            [Validation(Required=false)]
            public List<ImageTranslationProResponseBodyDataResultList> ResultList { get; set; }
            public class ImageTranslationProResponseBodyDataResultList : TeaModel {
                /// <summary>
                /// <para>The URL of the image translation result image.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://dashscope-a717.oss-cn-beijing.aliyuncs.com/xxx.jpg">http://dashscope-a717.oss-cn-beijing.aliyuncs.com/xxx.jpg</a></para>
                /// </summary>
                [NameInMap("FileUrl")]
                [Validation(Required=false)]
                public string FileUrl { get; set; }

                /// <summary>
                /// <para>The target language for image translation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>en</para>
                /// </summary>
                [NameInMap("Language")]
                [Validation(Required=false)]
                public string Language { get; set; }

            }

            /// <summary>
            /// <para>The asynchronous task ID. This is not returned for synchronous calls.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc123-task-id</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The usage information, including the number of processed images.</para>
            /// </summary>
            [NameInMap("UsageMap")]
            [Validation(Required=false)]
            public Dictionary<string, long?> UsageMap { get; set; }

        }

        /// <summary>
        /// <para>The error message. &quot;Success&quot; is returned for successful calls. A specific error message is returned for failed calls, such as &quot;The content contains sensitive data. Try other input.&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID, which uniquely identifies the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>61785C32-80C2-19A3-9E55-2C3702C84B40</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. A value of true indicates success. A value of false indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
