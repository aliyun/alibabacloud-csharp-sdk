// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class ImageTranslationProResponseBody : TeaModel {
        /// <summary>
        /// <para>Response code. 200 indicates a successful call. For other response codes, refer to the error code documentation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Translation result data. ResultList contains the URL of the translation result, and GenFiles contains EditInfo with recognized text information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ImageTranslationProResponseBodyData Data { get; set; }
        public class ImageTranslationProResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Editor protocol, containing translation result files and editing information</para>
            /// </summary>
            [NameInMap("GenFiles")]
            [Validation(Required=false)]
            public List<ImageTranslationProResponseBodyDataGenFiles> GenFiles { get; set; }
            public class ImageTranslationProResponseBodyDataGenFiles : TeaModel {
                /// <summary>
                /// <para>Editor information, containing recognized information such as text areas, product areas, and fonts</para>
                /// </summary>
                [NameInMap("EditInfo")]
                [Validation(Required=false)]
                public ImageTranslationProResponseBodyDataGenFilesEditInfo EditInfo { get; set; }
                public class ImageTranslationProResponseBodyDataGenFilesEditInfo : TeaModel {
                    /// <summary>
                    /// <para>Font type list</para>
                    /// </summary>
                    [NameInMap("Font")]
                    [Validation(Required=false)]
                    public List<string> Font { get; set; }

                    /// <summary>
                    /// <para>Product bounding box area coordinate information</para>
                    /// </summary>
                    [NameInMap("GoodsRects")]
                    [Validation(Required=false)]
                    public ImageTranslationProResponseBodyDataGenFilesEditInfoGoodsRects GoodsRects { get; set; }
                    public class ImageTranslationProResponseBodyDataGenFilesEditInfoGoodsRects : TeaModel {
                        /// <summary>
                        /// <para>Text box rotation angle in degrees. Values less than 1 indicate a horizontal text box</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Degree")]
                        [Validation(Required=false)]
                        public int? Degree { get; set; }

                        /// <summary>
                        /// <para>Height</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public int? Height { get; set; }

                        /// <summary>
                        /// <para>Left coordinate</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Left")]
                        [Validation(Required=false)]
                        public int? Left { get; set; }

                        /// <summary>
                        /// <para>Top coordinate</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Top")]
                        [Validation(Required=false)]
                        public int? Top { get; set; }

                        /// <summary>
                        /// <para>Width</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public int? Width { get; set; }

                    }

                    /// <summary>
                    /// <para>Translation target language list</para>
                    /// </summary>
                    [NameInMap("Languages")]
                    [Validation(Required=false)]
                    public List<string> Languages { get; set; }

                    /// <summary>
                    /// <para>Image URL after all text has been inpainted</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://dashscope-a717.oss-cn-beijing.aliyuncs.com/repaired.png">http://dashscope-a717.oss-cn-beijing.aliyuncs.com/repaired.png</a></para>
                    /// </summary>
                    [NameInMap("RepairedUrl")]
                    [Validation(Required=false)]
                    public string RepairedUrl { get; set; }

                    /// <summary>
                    /// <para>Collection of translated image global IDs</para>
                    /// </summary>
                    [NameInMap("ResultImageIds")]
                    [Validation(Required=false)]
                    public List<string> ResultImageIds { get; set; }

                    /// <summary>
                    /// <para>Text box list, containing information about all recognized text areas</para>
                    /// </summary>
                    [NameInMap("TextAreas")]
                    [Validation(Required=false)]
                    public List<ImageTranslationProResponseBodyDataGenFilesEditInfoTextAreas> TextAreas { get; set; }
                    public class ImageTranslationProResponseBodyDataGenFilesEditInfoTextAreas : TeaModel {
                        /// <summary>
                        /// <para>Text color, e.g., #ffffff</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>#515151</para>
                        /// </summary>
                        [NameInMap("Color")]
                        [Validation(Required=false)]
                        public string Color { get; set; }

                        /// <summary>
                        /// <para>Original text before translation</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>萌趣造型·清脆响铃</para>
                        /// </summary>
                        [NameInMap("Content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }

                        /// <summary>
                        /// <para>Font size</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>32</para>
                        /// </summary>
                        [NameInMap("Fontsize")]
                        [Validation(Required=false)]
                        public int? Fontsize { get; set; }

                        /// <summary>
                        /// <para>Horizontal layout mode. Available values: center, left, right</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>left</para>
                        /// </summary>
                        [NameInMap("HorizontalLayout")]
                        [Validation(Required=false)]
                        public string HorizontalLayout { get; set; }

                        /// <summary>
                        /// <para>Number of lines in the text box</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("LineCount")]
                        [Validation(Required=false)]
                        public int? LineCount { get; set; }

                        /// <summary>
                        /// <para>Translated text list, where each element corresponds to the translation result for one target language</para>
                        /// </summary>
                        [NameInMap("Texts")]
                        [Validation(Required=false)]
                        public List<ImageTranslationProResponseBodyDataGenFilesEditInfoTextAreasTexts> Texts { get; set; }
                        public class ImageTranslationProResponseBodyDataGenFilesEditInfoTextAreasTexts : TeaModel {
                            /// <summary>
                            /// <para>Translated text color</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>#515151</para>
                            /// </summary>
                            [NameInMap("Color")]
                            [Validation(Required=false)]
                            public string Color { get; set; }

                            /// <summary>
                            /// <para>Font size of the translated text</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>29</para>
                            /// </summary>
                            [NameInMap("Fontsize")]
                            [Validation(Required=false)]
                            public int? Fontsize { get; set; }

                            /// <summary>
                            /// <para>Horizontal layout mode. Available values: center, left, right</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>center</para>
                            /// </summary>
                            [NameInMap("HorizontalLayout")]
                            [Validation(Required=false)]
                            public string HorizontalLayout { get; set; }

                            /// <summary>
                            /// <para>Image repair area coordinates</para>
                            /// </summary>
                            [NameInMap("ImageRect")]
                            [Validation(Required=false)]
                            public ImageTranslationProResponseBodyDataGenFilesEditInfoTextAreasTextsImageRect ImageRect { get; set; }
                            public class ImageTranslationProResponseBodyDataGenFilesEditInfoTextAreasTextsImageRect : TeaModel {
                                /// <summary>
                                /// <para>Text box rotation angle in degrees. Values less than 1 indicate a horizontal text box</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>0</para>
                                /// </summary>
                                [NameInMap("Degree")]
                                [Validation(Required=false)]
                                public int? Degree { get; set; }

                                /// <summary>
                                /// <para>Height</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>54</para>
                                /// </summary>
                                [NameInMap("Height")]
                                [Validation(Required=false)]
                                public int? Height { get; set; }

                                /// <summary>
                                /// <para>Left coordinate</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>43</para>
                                /// </summary>
                                [NameInMap("Left")]
                                [Validation(Required=false)]
                                public int? Left { get; set; }

                                /// <summary>
                                /// <para>Top coordinate</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>83</para>
                                /// </summary>
                                [NameInMap("Top")]
                                [Validation(Required=false)]
                                public int? Top { get; set; }

                                /// <summary>
                                /// <para>Width</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>418</para>
                                /// </summary>
                                [NameInMap("Width")]
                                [Validation(Required=false)]
                                public int? Width { get; set; }

                            }

                            /// <summary>
                            /// <para>Translation target language code</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>en</para>
                            /// </summary>
                            [NameInMap("Language")]
                            [Validation(Required=false)]
                            public string Language { get; set; }

                            /// <summary>
                            /// <para>Number of lines in the text box</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("LineCount")]
                            [Validation(Required=false)]
                            public int? LineCount { get; set; }

                            /// <summary>
                            /// <para>Ovis model error message and execution time</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>| ovis time: 0.748</para>
                            /// </summary>
                            [NameInMap("OvisErrMsg")]
                            [Validation(Required=false)]
                            public string OvisErrMsg { get; set; }

                            /// <summary>
                            /// <para>Text box area coordinates</para>
                            /// </summary>
                            [NameInMap("TextRect")]
                            [Validation(Required=false)]
                            public ImageTranslationProResponseBodyDataGenFilesEditInfoTextAreasTextsTextRect TextRect { get; set; }
                            public class ImageTranslationProResponseBodyDataGenFilesEditInfoTextAreasTextsTextRect : TeaModel {
                                /// <summary>
                                /// <para>Text box rotation angle in degrees. Values less than 1 indicate a horizontal text box</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>0</para>
                                /// </summary>
                                [NameInMap("Degree")]
                                [Validation(Required=false)]
                                public int? Degree { get; set; }

                                /// <summary>
                                /// <para>Height</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>30</para>
                                /// </summary>
                                [NameInMap("Height")]
                                [Validation(Required=false)]
                                public int? Height { get; set; }

                                /// <summary>
                                /// <para>Left coordinate</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>8</para>
                                /// </summary>
                                [NameInMap("Left")]
                                [Validation(Required=false)]
                                public int? Left { get; set; }

                                /// <summary>
                                /// <para>Top coordinate</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>95</para>
                                /// </summary>
                                [NameInMap("Top")]
                                [Validation(Required=false)]
                                public int? Top { get; set; }

                                /// <summary>
                                /// <para>Width</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>488</para>
                                /// </summary>
                                [NameInMap("Width")]
                                [Validation(Required=false)]
                                public int? Width { get; set; }

                            }

                            /// <summary>
                            /// <para>Whether the TextItem is valid. It is invalid when this value does not exist or is false.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
                            [NameInMap("Valid")]
                            [Validation(Required=false)]
                            public bool? Valid { get; set; }

                            /// <summary>
                            /// <para>Translated text content</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Adorable Design · Crisp Bell Sound</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                            /// <summary>
                            /// <para>Vertical layout mode. Available values: center, top, down</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>center</para>
                            /// </summary>
                            [NameInMap("VerticalLayout")]
                            [Validation(Required=false)]
                            public string VerticalLayout { get; set; }

                        }

                        /// <summary>
                        /// <para>Vertical layout mode. Available values: center, top, down</para>
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
                /// <para>Translation result collection</para>
                /// </summary>
                [NameInMap("ResultList")]
                [Validation(Required=false)]
                public List<ImageTranslationProResponseBodyDataGenFilesResultList> ResultList { get; set; }
                public class ImageTranslationProResponseBodyDataGenFilesResultList : TeaModel {
                    /// <summary>
                    /// <para>Translated image file URL</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://dashscope-a717.oss-cn-beijing.aliyuncs.com/xxx.jpg">http://dashscope-a717.oss-cn-beijing.aliyuncs.com/xxx.jpg</a></para>
                    /// </summary>
                    [NameInMap("FileUrl")]
                    [Validation(Required=false)]
                    public string FileUrl { get; set; }

                    /// <summary>
                    /// <para>Translation target language</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>en</para>
                    /// </summary>
                    [NameInMap("Language")]
                    [Validation(Required=false)]
                    public string Language { get; set; }

                }

                /// <summary>
                /// <para>Original image URL</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://img.alicdn.com/imgextra/i3/O1CN01HTDhDi28Fd85ZYs7H_!!6000000007903-0-tps-800-800.jpg">https://img.alicdn.com/imgextra/i3/O1CN01HTDhDi28Fd85ZYs7H_!!6000000007903-0-tps-800-800.jpg</a></para>
                /// </summary>
                [NameInMap("SrcImage")]
                [Validation(Required=false)]
                public string SrcImage { get; set; }

            }

            /// <summary>
            /// <para>Image translation result list</para>
            /// </summary>
            [NameInMap("ResultList")]
            [Validation(Required=false)]
            public List<ImageTranslationProResponseBodyDataResultList> ResultList { get; set; }
            public class ImageTranslationProResponseBodyDataResultList : TeaModel {
                /// <summary>
                /// <para>Image translation result image URL</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://dashscope-a717.oss-cn-beijing.aliyuncs.com/xxx.jpg">http://dashscope-a717.oss-cn-beijing.aliyuncs.com/xxx.jpg</a></para>
                /// </summary>
                [NameInMap("FileUrl")]
                [Validation(Required=false)]
                public string FileUrl { get; set; }

                /// <summary>
                /// <para>Image translation target language</para>
                /// 
                /// <b>Example:</b>
                /// <para>en</para>
                /// </summary>
                [NameInMap("Language")]
                [Validation(Required=false)]
                public string Language { get; set; }

            }

            /// <summary>
            /// <para>Asynchronous task ID, not returned during synchronous calls.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc123-task-id</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>Usage information, including the number of processed images, etc.</para>
            /// </summary>
            [NameInMap("UsageMap")]
            [Validation(Required=false)]
            public Dictionary<string, long?> UsageMap { get; set; }

        }

        /// <summary>
        /// <para>Error message. Returns &quot;Success&quot; during normal calls. Returns specific error information during exceptions, such as &quot;Content contains sensitive data, please try other input&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID, used to identify a unique request call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>61785C32-80C2-19A3-9E55-2C3702C84B40</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Whether the call was successful. true indicates success, false indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
