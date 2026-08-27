// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.STAROps20260428.Models
{
    public class UpdateDigitalEmployeeRequest : TeaModel {
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
        /// <para>test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The display name of the digital employee.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The knowledge base list.</para>
        /// </summary>
        [NameInMap("knowledges")]
        [Validation(Required=false)]
        public UpdateDigitalEmployeeRequestKnowledges Knowledges { get; set; }
        public class UpdateDigitalEmployeeRequestKnowledges : TeaModel {
            /// <summary>
            /// <para>The Bailian knowledge base list.</para>
            /// </summary>
            [NameInMap("bailian")]
            [Validation(Required=false)]
            public List<UpdateDigitalEmployeeRequestKnowledgesBailian> Bailian { get; set; }
            public class UpdateDigitalEmployeeRequestKnowledgesBailian : TeaModel {
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
                /// <para>llm-xxxx</para>
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
        /// <para>The ARN of the RAM role.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::12345678912:role/testrole</para>
        /// </summary>
        [NameInMap("roleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        /// <summary>
        /// <para>The list of CIDRs or IP addresses that are allowed to be accessed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;allowFqdns&quot;:[&quot;api.example.com&quot;],&quot;allowCidrs&quot;:[&quot;1.2.3.0/24&quot;,&quot;8.8.8.8&quot;],&quot;enableAcl&quot;:false}</para>
        /// </summary>
        [NameInMap("sandboxNetworkPolicy")]
        [Validation(Required=false)]
        public UpdateDigitalEmployeeRequestSandboxNetworkPolicy SandboxNetworkPolicy { get; set; }
        public class UpdateDigitalEmployeeRequestSandboxNetworkPolicy : TeaModel {
            /// <summary>
            /// <para>The list of CIDRs or IP addresses that are allowed to be accessed.</para>
            /// </summary>
            [NameInMap("allowCidrs")]
            [Validation(Required=false)]
            public List<string> AllowCidrs { get; set; }

            /// <summary>
            /// <para>The list of FQDNs that are allowed to be accessed.</para>
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
        /// <para>The tool calling security policy configuration of the digital employee.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;aliyun&quot;:{&quot;enable&quot;:true,&quot;statements&quot;:[{&quot;decision&quot;:&quot;user_ack&quot;,&quot;product&quot;:&quot;Sls&quot;,&quot;apiVersion&quot;:&quot;2020-12-30&quot;,&quot;actions&quot;:[&quot;log:GetProject&quot;,&quot;log:CreateDashboard&quot;]}]}}</para>
        /// </summary>
        [NameInMap("toolPolicy")]
        [Validation(Required=false)]
        public UpdateDigitalEmployeeRequestToolPolicy ToolPolicy { get; set; }
        public class UpdateDigitalEmployeeRequestToolPolicy : TeaModel {
            /// <summary>
            /// <para>The Aliyun CLI tool calling security policy configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;enable&quot;:true,&quot;statements&quot;:[{&quot;decision&quot;:&quot;user_ack&quot;,&quot;product&quot;:&quot;Sls&quot;,&quot;apiVersion&quot;:&quot;2020-12-30&quot;,&quot;actions&quot;:[&quot;log:GetProject&quot;,&quot;log:CreateDashboard&quot;]}]}</para>
            /// </summary>
            [NameInMap("aliyun")]
            [Validation(Required=false)]
            public UpdateDigitalEmployeeRequestToolPolicyAliyun Aliyun { get; set; }
            public class UpdateDigitalEmployeeRequestToolPolicyAliyun : TeaModel {
                /// <summary>
                /// <para>The automatic pass-through policy. Each entry is a RAM Action string in the format of product:ApiName, product:Prefix*, or product:<em>. Matched actions are automatically allowed without human confirmation. If this parameter is empty or not configured, built-in read-only actions (Get</em>, List*, Describe*) are automatically allowed. Unmatched actions require human-in-the-loop (HIL) confirmation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;log:Get*&quot;,&quot;log:List*&quot;]</para>
                /// </summary>
                [NameInMap("autoPassPolicy")]
                [Validation(Required=false)]
                public List<string> AutoPassPolicy { get; set; }

                /// <summary>
                /// <para>The explicit deny policy with the highest priority. Each entry is a RAM Action string in the format of product:ApiName, product:Prefix*, or product:*. If this parameter is empty or not configured, no operations are actively denied. STAROps directly denies matched actions. Pop performs secondary enforcement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;ecs:RunCommand&quot;,&quot;ecs:Delete*&quot;]</para>
                /// </summary>
                [NameInMap("denyPolicy")]
                [Validation(Required=false)]
                public List<string> DenyPolicy { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable the policy.</para>
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
                /// <para>The list of Aliyun CLI tool policy statements.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;decision&quot;:&quot;user_ack&quot;,&quot;product&quot;:&quot;Sls&quot;,&quot;apiVersion&quot;:&quot;2020-12-30&quot;,&quot;actions&quot;:[&quot;log:GetProject&quot;,&quot;log:CreateDashboard&quot;]}]</para>
                /// </summary>
                [NameInMap("statements")]
                [Validation(Required=false)]
                [Obsolete]
                public List<UpdateDigitalEmployeeRequestToolPolicyAliyunStatements> Statements { get; set; }
                public class UpdateDigitalEmployeeRequestToolPolicyAliyunStatements : TeaModel {
                    /// <summary>
                    /// <para>RAM action</para>
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
                    /// <para><b>[Deprecated]</b> The API version.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-03-30</para>
                    /// </summary>
                    [NameInMap("apiVersion")]
                    [Validation(Required=false)]
                    [Obsolete]
                    public string ApiVersion { get; set; }

                    /// <summary>
                    /// <para>The execution policy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>user_ack</para>
                    /// </summary>
                    [NameInMap("decision")]
                    [Validation(Required=false)]
                    public string Decision { get; set; }

                    /// <summary>
                    /// <para>The cloud product code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Cms</para>
                    /// </summary>
                    [NameInMap("product")]
                    [Validation(Required=false)]
                    public string Product { get; set; }

                }

            }

        }

    }

}
