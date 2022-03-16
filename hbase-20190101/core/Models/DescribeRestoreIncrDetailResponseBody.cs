// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeRestoreIncrDetailResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RestoreIncrDetail")]
        [Validation(Required=false)]
        public DescribeRestoreIncrDetailResponseBodyRestoreIncrDetail RestoreIncrDetail { get; set; }
        public class DescribeRestoreIncrDetailResponseBodyRestoreIncrDetail : TeaModel {
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }
            [NameInMap("Process")]
            [Validation(Required=false)]
            public string Process { get; set; }
            [NameInMap("RestoreDelay")]
            [Validation(Required=false)]
            public string RestoreDelay { get; set; }
            [NameInMap("RestoreStartTs")]
            [Validation(Required=false)]
            public string RestoreStartTs { get; set; }
            [NameInMap("RestoredTs")]
            [Validation(Required=false)]
            public string RestoredTs { get; set; }
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }
        };

    }

}
