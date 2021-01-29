// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizeTakeoutOrderResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeTakeoutOrderResponseBodyData Data { get; set; }
        public class RecognizeTakeoutOrderResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<RecognizeTakeoutOrderResponseBodyDataElements> Elements { get; set; }
            public class RecognizeTakeoutOrderResponseBodyDataElements : TeaModel {
                public string Value { get; set; }
                public List<string> Boxes { get; set; }
                public float? Score { get; set; }
                public string Name { get; set; }
            }
        };

    }

}
