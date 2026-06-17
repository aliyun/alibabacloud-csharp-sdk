// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBLogFilesResponseBody : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-****************</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <para>The instance type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>polardb_mysql_rw</b>: read-write instance.</para>
        /// </description></item>
        /// <item><description><para><b>polardb_mysql_ro</b>: read-only instance.</para>
        /// </description></item>
        /// <item><description><para><b>polardb_mysql_standby</b>: standby instance.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>polardb_mysql_rw</para>
        /// </summary>
        [NameInMap("DBInstanceType")]
        [Validation(Required=false)]
        public string DBInstanceType { get; set; }

        /// <summary>
        /// <para>A list of failover logs.</para>
        /// </summary>
        [NameInMap("HaLogItems")]
        [Validation(Required=false)]
        public List<DescribeDBLogFilesResponseBodyHaLogItems> HaLogItems { get; set; }
        public class DescribeDBLogFilesResponseBodyHaLogItems : TeaModel {
            /// <summary>
            /// <para>The number of affected sessions during the failover.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("AffectedSessions")]
            [Validation(Required=false)]
            public long? AffectedSessions { get; set; }

            /// <summary>
            /// <para>The instance type before the failover. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>polardb_mysql_rw</b>: read-write instance.</para>
            /// </description></item>
            /// <item><description><para><b>polardb_mysql_ro</b>: read-only instance.</para>
            /// </description></item>
            /// <item><description><para><b>polardb_mysql_standby</b>: standby instance.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>polardb_mysql_rw</para>
            /// </summary>
            [NameInMap("FromDBType")]
            [Validation(Required=false)]
            public string FromDBType { get; set; }

            /// <summary>
            /// <para>The error code for the failover cause.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Platform.Ha.AuroraService.ManualOperations</para>
            /// </summary>
            [NameInMap("SwitchCauseCode")]
            [Validation(Required=false)]
            public string SwitchCauseCode { get; set; }

            /// <summary>
            /// <para>Details about the failover cause.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Platform.Ha.ManuallyTriggered</para>
            /// </summary>
            [NameInMap("SwitchCauseDetail")]
            [Validation(Required=false)]
            public string SwitchCauseDetail { get; set; }

            /// <summary>
            /// <para>The time when the failover was complete. The time is in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format and is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-05-20T03:09:56Z</para>
            /// </summary>
            [NameInMap("SwitchFinishTime")]
            [Validation(Required=false)]
            public string SwitchFinishTime { get; set; }

            /// <summary>
            /// <para>The failover log ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e571f897-9b3c-4012-9470-88333832dec4</para>
            /// </summary>
            [NameInMap("SwitchId")]
            [Validation(Required=false)]
            public string SwitchId { get; set; }

            /// <summary>
            /// <para>The time when the failover started. The time is in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format and is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-05-20T03:09:45Z</para>
            /// </summary>
            [NameInMap("SwitchStartTime")]
            [Validation(Required=false)]
            public string SwitchStartTime { get; set; }

            /// <summary>
            /// <para>The failover type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SwitchType")]
            [Validation(Required=false)]
            public long? SwitchType { get; set; }

            /// <summary>
            /// <para>The total number of sessions during the failover.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("TotalSessions")]
            [Validation(Required=false)]
            public long? TotalSessions { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether a failover record exists. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: No</para>
        /// </description></item>
        /// <item><description><para><b>0</b>: Yes</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("HaStatus")]
        [Validation(Required=false)]
        public int? HaStatus { get; set; }

        /// <summary>
        /// <para>The number of log items on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ItemsNumbers")]
        [Validation(Required=false)]
        public int? ItemsNumbers { get; set; }

        /// <summary>
        /// <para>The page number. It must be a positive integer that does not exceed the maximum value of the Integer data type. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: 5 to 50. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24A1990B-4F6E-482B-B8CB-75C612******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>A list of fault simulation records.</para>
        /// </summary>
        [NameInMap("SwitchListItems")]
        [Validation(Required=false)]
        public List<DescribeDBLogFilesResponseBodySwitchListItems> SwitchListItems { get; set; }
        public class DescribeDBLogFilesResponseBodySwitchListItems : TeaModel {
            /// <summary>
            /// <para>The IDs of nodes on which to simulate a fault.</para>
            /// <remarks>
            /// <para>For a node-level fault simulation, specify the ID of a single node. For an availability zone-level fault simulation, you can either omit this parameter or specify the IDs of all nodes in the zone.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("DBNodeCrashList")]
            [Validation(Required=false)]
            public List<string> DBNodeCrashList { get; set; }

            /// <summary>
            /// <para>The time when the fault simulation was complete. The time is in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format and is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-02-10T02:25:00Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The time when the system event was complete. The time is in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format and is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-04-19T02:12:00Z</para>
            /// </summary>
            [NameInMap("EventFinishTime")]
            [Validation(Required=false)]
            public string EventFinishTime { get; set; }

            /// <summary>
            /// <para>The time when the system event started. The time is in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format and is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-04-19T01:12:00Z</para>
            /// </summary>
            [NameInMap("EventStartTime")]
            [Validation(Required=false)]
            public string EventStartTime { get; set; }

            /// <summary>
            /// <para>The fault injection method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CrashSQLInjection: Injects a fault into the instance by using <c>Crash SQL</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CrashSQLInjection</para>
            /// </summary>
            [NameInMap("FaultInjectionType")]
            [Validation(Required=false)]
            public string FaultInjectionType { get; set; }

            /// <summary>
            /// <para>The fault simulation record ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23</para>
            /// </summary>
            [NameInMap("SimulateListId")]
            [Validation(Required=false)]
            public string SimulateListId { get; set; }

            /// <summary>
            /// <para>The fault simulation mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SimulateMode")]
            [Validation(Required=false)]
            public string SimulateMode { get; set; }

            /// <summary>
            /// <para>The fault simulation status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: Pending</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: Success</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: Running</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: Failed</para>
            /// </description></item>
            /// <item><description><para><b>4</b>: Aborted</para>
            /// </description></item>
            /// <item><description><para><b>5</b>: Awaiting rollback</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("SimulateStatus")]
            [Validation(Required=false)]
            public string SimulateStatus { get; set; }

            /// <summary>
            /// <para>The fault simulation task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23</para>
            /// </summary>
            [NameInMap("SimulateTaskId")]
            [Validation(Required=false)]
            public string SimulateTaskId { get; set; }

            /// <summary>
            /// <para>The time when the fault simulation started. The time is in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format and is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-02-25T01:05:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>A list of fault simulation logs.</para>
            /// </summary>
            [NameInMap("SwitchLogItems")]
            [Validation(Required=false)]
            public List<DescribeDBLogFilesResponseBodySwitchListItemsSwitchLogItems> SwitchLogItems { get; set; }
            public class DescribeDBLogFilesResponseBodySwitchListItemsSwitchLogItems : TeaModel {
                /// <summary>
                /// <para>The cluster ID.</para>
                /// <remarks>
                /// <para>You can call the <a href="https://help.aliyun.com/document_detail/98094.html">DescribeDBClusters</a> operation to query the details of your clusters, including the cluster IDs.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>pc-*************</para>
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                /// <summary>
                /// <para>The destination database type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>PolarDBMySQL</b>: A major version upgrade of PolarDB for MySQL.</para>
                /// </description></item>
                /// <item><description><para><b>RDS</b>: A migration from RDS to PolarDB for MySQL.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PolarDBMySQL</para>
                /// </summary>
                [NameInMap("DstDbType")]
                [Validation(Required=false)]
                public string DstDbType { get; set; }

                /// <summary>
                /// <para>The time when the system event was complete. The time is in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format and is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-04-19T02:12:00Z</para>
                /// </summary>
                [NameInMap("EventFinishTime")]
                [Validation(Required=false)]
                public string EventFinishTime { get; set; }

                /// <summary>
                /// <para>The time when the system event started. The time is in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format and is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-04-19T01:12:00Z</para>
                /// </summary>
                [NameInMap("EventStartTime")]
                [Validation(Required=false)]
                public string EventStartTime { get; set; }

                /// <summary>
                /// <para>The simulation list ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>96</para>
                /// </summary>
                [NameInMap("SimulateListId")]
                [Validation(Required=false)]
                public string SimulateListId { get; set; }

                /// <summary>
                /// <para>The simulation log ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>23</para>
                /// </summary>
                [NameInMap("SimulateLogId")]
                [Validation(Required=false)]
                public string SimulateLogId { get; set; }

                /// <summary>
                /// <para>The fault simulation status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>0</b>: Pending</para>
                /// </description></item>
                /// <item><description><para><b>1</b>: Success</para>
                /// </description></item>
                /// <item><description><para><b>2</b>: Running</para>
                /// </description></item>
                /// <item><description><para><b>3</b>: Failed</para>
                /// </description></item>
                /// <item><description><para><b>4</b>: Aborted</para>
                /// </description></item>
                /// <item><description><para><b>5</b>: Awaiting rollback</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SimulateStatus")]
                [Validation(Required=false)]
                public string SimulateStatus { get; set; }

                /// <summary>
                /// <para>The source database type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>PolarDBMySQL</b>: A major version upgrade of PolarDB for MySQL.</para>
                /// </description></item>
                /// <item><description><para><b>RDS</b>: A migration from RDS to PolarDB for MySQL.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PolarDBMySQL</para>
                /// </summary>
                [NameInMap("SrcDbType")]
                [Validation(Required=false)]
                public string SrcDbType { get; set; }

                /// <summary>
                /// <para>A list of fault simulation steps.</para>
                /// </summary>
                [NameInMap("SwitchStepItems")]
                [Validation(Required=false)]
                public List<DescribeDBLogFilesResponseBodySwitchListItemsSwitchLogItemsSwitchStepItems> SwitchStepItems { get; set; }
                public class DescribeDBLogFilesResponseBodySwitchListItemsSwitchLogItemsSwitchStepItems : TeaModel {
                    /// <summary>
                    /// <para>The time when the step was complete. The time is in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format and is displayed in UTC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2025-08-14T02:07:00Z</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the step was successful. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>true</c>: The step was successful.</para>
                    /// </description></item>
                    /// <item><description><para><c>false</c>: The step failed.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("IsSuccess")]
                    [Validation(Required=false)]
                    public string IsSuccess { get; set; }

                    /// <summary>
                    /// <para>The fault simulation phase. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>PolarDB.MySQL.FaultSimulate.Phase.FAULT_INJECTION</b>: The fault injection phase.</para>
                    /// </description></item>
                    /// <item><description><para><b>PolarDB.MySQL.FaultSimulate.Phase.RECOVERY</b>: The recovery phase.</para>
                    /// </description></item>
                    /// <item><description><para><b>PolarDB.MySQL.FaultSimulate.Phase.POST_PROCESS</b>: The post-processing phase.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PolarDB.MySQL.FaultSimulate.Phase.FAULT_INJECTION</para>
                    /// </summary>
                    [NameInMap("SimulatePhase")]
                    [Validation(Required=false)]
                    public string SimulatePhase { get; set; }

                    /// <summary>
                    /// <para>The time when the step started. The time is in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format and is displayed in UTC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2025-04-19T02:12:00Z</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    /// <summary>
                    /// <para>The name of the current step. You can call the <a href="https://help.aliyun.com/document_detail/2400077.html">DescribeHistoryTasks</a> operation to query the current step of a specified task. A common value is <b>do_pause</b>, which indicates that the system waits for a specified period of time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>init_task_info</para>
                    /// </summary>
                    [NameInMap("StepName")]
                    [Validation(Required=false)]
                    public string StepName { get; set; }

                    /// <summary>
                    /// <para>The duration of the step in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("TimeCost")]
                    [Validation(Required=false)]
                    public string TimeCost { get; set; }

                }

            }

            /// <summary>
            /// <para>A list of failover steps.</para>
            /// </summary>
            [NameInMap("SwitchStepItems")]
            [Validation(Required=false)]
            public List<DescribeDBLogFilesResponseBodySwitchListItemsSwitchStepItems> SwitchStepItems { get; set; }
            public class DescribeDBLogFilesResponseBodySwitchListItemsSwitchStepItems : TeaModel {
                /// <summary>
                /// <para>The cluster node ID.</para>
                /// <remarks>
                /// <para>This parameter is returned only when the <c>Key</c> parameter in the request is not set to <c>PolarDBDiskUsage</c>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>pi-*************</para>
                /// </summary>
                [NameInMap("DBNodeId")]
                [Validation(Required=false)]
                public string DBNodeId { get; set; }

                /// <summary>
                /// <para>The time when the step was complete. The time is in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format and is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-07-23T02:30:00Z</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>Indicates whether the step was successful. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: The step was successful.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: The step failed.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsSuccess")]
                [Validation(Required=false)]
                public string IsSuccess { get; set; }

                /// <summary>
                /// <para>The fault simulation phase. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>PolarDB.MySQL.FaultSimulate.Phase.FAULT_INJECTION</b>: The fault injection phase.</para>
                /// </description></item>
                /// <item><description><para><b>PolarDB.MySQL.FaultSimulate.Phase.RECOVERY</b>: The recovery phase.</para>
                /// </description></item>
                /// <item><description><para><b>PolarDB.MySQL.FaultSimulate.Phase.POST_PROCESS</b>: The post-processing phase.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PolarDB.MySQL.FaultSimulate.Phase.FAULT_INJECTION</para>
                /// </summary>
                [NameInMap("SimulatePhase")]
                [Validation(Required=false)]
                public string SimulatePhase { get; set; }

                /// <summary>
                /// <para>The time when the step started. The time is in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format and is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-07-16T02:12:00Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The name of the current step. You can call the <a href="https://help.aliyun.com/document_detail/2400077.html">DescribeHistoryTasks</a> operation to query the current step of a specified task. A common value is <b>do_pause</b>, which indicates that the system waits for a specified period of time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>init_task_info</para>
                /// </summary>
                [NameInMap("StepName")]
                [Validation(Required=false)]
                public string StepName { get; set; }

                /// <summary>
                /// <para>The duration of the step in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("TimeCost")]
                [Validation(Required=false)]
                public string TimeCost { get; set; }

            }

        }

        /// <summary>
        /// <para>A list of fault simulation logs.</para>
        /// </summary>
        [NameInMap("SwitchLogItems")]
        [Validation(Required=false)]
        public List<DescribeDBLogFilesResponseBodySwitchLogItems> SwitchLogItems { get; set; }
        public class DescribeDBLogFilesResponseBodySwitchLogItems : TeaModel {
            /// <summary>
            /// <para>The cluster ID.</para>
            /// <remarks>
            /// <para>You can call the <a href="https://help.aliyun.com/document_detail/98094.html">DescribeDBClusters</a> operation to query the details of your clusters, including the cluster IDs.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>pc-*************</para>
            /// </summary>
            [NameInMap("DBInstanceId")]
            [Validation(Required=false)]
            public string DBInstanceId { get; set; }

            /// <summary>
            /// <para>The destination database type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>PolarDBMySQL</b>: A major version upgrade of PolarDB for MySQL.</para>
            /// </description></item>
            /// <item><description><para><b>RDS</b>: A migration from RDS to PolarDB for MySQL.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PolarDBMySQL</para>
            /// </summary>
            [NameInMap("DstDbType")]
            [Validation(Required=false)]
            public string DstDbType { get; set; }

            /// <summary>
            /// <para>The time when the system event was complete. The time is in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format and is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-04-19T02:12:00Z</para>
            /// </summary>
            [NameInMap("EventFinishTime")]
            [Validation(Required=false)]
            public string EventFinishTime { get; set; }

            /// <summary>
            /// <para>The time when the system event started. The time is in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format and is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-04-19T01:12:00Z</para>
            /// </summary>
            [NameInMap("EventStartTime")]
            [Validation(Required=false)]
            public string EventStartTime { get; set; }

            /// <summary>
            /// <para>The simulation list ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>231</para>
            /// </summary>
            [NameInMap("SimulateListId")]
            [Validation(Required=false)]
            public string SimulateListId { get; set; }

            /// <summary>
            /// <para>The fault simulation status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: Pending</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: Success</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: Running</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: Failed</para>
            /// </description></item>
            /// <item><description><para><b>4</b>: Aborted</para>
            /// </description></item>
            /// <item><description><para><b>5</b>: Awaiting rollback</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SimulateStatus")]
            [Validation(Required=false)]
            public string SimulateStatus { get; set; }

            /// <summary>
            /// <para>The status code of the fault simulation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Simulatecode")]
            [Validation(Required=false)]
            public string Simulatecode { get; set; }

            /// <summary>
            /// <para>The source database type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>PolarDBMySQL</b>: A major version upgrade of PolarDB for MySQL.</para>
            /// </description></item>
            /// <item><description><para><b>RDS</b>: A migration from RDS to PolarDB for MySQL.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PolarDBMySQL</para>
            /// </summary>
            [NameInMap("SrcDbType")]
            [Validation(Required=false)]
            public string SrcDbType { get; set; }

            /// <summary>
            /// <para>A list of failover steps.</para>
            /// </summary>
            [NameInMap("SwitchStepItems")]
            [Validation(Required=false)]
            public List<DescribeDBLogFilesResponseBodySwitchLogItemsSwitchStepItems> SwitchStepItems { get; set; }
            public class DescribeDBLogFilesResponseBodySwitchLogItemsSwitchStepItems : TeaModel {
                /// <summary>
                /// <para>The node ID.</para>
                /// <remarks>
                /// <para>You must specify either the <c>DBNodeId</c> or <c>DBClusterId</c> parameter. You can call the <a href="https://help.aliyun.com/document_detail/98094.html">DescribeDBClusters</a> operation to query the details of your clusters, including the node IDs.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>pi-*************</para>
                /// </summary>
                [NameInMap("DBNodeId")]
                [Validation(Required=false)]
                public string DBNodeId { get; set; }

                /// <summary>
                /// <para>The time when the step was complete. The time is in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format and is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-03-27T02:27:00Z</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>Indicates whether the step was successful. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: The step was successful.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: The step failed.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsSuccess")]
                [Validation(Required=false)]
                public string IsSuccess { get; set; }

                /// <summary>
                /// <para>The fault simulation phase. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>PolarDB.MySQL.FaultSimulate.Phase.FAULT_INJECTION</b>: The fault injection phase.</para>
                /// </description></item>
                /// <item><description><para><b>PolarDB.MySQL.FaultSimulate.Phase.RECOVERY</b>: The recovery phase.</para>
                /// </description></item>
                /// <item><description><para><b>PolarDB.MySQL.FaultSimulate.Phase.POST_PROCESS</b>: The post-processing phase.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PolarDB.MySQL.FaultSimulate.Phase.FAULT_INJECTION</para>
                /// </summary>
                [NameInMap("SimulatePhase")]
                [Validation(Required=false)]
                public string SimulatePhase { get; set; }

                /// <summary>
                /// <para>The time when the step started. The time is in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format and is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-10-21T02:12:00Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>A message about the execution status of the step.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This step exec success</para>
                /// </summary>
                [NameInMap("StepMsg")]
                [Validation(Required=false)]
                public string StepMsg { get; set; }

                /// <summary>
                /// <para>The name of the step.</para>
                /// 
                /// <b>Example:</b>
                /// <para>init_task_info</para>
                /// </summary>
                [NameInMap("StepName")]
                [Validation(Required=false)]
                public string StepName { get; set; }

                /// <summary>
                /// <para>The duration of the step in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("TimeCost")]
                [Validation(Required=false)]
                public string TimeCost { get; set; }

            }

        }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecords")]
        [Validation(Required=false)]
        public int? TotalRecords { get; set; }

    }

}
