// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ada20260701.Models
{
    public class UpdateAgentRequest : TeaModel {
        /// <summary>
        /// <para>The new description. If not passed, the original value is retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Analyze code changes and check for correctness, security, and maintainability</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The new display name. If not passed, the original value is retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Code review and security review agent</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The expected current configuration revision number. This parameter is omitted by default. Pass the <c>AgentVersion</c> returned by the most recent <c>GetAgent</c> call when concurrent protection is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ExpectedVersion")]
        [Validation(Required=false)]
        public long? ExpectedVersion { get; set; }

        /// <summary>
        /// <para>The list of knowledge base bindings, which can contain at most one element. If not passed, the original value is retained. If a non-empty array is passed, the entire list is replaced. If <c>[ ]</c> is passed, all bindings are removed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;code-review-guidelines&quot;}]</para>
        /// </summary>
        [NameInMap("KnowledgeBases")]
        [Validation(Required=false)]
        public object KnowledgeBases { get; set; }

        /// <summary>
        /// <para>The name of the agent to update.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>code-review-agent</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The list of skill references. If not passed, the original value is retained. If a non-empty array is passed, the entire list is replaced. If <c>[ ]</c> is passed, all bindings are removed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;code-review&quot;}]</para>
        /// </summary>
        [NameInMap("Skills")]
        [Validation(Required=false)]
        public object Skills { get; set; }

        /// <summary>
        /// <para>The new system prompt. If not passed, the original value is retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Check for code defects, security risks, and compatibility issues in the code review, and provide actionable modification suggestions</para>
        /// </summary>
        [NameInMap("SystemPrompt")]
        [Validation(Required=false)]
        public string SystemPrompt { get; set; }

        /// <summary>
        /// <para>The list of MCP server and connector name references. The same array supports both types of entries. Specify only one type of reference for each entry. For MCP, omitting items indicates all public tools. Historically specified items retain their original values.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;mcpServerName&quot;:&quot;code-repository-mcp&quot;},{&quot;connectorName&quot;:&quot;code-review-data&quot;}]</para>
        /// </summary>
        [NameInMap("Tools")]
        [Validation(Required=false)]
        public object Tools { get; set; }

        /// <summary>
        /// <para>The new visibility scope. Valid values: <c>user</c> and <c>tenant</c>. If not passed, the original value is retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tenant</para>
        /// </summary>
        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

    }

}
