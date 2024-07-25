// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class DescribeImageResultExtResponseBody : TeaModel {
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
        public DescribeImageResultExtResponseBodyData Data { get; set; }
        public class DescribeImageResultExtResponseBodyData : TeaModel {
            /// <summary>
            /// If a custom image library is hit, information about the hit custom image library is returned.
            /// </summary>
            [NameInMap("CustomImage")]
            [Validation(Required=false)]
            public List<DescribeImageResultExtResponseBodyDataCustomImage> CustomImage { get; set; }
            public class DescribeImageResultExtResponseBodyDataCustomImage : TeaModel {
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
            /// Person information list.
            /// </summary>
            [NameInMap("PublicFigure")]
            [Validation(Required=false)]
            public List<DescribeImageResultExtResponseBodyDataPublicFigure> PublicFigure { get; set; }
            public class DescribeImageResultExtResponseBodyDataPublicFigure : TeaModel {
                /// <summary>
                /// Identified person coding information.
                /// </summary>
                [NameInMap("FigureId")]
                [Validation(Required=false)]
                public string FigureId { get; set; }

            }

            /// <summary>
            /// Returns the text information in the hit image.
            /// </summary>
            [NameInMap("TextInImage")]
            [Validation(Required=false)]
            public DescribeImageResultExtResponseBodyDataTextInImage TextInImage { get; set; }
            public class DescribeImageResultExtResponseBodyDataTextInImage : TeaModel {
                /// <summary>
                /// When a custom text library is hit, the custom library ID, custom library name, and custom word are returned.
                /// </summary>
                [NameInMap("CustomTexts")]
                [Validation(Required=false)]
                public List<DescribeImageResultExtResponseBodyDataTextInImageCustomTexts> CustomTexts { get; set; }
                public class DescribeImageResultExtResponseBodyDataTextInImageCustomTexts : TeaModel {
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
                [NameInMap("OcrDatas")]
                [Validation(Required=false)]
                public List<string> OcrDatas { get; set; }

                /// <summary>
                /// The risk words that are hit. Multiple words are separated by commas (,).
                /// </summary>
                [NameInMap("RiskWords")]
                [Validation(Required=false)]
                public List<string> RiskWords { get; set; }

            }

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
