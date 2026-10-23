// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class CreateWorkItemShrinkRequest : TeaModel {
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
        /// <para>The stable references of the input attachments.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("attachments")]
        [Validation(Required=false)]
        public string AttachmentsShrink { get; set; }

        /// <summary>
        /// <para>The ID of the collaboration workspace.</para>
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
        /// <para>The type of the work item. Only WORKFLOW is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WORKFLOW</para>
        /// </summary>
        [NameInMap("itemType")]
        [Validation(Required=false)]
        public string ItemType { get; set; }

        /// <summary>
        /// <para>The user ID of the owner. If this parameter is not specified, the ID of the caller is used.</para>
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
        /// <para>The tenant ID. This is a common parameter. If this parameter is not specified, the default tenant of the caller is used.</para>
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
        /// <para>The list of IDs of the bound workflow templates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("workflowTemplateIds")]
        [Validation(Required=false)]
        public string WorkflowTemplateIdsShrink { get; set; }

    }

}
