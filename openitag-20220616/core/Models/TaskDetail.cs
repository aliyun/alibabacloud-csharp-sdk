// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class TaskDetail : TeaModel {
        [NameInMap("Admins")]
        [Validation(Required=false)]
        public List<SimpleUser> Admins { get; set; }

        [NameInMap("AlertTime")]
        [Validation(Required=false)]
        public long? AlertTime { get; set; }

        [NameInMap("AllowAppendData")]
        [Validation(Required=false)]
        public bool? AllowAppendData { get; set; }

        [NameInMap("Archived")]
        [Validation(Required=false)]
        public bool? Archived { get; set; }

        [NameInMap("ArchivedInfos")]
        [Validation(Required=false)]
        public string ArchivedInfos { get; set; }

        [NameInMap("AssignConfig")]
        [Validation(Required=false)]
        public Dictionary<string, object> AssignConfig { get; set; }

        [NameInMap("Creator")]
        [Validation(Required=false)]
        public SimpleUser Creator { get; set; }

        [NameInMap("DatasetProxyRelations")]
        [Validation(Required=false)]
        public List<TaskDetailDatasetProxyRelations> DatasetProxyRelations { get; set; }
        public class TaskDetailDatasetProxyRelations : TeaModel {
            [NameInMap("DatasetId")]
            [Validation(Required=false)]
            public string DatasetId { get; set; }

            [NameInMap("DatasetType")]
            [Validation(Required=false)]
            public string DatasetType { get; set; }

            [NameInMap("Exif")]
            [Validation(Required=false)]
            public Dictionary<string, object> Exif { get; set; }

            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("SourceBizId")]
            [Validation(Required=false)]
            public string SourceBizId { get; set; }

            [NameInMap("SourceDatasetId")]
            [Validation(Required=false)]
            public string SourceDatasetId { get; set; }

        }

        [NameInMap("Exif")]
        [Validation(Required=false)]
        public Dictionary<string, object> Exif { get; set; }

        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        [NameInMap("LabelStyle")]
        [Validation(Required=false)]
        public string LabelStyle { get; set; }

        [NameInMap("MineConfigs")]
        [Validation(Required=false)]
        public Dictionary<string, object> MineConfigs { get; set; }

        [NameInMap("Modifier")]
        [Validation(Required=false)]
        public SimpleUser Modifier { get; set; }

        [NameInMap("NoticeConfig")]
        [Validation(Required=false)]
        public Dictionary<string, object> NoticeConfig { get; set; }

        [NameInMap("PeriodConfig")]
        [Validation(Required=false)]
        public Dictionary<string, object> PeriodConfig { get; set; }

        [NameInMap("RefTaskId")]
        [Validation(Required=false)]
        public string RefTaskId { get; set; }

        [NameInMap("RelateTaskConfig")]
        [Validation(Required=false)]
        public Dictionary<string, object> RelateTaskConfig { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("ResultCallbackConfig")]
        [Validation(Required=false)]
        public Dictionary<string, object> ResultCallbackConfig { get; set; }

        [NameInMap("Stage")]
        [Validation(Required=false)]
        public string Stage { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<string> Tags { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        [NameInMap("TaskTemplateConfig")]
        [Validation(Required=false)]
        public TaskDetailTaskTemplateConfig TaskTemplateConfig { get; set; }
        public class TaskDetailTaskTemplateConfig : TeaModel {
            [NameInMap("Exif")]
            [Validation(Required=false)]
            public Dictionary<string, object> Exif { get; set; }

            [NameInMap("ResourceKey")]
            [Validation(Required=false)]
            public string ResourceKey { get; set; }

            [NameInMap("RobotConfig")]
            [Validation(Required=false)]
            public Dictionary<string, object> RobotConfig { get; set; }

            [NameInMap("SelectQuestions")]
            [Validation(Required=false)]
            public List<string> SelectQuestions { get; set; }

            [NameInMap("TemplateOptionMap")]
            [Validation(Required=false)]
            public Dictionary<string, object> TemplateOptionMap { get; set; }

            [NameInMap("TemplateRelationId")]
            [Validation(Required=false)]
            public string TemplateRelationId { get; set; }

        }

        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        [NameInMap("TaskWorkflow")]
        [Validation(Required=false)]
        public List<TaskDetailTaskWorkflow> TaskWorkflow { get; set; }
        public class TaskDetailTaskWorkflow : TeaModel {
            [NameInMap("Exif")]
            [Validation(Required=false)]
            public Dictionary<string, object> Exif { get; set; }

            [NameInMap("Groups")]
            [Validation(Required=false)]
            public List<string> Groups { get; set; }

            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            [NameInMap("Users")]
            [Validation(Required=false)]
            public List<SimpleUser> Users { get; set; }

        }

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("TenantName")]
        [Validation(Required=false)]
        public string TenantName { get; set; }

        [NameInMap("UUID")]
        [Validation(Required=false)]
        public string UUID { get; set; }

        [NameInMap("VoteConfigs")]
        [Validation(Required=false)]
        public Dictionary<string, object> VoteConfigs { get; set; }

        [NameInMap("WorkflowNodes")]
        [Validation(Required=false)]
        public List<string> WorkflowNodes { get; set; }

        [NameInMap("runMsg")]
        [Validation(Required=false)]
        public string RunMsg { get; set; }

    }

}
