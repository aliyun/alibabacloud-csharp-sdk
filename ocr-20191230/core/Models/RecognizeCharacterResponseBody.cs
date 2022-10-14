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
                    [NameInMap("Angle")]
                    [Validation(Required=false)]
                    public int? Angle { get; set; }

                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public int? Height { get; set; }

                    [NameInMap("Left")]
                    [Validation(Required=false)]
                    public int? Left { get; set; }

                    [NameInMap("Top")]
                    [Validation(Required=false)]
                    public int? Top { get; set; }

                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public int? Width { get; set; }

                }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
