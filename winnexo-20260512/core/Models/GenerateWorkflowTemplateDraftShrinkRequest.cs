// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class GenerateWorkflowTemplateDraftShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the collaboration workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cg_9401</para>
        /// </summary>
        [NameInMap("collaborationGroupId")]
        [Validation(Required=false)]
        public string CollaborationGroupId { get; set; }

        /// <summary>
        /// <para>The draft from the previous round. If this parameter is provided, the new draft is iteratively modified based on it.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;schemaVersion\&quot;:2,\&quot;steps\&quot;:[]}</para>
        /// </summary>
        [NameInMap("previousDraft")]
        [Validation(Required=false)]
        public string PreviousDraftShrink { get; set; }

        /// <summary>
        /// <para>The description of the template requirement.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Generate a three-step process for handling customer complaints</para>
        /// </summary>
        [NameInMap("requirement")]
        [Validation(Required=false)]
        public string Requirement { get; set; }

        /// <summary>
        /// <para>The tenant ID. This is a common parameter. If this parameter is not specified, the default tenant of the caller is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
