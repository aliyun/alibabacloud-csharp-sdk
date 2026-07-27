// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.STAROps20260428.Models
{
    public class GetDigitalEmployeeResponseBody : TeaModel {
        /// <summary>
        /// <para>The attributes.</para>
        /// </summary>
        [NameInMap("attributes")]
        [Validation(Required=false)]
        public Dictionary<string, string> Attributes { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-03-11T08:21:58Z</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

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
        /// <para>The type of the digital employee.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("employeeType")]
        [Validation(Required=false)]
        public string EmployeeType { get; set; }

        /// <summary>
        /// <para>The knowledge base list.</para>
        /// </summary>
        [NameInMap("knowledges")]
        [Validation(Required=false)]
        public GetDigitalEmployeeResponseBodyKnowledges Knowledges { get; set; }
        public class GetDigitalEmployeeResponseBodyKnowledges : TeaModel {
            /// <summary>
            /// <para>The Bailian knowledge base list.</para>
            /// </summary>
            [NameInMap("bailian")]
            [Validation(Required=false)]
            public List<GetDigitalEmployeeResponseBodyKnowledgesBailian> Bailian { get; set; }
            public class GetDigitalEmployeeResponseBodyKnowledgesBailian : TeaModel {
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
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0B9377D9-C56B-5C2E-A8A4-************</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::12345678912:role/testrole</para>
        /// </summary>
        [NameInMap("roleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        /// <summary>
        /// <para>The sandbox network ACL policy configuration for the digital employee.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;allowFqdns&quot;:[&quot;api.example.com&quot;],&quot;allowCidrs&quot;:[&quot;1.2.3.0/24&quot;,&quot;8.8.8.8&quot;],&quot;enableAcl&quot;:false}</para>
        /// </summary>
        [NameInMap("sandboxNetworkPolicy")]
        [Validation(Required=false)]
        public GetDigitalEmployeeResponseBodySandboxNetworkPolicy SandboxNetworkPolicy { get; set; }
        public class GetDigitalEmployeeResponseBodySandboxNetworkPolicy : TeaModel {
            /// <summary>
            /// <para>The list of allowed CIDRs or IP addresses.</para>
            /// </summary>
            [NameInMap("allowCidrs")]
            [Validation(Required=false)]
            public List<string> AllowCidrs { get; set; }

            /// <summary>
            /// <para>The list of allowed FQDNs.</para>
            /// </summary>
            [NameInMap("allowFqdns")]
            [Validation(Required=false)]
            public List<string> AllowFqdns { get; set; }

            /// <summary>
            /// <para>Indicates whether the sandbox network ACL is enabled.</para>
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
        /// <para>The tool policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;aliyun&quot;:{&quot;enable&quot;:true,&quot;statements&quot;:[{&quot;decision&quot;:&quot;user_ack&quot;,&quot;product&quot;:&quot;Sls&quot;,&quot;apiVersion&quot;:&quot;2020-12-30&quot;,&quot;actions&quot;:[&quot;log:GetProject&quot;,&quot;log:CreateDashboard&quot;]}]}}</para>
        /// </summary>
        [NameInMap("toolPolicy")]
        [Validation(Required=false)]
        public GetDigitalEmployeeResponseBodyToolPolicy ToolPolicy { get; set; }
        public class GetDigitalEmployeeResponseBodyToolPolicy : TeaModel {
            /// <summary>
            /// <para>The security policy configuration for Aliyun CLI tool calling.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;enable&quot;:true,&quot;statements&quot;:[{&quot;decision&quot;:&quot;user_ack&quot;,&quot;product&quot;:&quot;Sls&quot;,&quot;apiVersion&quot;:&quot;2020-12-30&quot;,&quot;actions&quot;:[&quot;log:GetProject&quot;,&quot;log:CreateDashboard&quot;]}]}</para>
            /// </summary>
            [NameInMap("aliyun")]
            [Validation(Required=false)]
            public GetDigitalEmployeeResponseBodyToolPolicyAliyun Aliyun { get; set; }
            public class GetDigitalEmployeeResponseBodyToolPolicyAliyun : TeaModel {
                /// <summary>
                /// <para>Indicates whether the policy is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The list of Aliyun CLI tool policy statements.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;decision&quot;:&quot;user_ack&quot;,&quot;product&quot;:&quot;Sls&quot;,&quot;apiVersion&quot;:&quot;2020-12-30&quot;,&quot;actions&quot;:[&quot;log:GetProject&quot;,&quot;log:CreateDashboard&quot;]}]</para>
                /// </summary>
                [NameInMap("statements")]
                [Validation(Required=false)]
                public List<GetDigitalEmployeeResponseBodyToolPolicyAliyunStatements> Statements { get; set; }
                public class GetDigitalEmployeeResponseBodyToolPolicyAliyunStatements : TeaModel {
                    /// <summary>
                    /// <para>The list of RAM actions.</para>
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
                    /// <para>The API version.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2020-12-30</para>
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
                    /// <para>This parameter is required.</para>
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

        /// <summary>
        /// <para>The update time.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-02-18T02:25:06Z</para>
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
