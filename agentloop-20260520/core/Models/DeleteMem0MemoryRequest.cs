// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class DeleteMem0MemoryRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>my-agent-space</para>
        /// </summary>
        [NameInMap("agentSpace")]
        [Validation(Required=false)]
        public string AgentSpace { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cs-0001</para>
        /// </summary>
        [NameInMap("context_store_id")]
        [Validation(Required=false)]
        public string ContextStoreId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>org-001</para>
        /// </summary>
        [NameInMap("org_id")]
        [Validation(Required=false)]
        public string OrgId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>proj-001</para>
        /// </summary>
        [NameInMap("project_id")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

    }

}
