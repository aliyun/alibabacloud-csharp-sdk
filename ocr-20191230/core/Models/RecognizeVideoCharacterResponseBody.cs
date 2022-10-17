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
                        [NameInMap("Angle")]
                        [Validation(Required=false)]
                        public long? Angle { get; set; }

                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public long? Height { get; set; }

                        [NameInMap("Left")]
                        [Validation(Required=false)]
                        public long? Left { get; set; }

                        [NameInMap("Top")]
                        [Validation(Required=false)]
                        public long? Top { get; set; }

                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public long? Width { get; set; }

                    }

                }

                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

            }

            [NameInMap("Height")]
            [Validation(Required=false)]
            public long? Height { get; set; }

            [NameInMap("InputFile")]
            [Validation(Required=false)]
            public string InputFile { get; set; }

            [NameInMap("Width")]
            [Validation(Required=false)]
            public long? Width { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
