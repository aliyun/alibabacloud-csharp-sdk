// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListSlowQueryCategoriesResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public ListSlowQueryCategoriesResponseBodyResult Result { get; set; }
        public class ListSlowQueryCategoriesResponseBodyResult : TeaModel {
            [NameInMap("start")]
            [Validation(Required=false)]
            public int? Start { get; set; }
            [NameInMap("analyzeStatus")]
            [Validation(Required=false)]
            public string AnalyzeStatus { get; set; }
            [NameInMap("end")]
            [Validation(Required=false)]
            public int? End { get; set; }
        };

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
