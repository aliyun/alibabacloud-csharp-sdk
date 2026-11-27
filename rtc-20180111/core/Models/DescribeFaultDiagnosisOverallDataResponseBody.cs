// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeFaultDiagnosisOverallDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The exception metric data.</para>
        /// </summary>
        [NameInMap("MetricData")]
        [Validation(Required=false)]
        public DescribeFaultDiagnosisOverallDataResponseBodyMetricData MetricData { get; set; }
        public class DescribeFaultDiagnosisOverallDataResponseBodyMetricData : TeaModel {
            /// <summary>
            /// <para>The list of coordinate points for the metric trends chart.</para>
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<DescribeFaultDiagnosisOverallDataResponseBodyMetricDataNodes> Nodes { get; set; }
            public class DescribeFaultDiagnosisOverallDataResponseBodyMetricDataNodes : TeaModel {
                /// <summary>
                /// <para>The extended properties, where ratio indicates the proportion of abnormal users per unit time and totalCount indicates the total number of users per unit time.</para>
                /// </summary>
                [NameInMap("Ext")]
                [Validation(Required=false)]
                public Dictionary<string, object> Ext { get; set; }

                /// <summary>
                /// <para>The x-axis coordinate in the metric trends chart. The unit of time is 1 minute.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1615824000</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public string X { get; set; }

                /// <summary>
                /// <para>The y-axis coordinate in the metric trends chart.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public string Y { get; set; }

            }

        }

        /// <summary>
        /// <para>The list of overview data for exception diagnostics.</para>
        /// </summary>
        [NameInMap("OverallData")]
        [Validation(Required=false)]
        public DescribeFaultDiagnosisOverallDataResponseBodyOverallData OverallData { get; set; }
        public class DescribeFaultDiagnosisOverallDataResponseBodyOverallData : TeaModel {
            /// <summary>
            /// <para>The number of abnormal user visits or abnormal users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("FaultUserCount")]
            [Validation(Required=false)]
            public int? FaultUserCount { get; set; }

            /// <summary>
            /// <para>The total proportion of abnormal users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("FaultUserRatio")]
            [Validation(Required=false)]
            public float? FaultUserRatio { get; set; }

            /// <summary>
            /// <para>The total number of user visits or total users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("TotalUserCount")]
            [Validation(Required=false)]
            public int? TotalUserCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>231470C1-ACFB-4C9F-844F-4CFE1E3804C5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
