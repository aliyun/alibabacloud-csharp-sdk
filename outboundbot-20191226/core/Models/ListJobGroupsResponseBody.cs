// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListJobGroupsResponseBody : TeaModel {
        [NameInMap("AsyncTaskId")]
        [Validation(Required=false)]
        public string AsyncTaskId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public long? CreationTime { get; set; }

                [NameInMap("ExportProgress")]
                [Validation(Required=false)]
                public ListJobGroupsResponseBodyJobGroupsListExportProgress ExportProgress { get; set; }
                public class ListJobGroupsResponseBodyJobGroupsListExportProgress : TeaModel {
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
                public ListJobGroupsResponseBodyJobGroupsListProgress Progress { get; set; }
                public class ListJobGroupsResponseBodyJobGroupsListProgress : TeaModel {
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
                public ListJobGroupsResponseBodyJobGroupsListStrategy Strategy { get; set; }
                public class ListJobGroupsResponseBodyJobGroupsListStrategy : TeaModel {
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

            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
