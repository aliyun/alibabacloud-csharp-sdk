// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizePdfResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizePdfResponseBodyData Data { get; set; }
        public class RecognizePdfResponseBodyData : TeaModel {
            [NameInMap("Angle")]
            [Validation(Required=false)]
            public long? Angle { get; set; }
            [NameInMap("Height")]
            [Validation(Required=false)]
            public long? Height { get; set; }
            [NameInMap("OrgHeight")]
            [Validation(Required=false)]
            public long? OrgHeight { get; set; }
            [NameInMap("OrgWidth")]
            [Validation(Required=false)]
            public long? OrgWidth { get; set; }
            [NameInMap("PageIndex")]
            [Validation(Required=false)]
            public long? PageIndex { get; set; }
            [NameInMap("Width")]
            [Validation(Required=false)]
            public long? Width { get; set; }
            [NameInMap("WordsInfo")]
            [Validation(Required=false)]
            public List<RecognizePdfResponseBodyDataWordsInfo> WordsInfo { get; set; }
            public class RecognizePdfResponseBodyDataWordsInfo : TeaModel {
                public long? Angle { get; set; }
                public long? Height { get; set; }
                public List<RecognizePdfResponseBodyDataWordsInfoPositions> Positions { get; set; }
                public class RecognizePdfResponseBodyDataWordsInfoPositions : TeaModel {
                    public long? X { get; set; }
                    public long? Y { get; set; }
                }
                public long? Width { get; set; }
                public string Word { get; set; }
                public long? X { get; set; }
                public long? Y { get; set; }
            }
        };

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
