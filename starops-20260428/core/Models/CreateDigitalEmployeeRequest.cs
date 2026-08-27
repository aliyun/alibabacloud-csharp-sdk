// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.STAROps20260428.Models
{
    public class CreateDigitalEmployeeRequest : TeaModel {
        /// <summary>
        /// <para>The attributes.</para>
        /// </summary>
        [NameInMap("attributes")]
        [Validation(Required=false)]
        public Dictionary<string, string> Attributes { get; set; }

        /// <summary>
        /// <para>The default rule of the digital employee.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("defaultRule")]
        [Validation(Required=false)]
        public string DefaultRule { get; set; }

        /// <summary>
        /// <para>The description of the digital employee.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aaa</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The display name of the digital employee.</para>
        /// 
        /// <b>Example:</b>
        /// <para>digial-employee-test</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The knowledge base list.</para>
        /// </summary>
        [NameInMap("knowledges")]
        [Validation(Required=false)]
        public CreateDigitalEmployeeRequestKnowledges Knowledges { get; set; }
        public class CreateDigitalEmployeeRequestKnowledges : TeaModel {
            /// <summary>
            /// <para>The Bailian knowledge base list.</para>
            /// </summary>
            [NameInMap("bailian")]
            [Validation(Required=false)]
            public List<CreateDigitalEmployeeRequestKnowledgesBailian> Bailian { get; set; }
            public class CreateDigitalEmployeeRequestKnowledgesBailian : TeaModel {
                /// <summary>
                /// <para>The knowledge base attributes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("attributes")]
                [Validation(Required=false)]
                public string Attributes { get; set; }

                /// <summary>
                /// <para>The Bailian index ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>index-xxxx</para>
                /// </summary>
                [NameInMap("indexId")]
                [Validation(Required=false)]
                public string IndexId { get; set; }

                /// <summary>
                /// <para>The region of the knowledge base.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The Bailian workspace ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>llm-xxxxx</para>
                /// </summary>
                [NameInMap("workspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }

            }

            /// <summary>
            /// <para>The SOP knowledge base list.</para>
            /// </summary>
            [NameInMap("sop")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Sop { get; set; }

        }

        /// <summary>
        /// <para>The name of the digital employee.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-ae******ey</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The ARN of the RAM role.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::12345678912:role/testrole</para>
        /// </summary>
        [NameInMap("roleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        /// <summary>
        /// <para>The sandbox network ACL policy configuration of the digital employee.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;allowFqdns&quot;:[&quot;api.example.com&quot;],&quot;allowCidrs&quot;:[&quot;1.2.3.0/24&quot;,&quot;8.8.8.8&quot;],&quot;enableAcl&quot;:false}</para>
        /// </summary>
        [NameInMap("sandboxNetworkPolicy")]
        [Validation(Required=false)]
        public CreateDigitalEmployeeRequestSandboxNetworkPolicy SandboxNetworkPolicy { get; set; }
        public class CreateDigitalEmployeeRequestSandboxNetworkPolicy : TeaModel {
            /// <summary>
            /// <para>The list of allowed CIDRs or IP addresses. A maximum of 50 entries are supported.</para>
            /// </summary>
            [NameInMap("allowCidrs")]
            [Validation(Required=false)]
            public List<string> AllowCidrs { get; set; }

            /// <summary>
            /// <para>The list of allowed FQDNs. A maximum of 50 entries are supported.</para>
            /// </summary>
            [NameInMap("allowFqdns")]
            [Validation(Required=false)]
            public List<string> AllowFqdns { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the sandbox network ACL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("enableAcl")]
            [Validation(Required=false)]
            public bool? EnableAcl { get; set; }

        }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// <para>The tool calling security policy configuration of the digital employee.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;aliyun&quot;:{&quot;enable&quot;:true,&quot;denyPolicy&quot;:[&quot;ecs:RunCommand&quot;,&quot;ecs:Delete*&quot;],&quot;autoPassPolicy&quot;:[&quot;log:Get*&quot;,&quot;log:List*&quot;],&quot;statements&quot;:[{&quot;decision&quot;:&quot;user_ack&quot;,&quot;product&quot;:&quot;Sls&quot;,&quot;apiVersion&quot;:&quot;2020-12-30&quot;,&quot;actions&quot;:[&quot;log:GetProject&quot;,&quot;log:CreateDashboard&quot;]}]}}</para>
        /// </summary>
        [NameInMap("toolPolicy")]
        [Validation(Required=false)]
        public CreateDigitalEmployeeRequestToolPolicy ToolPolicy { get; set; }
        public class CreateDigitalEmployeeRequestToolPolicy : TeaModel {
            /// <summary>
            /// <para>The Aliyun MCP tool calling security policy configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;enable&quot;:true,&quot;denyPolicy&quot;:[&quot;ecs:RunCommand&quot;,&quot;ecs:Delete*&quot;],&quot;autoPassPolicy&quot;:[&quot;log:Get*&quot;,&quot;log:List*&quot;],&quot;statements&quot;:[{&quot;decision&quot;:&quot;user_ack&quot;,&quot;product&quot;:&quot;Sls&quot;,&quot;apiVersion&quot;:&quot;2020-12-30&quot;,&quot;actions&quot;:[&quot;log:GetProject&quot;,&quot;log:CreateDashboard&quot;]}]}</para>
            /// </summary>
            [NameInMap("aliyun")]
            [Validation(Required=false)]
            public CreateDigitalEmployeeRequestToolPolicyAliyun Aliyun { get; set; }
            public class CreateDigitalEmployeeRequestToolPolicyAliyun : TeaModel {
                /// <summary>
                /// <para>The auto-pass policy. Entries are RAM Action strings in the format of product:ApiName, product:Prefix*, or product:<em>. Matched requests are automatically passed without human confirmation. If this parameter is empty or not configured, built-in read-only actions (Get</em>, List*, Describe*) are automatically passed. Unmatched requests require human-in-the-loop (HIL) confirmation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;log:Get*&quot;,&quot;log:List*&quot;]</para>
                /// </summary>
                [NameInMap("autoPassPolicy")]
                [Validation(Required=false)]
                public List<string> AutoPassPolicy { get; set; }

                /// <summary>
                /// <para>The explicit deny policy with the highest priority. Entries are RAM Action strings in the format of product:ApiName, product:Prefix*, or product:*. If this parameter is empty or not configured, no operations are actively denied. When matched by STAROps, the request is directly denied. Pop performs a secondary fallback check.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;ecs:RunCommand&quot;,&quot;ecs:Delete*&quot;]</para>
                /// </summary>
                [NameInMap("denyPolicy")]
                [Validation(Required=false)]
                public List<string> DenyPolicy { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable the Aliyun MCP tool policy. The policy is enabled by default and is disabled only when this parameter is explicitly set to false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <term><b>Obsolete</b></term>
                /// 
                /// <summary>
                /// <para><b>[Deprecated]</b> Use denyPolicy and autoPassPolicy instead. This parameter is still returned during the transition period. Original description: The list of Aliyun OpenAPI tool policy statements.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;decision&quot;:&quot;user_ack&quot;,&quot;product&quot;:&quot;Sls&quot;,&quot;apiVersion&quot;:&quot;2020-12-30&quot;,&quot;actions&quot;:[&quot;log:GetProject&quot;,&quot;log:CreateDashboard&quot;]}]</para>
                /// </summary>
                [NameInMap("statements")]
                [Validation(Required=false)]
                [Obsolete]
                public List<CreateDigitalEmployeeRequestToolPolicyAliyunStatements> Statements { get; set; }
                public class CreateDigitalEmployeeRequestToolPolicyAliyunStatements : TeaModel {
                    /// <summary>
                    /// <para>The list of Aliyun OpenAPI actions. Format: product:ApiName, product:Prefix*, or product:*.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>[&quot;log:GetProject&quot;,&quot;log:CreateDashboard&quot;]</para>
                    /// </summary>
                    [NameInMap("actions")]
                    [Validation(Required=false)]
                    public List<string> Actions { get; set; }

                    /// <term><b>Obsolete</b></term>
                    /// 
                    /// <summary>
                    /// <para>The Aliyun OpenAPI version that this statement applies to.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2020-12-30</para>
                    /// </summary>
                    [NameInMap("apiVersion")]
                    [Validation(Required=false)]
                    [Obsolete]
                    public string ApiVersion { get; set; }

                    /// <summary>
                    /// <para>The execution policy when the API is matched.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>user_ack</para>
                    /// </summary>
                    [NameInMap("decision")]
                    [Validation(Required=false)]
                    public string Decision { get; set; }

                    /// <summary>
                    /// <para>The Aliyun OpenAPI product name that this statement applies to.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Sls</para>
                    /// </summary>
                    [NameInMap("product")]
                    [Validation(Required=false)]
                    public string Product { get; set; }

                }

            }

        }

    }

}
