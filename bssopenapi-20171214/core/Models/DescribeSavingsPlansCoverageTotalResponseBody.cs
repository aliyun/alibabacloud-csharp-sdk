// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeSavingsPlansCoverageTotalResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSavingsPlansCoverageTotalResponseBodyData Data { get; set; }
        public class DescribeSavingsPlansCoverageTotalResponseBodyData : TeaModel {
            [NameInMap("PeriodCoverage")]
            [Validation(Required=false)]
            public List<DescribeSavingsPlansCoverageTotalResponseBodyDataPeriodCoverage> PeriodCoverage { get; set; }
            public class DescribeSavingsPlansCoverageTotalResponseBodyDataPeriodCoverage : TeaModel {
                public float? Percentage { get; set; }
                public string Period { get; set; }
            }
            [NameInMap("TotalCoverage")]
            [Validation(Required=false)]
            public DescribeSavingsPlansCoverageTotalResponseBodyDataTotalCoverage TotalCoverage { get; set; }
            public class DescribeSavingsPlansCoverageTotalResponseBodyDataTotalCoverage : TeaModel {
                [NameInMap("CoveragePercentage")]
                [Validation(Required=false)]
                public float? CoveragePercentage { get; set; }

                [NameInMap("DeductAmount")]
                [Validation(Required=false)]
                public float? DeductAmount { get; set; }

            }
        };

    }

}
