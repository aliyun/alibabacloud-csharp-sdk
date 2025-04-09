// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListJobGroupsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2bb0cf15-2126-4c9b-bc30-bb5301b96284</para>
        /// </summary>
        [NameInMap("AsyncTaskId")]
        [Validation(Required=false)]
        public string AsyncTaskId { get; set; }

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
        public ListJobGroupsResponseBodyJobGroups JobGroups { get; set; }
        public class ListJobGroupsResponseBodyJobGroups : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListJobGroupsResponseBodyJobGroupsList> List { get; set; }
            public class ListJobGroupsResponseBodyJobGroupsList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1578550074361</para>
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
                public ListJobGroupsResponseBodyJobGroupsListExportProgress ExportProgress { get; set; }
                public class ListJobGroupsResponseBodyJobGroupsListExportProgress : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="http://www.xxx.com/xxx">http://www.xxx.com/xxx</a></para>
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
                /// <para>c62e6789-28a8-41db-941e-171a01d3b3b9</para>
                /// </summary>
                [NameInMap("JobDataParsingTaskId")]
                [Validation(Required=false)]
                public string JobDataParsingTaskId { get; set; }

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

                [NameInMap("MinConcurrency")]
                [Validation(Required=false)]
                public int? MinConcurrency { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1578550074361</para>
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
                public ListJobGroupsResponseBodyJobGroupsListProgress Progress { get; set; }
                public class ListJobGroupsResponseBodyJobGroupsListProgress : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("CancelledNum")]
                    [Validation(Required=false)]
                    public int? CancelledNum { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1578550074361</para>
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public int? Duration { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("ExecutingNum")]
                    [Validation(Required=false)]
                    public int? ExecutingNum { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("FailedNum")]
                    [Validation(Required=false)]
                    public int? FailedNum { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("PausedNum")]
                    [Validation(Required=false)]
                    public int? PausedNum { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Scheduling")]
                    [Validation(Required=false)]
                    public int? Scheduling { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1578550074361</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("TotalCompleted")]
                    [Validation(Required=false)]
                    public int? TotalCompleted { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>20</para>
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
                /// <para>c62e6789-28a8-41db-941e-171a01d3b3b9</para>
                /// </summary>
                [NameInMap("ScriptId")]
                [Validation(Required=false)]
                public string ScriptId { get; set; }

                [NameInMap("ScriptName")]
                [Validation(Required=false)]
                public string ScriptName { get; set; }

                [NameInMap("ScriptVersion")]
                [Validation(Required=false)]
                public string ScriptVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Draft</para>
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
                public ListJobGroupsResponseBodyJobGroupsListStrategy Strategy { get; set; }
                public class ListJobGroupsResponseBodyJobGroupsListStrategy : TeaModel {
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public long? EndTime { get; set; }

                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TotalCallNum")]
                [Validation(Required=false)]
                public int? TotalCallNum { get; set; }

            }

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
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

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
