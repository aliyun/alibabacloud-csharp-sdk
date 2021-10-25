// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeSQLPlanResponseBody : TeaModel {
        [NameInMap("OriginInfo")]
        [Validation(Required=false)]
        public string OriginInfo { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Detail")]
        [Validation(Required=false)]
        public DescribeSQLPlanResponseBodyDetail Detail { get; set; }
        public class DescribeSQLPlanResponseBodyDetail : TeaModel {
            [NameInMap("SQL")]
            [Validation(Required=false)]
            public string SQL { get; set; }
            [NameInMap("OutputSize")]
            [Validation(Required=false)]
            public long? OutputSize { get; set; }
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }
            [NameInMap("OutputRows")]
            [Validation(Required=false)]
            public long? OutputRows { get; set; }
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }
            [NameInMap("TotalStage")]
            [Validation(Required=false)]
            public long? TotalStage { get; set; }
            [NameInMap("TotalTime")]
            [Validation(Required=false)]
            public long? TotalTime { get; set; }
            [NameInMap("QueuedTime")]
            [Validation(Required=false)]
            public long? QueuedTime { get; set; }
            [NameInMap("Database")]
            [Validation(Required=false)]
            public string Database { get; set; }
            [NameInMap("TotalTask")]
            [Validation(Required=false)]
            public long? TotalTask { get; set; }
            [NameInMap("PeakMemory")]
            [Validation(Required=false)]
            public long? PeakMemory { get; set; }
            [NameInMap("ClientIP")]
            [Validation(Required=false)]
            public string ClientIP { get; set; }
            [NameInMap("PlanningTime")]
            [Validation(Required=false)]
            public long? PlanningTime { get; set; }
            [NameInMap("CPUTime")]
            [Validation(Required=false)]
            public long? CPUTime { get; set; }
        };

        [NameInMap("StageList")]
        [Validation(Required=false)]
        public List<DescribeSQLPlanResponseBodyStageList> StageList { get; set; }
        public class DescribeSQLPlanResponseBodyStageList : TeaModel {
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("CPUTimeMax")]
            [Validation(Required=false)]
            public long? CPUTimeMax { get; set; }

            [NameInMap("CPUTimeAvg")]
            [Validation(Required=false)]
            public long? CPUTimeAvg { get; set; }

            [NameInMap("OperatorCost")]
            [Validation(Required=false)]
            public long? OperatorCost { get; set; }

            [NameInMap("ScanTimeMax")]
            [Validation(Required=false)]
            public long? ScanTimeMax { get; set; }

            [NameInMap("StageId")]
            [Validation(Required=false)]
            public int? StageId { get; set; }

            [NameInMap("InputSizeMax")]
            [Validation(Required=false)]
            public long? InputSizeMax { get; set; }

            [NameInMap("ScanSizeMax")]
            [Validation(Required=false)]
            public long? ScanSizeMax { get; set; }

            [NameInMap("CPUTimeMin")]
            [Validation(Required=false)]
            public long? CPUTimeMin { get; set; }

            [NameInMap("ScanTimeMin")]
            [Validation(Required=false)]
            public long? ScanTimeMin { get; set; }

            [NameInMap("ScanSizeMin")]
            [Validation(Required=false)]
            public long? ScanSizeMin { get; set; }

            [NameInMap("InputSizeMin")]
            [Validation(Required=false)]
            public long? InputSizeMin { get; set; }

            [NameInMap("PeakMemory")]
            [Validation(Required=false)]
            public long? PeakMemory { get; set; }

            [NameInMap("ScanTimeAvg")]
            [Validation(Required=false)]
            public long? ScanTimeAvg { get; set; }

            [NameInMap("ScanSizeAvg")]
            [Validation(Required=false)]
            public long? ScanSizeAvg { get; set; }

            [NameInMap("InputSizeAvg")]
            [Validation(Required=false)]
            public long? InputSizeAvg { get; set; }

        }

    }

}
