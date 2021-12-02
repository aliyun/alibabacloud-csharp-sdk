// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class RecognizeActionResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeActionResponseBodyData Data { get; set; }
        public class RecognizeActionResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<RecognizeActionResponseBodyDataElements> Elements { get; set; }
            public class RecognizeActionResponseBodyDataElements : TeaModel {
                public List<RecognizeActionResponseBodyDataElementsBoxes> Boxes { get; set; }
                public class RecognizeActionResponseBodyDataElementsBoxes : TeaModel {
                    public List<string> Box { get; set; }
                }
                public List<string> Labels { get; set; }
                public List<string> Scores { get; set; }
                public int? Timestamp { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
