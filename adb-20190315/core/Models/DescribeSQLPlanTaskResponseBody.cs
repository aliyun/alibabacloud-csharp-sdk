// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeSQLPlanTaskResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TaskList")]
        [Validation(Required=false)]
        public List<DescribeSQLPlanTaskResponseBodyTaskList> TaskList { get; set; }
        public class DescribeSQLPlanTaskResponseBodyTaskList : TeaModel {
            [NameInMap("ScanCost")]
            [Validation(Required=false)]
            public long? ScanCost { get; set; }

            [NameInMap("OutputSize")]
            [Validation(Required=false)]
            public long? OutputSize { get; set; }

            [NameInMap("InputSize")]
            [Validation(Required=false)]
            public long? InputSize { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("OperatorCost")]
            [Validation(Required=false)]
            public long? OperatorCost { get; set; }

            [NameInMap("OutputRows")]
            [Validation(Required=false)]
            public long? OutputRows { get; set; }

            [NameInMap("ScanSize")]
            [Validation(Required=false)]
            public long? ScanSize { get; set; }

            [NameInMap("ElapsedTime")]
            [Validation(Required=false)]
            public long? ElapsedTime { get; set; }

            [NameInMap("ScanRows")]
            [Validation(Required=false)]
            public long? ScanRows { get; set; }

            [NameInMap("PeakMemory")]
            [Validation(Required=false)]
            public long? PeakMemory { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public int? TaskId { get; set; }

            [NameInMap("InputRows")]
            [Validation(Required=false)]
            public long? InputRows { get; set; }

        }

    }

}
