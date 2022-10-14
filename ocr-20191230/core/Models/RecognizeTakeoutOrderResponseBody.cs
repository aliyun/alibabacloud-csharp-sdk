// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizeTakeoutOrderResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeTakeoutOrderResponseBodyData Data { get; set; }
        public class RecognizeTakeoutOrderResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<RecognizeTakeoutOrderResponseBodyDataElements> Elements { get; set; }
            public class RecognizeTakeoutOrderResponseBodyDataElements : TeaModel {
                [NameInMap("Boxes")]
                [Validation(Required=false)]
                public List<int?> Boxes { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
