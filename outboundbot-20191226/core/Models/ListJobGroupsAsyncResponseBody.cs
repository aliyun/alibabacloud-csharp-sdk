// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListJobGroupsAsyncResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("JobGroups")]
        [Validation(Required=false)]
        public List<ListJobGroupsAsyncResponseBodyJobGroups> JobGroups { get; set; }
        public class ListJobGroupsAsyncResponseBodyJobGroups : TeaModel {
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public long? CreationTime { get; set; }

            [NameInMap("ExportProgress")]
            [Validation(Required=false)]
            public ListJobGroupsAsyncResponseBodyJobGroupsExportProgress ExportProgress { get; set; }
            public class ListJobGroupsAsyncResponseBodyJobGroupsExportProgress : TeaModel {
                [NameInMap("FileHttpUrl")]
                [Validation(Required=false)]
                public string FileHttpUrl { get; set; }

                [NameInMap("Progress")]
                [Validation(Required=false)]
                public string Progress { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("JobDataParsingTaskId")]
            [Validation(Required=false)]
            public string JobDataParsingTaskId { get; set; }

            [NameInMap("JobGroupDescription")]
            [Validation(Required=false)]
            public string JobGroupDescription { get; set; }

            [NameInMap("JobGroupId")]
            [Validation(Required=false)]
            public string JobGroupId { get; set; }

            [NameInMap("JobGroupName")]
            [Validation(Required=false)]
            public string JobGroupName { get; set; }

            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            [NameInMap("Progress")]
            [Validation(Required=false)]
            public ListJobGroupsAsyncResponseBodyJobGroupsProgress Progress { get; set; }
            public class ListJobGroupsAsyncResponseBodyJobGroupsProgress : TeaModel {
                [NameInMap("CancelledNum")]
                [Validation(Required=false)]
                public int? CancelledNum { get; set; }

                [NameInMap("Duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                [NameInMap("ExecutingNum")]
                [Validation(Required=false)]
                public int? ExecutingNum { get; set; }

                [NameInMap("FailedNum")]
                [Validation(Required=false)]
                public int? FailedNum { get; set; }

                [NameInMap("PausedNum")]
                [Validation(Required=false)]
                public int? PausedNum { get; set; }

                [NameInMap("Scheduling")]
                [Validation(Required=false)]
                public int? Scheduling { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TotalCompleted")]
                [Validation(Required=false)]
                public int? TotalCompleted { get; set; }

                [NameInMap("TotalJobs")]
                [Validation(Required=false)]
                public int? TotalJobs { get; set; }

                [NameInMap("TotalNotAnswered")]
                [Validation(Required=false)]
                public int? TotalNotAnswered { get; set; }

            }

            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

            [NameInMap("ScriptName")]
            [Validation(Required=false)]
            public string ScriptName { get; set; }

            [NameInMap("ScriptVersion")]
            [Validation(Required=false)]
            public string ScriptVersion { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Strategy")]
            [Validation(Required=false)]
            public ListJobGroupsAsyncResponseBodyJobGroupsStrategy Strategy { get; set; }
            public class ListJobGroupsAsyncResponseBodyJobGroupsStrategy : TeaModel {
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

            }

            [NameInMap("TotalCallNum")]
            [Validation(Required=false)]
            public int? TotalCallNum { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public bool? Timeout { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("Vaild")]
        [Validation(Required=false)]
        public bool? Vaild { get; set; }

    }

}
