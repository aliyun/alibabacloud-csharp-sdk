// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class TaskDetail : TeaModel {
        /// <summary>
        /// <para>List of job administrators.</para>
        /// </summary>
        [NameInMap("Admins")]
        [Validation(Required=false)]
        public List<SimpleUser> Admins { get; set; }

        /// <summary>
        /// <para>Alert time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12412312</para>
        /// </summary>
        [NameInMap("AlertTime")]
        [Validation(Required=false)]
        public long? AlertTime { get; set; }

        /// <summary>
        /// <para>Indicates whether data appending is allowed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AllowAppendData")]
        [Validation(Required=false)]
        public bool? AllowAppendData { get; set; }

        /// <summary>
        /// <para>Indicates whether the job has been archived.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Archived")]
        [Validation(Required=false)]
        public bool? Archived { get; set; }

        /// <summary>
        /// <para>Data archiving information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("ArchivedInfos")]
        [Validation(Required=false)]
        public string ArchivedInfos { get; set; }

        /// <summary>
        /// <para>Job assignment configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("AssignConfig")]
        [Validation(Required=false)]
        public Dictionary<string, object> AssignConfig { get; set; }

        /// <summary>
        /// <para>Creator information.</para>
        /// </summary>
        [NameInMap("Creator")]
        [Validation(Required=false)]
        public SimpleUser Creator { get; set; }

        /// <summary>
        /// <para>List of Data proxy relationships.</para>
        /// </summary>
        [NameInMap("DatasetProxyRelations")]
        [Validation(Required=false)]
        public List<TaskDetailDatasetProxyRelations> DatasetProxyRelations { get; set; }
        public class TaskDetailDatasetProxyRelations : TeaModel {
            /// <summary>
            /// <para>Dataset ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>102***124</para>
            /// </summary>
            [NameInMap("DatasetId")]
            [Validation(Required=false)]
            public string DatasetId { get; set; }

            /// <summary>
            /// <para>Dataset type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LABEL</para>
            /// </summary>
            [NameInMap("DatasetType")]
            [Validation(Required=false)]
            public string DatasetType { get; set; }

            /// <summary>
            /// <para>Additional information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Exif")]
            [Validation(Required=false)]
            public Dictionary<string, object> Exif { get; set; }

            /// <summary>
            /// <para>Dataset source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PAI</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>Source business ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d-24eyimdzdn4a98jktk</para>
            /// </summary>
            [NameInMap("SourceBizId")]
            [Validation(Required=false)]
            public string SourceBizId { get; set; }

            /// <summary>
            /// <para>Source dataset ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2312124</para>
            /// </summary>
            [NameInMap("SourceDatasetId")]
            [Validation(Required=false)]
            public string SourceDatasetId { get; set; }

        }

        /// <summary>
        /// <para>Additional configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("Exif")]
        [Validation(Required=false)]
        public Dictionary<string, object> Exif { get; set; }

        /// <summary>
        /// <para>Creation UTC time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-04 11:42:57</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>UTC time of the last modification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-08-16 18:38:42</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>Annotation style.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("LabelStyle")]
        [Validation(Required=false)]
        public string LabelStyle { get; set; }

        /// <summary>
        /// <para>My configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("MineConfigs")]
        [Validation(Required=false)]
        public Dictionary<string, object> MineConfigs { get; set; }

        /// <summary>
        /// <para>Updated By information.</para>
        /// </summary>
        [NameInMap("Modifier")]
        [Validation(Required=false)]
        public SimpleUser Modifier { get; set; }

        /// <summary>
        /// <para>Notice configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;DingHook&quot;:&quot;&quot;,&quot;ListenActions&quot;:[],&quot;SubTaskAlertGap&quot;:&quot;&quot;}</para>
        /// </summary>
        [NameInMap("NoticeConfig")]
        [Validation(Required=false)]
        public Dictionary<string, object> NoticeConfig { get; set; }

        /// <summary>
        /// <para>Time configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;periodConfigId&quot;:&quot;&quot;,&quot;status&quot;:&quot;&quot;}</para>
        /// </summary>
        [NameInMap("PeriodConfig")]
        [Validation(Required=false)]
        public Dictionary<string, object> PeriodConfig { get; set; }

        /// <summary>
        /// <para>Auto triggered task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12312414</para>
        /// </summary>
        [NameInMap("RefTaskId")]
        [Validation(Required=false)]
        public string RefTaskId { get; set; }

        /// <summary>
        /// <para>Related job configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("RelateTaskConfig")]
        [Validation(Required=false)]
        public Dictionary<string, object> RelateTaskConfig { get; set; }

        /// <summary>
        /// <para>Remark information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>Result callback configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;RetMsgMode&quot;:&quot;&quot;,&quot;Exif&quot;:{}}</para>
        /// </summary>
        [NameInMap("ResultCallbackConfig")]
        [Validation(Required=false)]
        public Dictionary<string, object> ResultCallbackConfig { get; set; }

        /// <summary>
        /// <para>Current edge zone. Possible values:</para>
        /// <list type="bullet">
        /// <item><description>MARK: Annotating.</description></item>
        /// <item><description>CHECK: Checking.</description></item>
        /// <item><description>SAMPLING: Validating.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MARK</para>
        /// </summary>
        [NameInMap("Stage")]
        [Validation(Required=false)]
        public string Stage { get; set; }

        /// <summary>
        /// <para>Task Status. Possible values:</para>
        /// <list type="bullet">
        /// <item><description>CREATED</description></item>
        /// <item><description>SUCCESS</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CREATED</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>List of job tags.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// <para>Job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15438***8306500608</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>Task Name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试任务</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>Supplementary configuration for the Job template.</para>
        /// </summary>
        [NameInMap("TaskTemplateConfig")]
        [Validation(Required=false)]
        public TaskDetailTaskTemplateConfig TaskTemplateConfig { get; set; }
        public class TaskDetailTaskTemplateConfig : TeaModel {
            /// <summary>
            /// <para>Additional information for template configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Exif")]
            [Validation(Required=false)]
            public Dictionary<string, object> Exif { get; set; }

            /// <summary>
            /// <para>Resource key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>picture1</para>
            /// </summary>
            [NameInMap("ResourceKey")]
            [Validation(Required=false)]
            public string ResourceKey { get; set; }

            /// <summary>
            /// <para>Robot configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("RobotConfig")]
            [Validation(Required=false)]
            public Dictionary<string, object> RobotConfig { get; set; }

            /// <summary>
            /// <para>If the number of questions in the Job is less than that in the template, you can select the required questions from the List.</para>
            /// </summary>
            [NameInMap("SelectQuestions")]
            [Validation(Required=false)]
            public List<string> SelectQuestions { get; set; }

            /// <summary>
            /// <para>Options configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;1&quot;:[{&quot;label&quot;:&quot;label1&quot;,&quot;key&quot;:&quot;label1&quot;}]}</para>
            /// </summary>
            [NameInMap("TemplateOptionMap")]
            [Validation(Required=false)]
            public Dictionary<string, object> TemplateOptionMap { get; set; }

            /// <summary>
            /// <para>Template relation ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("TemplateRelationId")]
            [Validation(Required=false)]
            public string TemplateRelationId { get; set; }

        }

        /// <summary>
        /// <para>Task Type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// <para>List of job stream configurations.</para>
        /// </summary>
        [NameInMap("TaskWorkflow")]
        [Validation(Required=false)]
        public List<TaskDetailTaskWorkflow> TaskWorkflow { get; set; }
        public class TaskDetailTaskWorkflow : TeaModel {
            /// <summary>
            /// <para>Extra information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Exif")]
            [Validation(Required=false)]
            public Dictionary<string, object> Exif { get; set; }

            /// <summary>
            /// <para>Group list.</para>
            /// </summary>
            [NameInMap("Groups")]
            [Validation(Required=false)]
            public List<string> Groups { get; set; }

            /// <summary>
            /// <para>Edge zone name. Possible values:  </para>
            /// <list type="bullet">
            /// <item><description>MARK  </description></item>
            /// <item><description>CHECK  </description></item>
            /// <item><description>SAMPLING</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MARK</para>
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// <para>User List.</para>
            /// </summary>
            [NameInMap("Users")]
            [Validation(Required=false)]
            public List<SimpleUser> Users { get; set; }

        }

        /// <summary>
        /// <para>Template ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1529***348342353920</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>Tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GA***W134</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>Tenant name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试任务202208101424</para>
        /// </summary>
        [NameInMap("TenantName")]
        [Validation(Required=false)]
        public string TenantName { get; set; }

        /// <summary>
        /// <para>UUID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>paiworkspace-0001</para>
        /// </summary>
        [NameInMap("UUID")]
        [Validation(Required=false)]
        public string UUID { get; set; }

        /// <summary>
        /// <para>Voting configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;1&quot;:{&quot;VoteNum&quot;:1,&quot;MinVote&quot;:1}}</para>
        /// </summary>
        [NameInMap("VoteConfigs")]
        [Validation(Required=false)]
        public Dictionary<string, object> VoteConfigs { get; set; }

        /// <summary>
        /// <para>List of pipeline nodes.</para>
        /// </summary>
        [NameInMap("WorkflowNodes")]
        [Validation(Required=false)]
        public List<string> WorkflowNodes { get; set; }

        /// <summary>
        /// <para>Run message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx</para>
        /// </summary>
        [NameInMap("runMsg")]
        [Validation(Required=false)]
        public string RunMsg { get; set; }

    }

}
