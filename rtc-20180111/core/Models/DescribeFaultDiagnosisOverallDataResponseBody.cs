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

                /// <summary>
                /// <b>Example:</b>
                /// <para>1615824000</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public string X { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public string Y { get; set; }

            }

        }

        [NameInMap("OverallData")]
        [Validation(Required=false)]
        public DescribeFaultDiagnosisOverallDataResponseBodyOverallData OverallData { get; set; }
        public class DescribeFaultDiagnosisOverallDataResponseBodyOverallData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("FaultUserCount")]
            [Validation(Required=false)]
            public int? FaultUserCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.1</para>
            /// </summary>
            [NameInMap("FaultUserRatio")]
            [Validation(Required=false)]
            public float? FaultUserRatio { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("TotalUserCount")]
            [Validation(Required=false)]
            public int? TotalUserCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>231470C1-ACFB-4C9F-844F-4CFE1E3804C5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
