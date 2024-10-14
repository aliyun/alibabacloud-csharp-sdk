// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class DescribeImageResultExtResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeImageResultExtResponseBodyData Data { get; set; }
        public class DescribeImageResultExtResponseBodyData : TeaModel {
            /// <summary>
            /// <para>If a custom image library is hit, information about the hit custom image library is returned.</para>
            /// </summary>
            [NameInMap("CustomImage")]
            [Validation(Required=false)]
            public List<DescribeImageResultExtResponseBodyDataCustomImage> CustomImage { get; set; }
            public class DescribeImageResultExtResponseBodyDataCustomImage : TeaModel {
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
                /// <para>123456</para>
                /// </summary>
                [NameInMap("LibId")]
                [Validation(Required=false)]
                public string LibId { get; set; }

                /// <summary>
                /// <para>The image library name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>图库123</para>
                /// </summary>
                [NameInMap("LibName")]
                [Validation(Required=false)]
                public string LibName { get; set; }

            }

            /// <summary>
            /// <para>Person information list.</para>
            /// </summary>
            [NameInMap("PublicFigure")]
            [Validation(Required=false)]
            public List<DescribeImageResultExtResponseBodyDataPublicFigure> PublicFigure { get; set; }
            public class DescribeImageResultExtResponseBodyDataPublicFigure : TeaModel {
                /// <summary>
                /// <para>Identified person coding information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yzazhzou</para>
                /// </summary>
                [NameInMap("FigureId")]
                [Validation(Required=false)]
                public string FigureId { get; set; }

            }

            /// <summary>
            /// <para>Returns the text information in the hit image.</para>
            /// </summary>
            [NameInMap("TextInImage")]
            [Validation(Required=false)]
            public DescribeImageResultExtResponseBodyDataTextInImage TextInImage { get; set; }
            public class DescribeImageResultExtResponseBodyDataTextInImage : TeaModel {
                /// <summary>
                /// <para>When a custom text library is hit, the custom library ID, custom library name, and custom word are returned.</para>
                /// </summary>
                [NameInMap("CustomTexts")]
                [Validation(Required=false)]
                public List<DescribeImageResultExtResponseBodyDataTextInImageCustomTexts> CustomTexts { get; set; }
                public class DescribeImageResultExtResponseBodyDataTextInImageCustomTexts : TeaModel {
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
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("LibName")]
                    [Validation(Required=false)]
                    public string LibName { get; set; }

                }

                /// <summary>
                /// <para>Returns the text information in the recognized image.</para>
                /// </summary>
                [NameInMap("OcrDatas")]
                [Validation(Required=false)]
                public List<string> OcrDatas { get; set; }

                /// <summary>
                /// <para>The risk words that are hit. Multiple words are separated by commas (,).</para>
                /// </summary>
                [NameInMap("RiskWords")]
                [Validation(Required=false)]
                public List<string> RiskWords { get; set; }

            }

        }

        /// <summary>
        /// <para>The message that is returned in response to the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6CF2815C-C8C7-4A01-B52E-FF6E24F53492</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
