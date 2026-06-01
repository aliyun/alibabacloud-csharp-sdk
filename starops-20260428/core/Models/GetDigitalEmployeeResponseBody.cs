// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.STAROps20260428.Models
{
    public class GetDigitalEmployeeResponseBody : TeaModel {
        [NameInMap("attributes")]
        [Validation(Required=false)]
        public Dictionary<string, string> Attributes { get; set; }

        /// <summary>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-03-11T08:21:58Z</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("defaultRule")]
        [Validation(Required=false)]
        public string DefaultRule { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("employeeType")]
        [Validation(Required=false)]
        public string EmployeeType { get; set; }

        [NameInMap("knowledges")]
        [Validation(Required=false)]
        public GetDigitalEmployeeResponseBodyKnowledges Knowledges { get; set; }
        public class GetDigitalEmployeeResponseBodyKnowledges : TeaModel {
            [NameInMap("bailian")]
            [Validation(Required=false)]
            public List<GetDigitalEmployeeResponseBodyKnowledgesBailian> Bailian { get; set; }
            public class GetDigitalEmployeeResponseBodyKnowledgesBailian : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("attributes")]
                [Validation(Required=false)]
                public string Attributes { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>index-xxxx</para>
                /// </summary>
                [NameInMap("indexId")]
                [Validation(Required=false)]
                public string IndexId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>llm-xxxxx</para>
                /// </summary>
                [NameInMap("workspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }

            }

            [NameInMap("sop")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Sop { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0B9377D9-C56B-5C2E-A8A4-************</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rg-ae******ey</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>acs:ram::12345678912:role/testrole</para>
        /// </summary>
        [NameInMap("roleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// <para>数字员工工具调用安全策略配置。</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;aliyun&quot;:{&quot;enable&quot;:true,&quot;statements&quot;:[{&quot;decision&quot;:&quot;user_ack&quot;,&quot;product&quot;:&quot;Sls&quot;,&quot;apiVersion&quot;:&quot;2020-12-30&quot;,&quot;actions&quot;:[&quot;log:GetProject&quot;,&quot;log:CreateDashboard&quot;]}]}}</para>
        /// </summary>
        [NameInMap("toolPolicy")]
        [Validation(Required=false)]
        public GetDigitalEmployeeResponseBodyToolPolicy ToolPolicy { get; set; }
        public class GetDigitalEmployeeResponseBodyToolPolicy : TeaModel {
            /// <summary>
            /// <para>Aliyun MCP 工具调用安全策略配置。</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;enable&quot;:true,&quot;statements&quot;:[{&quot;decision&quot;:&quot;user_ack&quot;,&quot;product&quot;:&quot;Sls&quot;,&quot;apiVersion&quot;:&quot;2020-12-30&quot;,&quot;actions&quot;:[&quot;log:GetProject&quot;,&quot;log:CreateDashboard&quot;]}]}</para>
            /// </summary>
            [NameInMap("aliyun")]
            [Validation(Required=false)]
            public GetDigitalEmployeeResponseBodyToolPolicyAliyun Aliyun { get; set; }
            public class GetDigitalEmployeeResponseBodyToolPolicyAliyun : TeaModel {
                /// <summary>
                /// <para>是否启用 Aliyun MCP 工具策略。</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>Aliyun OpenAPI 工具策略语句列表。</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;decision&quot;:&quot;user_ack&quot;,&quot;product&quot;:&quot;Sls&quot;,&quot;apiVersion&quot;:&quot;2020-12-30&quot;,&quot;actions&quot;:[&quot;log:GetProject&quot;,&quot;log:CreateDashboard&quot;]}]</para>
                /// </summary>
                [NameInMap("statements")]
                [Validation(Required=false)]
                public List<GetDigitalEmployeeResponseBodyToolPolicyAliyunStatements> Statements { get; set; }
                public class GetDigitalEmployeeResponseBodyToolPolicyAliyunStatements : TeaModel {
                    /// <summary>
                    /// <para>Aliyun OpenAPI Action 列表，格式为 product:ApiName、product:Prefix* 或 product:*。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>[&quot;log:GetProject&quot;,&quot;log:CreateDashboard&quot;]</para>
                    /// </summary>
                    [NameInMap("actions")]
                    [Validation(Required=false)]
                    public List<string> Actions { get; set; }

                    /// <summary>
                    /// <para>本条语句对应的 Aliyun OpenAPI API 版本。</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2020-12-30</para>
                    /// </summary>
                    [NameInMap("apiVersion")]
                    [Validation(Required=false)]
                    public string ApiVersion { get; set; }

                    /// <summary>
                    /// <para>命中该 API 后的执行策略。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>user_ack</para>
                    /// </summary>
                    [NameInMap("decision")]
                    [Validation(Required=false)]
                    public string Decision { get; set; }

                    /// <summary>
                    /// <para>本条语句对应的 Aliyun OpenAPI 产品名。</para>
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
