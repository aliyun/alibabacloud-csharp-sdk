// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ModifyJobGroupResponseBody : TeaModel {
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
        public ModifyJobGroupResponseBodyJobGroup JobGroup { get; set; }
        public class ModifyJobGroupResponseBodyJobGroup : TeaModel {
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
            public ModifyJobGroupResponseBodyJobGroupExportProgress ExportProgress { get; set; }
            public class ModifyJobGroupResponseBodyJobGroupExportProgress : TeaModel {
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

            [NameInMap("FlashSmsExtras")]
            [Validation(Required=false)]
            public string FlashSmsExtras { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>e37d28cb-0413-4816-85ed-fd354d025ea3</para>
            /// </summary>
            [NameInMap("JobDataParsingTaskId")]
            [Validation(Required=false)]
            public string JobDataParsingTaskId { get; set; }

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

            [NameInMap("RecallStrategy")]
            [Validation(Required=false)]
            public ModifyJobGroupResponseBodyJobGroupRecallStrategy RecallStrategy { get; set; }
            public class ModifyJobGroupResponseBodyJobGroupRecallStrategy : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("EmptyNumberIgnore")]
                [Validation(Required=false)]
                public bool? EmptyNumberIgnore { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("InArrearsIgnore")]
                [Validation(Required=false)]
                public bool? InArrearsIgnore { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("OutOfServiceIgnore")]
                [Validation(Required=false)]
                public bool? OutOfServiceIgnore { get; set; }

            }

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
            public ModifyJobGroupResponseBodyJobGroupStrategy Strategy { get; set; }
            public class ModifyJobGroupResponseBodyJobGroupStrategy : TeaModel {
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
                /// <para>10</para>
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
                /// <para>f718798d-96be-40e4-bef6-317b54855708</para>
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
                public List<ModifyJobGroupResponseBodyJobGroupStrategyWorkingTime> WorkingTime { get; set; }
                public class ModifyJobGroupResponseBodyJobGroupStrategyWorkingTime : TeaModel {
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
