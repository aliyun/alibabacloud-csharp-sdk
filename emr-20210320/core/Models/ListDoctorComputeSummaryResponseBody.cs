// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListDoctorComputeSummaryResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListDoctorComputeSummaryResponseBodyData> Data { get; set; }
        public class ListDoctorComputeSummaryResponseBodyData : TeaModel {
            [NameInMap("Analysis")]
            [Validation(Required=false)]
            public ListDoctorComputeSummaryResponseBodyDataAnalysis Analysis { get; set; }
            public class ListDoctorComputeSummaryResponseBodyDataAnalysis : TeaModel {
                [NameInMap("HealthyJobCount")]
                [Validation(Required=false)]
                public long? HealthyJobCount { get; set; }

                [NameInMap("NeedAttentionJobCount")]
                [Validation(Required=false)]
                public long? NeedAttentionJobCount { get; set; }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public int? Score { get; set; }

                [NameInMap("ScoreDayGrowthRatio")]
                [Validation(Required=false)]
                public float? ScoreDayGrowthRatio { get; set; }

                [NameInMap("SubHealthyJobCount")]
                [Validation(Required=false)]
                public long? SubHealthyJobCount { get; set; }

                [NameInMap("UnhealthyJobCount")]
                [Validation(Required=false)]
                public long? UnhealthyJobCount { get; set; }

            }

            [NameInMap("ComponentName")]
            [Validation(Required=false)]
            public string ComponentName { get; set; }

            [NameInMap("Metrics")]
            [Validation(Required=false)]
            public ListDoctorComputeSummaryResponseBodyDataMetrics Metrics { get; set; }
            public class ListDoctorComputeSummaryResponseBodyDataMetrics : TeaModel {
                [NameInMap("MemSeconds")]
                [Validation(Required=false)]
                public ListDoctorComputeSummaryResponseBodyDataMetricsMemSeconds MemSeconds { get; set; }
                public class ListDoctorComputeSummaryResponseBodyDataMetricsMemSeconds : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                [NameInMap("MemSecondsDayGrowthRatio")]
                [Validation(Required=false)]
                public ListDoctorComputeSummaryResponseBodyDataMetricsMemSecondsDayGrowthRatio MemSecondsDayGrowthRatio { get; set; }
                public class ListDoctorComputeSummaryResponseBodyDataMetricsMemSecondsDayGrowthRatio : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                [NameInMap("MemUtilization")]
                [Validation(Required=false)]
                public ListDoctorComputeSummaryResponseBodyDataMetricsMemUtilization MemUtilization { get; set; }
                public class ListDoctorComputeSummaryResponseBodyDataMetricsMemUtilization : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                [NameInMap("ReadSize")]
                [Validation(Required=false)]
                public ListDoctorComputeSummaryResponseBodyDataMetricsReadSize ReadSize { get; set; }
                public class ListDoctorComputeSummaryResponseBodyDataMetricsReadSize : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                [NameInMap("VcoreSeconds")]
                [Validation(Required=false)]
                public ListDoctorComputeSummaryResponseBodyDataMetricsVcoreSeconds VcoreSeconds { get; set; }
                public class ListDoctorComputeSummaryResponseBodyDataMetricsVcoreSeconds : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                [NameInMap("VcoreSecondsDayGrowthRatio")]
                [Validation(Required=false)]
                public ListDoctorComputeSummaryResponseBodyDataMetricsVcoreSecondsDayGrowthRatio VcoreSecondsDayGrowthRatio { get; set; }
                public class ListDoctorComputeSummaryResponseBodyDataMetricsVcoreSecondsDayGrowthRatio : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                [NameInMap("VcoreUtilization")]
                [Validation(Required=false)]
                public ListDoctorComputeSummaryResponseBodyDataMetricsVcoreUtilization VcoreUtilization { get; set; }
                public class ListDoctorComputeSummaryResponseBodyDataMetricsVcoreUtilization : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                [NameInMap("WriteSize")]
                [Validation(Required=false)]
                public ListDoctorComputeSummaryResponseBodyDataMetricsWriteSize WriteSize { get; set; }
                public class ListDoctorComputeSummaryResponseBodyDataMetricsWriteSize : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

            }

        }

        /// <summary>
        /// 本次请求所返回的最大记录条数。
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 返回读取到的数据位置，空代表数据已经读取完毕。
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 本次请求条件下的数据总量。
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
