// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ListWorkItemsResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code. A value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Indicates whether more data is available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <para>The list of work items on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;acceptanceCriteria&quot;:&quot;example&quot;,&quot;appliedStatusVersion&quot;:1,&quot;attachments&quot;:[{&quot;attachmentId&quot;:&quot;example&quot;,&quot;contentType&quot;:&quot;example&quot;,&quot;refUrl&quot;:&quot;example&quot;,&quot;resourceId&quot;:&quot;example&quot;,&quot;resourceKind&quot;:&quot;example&quot;,&quot;sizeBytes&quot;:1,&quot;title&quot;:&quot;example&quot;}],&quot;businessStatus&quot;:&quot;PROCESSING&quot;,&quot;canDelete&quot;:false,&quot;canManage&quot;:false,&quot;canManageVisibility&quot;:false,&quot;canRename&quot;:false,&quot;collaborationGroupId&quot;:&quot;example&quot;,&quot;collaboratorUserIds&quot;:[10001],&quot;conversationId&quot;:&quot;example&quot;,&quot;createdAt&quot;:&quot;example&quot;,&quot;createdByUserId&quot;:1,&quot;creationType&quot;:&quot;DEFAULT&quot;,&quot;currentPlanId&quot;:&quot;example&quot;,&quot;currentRevision&quot;:1,&quot;currentRunId&quot;:&quot;example&quot;,&quot;currentRunSeq&quot;:1,&quot;currentStepName&quot;:&quot;example&quot;,&quot;description&quot;:&quot;example&quot;,&quot;inputVersion&quot;:1,&quot;itemType&quot;:&quot;WORKFLOW&quot;,&quot;lastProcessingAt&quot;:&quot;example&quot;,&quot;legacyTopic&quot;:false,&quot;memberUserIds&quot;:[10001],&quot;modifiedAt&quot;:&quot;example&quot;,&quot;ownerUserId&quot;:1,&quot;pinned&quot;:false,&quot;priority&quot;:&quot;HIGH&quot;,&quot;progressCompleted&quot;:1,&quot;progressTotal&quot;:1,&quot;sourceExecutionId&quot;:&quot;example&quot;,&quot;sourceTaskId&quot;:&quot;example&quot;,&quot;sourceTaskName&quot;:&quot;example&quot;,&quot;sourceTriggerKey&quot;:&quot;example&quot;,&quot;sourceType&quot;:&quot;example&quot;,&quot;title&quot;:&quot;example&quot;,&quot;triggerTimezone&quot;:&quot;example&quot;,&quot;triggeredAt&quot;:&quot;example&quot;,&quot;version&quot;:1,&quot;visibility&quot;:&quot;example&quot;,&quot;visibilitySource&quot;:&quot;SELF&quot;,&quot;workItemId&quot;:&quot;example&quot;,&quot;workflowStatus&quot;:&quot;example&quot;,&quot;workflowTemplateIds&quot;:[&quot;tpl_example&quot;]}]</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListWorkItemsResponseBodyItems> Items { get; set; }
        public class ListWorkItemsResponseBodyItems : TeaModel {
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
            /// <para>[{&quot;attachmentId&quot;:&quot;example&quot;,&quot;contentType&quot;:&quot;example&quot;,&quot;refUrl&quot;:&quot;example&quot;,&quot;resourceId&quot;:&quot;example&quot;,&quot;resourceKind&quot;:&quot;example&quot;,&quot;sizeBytes&quot;:1,&quot;title&quot;:&quot;example&quot;}]</para>
            /// </summary>
            [NameInMap("attachments")]
            [Validation(Required=false)]
            public List<ListWorkItemsResponseBodyItemsAttachments> Attachments { get; set; }
            public class ListWorkItemsResponseBodyItemsAttachments : TeaModel {
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
                /// <para>The access endpoint of the attachment (prefixed with an OpenAPI 302 redirect).</para>
                /// 
                /// <b>Example:</b>
                /// <para>example</para>
                /// </summary>
                [NameInMap("refUrl")]
                [Validation(Required=false)]
                public string RefUrl { get; set; }

                /// <summary>
                /// <para>The resource ID of the attachment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example</para>
                /// </summary>
                [NameInMap("resourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The resource type of the attachment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example</para>
                /// </summary>
                [NameInMap("resourceKind")]
                [Validation(Required=false)]
                public string ResourceKind { get; set; }

                /// <summary>
                /// <para>The size of the attachment in bytes.</para>
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
            /// <para>Indicates whether the caller can delete the item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("canDelete")]
            [Validation(Required=false)]
            public bool? CanDelete { get; set; }

            /// <summary>
            /// <para>Indicates whether the caller can manage the item.</para>
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
            /// <para>Indicates whether the caller can rename the item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("canRename")]
            [Validation(Required=false)]
            public bool? CanRename { get; set; }

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
            /// <para>The list of user IDs of the collaborators.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[10001]</para>
            /// </summary>
            [NameInMap("collaboratorUserIds")]
            [Validation(Required=false)]
            public List<long?> CollaboratorUserIds { get; set; }

            /// <summary>
            /// <para>The ID of the associated conversation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("conversationId")]
            [Validation(Required=false)]
            public string ConversationId { get; set; }

            /// <summary>
            /// <para>The creation time (ISO 8601).</para>
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
            /// <para>The creation source. Valid values: DEFAULT and TASK.</para>
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
            /// <para>The time when the item last entered the processing state (ISO 8601).</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("lastProcessingAt")]
            [Validation(Required=false)]
            public string LastProcessingAt { get; set; }

            /// <summary>
            /// <para>Indicates whether the topic is a free exploration topic during the compatibility period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("legacyTopic")]
            [Validation(Required=false)]
            public bool? LegacyTopic { get; set; }

            /// <summary>
            /// <para>The list of user IDs of visible members.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[10001]</para>
            /// </summary>
            [NameInMap("memberUserIds")]
            [Validation(Required=false)]
            public List<long?> MemberUserIds { get; set; }

            /// <summary>
            /// <para>The modification time (ISO 8601).</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("modifiedAt")]
            [Validation(Required=false)]
            public string ModifiedAt { get; set; }

            /// <summary>
            /// <para>The user ID of the owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ownerUserId")]
            [Validation(Required=false)]
            public long? OwnerUserId { get; set; }

            /// <summary>
            /// <para>The personal pin status for the caller.</para>
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
            /// <para>The execution ID of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("sourceExecutionId")]
            [Validation(Required=false)]
            public string SourceExecutionId { get; set; }

            /// <summary>
            /// <para>The source ID of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("sourceTaskId")]
            [Validation(Required=false)]
            public string SourceTaskId { get; set; }

            /// <summary>
            /// <para>The source name of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("sourceTaskName")]
            [Validation(Required=false)]
            public string SourceTaskName { get; set; }

            /// <summary>
            /// <para>The trigger key of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("sourceTriggerKey")]
            [Validation(Required=false)]
            public string SourceTriggerKey { get; set; }

            /// <summary>
            /// <para>The source type of the task.</para>
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
            /// <para>The trigger time zone of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("triggerTimezone")]
            [Validation(Required=false)]
            public string TriggerTimezone { get; set; }

            /// <summary>
            /// <para>The trigger time of the task (ISO 8601).</para>
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
            /// <para>The source of the visibility scope. Valid values: SELF, TASK, and TEMPLATE.</para>
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
            /// <para>The workflow status projection (four states).</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("workflowStatus")]
            [Validation(Required=false)]
            public string WorkflowStatus { get; set; }

            /// <summary>
            /// <para>The list of IDs of the bound workflow templates.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;tpl_example&quot;]</para>
            /// </summary>
            [NameInMap("workflowTemplateIds")]
            [Validation(Required=false)]
            public List<string> WorkflowTemplateIds { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of items returned per page for this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

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
        /// <para>The pagination token for the next page. An empty string indicates that no more data is available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        /// <summary>
        /// <para>The number of items per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request tracking ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of visible items under the filter conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
