// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribePreCheckStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of assessment tasks.</para>
        /// </summary>
        [NameInMap("AnalysisJobProgress")]
        [Validation(Required=false)]
        public List<DescribePreCheckStatusResponseBodyAnalysisJobProgress> AnalysisJobProgress { get; set; }
        public class DescribePreCheckStatusResponseBodyAnalysisJobProgress : TeaModel {
            /// <summary>
            /// <para>The time when the specific item was started. The time is displayed in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-03-16T08:01:31.000+00:00</para>
            /// </summary>
            [NameInMap("BootTime")]
            [Validation(Required=false)]
            public string BootTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the sub-item can be skipped.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CanSkip")]
            [Validation(Required=false)]
            public bool? CanSkip { get; set; }

            /// <summary>
            /// <para>The number of subtasks that are currently running.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Current")]
            [Validation(Required=false)]
            public string Current { get; set; }

            /// <summary>
            /// <para>The DDL operation that was executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CREATE TABLE ****</para>
            /// </summary>
            [NameInMap("DdlSql")]
            [Validation(Required=false)]
            public string DdlSql { get; set; }

            /// <summary>
            /// <para>The task latency.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DelaySeconds")]
            [Validation(Required=false)]
            public int? DelaySeconds { get; set; }

            /// <summary>
            /// <para>The name of the database to which the migration object belongs in the destination instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dest</para>
            /// </summary>
            [NameInMap("DestSchema")]
            [Validation(Required=false)]
            public string DestSchema { get; set; }

            /// <summary>
            /// <para>This parameter will be deprecated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DiffRow")]
            [Validation(Required=false)]
            public long? DiffRow { get; set; }

            /// <summary>
            /// <para>The error details when the item encounters an error.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ANALYSIS_MYSQL</para>
            /// </summary>
            [NameInMap("ErrDetail")]
            [Validation(Required=false)]
            public string ErrDetail { get; set; }

            /// <summary>
            /// <para>The specific error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ANALYSIS_</para>
            /// </summary>
            [NameInMap("ErrMsg")]
            [Validation(Required=false)]
            public string ErrMsg { get; set; }

            /// <summary>
            /// <para>The time when the assessment task was completed. The time is displayed in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-03-16T08:01:31.000+00:00</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            /// <summary>
            /// <para>The ID of the assessment item in the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123123</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Indicates whether the specific item is directly ignored and the next item is processed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>N</b>: No.</description></item>
            /// <item><description><b>Y</b>: Yes.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>N</para>
            /// </summary>
            [NameInMap("IgnoreFlag")]
            [Validation(Required=false)]
            public string IgnoreFlag { get; set; }

            /// <summary>
            /// <para>The name of the assessment item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ANALYSIS_MYSQL_4_ITEM</para>
            /// </summary>
            [NameInMap("Item")]
            [Validation(Required=false)]
            public string Item { get; set; }

            /// <summary>
            /// <para>The ID of the assessment task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11234234xc</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The sub-assessment items.</para>
            /// </summary>
            [NameInMap("Logs")]
            [Validation(Required=false)]
            public List<DescribePreCheckStatusResponseBodyAnalysisJobProgressLogs> Logs { get; set; }
            public class DescribePreCheckStatusResponseBodyAnalysisJobProgressLogs : TeaModel {
                /// <summary>
                /// <para>The error information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>请修改该对象</para>
                /// </summary>
                [NameInMap("ErrData")]
                [Validation(Required=false)]
                public string ErrData { get; set; }

                /// <summary>
                /// <para>The error message returned by DTS when the specific item encounters an error.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DTS-1020042 Execute sql error sql: Table \&quot;customer\&quot; already exists</para>
                /// </summary>
                [NameInMap("ErrMsg")]
                [Validation(Required=false)]
                public string ErrMsg { get; set; }

                /// <summary>
                /// <para>The error type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ForeignKey</para>
                /// </summary>
                [NameInMap("ErrType")]
                [Validation(Required=false)]
                public string ErrType { get; set; }

                /// <summary>
                /// <para>The log level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ERROR</para>
                /// </summary>
                [NameInMap("LogLevel")]
                [Validation(Required=false)]
                public string LogLevel { get; set; }

            }

            /// <summary>
            /// <para>The name of the assessment item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ANALYSIS_MYSQL_4_DETAIL</para>
            /// </summary>
            [NameInMap("Names")]
            [Validation(Required=false)]
            public string Names { get; set; }

            /// <summary>
            /// <para>The number of the assessment item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("OrderNum")]
            [Validation(Required=false)]
            public int? OrderNum { get; set; }

            /// <summary>
            /// <para>This parameter will be deprecated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo</para>
            /// </summary>
            [NameInMap("ParentObj")]
            [Validation(Required=false)]
            public string ParentObj { get; set; }

            /// <summary>
            /// <para>The repair method for the assessment item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ANALYSIS_</para>
            /// </summary>
            [NameInMap("RepairMethod")]
            [Validation(Required=false)]
            public string RepairMethod { get; set; }

            /// <summary>
            /// <para>Indicates whether you have set to skip this assessment item after it failed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Skip")]
            [Validation(Required=false)]
            public bool? Skip { get; set; }

            /// <summary>
            /// <para>The name of the database to which the migration object belongs in the source instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dtstestdata</para>
            /// </summary>
            [NameInMap("SourceSchema")]
            [Validation(Required=false)]
            public string SourceSchema { get; set; }

            /// <summary>
            /// <para>The result of the assessment item. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Failed</b>: failed.</description></item>
            /// <item><description><b>Success</b>: completed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The progress of sub-items of the specific item.</para>
            /// <remarks>
            /// <para>If <b>[]</b> is returned, no sub-items exist.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("Sub")]
            [Validation(Required=false)]
            public string Sub { get; set; }

            /// <summary>
            /// <para>The name of the target object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testTable</para>
            /// </summary>
            [NameInMap("TargetNames")]
            [Validation(Required=false)]
            public string TargetNames { get; set; }

            /// <summary>
            /// <para>The total number of specific items in the subtask.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>The task code that represents the queried subtask. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>01</b>: precheck.</description></item>
        /// <item><description><b>02</b>: schema migration or initial schema synchronization.</description></item>
        /// <item><description><b>03</b>: full data migration or initial full data synchronization.</description></item>
        /// <item><description><b>04</b>: incremental data migration or incremental data synchronization.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>01</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The number of items that failed the assessment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ErrorAnalysisItem")]
        [Validation(Required=false)]
        public int? ErrorAnalysisItem { get; set; }

        /// <summary>
        /// <para>The number of specific items that caused the subtask to fail.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ErrorItem")]
        [Validation(Required=false)]
        public int? ErrorItem { get; set; }

        /// <summary>
        /// <para>The full CIDR block check results.</para>
        /// </summary>
        [NameInMap("FullNetCheckJobStatus")]
        [Validation(Required=false)]
        public List<DescribePreCheckStatusResponseBodyFullNetCheckJobStatus> FullNetCheckJobStatus { get; set; }
        public class DescribePreCheckStatusResponseBodyFullNetCheckJobStatus : TeaModel {
            /// <summary>
            /// <para>The task code. <b>01</b> indicates precheck.</para>
            /// 
            /// <b>Example:</b>
            /// <para>01</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The region ID of the destination CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("DestRegion")]
            [Validation(Required=false)]
            public string DestRegion { get; set; }

            /// <summary>
            /// <para>The destination CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100.104.XX.XXX/XX</para>
            /// </summary>
            [NameInMap("DestRegionCidr")]
            [Validation(Required=false)]
            public string DestRegionCidr { get; set; }

            /// <summary>
            /// <para>The connection method of the destination instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ALIYUN</b>: <b>cloud instance</b>.</description></item>
            /// <item><description><b>OTHER</b>: <b>public IP address</b>.</description></item>
            /// <item><description><b>ECS</b>: <b>self-managed database on ECS</b>.</description></item>
            /// <item><description><b>EXPRESS</b>: <b>Express Connect/VPN Gateway/Smart Access Gateway</b>.</description></item>
            /// <item><description><b>CEN</b>: <b>Cloud Enterprise Network (CEN)</b>.</description></item>
            /// <item><description><b>DG</b>: <b>Database Gateway (DG)</b>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CEN</para>
            /// </summary>
            [NameInMap("DestinationEndpointType")]
            [Validation(Required=false)]
            public string DestinationEndpointType { get; set; }

            /// <summary>
            /// <para>The number of items that failed the precheck.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ErrorItem")]
            [Validation(Required=false)]
            public int? ErrorItem { get; set; }

            /// <summary>
            /// <para>The region ID of the node where the instance runs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("HostRegion")]
            [Validation(Required=false)]
            public string HostRegion { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>l3m1213ye7l****</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The task name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dts.step.fullnetcheck</para>
            /// </summary>
            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            /// <summary>
            /// <para>The list of specific items of the task and their execution progress.</para>
            /// </summary>
            [NameInMap("JobProgress")]
            [Validation(Required=false)]
            public List<DescribePreCheckStatusResponseBodyFullNetCheckJobStatusJobProgress> JobProgress { get; set; }
            public class DescribePreCheckStatusResponseBodyFullNetCheckJobStatusJobProgress : TeaModel {
                /// <summary>
                /// <para>The time when the specific item was started. The time is displayed in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-03-30T03:36:11.000+00:00</para>
                /// </summary>
                [NameInMap("BootTime")]
                [Validation(Required=false)]
                public string BootTime { get; set; }

                /// <summary>
                /// <para>Indicates whether DTS supports skipping the item after it fails. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: Yes.</description></item>
                /// <item><description><b>false</b>: No.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("CanSkip")]
                [Validation(Required=false)]
                public bool? CanSkip { get; set; }

                /// <summary>
                /// <para>The number of tasks that are currently running.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Current")]
                [Validation(Required=false)]
                public string Current { get; set; }

                /// <summary>
                /// <para>The DDL operation that was executed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CREATE TABLE ****</para>
                /// </summary>
                [NameInMap("DdlSql")]
                [Validation(Required=false)]
                public string DdlSql { get; set; }

                /// <summary>
                /// <para>The task latency.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DelaySeconds")]
                [Validation(Required=false)]
                public int? DelaySeconds { get; set; }

                /// <summary>
                /// <para>The name of the database to which the migration object belongs in the destination instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dest</para>
                /// </summary>
                [NameInMap("DestSchema")]
                [Validation(Required=false)]
                public string DestSchema { get; set; }

                /// <summary>
                /// <para>This parameter will be deprecated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DiffRow")]
                [Validation(Required=false)]
                public long? DiffRow { get; set; }

                /// <summary>
                /// <para>The error details when the specific item encounters an error.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CHECK__ERROR_SAME_OBJ_DETAIL</para>
                /// </summary>
                [NameInMap("ErrDetail")]
                [Validation(Required=false)]
                public string ErrDetail { get; set; }

                /// <summary>
                /// <para>The error message when the specific item encounters an error.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ODPS project does not exist odps.`huijin</para>
                /// </summary>
                [NameInMap("ErrMsg")]
                [Validation(Required=false)]
                public string ErrMsg { get; set; }

                /// <summary>
                /// <para>The time when the task was completed. The time is displayed in the yyyy-MM-ddTHH:mm:ssZ format in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-03-31T03:36:11.000+00:00</para>
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                /// <summary>
                /// <para>The ID of the record in the metastore.</para>
                /// 
                /// <b>Example:</b>
                /// <para>922305811766881****</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>Indicates whether the specific item is directly ignored and the next item is processed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>N</b>: No.</description></item>
                /// <item><description><b>Y</b>: Yes.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>N</para>
                /// </summary>
                [NameInMap("IgnoreFlag")]
                [Validation(Required=false)]
                public string IgnoreFlag { get; set; }

                /// <summary>
                /// <para>The name of the specific item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CHECK_CONN_SRC</para>
                /// </summary>
                [NameInMap("Item")]
                [Validation(Required=false)]
                public string Item { get; set; }

                /// <summary>
                /// <para>The task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>l3m1213ye7l****</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <para>The execution logs of the error.</para>
                /// </summary>
                [NameInMap("Logs")]
                [Validation(Required=false)]
                public List<DescribePreCheckStatusResponseBodyFullNetCheckJobStatusJobProgressLogs> Logs { get; set; }
                public class DescribePreCheckStatusResponseBodyFullNetCheckJobStatusJobProgressLogs : TeaModel {
                    /// <summary>
                    /// <para>The error record.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CREATE TABLE <c>dtstestdata</c>.<c>customer</c> ****</para>
                    /// </summary>
                    [NameInMap("ErrData")]
                    [Validation(Required=false)]
                    public string ErrData { get; set; }

                    /// <summary>
                    /// <para>The specific error message.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>get metric list fail</para>
                    /// </summary>
                    [NameInMap("ErrMsg")]
                    [Validation(Required=false)]
                    public string ErrMsg { get; set; }

                    /// <summary>
                    /// <para>The error type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ForeignKey</para>
                    /// </summary>
                    [NameInMap("ErrType")]
                    [Validation(Required=false)]
                    public string ErrType { get; set; }

                    /// <summary>
                    /// <para>The log level.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>INFO</para>
                    /// </summary>
                    [NameInMap("LogLevel")]
                    [Validation(Required=false)]
                    public string LogLevel { get; set; }

                }

                /// <summary>
                /// <para>The name of the specific item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CHECK_CONN_SRC_DETAIL</para>
                /// </summary>
                [NameInMap("Names")]
                [Validation(Required=false)]
                public string Names { get; set; }

                /// <summary>
                /// <para>The item number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("OrderNum")]
                [Validation(Required=false)]
                public int? OrderNum { get; set; }

                /// <summary>
                /// <para>This parameter will be deprecated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo</para>
                /// </summary>
                [NameInMap("ParentObj")]
                [Validation(Required=false)]
                public string ParentObj { get; set; }

                /// <summary>
                /// <para>The repair method when the precheck does not pass.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CHECK__ERROR_SAME_OBJ_REPAIR</para>
                /// </summary>
                [NameInMap("RepairMethod")]
                [Validation(Required=false)]
                public string RepairMethod { get; set; }

                /// <summary>
                /// <para>Indicates whether you have set to skip this specific item after it failed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: Yes.</description></item>
                /// <item><description><b>false</b>: No.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Skip")]
                [Validation(Required=false)]
                public bool? Skip { get; set; }

                /// <summary>
                /// <para>The name of the database to which the migration object belongs in the source instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dtstestdata</para>
                /// </summary>
                [NameInMap("SourceSchema")]
                [Validation(Required=false)]
                public string SourceSchema { get; set; }

                /// <summary>
                /// <para>The check result. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Failed</b>: failed.</description></item>
                /// <item><description><b>Success</b>: completed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <para>The progress of sub-items of the specific item.</para>
                /// <remarks>
                /// <para>If <b>[]</b> is returned, no sub-items exist.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>[]</para>
                /// </summary>
                [NameInMap("Sub")]
                [Validation(Required=false)]
                public string Sub { get; set; }

                /// <summary>
                /// <para>The name of the target object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>order</para>
                /// </summary>
                [NameInMap("TargetNames")]
                [Validation(Required=false)]
                public string TargetNames { get; set; }

                /// <summary>
                /// <para>The total number of items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("Total")]
                [Validation(Required=false)]
                public int? Total { get; set; }

            }

            /// <summary>
            /// <para>The connection method of the source instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ALIYUN</b>: <b>cloud instance</b>.</description></item>
            /// <item><description><b>OTHER</b>: <b>public IP address</b>.</description></item>
            /// <item><description><b>ECS</b>: <b>self-managed database on ECS</b>.</description></item>
            /// <item><description><b>EXPRESS</b>: <b>Express Connect/VPN Gateway/Smart Access Gateway</b>.</description></item>
            /// <item><description><b>CEN</b>: <b>Cloud Enterprise Network (CEN)</b>.</description></item>
            /// <item><description><b>DG</b>: <b>Database Gateway (DG)</b>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CEN</para>
            /// </summary>
            [NameInMap("SourceEndpointType")]
            [Validation(Required=false)]
            public string SourceEndpointType { get; set; }

            /// <summary>
            /// <para>The region ID of the source CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("SrcRegion")]
            [Validation(Required=false)]
            public string SrcRegion { get; set; }

            /// <summary>
            /// <para>The source CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100.104.XX.XXX/XX</para>
            /// </summary>
            [NameInMap("SrcRegionCidr")]
            [Validation(Required=false)]
            public string SrcRegionCidr { get; set; }

            /// <summary>
            /// <para>The check result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Failed</b>: failed.</description></item>
            /// <item><description><b>Success</b>: completed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The total number of items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The ID of the data migration or data synchronization task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b4my3zg929a****</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The name of the queried subtask.</para>
        /// 
        /// <b>Example:</b>
        /// <para>预检查</para>
        /// </summary>
        [NameInMap("JobName")]
        [Validation(Required=false)]
        public string JobName { get; set; }

        /// <summary>
        /// <para>The list of specific items of the subtask and their execution progress.</para>
        /// </summary>
        [NameInMap("JobProgress")]
        [Validation(Required=false)]
        public List<DescribePreCheckStatusResponseBodyJobProgress> JobProgress { get; set; }
        public class DescribePreCheckStatusResponseBodyJobProgress : TeaModel {
            /// <summary>
            /// <para>The time when the specific item was started. The time is displayed in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-03-16T08:01:31.000+00:00</para>
            /// </summary>
            [NameInMap("BootTime")]
            [Validation(Required=false)]
            public string BootTime { get; set; }

            /// <summary>
            /// <para>Indicates whether DTS supports skipping the specific item after it fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CanSkip")]
            [Validation(Required=false)]
            public bool? CanSkip { get; set; }

            /// <summary>
            /// <para>The number of subtasks that are currently running.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Current")]
            [Validation(Required=false)]
            public string Current { get; set; }

            /// <summary>
            /// <para>The DDL operation that was executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CREATE TABLE <c>dtstestdata</c>.<c>order</c> (\n<c>orderid</c>  int(11)     COMMENT \&quot;\&quot;   NOT NULL   , \n<c>username</c>  char(32)  CHARSET <c>utf8</c> COLLATE <c>utf8_general_ci</c>    COMMENT \&quot;\&quot;   NULL   , \n<c>ordertime</c>  datetime     COMMENT \&quot;\&quot;   NULL   , \n<c>commodity</c>  varchar(32)  CHARSET <c>utf8</c> COLLATE <c>utf8_general_ci</c>    COMMENT \&quot;\&quot;   NULL   , \n<c>phonenumber</c>  int(11)     COMMENT \&quot;\&quot;   NULL   , \n<c>address</c>  text  CHARSET <c>utf8mb4</c> COLLATE <c>utf8mb4_general_ci</c>    COMMENT \&quot;\&quot;   NULL   \n, PRIMARY KEY (<c>orderid</c>)) engine=InnoDB DEFAULT CHARSET=<c>gbk</c> DEFAULT COLLATE <c>gbk_chinese_ci</c> ROW_FORMAT= Dynamic comment = \&quot;\&quot; ;\n</para>
            /// </summary>
            [NameInMap("DdlSql")]
            [Validation(Required=false)]
            public string DdlSql { get; set; }

            /// <summary>
            /// <para>The synchronization latency of incremental data migration or incremental data synchronization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DelaySeconds")]
            [Validation(Required=false)]
            public int? DelaySeconds { get; set; }

            /// <summary>
            /// <para>The name of the database to which the migration object belongs in the destination instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dtstestdata_new</para>
            /// </summary>
            [NameInMap("DestSchema")]
            [Validation(Required=false)]
            public string DestSchema { get; set; }

            /// <summary>
            /// <para>This parameter will be deprecated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DiffRow")]
            [Validation(Required=false)]
            public long? DiffRow { get; set; }

            /// <summary>
            /// <para>The error details when the specific item encounters an error.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CHECK__ERROR_SAME_OBJ_DETAIL</para>
            /// </summary>
            [NameInMap("ErrDetail")]
            [Validation(Required=false)]
            public string ErrDetail { get; set; }

            /// <summary>
            /// <para>The error message when the specific item encounters an error.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CHECK__ERROR_SAME_OBJ</para>
            /// </summary>
            [NameInMap("ErrMsg")]
            [Validation(Required=false)]
            public string ErrMsg { get; set; }

            /// <summary>
            /// <para>The time when the specific item was completed. The time is displayed in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>ZZ format in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-03-16T08:01:34.000+00:00</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            /// <summary>
            /// <para>The ID of the record in the metastore.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5632</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Indicates whether the specific item is directly ignored and the next item is processed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>N</b>: No.</description></item>
            /// <item><description><b>Y</b>: Yes.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>N</para>
            /// </summary>
            [NameInMap("IgnoreFlag")]
            [Validation(Required=false)]
            public string IgnoreFlag { get; set; }

            /// <summary>
            /// <para>The short name of the specific item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CHECK_CONN_DEST</para>
            /// </summary>
            [NameInMap("Item")]
            [Validation(Required=false)]
            public string Item { get; set; }

            /// <summary>
            /// <para>The subtask ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fj1c33ro168****</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The execution logs of the specific error.</para>
            /// </summary>
            [NameInMap("Logs")]
            [Validation(Required=false)]
            public List<DescribePreCheckStatusResponseBodyJobProgressLogs> Logs { get; set; }
            public class DescribePreCheckStatusResponseBodyJobProgressLogs : TeaModel {
                /// <summary>
                /// <para>The error information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CREATE TABLE <c>dtstestdata</c>.<c>customer</c> (\n<c>runoob_id</c>  int(10) unsigned   auto_increment  COMMENT \&quot;\&quot;   NOT NULL   , \n<c>runoob_title</c>  varchar(100)  CHARSET <c>utf8</c> COLLATE <c>utf8_general_ci</c>    COMMENT \&quot;\&quot;   NOT NULL   , \n<c>runoob_author1216</c>  varchar(40)  CHARSET <c>utf8</c> COLLATE <c>utf8_general_ci</c>    COMMENT \&quot;\&quot;   NOT NULL   , \n<c>submission_date1216</c>  date     COMMENT \&quot;\&quot;   NULL   \n, PRIMARY KEY (<c>runoob_id</c>)) engine=InnoDB AUTO_INCREMENT=200001 DEFAULT CHARSET=<c>utf8</c> DEFAULT COLLATE <c>utf8_general_ci</c> ROW_FORMAT= Dynamic comment = \&quot;\&quot; ;\n</para>
                /// </summary>
                [NameInMap("ErrData")]
                [Validation(Required=false)]
                public string ErrData { get; set; }

                /// <summary>
                /// <para>The error message returned by DTS when the specific item encounters an error.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DTS-1020042 Execute sql error sql: Table \&quot;customer\&quot; already exists</para>
                /// </summary>
                [NameInMap("ErrMsg")]
                [Validation(Required=false)]
                public string ErrMsg { get; set; }

                /// <summary>
                /// <para>The error type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ForeignKey</para>
                /// </summary>
                [NameInMap("ErrType")]
                [Validation(Required=false)]
                public string ErrType { get; set; }

                /// <summary>
                /// <para>The log level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ERROR</para>
                /// </summary>
                [NameInMap("LogLevel")]
                [Validation(Required=false)]
                public string LogLevel { get; set; }

            }

            /// <summary>
            /// <para>The name of the specific item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CHECK_CONN_DEST_DETAIL</para>
            /// </summary>
            [NameInMap("Names")]
            [Validation(Required=false)]
            public string Names { get; set; }

            /// <summary>
            /// <para>The item number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("OrderNum")]
            [Validation(Required=false)]
            public int? OrderNum { get; set; }

            /// <summary>
            /// <para>This parameter will be deprecated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo</para>
            /// </summary>
            [NameInMap("ParentObj")]
            [Validation(Required=false)]
            public string ParentObj { get; set; }

            /// <summary>
            /// <para>The repair method when the specific item does not pass.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CHECK__ERROR_SAME_OBJ_REPAIR</para>
            /// </summary>
            [NameInMap("RepairMethod")]
            [Validation(Required=false)]
            public string RepairMethod { get; set; }

            /// <summary>
            /// <para>Indicates whether you have set to skip this specific item after it failed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Skip")]
            [Validation(Required=false)]
            public bool? Skip { get; set; }

            /// <summary>
            /// <para>The name of the database to which the migration object belongs in the source instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dtstestdata</para>
            /// </summary>
            [NameInMap("SourceSchema")]
            [Validation(Required=false)]
            public string SourceSchema { get; set; }

            /// <summary>
            /// <para>The execution progress status of the specific item. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NotStarted</b>: not started.</description></item>
            /// <item><description><b>Checking</b>: being checked.</description></item>
            /// <item><description><b>Migrating</b>: being migrated.</description></item>
            /// <item><description><b>Failed</b>: failed.</description></item>
            /// <item><description><b>Warning</b>: warning.</description></item>
            /// <item><description><b>Success</b>: completed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The progress of sub-items of the specific item.</para>
            /// <remarks>
            /// <para>If <b>[]</b> is returned, no sub-items exist.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("Sub")]
            [Validation(Required=false)]
            public string Sub { get; set; }

            /// <summary>
            /// <para>The name of the object to be migrated or synchronized.</para>
            /// 
            /// <b>Example:</b>
            /// <para>order</para>
            /// </summary>
            [NameInMap("TargetNames")]
            [Validation(Required=false)]
            public string TargetNames { get; set; }

            /// <summary>
            /// <para>The total number of specific items in the subtask.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>The network diagnosis result.</para>
        /// </summary>
        [NameInMap("NetworkDiagnosisResult")]
        [Validation(Required=false)]
        public DescribePreCheckStatusResponseBodyNetworkDiagnosisResult NetworkDiagnosisResult { get; set; }
        public class DescribePreCheckStatusResponseBodyNetworkDiagnosisResult : TeaModel {
            /// <summary>
            /// <para>The network diagnostic report.</para>
            /// </summary>
            [NameInMap("Diagnosis")]
            [Validation(Required=false)]
            public List<DescribePreCheckStatusResponseBodyNetworkDiagnosisResultDiagnosis> Diagnosis { get; set; }
            public class DescribePreCheckStatusResponseBodyNetworkDiagnosisResultDiagnosis : TeaModel {
                /// <summary>
                /// <para>The documentation URL for the China region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>https://<em><b>.ali</b></em>.com/document_detail/470447.html</para>
                /// </summary>
                [NameInMap("CnDocUrl")]
                [Validation(Required=false)]
                public string CnDocUrl { get; set; }

                /// <summary>
                /// <para>The diagnosis code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dts.kunlun.diagnosis.network.express_doc</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The endpoint type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>source</b>: source endpoint.</description></item>
                /// <item><description><b>destination</b>: destination endpoint.</description></item>
                /// <item><description><b>unknown</b>: unknown.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>source</para>
                /// </summary>
                [NameInMap("EndpointType")]
                [Validation(Required=false)]
                public string EndpointType { get; set; }

                /// <summary>
                /// <para>The documentation URL for regions outside China.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://www.ali***.com/help/en/data-transmission-service/latest/how-to-solve-an-error-when-accessing-a-database-instance-to-dts-using-vpn">https://www.ali***.com/help/en/data-transmission-service/latest/how-to-solve-an-error-when-accessing-a-database-instance-to-dts-using-vpn</a></para>
                /// </summary>
                [NameInMap("InternationalDocUrl")]
                [Validation(Required=false)]
                public string InternationalDocUrl { get; set; }

                /// <summary>
                /// <para>The reserved field for the diagnosis result. This field is empty by default.</para>
                /// 
                /// <b>Example:</b>
                /// <para>none</para>
                /// </summary>
                [NameInMap("Result")]
                [Validation(Required=false)]
                public string Result { get; set; }

            }

            /// <summary>
            /// <para>The version of the diagnosis model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>network-v0.2</para>
            /// </summary>
            [NameInMap("ModelVersion")]
            [Validation(Required=false)]
            public string ModelVersion { get; set; }

        }

        /// <summary>
        /// <para>The page number. The value must be a positive integer that does not exceed the maximum value of the Integer data type. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The maximum number of records that can be displayed on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public long? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C096FA97-B6BA-4575-899D-61E12B59****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The execution status of the subtask. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NotStarted</b>: not started.</description></item>
        /// <item><description><b>Suspending</b>: suspended.</description></item>
        /// <item><description><b>Checking</b>: being checked.</description></item>
        /// <item><description><b>Migrating</b>: being migrated.</description></item>
        /// <item><description><b>Failed</b>: failed.</description></item>
        /// <item><description><b>Catched</b>: incremental data migration or synchronization in progress.</description></item>
        /// <item><description><b>Finished</b>: completed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Finished</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The details of distributed subtasks.</para>
        /// </summary>
        [NameInMap("SubDistributedJobStatus")]
        [Validation(Required=false)]
        public List<DescribePreCheckStatusResponseBodySubDistributedJobStatus> SubDistributedJobStatus { get; set; }
        public class DescribePreCheckStatusResponseBodySubDistributedJobStatus : TeaModel {
            /// <summary>
            /// <para>The task code that represents the queried subtask type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>01</b>: precheck.</description></item>
            /// <item><description><b>02</b>: schema migration or initial schema synchronization.</description></item>
            /// <item><description><b>03</b>: full data migration or initial full data synchronization.</description></item>
            /// <item><description><b>04</b>: incremental data migration or incremental data synchronization.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>02</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The number of tasks that are currently failing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ErrorItem")]
            [Validation(Required=false)]
            public int? ErrorItem { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>n0gm1682j6563np</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The name of the distributed subtask associated with the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dts.step.struct.load</para>
            /// </summary>
            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            /// <summary>
            /// <para>The list of specific items of the subtask and their execution progress.</para>
            /// </summary>
            [NameInMap("JobProgress")]
            [Validation(Required=false)]
            public List<DescribePreCheckStatusResponseBodySubDistributedJobStatusJobProgress> JobProgress { get; set; }
            public class DescribePreCheckStatusResponseBodySubDistributedJobStatusJobProgress : TeaModel {
                /// <summary>
                /// <para>The time when the specific item was started. The time is displayed in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-03-30T03:36:11.000+00:00</para>
                /// </summary>
                [NameInMap("BootTime")]
                [Validation(Required=false)]
                public string BootTime { get; set; }

                /// <summary>
                /// <para>Indicates whether DTS supports skipping the item after it fails. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: Yes.</description></item>
                /// <item><description><b>false</b>: No.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("CanSkip")]
                [Validation(Required=false)]
                public bool? CanSkip { get; set; }

                /// <summary>
                /// <para>The number of subtasks that are currently running.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Current")]
                [Validation(Required=false)]
                public string Current { get; set; }

                /// <summary>
                /// <para>The DDL operation that was executed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>None</para>
                /// </summary>
                [NameInMap("DdlSql")]
                [Validation(Required=false)]
                public string DdlSql { get; set; }

                /// <summary>
                /// <para>The synchronization latency of incremental data migration or incremental data synchronization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DelaySeconds")]
                [Validation(Required=false)]
                public int? DelaySeconds { get; set; }

                /// <summary>
                /// <para>The name of the database to which the migration object belongs in the destination instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>databasetest</para>
                /// </summary>
                [NameInMap("DestSchema")]
                [Validation(Required=false)]
                public string DestSchema { get; set; }

                /// <summary>
                /// <para>This parameter will be deprecated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>None</para>
                /// </summary>
                [NameInMap("DiffRow")]
                [Validation(Required=false)]
                public long? DiffRow { get; set; }

                /// <summary>
                /// <para>The error details when the specific item encounters an error.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CHECK__ERROR_SAME_OBJ_DETAIL</para>
                /// </summary>
                [NameInMap("ErrDetail")]
                [Validation(Required=false)]
                public string ErrDetail { get; set; }

                /// <summary>
                /// <para>The error message when the specific item encounters an error.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ODPS project does not exist odps.`huijin</para>
                /// </summary>
                [NameInMap("ErrMsg")]
                [Validation(Required=false)]
                public string ErrMsg { get; set; }

                /// <summary>
                /// <para>The completion time. The time is displayed in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-03-31T03:36:11.000+00:00</para>
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                /// <summary>
                /// <para>The ID of the record in the metastore.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3890****</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>Indicates whether the specific item is directly ignored and the next item is processed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>N</b>: No.</description></item>
                /// <item><description><b>Y</b>: Yes.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>N</para>
                /// </summary>
                [NameInMap("IgnoreFlag")]
                [Validation(Required=false)]
                public string IgnoreFlag { get; set; }

                /// <summary>
                /// <para>The name of the specific item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>login_common_time</para>
                /// </summary>
                [NameInMap("Item")]
                [Validation(Required=false)]
                public string Item { get; set; }

                /// <summary>
                /// <para>The task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>l3m1213ye7l****</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <para>The execution logs of the error.</para>
                /// </summary>
                [NameInMap("Logs")]
                [Validation(Required=false)]
                public List<DescribePreCheckStatusResponseBodySubDistributedJobStatusJobProgressLogs> Logs { get; set; }
                public class DescribePreCheckStatusResponseBodySubDistributedJobStatusJobProgressLogs : TeaModel {
                    /// <summary>
                    /// <para>The error record.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CREATE TABLE <c>dtstestdata</c>.<c>customer</c> (\n<c>runoob_id</c> int(10) unsigned auto_increment COMMENT \&quot;\&quot; NOT NULL , \n<c>runoob_title</c> varchar(100) CHARSET <c>utf8</c> COLLATE <c>utf8_general_ci</c> COMMENT \&quot;\&quot; NOT NULL , \n<c>runoob_author1216</c> varchar(40) CHARSET <c>utf8</c> COLLATE <c>utf8_general_ci</c> COMMENT \&quot;\&quot; NOT NULL , \n<c>submission_date1216</c> date COMMENT \&quot;\&quot; NULL \n, PRIMARY KEY (<c>runoob_id</c>)) engine=InnoDB AUTO_INCREMENT=200001 DEFAULT CHARSET=<c>utf8</c> DEFAULT COLLATE <c>utf8_general_ci</c> ROW_FORMAT= Dynamic comment = \&quot;\&quot; ;\n</para>
                    /// </summary>
                    [NameInMap("ErrData")]
                    [Validation(Required=false)]
                    public string ErrData { get; set; }

                    /// <summary>
                    /// <para>The specific error message.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>get metric list fail</para>
                    /// </summary>
                    [NameInMap("ErrMsg")]
                    [Validation(Required=false)]
                    public string ErrMsg { get; set; }

                    /// <summary>
                    /// <para>The error type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ForeignKey</para>
                    /// </summary>
                    [NameInMap("ErrType")]
                    [Validation(Required=false)]
                    public string ErrType { get; set; }

                    /// <summary>
                    /// <para>The log level.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>INFO</para>
                    /// </summary>
                    [NameInMap("LogLevel")]
                    [Validation(Required=false)]
                    public string LogLevel { get; set; }

                }

                /// <summary>
                /// <para>The name of the specific item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>metricRuleTargets-20180308houe</para>
                /// </summary>
                [NameInMap("Names")]
                [Validation(Required=false)]
                public string Names { get; set; }

                /// <summary>
                /// <para>The item number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("OrderNum")]
                [Validation(Required=false)]
                public int? OrderNum { get; set; }

                /// <summary>
                /// <para>This parameter will be deprecated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>None</para>
                /// </summary>
                [NameInMap("ParentObj")]
                [Validation(Required=false)]
                public string ParentObj { get; set; }

                /// <summary>
                /// <para>The repair method when the precheck does not pass.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CHECK__ERROR_SAME_OBJ_REPAIR</para>
                /// </summary>
                [NameInMap("RepairMethod")]
                [Validation(Required=false)]
                public string RepairMethod { get; set; }

                /// <summary>
                /// <para>Indicates whether the item has been skipped. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: Yes.</description></item>
                /// <item><description><b>false</b>: No.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Skip")]
                [Validation(Required=false)]
                public bool? Skip { get; set; }

                /// <summary>
                /// <para>The name of the database to which the migration object belongs in the source instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>databasetest</para>
                /// </summary>
                [NameInMap("SourceSchema")]
                [Validation(Required=false)]
                public string SourceSchema { get; set; }

                /// <summary>
                /// <para>The execution status of the subtask. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>NotStarted</b>: not started.</description></item>
                /// <item><description><b>Suspending</b>: suspended.</description></item>
                /// <item><description><b>Checking</b>: being checked.</description></item>
                /// <item><description><b>Migrating</b>: being migrated.</description></item>
                /// <item><description><b>Failed</b>: failed.</description></item>
                /// <item><description><b>Catched</b>: incremental data migration or synchronization in progress.</description></item>
                /// <item><description><b>Finished</b>: completed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Finished</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <para>The progress of sub-items of the specific item.</para>
                /// <remarks>
                /// <para>If <b>[]</b> is returned, no sub-items exist.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>[]</para>
                /// </summary>
                [NameInMap("Sub")]
                [Validation(Required=false)]
                public string Sub { get; set; }

                /// <summary>
                /// <para>The name of the target object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>order</para>
                /// </summary>
                [NameInMap("TargetNames")]
                [Validation(Required=false)]
                public string TargetNames { get; set; }

                /// <summary>
                /// <para>The total number of items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("Total")]
                [Validation(Required=false)]
                public int? Total { get; set; }

            }

            /// <summary>
            /// <para>The execution status of the subtask. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NotStarted</b>: not started.</description></item>
            /// <item><description><b>Suspending</b>: suspended.</description></item>
            /// <item><description><b>Checking</b>: being checked.</description></item>
            /// <item><description><b>Migrating</b>: being migrated.</description></item>
            /// <item><description><b>Failed</b>: failed.</description></item>
            /// <item><description><b>Catched</b>: incremental data migration or synchronization in progress.</description></item>
            /// <item><description><b>Finished</b>: completed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Finished</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The total number of returned data entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of subtasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public long? TotalRecordCount { get; set; }

    }

}
