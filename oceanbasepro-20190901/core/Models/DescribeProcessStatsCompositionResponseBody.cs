// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeProcessStatsCompositionResponseBody : TeaModel {
        /// <summary>
        /// <para>The return result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeProcessStatsCompositionResponseBodyData Data { get; set; }
        public class DescribeProcessStatsCompositionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of active sessions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("ActiveSessionCount")]
            [Validation(Required=false)]
            public int? ActiveSessionCount { get; set; }

            /// <summary>
            /// <para>The details of all sessions.</para>
            /// </summary>
            [NameInMap("AllProcessList")]
            [Validation(Required=false)]
            public List<DescribeProcessStatsCompositionResponseBodyDataAllProcessList> AllProcessList { get; set; }
            public class DescribeProcessStatsCompositionResponseBodyDataAllProcessList : TeaModel {
                /// <summary>
                /// <para>The IP address of the client.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx.xx.xx.xx</para>
                /// </summary>
                [NameInMap("ClientIp")]
                [Validation(Required=false)]
                public string ClientIp { get; set; }

                /// <summary>
                /// <para>The type of the SQL statement being executed in the session.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Query</para>
                /// </summary>
                [NameInMap("Command")]
                [Validation(Required=false)]
                public string Command { get; set; }

                /// <summary>
                /// <para>The CPU time spent on executing the current SQL statement, in seconds. </para>
                /// <remarks>
                /// <para>This parameter is introduced since OceanBase Database V3.2.4 BP5.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CpuTime")]
                [Validation(Required=false)]
                public long? CpuTime { get; set; }

                /// <summary>
                /// <para>The name of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c1</para>
                /// </summary>
                [NameInMap("Database")]
                [Validation(Required=false)]
                public string Database { get; set; }

                /// <summary>
                /// <para>The definition of this parameter varies based on whether the SQL statement is executed.</para>
                /// <list type="bullet">
                /// <item><description>When the request is accepted and the result is not returned to the client, this parameter indicates the time interval between the time when the request is accepted and the current time, in seconds.</description></item>
                /// <item><description>When the request is not accepted, this parameter indicates the duration for which the current status lasts, in seconds.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("ExecuteTime")]
                [Validation(Required=false)]
                public long? ExecuteTime { get; set; }

                /// <summary>
                /// <para>The ID of the execution plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1898</para>
                /// </summary>
                [NameInMap("PlanId")]
                [Validation(Required=false)]
                public string PlanId { get; set; }

                /// <summary>
                /// <para>The session ID of the client. If an OceanBase Database Proxy (ODP) is used for connection, the session ID of the ODP is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7521015416********</para>
                /// </summary>
                [NameInMap("ProxySessId")]
                [Validation(Required=false)]
                public string ProxySessId { get; set; }

                /// <summary>
                /// <para>The IP address of the server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx.xx.xx.xx</para>
                /// </summary>
                [NameInMap("ServerIp")]
                [Validation(Required=false)]
                public string ServerIp { get; set; }

                /// <summary>
                /// <para>The ID of the session.</para>
                /// 
                /// <b>Example:</b>
                /// <para>322441****</para>
                /// </summary>
                [NameInMap("SessionId")]
                [Validation(Required=false)]
                public long? SessionId { get; set; }

                /// <summary>
                /// <para>The ID of the SQL statement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>45CCBDC7DEBDCDAXXXXAFC********</para>
                /// </summary>
                [NameInMap("SqlId")]
                [Validation(Required=false)]
                public string SqlId { get; set; }

                /// <summary>
                /// <para>The SQL text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>select * from c1 where id = 100;</para>
                /// </summary>
                [NameInMap("SqlText")]
                [Validation(Required=false)]
                public string SqlText { get; set; }

                /// <summary>
                /// <para>The status of the session.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ACTIVE</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The ID of the tenant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_mysql</para>
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                /// <summary>
                /// <para>The ID of the trace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>YB420XXX128-00062XXXX8313XXX1-X-X</para>
                /// </summary>
                [NameInMap("TraceId")]
                [Validation(Required=false)]
                public string TraceId { get; set; }

                /// <summary>
                /// <para>The user to which the session belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_user</para>
                /// </summary>
                [NameInMap("User")]
                [Validation(Required=false)]
                public string User { get; set; }

            }

            /// <summary>
            /// <para>The number of sessions in the SLEEP state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("IdleSessionCount")]
            [Validation(Required=false)]
            public int? IdleSessionCount { get; set; }

            /// <summary>
            /// <para>The version of OceanBase Database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3.2.4</para>
            /// </summary>
            [NameInMap("ObVersion")]
            [Validation(Required=false)]
            public string ObVersion { get; set; }

            /// <summary>
            /// <para>The session data in different dimensions.</para>
            /// </summary>
            [NameInMap("SessionStatistics")]
            [Validation(Required=false)]
            public DescribeProcessStatsCompositionResponseBodyDataSessionStatistics SessionStatistics { get; set; }
            public class DescribeProcessStatsCompositionResponseBodyDataSessionStatistics : TeaModel {
                /// <summary>
                /// <para>The session data in the database dimension.</para>
                /// </summary>
                [NameInMap("DataBaseStatistics")]
                [Validation(Required=false)]
                public List<DescribeProcessStatsCompositionResponseBodyDataSessionStatisticsDataBaseStatistics> DataBaseStatistics { get; set; }
                public class DescribeProcessStatsCompositionResponseBodyDataSessionStatisticsDataBaseStatistics : TeaModel {
                    /// <summary>
                    /// <para>The number of active sessions.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>25</para>
                    /// </summary>
                    [NameInMap("ActiveCount")]
                    [Validation(Required=false)]
                    public long? ActiveCount { get; set; }

                    /// <summary>
                    /// <para>The name of the database.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test_database</para>
                    /// </summary>
                    [NameInMap("MetricValue")]
                    [Validation(Required=false)]
                    public string MetricValue { get; set; }

                    /// <summary>
                    /// <para>The total number of entries returned.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("TotalCount")]
                    [Validation(Required=false)]
                    public long? TotalCount { get; set; }

                    /// <summary>
                    /// <para>The dimension. This value is fixed to database.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>database</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The session data in the client dimension.</para>
                /// </summary>
                [NameInMap("SourceStatistics")]
                [Validation(Required=false)]
                public List<DescribeProcessStatsCompositionResponseBodyDataSessionStatisticsSourceStatistics> SourceStatistics { get; set; }
                public class DescribeProcessStatsCompositionResponseBodyDataSessionStatisticsSourceStatistics : TeaModel {
                    /// <summary>
                    /// <para>The number of active sessions.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>25</para>
                    /// </summary>
                    [NameInMap("ActiveCount")]
                    [Validation(Required=false)]
                    public long? ActiveCount { get; set; }

                    /// <summary>
                    /// <para>The IP address of the client.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xx.xx.xx.xx</para>
                    /// </summary>
                    [NameInMap("MetricValue")]
                    [Validation(Required=false)]
                    public string MetricValue { get; set; }

                    /// <summary>
                    /// <para>The total number of entries returned.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("TotalCount")]
                    [Validation(Required=false)]
                    public long? TotalCount { get; set; }

                    /// <summary>
                    /// <para>The dimension. This value is fixed to client.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>client</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The session data in the user dimension.</para>
                /// </summary>
                [NameInMap("UserStatistics")]
                [Validation(Required=false)]
                public List<DescribeProcessStatsCompositionResponseBodyDataSessionStatisticsUserStatistics> UserStatistics { get; set; }
                public class DescribeProcessStatsCompositionResponseBodyDataSessionStatisticsUserStatistics : TeaModel {
                    /// <summary>
                    /// <para>The number of active sessions.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>25</para>
                    /// </summary>
                    [NameInMap("ActiveCount")]
                    [Validation(Required=false)]
                    public long? ActiveCount { get; set; }

                    /// <summary>
                    /// <para>The username.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test_user</para>
                    /// </summary>
                    [NameInMap("MetricValue")]
                    [Validation(Required=false)]
                    public string MetricValue { get; set; }

                    /// <summary>
                    /// <para>The total number of entries returned.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("TotalCount")]
                    [Validation(Required=false)]
                    public long? TotalCount { get; set; }

                    /// <summary>
                    /// <para>The dimension. This value is fixed to user.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>user</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// <para>The total number of sessions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalSessionCount")]
            [Validation(Required=false)]
            public int? TotalSessionCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-<b><b>-</b></b>-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
