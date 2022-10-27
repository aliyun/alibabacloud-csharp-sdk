// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeAnomalySQLListResponseBody : TeaModel {
        [NameInMap("AnomalySQLList")]
        [Validation(Required=false)]
        public List<DescribeAnomalySQLListResponseBodyAnomalySQLList> AnomalySQLList { get; set; }
        public class DescribeAnomalySQLListResponseBodyAnomalySQLList : TeaModel {
            [NameInMap("CpuTime")]
            [Validation(Required=false)]
            public float? CpuTime { get; set; }

            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            [NameInMap("Diagnosis")]
            [Validation(Required=false)]
            public string Diagnosis { get; set; }

            [NameInMap("DiagnosisRule")]
            [Validation(Required=false)]
            public string DiagnosisRule { get; set; }

            [NameInMap("Executions")]
            [Validation(Required=false)]
            public long? Executions { get; set; }

            [NameInMap("Key")]
            [Validation(Required=false)]
            public long? Key { get; set; }

            [NameInMap("RequestTime")]
            [Validation(Required=false)]
            public float? RequestTime { get; set; }

            [NameInMap("RequestTimeUTCString")]
            [Validation(Required=false)]
            public string RequestTimeUTCString { get; set; }

            [NameInMap("SQLId")]
            [Validation(Required=false)]
            public string SQLId { get; set; }

            [NameInMap("SQLText")]
            [Validation(Required=false)]
            public string SQLText { get; set; }

            [NameInMap("Suggestion")]
            [Validation(Required=false)]
            public string Suggestion { get; set; }

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
