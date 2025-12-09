// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenAPIExplorer20241130.Models
{
    public class UpdateApiMcpServerRequest : TeaModel {
        [NameInMap("additionalApiDescriptions")]
        [Validation(Required=false)]
        public List<UpdateApiMcpServerRequestAdditionalApiDescriptions> AdditionalApiDescriptions { get; set; }
        public class UpdateApiMcpServerRequestAdditionalApiDescriptions : TeaModel {
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
            public List<UpdateApiMcpServerRequestAdditionalApiDescriptionsConstParameters> ConstParameters { get; set; }
            public class UpdateApiMcpServerRequestAdditionalApiDescriptionsConstParameters : TeaModel {
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

        [NameInMap("apis")]
        [Validation(Required=false)]
        public List<UpdateApiMcpServerRequestApis> Apis { get; set; }
        public class UpdateApiMcpServerRequestApis : TeaModel {
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
        /// <para>403*************370</para>
        /// </summary>
        [NameInMap("oauthClientId")]
        [Validation(Required=false)]
        public string OauthClientId { get; set; }

        [NameInMap("prompts")]
        [Validation(Required=false)]
        public List<UpdateApiMcpServerRequestPrompts> Prompts { get; set; }
        public class UpdateApiMcpServerRequestPrompts : TeaModel {
            [NameInMap("arguments")]
            [Validation(Required=false)]
            public List<UpdateApiMcpServerRequestPromptsArguments> Arguments { get; set; }
            public class UpdateApiMcpServerRequestPromptsArguments : TeaModel {
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
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

        [NameInMap("systemTools")]
        [Validation(Required=false)]
        public List<string> SystemTools { get; set; }

        [NameInMap("terraformTools")]
        [Validation(Required=false)]
        public List<UpdateApiMcpServerRequestTerraformTools> TerraformTools { get; set; }
        public class UpdateApiMcpServerRequestTerraformTools : TeaModel {
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
            /// <para>Terraform Tool  description</para>
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

        [NameInMap("vpcWhitelists")]
        [Validation(Required=false)]
        public List<string> VpcWhitelists { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
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
