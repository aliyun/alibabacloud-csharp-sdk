// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenAPIExplorer20241130.Models
{
    public class GetApiMcpServerResponseBody : TeaModel {
        [NameInMap("additionalApiDescriptions")]
        [Validation(Required=false)]
        public List<GetApiMcpServerResponseBodyAdditionalApiDescriptions> AdditionalApiDescriptions { get; set; }
        public class GetApiMcpServerResponseBodyAdditionalApiDescriptions : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>DescribeRegions</para>
            /// </summary>
            [NameInMap("apiName")]
            [Validation(Required=false)]
            public string ApiName { get; set; }

            [NameInMap("apiOverrideJson")]
            [Validation(Required=false)]
            public string ApiOverrideJson { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2014-05-26</para>
            /// </summary>
            [NameInMap("apiVersion")]
            [Validation(Required=false)]
            public string ApiVersion { get; set; }

            [NameInMap("constParameters")]
            [Validation(Required=false)]
            public List<GetApiMcpServerResponseBodyAdditionalApiDescriptionsConstParameters> ConstParameters { get; set; }
            public class GetApiMcpServerResponseBodyAdditionalApiDescriptionsConstParameters : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>InstanceId</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public object Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enableOutputSchema")]
            [Validation(Required=false)]
            public bool? EnableOutputSchema { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("executeCliCommand")]
            [Validation(Required=false)]
            public bool? ExecuteCliCommand { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Ecs</para>
            /// </summary>
            [NameInMap("product")]
            [Validation(Required=false)]
            public string Product { get; set; }

        }

        [NameInMap("apiInfos")]
        [Validation(Required=false)]
        public List<GetApiMcpServerResponseBodyApiInfos> ApiInfos { get; set; }
        public class GetApiMcpServerResponseBodyApiInfos : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>DescribeRegions</para>
            /// </summary>
            [NameInMap("apiName")]
            [Validation(Required=false)]
            public string ApiName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2014-05-26</para>
            /// </summary>
            [NameInMap("apiVersion")]
            [Validation(Required=false)]
            public string ApiVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Ecs</para>
            /// </summary>
            [NameInMap("product")]
            [Validation(Required=false)]
            public string Product { get; set; }

        }

        [NameInMap("apis")]
        [Validation(Required=false)]
        public List<GetApiMcpServerResponseBodyApis> Apis { get; set; }
        public class GetApiMcpServerResponseBodyApis : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2014-05-26</para>
            /// </summary>
            [NameInMap("apiVersion")]
            [Validation(Required=false)]
            public string ApiVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Ecs</para>
            /// </summary>
            [NameInMap("product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            [NameInMap("selectors")]
            [Validation(Required=false)]
            public List<string> Selectors { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;Version&quot;: &quot;1&quot;,
        ///   &quot;Statement&quot;: [
        ///     {
        ///       &quot;Effect&quot;: &quot;Allow&quot;,
        ///       &quot;Action&quot;: [
        ///         &quot;ecs:Describe*&quot;,
        ///         &quot;vpc:Describe*&quot;,
        ///         &quot;vpc:List*&quot;
        ///       ],
        ///       &quot;Resource&quot;: &quot;*&quot;
        ///     }
        ///   ]
        /// }</para>
        /// </summary>
        [NameInMap("assumeRoleExtraPolicy")]
        [Validation(Required=false)]
        public string AssumeRoleExtraPolicy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("assumeRoleName")]
        [Validation(Required=false)]
        public string AssumeRoleName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-02-07T02:17:46Z</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableAssumeRole")]
        [Validation(Required=false)]
        public bool? EnableAssumeRole { get; set; }

        [NameInMap("enableCustomVpcWhitelist")]
        [Validation(Required=false)]
        public bool? EnableCustomVpcWhitelist { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>v6ZZ7ftCzEILW***</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("instructions")]
        [Validation(Required=false)]
        public string Instructions { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ZH_CN</para>
        /// </summary>
        [NameInMap("language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>mcp-demo</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>403*************370</para>
        /// </summary>
        [NameInMap("oauthClientId")]
        [Validation(Required=false)]
        public string OauthClientId { get; set; }

        [NameInMap("prompts")]
        [Validation(Required=false)]
        public List<GetApiMcpServerResponseBodyPrompts> Prompts { get; set; }
        public class GetApiMcpServerResponseBodyPrompts : TeaModel {
            [NameInMap("arguments")]
            [Validation(Required=false)]
            public List<GetApiMcpServerResponseBodyPromptsArguments> Arguments { get; set; }
            public class GetApiMcpServerResponseBodyPromptsArguments : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>argument description</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("required")]
                [Validation(Required=false)]
                public bool? Required { get; set; }

            }

            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>prompt description</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("publicAccess")]
        [Validation(Required=false)]
        public string PublicAccess { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9BFC4AC1-6BE4-5405-BDEC-CA288D404812</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;Version&quot;: &quot;1&quot;,
        ///   &quot;Statement&quot;: [
        ///     {
        ///       &quot;Effect&quot;: &quot;Allow&quot;,
        ///       &quot;Action&quot;: [
        ///         &quot;ecs:Describe*&quot;,
        ///         &quot;vpc:Describe*&quot;,
        ///         &quot;vpc:List*&quot;
        ///       ],
        ///       &quot;Resource&quot;: &quot;*&quot;
        ///     }
        ///   ]
        /// }</para>
        /// </summary>
        [NameInMap("requiredRAMPolicy")]
        [Validation(Required=false)]
        public string RequiredRAMPolicy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>system</para>
        /// </summary>
        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        [NameInMap("systemMcpServerInfo")]
        [Validation(Required=false)]
        public GetApiMcpServerResponseBodySystemMcpServerInfo SystemMcpServerInfo { get; set; }
        public class GetApiMcpServerResponseBodySystemMcpServerInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>mcp-system</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Ecs</para>
            /// </summary>
            [NameInMap("product")]
            [Validation(Required=false)]
            public string Product { get; set; }

        }

        [NameInMap("systemTools")]
        [Validation(Required=false)]
        public List<string> SystemTools { get; set; }

        [NameInMap("terraformTools")]
        [Validation(Required=false)]
        public List<GetApiMcpServerResponseBodyTerraformTools> TerraformTools { get; set; }
        public class GetApiMcpServerResponseBodyTerraformTools : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("async")]
            [Validation(Required=false)]
            public bool? Async { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>variable &quot;name&quot; {
            ///   default = &quot;terraform-example&quot;
            /// }</para>
            /// <para>provider &quot;alicloud&quot; {
            ///   region = &quot;cn-beijing&quot;
            /// }</para>
            /// <para>resource &quot;alicloud_vpc&quot; &quot;default&quot; {
            ///   ipv6_isp    = &quot;BGP&quot;
            ///   description = &quot;test&quot;
            ///   cidr_block  = &quot;10.0.0.0/8&quot;
            ///   vpc_name    = var.name
            ///   enable_ipv6 = true
            /// }</para>
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Terraform Tool description</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ON_FAILURE</para>
            /// </summary>
            [NameInMap("destroyPolicy")]
            [Validation(Required=false)]
            public string DestroyPolicy { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-02-05T02:26:04Z</para>
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        [NameInMap("urls")]
        [Validation(Required=false)]
        public GetApiMcpServerResponseBodyUrls Urls { get; set; }
        public class GetApiMcpServerResponseBodyUrls : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://mcpserverinner-pre.cn-zhangjiakou.aliyuncs.com/accounts/xxxx/custom/xxx/id/xxxx/mcp">https://mcpserverinner-pre.cn-zhangjiakou.aliyuncs.com/accounts/xxxx/custom/xxx/id/xxxx/mcp</a></para>
            /// </summary>
            [NameInMap("mcp")]
            [Validation(Required=false)]
            public string Mcp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://mcpserverinner-pre.cn-zhangjiakou.aliyuncs.com/accounts/xxxx/custom/xxx/id/xxxx/sse">https://mcpserverinner-pre.cn-zhangjiakou.aliyuncs.com/accounts/xxxx/custom/xxx/id/xxxx/sse</a></para>
            /// </summary>
            [NameInMap("sse")]
            [Validation(Required=false)]
            public string Sse { get; set; }

            [NameInMap("vpcMcp")]
            [Validation(Required=false)]
            public string VpcMcp { get; set; }

            [NameInMap("vpcSse")]
            [Validation(Required=false)]
            public string VpcSse { get; set; }

        }

        [NameInMap("vpcWhitelists")]
        [Validation(Required=false)]
        public List<string> VpcWhitelists { get; set; }

    }

}
