// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imagerecog20190930.Models
{
    public class ClassifyingRubbishResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ClassifyingRubbishResponseBodyData Data { get; set; }
        public class ClassifyingRubbishResponseBodyData : TeaModel {
            [NameInMap("Sensitive")]
            [Validation(Required=false)]
            public bool? Sensitive { get; set; }
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<ClassifyingRubbishResponseBodyDataElements> Elements { get; set; }
            public class ClassifyingRubbishResponseBodyDataElements : TeaModel {
                public float? CategoryScore { get; set; }
                public string Rubbish { get; set; }
                public float? RubbishScore { get; set; }
                public string Category { get; set; }
            }
        };

    }

}
