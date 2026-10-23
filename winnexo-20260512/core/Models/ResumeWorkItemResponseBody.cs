// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ResumeWorkItemResponseBody : TeaModel {
        /// <summary>
        /// <para>The acceptance criteria.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("acceptanceCriteria")]
        [Validation(Required=false)]
        public string AcceptanceCriteria { get; set; }

        /// <summary>
        /// <para>The applied status version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("appliedStatusVersion")]
        [Validation(Required=false)]
        public long? AppliedStatusVersion { get; set; }

        /// <summary>
        /// <para>The list of input attachments.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("attachments")]
        [Validation(Required=false)]
        public List<ResumeWorkItemResponseBodyAttachments> Attachments { get; set; }
        public class ResumeWorkItemResponseBodyAttachments : TeaModel {
            /// <summary>
            /// <para>The attachment ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("attachmentId")]
            [Validation(Required=false)]
            public string AttachmentId { get; set; }

            /// <summary>
            /// <para>The content type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("contentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            /// <summary>
            /// <para>The attachment access entry (OpenAPI 302 pre-redirect).</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("refUrl")]
            [Validation(Required=false)]
            public string RefUrl { get; set; }

            /// <summary>
            /// <para>The attachment resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("resourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The attachment resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("resourceKind")]
            [Validation(Required=false)]
            public string ResourceKind { get; set; }

            /// <summary>
            /// <para>The attachment size, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("sizeBytes")]
            [Validation(Required=false)]
            public long? SizeBytes { get; set; }

            /// <summary>
            /// <para>The attachment title.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>The business status (seven states).</para>
        /// 
        /// <b>Example:</b>
        /// <para>PROCESSING</para>
        /// </summary>
        [NameInMap("businessStatus")]
        [Validation(Required=false)]
        public string BusinessStatus { get; set; }

        /// <summary>
        /// <para>Indicates whether the caller can delete this item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("canDelete")]
        [Validation(Required=false)]
        public bool? CanDelete { get; set; }

        /// <summary>
        /// <para>Indicates whether the caller can manage this item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("canManage")]
        [Validation(Required=false)]
        public bool? CanManage { get; set; }

        /// <summary>
        /// <para>Indicates whether the visibility scope can be adjusted independently.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("canManageVisibility")]
        [Validation(Required=false)]
        public bool? CanManageVisibility { get; set; }

        /// <summary>
        /// <para>Indicates whether the caller can rename this item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("canRename")]
        [Validation(Required=false)]
        public bool? CanRename { get; set; }

        /// <summary>
        /// <para>The business status code. 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The collaboration space ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("collaborationGroupId")]
        [Validation(Required=false)]
        public string CollaborationGroupId { get; set; }

        /// <summary>
        /// <para>The list of collaborator user IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("collaboratorUserIds")]
        [Validation(Required=false)]
        public List<long?> CollaboratorUserIds { get; set; }

        /// <summary>
        /// <para>The associated conversation ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("conversationId")]
        [Validation(Required=false)]
        public string ConversationId { get; set; }

        /// <summary>
        /// <para>The creation time, in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>The user ID of the creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("createdByUserId")]
        [Validation(Required=false)]
        public long? CreatedByUserId { get; set; }

        /// <summary>
        /// <para>The creation source. Valid values: DEFAULT, TASK.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DEFAULT</para>
        /// </summary>
        [NameInMap("creationType")]
        [Validation(Required=false)]
        public string CreationType { get; set; }

        /// <summary>
        /// <para>The current physical plan ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("currentPlanId")]
        [Validation(Required=false)]
        public string CurrentPlanId { get; set; }

        /// <summary>
        /// <para>The current revision number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("currentRevision")]
        [Validation(Required=false)]
        public long? CurrentRevision { get; set; }

        /// <summary>
        /// <para>The current run ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("currentRunId")]
        [Validation(Required=false)]
        public string CurrentRunId { get; set; }

        /// <summary>
        /// <para>The current run sequence number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("currentRunSeq")]
        [Validation(Required=false)]
        public long? CurrentRunSeq { get; set; }

        /// <summary>
        /// <para>The current step name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("currentStepName")]
        [Validation(Required=false)]
        public string CurrentStepName { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The input snapshot version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("inputVersion")]
        [Validation(Required=false)]
        public long? InputVersion { get; set; }

        /// <summary>
        /// <para>The work item type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WORKFLOW</para>
        /// </summary>
        [NameInMap("itemType")]
        [Validation(Required=false)]
        public string ItemType { get; set; }

        /// <summary>
        /// <para>The most recent time the item entered processing state, in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("lastProcessingAt")]
        [Validation(Required=false)]
        public string LastProcessingAt { get; set; }

        /// <summary>
        /// <para>Indicates whether this is a legacy free-exploration topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("legacyTopic")]
        [Validation(Required=false)]
        public bool? LegacyTopic { get; set; }

        /// <summary>
        /// <para>The list of visible member user IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("memberUserIds")]
        [Validation(Required=false)]
        public List<long?> MemberUserIds { get; set; }

        /// <summary>
        /// <para>The error description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The requested resource does not exist</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The modification time, in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("modifiedAt")]
        [Validation(Required=false)]
        public string ModifiedAt { get; set; }

        /// <summary>
        /// <para>The owner user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ownerUserId")]
        [Validation(Required=false)]
        public long? OwnerUserId { get; set; }

        /// <summary>
        /// <para>Indicates whether the caller has pinned this item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("pinned")]
        [Validation(Required=false)]
        public bool? Pinned { get; set; }

        /// <summary>
        /// <para>The priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HIGH</para>
        /// </summary>
        [NameInMap("priority")]
        [Validation(Required=false)]
        public string Priority { get; set; }

        /// <summary>
        /// <para>The completed progress.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("progressCompleted")]
        [Validation(Required=false)]
        public long? ProgressCompleted { get; set; }

        /// <summary>
        /// <para>The total progress.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("progressTotal")]
        [Validation(Required=false)]
        public long? ProgressTotal { get; set; }

        /// <summary>
        /// <para>The request trace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The task execution ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("sourceExecutionId")]
        [Validation(Required=false)]
        public string SourceExecutionId { get; set; }

        /// <summary>
        /// <para>The task source ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("sourceTaskId")]
        [Validation(Required=false)]
        public string SourceTaskId { get; set; }

        /// <summary>
        /// <para>The task source name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("sourceTaskName")]
        [Validation(Required=false)]
        public string SourceTaskName { get; set; }

        /// <summary>
        /// <para>The task trigger key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("sourceTriggerKey")]
        [Validation(Required=false)]
        public string SourceTriggerKey { get; set; }

        /// <summary>
        /// <para>The task source type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The title.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The task trigger time zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("triggerTimezone")]
        [Validation(Required=false)]
        public string TriggerTimezone { get; set; }

        /// <summary>
        /// <para>The task trigger time, in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("triggeredAt")]
        [Validation(Required=false)]
        public string TriggeredAt { get; set; }

        /// <summary>
        /// <para>The optimistic version number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public long? Version { get; set; }

        /// <summary>
        /// <para>The visibility scope.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

        /// <summary>
        /// <para>The visibility scope source. Valid values: SELF, TASK, TEMPLATE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SELF</para>
        /// </summary>
        [NameInMap("visibilitySource")]
        [Validation(Required=false)]
        public string VisibilitySource { get; set; }

        /// <summary>
        /// <para>The work item ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("workItemId")]
        [Validation(Required=false)]
        public string WorkItemId { get; set; }

        /// <summary>
        /// <para>The workflow four-state projection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("workflowStatus")]
        [Validation(Required=false)]
        public string WorkflowStatus { get; set; }

        /// <summary>
        /// <para>The list of bound workflow template IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("workflowTemplateIds")]
        [Validation(Required=false)]
        public List<string> WorkflowTemplateIds { get; set; }

    }

}
