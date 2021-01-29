// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizeStampResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeStampResponseBodyData Data { get; set; }
        public class RecognizeStampResponseBodyData : TeaModel {
            [NameInMap("Results")]
            [Validation(Required=false)]
            public List<RecognizeStampResponseBodyDataResults> Results { get; set; }
            public class RecognizeStampResponseBodyDataResults : TeaModel {
                [NameInMap("Confidence")]
                [Validation(Required=false)]
                public float? Confidence { get; set; }

                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

            }
        };

    }

}
