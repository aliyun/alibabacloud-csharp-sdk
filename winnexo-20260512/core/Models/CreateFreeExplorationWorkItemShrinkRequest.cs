// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class CreateFreeExplorationWorkItemShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The technical names of the selected digital workers.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;sales-agent&quot;]</para>
        /// </summary>
        [NameInMap("agentNames")]
        [Validation(Required=false)]
        public string AgentNamesShrink { get; set; }

        /// <summary>
        /// <para>The ID of the collaboration workspace to which the work item belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cg_123</para>
        /// </summary>
        [NameInMap("collaborationGroupId")]
        [Validation(Required=false)]
        public string CollaborationGroupId { get; set; }

        /// <summary>
        /// <para>The actual members of the topic, including the creator. For public topics, members of the entire workspace are not enumerated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[43]</para>
        /// </summary>
        [NameInMap("memberUserIds")]
        [Validation(Required=false)]
        public string MemberUserIdsShrink { get; set; }

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
        /// <para>Investigate sales opportunities</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The actual visibility scope. Valid values: PRIVATE, COLLABORATIVE, and PUBLIC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

    }

}
