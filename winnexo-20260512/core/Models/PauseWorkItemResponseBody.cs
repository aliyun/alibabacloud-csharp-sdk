// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class PauseWorkItemResponseBody : TeaModel {
        /// <summary>
        /// <para>验收标准</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("acceptanceCriteria")]
        [Validation(Required=false)]
        public string AcceptanceCriteria { get; set; }

        /// <summary>
        /// <para>已应用的状态版本</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("appliedStatusVersion")]
        [Validation(Required=false)]
        public long? AppliedStatusVersion { get; set; }

        /// <summary>
        /// <para>输入附件列表</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("attachments")]
        [Validation(Required=false)]
        public List<PauseWorkItemResponseBodyAttachments> Attachments { get; set; }
        public class PauseWorkItemResponseBodyAttachments : TeaModel {
            /// <summary>
            /// <para>附件ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("attachmentId")]
            [Validation(Required=false)]
            public string AttachmentId { get; set; }

            /// <summary>
            /// <para>内容类型</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("contentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            /// <summary>
            /// <para>附件访问入口（OpenAPI 302 前置）</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("refUrl")]
            [Validation(Required=false)]
            public string RefUrl { get; set; }

            /// <summary>
            /// <para>附件资源ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("resourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>附件资源类型</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("resourceKind")]
            [Validation(Required=false)]
            public string ResourceKind { get; set; }

            /// <summary>
            /// <para>附件大小(字节)</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("sizeBytes")]
            [Validation(Required=false)]
            public long? SizeBytes { get; set; }

            /// <summary>
            /// <para>附件标题</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>业务状态（七态）</para>
        /// 
        /// <b>Example:</b>
        /// <para>PROCESSING</para>
        /// </summary>
        [NameInMap("businessStatus")]
        [Validation(Required=false)]
        public string BusinessStatus { get; set; }

        /// <summary>
        /// <para>调用者是否可删除</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("canDelete")]
        [Validation(Required=false)]
        public bool? CanDelete { get; set; }

        /// <summary>
        /// <para>调用者是否可管理</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("canManage")]
        [Validation(Required=false)]
        public bool? CanManage { get; set; }

        /// <summary>
        /// <para>是否可独立调整可见范围</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("canManageVisibility")]
        [Validation(Required=false)]
        public bool? CanManageVisibility { get; set; }

        /// <summary>
        /// <para>调用者是否可重命名</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("canRename")]
        [Validation(Required=false)]
        public bool? CanRename { get; set; }

        /// <summary>
        /// <para>业务状态码；成功为200</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>协作空间ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("collaborationGroupId")]
        [Validation(Required=false)]
        public string CollaborationGroupId { get; set; }

        /// <summary>
        /// <para>协作人用户ID列表</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("collaboratorUserIds")]
        [Validation(Required=false)]
        public List<long?> CollaboratorUserIds { get; set; }

        /// <summary>
        /// <para>关联会话ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("conversationId")]
        [Validation(Required=false)]
        public string ConversationId { get; set; }

        /// <summary>
        /// <para>创建时间(ISO8601)</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>创建人用户ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("createdByUserId")]
        [Validation(Required=false)]
        public long? CreatedByUserId { get; set; }

        /// <summary>
        /// <para>创建来源：DEFAULT/TASK</para>
        /// 
        /// <b>Example:</b>
        /// <para>DEFAULT</para>
        /// </summary>
        [NameInMap("creationType")]
        [Validation(Required=false)]
        public string CreationType { get; set; }

        /// <summary>
        /// <para>当前物理计划ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("currentPlanId")]
        [Validation(Required=false)]
        public string CurrentPlanId { get; set; }

        /// <summary>
        /// <para>当前修订号</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("currentRevision")]
        [Validation(Required=false)]
        public long? CurrentRevision { get; set; }

        /// <summary>
        /// <para>当前运行ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("currentRunId")]
        [Validation(Required=false)]
        public string CurrentRunId { get; set; }

        /// <summary>
        /// <para>当前运行序号</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("currentRunSeq")]
        [Validation(Required=false)]
        public long? CurrentRunSeq { get; set; }

        /// <summary>
        /// <para>当前步骤名称</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("currentStepName")]
        [Validation(Required=false)]
        public string CurrentStepName { get; set; }

        /// <summary>
        /// <para>描述</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>输入快照版本</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("inputVersion")]
        [Validation(Required=false)]
        public long? InputVersion { get; set; }

        /// <summary>
        /// <para>工作项类型</para>
        /// 
        /// <b>Example:</b>
        /// <para>WORKFLOW</para>
        /// </summary>
        [NameInMap("itemType")]
        [Validation(Required=false)]
        public string ItemType { get; set; }

        /// <summary>
        /// <para>最近进入处理中的时间(ISO8601)</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("lastProcessingAt")]
        [Validation(Required=false)]
        public string LastProcessingAt { get; set; }

        /// <summary>
        /// <para>是否为兼容期自由探索话题</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("legacyTopic")]
        [Validation(Required=false)]
        public bool? LegacyTopic { get; set; }

        /// <summary>
        /// <para>可见成员用户ID列表</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("memberUserIds")]
        [Validation(Required=false)]
        public List<long?> MemberUserIds { get; set; }

        /// <summary>
        /// <para>错误描述</para>
        /// 
        /// <b>Example:</b>
        /// <para>请求的资源不存在</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>修改时间(ISO8601)</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("modifiedAt")]
        [Validation(Required=false)]
        public string ModifiedAt { get; set; }

        /// <summary>
        /// <para>负责人用户ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ownerUserId")]
        [Validation(Required=false)]
        public long? OwnerUserId { get; set; }

        /// <summary>
        /// <para>调用者个人置顶状态</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("pinned")]
        [Validation(Required=false)]
        public bool? Pinned { get; set; }

        /// <summary>
        /// <para>优先级</para>
        /// 
        /// <b>Example:</b>
        /// <para>HIGH</para>
        /// </summary>
        [NameInMap("priority")]
        [Validation(Required=false)]
        public string Priority { get; set; }

        /// <summary>
        /// <para>已完成进度</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("progressCompleted")]
        [Validation(Required=false)]
        public long? ProgressCompleted { get; set; }

        /// <summary>
        /// <para>总进度</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("progressTotal")]
        [Validation(Required=false)]
        public long? ProgressTotal { get; set; }

        /// <summary>
        /// <para>请求追踪ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>任务执行ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("sourceExecutionId")]
        [Validation(Required=false)]
        public string SourceExecutionId { get; set; }

        /// <summary>
        /// <para>任务来源ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("sourceTaskId")]
        [Validation(Required=false)]
        public string SourceTaskId { get; set; }

        /// <summary>
        /// <para>任务来源名称</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("sourceTaskName")]
        [Validation(Required=false)]
        public string SourceTaskName { get; set; }

        /// <summary>
        /// <para>任务触发键</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("sourceTriggerKey")]
        [Validation(Required=false)]
        public string SourceTriggerKey { get; set; }

        /// <summary>
        /// <para>任务来源类型</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>标题</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>任务触发时区</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("triggerTimezone")]
        [Validation(Required=false)]
        public string TriggerTimezone { get; set; }

        /// <summary>
        /// <para>任务触发时间(ISO8601)</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("triggeredAt")]
        [Validation(Required=false)]
        public string TriggeredAt { get; set; }

        /// <summary>
        /// <para>乐观版本号</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public long? Version { get; set; }

        /// <summary>
        /// <para>可见范围</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

        /// <summary>
        /// <para>可见范围来源：SELF/TASK/TEMPLATE</para>
        /// 
        /// <b>Example:</b>
        /// <para>SELF</para>
        /// </summary>
        [NameInMap("visibilitySource")]
        [Validation(Required=false)]
        public string VisibilitySource { get; set; }

        /// <summary>
        /// <para>工作项ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("workItemId")]
        [Validation(Required=false)]
        public string WorkItemId { get; set; }

        /// <summary>
        /// <para>Workflow四态投影</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("workflowStatus")]
        [Validation(Required=false)]
        public string WorkflowStatus { get; set; }

        /// <summary>
        /// <para>绑定的工作流模板ID列表</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("workflowTemplateIds")]
        [Validation(Required=false)]
        public List<string> WorkflowTemplateIds { get; set; }

    }

}
