// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListJobGroupsAsyncResponseBody : TeaModel {
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

        [NameInMap("JobGroups")]
        [Validation(Required=false)]
        public List<ListJobGroupsAsyncResponseBodyJobGroups> JobGroups { get; set; }
        public class ListJobGroupsAsyncResponseBodyJobGroups : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1640316786259</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public long? CreationTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("ExportProgress")]
            [Validation(Required=false)]
            public ListJobGroupsAsyncResponseBodyJobGroupsExportProgress ExportProgress { get; set; }
            public class ListJobGroupsAsyncResponseBodyJobGroupsExportProgress : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>http://</para>
                /// </summary>
                [NameInMap("FileHttpUrl")]
                [Validation(Required=false)]
                public string FileHttpUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public string Progress { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PENDING</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
            /// </summary>
            [NameInMap("JobDataParsingTaskId")]
            [Validation(Required=false)]
            public string JobDataParsingTaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("JobGroupDescription")]
            [Validation(Required=false)]
            public string JobGroupDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
            /// </summary>
            [NameInMap("JobGroupId")]
            [Validation(Required=false)]
            public string JobGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("JobGroupName")]
            [Validation(Required=false)]
            public string JobGroupName { get; set; }

            [NameInMap("MinConcurrency")]
            [Validation(Required=false)]
            public int? MinConcurrency { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1640316786259</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public ListJobGroupsAsyncResponseBodyJobGroupsProgress Progress { get; set; }
            public class ListJobGroupsAsyncResponseBodyJobGroupsProgress : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("CancelledNum")]
                [Validation(Required=false)]
                public int? CancelledNum { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("ExecutingNum")]
                [Validation(Required=false)]
                public int? ExecutingNum { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("FailedNum")]
                [Validation(Required=false)]
                public int? FailedNum { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("PausedNum")]
                [Validation(Required=false)]
                public int? PausedNum { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Scheduling")]
                [Validation(Required=false)]
                public int? Scheduling { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1640316786259</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TotalCompleted")]
                [Validation(Required=false)]
                public int? TotalCompleted { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("TotalJobs")]
                [Validation(Required=false)]
                public int? TotalJobs { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TotalNotAnswered")]
                [Validation(Required=false)]
                public int? TotalNotAnswered { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
            /// </summary>
            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("ScriptName")]
            [Validation(Required=false)]
            public string ScriptName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>111</para>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Strategy")]
            [Validation(Required=false)]
            public ListJobGroupsAsyncResponseBodyJobGroupsStrategy Strategy { get; set; }
            public class ListJobGroupsAsyncResponseBodyJobGroupsStrategy : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1640316786259</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1640316786259</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCallNum")]
            [Validation(Required=false)]
            public int? TotalCallNum { get; set; }

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
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public bool? Timeout { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Vaild")]
        [Validation(Required=false)]
        public bool? Vaild { get; set; }

    }

}
