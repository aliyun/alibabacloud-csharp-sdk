// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeOasAnomalySQLListResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeOasAnomalySQLListResponseBodyData> Data { get; set; }
        public class DescribeOasAnomalySQLListResponseBodyData : TeaModel {
            [NameInMap("AvgCpuTime")]
            [Validation(Required=false)]
            public double? AvgCpuTime { get; set; }

            [NameInMap("AvgElapsedTime")]
            [Validation(Required=false)]
            public double? AvgElapsedTime { get; set; }

            [NameInMap("AvgGetPlanTime")]
            [Validation(Required=false)]
            public double? AvgGetPlanTime { get; set; }

            [NameInMap("CpuTime")]
            [Validation(Required=false)]
            public double? CpuTime { get; set; }

            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            [NameInMap("DiagTypes")]
            [Validation(Required=false)]
            public List<string> DiagTypes { get; set; }

            [NameInMap("Diagnosis")]
            [Validation(Required=false)]
            public string Diagnosis { get; set; }

            [NameInMap("Executions")]
            [Validation(Required=false)]
            public double? Executions { get; set; }

            [NameInMap("LastExecutedTime")]
            [Validation(Required=false)]
            public double? LastExecutedTime { get; set; }

            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// SQL ID。
            /// </summary>
            [NameInMap("SqlId")]
            [Validation(Required=false)]
            public string SqlId { get; set; }

            [NameInMap("SqlTextShort")]
            [Validation(Required=false)]
            public string SqlTextShort { get; set; }

            [NameInMap("Suggestion")]
            [Validation(Required=false)]
            public string Suggestion { get; set; }

            [NameInMap("SumElapsedTime")]
            [Validation(Required=false)]
            public string SumElapsedTime { get; set; }

            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
