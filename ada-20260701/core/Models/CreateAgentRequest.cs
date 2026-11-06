// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ada20260701.Models
{
    public class CreateAgentRequest : TeaModel {
        /// <summary>
        /// <para>The description of the agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Analyzes code changes and generates code review comments</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The display name of the agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Code Review Agent</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The list of knowledge base references, which can contain at most one element.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;code-review-guidelines&quot;}]</para>
        /// </summary>
        [NameInMap("KnowledgeBases")]
        [Validation(Required=false)]
        public object KnowledgeBases { get; set; }

        /// <summary>
        /// <para>The name of the agent, which is also the unique identifier that cannot be modified after creation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>code-review-agent</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The list of skill references. For specific fields, refer to the supplementary description of request parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;code-review&quot;}]</para>
        /// </summary>
        [NameInMap("Skills")]
        [Validation(Required=false)]
        public object Skills { get; set; }

        /// <summary>
        /// <para>The system prompt.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Check the correctness, security, and maintainability of code changes in the code review, and provide review comments based on severity</para>
        /// </summary>
        [NameInMap("SystemPrompt")]
        [Validation(Required=false)]
        public string SystemPrompt { get; set; }

        /// <summary>
        /// <para>The list of MCP server and connector name references. The same array supports both types of entries. Specify only one type of reference for each entry. For MCP, omitting items indicates all public tools, and historically specified items retain their original values.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;mcpServerName&quot;:&quot;code-repository-mcp&quot;},{&quot;connectorName&quot;:&quot;code-review-data&quot;}]</para>
        /// </summary>
        [NameInMap("Tools")]
        [Validation(Required=false)]
        public object Tools { get; set; }

        /// <summary>
        /// <para>The visibility scope of the agent. Valid values: <c>user</c> and <c>tenant</c>. Default value: <c>user</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

    }

}
