// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imagerecog20190930.Models
{
    public class ClassifyingRubbishResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ClassifyingRubbishResponseBodyData Data { get; set; }
        public class ClassifyingRubbishResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<ClassifyingRubbishResponseBodyDataElements> Elements { get; set; }
            public class ClassifyingRubbishResponseBodyDataElements : TeaModel {
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("CategoryScore")]
                [Validation(Required=false)]
                public float? CategoryScore { get; set; }

                [NameInMap("Rubbish")]
                [Validation(Required=false)]
                public string Rubbish { get; set; }

                [NameInMap("RubbishScore")]
                [Validation(Required=false)]
                public float? RubbishScore { get; set; }

            }

            [NameInMap("Sensitive")]
            [Validation(Required=false)]
            public bool? Sensitive { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
