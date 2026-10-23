// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class CreateTodoShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of platform user IDs of the assignees. You can specify 1 to 100 IDs. Duplicate IDs are automatically removed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>43</para>
        /// </summary>
        [NameInMap("assigneeUserIds")]
        [Validation(Required=false)]
        public string AssigneeUserIdsShrink { get; set; }

        /// <summary>
        /// <para>The ID of the collaboration workspace. This parameter is optional.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cg_123</para>
        /// </summary>
        [NameInMap("collaborationGroupId")]
        [Validation(Required=false)]
        public string CollaborationGroupId { get; set; }

        /// <summary>
        /// <para>The priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MEDIUM</para>
        /// </summary>
        [NameInMap("priority")]
        [Validation(Required=false)]
        public string Priority { get; set; }

        /// <summary>
        /// <para>The list of questions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("questions")]
        [Validation(Required=false)]
        public string QuestionsShrink { get; set; }

        /// <summary>
        /// <para>The source context. The value is passed through and stored in the database as-is without validation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("sourceContext")]
        [Validation(Required=false)]
        public string SourceContextShrink { get; set; }

        /// <summary>
        /// <para>The source of the to-do item. Only OPEN_API is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OPEN_API</para>
        /// </summary>
        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

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
        /// <para>The title of the to-do item. The maximum length is 200 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Governance approval</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
