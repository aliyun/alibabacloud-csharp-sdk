// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class DescribeSlowQueryStatusResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public DescribeSlowQueryStatusResponseBodyResult Result { get; set; }
        public class DescribeSlowQueryStatusResponseBodyResult : TeaModel {
            [NameInMap("appGroupId")]
            [Validation(Required=false)]
            public string AppGroupId { get; set; }
            [NameInMap("region")]
            [Validation(Required=false)]
            public string Region { get; set; }
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }
        };

    }

}
