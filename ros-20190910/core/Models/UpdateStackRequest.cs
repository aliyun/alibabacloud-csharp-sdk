// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class UpdateStackRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that the value is unique among different requests.</para>
        /// <para>The token can be up to 64 characters in length, and can contain letters, digits, hyphens (-), and underscores (_).</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/134212.html">Ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Specifies whether to roll back the resources in the stack when the stack fails to be updated.</para>
        /// <para>Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DisableRollback")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? DisableRollback { get; set; }

        /// <summary>
        /// <para>Specifies whether only to validate the stack in the request. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: only validates the stack.</description></item>
        /// <item><description>false: validates and updates the stack.</description></item>
        /// </list>
        /// <remarks>
        /// <para> When no changes are made during the update, the following rules apply: If you set the DryRun parameter to false, the NotSupported error code is returned. If you set the DryRun parameter to true, no error is reported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The dry run option in the list format. You can specify only one dry run option.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when DryRun is set to true.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("DryRunOptions")]
        [Validation(Required=false)]
        public List<string> DryRunOptions { get; set; }

        /// <summary>
        /// <para>The maximum number of concurrent operations that can be performed on resources.</para>
        /// <para>By default, this parameter is empty. You can set this parameter to an integer that is greater than or equal to 0.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you set this parameter to an integer that is greater than 0, the integer is used.</description></item>
        /// <item><description>If you set this parameter to 0, no limit is imposed on Resource Orchestration Service (ROS) stacks. However, the default value in Terraform is used for Terraform stacks. In most cases, the default value in Terraform is 10.</description></item>
        /// <item><description>If you leave this parameter empty, the value that you specified for this parameter in the previous request is used. If you left this parameter empty in the previous request, no limit is imposed on ROS stacks. However, the default value in Terraform is used for Terraform stacks. In most cases, the default value in Terraform is 10.</description></item>
        /// <item><description>If you set this parameter to a specific value, ROS associates the value with the stack. The value affects subsequent operations on the stack.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Parallelism")]
        [Validation(Required=false)]
        public long? Parallelism { get; set; }

        /// <summary>
        /// <para>The parameters.</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<UpdateStackRequestParameters> Parameters { get; set; }
        public class UpdateStackRequestParameters : TeaModel {
            /// <summary>
            /// <para>The name of parameter N. If you do not specify the name and value of a parameter, ROS uses the default name and value in the template.</para>
            /// <para>Maximum value of N: 200.</para>
            /// <remarks>
            /// <para> The Parameters parameter is optional. If you specify Parameters, you must specify both Parameters.N.ParameterKey and Parameters.N.ParameterValue.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Amount</para>
            /// </summary>
            [NameInMap("ParameterKey")]
            [Validation(Required=false)]
            public string ParameterKey { get; set; }

            /// <summary>
            /// <para>The value of parameter N. Maximum value of N: 200.</para>
            /// <remarks>
            /// <para> The Parameters parameter is optional. If you specify Parameters, you must specify both Parameters.N.ParameterKey and Parameters.N.ParameterValue.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

        /// <summary>
        /// <para>The name of the RAM role. Resource Orchestration Service (ROS) assumes the RAM role to create the stack and uses the credentials of the role to call the APIs of Alibaba Cloud services.</para>
        /// <para>ROS assumes the RAM role to perform operations on the stack. If you have permissions to perform operations on the stack but do not have permissions to use the RAM role, ROS still assumes the RAM role. You must make sure that the least privileges are granted to the RAM role.</para>
        /// <para>If you do not specify this parameter, ROS assumes the existing RAM role that is associated with the stack. If no RAM roles are available, ROS uses a temporary credential that is generated from the credentials of your account.</para>
        /// <para>The name of the RAM role can be up to 64 bytes in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-role</para>
        /// </summary>
        [NameInMap("RamRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the stack is deployed. You can call the <a href="https://help.aliyun.com/document_detail/131035.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the replacement update feature. If you cannot change resource properties, you can enable the replacement update feature to replace the resource properties. If the replacement update feature is used, the existing resource is deleted and a new resource is created. The physical ID of the new resource is different from the physical ID of the deleted resource.</para>
        /// <para>Default value: Disabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enabled</description></item>
        /// <item><description>Disabled</description></item>
        /// </list>
        /// <remarks>
        /// <para> Changes have higher priorities than replacement updates.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Disabled</para>
        /// </summary>
        [NameInMap("ReplacementOption")]
        [Validation(Required=false)]
        public string ReplacementOption { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxazb4ph6aiy****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the stack.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</para>
        /// </summary>
        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

        /// <summary>
        /// <para>The structure that contains the stack policy body. The policy body must be 1 to 16,384 bytes in length.</para>
        /// <remarks>
        /// <para> You can specify only one of the StackPolicyBody and StackPolicyURL parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Statement&quot;: [{&quot;Action&quot;: &quot;Update:<em>&quot;, &quot;Resource&quot;: &quot;</em>&quot;, &quot;Effect&quot;: &quot;Allow&quot;, &quot;Principal&quot;: &quot;*&quot;}]}</para>
        /// </summary>
        [NameInMap("StackPolicyBody")]
        [Validation(Required=false)]
        public string StackPolicyBody { get; set; }

        /// <summary>
        /// <para>The structure that contains the body of the temporary overriding stack policy. The policy body must be 1 to 16,384 bytes in length.</para>
        /// <para>If you want to update protected resources, you must specify a temporary overriding stack policy during the update. If you do not specify a temporary overriding stack policy, the existing policy that is associated with the stack is used.</para>
        /// <para>This parameter takes effect only when the ChangeSetType parameter is set to UPDATE. You can specify only one of the following parameters:</para>
        /// <list type="bullet">
        /// <item><description>StackPolicyBody</description></item>
        /// <item><description>StackPolicyURL</description></item>
        /// <item><description>StackPolicyDuringUpdateBody</description></item>
        /// <item><description>StackPolicyDuringUpdateURL</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Statement&quot;: [{&quot;Effect&quot;: &quot;Allow&quot;, &quot;Action&quot;: &quot;Update:<em>&quot;, &quot;Principal&quot;: &quot;</em>&quot;, &quot;Resource&quot;: &quot;*&quot;}]}</para>
        /// </summary>
        [NameInMap("StackPolicyDuringUpdateBody")]
        [Validation(Required=false)]
        public string StackPolicyDuringUpdateBody { get; set; }

        /// <summary>
        /// <para>The URL of the file that contains the temporary overriding stack policy. The URL must point to a policy that is located on an HTTP or HTTPS web server or in an OSS bucket, such as oss://ros/stack-policy/demo or oss://ros/stack-policy/demo?RegionId=cn-hangzhou. The policy file can be up to 16,384 bytes in length.</para>
        /// <remarks>
        /// <para> If you do not specify the region ID of the OSS bucket, the value of the RegionId parameter is used.</para>
        /// </remarks>
        /// <para>The URL can be up to 1,350 bytes in length.</para>
        /// <para>If you want to update protected resources, you must specify a temporary overriding stack policy during the update. If you do not specify a temporary overriding stack policy, the existing policy that is associated with the stack is used. This parameter takes effect only when the ChangeSetType parameter is set to UPDATE. You can specify only one of the following parameters:</para>
        /// <list type="bullet">
        /// <item><description>StackPolicyBody</description></item>
        /// <item><description>StackPolicyURL</description></item>
        /// <item><description>StackPolicyDuringUpdateBody</description></item>
        /// <item><description>StackPolicyDuringUpdateURL</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>oss://ros-stack-policy/demo</para>
        /// </summary>
        [NameInMap("StackPolicyDuringUpdateURL")]
        [Validation(Required=false)]
        public string StackPolicyDuringUpdateURL { get; set; }

        /// <summary>
        /// <para>The URL of the file that contains the stack policy. The URL must point to a policy that is located on an HTTP or HTTPS web server or in an Object Storage Service (OSS) bucket, such as oss://ros/stack-policy/demo or oss://ros/stack-policy/demo?RegionId=cn-hangzhou. The policy file can be up to 16,384 bytes in length. If you do not specify the region ID of the OSS bucket, the value of the RegionId parameter is used.</para>
        /// <remarks>
        /// <para> You can specify only one of the StackPolicyBody and StackPolicyURL parameters.</para>
        /// </remarks>
        /// <para>The URL can be up to 1,350 bytes in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://ros-stack-policy/demo</para>
        /// </summary>
        [NameInMap("StackPolicyURL")]
        [Validation(Required=false)]
        public string StackPolicyURL { get; set; }

        /// <summary>
        /// <para>The value of tag N that you want to add to the template.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<UpdateStackRequestTags> Tags { get; set; }
        public class UpdateStackRequestTags : TeaModel {
            /// <summary>
            /// <para>The key of tag N that you want to add to the stack.</para>
            /// <para>Valid values of N: 1 to 20.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>The Tags parameter is optional. If you specify Tags, you must specify Tags.N.Key.</description></item>
            /// <item><description>The tag of a stack is propagated to each resource that supports the tag feature in the stack. For more information, see <a href="https://help.aliyun.com/document_detail/201421.html">Propagate tags</a>.</description></item>
            /// </list>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>usage</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N that you want to add to the stack.</para>
            /// <para>Valid values of N: 1 to 20.</para>
            /// <remarks>
            /// <para> The tag of a stack is propagated to each resource that supports the tag feature in the stack. For more information, see <a href="https://help.aliyun.com/document_detail/201421.html">Propagate tags</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("TaintResources")]
        [Validation(Required=false)]
        public List<string> TaintResources { get; set; }

        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// <para>The ID of the template. This parameter applies to shared templates and private templates.</para>
        /// <remarks>
        /// <para> You must specify only one of the following parameters: TemplateBody, TemplateURL, and TemplateId.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5ecd1e10-b0e9-4389-a565-e4c15efc****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The URL of the file that contains the template body. The URL must point to a template that is located on an HTTP or HTTPS web server or in an OSS bucket, such as oss://ros/template/demo or oss://ros/template/demo?RegionId=cn-hangzhou. The template body must be 1 to 524,288 bytes in length. If you do not specify the region ID of the OSS bucket, the value of the RegionId parameter is used.</para>
        /// <remarks>
        /// <para> You must specify only one of the following parameters: TemplateBody, TemplateURL, and TemplateId.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>oss://ros-template/demo</para>
        /// </summary>
        [NameInMap("TemplateURL")]
        [Validation(Required=false)]
        public string TemplateURL { get; set; }

        /// <summary>
        /// <para>The version of the template. This parameter takes effect only when the TemplateId parameter is specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public string TemplateVersion { get; set; }

        /// <summary>
        /// <para>The timeout period for the update operation on the stack.</para>
        /// <list type="bullet">
        /// <item><description>Default value: 60.</description></item>
        /// <item><description>Unit: minutes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TimeoutInMinutes")]
        [Validation(Required=false)]
        public long? TimeoutInMinutes { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the values specified in the previous request for the parameters that you do not specify in the current request.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UsePreviousParameters")]
        [Validation(Required=false)]
        public bool? UsePreviousParameters { get; set; }

    }

}
