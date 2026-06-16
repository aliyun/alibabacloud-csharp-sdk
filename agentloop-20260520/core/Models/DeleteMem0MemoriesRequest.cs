// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class DeleteMem0MemoriesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>my-agent-space</para>
        /// </summary>
        [NameInMap("agentSpace")]
        [Validation(Required=false)]
        public string AgentSpace { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>agent-001</para>
        /// </summary>
        [NameInMap("agent_id")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>app-001</para>
        /// </summary>
        [NameInMap("app_id")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cs-0001</para>
        /// </summary>
        [NameInMap("context_store_id")]
        [Validation(Required=false)]
        public string ContextStoreId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;channel&quot;:&quot;app&quot;,&quot;locale&quot;:&quot;zh-CN&quot;}</para>
        /// </summary>
        [NameInMap("metadata")]
        [Validation(Required=false)]
        public Dictionary<string, object> Metadata { get; set; }

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

        /// <summary>
        /// <b>Example:</b>
        /// <para>run-001</para>
        /// </summary>
        [NameInMap("run_id")]
        [Validation(Required=false)]
        public string RunId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
