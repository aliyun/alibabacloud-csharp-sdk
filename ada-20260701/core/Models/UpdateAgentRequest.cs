// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ada20260701.Models
{
    public class UpdateAgentRequest : TeaModel {
        /// <summary>
        /// <para>The new description. If not specified, the existing value is retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Analyzes CR code changes and checks for correctness, security, and maintainability</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The new display name. If not specified, the existing value is retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CR Code and Security Review Agent</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The expected current configuration revision number. This parameter is omitted by default. For concurrency protection, pass in the <c>AgentVersion</c> returned by the most recent <c>GetAgent</c> call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ExpectedVersion")]
        [Validation(Required=false)]
        public long? ExpectedVersion { get; set; }

        /// <summary>
        /// <para>The list of knowledge base bindings, which contains at most one element. If not specified, the existing value is retained. A non-empty array replaces the entire value. Passing <c>[ ]</c> removes all bindings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;code-review-guidelines&quot;}]</para>
        /// </summary>
        [NameInMap("KnowledgeBases")]
        [Validation(Required=false)]
        public object KnowledgeBases { get; set; }

        /// <summary>
        /// <para>The name of the Agent to update.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>code-review-agent</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The list of Skill references. If not specified, the existing value is retained. A non-empty array replaces the entire value. Passing <c>[ ]</c> removes all bindings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;code-review&quot;}]</para>
        /// </summary>
        [NameInMap("Skills")]
        [Validation(Required=false)]
        public object Skills { get; set; }

        /// <summary>
        /// <para>The new system prompt. If not specified, the existing value is retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Check the CR for code defects, security risks, and compatibility issues, and provide actionable suggestions for fixes</para>
        /// </summary>
        [NameInMap("SystemPrompt")]
        [Validation(Required=false)]
        public string SystemPrompt { get; set; }

        /// <summary>
        /// <para>The list of MCP Server and Connector name references. The same array supports both types of entries. Each entry specifies one type of reference. If items is omitted for an MCP entry, all public tools are included. Previously specified items retain their existing values.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;mcpServerName&quot;:&quot;code-repository-mcp&quot;},{&quot;connectorName&quot;:&quot;code-review-data&quot;}]</para>
        /// </summary>
        [NameInMap("Tools")]
        [Validation(Required=false)]
        public object Tools { get; set; }

        /// <summary>
        /// <para>The new visibility scope. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>user</description></item>
        /// <item><description>tenant</description></item>
        /// </list>
        /// <para>If not specified, the existing value is retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tenant</para>
        /// </summary>
        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

    }

}
