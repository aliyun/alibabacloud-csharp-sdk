// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenAPIExplorer20241130.Models
{
    public class UpdateApiMcpServerRequest : TeaModel {
        /// <summary>
        /// <para>A list of supplementary API descriptions.</para>
        /// </summary>
        [NameInMap("additionalApiDescriptions")]
        [Validation(Required=false)]
        public List<UpdateApiMcpServerRequestAdditionalApiDescriptions> AdditionalApiDescriptions { get; set; }
        public class UpdateApiMcpServerRequestAdditionalApiDescriptions : TeaModel {
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
            /// <para>The API metadata in JSON format. For more information about the format, see https\://api.aliyun.com/meta/v1/products/Ecs/versions/2014-05-26/apis/DescribeInstances/api.json. You can overwrite the summary and parameters fields.</para>
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
            public List<UpdateApiMcpServerRequestAdditionalApiDescriptionsConstParameters> ConstParameters { get; set; }
            public class UpdateApiMcpServerRequestAdditionalApiDescriptionsConstParameters : TeaModel {
                /// <summary>
                /// <para>The parameter name. Only first-level parameter names are supported. For ROA-style APIs, you can set parameters such as body.xx. You cannot set values for parameters beyond the top level.</para>
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
            /// <para>Specifies whether to return the schema of the response parameters. Returning the response parameter schema increases the overall size of the API MCP server. The default value is null, which means the response parameter schema is not returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enableOutputSchema")]
            [Validation(Required=false)]
            public bool? EnableOutputSchema { get; set; }

            /// <summary>
            /// <para>Specifies whether to return the command-line interface (CLI) command for execution. In this mode, the API call is not actually executed. Instead, the corresponding CLI command is returned. This is suitable for long-running tasks that need to be executed using Alibaba Cloud CLI.</para>
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
            /// <item><description><para>Call the GetRequestLog operation to obtain the product code from the response.</para>
            /// </description></item>
            /// <item><description><para>Find the product code from the URL of the product in OpenAPI Explorer. For example, the URL for Short Message Service is https\://api.alibabacloud.com/product/Dysmsapi. The product code is \<c>Dysmsapi\\</c>.</para>
            /// </description></item>
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
        /// <para>The list of APIs to modify.</para>
        /// </summary>
        [NameInMap("apis")]
        [Validation(Required=false)]
        public List<UpdateApiMcpServerRequestApis> Apis { get; set; }
        public class UpdateApiMcpServerRequestApis : TeaModel {
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
            /// <item><description><para>Call the GetRequestLog operation to obtain the product code from the response.</para>
            /// </description></item>
            /// <item><description><para>Find the product code from the URL of the product in OpenAPI Explorer. For example, the URL for Short Message Service is https\://api.alibabacloud.com/product/Dysmsapi. The product code is \<c>Dysmsapi\\</c>.</para>
            /// </description></item>
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
        /// <para>An additional policy for role assumption when multi-account access is enabled. If this policy exists, the permissions for the role assumption are based on this policy, which overwrites the permissions defined for the role itself.</para>
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
        /// <para>The name of the RAM role in the destination account that is assumed for cross-account operations when multi-account access is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("assumeRoleName")]
        [Validation(Required=false)]
        public string AssumeRoleName { get; set; }

        /// <summary>
        /// <para>The description of the API MCP server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>这是一个API MCP服务器。</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable multi-account access.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableAssumeRole")]
        [Validation(Required=false)]
        public bool? EnableAssumeRole { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable a custom VPC whitelist. If this is disabled, the account-level configuration is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableCustomVpcWhitelist")]
        [Validation(Required=false)]
        public bool? EnableCustomVpcWhitelist { get; set; }

        /// <summary>
        /// <para>The MCP instruction. It prompts the large language model on how to use this MCP. The client must support the Instructions field of the standard MCP protocol.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("instructions")]
        [Validation(Required=false)]
        public string Instructions { get; set; }

        /// <summary>
        /// <para>The language of the API documentation for the API MCP service. You can select Chinese or English. Different language prompts may affect the AI\&quot;s response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ZH_CN</para>
        /// </summary>
        [NameInMap("language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The custom OAuth client ID to use when you select a custom OAuth configuration.</para>
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
        public List<UpdateApiMcpServerRequestPrompts> Prompts { get; set; }
        public class UpdateApiMcpServerRequestPrompts : TeaModel {
            /// <summary>
            /// <para>A list of parameters that the prompt supports.</para>
            /// </summary>
            [NameInMap("arguments")]
            [Validation(Required=false)]
            public List<UpdateApiMcpServerRequestPromptsArguments> Arguments { get; set; }
            public class UpdateApiMcpServerRequestPromptsArguments : TeaModel {
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
                /// <para>Specifies whether the parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
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
        /// <para>Specifies whether to enable public network access.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("publicAccess")]
        [Validation(Required=false)]
        public string PublicAccess { get; set; }

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
        public List<UpdateApiMcpServerRequestTerraformTools> TerraformTools { get; set; }
        public class UpdateApiMcpServerRequestTerraformTools : TeaModel {
            /// <summary>
            /// <para>Specifies whether to execute the task asynchronously. If this is enabled, the system immediately proceeds to the next task after it initiates a task execution, without waiting for each resource operation to complete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("async")]
            [Validation(Required=false)]
            public bool? Async { get; set; }

            /// <summary>
            /// <para>The Terraform tool code. For more information, see <a href="https://www.alibabacloud.com/help/en/terraform/latest/hcl-language-overview">HCL language overview</a>.</para>
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
            /// <para>Terraform Tool  description</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The deletion policy. After a task is executed, the system applies one of the following cleanup policies to the temporary resources based on the task execution status.</para>
            /// <list type="bullet">
            /// <item><description><para>NEVER: Does not delete any created resources, regardless of whether the task succeeds or fails.</para>
            /// </description></item>
            /// <item><description><para>ALWAYS: Immediately destroys all related resources after execution, regardless of whether the task succeeds or fails.</para>
            /// </description></item>
            /// <item><description><para>ON_FAILURE: Deletes related resources only if the task fails. If the task succeeds, the resources are retained.</para>
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
        /// <para>The VPC whitelist that specifies the allowed source VPCs after public network access is disabled. If you do not set this parameter or leave it empty, access from all sources is allowed.</para>
        /// </summary>
        [NameInMap("vpcWhitelists")]
        [Validation(Required=false)]
        public List<string> VpcWhitelists { get; set; }

        /// <summary>
        /// <para>A client token that you can use to ensure the idempotence of the request. Generate a unique value from your client. The token can contain only ASCII characters and must be no more than 64 characters long. We recommend that you use a UUID. The token is valid for three days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the API MCP service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v6ZZ7ftCzEILW***</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

    }

}
