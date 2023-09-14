// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class GetDoctorApplicationResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDoctorApplicationResponseBodyData Data { get; set; }
        public class GetDoctorApplicationResponseBodyData : TeaModel {
            [NameInMap("Analysis")]
            [Validation(Required=false)]
            public GetDoctorApplicationResponseBodyDataAnalysis Analysis { get; set; }
            public class GetDoctorApplicationResponseBodyDataAnalysis : TeaModel {
                [NameInMap("Score")]
                [Validation(Required=false)]
                public int? Score { get; set; }

                [NameInMap("Suggestion")]
                [Validation(Required=false)]
                public string Suggestion { get; set; }

            }

            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("Ids")]
            [Validation(Required=false)]
            public List<string> Ids { get; set; }

            [NameInMap("Metrics")]
            [Validation(Required=false)]
            public GetDoctorApplicationResponseBodyDataMetrics Metrics { get; set; }
            public class GetDoctorApplicationResponseBodyDataMetrics : TeaModel {
                [NameInMap("MemSeconds")]
                [Validation(Required=false)]
                public GetDoctorApplicationResponseBodyDataMetricsMemSeconds MemSeconds { get; set; }
                public class GetDoctorApplicationResponseBodyDataMetricsMemSeconds : TeaModel {
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

                [NameInMap("MemUtilization")]
                [Validation(Required=false)]
                public GetDoctorApplicationResponseBodyDataMetricsMemUtilization MemUtilization { get; set; }
                public class GetDoctorApplicationResponseBodyDataMetricsMemUtilization : TeaModel {
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

                [NameInMap("VcoreSeconds")]
                [Validation(Required=false)]
                public GetDoctorApplicationResponseBodyDataMetricsVcoreSeconds VcoreSeconds { get; set; }
                public class GetDoctorApplicationResponseBodyDataMetricsVcoreSeconds : TeaModel {
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

                [NameInMap("VcoreUtilization")]
                [Validation(Required=false)]
                public GetDoctorApplicationResponseBodyDataMetricsVcoreUtilization VcoreUtilization { get; set; }
                public class GetDoctorApplicationResponseBodyDataMetricsVcoreUtilization : TeaModel {
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

            }

            [NameInMap("QuerySql")]
            [Validation(Required=false)]
            public string QuerySql { get; set; }

            [NameInMap("Queue")]
            [Validation(Required=false)]
            public string Queue { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
