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
                public List<RecognizeVideoCharacterResponseBodyDataFramesElements> Elements { get; set; }
                public class RecognizeVideoCharacterResponseBodyDataFramesElements : TeaModel {
                    public float? Score { get; set; }
                    public string Text { get; set; }
                    public List<RecognizeVideoCharacterResponseBodyDataFramesElementsTextRectangles> TextRectangles { get; set; }
                    public class RecognizeVideoCharacterResponseBodyDataFramesElementsTextRectangles : TeaModel {
                        public long? Angle { get; set; }
                        public long? Height { get; set; }
                        public long? Left { get; set; }
                        public long? Top { get; set; }
                        public long? Width { get; set; }
                    }
                }
                public long? Timestamp { get; set; }
            }
            [NameInMap("Height")]
            [Validation(Required=false)]
            public long? Height { get; set; }
            [NameInMap("Width")]
            [Validation(Required=false)]
            public long? Width { get; set; }
        };

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
