// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeDiagnosisRecordsResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("Querys")]
        [Validation(Required=false)]
        public List<DescribeDiagnosisRecordsResponseBodyQuerys> Querys { get; set; }
        public class DescribeDiagnosisRecordsResponseBodyQuerys : TeaModel {
            [NameInMap("SQL")]
            [Validation(Required=false)]
            public string SQL { get; set; }

            [NameInMap("SQLTruncatedThreshold")]
            [Validation(Required=false)]
            public long? SQLTruncatedThreshold { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("OutputDataSize")]
            [Validation(Required=false)]
            public long? OutputDataSize { get; set; }

            [NameInMap("Cost")]
            [Validation(Required=false)]
            public long? Cost { get; set; }

            [NameInMap("OutputRows")]
            [Validation(Required=false)]
            public long? OutputRows { get; set; }

            [NameInMap("RcHost")]
            [Validation(Required=false)]
            public string RcHost { get; set; }

            [NameInMap("ScanSize")]
            [Validation(Required=false)]
            public long? ScanSize { get; set; }

            [NameInMap("ProcessId")]
            [Validation(Required=false)]
            public string ProcessId { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("SQLTruncated")]
            [Validation(Required=false)]
            public bool? SQLTruncated { get; set; }

            [NameInMap("Database")]
            [Validation(Required=false)]
            public string Database { get; set; }

            [NameInMap("ScanRows")]
            [Validation(Required=false)]
            public long? ScanRows { get; set; }

            [NameInMap("ResourceCostRank")]
            [Validation(Required=false)]
            public int? ResourceCostRank { get; set; }

            [NameInMap("ClientIp")]
            [Validation(Required=false)]
            public string ClientIp { get; set; }

            [NameInMap("PeakMemory")]
            [Validation(Required=false)]
            public long? PeakMemory { get; set; }

            [NameInMap("QueueTime")]
            [Validation(Required=false)]
            public long? QueueTime { get; set; }

            [NameInMap("ResourceGroup")]
            [Validation(Required=false)]
            public string ResourceGroup { get; set; }

            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            [NameInMap("ExecutionTime")]
            [Validation(Required=false)]
            public long? ExecutionTime { get; set; }

            [NameInMap("TotalPlanningTime")]
            [Validation(Required=false)]
            public long? TotalPlanningTime { get; set; }

            [NameInMap("EtlWriteRows")]
            [Validation(Required=false)]
            public long? EtlWriteRows { get; set; }

            [NameInMap("TotalStages")]
            [Validation(Required=false)]
            public int? TotalStages { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
