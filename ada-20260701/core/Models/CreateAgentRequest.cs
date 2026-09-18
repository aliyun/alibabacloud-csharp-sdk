// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ada20260701.Models
{
    public class CreateAgentRequest : TeaModel {
        /// <summary>
        /// <para>The description of the Agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Analyzes code changes and generates CR review comments</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The display name of the Agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CR Code Review Agent</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The knowledge base reference list, which contains at most one element.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;code-review-guidelines&quot;}]</para>
        /// </summary>
        [NameInMap("KnowledgeBases")]
        [Validation(Required=false)]
        public object KnowledgeBases { get; set; }

        /// <summary>
        /// <para>The Agent name, which is also the unique identifier that cannot be modified after creation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>code-review-agent</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The Skill reference list. For specific fields, see &quot;Supplementary description of request parameters&quot;.</para>
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
        /// <para>Check the correctness, security, and maintainability of code changes in the CR, and provide review comments by severity</para>
        /// </summary>
        [NameInMap("SystemPrompt")]
        [Validation(Required=false)]
        public string SystemPrompt { get; set; }

        /// <summary>
        /// <para>The reference list of MCP Server and Connector names. The same array supports both types of entries. Each entry specifies one type of reference. If items is omitted for an MCP Server, all public tools are included. Previously specified items retain their original values.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;mcpServerName&quot;:&quot;code-repository-mcp&quot;},{&quot;connectorName&quot;:&quot;code-review-data&quot;}]</para>
        /// </summary>
        [NameInMap("Tools")]
        [Validation(Required=false)]
        public object Tools { get; set; }

        /// <summary>
        /// <para>The visibility scope of the Agent. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>user</description></item>
        /// <item><description>tenant</description></item>
        /// </list>
        /// <para>Default value: user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

    }

}
