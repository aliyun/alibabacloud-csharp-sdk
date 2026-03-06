// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenAPIExplorer20241130.Models
{
    public class GetApiMcpServerResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of supplementary API descriptions.</para>
        /// </summary>
        [NameInMap("additionalApiDescriptions")]
        [Validation(Required=false)]
        public List<GetApiMcpServerResponseBodyAdditionalApiDescriptions> AdditionalApiDescriptions { get; set; }
        public class GetApiMcpServerResponseBodyAdditionalApiDescriptions : TeaModel {
            /// <summary>
            /// <para>The API name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DescribeRegions</para>
            /// </summary>
            [NameInMap("apiName")]
            [Validation(Required=false)]
            public string ApiName { get; set; }

            /// <summary>
            /// <para>The API metadata in JSON format. For an example of the format, see https\://api.aliyun.com/meta/v1/products/Ecs/versions/2014-05-26/apis/DescribeInstances/api.json. You can overwrite the summary and parameters fields.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;summary&quot;: &quot;本接口支持根据不同请求条件查询实例列表，并关联查询实例的详细信息。&quot;
            /// }</para>
            /// </summary>
            [NameInMap("apiOverrideJson")]
            [Validation(Required=false)]
            public string ApiOverrideJson { get; set; }

            /// <summary>
            /// <para>The POP version of the API that is exposed to the MCP server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2014-05-26</para>
            /// </summary>
            [NameInMap("apiVersion")]
            [Validation(Required=false)]
            public string ApiVersion { get; set; }

            /// <summary>
            /// <para>A list of constant input parameters. These parameters are not included in the output during API parameter parsing.</para>
            /// </summary>
            [NameInMap("constParameters")]
            [Validation(Required=false)]
            public List<GetApiMcpServerResponseBodyAdditionalApiDescriptionsConstParameters> ConstParameters { get; set; }
            public class GetApiMcpServerResponseBodyAdditionalApiDescriptionsConstParameters : TeaModel {
                /// <summary>
                /// <para>The parameter name. Only first-level parameter names are supported. For ROA-style APIs, you can set parameters such as body.xx. You cannot set values that exceed the top-level parameters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>InstanceId</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public object Value { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether to return the schema of the response parameters. Returning the schema increases the size of the entire API MCP server. The default value is null, which means the schema is not returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enableOutputSchema")]
            [Validation(Required=false)]
            public bool? EnableOutputSchema { get; set; }

            /// <summary>
            /// <para>Indicates whether to return the command-line interface (CLI) command. In this mode, the API is not called. Instead, the corresponding CLI command is returned. This is suitable for long-running tasks that need to be executed using Alibaba Cloud CLI.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("executeCliCommand")]
            [Validation(Required=false)]
            public bool? ExecuteCliCommand { get; set; }

            /// <summary>
            /// <para>The product code.</para>
            /// <list type="bullet">
            /// <item><description>Call the GetRequestLog operation to obtain the product code from the response.</description></item>
            /// </list>
            /// <para>&lt;props=&quot;intl&quot;&gt;</para>
            /// <list type="bullet">
            /// <item><description>Find the corresponding product code from the URL of the OpenAPI Portal. For example, the URL of the OpenAPI Portal for Short Message Service is https\://api.alibabacloud.com/product/Dysmsapi. The product code for Short Message Service is Dysmsapi.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Ecs</para>
            /// </summary>
            [NameInMap("product")]
            [Validation(Required=false)]
            public string Product { get; set; }

        }

        /// <summary>
        /// <para>A list of API information for the API MCP service.</para>
        /// </summary>
        [NameInMap("apiInfos")]
        [Validation(Required=false)]
        public List<GetApiMcpServerResponseBodyApiInfos> ApiInfos { get; set; }
        public class GetApiMcpServerResponseBodyApiInfos : TeaModel {
            /// <summary>
            /// <para>The API name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DescribeRegions</para>
            /// </summary>
            [NameInMap("apiName")]
            [Validation(Required=false)]
            public string ApiName { get; set; }

            /// <summary>
            /// <para>The POP version of the API that is exposed to the MCP server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2014-05-26</para>
            /// </summary>
            [NameInMap("apiVersion")]
            [Validation(Required=false)]
            public string ApiVersion { get; set; }

            /// <summary>
            /// <para>The product code.</para>
            /// <list type="bullet">
            /// <item><description>Call the GetRequestLog operation to obtain the product code from the response.</description></item>
            /// </list>
            /// <para>&lt;props=&quot;intl&quot;&gt;</para>
            /// <list type="bullet">
            /// <item><description>Find the corresponding product code from the URL of the OpenAPI Portal. For example, the URL of the OpenAPI Portal for Short Message Service is https\://api.alibabacloud.com/product/Dysmsapi. The product code for Short Message Service is Dysmsapi.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Ecs</para>
            /// </summary>
            [NameInMap("product")]
            [Validation(Required=false)]
            public string Product { get; set; }

        }

        /// <summary>
        /// <para>A list of API information.</para>
        /// </summary>
        [NameInMap("apis")]
        [Validation(Required=false)]
        public List<GetApiMcpServerResponseBodyApis> Apis { get; set; }
        public class GetApiMcpServerResponseBodyApis : TeaModel {
            /// <summary>
            /// <para>The POP version of the API that is exposed to the MCP server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2014-05-26</para>
            /// </summary>
            [NameInMap("apiVersion")]
            [Validation(Required=false)]
            public string ApiVersion { get; set; }

            /// <summary>
            /// <para>The product code.</para>
            /// <list type="bullet">
            /// <item><description>Call the GetRequestLog operation to obtain the product code from the response.</description></item>
            /// </list>
            /// <para>&lt;props=&quot;intl&quot;&gt;</para>
            /// <list type="bullet">
            /// <item><description>Find the corresponding product code from the URL of the OpenAPI Portal. For example, the URL of the OpenAPI Portal for Short Message Service is https\://api.alibabacloud.com/product/Dysmsapi. The product code for Short Message Service is Dysmsapi.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Ecs</para>
            /// </summary>
            [NameInMap("product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            /// <summary>
            /// <para>A list of API name matching rules.</para>
            /// </summary>
            [NameInMap("selectors")]
            [Validation(Required=false)]
            public List<string> Selectors { get; set; }

        }

        /// <summary>
        /// <para>The extra policy for role assumption when multi-account access is enabled. If this policy is specified, the permissions for the role assumption are based on this policy and overwrite the permissions that are defined for the role.</para>
        /// 
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
        /// <para>The name of the RAM role of the destination account that is assumed when you perform cross-account operations with multi-account access enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("assumeRoleName")]
        [Validation(Required=false)]
        public string AssumeRoleName { get; set; }

        /// <summary>
        /// <para>The time when the API MCP server was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-02-07T02:17:46Z</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The description of the API MCP server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>这是一个API MCP 服务器</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Indicates whether to enable multi-account access.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableAssumeRole")]
        [Validation(Required=false)]
        public bool? EnableAssumeRole { get; set; }

        /// <summary>
        /// <para>Indicates whether to enable a custom VPC whitelist. If this parameter is not enabled, the account-level configuration is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableCustomVpcWhitelist")]
        [Validation(Required=false)]
        public bool? EnableCustomVpcWhitelist { get; set; }

        /// <summary>
        /// <para>The ID of the API MCP service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v6ZZ7ftCzEILW***</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The MCP instruction. It prompts the large model on how to use the MCP. The client must support the Instructions field of the standard MCP protocol.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("instructions")]
        [Validation(Required=false)]
        public string Instructions { get; set; }

        /// <summary>
        /// <para>The language of the API documentation for the API MCP service. You can select Chinese or English API documentation. The language of the prompt may affect the AI\&quot;s response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ZH_CN</para>
        /// </summary>
        [NameInMap("language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The name of the MCP server. The name must be 3 to 64 characters in length and can contain lowercase letters and digits. It must not start with a digit. The name must be unique within the same Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mcp-demo</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The custom OAuth client ID when you select a custom OAuth configuration.</para>
        /// <para><c>Only web and native applications are supported. The OAuth scope must include /acs/mcp-server.</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>403*************370</para>
        /// </summary>
        [NameInMap("oauthClientId")]
        [Validation(Required=false)]
        public string OauthClientId { get; set; }

        /// <summary>
        /// <para>A list of prompt configurations.</para>
        /// </summary>
        [NameInMap("prompts")]
        [Validation(Required=false)]
        public List<GetApiMcpServerResponseBodyPrompts> Prompts { get; set; }
        public class GetApiMcpServerResponseBodyPrompts : TeaModel {
            /// <summary>
            /// <para>A list of parameters that the prompt supports.</para>
            /// </summary>
            [NameInMap("arguments")]
            [Validation(Required=false)]
            public List<GetApiMcpServerResponseBodyPromptsArguments> Arguments { get; set; }
            public class GetApiMcpServerResponseBodyPromptsArguments : TeaModel {
                /// <summary>
                /// <para>The description of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>argument description</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The parameter name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Indicates whether this parameter is required.</para>
                /// </summary>
                [NameInMap("required")]
                [Validation(Required=false)]
                public bool? Required { get; set; }

            }

            /// <summary>
            /// <para>The content of the prompt. Variables are specified in the {{xxx}} format. The xxx variable must be defined in the arguments parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prompt正文，{{name}}</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prompt description</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The prompt name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether to enable public access.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("publicAccess")]
        [Validation(Required=false)]
        public string PublicAccess { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9BFC4AC1-6BE4-5405-BDEC-CA288D404812</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The RAM access policy that is required by the API MCP service.</para>
        /// 
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
        /// <para>The type of the API MCP service.</para>
        /// <list type="bullet">
        /// <item><description><para>custom: a custom service</para>
        /// </description></item>
        /// <item><description><para>system: a system service</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>system</para>
        /// </summary>
        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>A list of system MCP services.</para>
        /// </summary>
        [NameInMap("systemMcpServerInfo")]
        [Validation(Required=false)]
        public GetApiMcpServerResponseBodySystemMcpServerInfo SystemMcpServerInfo { get; set; }
        public class GetApiMcpServerResponseBodySystemMcpServerInfo : TeaModel {
            /// <summary>
            /// <para>The name of the system MCP service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mcp-system</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The product code.</para>
            /// <list type="bullet">
            /// <item><description>Call the GetRequestLog operation to obtain the product code from the response.</description></item>
            /// </list>
            /// <para>&lt;props=&quot;intl&quot;&gt;</para>
            /// <list type="bullet">
            /// <item><description>Find the corresponding product code from the URL of the OpenAPI Portal. For example, the URL of the OpenAPI Portal for Short Message Service is https\://api.alibabacloud.com/product/Dysmsapi. The product code for Short Message Service is Dysmsapi.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Ecs</para>
            /// </summary>
            [NameInMap("product")]
            [Validation(Required=false)]
            public string Product { get; set; }

        }

        /// <summary>
        /// <para>A list of system tools.</para>
        /// </summary>
        [NameInMap("systemTools")]
        [Validation(Required=false)]
        public List<string> SystemTools { get; set; }

        /// <summary>
        /// <para>A list of Terraform tools.</para>
        /// </summary>
        [NameInMap("terraformTools")]
        [Validation(Required=false)]
        public List<GetApiMcpServerResponseBodyTerraformTools> TerraformTools { get; set; }
        public class GetApiMcpServerResponseBodyTerraformTools : TeaModel {
            /// <summary>
            /// <para>Indicates whether to execute tasks asynchronously. If set to true, the system immediately starts the next task after the current task is initiated, without waiting for each resource operation to complete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("async")]
            [Validation(Required=false)]
            public bool? Async { get; set; }

            /// <summary>
            /// <para>The code for the Terraform tool. For more information, see <a href="https://help.aliyun.com/zh/terraform/terraform-configuration-and-hcl-language-overview">HCL language overview</a>.</para>
            /// 
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
            /// <para>The description of the Terraform tool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Terraform Tool description</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The destroy policy. After a task is complete, the system applies the following cleanup policy to temporary resources based on the task execution status.</para>
            /// <list type="bullet">
            /// <item><description><para>NEVER: All created resources are retained, regardless of whether the task succeeds or fails.</para>
            /// </description></item>
            /// <item><description><para>ALWAYS: All related resources are immediately destroyed after the task is complete, regardless of whether the task succeeds or fails.</para>
            /// </description></item>
            /// <item><description><para>ON_FAILURE: Related resources are deleted only if the task fails. If the task succeeds, the resources are retained.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ON_FAILURE</para>
            /// </summary>
            [NameInMap("destroyPolicy")]
            [Validation(Required=false)]
            public string DestroyPolicy { get; set; }

            /// <summary>
            /// <para>The name of the Terraform tool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The time when the API MCP server was last modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-02-05T02:26:04Z</para>
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <para>The connection information for the MCP server.</para>
        /// </summary>
        [NameInMap("urls")]
        [Validation(Required=false)]
        public GetApiMcpServerResponseBodyUrls Urls { get; set; }
        public class GetApiMcpServerResponseBodyUrls : TeaModel {
            /// <summary>
            /// <para>The connection information for the streamable HTTP protocol. This protocol is recommended.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://openapi-mcp.cn-hangzhou.aliyuncs.com/accounts/xxxx/custom/xxx/id/xxxx/mcp">https://openapi-mcp.cn-hangzhou.aliyuncs.com/accounts/xxxx/custom/xxx/id/xxxx/mcp</a></para>
            /// </summary>
            [NameInMap("mcp")]
            [Validation(Required=false)]
            public string Mcp { get; set; }

            /// <summary>
            /// <para>The connection information for the Server-Sent Events (SSE) protocol.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://openapi-mcp.cn-hangzhou.aliyuncs.com/accounts/xxxx/custom/xxx/id/xxxx/sse">https://openapi-mcp.cn-hangzhou.aliyuncs.com/accounts/xxxx/custom/xxx/id/xxxx/sse</a></para>
            /// </summary>
            [NameInMap("sse")]
            [Validation(Required=false)]
            public string Sse { get; set; }

            /// <summary>
            /// <para>The endpoint of the streamable HTTP protocol in a VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://openapi-mcp-cn.vpc-proxy.aliyuncs.com/accounts/xxxx/custom/xxx/id/xxxx/mcp">https://openapi-mcp-cn.vpc-proxy.aliyuncs.com/accounts/xxxx/custom/xxx/id/xxxx/mcp</a></para>
            /// </summary>
            [NameInMap("vpcMcp")]
            [Validation(Required=false)]
            public string VpcMcp { get; set; }

            /// <summary>
            /// <para>The endpoint of the SSE protocol in a VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://openapi-mcp-cn.vpc-proxy.aliyuncs.com/accounts/xxxx/custom/xxx/id/xxxx/sse">https://openapi-mcp-cn.vpc-proxy.aliyuncs.com/accounts/xxxx/custom/xxx/id/xxxx/sse</a></para>
            /// </summary>
            [NameInMap("vpcSse")]
            [Validation(Required=false)]
            public string VpcSse { get; set; }

        }

        /// <summary>
        /// <para>The VPC whitelist that specifies the allowed source VPCs after public access is disabled. If you do not set this parameter or leave it empty, access from all sources is allowed.</para>
        /// </summary>
        [NameInMap("vpcWhitelists")]
        [Validation(Required=false)]
        public List<string> VpcWhitelists { get; set; }

    }

}
