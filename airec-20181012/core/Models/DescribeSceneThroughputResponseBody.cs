// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20181012.Models
{
    public class DescribeSceneThroughputResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeSceneThroughputResponseBodyResult Result { get; set; }
        public class DescribeSceneThroughputResponseBodyResult : TeaModel {
            [NameInMap("PvCount")]
            [Validation(Required=false)]
            public long? PvCount { get; set; }
        };

    }

}
