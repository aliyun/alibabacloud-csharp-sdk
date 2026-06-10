// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ModifyJobGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The API status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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
        /// <para>The job group details.</para>
        /// </summary>
        [NameInMap("JobGroup")]
        [Validation(Required=false)]
        public ModifyJobGroupResponseBodyJobGroup JobGroup { get; set; }
        public class ModifyJobGroupResponseBodyJobGroup : TeaModel {
            /// <summary>
            /// <para>The list of calling numbers.</para>
            /// </summary>
            [NameInMap("CallingNumbers")]
            [Validation(Required=false)]
            public List<string> CallingNumbers { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// <remarks>
            /// <para>Call the <c>DescribeJobGroup</c> operation to obtain this value.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1578550074361</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public long? CreationTime { get; set; }

            /// <summary>
            /// <para>The export progress. [Deprecated]</para>
            /// </summary>
            [NameInMap("ExportProgress")]
            [Validation(Required=false)]
            public ModifyJobGroupResponseBodyJobGroupExportProgress ExportProgress { get; set; }
            public class ModifyJobGroupResponseBodyJobGroupExportProgress : TeaModel {
                /// <summary>
                /// <para>The file URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>https://***.oss-cn-shanghai.aliyuncs.com/sample</para>
                /// </summary>
                [NameInMap("FileHttpUrl")]
                [Validation(Required=false)]
                public string FileHttpUrl { get; set; }

                /// <summary>
                /// <para>The progress of the export.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public string Progress { get; set; }

                /// <summary>
                /// <para>The export status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FINISHED</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>Extra parameters for the flash SMS service. The value is a JSON string that contains the configuration for a third-party provider.</para>
            /// <para><c>templateId</c>: The flash SMS template ID. <c>configId</c>: The flash SMS configuration ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;configId&quot;:&quot;3157b3c8-3a3e-4ea9-894b-9c8a6&quot;, &quot;templateId&quot;:&quot;1234&quot;}</para>
            /// </summary>
            [NameInMap("FlashSmsExtras")]
            [Validation(Required=false)]
            public string FlashSmsExtras { get; set; }

            /// <summary>
            /// <para>The data parsing task ID. [Deprecated]</para>
            /// 
            /// <b>Example:</b>
            /// <para>e37d28cb-0413-4816-85ed-fd354d025ea3</para>
            /// </summary>
            [NameInMap("JobDataParsingTaskId")]
            [Validation(Required=false)]
            public string JobDataParsingTaskId { get; set; }

            /// <summary>
            /// <para>The job file path. [Deprecated]</para>
            /// 
            /// <b>Example:</b>
            /// <para>UPLOADED/JOB/d481cebe-0bb6-4d13-9649-42ce5074fb75/6c7d9132-98e1-4f08-8a76-8a266c7532fd_job_template - 副本.xlsx</para>
            /// </summary>
            [NameInMap("JobFilePath")]
            [Validation(Required=false)]
            public string JobFilePath { get; set; }

            /// <summary>
            /// <para>The job group description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>催收的作业组</para>
            /// </summary>
            [NameInMap("JobGroupDescription")]
            [Validation(Required=false)]
            public string JobGroupDescription { get; set; }

            /// <summary>
            /// <para>The job group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c62e6789-28a8-41db-941e-171a01d3b3b9</para>
            /// </summary>
            [NameInMap("JobGroupId")]
            [Validation(Required=false)]
            public string JobGroupId { get; set; }

            /// <summary>
            /// <para>The job group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>第一个催收</para>
            /// </summary>
            [NameInMap("JobGroupName")]
            [Validation(Required=false)]
            public string JobGroupName { get; set; }

            /// <summary>
            /// <para>The minimum number of concurrent calls to reserve for this job group. The sum of this value for all job groups with the same priority cannot exceed the total concurrency of the instance. If set to 0, the system dynamically allocates idle lines from a shared pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MinConcurrency")]
            [Validation(Required=false)]
            public long? MinConcurrency { get; set; }

            /// <summary>
            /// <para>The modification time.</para>
            /// <remarks>
            /// <para>Call the <c>DescribeJobGroup</c> operation to obtain this value.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1628425608429</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The job group priority. Valid values:</para>
            /// <para><c>Urgent</c>: For high-priority jobs. <c>Daily</c>: For standard-priority jobs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Daily</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            /// <summary>
            /// <para>The recall strategy.</para>
            /// </summary>
            [NameInMap("RecallStrategy")]
            [Validation(Required=false)]
            public ModifyJobGroupResponseBodyJobGroupRecallStrategy RecallStrategy { get; set; }
            public class ModifyJobGroupResponseBodyJobGroupRecallStrategy : TeaModel {
                /// <summary>
                /// <para>Indicates whether to ignore an invalid number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("EmptyNumberIgnore")]
                [Validation(Required=false)]
                public bool? EmptyNumberIgnore { get; set; }

                /// <summary>
                /// <para>Indicates whether to ignore a number in arrears.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("InArrearsIgnore")]
                [Validation(Required=false)]
                public bool? InArrearsIgnore { get; set; }

                /// <summary>
                /// <para>Indicates whether to ignore an out-of-service number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("OutOfServiceIgnore")]
                [Validation(Required=false)]
                public bool? OutOfServiceIgnore { get; set; }

            }

            /// <summary>
            /// <para>The ringing duration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>25</para>
            /// </summary>
            [NameInMap("RingingDuration")]
            [Validation(Required=false)]
            public long? RingingDuration { get; set; }

            /// <summary>
            /// <para>The scenario ID.</para>
            /// <remarks>
            /// <para>This parameter is deprecated. To obtain the <c>ScriptId</c>, call the <c>DescribeJobGroup</c> operation.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>6cea9bed-63e6-439e-ae4c-b3333efff53d</para>
            /// </summary>
            [NameInMap("ScenarioId")]
            [Validation(Required=false)]
            public string ScenarioId { get; set; }

            /// <summary>
            /// <para>The script name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>话术</para>
            /// </summary>
            [NameInMap("ScriptName")]
            [Validation(Required=false)]
            public string ScriptName { get; set; }

            /// <summary>
            /// <para>The script version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1628425608429</para>
            /// </summary>
            [NameInMap("ScriptVersion")]
            [Validation(Required=false)]
            public string ScriptVersion { get; set; }

            /// <summary>
            /// <para>The job group status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Scheduling</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The outbound strategy.</para>
            /// </summary>
            [NameInMap("Strategy")]
            [Validation(Required=false)]
            public ModifyJobGroupResponseBodyJobGroupStrategy Strategy { get; set; }
            public class ModifyJobGroupResponseBodyJobGroupStrategy : TeaModel {
                /// <summary>
                /// <para>The customized strategy data. [Deprecated]</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("Customized")]
                [Validation(Required=false)]
                public string Customized { get; set; }

                /// <summary>
                /// <para>The end time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2209702074000</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>The action to take when the execution cycle ends. [Deprecated]</para>
                /// 
                /// <b>Example:</b>
                /// <para>CONTINUE</para>
                /// </summary>
                [NameInMap("FollowUpStrategy")]
                [Validation(Required=false)]
                public string FollowUpStrategy { get; set; }

                /// <summary>
                /// <para>Indicates whether the strategy is a template. [Deprecated]</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsTemplate")]
                [Validation(Required=false)]
                public bool? IsTemplate { get; set; }

                /// <summary>
                /// <para>The maximum attempts per day.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("MaxAttemptsPerDay")]
                [Validation(Required=false)]
                public int? MaxAttemptsPerDay { get; set; }

                /// <summary>
                /// <para>The minimum attempt interval.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("MinAttemptInterval")]
                [Validation(Required=false)]
                public int? MinAttemptInterval { get; set; }

                /// <summary>
                /// <para>The repeat mode. Valid values: <c>Once</c> (runs only once), <c>Day</c> (repeats daily), <c>Week</c> (repeats weekly), and <c>Month</c> (repeats monthly).</para>
                /// 
                /// <b>Example:</b>
                /// <para>Once</para>
                /// </summary>
                [NameInMap("RepeatBy")]
                [Validation(Required=false)]
                public string RepeatBy { get; set; }

                /// <summary>
                /// <para>The days of the week or month on which the job repeats.</para>
                /// <para>If <c>RepeatBy</c> is set to <c>Week</c>, valid values are <c>0</c> to <c>6</c>, where <c>0</c> represents Sunday, and <c>1</c> to <c>6</c> represent Monday to Saturday.
                /// If <c>RepeatBy</c> is set to <c>Month</c>, valid values are <c>1</c> to <c>31</c>. If a month is shorter than the specified day (for example, day 31 in February), the job does not run that month.</para>
                /// </summary>
                [NameInMap("RepeatDays")]
                [Validation(Required=false)]
                public List<string> RepeatDays { get; set; }

                /// <summary>
                /// <para>The routing strategy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>LocalFirst</para>
                /// </summary>
                [NameInMap("RoutingStrategy")]
                [Validation(Required=false)]
                public string RoutingStrategy { get; set; }

                /// <summary>
                /// <para>The start time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1578550074000</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <para>The strategy description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>催收作业执行策略</para>
                /// </summary>
                [NameInMap("StrategyDescription")]
                [Validation(Required=false)]
                public string StrategyDescription { get; set; }

                /// <summary>
                /// <para>The strategy ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>f718798d-96be-40e4-bef6-317b54855708</para>
                /// </summary>
                [NameInMap("StrategyId")]
                [Validation(Required=false)]
                public string StrategyId { get; set; }

                /// <summary>
                /// <para>The strategy name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>催收策略</para>
                /// </summary>
                [NameInMap("StrategyName")]
                [Validation(Required=false)]
                public string StrategyName { get; set; }

                /// <summary>
                /// <para>The strategy type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Repeatable</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The time windows for making outbound calls.</para>
                /// </summary>
                [NameInMap("WorkingTime")]
                [Validation(Required=false)]
                public List<ModifyJobGroupResponseBodyJobGroupStrategyWorkingTime> WorkingTime { get; set; }
                public class ModifyJobGroupResponseBodyJobGroupStrategyWorkingTime : TeaModel {
                    /// <summary>
                    /// <para>The start time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>09:00:00</para>
                    /// </summary>
                    [NameInMap("BeginTime")]
                    [Validation(Required=false)]
                    public string BeginTime { get; set; }

                    /// <summary>
                    /// <para>The end time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12:00:00</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The API response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
