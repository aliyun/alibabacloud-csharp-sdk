// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeProcessStatsCompositionResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeProcessStatsCompositionResponseBodyData> Data { get; set; }
        public class DescribeProcessStatsCompositionResponseBodyData : TeaModel {
            [NameInMap("ActiveSessionCount")]
            [Validation(Required=false)]
            public int? ActiveSessionCount { get; set; }

            [NameInMap("AllProcessList")]
            [Validation(Required=false)]
            public List<DescribeProcessStatsCompositionResponseBodyDataAllProcessList> AllProcessList { get; set; }
            public class DescribeProcessStatsCompositionResponseBodyDataAllProcessList : TeaModel {
                [NameInMap("ClientIp")]
                [Validation(Required=false)]
                public string ClientIp { get; set; }

                [NameInMap("Command")]
                [Validation(Required=false)]
                public string Command { get; set; }

                [NameInMap("CpuTime")]
                [Validation(Required=false)]
                public long? CpuTime { get; set; }

                [NameInMap("Database")]
                [Validation(Required=false)]
                public string Database { get; set; }

                [NameInMap("ExecuteTime")]
                [Validation(Required=false)]
                public long? ExecuteTime { get; set; }

                [NameInMap("PlanId")]
                [Validation(Required=false)]
                public string PlanId { get; set; }

                [NameInMap("ProxySessId")]
                [Validation(Required=false)]
                public string ProxySessId { get; set; }

                [NameInMap("ServerIp")]
                [Validation(Required=false)]
                public string ServerIp { get; set; }

                [NameInMap("SessionId")]
                [Validation(Required=false)]
                public long? SessionId { get; set; }

                /// <summary>
                /// SQL ID。
                /// </summary>
                [NameInMap("SqlId")]
                [Validation(Required=false)]
                public string SqlId { get; set; }

                [NameInMap("SqlText")]
                [Validation(Required=false)]
                public string SqlText { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                [NameInMap("TraceId")]
                [Validation(Required=false)]
                public string TraceId { get; set; }

                [NameInMap("User")]
                [Validation(Required=false)]
                public string User { get; set; }

            }

            [NameInMap("IdleSessionCount")]
            [Validation(Required=false)]
            public int? IdleSessionCount { get; set; }

            [NameInMap("ObVersion")]
            [Validation(Required=false)]
            public string ObVersion { get; set; }

            [NameInMap("SessionStatistics")]
            [Validation(Required=false)]
            public DescribeProcessStatsCompositionResponseBodyDataSessionStatistics SessionStatistics { get; set; }
            public class DescribeProcessStatsCompositionResponseBodyDataSessionStatistics : TeaModel {
                [NameInMap("DataBaseStatistics")]
                [Validation(Required=false)]
                public List<DescribeProcessStatsCompositionResponseBodyDataSessionStatisticsDataBaseStatistics> DataBaseStatistics { get; set; }
                public class DescribeProcessStatsCompositionResponseBodyDataSessionStatisticsDataBaseStatistics : TeaModel {
                    [NameInMap("ActiveCount")]
                    [Validation(Required=false)]
                    public long? ActiveCount { get; set; }

                    [NameInMap("MetricValue")]
                    [Validation(Required=false)]
                    public string MetricValue { get; set; }

                    [NameInMap("TotalCount")]
                    [Validation(Required=false)]
                    public long? TotalCount { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("SourceStatistics")]
                [Validation(Required=false)]
                public List<DescribeProcessStatsCompositionResponseBodyDataSessionStatisticsSourceStatistics> SourceStatistics { get; set; }
                public class DescribeProcessStatsCompositionResponseBodyDataSessionStatisticsSourceStatistics : TeaModel {
                    [NameInMap("ActiveCount")]
                    [Validation(Required=false)]
                    public long? ActiveCount { get; set; }

                    [NameInMap("MetricValue")]
                    [Validation(Required=false)]
                    public string MetricValue { get; set; }

                    [NameInMap("TotalCount")]
                    [Validation(Required=false)]
                    public long? TotalCount { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("UserStatistics")]
                [Validation(Required=false)]
                public List<DescribeProcessStatsCompositionResponseBodyDataSessionStatisticsUserStatistics> UserStatistics { get; set; }
                public class DescribeProcessStatsCompositionResponseBodyDataSessionStatisticsUserStatistics : TeaModel {
                    [NameInMap("ActiveCount")]
                    [Validation(Required=false)]
                    public long? ActiveCount { get; set; }

                    [NameInMap("MetricValue")]
                    [Validation(Required=false)]
                    public string MetricValue { get; set; }

                    [NameInMap("TotalCount")]
                    [Validation(Required=false)]
                    public long? TotalCount { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            [NameInMap("TotalSessionCount")]
            [Validation(Required=false)]
            public int? TotalSessionCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
