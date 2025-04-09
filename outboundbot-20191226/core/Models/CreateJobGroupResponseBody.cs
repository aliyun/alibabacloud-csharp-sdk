// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class CreateJobGroupResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("JobGroup")]
        [Validation(Required=false)]
        public CreateJobGroupResponseBodyJobGroup JobGroup { get; set; }
        public class CreateJobGroupResponseBodyJobGroup : TeaModel {
            [NameInMap("CallingNumbers")]
            [Validation(Required=false)]
            public List<string> CallingNumbers { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1578550074361</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public long? CreationTime { get; set; }

            [NameInMap("ExportProgress")]
            [Validation(Required=false)]
            public CreateJobGroupResponseBodyJobGroupExportProgress ExportProgress { get; set; }
            public class CreateJobGroupResponseBodyJobGroupExportProgress : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>https://***.oss-cn-shanghai.aliyuncs.com/sample</para>
                /// </summary>
                [NameInMap("FileHttpUrl")]
                [Validation(Required=false)]
                public string FileHttpUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public string Progress { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>FINISHED</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>744ff448-2b4c-40d4-94ca-51f246905b0f</para>
            /// </summary>
            [NameInMap("JobDataParsingTaskId")]
            [Validation(Required=false)]
            public string JobDataParsingTaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>UPLOADED/JOB/b3865dc3-40fa-4afd-9fe4-dc7cda305a24/229eac13-379d-4abe-96e0-8cf026b56c0b_template (1).xlsx</para>
            /// </summary>
            [NameInMap("JobFilePath")]
            [Validation(Required=false)]
            public string JobFilePath { get; set; }

            [NameInMap("JobGroupDescription")]
            [Validation(Required=false)]
            public string JobGroupDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>c62e6789-28a8-41db-941e-171a01d3b3b9</para>
            /// </summary>
            [NameInMap("JobGroupId")]
            [Validation(Required=false)]
            public string JobGroupId { get; set; }

            [NameInMap("JobGroupName")]
            [Validation(Required=false)]
            public string JobGroupName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MinConcurrency")]
            [Validation(Required=false)]
            public long? MinConcurrency { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1628425608429</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            [NameInMap("RecallCallingNumbers")]
            [Validation(Required=false)]
            public List<string> RecallCallingNumbers { get; set; }

            [NameInMap("RecallStrategy")]
            [Validation(Required=false)]
            public CreateJobGroupResponseBodyJobGroupRecallStrategy RecallStrategy { get; set; }
            public class CreateJobGroupResponseBodyJobGroupRecallStrategy : TeaModel {
                [NameInMap("EmptyNumberIgnore")]
                [Validation(Required=false)]
                public bool? EmptyNumberIgnore { get; set; }

                [NameInMap("InArrearsIgnore")]
                [Validation(Required=false)]
                public bool? InArrearsIgnore { get; set; }

                [NameInMap("OutOfServiceIgnore")]
                [Validation(Required=false)]
                public bool? OutOfServiceIgnore { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("RingingDuration")]
            [Validation(Required=false)]
            public long? RingingDuration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6cea9bed-63e6-439e-ae4c-b3333efff53d</para>
            /// </summary>
            [NameInMap("ScenarioId")]
            [Validation(Required=false)]
            public string ScenarioId { get; set; }

            [NameInMap("ScriptName")]
            [Validation(Required=false)]
            public string ScriptName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1628425608429</para>
            /// </summary>
            [NameInMap("ScriptVersion")]
            [Validation(Required=false)]
            public string ScriptVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Scheduling</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Strategy")]
            [Validation(Required=false)]
            public CreateJobGroupResponseBodyJobGroupStrategy Strategy { get; set; }
            public class CreateJobGroupResponseBodyJobGroupStrategy : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("Customized")]
                [Validation(Required=false)]
                public string Customized { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2209702074000</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CONTINUE</para>
                /// </summary>
                [NameInMap("FollowUpStrategy")]
                [Validation(Required=false)]
                public string FollowUpStrategy { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsTemplate")]
                [Validation(Required=false)]
                public bool? IsTemplate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("MaxAttemptsPerDay")]
                [Validation(Required=false)]
                public int? MaxAttemptsPerDay { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("MinAttemptInterval")]
                [Validation(Required=false)]
                public int? MinAttemptInterval { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Once</para>
                /// </summary>
                [NameInMap("RepeatBy")]
                [Validation(Required=false)]
                public string RepeatBy { get; set; }

                [NameInMap("RepeatDays")]
                [Validation(Required=false)]
                public List<string> RepeatDays { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>LocalFirst</para>
                /// </summary>
                [NameInMap("RoutingStrategy")]
                [Validation(Required=false)]
                public string RoutingStrategy { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1578550074000</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                [NameInMap("StrategyDescription")]
                [Validation(Required=false)]
                public string StrategyDescription { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cc9a436e-03b0-4ada-8364-77ec2290aa39</para>
                /// </summary>
                [NameInMap("StrategyId")]
                [Validation(Required=false)]
                public string StrategyId { get; set; }

                [NameInMap("StrategyName")]
                [Validation(Required=false)]
                public string StrategyName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Repeatable</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("WorkingTime")]
                [Validation(Required=false)]
                public List<CreateJobGroupResponseBodyJobGroupStrategyWorkingTime> WorkingTime { get; set; }
                public class CreateJobGroupResponseBodyJobGroupStrategyWorkingTime : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>09:00:00</para>
                    /// </summary>
                    [NameInMap("BeginTime")]
                    [Validation(Required=false)]
                    public string BeginTime { get; set; }

                    /// <summary>
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
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
