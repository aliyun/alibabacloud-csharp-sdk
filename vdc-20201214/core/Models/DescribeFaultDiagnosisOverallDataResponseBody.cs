// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribeFaultDiagnosisOverallDataResponseBody : TeaModel {
        /// <summary>
        /// 异常指标数据
        /// </summary>
        [NameInMap("MetricData")]
        [Validation(Required=false)]
        public DescribeFaultDiagnosisOverallDataResponseBodyMetricData MetricData { get; set; }
        public class DescribeFaultDiagnosisOverallDataResponseBodyMetricData : TeaModel {
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<DescribeFaultDiagnosisOverallDataResponseBodyMetricDataNodes> Nodes { get; set; }
            public class DescribeFaultDiagnosisOverallDataResponseBodyMetricDataNodes : TeaModel {
                public Dictionary<string, string> Ext { get; set; }
                public string X { get; set; }
                public string Y { get; set; }
            }
        };

        /// <summary>
        /// 总览数据
        /// </summary>
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
        };

        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
