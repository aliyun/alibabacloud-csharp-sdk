// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops_rdc20200303.Models
{
    public class GetTaskDetailBaseResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("Object")]
        [Validation(Required=false)]
        public GetTaskDetailBaseResponseBodyObject Object { get; set; }
        public class GetTaskDetailBaseResponseBodyObject : TeaModel {
            [NameInMap("Organization")]
            [Validation(Required=false)]
            public string Organization { get; set; }
            [NameInMap("ScenariofieldconfigId")]
            [Validation(Required=false)]
            public string ScenariofieldconfigId { get; set; }
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }
            [NameInMap("IsTopInProject")]
            [Validation(Required=false)]
            public bool? IsTopInProject { get; set; }
            [NameInMap("Tasklist")]
            [Validation(Required=false)]
            public GetTaskDetailBaseResponseBodyObjectTasklist Tasklist { get; set; }
            public class GetTaskDetailBaseResponseBodyObjectTasklist : TeaModel {
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

            }
            [NameInMap("Badges")]
            [Validation(Required=false)]
            public GetTaskDetailBaseResponseBodyObjectBadges Badges { get; set; }
            public class GetTaskDetailBaseResponseBodyObjectBadges : TeaModel {
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
            [NameInMap("AncestorIds")]
            [Validation(Required=false)]
            public List<string> AncestorIds { get; set; }
            [NameInMap("ShareStatus")]
            [Validation(Required=false)]
            public int? ShareStatus { get; set; }
            [NameInMap("Reminder")]
            [Validation(Required=false)]
            public GetTaskDetailBaseResponseBodyObjectReminder Reminder { get; set; }
            public class GetTaskDetailBaseResponseBodyObjectReminder : TeaModel {
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Members")]
                [Validation(Required=false)]
                public List<string> Members { get; set; }

                [NameInMap("Date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                [NameInMap("MemberRoles")]
                [Validation(Required=false)]
                public List<string> MemberRoles { get; set; }

                [NameInMap("Method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                [NameInMap("CreatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                [NameInMap("Rules")]
                [Validation(Required=false)]
                public List<string> Rules { get; set; }

            }
            [NameInMap("Ancestors")]
            [Validation(Required=false)]
            public List<string> Ancestors { get; set; }
            [NameInMap("TaskflowstatusId")]
            [Validation(Required=false)]
            public string TaskflowstatusId { get; set; }
            [NameInMap("Updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }
            [NameInMap("Note")]
            [Validation(Required=false)]
            public string Note { get; set; }
            [NameInMap("IsArchived")]
            [Validation(Required=false)]
            public bool? IsArchived { get; set; }
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }
            [NameInMap("Rating")]
            [Validation(Required=false)]
            public int? Rating { get; set; }
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }
            [NameInMap("Stage")]
            [Validation(Required=false)]
            public GetTaskDetailBaseResponseBodyObjectStage Stage { get; set; }
            public class GetTaskDetailBaseResponseBodyObjectStage : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

            }
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<string> Labels { get; set; }
            [NameInMap("StartDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }
            [NameInMap("Sprint")]
            [Validation(Required=false)]
            public string Sprint { get; set; }
            [NameInMap("CreatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }
            [NameInMap("SourceId")]
            [Validation(Required=false)]
            public string SourceId { get; set; }
            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }
            [NameInMap("SourceDate")]
            [Validation(Required=false)]
            public string SourceDate { get; set; }
            [NameInMap("IsFavorite")]
            [Validation(Required=false)]
            public bool? IsFavorite { get; set; }
            [NameInMap("ExecutorId")]
            [Validation(Required=false)]
            public string ExecutorId { get; set; }
            [NameInMap("Scenariofieldconfig")]
            [Validation(Required=false)]
            public GetTaskDetailBaseResponseBodyObjectScenariofieldconfig Scenariofieldconfig { get; set; }
            public class GetTaskDetailBaseResponseBodyObjectScenariofieldconfig : TeaModel {
                [NameInMap("Icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                [NameInMap("ProTemplateConfigType")]
                [Validation(Required=false)]
                public string ProTemplateConfigType { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

            }
            [NameInMap("WorkTime")]
            [Validation(Required=false)]
            public GetTaskDetailBaseResponseBodyObjectWorkTime WorkTime { get; set; }
            public class GetTaskDetailBaseResponseBodyObjectWorkTime : TeaModel {
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
            [NameInMap("TagIds")]
            [Validation(Required=false)]
            public List<string> TagIds { get; set; }
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public GetTaskDetailBaseResponseBodyObjectCreator Creator { get; set; }
            public class GetTaskDetailBaseResponseBodyObjectCreator : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

            }
            [NameInMap("Executor")]
            [Validation(Required=false)]
            public GetTaskDetailBaseResponseBodyObjectExecutor Executor { get; set; }
            public class GetTaskDetailBaseResponseBodyObjectExecutor : TeaModel {
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
            [NameInMap("Accomplished")]
            [Validation(Required=false)]
            public string Accomplished { get; set; }
            [NameInMap("InvolveMembers")]
            [Validation(Required=false)]
            public List<string> InvolveMembers { get; set; }
            [NameInMap("UniqueId")]
            [Validation(Required=false)]
            public int? UniqueId { get; set; }
            [NameInMap("CommentsCount")]
            [Validation(Required=false)]
            public int? CommentsCount { get; set; }
            [NameInMap("Recurrence")]
            [Validation(Required=false)]
            public string Recurrence { get; set; }
            [NameInMap("ObjectType")]
            [Validation(Required=false)]
            public string ObjectType { get; set; }
            [NameInMap("SubtaskCount")]
            [Validation(Required=false)]
            public GetTaskDetailBaseResponseBodyObjectSubtaskCount SubtaskCount { get; set; }
            public class GetTaskDetailBaseResponseBodyObjectSubtaskCount : TeaModel {
                [NameInMap("Done")]
                [Validation(Required=false)]
                public int? Done { get; set; }

                [NameInMap("Total")]
                [Validation(Required=false)]
                public int? Total { get; set; }

            }
            [NameInMap("UntilDate")]
            [Validation(Required=false)]
            public string UntilDate { get; set; }
            [NameInMap("StoryPoint")]
            [Validation(Required=false)]
            public string StoryPoint { get; set; }
            [NameInMap("ObjectlinksCount")]
            [Validation(Required=false)]
            public int? ObjectlinksCount { get; set; }
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }
            [NameInMap("LikesCount")]
            [Validation(Required=false)]
            public int? LikesCount { get; set; }
            [NameInMap("StageId")]
            [Validation(Required=false)]
            public string StageId { get; set; }
            [NameInMap("Divisions")]
            [Validation(Required=false)]
            public List<string> Divisions { get; set; }
            [NameInMap("Visible")]
            [Validation(Required=false)]
            public string Visible { get; set; }
            [NameInMap("IsDone")]
            [Validation(Required=false)]
            public bool? IsDone { get; set; }
            [NameInMap("Involvers")]
            [Validation(Required=false)]
            public List<GetTaskDetailBaseResponseBodyObjectInvolvers> Involvers { get; set; }
            public class GetTaskDetailBaseResponseBodyObjectInvolvers : TeaModel {
                public string Name { get; set; }
                public string Id { get; set; }
            }
            [NameInMap("Parent")]
            [Validation(Required=false)]
            public string Parent { get; set; }
            [NameInMap("SprintId")]
            [Validation(Required=false)]
            public string SprintId { get; set; }
            [NameInMap("DueDate")]
            [Validation(Required=false)]
            public string DueDate { get; set; }
            [NameInMap("AttachmentsCount")]
            [Validation(Required=false)]
            public int? AttachmentsCount { get; set; }
            [NameInMap("Subtasks")]
            [Validation(Required=false)]
            public List<GetTaskDetailBaseResponseBodyObjectSubtasks> Subtasks { get; set; }
            public class GetTaskDetailBaseResponseBodyObjectSubtasks : TeaModel {
                public string Content { get; set; }
                public string Id { get; set; }
            }
            [NameInMap("Customfields")]
            [Validation(Required=false)]
            public List<GetTaskDetailBaseResponseBodyObjectCustomfields> Customfields { get; set; }
            public class GetTaskDetailBaseResponseBodyObjectCustomfields : TeaModel {
                public string Type { get; set; }
                public List<GetTaskDetailBaseResponseBodyObjectCustomfieldsValue> Value { get; set; }
                public class GetTaskDetailBaseResponseBodyObjectCustomfieldsValue : TeaModel {
                    public string Title { get; set; }
                    public string Id { get; set; }
                }
                public List<string> Values { get; set; }
                public string CustomfieldId { get; set; }
            }
            [NameInMap("Created")]
            [Validation(Required=false)]
            public string Created { get; set; }
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }
            [NameInMap("Taskflowstatus")]
            [Validation(Required=false)]
            public GetTaskDetailBaseResponseBodyObjectTaskflowstatus Taskflowstatus { get; set; }
            public class GetTaskDetailBaseResponseBodyObjectTaskflowstatus : TeaModel {
                [NameInMap("TaskflowId")]
                [Validation(Required=false)]
                public string TaskflowId { get; set; }

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
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
        };

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Successful")]
        [Validation(Required=false)]
        public bool? Successful { get; set; }

    }

}
