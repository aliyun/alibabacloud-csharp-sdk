// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops_rdc20200303.Models
{
    public class GetTaskListFilterResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("Object")]
        [Validation(Required=false)]
        public GetTaskListFilterResponseBodyObject Object { get; set; }
        public class GetTaskListFilterResponseBodyObject : TeaModel {
            [NameInMap("NextPageToken")]
            [Validation(Required=false)]
            public string NextPageToken { get; set; }
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<GetTaskListFilterResponseBodyObjectResult> Result { get; set; }
            public class GetTaskListFilterResponseBodyObjectResult : TeaModel {
                public string ProjectId { get; set; }
                public bool? IsTopInProject { get; set; }
                public GetTaskListFilterResponseBodyObjectResultBadges Badges { get; set; }
                public class GetTaskListFilterResponseBodyObjectResultBadges : TeaModel {
                    [NameInMap("LikesCount")]
                    [Validation(Required=false)]
                    public int? LikesCount { get; set; }

                    [NameInMap("ObjectlinksCount")]
                    [Validation(Required=false)]
                    public int? ObjectlinksCount { get; set; }

                    [NameInMap("AttachmentsCount")]
                    [Validation(Required=false)]
                    public int? AttachmentsCount { get; set; }

                    [NameInMap("CommentsCount")]
                    [Validation(Required=false)]
                    public int? CommentsCount { get; set; }

                }
                public List<string> AncestorIds { get; set; }
                public int? ShareStatus { get; set; }
                public GetTaskListFilterResponseBodyObjectResultReminder Reminder { get; set; }
                public class GetTaskListFilterResponseBodyObjectResultReminder : TeaModel {
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("Members")]
                    [Validation(Required=false)]
                    public List<string> Members { get; set; }

                    [NameInMap("Date")]
                    [Validation(Required=false)]
                    public string Date { get; set; }

                    [NameInMap("CreatorId")]
                    [Validation(Required=false)]
                    public string CreatorId { get; set; }

                    [NameInMap("Rules")]
                    [Validation(Required=false)]
                    public List<string> Rules { get; set; }

                }
                public string Note { get; set; }
                public string Updated { get; set; }
                public bool? IsArchived { get; set; }
                public string Content { get; set; }
                public int? Rating { get; set; }
                public string TaskFlowStatusId { get; set; }
                public int? Progress { get; set; }
                public GetTaskListFilterResponseBodyObjectResultStage Stage { get; set; }
                public class GetTaskListFilterResponseBodyObjectResultStage : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                }
                public List<string> Labels { get; set; }
                public int? Pos { get; set; }
                public string StartDate { get; set; }
                public string Sprint { get; set; }
                public string CreatorId { get; set; }
                public string SourceId { get; set; }
                public string OrganizationId { get; set; }
                public string SourceDate { get; set; }
                public bool? IsFavorite { get; set; }
                public string ExecutorId { get; set; }
                public GetTaskListFilterResponseBodyObjectResultWorkTime WorkTime { get; set; }
                public class GetTaskListFilterResponseBodyObjectResultWorkTime : TeaModel {
                    [NameInMap("UsedTime")]
                    [Validation(Required=false)]
                    public int? UsedTime { get; set; }

                    [NameInMap("TotalTime")]
                    [Validation(Required=false)]
                    public int? TotalTime { get; set; }

                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                }
                public List<string> TagIds { get; set; }
                public int? Priority { get; set; }
                public string ScenariofFeldConfigId { get; set; }
                public GetTaskListFilterResponseBodyObjectResultCreator Creator { get; set; }
                public class GetTaskListFilterResponseBodyObjectResultCreator : TeaModel {
                    [NameInMap("AvatarUrl")]
                    [Validation(Required=false)]
                    public string AvatarUrl { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                }
                public GetTaskListFilterResponseBodyObjectResultExecutor Executor { get; set; }
                public class GetTaskListFilterResponseBodyObjectResultExecutor : TeaModel {
                    [NameInMap("AvatarUrl")]
                    [Validation(Required=false)]
                    public string AvatarUrl { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                }
                public string Accomplished { get; set; }
                public string TaskListId { get; set; }
                public List<string> InvolveMembers { get; set; }
                public int? UniqueId { get; set; }
                public GetTaskListFilterResponseBodyObjectResultTaskFlowStatus TaskFlowStatus { get; set; }
                public class GetTaskListFilterResponseBodyObjectResultTaskFlowStatus : TeaModel {
                    [NameInMap("TaskFlowId")]
                    [Validation(Required=false)]
                    public string TaskFlowId { get; set; }

                    [NameInMap("Pos")]
                    [Validation(Required=false)]
                    public int? Pos { get; set; }

                    [NameInMap("Kind")]
                    [Validation(Required=false)]
                    public string Kind { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                }
                public int? CommentsCount { get; set; }
                public string Recurrence { get; set; }
                public string ObjectType { get; set; }
                public GetTaskListFilterResponseBodyObjectResultSubtaskCount SubtaskCount { get; set; }
                public class GetTaskListFilterResponseBodyObjectResultSubtaskCount : TeaModel {
                    [NameInMap("Done")]
                    [Validation(Required=false)]
                    public int? Done { get; set; }

                    [NameInMap("Total")]
                    [Validation(Required=false)]
                    public int? Total { get; set; }

                }
                public string UntilDate { get; set; }
                public string StoryPoint { get; set; }
                public int? ObjectlinksCount { get; set; }
                public string Source { get; set; }
                public int? LikesCount { get; set; }
                public string StageId { get; set; }
                public List<string> Divisions { get; set; }
                public string Visible { get; set; }
                public bool? IsDone { get; set; }
                public string Parent { get; set; }
                public string SprintId { get; set; }
                public string DueDate { get; set; }
                public int? AttachmentsCount { get; set; }
                public List<GetTaskListFilterResponseBodyObjectResultCustomfields> Customfields { get; set; }
                public class GetTaskListFilterResponseBodyObjectResultCustomfields : TeaModel {
                    public string Type { get; set; }
                    public List<GetTaskListFilterResponseBodyObjectResultCustomfieldsValue> Value { get; set; }
                    public class GetTaskListFilterResponseBodyObjectResultCustomfieldsValue : TeaModel {
                        public string Title { get; set; }
                        public string Id { get; set; }
                    }
                    public string Values { get; set; }
                    public string CustomfieldId { get; set; }
                }
                public string Created { get; set; }
                public string TaskUniqueId { get; set; }
                public string TaskId { get; set; }
                public string Id { get; set; }
            }
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }
        };

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Successful")]
        [Validation(Required=false)]
        public string Successful { get; set; }

    }

}
