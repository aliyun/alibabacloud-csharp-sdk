// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20181012.Models
{
    public class DescribeDiversifyResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeDiversifyResponseBodyResult Result { get; set; }
        public class DescribeDiversifyResponseBodyResult : TeaModel {
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }
            [NameInMap("Parameter")]
            [Validation(Required=false)]
            public DescribeDiversifyResponseBodyResultParameter Parameter { get; set; }
            public class DescribeDiversifyResponseBodyResultParameter : TeaModel {
                [NameInMap("Window")]
                [Validation(Required=false)]
                public int? Window { get; set; }

                [NameInMap("CategoryIndex")]
                [Validation(Required=false)]
                public int? CategoryIndex { get; set; }

            }
        };

    }

}
