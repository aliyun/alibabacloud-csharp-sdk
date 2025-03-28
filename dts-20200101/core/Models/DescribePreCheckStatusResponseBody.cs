// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribePreCheckStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>Display list of evaluation tasks</para>
        /// </summary>
        [NameInMap("AnalysisJobProgress")]
        [Validation(Required=false)]
        public List<DescribePreCheckStatusResponseBodyAnalysisJobProgress> AnalysisJobProgress { get; set; }
        public class DescribePreCheckStatusResponseBodyAnalysisJobProgress : TeaModel {
            /// <summary>
            /// <para>The specific project start time, formatted as <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC time).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-03-16T08:01:31.000+00:00</para>
            /// </summary>
            [NameInMap("BootTime")]
            [Validation(Required=false)]
            public string BootTime { get; set; }

            /// <summary>
            /// <para>Whether to support skipping this sub-item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CanSkip")]
            [Validation(Required=false)]
            public bool? CanSkip { get; set; }

            /// <summary>
            /// <para>The number of currently running subtasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Current")]
            [Validation(Required=false)]
            public string Current { get; set; }

            /// <summary>
            /// <para>The DDL operation to be executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CREATE TABLE ****</para>
            /// </summary>
            [NameInMap("DdlSql")]
            [Validation(Required=false)]
            public string DdlSql { get; set; }

            /// <summary>
            /// <para>Task delay time</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DelaySeconds")]
            [Validation(Required=false)]
            public int? DelaySeconds { get; set; }

            /// <summary>
            /// <para>Name of the database to which the migration objects in the target instance belong.</para>
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
            /// <para>Error details when the project encounters an error.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ANALYSIS_MYSQL</para>
            /// </summary>
            [NameInMap("ErrDetail")]
            [Validation(Required=false)]
            public string ErrDetail { get; set; }

            /// <summary>
            /// <para>Specific error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ANALYSIS_</para>
            /// </summary>
            [NameInMap("ErrMsg")]
            [Validation(Required=false)]
            public string ErrMsg { get; set; }

            /// <summary>
            /// <para>The end time of the evaluation task, formatted as <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC time).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-03-16T08:01:31.000+00:00</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            /// <summary>
            /// <para>The ID of this evaluation item in the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123123</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Whether to directly ignore this specific item and move to the next one. Return values:</para>
            /// <list type="bullet">
            /// <item><description><b>N</b>: No. - <b>Y</b>: Yes.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>N</para>
            /// </summary>
            [NameInMap("IgnoreFlag")]
            [Validation(Required=false)]
            public string IgnoreFlag { get; set; }

            /// <summary>
            /// <para>Name of the evaluation item</para>
            /// 
            /// <b>Example:</b>
            /// <para>ANALYSIS_MYSQL_4_ITEM</para>
            /// </summary>
            [NameInMap("Item")]
            [Validation(Required=false)]
            public string Item { get; set; }

            /// <summary>
            /// <para>The ID of the evaluation task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11234234xc</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>Sub-assessment item.</para>
            /// </summary>
            [NameInMap("Logs")]
            [Validation(Required=false)]
            public List<DescribePreCheckStatusResponseBodyAnalysisJobProgressLogs> Logs { get; set; }
            public class DescribePreCheckStatusResponseBodyAnalysisJobProgressLogs : TeaModel {
                /// <summary>
                /// <para>Error message</para>
                /// 
                /// <b>Example:</b>
                /// <para>Please modify this object</para>
                /// </summary>
                [NameInMap("ErrData")]
                [Validation(Required=false)]
                public string ErrData { get; set; }

                /// <summary>
                /// <para>Error message from DTS when a specific project encounters an error.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DTS-1020042 Execute sql error sql: Table \&quot;customer\&quot; already exists</para>
                /// </summary>
                [NameInMap("ErrMsg")]
                [Validation(Required=false)]
                public string ErrMsg { get; set; }

                /// <summary>
                /// <para>Error type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ForeignKey</para>
                /// </summary>
                [NameInMap("ErrType")]
                [Validation(Required=false)]
                public string ErrType { get; set; }

                /// <summary>
                /// <para>The level of the log.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ERROR</para>
                /// </summary>
                [NameInMap("LogLevel")]
                [Validation(Required=false)]
                public string LogLevel { get; set; }

            }

            /// <summary>
            /// <para>Name of the evaluation item</para>
            /// 
            /// <b>Example:</b>
            /// <para>ANALYSIS_MYSQL_4_DETAIL</para>
            /// </summary>
            [NameInMap("Names")]
            [Validation(Required=false)]
            public string Names { get; set; }

            /// <summary>
            /// <para>The number of the evaluation item.</para>
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
            /// <para>Remediation method for the evaluation item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ANALYSIS_</para>
            /// </summary>
            [NameInMap("RepairMethod")]
            [Validation(Required=false)]
            public string RepairMethod { get; set; }

            /// <summary>
            /// <para>If this evaluation item fails, whether you set to skip this item. Return values: * <b>true</b>: Yes * <b>false</b>: No</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Skip")]
            [Validation(Required=false)]
            public bool? Skip { get; set; }

            /// <summary>
            /// <para>Name of the database to which the migration objects in the source instance belong.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dtstestdata</para>
            /// </summary>
            [NameInMap("SourceSchema")]
            [Validation(Required=false)]
            public string SourceSchema { get; set; }

            /// <summary>
            /// <para>The result of the evaluation, with return values being: - <b>Failed</b>: Failure. - <b>Success</b>: Success.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>Progress of sub-projects under a specific project. &gt; If it returns <b>[]</b>, it indicates there are no sub-projects.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("Sub")]
            [Validation(Required=false)]
            public string Sub { get; set; }

            /// <summary>
            /// <para>Name of the target object</para>
            /// 
            /// <b>Example:</b>
            /// <para>testTable</para>
            /// </summary>
            [NameInMap("TargetNames")]
            [Validation(Required=false)]
            public string TargetNames { get; set; }

            /// <summary>
            /// <para>The total number of specific items in the sub-task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>The task code that indicates the type of the subtask. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>01</b>: precheck.</description></item>
        /// <item><description><b>02</b>: schema migration or initial schema synchronization.</description></item>
        /// <item><description><b>03</b>: full data migration or initial full data synchronization.</description></item>
        /// <item><description><b>04</b>: incremental data migration or synchronization.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>01</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Number of failed evaluation items</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ErrorAnalysisItem")]
        [Validation(Required=false)]
        public int? ErrorAnalysisItem { get; set; }

        /// <summary>
        /// <para>The total number of subtask failures.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ErrorItem")]
        [Validation(Required=false)]
        public int? ErrorItem { get; set; }

        /// <summary>
        /// <para>Network-wide inspection results.</para>
        /// </summary>
        [NameInMap("FullNetCheckJobStatus")]
        [Validation(Required=false)]
        public List<DescribePreCheckStatusResponseBodyFullNetCheckJobStatus> FullNetCheckJobStatus { get; set; }
        public class DescribePreCheckStatusResponseBodyFullNetCheckJobStatus : TeaModel {
            /// <summary>
            /// <para>Task code, <b>01</b> represents pre-check.</para>
            /// 
            /// <b>Example:</b>
            /// <para>01</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>ID of the region to which the target network segment belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("DestRegion")]
            [Validation(Required=false)]
            public string DestRegion { get; set; }

            /// <summary>
            /// <para>Destination network segment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100.104.XX.XXX/XX</para>
            /// </summary>
            [NameInMap("DestRegionCidr")]
            [Validation(Required=false)]
            public string DestRegionCidr { get; set; }

            /// <summary>
            /// <para>The access method of the target instance, with return values as follows: - <b>ALIYUN</b>: Access method is <b>cloud instance</b>. - <b>OTHER</b>: Access method is <b>public IP</b>. - <b>ECS</b>: Access method is <b>ECS self-built database</b>. - <b>EXPRESS</b>: Access method is <b>Express Connect / VPN Gateway / Smart Gateway</b>. - <b>CEN</b>: Access method is <b>Cloud Enterprise Network (CEN)</b>. - <b>DG</b>: Access method is <b>Database Gateway (DG)</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CEN</para>
            /// </summary>
            [NameInMap("DestinationEndpointType")]
            [Validation(Required=false)]
            public string DestinationEndpointType { get; set; }

            /// <summary>
            /// <para>Number of pre-check failed items</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ErrorItem")]
            [Validation(Required=false)]
            public int? ErrorItem { get; set; }

            /// <summary>
            /// <para>The region ID of the instance\&quot;s running node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("HostRegion")]
            [Validation(Required=false)]
            public string HostRegion { get; set; }

            /// <summary>
            /// <para>Task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>l3m1213ye7l****</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>Task name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dts.step.fullnetcheck</para>
            /// </summary>
            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            /// <summary>
            /// <para>A list of specific items for the task and their execution progress.</para>
            /// </summary>
            [NameInMap("JobProgress")]
            [Validation(Required=false)]
            public List<DescribePreCheckStatusResponseBodyFullNetCheckJobStatusJobProgress> JobProgress { get; set; }
            public class DescribePreCheckStatusResponseBodyFullNetCheckJobStatusJobProgress : TeaModel {
                /// <summary>
                /// <para>The specific project start time, formatted as <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC time).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-03-30T03:36:11.000+00:00</para>
                /// </summary>
                [NameInMap("BootTime")]
                [Validation(Required=false)]
                public string BootTime { get; set; }

                /// <summary>
                /// <para>Whether DTS supports skipping a project after it fails. Return values: * <b>true</b>: Yes * <b>false</b>: No</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("CanSkip")]
                [Validation(Required=false)]
                public bool? CanSkip { get; set; }

                /// <summary>
                /// <para>The number of currently running tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Current")]
                [Validation(Required=false)]
                public string Current { get; set; }

                /// <summary>
                /// <para>The DDL operation to be executed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CREATE TABLE ****</para>
                /// </summary>
                [NameInMap("DdlSql")]
                [Validation(Required=false)]
                public string DdlSql { get; set; }

                /// <summary>
                /// <para>Task delay time</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DelaySeconds")]
                [Validation(Required=false)]
                public int? DelaySeconds { get; set; }

                /// <summary>
                /// <para>Name of the database to which the migration objects in the target instance belong.</para>
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
                /// <para>Details of the error when a specific project fails.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CHECK__ERROR_SAME_OBJ_DETAIL</para>
                /// </summary>
                [NameInMap("ErrDetail")]
                [Validation(Required=false)]
                public string ErrDetail { get; set; }

                /// <summary>
                /// <para>Error message prompt when a specific project encounters an error.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ODPS project does not exist odps.`huijin</para>
                /// </summary>
                [NameInMap("ErrMsg")]
                [Validation(Required=false)]
                public string ErrMsg { get; set; }

                /// <summary>
                /// <para>Task completion time, formatted as yyyy-MM-ddTHH:mm:ssZ (UTC time).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-03-31T03:36:11.000+00:00</para>
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                /// <summary>
                /// <para>The ID of the record in the metadata database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>922305811766881****</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>Whether to directly ignore this specific item and move to the next one. Return values:</para>
                /// <list type="bullet">
                /// <item><description><b>N</b>: No. - <b>Y</b>: Yes.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>N</para>
                /// </summary>
                [NameInMap("IgnoreFlag")]
                [Validation(Required=false)]
                public string IgnoreFlag { get; set; }

                /// <summary>
                /// <para>Specific project name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CHECK_CONN_SRC</para>
                /// </summary>
                [NameInMap("Item")]
                [Validation(Required=false)]
                public string Item { get; set; }

                /// <summary>
                /// <para>Task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>l3m1213ye7l****</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <para>Error execution log information.</para>
                /// </summary>
                [NameInMap("Logs")]
                [Validation(Required=false)]
                public List<DescribePreCheckStatusResponseBodyFullNetCheckJobStatusJobProgressLogs> Logs { get; set; }
                public class DescribePreCheckStatusResponseBodyFullNetCheckJobStatusJobProgressLogs : TeaModel {
                    /// <summary>
                    /// <para>Error record.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CREATE TABLE <c>dtstestdata</c>.<c>customer</c> ****</para>
                    /// </summary>
                    [NameInMap("ErrData")]
                    [Validation(Required=false)]
                    public string ErrData { get; set; }

                    /// <summary>
                    /// <para>Specific error message.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>get metric list fail</para>
                    /// </summary>
                    [NameInMap("ErrMsg")]
                    [Validation(Required=false)]
                    public string ErrMsg { get; set; }

                    /// <summary>
                    /// <para>Type of error.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ForeignKey</para>
                    /// </summary>
                    [NameInMap("ErrType")]
                    [Validation(Required=false)]
                    public string ErrType { get; set; }

                    /// <summary>
                    /// <para>The level of the log.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>INFO</para>
                    /// </summary>
                    [NameInMap("LogLevel")]
                    [Validation(Required=false)]
                    public string LogLevel { get; set; }

                }

                /// <summary>
                /// <para>Specific project name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CHECK_CONN_SRC_DETAIL</para>
                /// </summary>
                [NameInMap("Names")]
                [Validation(Required=false)]
                public string Names { get; set; }

                /// <summary>
                /// <para>Project number.</para>
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
                /// <para>The corresponding remediation method when the pre-check fails.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CHECK__ERROR_SAME_OBJ_REPAIR</para>
                /// </summary>
                [NameInMap("RepairMethod")]
                [Validation(Required=false)]
                public string RepairMethod { get; set; }

                /// <summary>
                /// <para>After this specific item fails, do you set to skip this item. Return values: * <b>true</b>: Yes * <b>false</b>: No</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Skip")]
                [Validation(Required=false)]
                public bool? Skip { get; set; }

                /// <summary>
                /// <para>Name of the database to which the migration objects in the source instance belong.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dtstestdata</para>
                /// </summary>
                [NameInMap("SourceSchema")]
                [Validation(Required=false)]
                public string SourceSchema { get; set; }

                /// <summary>
                /// <para>Check result, the return value is: - <b>Failed</b>: Failure. - <b>Success</b>: Completed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <para>Progress of sub-projects under a specific project. &gt; If it returns <b>[]</b>, it indicates there are no sub-projects.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[]</para>
                /// </summary>
                [NameInMap("Sub")]
                [Validation(Required=false)]
                public string Sub { get; set; }

                /// <summary>
                /// <para>Name of the target object</para>
                /// 
                /// <b>Example:</b>
                /// <para>order</para>
                /// </summary>
                [NameInMap("TargetNames")]
                [Validation(Required=false)]
                public string TargetNames { get; set; }

                /// <summary>
                /// <para>The total number of projects.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("Total")]
                [Validation(Required=false)]
                public int? Total { get; set; }

            }

            /// <summary>
            /// <para>The access method of the source instance, with return values as follows: - <b>ALIYUN</b>: Access method is <b>cloud instance</b>. - <b>OTHER</b>: Access method is <b>public IP</b>. - <b>ECS</b>: Access method is <b>ECS self-built database</b>. - <b>EXPRESS</b>: Access method is <b>dedicated line/VPN gateway/smart gateway</b>. - <b>CEN</b>: Access method is <b>Cloud Enterprise Network CEN</b>. - <b>DG</b>: Access method is <b>Database Gateway DG</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CEN</para>
            /// </summary>
            [NameInMap("SourceEndpointType")]
            [Validation(Required=false)]
            public string SourceEndpointType { get; set; }

            /// <summary>
            /// <para>ID of the region to which the source network segment belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("SrcRegion")]
            [Validation(Required=false)]
            public string SrcRegion { get; set; }

            /// <summary>
            /// <para>Source network segment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100.104.XX.XXX/XX</para>
            /// </summary>
            [NameInMap("SrcRegionCidr")]
            [Validation(Required=false)]
            public string SrcRegionCidr { get; set; }

            /// <summary>
            /// <para>Check result, the return value is: - <b>Failed</b>: Failure. - <b>Success</b>: Completed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>Total number of items in the project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>The status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The ID of the data migration or synchronization task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b4my3zg929a****</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The name of the subtask.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtstest</para>
        /// </summary>
        [NameInMap("JobName")]
        [Validation(Required=false)]
        public string JobName { get; set; }

        /// <summary>
        /// <para>The subtasks and the progress of each subtask.</para>
        /// </summary>
        [NameInMap("JobProgress")]
        [Validation(Required=false)]
        public List<DescribePreCheckStatusResponseBodyJobProgress> JobProgress { get; set; }
        public class DescribePreCheckStatusResponseBodyJobProgress : TeaModel {
            /// <summary>
            /// <para>The time when the subtask was started. The time is displayed in the yyyy-MM-ddTHH:mm:ssZ format in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-03-16T08:01:31.000+00:00</para>
            /// </summary>
            [NameInMap("BootTime")]
            [Validation(Required=false)]
            public string BootTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the subtask can be ignored if it fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CanSkip")]
            [Validation(Required=false)]
            public bool? CanSkip { get; set; }

            /// <summary>
            /// <para>The number of the subtasks that are running.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Current")]
            [Validation(Required=false)]
            public string Current { get; set; }

            /// <summary>
            /// <para>The DDL statements.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CREATE TABLE <c>dtstestdata</c>.<c>order</c> (\n<c>orderid</c>  int(11)     COMMENT \&quot;\&quot;   NOT NULL   , \n<c>username</c>  char(32)  CHARSET <c>utf8</c> COLLATE <c>utf8_general_ci</c>    COMMENT \&quot;\&quot;   NULL   , \n<c>ordertime</c>  datetime     COMMENT \&quot;\&quot;   NULL   , \n<c>commodity</c>  varchar(32)  CHARSET <c>utf8</c> COLLATE <c>utf8_general_ci</c>    COMMENT \&quot;\&quot;   NULL   , \n<c>phonenumber</c>  int(11)     COMMENT \&quot;\&quot;   NULL   , \n<c>address</c>  text  CHARSET <c>utf8mb4</c> COLLATE <c>utf8mb4_general_ci</c>    COMMENT \&quot;\&quot;   NULL   \n, PRIMARY KEY (<c>orderid</c>)) engine=InnoDB DEFAULT CHARSET=<c>gbk</c> DEFAULT COLLATE <c>gbk_chinese_ci</c> ROW_FORMAT= Dynamic comment = \&quot;\&quot; ;\n</para>
            /// </summary>
            [NameInMap("DdlSql")]
            [Validation(Required=false)]
            public string DdlSql { get; set; }

            /// <summary>
            /// <para>The latency of incremental data migration or synchronization.</para>
            /// <remarks>
            /// <para>If you query data migration tasks, the unit of this parameter is milliseconds. If you query data synchronization tasks, the unit of this parameter is seconds.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DelaySeconds")]
            [Validation(Required=false)]
            public int? DelaySeconds { get; set; }

            /// <summary>
            /// <para>The name of the database to which the object in the destination instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dtstestdata_new</para>
            /// </summary>
            [NameInMap("DestSchema")]
            [Validation(Required=false)]
            public string DestSchema { get; set; }

            /// <summary>
            /// <para>This parameter will be removed in the future.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DiffRow")]
            [Validation(Required=false)]
            public long? DiffRow { get; set; }

            /// <summary>
            /// <para>The error details of the subtask failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CHECK__ERROR_SAME_OBJ_DETAIL</para>
            /// </summary>
            [NameInMap("ErrDetail")]
            [Validation(Required=false)]
            public string ErrDetail { get; set; }

            /// <summary>
            /// <para>The error message of the subtask failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CHECK__ERROR_SAME_OBJ</para>
            /// </summary>
            [NameInMap("ErrMsg")]
            [Validation(Required=false)]
            public string ErrMsg { get; set; }

            /// <summary>
            /// <para>The time when the subtask was complete. The time is displayed in the yyyy-MM-ddTHH:mm:ssZ format in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-03-16T08:01:34.000+00:00</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            /// <summary>
            /// <para>The ID of the entry in the metadatabase.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5632</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Indicates whether DTS ignores the subtask and proceeds with the next subtask. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>N</b>: no.</description></item>
            /// <item><description><b>Y</b>: yes.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>N</para>
            /// </summary>
            [NameInMap("IgnoreFlag")]
            [Validation(Required=false)]
            public string IgnoreFlag { get; set; }

            /// <summary>
            /// <para>The shortened name of the subtask.</para>
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
            /// <para>The logs of subtask failures.</para>
            /// </summary>
            [NameInMap("Logs")]
            [Validation(Required=false)]
            public List<DescribePreCheckStatusResponseBodyJobProgressLogs> Logs { get; set; }
            public class DescribePreCheckStatusResponseBodyJobProgressLogs : TeaModel {
                /// <summary>
                /// <para>The error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CREATE TABLE <c>dtstestdata</c>.<c>customer</c> (\n<c>runoob_id</c>  int(10) unsigned   auto_increment  COMMENT \&quot;\&quot;   NOT NULL   , \n<c>runoob_title</c>  varchar(100)  CHARSET <c>utf8</c> COLLATE <c>utf8_general_ci</c>    COMMENT \&quot;\&quot;   NOT NULL   , \n<c>runoob_author1216</c>  varchar(40)  CHARSET <c>utf8</c> COLLATE <c>utf8_general_ci</c>    COMMENT \&quot;\&quot;   NOT NULL   , \n<c>submission_date1216</c>  date     COMMENT \&quot;\&quot;   NULL   \n, PRIMARY KEY (<c>runoob_id</c>)) engine=InnoDB AUTO_INCREMENT=200001 DEFAULT CHARSET=<c>utf8</c> DEFAULT COLLATE <c>utf8_general_ci</c> ROW_FORMAT= Dynamic comment = \&quot;\&quot; ;\n</para>
                /// </summary>
                [NameInMap("ErrData")]
                [Validation(Required=false)]
                public string ErrData { get; set; }

                /// <summary>
                /// <para>The error message that is returned when an error occurs on the subtask.</para>
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
                /// <para>The level of logs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ERROR</para>
                /// </summary>
                [NameInMap("LogLevel")]
                [Validation(Required=false)]
                public string LogLevel { get; set; }

            }

            /// <summary>
            /// <para>The name of the subtask.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CHECK_CONN_DEST_DETAIL</para>
            /// </summary>
            [NameInMap("Names")]
            [Validation(Required=false)]
            public string Names { get; set; }

            /// <summary>
            /// <para>The serial number of the subtask.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("OrderNum")]
            [Validation(Required=false)]
            public int? OrderNum { get; set; }

            /// <summary>
            /// <para>This parameter will be removed in the future.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo</para>
            /// </summary>
            [NameInMap("ParentObj")]
            [Validation(Required=false)]
            public string ParentObj { get; set; }

            /// <summary>
            /// <para>The method to fix the subtask failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CHECK__ERROR_SAME_OBJ_REPAIR</para>
            /// </summary>
            [NameInMap("RepairMethod")]
            [Validation(Required=false)]
            public string RepairMethod { get; set; }

            /// <summary>
            /// <para>Indicates whether the subtask is ignored if it fails. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Skip")]
            [Validation(Required=false)]
            public bool? Skip { get; set; }

            /// <summary>
            /// <para>The name of the database to which the object in the source instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dtstestdata</para>
            /// </summary>
            [NameInMap("SourceSchema")]
            [Validation(Required=false)]
            public string SourceSchema { get; set; }

            /// <summary>
            /// <para>The status of the subtask. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NotStarted</b>: The subtask is not started.</description></item>
            /// <item><description><b>Checking</b>: The subtask is being checked.</description></item>
            /// <item><description><b>Migrating</b>: The subtask is in progress. Data is being migrated.</description></item>
            /// <item><description><b>Failed</b>: The subtask failed.</description></item>
            /// <item><description><b>Warning</b>: The subtask encounters an exception.</description></item>
            /// <item><description><b>Success</b>: The subtask is complete.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The sub-item progress of the subtask.</para>
            /// <remarks>
            /// <para>If \<em>\</em>[]\<em>\</em> is returned, the subtask has no sub-items.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("Sub")]
            [Validation(Required=false)]
            public string Sub { get; set; }

            /// <summary>
            /// <para>The names of the objects that are migrated or synchronized.</para>
            /// 
            /// <b>Example:</b>
            /// <para>order</para>
            /// </summary>
            [NameInMap("TargetNames")]
            [Validation(Required=false)]
            public string TargetNames { get; set; }

            /// <summary>
            /// <para>The total number of sub-items of the subtask.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>Network diagnosis result</para>
        /// </summary>
        [NameInMap("NetworkDiagnosisResult")]
        [Validation(Required=false)]
        public DescribePreCheckStatusResponseBodyNetworkDiagnosisResult NetworkDiagnosisResult { get; set; }
        public class DescribePreCheckStatusResponseBodyNetworkDiagnosisResult : TeaModel {
            /// <summary>
            /// <para>Network diagnostic report</para>
            /// </summary>
            [NameInMap("Diagnosis")]
            [Validation(Required=false)]
            public List<DescribePreCheckStatusResponseBodyNetworkDiagnosisResultDiagnosis> Diagnosis { get; set; }
            public class DescribePreCheckStatusResponseBodyNetworkDiagnosisResultDiagnosis : TeaModel {
                /// <summary>
                /// <para>Document address for China region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>https://<em><b>.ali</b></em>.com/document_detail/470447.html</para>
                /// </summary>
                [NameInMap("CnDocUrl")]
                [Validation(Required=false)]
                public string CnDocUrl { get; set; }

                /// <summary>
                /// <para>Diagnostic code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dts.kunlun.diagnosis.network.express_doc</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>Access point, the return values are: - <b>source</b>: source end. - <b>destination</b>: destination end. - <b>unknown</b>: unknown.</para>
                /// 
                /// <b>Example:</b>
                /// <para>source</para>
                /// </summary>
                [NameInMap("EndpointType")]
                [Validation(Required=false)]
                public string EndpointType { get; set; }

                /// <summary>
                /// <para>Overseas region document address.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://www.ali***.com/help/en/data-transmission-service/latest/how-to-solve-an-error-when-accessing-a-database-instance-to-dts-using-vpn">https://www.ali***.com/help/en/data-transmission-service/latest/how-to-solve-an-error-when-accessing-a-database-instance-to-dts-using-vpn</a></para>
                /// </summary>
                [NameInMap("InternationalDocUrl")]
                [Validation(Required=false)]
                public string InternationalDocUrl { get; set; }

                /// <summary>
                /// <para>Reserved field for diagnostic results, default is empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>none</para>
                /// </summary>
                [NameInMap("Result")]
                [Validation(Required=false)]
                public string Result { get; set; }

            }

            /// <summary>
            /// <para>Diagnose model version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>network-v0.2</para>
            /// </summary>
            [NameInMap("ModelVersion")]
            [Validation(Required=false)]
            public string ModelVersion { get; set; }

        }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
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
        /// <para>The status of the subtask. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NotStarted</b>: The subtask is not started.</description></item>
        /// <item><description><b>Suspending</b>: The subtask is paused.</description></item>
        /// <item><description><b>Checking</b>: The subtask is being checked.</description></item>
        /// <item><description><b>Migrating</b>: The subtask is in progress. Data is being migrated.</description></item>
        /// <item><description><b>Failed</b>: The subtask failed.</description></item>
        /// <item><description><b>Catched</b>: The subtask is in progress. Incremental data is being migrated or synchronized.</description></item>
        /// <item><description><b>Finished</b>: The subtask is complete.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Finished</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The information about the distributed subtasks.</para>
        /// </summary>
        [NameInMap("SubDistributedJobStatus")]
        [Validation(Required=false)]
        public List<DescribePreCheckStatusResponseBodySubDistributedJobStatus> SubDistributedJobStatus { get; set; }
        public class DescribePreCheckStatusResponseBodySubDistributedJobStatus : TeaModel {
            /// <summary>
            /// <para>The task code that indicates the type of the subtask. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>01</b>: precheck.</description></item>
            /// <item><description><b>02</b>: schema migration or initial schema synchronization.</description></item>
            /// <item><description><b>03</b>: full data migration or initial full data synchronization.</description></item>
            /// <item><description><b>04</b>: incremental data migration or synchronization.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>02</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The number of subtasks that failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ErrorItem")]
            [Validation(Required=false)]
            public int? ErrorItem { get; set; }

            /// <summary>
            /// <para>The subtask ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>n0gm1682j6563np</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The name of distributed subtasks associated with the subtask.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dts.step.struct.load</para>
            /// </summary>
            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            /// <summary>
            /// <para>The subtasks and the progress of each subtask.</para>
            /// </summary>
            [NameInMap("JobProgress")]
            [Validation(Required=false)]
            public List<DescribePreCheckStatusResponseBodySubDistributedJobStatusJobProgress> JobProgress { get; set; }
            public class DescribePreCheckStatusResponseBodySubDistributedJobStatusJobProgress : TeaModel {
                /// <summary>
                /// <para>The time when the subtask was started. The time is displayed in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-03-30T03:36:11.000+00:00</para>
                /// </summary>
                [NameInMap("BootTime")]
                [Validation(Required=false)]
                public string BootTime { get; set; }

                /// <summary>
                /// <para>Indicates whether the subtask can be ignored if it fails. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("CanSkip")]
                [Validation(Required=false)]
                public bool? CanSkip { get; set; }

                /// <summary>
                /// <para>The number of the subtasks that are running.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Current")]
                [Validation(Required=false)]
                public string Current { get; set; }

                /// <summary>
                /// <para>The DDL statements.</para>
                /// 
                /// <b>Example:</b>
                /// <para>None</para>
                /// </summary>
                [NameInMap("DdlSql")]
                [Validation(Required=false)]
                public string DdlSql { get; set; }

                /// <summary>
                /// <para>The latency of incremental data migration or synchronization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DelaySeconds")]
                [Validation(Required=false)]
                public int? DelaySeconds { get; set; }

                /// <summary>
                /// <para>The name of the database to which the object in the destination instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>databasetest</para>
                /// </summary>
                [NameInMap("DestSchema")]
                [Validation(Required=false)]
                public string DestSchema { get; set; }

                /// <summary>
                /// <para>This parameter will be removed in the future.</para>
                /// 
                /// <b>Example:</b>
                /// <para>None</para>
                /// </summary>
                [NameInMap("DiffRow")]
                [Validation(Required=false)]
                public long? DiffRow { get; set; }

                /// <summary>
                /// <para>The error details of the subtask failure.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CHECK__ERROR_SAME_OBJ_DETAIL</para>
                /// </summary>
                [NameInMap("ErrDetail")]
                [Validation(Required=false)]
                public string ErrDetail { get; set; }

                /// <summary>
                /// <para>The error message of the subtask failure.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ODPS project does not exist odps.`huijin</para>
                /// </summary>
                [NameInMap("ErrMsg")]
                [Validation(Required=false)]
                public string ErrMsg { get; set; }

                /// <summary>
                /// <para>The time when the subtask was complete. The time is displayed in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-03-31T03:36:11.000+00:00</para>
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                /// <summary>
                /// <para>The ID of the entry in the metadatabase.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3890</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>Indicates whether DTS ignores the subtask and proceeds with the next subtask. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>N</b>: no.</description></item>
                /// <item><description><b>Y</b>: yes.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>N</para>
                /// </summary>
                [NameInMap("IgnoreFlag")]
                [Validation(Required=false)]
                public string IgnoreFlag { get; set; }

                /// <summary>
                /// <para>The name of the subtask.</para>
                /// 
                /// <b>Example:</b>
                /// <para>login_common_time</para>
                /// </summary>
                [NameInMap("Item")]
                [Validation(Required=false)]
                public string Item { get; set; }

                /// <summary>
                /// <para>The subtask ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>l3m1213ye7l****</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <para>The operations logs of errors.</para>
                /// </summary>
                [NameInMap("Logs")]
                [Validation(Required=false)]
                public List<DescribePreCheckStatusResponseBodySubDistributedJobStatusJobProgressLogs> Logs { get; set; }
                public class DescribePreCheckStatusResponseBodySubDistributedJobStatusJobProgressLogs : TeaModel {
                    /// <summary>
                    /// <para>The record of errors.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CREATE TABLE <c>dtstestdata</c>.<c>customer</c> (\n<c>runoob_id</c> int(10) unsigned auto_increment COMMENT \&quot;\&quot; NOT NULL , \n<c>runoob_title</c> varchar(100) CHARSET <c>utf8</c> COLLATE <c>utf8_general_ci</c> COMMENT \&quot;\&quot; NOT NULL , \n<c>runoob_author1216</c> varchar(40) CHARSET <c>utf8</c> COLLATE <c>utf8_general_ci</c> COMMENT \&quot;\&quot; NOT NULL , \n<c>submission_date1216</c> date COMMENT \&quot;\&quot; NULL \n, PRIMARY KEY (<c>runoob_id</c>)) engine=InnoDB AUTO_INCREMENT=200001 DEFAULT CHARSET=<c>utf8</c> DEFAULT COLLATE <c>utf8_general_ci</c> ROW_FORMAT= Dynamic comment = \&quot;\&quot; ;\n</para>
                    /// </summary>
                    [NameInMap("ErrData")]
                    [Validation(Required=false)]
                    public string ErrData { get; set; }

                    /// <summary>
                    /// <para>The error message.</para>
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
                    /// <para>The level of logs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>INFO</para>
                    /// </summary>
                    [NameInMap("LogLevel")]
                    [Validation(Required=false)]
                    public string LogLevel { get; set; }

                }

                /// <summary>
                /// <para>The name of the subtask.</para>
                /// 
                /// <b>Example:</b>
                /// <para>metricRuleTargets-20180308houe</para>
                /// </summary>
                [NameInMap("Names")]
                [Validation(Required=false)]
                public string Names { get; set; }

                /// <summary>
                /// <para>The serial number of the subtask.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("OrderNum")]
                [Validation(Required=false)]
                public int? OrderNum { get; set; }

                /// <summary>
                /// <para>This parameter will be removed in the future.</para>
                /// 
                /// <b>Example:</b>
                /// <para>None</para>
                /// </summary>
                [NameInMap("ParentObj")]
                [Validation(Required=false)]
                public string ParentObj { get; set; }

                /// <summary>
                /// <para>The method to fix a precheck failure.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CHECK__ERROR_SAME_OBJ_REPAIR</para>
                /// </summary>
                [NameInMap("RepairMethod")]
                [Validation(Required=false)]
                public string RepairMethod { get; set; }

                /// <summary>
                /// <para>Indicates whether the subtask was ignored. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("Skip")]
                [Validation(Required=false)]
                public bool? Skip { get; set; }

                /// <summary>
                /// <para>The name of the database to which the object in the source instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>databasetest</para>
                /// </summary>
                [NameInMap("SourceSchema")]
                [Validation(Required=false)]
                public string SourceSchema { get; set; }

                /// <summary>
                /// <para>The status of the subtask. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>NotStarted</b>: The subtask is not started.</description></item>
                /// <item><description><b>Suspending</b>: The subtask is paused.</description></item>
                /// <item><description><b>Checking</b>: The subtask is being checked.</description></item>
                /// <item><description><b>Migrating</b>: The subtask is in progress. Data is being migrated.</description></item>
                /// <item><description><b>Failed</b>: The subtask failed.</description></item>
                /// <item><description><b>Catched</b>: The subtask is in progress. Incremental data is being migrated or synchronized.</description></item>
                /// <item><description><b>Finished</b>: The subtask is complete.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Finished</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <para>The sub-item progress of the subtask.</para>
                /// <remarks>
                /// <para>If \<em>\</em>[]\<em>\</em> is returned, the subtask has no sub-item.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>[]</para>
                /// </summary>
                [NameInMap("Sub")]
                [Validation(Required=false)]
                public string Sub { get; set; }

                /// <summary>
                /// <para>The names of the objects that are migrated or synchronized.</para>
                /// 
                /// <b>Example:</b>
                /// <para>order</para>
                /// </summary>
                [NameInMap("TargetNames")]
                [Validation(Required=false)]
                public string TargetNames { get; set; }

                /// <summary>
                /// <para>The total number of subtasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("Total")]
                [Validation(Required=false)]
                public int? Total { get; set; }

            }

            /// <summary>
            /// <para>The status of the subtask. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NotStarted</b>: The subtask is not started.</description></item>
            /// <item><description><b>Suspending</b>: The subtask is paused.</description></item>
            /// <item><description><b>Checking</b>: The subtask is being checked.</description></item>
            /// <item><description><b>Migrating</b>: The subtask is in progress. Data is being migrated.</description></item>
            /// <item><description><b>Failed</b>: The subtask failed.</description></item>
            /// <item><description><b>Catched</b>: The subtask is in progress. Incremental data is being migrated or synchronized.</description></item>
            /// <item><description><b>Finished</b>: The subtask is complete.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Finished</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The total number of entries that are returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
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
        /// <para>The total number of entries that are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public long? TotalRecordCount { get; set; }

    }

}
