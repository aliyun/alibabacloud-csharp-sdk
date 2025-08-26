// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizeVideoCharacterResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeVideoCharacterResponseBodyData Data { get; set; }
        public class RecognizeVideoCharacterResponseBodyData : TeaModel {
            [NameInMap("Frames")]
            [Validation(Required=false)]
            public List<RecognizeVideoCharacterResponseBodyDataFrames> Frames { get; set; }
            public class RecognizeVideoCharacterResponseBodyDataFrames : TeaModel {
                [NameInMap("Elements")]
                [Validation(Required=false)]
                public List<RecognizeVideoCharacterResponseBodyDataFramesElements> Elements { get; set; }
                public class RecognizeVideoCharacterResponseBodyDataFramesElements : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.99</para>
                    /// </summary>
                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    [NameInMap("TextRectangles")]
                    [Validation(Required=false)]
                    public List<RecognizeVideoCharacterResponseBodyDataFramesElementsTextRectangles> TextRectangles { get; set; }
                    public class RecognizeVideoCharacterResponseBodyDataFramesElementsTextRectangles : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>-90</para>
                        /// </summary>
                        [NameInMap("Angle")]
                        [Validation(Required=false)]
                        public long? Angle { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>213</para>
                        /// </summary>
                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public long? Height { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>213</para>
                        /// </summary>
                        [NameInMap("Left")]
                        [Validation(Required=false)]
                        public long? Left { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>98</para>
                        /// </summary>
                        [NameInMap("Top")]
                        [Validation(Required=false)]
                        public long? Top { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>46</para>
                        /// </summary>
                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public long? Width { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>6124533574</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1080</para>
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public long? Height { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>oss://my-bucket/a/b/c.mp4</para>
            /// </summary>
            [NameInMap("InputFile")]
            [Validation(Required=false)]
            public string InputFile { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1920</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public long? Width { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D3F5BA69-79C4-46A4-B02B-58C4EEBC4C33</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
