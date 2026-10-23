// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class UpdateWorkItemShrinkRequest : TeaModel {
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
        /// <para>The stable references for the attachments.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("attachments")]
        [Validation(Required=false)]
        public string AttachmentsShrink { get; set; }

        /// <summary>
        /// <para>The ID of the collaboration space.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>group_example</para>
        /// </summary>
        [NameInMap("collaborationGroupId")]
        [Validation(Required=false)]
        public string CollaborationGroupId { get; set; }

        /// <summary>
        /// <para>The list of user IDs of the collaborators.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("collaboratorUserIds")]
        [Validation(Required=false)]
        public string CollaboratorUserIdsShrink { get; set; }

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
        /// <para>The description of the work item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The optimistic version number. Obtain this value from the version field in the previous response.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("expectedVersion")]
        [Validation(Required=false)]
        public long? ExpectedVersion { get; set; }

        /// <summary>
        /// <para>The user ID of the owner. If not specified, the user ID of the caller is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ownerUserId")]
        [Validation(Required=false)]
        public long? OwnerUserId { get; set; }

        /// <summary>
        /// <para>The scheduling priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HIGH</para>
        /// </summary>
        [NameInMap("priority")]
        [Validation(Required=false)]
        public string Priority { get; set; }

        /// <summary>
        /// <para>The tenant ID. This is a common parameter. If not specified, the default tenant of the caller is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The title of the work item.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The ID of the work item.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wi_example</para>
        /// </summary>
        [NameInMap("workItemId")]
        [Validation(Required=false)]
        public string WorkItemId { get; set; }

        /// <summary>
        /// <para>The list of bound workflow template IDs. If not specified, the existing bindings are retained. If an empty array is provided, the bindings are cleared.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("workflowTemplateIds")]
        [Validation(Required=false)]
        public string WorkflowTemplateIdsShrink { get; set; }

    }

}
