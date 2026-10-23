// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class CloseWorkflowTodosRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the collaborative workspace. The match scope is limited to this workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cg_123</para>
        /// </summary>
        [NameInMap("collaborationGroupId")]
        [Validation(Required=false)]
        public string CollaborationGroupId { get; set; }

        /// <summary>
        /// <para>The workflow ID at the run level.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wf-1</para>
        /// </summary>
        [NameInMap("sourceWorkflowId")]
        [Validation(Required=false)]
        public string SourceWorkflowId { get; set; }

        /// <summary>
        /// <para>The tenant ID. This is a common parameter. If not specified, the default tenant of the caller is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
