// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListSlowQueryQueriesResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public ListSlowQueryQueriesResponseBodyResult Result { get; set; }
        public class ListSlowQueryQueriesResponseBodyResult : TeaModel {
            [NameInMap("appQuery")]
            [Validation(Required=false)]
            public string AppQuery { get; set; }
            [NameInMap("end")]
            [Validation(Required=false)]
            public int? End { get; set; }
            [NameInMap("index")]
            [Validation(Required=false)]
            public int? Index { get; set; }
            [NameInMap("start")]
            [Validation(Required=false)]
            public int? Start { get; set; }
        };

    }

}
