// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imagerecog20190930.Models
{
    public class RecognizeFoodResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeFoodResponseBodyData Data { get; set; }
        public class RecognizeFoodResponseBodyData : TeaModel {
            [NameInMap("TopFives")]
            [Validation(Required=false)]
            public List<RecognizeFoodResponseBodyDataTopFives> TopFives { get; set; }
            public class RecognizeFoodResponseBodyDataTopFives : TeaModel {
                [NameInMap("Calorie")]
                [Validation(Required=false)]
                public string Calorie { get; set; }

                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
