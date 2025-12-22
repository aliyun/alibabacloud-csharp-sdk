// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizeCharacterResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeCharacterResponseBodyData Data { get; set; }
        public class RecognizeCharacterResponseBodyData : TeaModel {
            [NameInMap("Results")]
            [Validation(Required=false)]
            public List<RecognizeCharacterResponseBodyDataResults> Results { get; set; }
            public class RecognizeCharacterResponseBodyDataResults : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0.99</para>
                /// </summary>
                [NameInMap("Probability")]
                [Validation(Required=false)]
                public float? Probability { get; set; }

                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                [NameInMap("TextRectangles")]
                [Validation(Required=false)]
                public RecognizeCharacterResponseBodyDataResultsTextRectangles TextRectangles { get; set; }
                public class RecognizeCharacterResponseBodyDataResultsTextRectangles : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>-65</para>
                    /// </summary>
                    [NameInMap("Angle")]
                    [Validation(Required=false)]
                    public int? Angle { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>409</para>
                    /// </summary>
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public int? Height { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>511</para>
                    /// </summary>
                    [NameInMap("Left")]
                    [Validation(Required=false)]
                    public int? Left { get; set; }

                    [NameInMap("Pos")]
                    [Validation(Required=false)]
                    public List<RecognizeCharacterResponseBodyDataResultsTextRectanglesPos> Pos { get; set; }
                    public class RecognizeCharacterResponseBodyDataResultsTextRectanglesPos : TeaModel {
                        [NameInMap("x")]
                        [Validation(Required=false)]
                        public int? X { get; set; }

                        [NameInMap("y")]
                        [Validation(Required=false)]
                        public int? Y { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>150</para>
                    /// </summary>
                    [NameInMap("Top")]
                    [Validation(Required=false)]
                    public int? Top { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>77</para>
                    /// </summary>
                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public int? Width { get; set; }

                }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7A9BC7FE-2D42-57AF-93BC-09A229DD2F1D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
