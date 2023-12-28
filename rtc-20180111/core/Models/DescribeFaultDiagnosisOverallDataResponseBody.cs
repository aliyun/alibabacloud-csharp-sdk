// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeFaultDiagnosisOverallDataResponseBody : TeaModel {
        [NameInMap("MetricData")]
        [Validation(Required=false)]
        public DescribeFaultDiagnosisOverallDataResponseBodyMetricData MetricData { get; set; }
        public class DescribeFaultDiagnosisOverallDataResponseBodyMetricData : TeaModel {
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<DescribeFaultDiagnosisOverallDataResponseBodyMetricDataNodes> Nodes { get; set; }
            public class DescribeFaultDiagnosisOverallDataResponseBodyMetricDataNodes : TeaModel {
                [NameInMap("Ext")]
                [Validation(Required=false)]
                public Dictionary<string, object> Ext { get; set; }

                [NameInMap("X")]
                [Validation(Required=false)]
                public string X { get; set; }

                [NameInMap("Y")]
                [Validation(Required=false)]
                public string Y { get; set; }

            }

        }

        [NameInMap("OverallData")]
        [Validation(Required=false)]
        public DescribeFaultDiagnosisOverallDataResponseBodyOverallData OverallData { get; set; }
        public class DescribeFaultDiagnosisOverallDataResponseBodyOverallData : TeaModel {
            [NameInMap("FaultUserCount")]
            [Validation(Required=false)]
            public int? FaultUserCount { get; set; }

            [NameInMap("FaultUserRatio")]
            [Validation(Required=false)]
            public float? FaultUserRatio { get; set; }

            [NameInMap("TotalUserCount")]
            [Validation(Required=false)]
            public int? TotalUserCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
