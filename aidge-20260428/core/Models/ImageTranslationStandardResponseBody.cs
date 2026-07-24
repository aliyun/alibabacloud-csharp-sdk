// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class ImageTranslationStandardResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. A value of 200 indicates a successful call. For other response codes, refer to the error code information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The translation result data, including the translated image URL and usage information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ImageTranslationStandardResponseBodyData Data { get; set; }
        public class ImageTranslationStandardResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The edit information.</para>
            /// </summary>
            [NameInMap("EditInfo")]
            [Validation(Required=false)]
            public ImageTranslationStandardResponseBodyDataEditInfo EditInfo { get; set; }
            public class ImageTranslationStandardResponseBodyDataEditInfo : TeaModel {
                /// <summary>
                /// <para>The list of fonts used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;NotoSansSC-Bold&quot;]</para>
                /// </summary>
                [NameInMap("Font")]
                [Validation(Required=false)]
                public List<string> Font { get; set; }

                /// <summary>
                /// <para>The product area rectangles.</para>
                /// </summary>
                [NameInMap("GoodsRects")]
                [Validation(Required=false)]
                public ImageTranslationStandardResponseBodyDataEditInfoGoodsRects GoodsRects { get; set; }
                public class ImageTranslationStandardResponseBodyDataEditInfoGoodsRects : TeaModel {
                    /// <summary>
                    /// <para>The rotation angle.</para>
                    /// </summary>
                    [NameInMap("Degree")]
                    [Validation(Required=false)]
                    public int? Degree { get; set; }

                    /// <summary>
                    /// <para>The height.</para>
                    /// </summary>
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public int? Height { get; set; }

                    /// <summary>
                    /// <para>The left coordinate.</para>
                    /// </summary>
                    [NameInMap("Left")]
                    [Validation(Required=false)]
                    public int? Left { get; set; }

                    /// <summary>
                    /// <para>The top coordinate.</para>
                    /// </summary>
                    [NameInMap("Top")]
                    [Validation(Required=false)]
                    public int? Top { get; set; }

                    /// <summary>
                    /// <para>The width.</para>
                    /// </summary>
                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public int? Width { get; set; }

                }

                /// <summary>
                /// <para>The product image URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://xiuxiu-pro.meitudata.com/posters/34d78f9157e5560a4d612949ca6f6485.jpg">https://xiuxiu-pro.meitudata.com/posters/34d78f9157e5560a4d612949ca6f6485.jpg</a></para>
                /// </summary>
                [NameInMap("GoodsUrl")]
                [Validation(Required=false)]
                public string GoodsUrl { get; set; }

                /// <summary>
                /// <para>The list of target languages.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;zh&quot;]</para>
                /// </summary>
                [NameInMap("Languages")]
                [Validation(Required=false)]
                public List<string> Languages { get; set; }

                /// <summary>
                /// <para>The original image URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://xiuxiu-pro.meitudata.com/posters/34d78f9157e5560a4d612949ca6f6485.jpg">https://xiuxiu-pro.meitudata.com/posters/34d78f9157e5560a4d612949ca6f6485.jpg</a></para>
                /// </summary>
                [NameInMap("PictUrl")]
                [Validation(Required=false)]
                public string PictUrl { get; set; }

                /// <summary>
                /// <para>The repaired image URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://dashscope-a717.oss-cn-beijing.aliyuncs.com/xxx.png">http://dashscope-a717.oss-cn-beijing.aliyuncs.com/xxx.png</a></para>
                /// </summary>
                [NameInMap("RepairedUrl")]
                [Validation(Required=false)]
                public string RepairedUrl { get; set; }

                /// <summary>
                /// <para>The list of repaired image URLs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;<a href="http://dashscope-a717.oss-cn-beijing.aliyuncs.com/xxx.png%22%5D">http://dashscope-a717.oss-cn-beijing.aliyuncs.com/xxx.png&quot;]</a></para>
                /// </summary>
                [NameInMap("RepairedUrls")]
                [Validation(Required=false)]
                public List<string> RepairedUrls { get; set; }

                /// <summary>
                /// <para>The list of result image IDs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;c18ab570-81aa-11f1-a14a-5ee00dcfdc3c&quot;]</para>
                /// </summary>
                [NameInMap("ResultImageIds")]
                [Validation(Required=false)]
                public List<string> ResultImageIds { get; set; }

                /// <summary>
                /// <para>The list of result image URLs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;<a href="http://dashscope-a717.oss-cn-beijing.aliyuncs.com/xxx.jpg%22%5D">http://dashscope-a717.oss-cn-beijing.aliyuncs.com/xxx.jpg&quot;]</a></para>
                /// </summary>
                [NameInMap("ResultUrls")]
                [Validation(Required=false)]
                public List<string> ResultUrls { get; set; }

                /// <summary>
                /// <para>The list of text areas.</para>
                /// </summary>
                [NameInMap("TextAreas")]
                [Validation(Required=false)]
                public List<ImageTranslationStandardResponseBodyDataEditInfoTextAreas> TextAreas { get; set; }
                public class ImageTranslationStandardResponseBodyDataEditInfoTextAreas : TeaModel {
                    /// <summary>
                    /// <para>The color.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>#000000</para>
                    /// </summary>
                    [NameInMap("Color")]
                    [Validation(Required=false)]
                    public string Color { get; set; }

                    /// <summary>
                    /// <para>The content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SOLIDWOOD WARDROBE</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>The font size.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>36</para>
                    /// </summary>
                    [NameInMap("Fontsize")]
                    [Validation(Required=false)]
                    public int? Fontsize { get; set; }

                    /// <summary>
                    /// <para>The horizontal layout.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>left</para>
                    /// </summary>
                    [NameInMap("HorizontalLayout")]
                    [Validation(Required=false)]
                    public string HorizontalLayout { get; set; }

                    /// <summary>
                    /// <para>The line count.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("LineCount")]
                    [Validation(Required=false)]
                    public int? LineCount { get; set; }

                    /// <summary>
                    /// <para>The list of texts.</para>
                    /// </summary>
                    [NameInMap("Texts")]
                    [Validation(Required=false)]
                    public List<ImageTranslationStandardResponseBodyDataEditInfoTextAreasTexts> Texts { get; set; }
                    public class ImageTranslationStandardResponseBodyDataEditInfoTextAreasTexts : TeaModel {
                        /// <summary>
                        /// <para>The color.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>#9d7746</para>
                        /// </summary>
                        [NameInMap("Color")]
                        [Validation(Required=false)]
                        public string Color { get; set; }

                        /// <summary>
                        /// <para>The font size.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>42</para>
                        /// </summary>
                        [NameInMap("Fontsize")]
                        [Validation(Required=false)]
                        public int? Fontsize { get; set; }

                        /// <summary>
                        /// <para>The horizontal layout.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>left</para>
                        /// </summary>
                        [NameInMap("HorizontalLayout")]
                        [Validation(Required=false)]
                        public string HorizontalLayout { get; set; }

                        /// <summary>
                        /// <para>The image area.</para>
                        /// </summary>
                        [NameInMap("ImageRect")]
                        [Validation(Required=false)]
                        public ImageTranslationStandardResponseBodyDataEditInfoTextAreasTextsImageRect ImageRect { get; set; }
                        public class ImageTranslationStandardResponseBodyDataEditInfoTextAreasTextsImageRect : TeaModel {
                            /// <summary>
                            /// <para>The rotation angle.</para>
                            /// </summary>
                            [NameInMap("Degree")]
                            [Validation(Required=false)]
                            public int? Degree { get; set; }

                            /// <summary>
                            /// <para>The height.</para>
                            /// </summary>
                            [NameInMap("Height")]
                            [Validation(Required=false)]
                            public int? Height { get; set; }

                            /// <summary>
                            /// <para>The left coordinate.</para>
                            /// </summary>
                            [NameInMap("Left")]
                            [Validation(Required=false)]
                            public int? Left { get; set; }

                            /// <summary>
                            /// <para>The top coordinate.</para>
                            /// </summary>
                            [NameInMap("Top")]
                            [Validation(Required=false)]
                            public int? Top { get; set; }

                            /// <summary>
                            /// <para>The width.</para>
                            /// </summary>
                            [NameInMap("Width")]
                            [Validation(Required=false)]
                            public int? Width { get; set; }

                        }

                        /// <summary>
                        /// <para>The language.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>zh</para>
                        /// </summary>
                        [NameInMap("Language")]
                        [Validation(Required=false)]
                        public string Language { get; set; }

                        /// <summary>
                        /// <para>The line count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("LineCount")]
                        [Validation(Required=false)]
                        public int? LineCount { get; set; }

                        /// <summary>
                        /// <para>The text area.</para>
                        /// </summary>
                        [NameInMap("TextRect")]
                        [Validation(Required=false)]
                        public ImageTranslationStandardResponseBodyDataEditInfoTextAreasTextsTextRect TextRect { get; set; }
                        public class ImageTranslationStandardResponseBodyDataEditInfoTextAreasTextsTextRect : TeaModel {
                            /// <summary>
                            /// <para>The rotation angle.</para>
                            /// </summary>
                            [NameInMap("Degree")]
                            [Validation(Required=false)]
                            public int? Degree { get; set; }

                            /// <summary>
                            /// <para>The height.</para>
                            /// </summary>
                            [NameInMap("Height")]
                            [Validation(Required=false)]
                            public int? Height { get; set; }

                            /// <summary>
                            /// <para>The left coordinate.</para>
                            /// </summary>
                            [NameInMap("Left")]
                            [Validation(Required=false)]
                            public int? Left { get; set; }

                            /// <summary>
                            /// <para>The top coordinate.</para>
                            /// </summary>
                            [NameInMap("Top")]
                            [Validation(Required=false)]
                            public int? Top { get; set; }

                            /// <summary>
                            /// <para>The width.</para>
                            /// </summary>
                            [NameInMap("Width")]
                            [Validation(Required=false)]
                            public int? Width { get; set; }

                        }

                        /// <summary>
                        /// <para>Indicates whether the text is valid.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("Valid")]
                        [Validation(Required=false)]
                        public bool? Valid { get; set; }

                        /// <summary>
                        /// <para>The text value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Solid Wood Wardrobe.</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                        /// <summary>
                        /// <para>The vertical layout.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>center</para>
                        /// </summary>
                        [NameInMap("VerticalLayout")]
                        [Validation(Required=false)]
                        public string VerticalLayout { get; set; }

                    }

                    /// <summary>
                    /// <para>The vertical layout.</para>
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
            /// <para>The URL of the image generated after image translation.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://dashscope-a717.oss-cn-beijing.aliyuncs.com/xxx.jpg">http://dashscope-a717.oss-cn-beijing.aliyuncs.com/xxx.jpg</a></para>
            /// </summary>
            [NameInMap("ImageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }

            /// <summary>
            /// <para>The usage information, including the number of images processed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;ProcessedImageCount&quot;:1}</para>
            /// </summary>
            [NameInMap("UsageMap")]
            [Validation(Required=false)]
            public Dictionary<string, long?> UsageMap { get; set; }

        }

        /// <summary>
        /// <para>The error message. Returns &quot;Success&quot; for successful calls, and returns specific error information for failed calls.</para>
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
        /// <para>1CEC4D94-905A-1ED1-A7B4-1BFEFFB3D850</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. A value of true indicates success, and a value of false indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
