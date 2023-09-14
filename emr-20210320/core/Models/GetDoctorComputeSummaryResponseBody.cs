// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class GetDoctorComputeSummaryResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDoctorComputeSummaryResponseBodyData Data { get; set; }
        public class GetDoctorComputeSummaryResponseBodyData : TeaModel {
            [NameInMap("Analysis")]
            [Validation(Required=false)]
            public GetDoctorComputeSummaryResponseBodyDataAnalysis Analysis { get; set; }
            public class GetDoctorComputeSummaryResponseBodyDataAnalysis : TeaModel {
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

            [NameInMap("Metrics")]
            [Validation(Required=false)]
            public GetDoctorComputeSummaryResponseBodyDataMetrics Metrics { get; set; }
            public class GetDoctorComputeSummaryResponseBodyDataMetrics : TeaModel {
                [NameInMap("MemSeconds")]
                [Validation(Required=false)]
                public GetDoctorComputeSummaryResponseBodyDataMetricsMemSeconds MemSeconds { get; set; }
                public class GetDoctorComputeSummaryResponseBodyDataMetricsMemSeconds : TeaModel {
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
                public GetDoctorComputeSummaryResponseBodyDataMetricsMemSecondsDayGrowthRatio MemSecondsDayGrowthRatio { get; set; }
                public class GetDoctorComputeSummaryResponseBodyDataMetricsMemSecondsDayGrowthRatio : TeaModel {
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
                public GetDoctorComputeSummaryResponseBodyDataMetricsMemUtilization MemUtilization { get; set; }
                public class GetDoctorComputeSummaryResponseBodyDataMetricsMemUtilization : TeaModel {
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
                public GetDoctorComputeSummaryResponseBodyDataMetricsReadSize ReadSize { get; set; }
                public class GetDoctorComputeSummaryResponseBodyDataMetricsReadSize : TeaModel {
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
                public GetDoctorComputeSummaryResponseBodyDataMetricsVcoreSeconds VcoreSeconds { get; set; }
                public class GetDoctorComputeSummaryResponseBodyDataMetricsVcoreSeconds : TeaModel {
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
                public GetDoctorComputeSummaryResponseBodyDataMetricsVcoreSecondsDayGrowthRatio VcoreSecondsDayGrowthRatio { get; set; }
                public class GetDoctorComputeSummaryResponseBodyDataMetricsVcoreSecondsDayGrowthRatio : TeaModel {
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
                public GetDoctorComputeSummaryResponseBodyDataMetricsVcoreUtilization VcoreUtilization { get; set; }
                public class GetDoctorComputeSummaryResponseBodyDataMetricsVcoreUtilization : TeaModel {
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
                public GetDoctorComputeSummaryResponseBodyDataMetricsWriteSize WriteSize { get; set; }
                public class GetDoctorComputeSummaryResponseBodyDataMetricsWriteSize : TeaModel {
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
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
