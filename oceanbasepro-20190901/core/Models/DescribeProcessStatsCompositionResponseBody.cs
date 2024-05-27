// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeProcessStatsCompositionResponseBody : TeaModel {
        /// <summary>
        /// The return result.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeProcessStatsCompositionResponseBodyData> Data { get; set; }
        public class DescribeProcessStatsCompositionResponseBodyData : TeaModel {
            /// <summary>
            /// The number of active sessions.
            /// </summary>
            [NameInMap("ActiveSessionCount")]
            [Validation(Required=false)]
            public int? ActiveSessionCount { get; set; }

            /// <summary>
            /// The list of all processes in the system.
            /// </summary>
            [NameInMap("AllProcessList")]
            [Validation(Required=false)]
            public List<DescribeProcessStatsCompositionResponseBodyDataAllProcessList> AllProcessList { get; set; }
            public class DescribeProcessStatsCompositionResponseBodyDataAllProcessList : TeaModel {
                /// <summary>
                /// The IP address of the client.
                /// </summary>
                [NameInMap("ClientIp")]
                [Validation(Required=false)]
                public string ClientIp { get; set; }

                /// <summary>
                /// The type of command executed on the current session.
                /// </summary>
                [NameInMap("Command")]
                [Validation(Required=false)]
                public string Command { get; set; }

                /// <summary>
                /// The CPU time.
                /// </summary>
                [NameInMap("CpuTime")]
                [Validation(Required=false)]
                public long? CpuTime { get; set; }

                /// <summary>
                /// The name of the database.
                /// </summary>
                [NameInMap("Database")]
                [Validation(Required=false)]
                public string Database { get; set; }

                /// <summary>
                /// The execution time.
                /// </summary>
                [NameInMap("ExecuteTime")]
                [Validation(Required=false)]
                public long? ExecuteTime { get; set; }

                /// <summary>
                /// The ID of the plan.
                /// </summary>
                [NameInMap("PlanId")]
                [Validation(Required=false)]
                public string PlanId { get; set; }

                /// <summary>
                /// The ID of the proxy session.
                /// </summary>
                [NameInMap("ProxySessId")]
                [Validation(Required=false)]
                public string ProxySessId { get; set; }

                /// <summary>
                /// The IP address of the server.
                /// </summary>
                [NameInMap("ServerIp")]
                [Validation(Required=false)]
                public string ServerIp { get; set; }

                /// <summary>
                /// The ID of the session.
                /// </summary>
                [NameInMap("SessionId")]
                [Validation(Required=false)]
                public long? SessionId { get; set; }

                /// <summary>
                /// The ID of the SQL statement.
                /// </summary>
                [NameInMap("SqlId")]
                [Validation(Required=false)]
                public string SqlId { get; set; }

                /// <summary>
                /// The SQL statement.
                /// </summary>
                [NameInMap("SqlText")]
                [Validation(Required=false)]
                public string SqlText { get; set; }

                /// <summary>
                /// The state of the session.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The ID of the tenant.
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                /// <summary>
                /// The ID of the trace.
                /// </summary>
                [NameInMap("TraceId")]
                [Validation(Required=false)]
                public string TraceId { get; set; }

                /// <summary>
                /// The username that you use to log in to the database.
                /// </summary>
                [NameInMap("User")]
                [Validation(Required=false)]
                public string User { get; set; }

            }

            /// <summary>
            /// The number of idle sessions.
            /// </summary>
            [NameInMap("IdleSessionCount")]
            [Validation(Required=false)]
            public int? IdleSessionCount { get; set; }

            /// <summary>
            /// The version of OceanBase Database.
            /// </summary>
            [NameInMap("ObVersion")]
            [Validation(Required=false)]
            public string ObVersion { get; set; }

            /// <summary>
            /// The session statistics.
            /// </summary>
            [NameInMap("SessionStatistics")]
            [Validation(Required=false)]
            public DescribeProcessStatsCompositionResponseBodyDataSessionStatistics SessionStatistics { get; set; }
            public class DescribeProcessStatsCompositionResponseBodyDataSessionStatistics : TeaModel {
                /// <summary>
                /// The database statistics.
                /// </summary>
                [NameInMap("DataBaseStatistics")]
                [Validation(Required=false)]
                public List<DescribeProcessStatsCompositionResponseBodyDataSessionStatisticsDataBaseStatistics> DataBaseStatistics { get; set; }
                public class DescribeProcessStatsCompositionResponseBodyDataSessionStatisticsDataBaseStatistics : TeaModel {
                    /// <summary>
                    /// The number of active sessions.
                    /// </summary>
                    [NameInMap("ActiveCount")]
                    [Validation(Required=false)]
                    public long? ActiveCount { get; set; }

                    /// <summary>
                    /// The value of the database metric.
                    /// </summary>
                    [NameInMap("MetricValue")]
                    [Validation(Required=false)]
                    public string MetricValue { get; set; }

                    /// <summary>
                    /// The total number of sessions.
                    /// </summary>
                    [NameInMap("TotalCount")]
                    [Validation(Required=false)]
                    public long? TotalCount { get; set; }

                    /// <summary>
                    /// The type of the database statistics.
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// The data source statistics.
                /// </summary>
                [NameInMap("SourceStatistics")]
                [Validation(Required=false)]
                public List<DescribeProcessStatsCompositionResponseBodyDataSessionStatisticsSourceStatistics> SourceStatistics { get; set; }
                public class DescribeProcessStatsCompositionResponseBodyDataSessionStatisticsSourceStatistics : TeaModel {
                    /// <summary>
                    /// The number of active sessions.
                    /// </summary>
                    [NameInMap("ActiveCount")]
                    [Validation(Required=false)]
                    public long? ActiveCount { get; set; }

                    /// <summary>
                    /// The value of the data source metric.
                    /// </summary>
                    [NameInMap("MetricValue")]
                    [Validation(Required=false)]
                    public string MetricValue { get; set; }

                    /// <summary>
                    /// The total number of sessions.
                    /// </summary>
                    [NameInMap("TotalCount")]
                    [Validation(Required=false)]
                    public long? TotalCount { get; set; }

                    /// <summary>
                    /// The type of the data source.
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// The user statistics.
                /// </summary>
                [NameInMap("UserStatistics")]
                [Validation(Required=false)]
                public List<DescribeProcessStatsCompositionResponseBodyDataSessionStatisticsUserStatistics> UserStatistics { get; set; }
                public class DescribeProcessStatsCompositionResponseBodyDataSessionStatisticsUserStatistics : TeaModel {
                    /// <summary>
                    /// The number of active sessions.
                    /// </summary>
                    [NameInMap("ActiveCount")]
                    [Validation(Required=false)]
                    public long? ActiveCount { get; set; }

                    /// <summary>
                    /// The value of the user metric.
                    /// </summary>
                    [NameInMap("MetricValue")]
                    [Validation(Required=false)]
                    public string MetricValue { get; set; }

                    /// <summary>
                    /// The total number of sessions.
                    /// </summary>
                    [NameInMap("TotalCount")]
                    [Validation(Required=false)]
                    public long? TotalCount { get; set; }

                    /// <summary>
                    /// The type of the user.
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// The total number of sessions.
            /// </summary>
            [NameInMap("TotalSessionCount")]
            [Validation(Required=false)]
            public int? TotalSessionCount { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
