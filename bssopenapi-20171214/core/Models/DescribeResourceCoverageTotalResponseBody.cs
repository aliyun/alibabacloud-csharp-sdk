// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeResourceCoverageTotalResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeResourceCoverageTotalResponseBodyData Data { get; set; }
        public class DescribeResourceCoverageTotalResponseBodyData : TeaModel {
            [NameInMap("PeriodCoverage")]
            [Validation(Required=false)]
            public List<DescribeResourceCoverageTotalResponseBodyDataPeriodCoverage> PeriodCoverage { get; set; }
            public class DescribeResourceCoverageTotalResponseBodyDataPeriodCoverage : TeaModel {
                public float? CoveragePercentage { get; set; }
                public string Period { get; set; }
            }
            [NameInMap("TotalCoverage")]
            [Validation(Required=false)]
            public DescribeResourceCoverageTotalResponseBodyDataTotalCoverage TotalCoverage { get; set; }
            public class DescribeResourceCoverageTotalResponseBodyDataTotalCoverage : TeaModel {
                [NameInMap("CapacityUnit")]
                [Validation(Required=false)]
                public string CapacityUnit { get; set; }

                [NameInMap("CoveragePercentage")]
                [Validation(Required=false)]
                public float? CoveragePercentage { get; set; }

                [NameInMap("DeductQuantity")]
                [Validation(Required=false)]
                public float? DeductQuantity { get; set; }

                [NameInMap("TotalQuantity")]
                [Validation(Required=false)]
                public float? TotalQuantity { get; set; }

            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
