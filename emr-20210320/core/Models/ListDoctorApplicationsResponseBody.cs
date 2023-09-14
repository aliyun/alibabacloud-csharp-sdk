// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListDoctorApplicationsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListDoctorApplicationsResponseBodyData> Data { get; set; }
        public class ListDoctorApplicationsResponseBodyData : TeaModel {
            [NameInMap("Analysis")]
            [Validation(Required=false)]
            public ListDoctorApplicationsResponseBodyDataAnalysis Analysis { get; set; }
            public class ListDoctorApplicationsResponseBodyDataAnalysis : TeaModel {
                [NameInMap("Score")]
                [Validation(Required=false)]
                public int? Score { get; set; }

                [NameInMap("Suggestion")]
                [Validation(Required=false)]
                public string Suggestion { get; set; }

            }

            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

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
            public ListDoctorApplicationsResponseBodyDataMetrics Metrics { get; set; }
            public class ListDoctorApplicationsResponseBodyDataMetrics : TeaModel {
                [NameInMap("MemSeconds")]
                [Validation(Required=false)]
                public ListDoctorApplicationsResponseBodyDataMetricsMemSeconds MemSeconds { get; set; }
                public class ListDoctorApplicationsResponseBodyDataMetricsMemSeconds : TeaModel {
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
                public ListDoctorApplicationsResponseBodyDataMetricsMemUtilization MemUtilization { get; set; }
                public class ListDoctorApplicationsResponseBodyDataMetricsMemUtilization : TeaModel {
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
                public ListDoctorApplicationsResponseBodyDataMetricsVcoreSeconds VcoreSeconds { get; set; }
                public class ListDoctorApplicationsResponseBodyDataMetricsVcoreSeconds : TeaModel {
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
                public ListDoctorApplicationsResponseBodyDataMetricsVcoreUtilization VcoreUtilization { get; set; }
                public class ListDoctorApplicationsResponseBodyDataMetricsVcoreUtilization : TeaModel {
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
