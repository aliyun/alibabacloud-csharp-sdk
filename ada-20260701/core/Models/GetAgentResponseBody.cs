// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ada20260701.Models
{
    public class GetAgentResponseBody : TeaModel {
        /// <summary>
        /// <para>Agent ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent_00000000000000000000000000000001</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>The current configuration revision number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("AgentVersion")]
        [Validation(Required=false)]
        public long? AgentVersion { get; set; }

        /// <summary>
        /// <para>Indicates whether the current identity can delete the agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CanDelete")]
        [Validation(Required=false)]
        public bool? CanDelete { get; set; }

        /// <summary>
        /// <para>Indicates whether the current identity can modify the agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CanModify")]
        [Validation(Required=false)]
        public bool? CanModify { get; set; }

        /// <summary>
        /// <para>The creation time. The value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1788332400000</para>
        /// </summary>
        [NameInMap("CreatedAt")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// <para>The description of the agent. This field may not be returned if it is not configured.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Analyzes code changes and generates CR review comments</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The display name of the agent. This field may not be returned if it is not configured.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CR Code Review Agent</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The list of knowledge base references. The list contains at most one element.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;code-review-guidelines&quot;}]</para>
        /// </summary>
        [NameInMap("KnowledgeBases")]
        [Validation(Required=false)]
        public object KnowledgeBases { get; set; }

        /// <summary>
        /// <para>The display metadata of the agent. For specific fields, see &quot;Supplementary description of response elements&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;iconUrl&quot;:&quot;<a href="https://example.com/icons/code-review-agent.png%22%7D">https://example.com/icons/code-review-agent.png&quot;}</a></para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public object Metadata { get; set; }

        /// <summary>
        /// <para>The saved model configuration. This field is returned only for official agents. The value supports an object array and is compatible with legacy single objects and strings. An empty array returns [ \]. Object arrays preserve the original order, duplicate names, and object fields.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;base&quot;,&quot;default&quot;:true},{&quot;name&quot;:&quot;base&quot;},{&quot;name&quot;:&quot;base&quot;,&quot;settings&quot;:{&quot;thinking&quot;:false,&quot;topK&quot;:5}}]</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public object Model { get; set; }

        /// <summary>
        /// <para>The name of the agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>code-review-agent</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Indicates whether the agent is an official agent provided by the platform.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Official")]
        [Validation(Required=false)]
        public bool? Official { get; set; }

        /// <summary>
        /// <para>The request ID, which is used for Tracing Analysis and troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0A1B2C3D-4E5F-6789-ABCD-EF0123456789</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of skill references. For specific fields, see &quot;Supplementary description of response elements&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;code-review&quot;}]</para>
        /// </summary>
        [NameInMap("Skills")]
        [Validation(Required=false)]
        public object Skills { get; set; }

        /// <summary>
        /// <para>The status of the agent. The default status of a newly created agent is <c>draft</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>draft</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The system prompt. This field may not be returned if it is not configured.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Check the correctness, security, and maintainability of code changes in the CR, and provide review comments by severity</para>
        /// </summary>
        [NameInMap("SystemPrompt")]
        [Validation(Required=false)]
        public string SystemPrompt { get; set; }

        /// <summary>
        /// <para>The list of MCP Server and Connector name references. For element fields, see the following section.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;mcpServerName&quot;:&quot;code-repository-mcp&quot;},{&quot;connectorName&quot;:&quot;code-review-data&quot;}]</para>
        /// </summary>
        [NameInMap("Tools")]
        [Validation(Required=false)]
        public object Tools { get; set; }

        /// <summary>
        /// <para>The most recent update time. The value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1788332700000</para>
        /// </summary>
        [NameInMap("UpdatedAt")]
        [Validation(Required=false)]
        public long? UpdatedAt { get; set; }

        /// <summary>
        /// <para>The visibility scope of the agent. Valid values: <c>user</c> and <c>tenant</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

    }

}
