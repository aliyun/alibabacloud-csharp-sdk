// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRCInstanceDdosCountResponseBody : TeaModel {
        [NameInMap("DdosCount")]
        [Validation(Required=false)]
        public DescribeRCInstanceDdosCountResponseBodyDdosCount DdosCount { get; set; }
        public class DescribeRCInstanceDdosCountResponseBodyDdosCount : TeaModel {
            [NameInMap("BlackholeCount")]
            [Validation(Required=false)]
            public string BlackholeCount { get; set; }

            [NameInMap("DefenseCount")]
            [Validation(Required=false)]
            public string DefenseCount { get; set; }

            [NameInMap("InstacenCount")]
            [Validation(Required=false)]
            public string InstacenCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
