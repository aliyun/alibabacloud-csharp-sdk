// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class CreateStackRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can be up to 64 characters in length, and can contain letters, digits, hyphens (-), and underscores (_).</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/134212.html">Ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The creation option for the stack. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>KeepStackOnCreationComplete (default): After the stack is created, the stack and its resources are retained. The quota for the maximum number of stacks that can be created in ROS is consumed.</description></item>
        /// <item><description>AbandonStackOnCreationComplete: After the stack is created, the stack is deleted, but its resources are retained. The quota for the maximum number of stacks that can be created in ROS is not consumed. If the stack fails to be created, the stack is retained.</description></item>
        /// <item><description>AbandonStackOnCreationRollbackComplete: When the resources of the stack are rolled back after the stack fails to be created, the stack is deleted. The quota for the maximum number of stacks that can be created in ROS is not consumed. In other rollback scenarios, the stack is retained.</description></item>
        /// <item><description>ManuallyPay: When you create the stack, you must manually pay for the subscription resources that are used. The following resource types support manual payment: <c>ALIYUN::ECS::InstanceGroup</c>, <c>ALIYUN::RDS::DBInstance</c>, <c>ALIYUN::SLB::LoadBalancer</c>, <c>ALIYUN::VPC::EIP</c>, and <c>ALIYUN::VPC::VpnGateway</c>.</description></item>
        /// </list>
        /// <remarks>
        /// <para> You can specify only one of CreateOption and CreateOptions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>KeepStackOnCreationComplete</para>
        /// </summary>
        [NameInMap("CreateOption")]
        [Validation(Required=false)]
        public string CreateOption { get; set; }

        /// <summary>
        /// <para>The creation options for the stack.</para>
        /// </summary>
        [NameInMap("CreateOptions")]
        [Validation(Required=false)]
        public List<string> CreateOptions { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable deletion protection for the stack. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enabled.</description></item>
        /// <item><description>Disabled (default). If deletion protection is disabled, you can delete the stack by using the ROS console or by calling the DeleteStack operation.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The value of DeletionProtection that you specify for the root stack applies to its nested stacks.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public string DeletionProtection { get; set; }

        /// <summary>
        /// <para>Specifies whether to disable rollback for the resources when the stack fails to be created.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DisableRollback")]
        [Validation(Required=false)]
        public bool? DisableRollback { get; set; }

        /// <summary>
        /// <para>The callback URLs that are used to receive stack events. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>HTTP POST URL</description></item>
        /// </list>
        /// <para>Each URL can be up to 1,024 bytes in length.</para>
        /// <list type="bullet">
        /// <item><description>eventbridge</description></item>
        /// </list>
        /// <para>When the status of a stack changes, ROS sends notifications to the EventBridge service. You can view the event information in the <a href="https://eventbridge.console.aliyun.com">EventBridge</a> console.</para>
        /// <remarks>
        /// <para>This feature is supported in the China (Hangzhou), China (Shanghai), China (Beijing), China (Hong Kong), and China (Zhangjiakou) regions.</para>
        /// </remarks>
        /// <para>Maximum value of N: 5. When the status of a stack changes, ROS sends a notification to the specified URL. When rollback is enabled for the stack, notifications are sent if the stack is in the CREATE_ROLLBACK or ROLLBACK state, but are not sent if the stack is in the CREATE_FAILED, UPDATE_FAILED, or IN_PROGRESS state.\
        /// ROS sends notifications regardless of whether you specify the Outputs section. The following sample code provides an example on the content of a notification:</para>
        /// <pre><c>{
        ///    &quot;Outputs&quot;: [
        ///        {
        ///            &quot;Description&quot;: &quot;No description given&quot;,
        ///            &quot;OutputKey&quot;: &quot;InstanceId&quot;,
        ///            &quot;OutputValue&quot;: &quot;i-xxx&quot;
        ///        }
        ///    ],
        ///    &quot;StackId&quot;: &quot;80bd6b6c-e888-4573-ae3b-93d29113****&quot;,
        ///    &quot;StackName&quot;: &quot;test-notification-url&quot;,
        ///    &quot;Status&quot;: &quot;CREATE_COMPLETE&quot;
        /// }
        /// </c></pre>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://my-site.com/ros-event">http://my-site.com/ros-event</a></para>
        /// </summary>
        [NameInMap("NotificationURLs")]
        [Validation(Required=false)]
        public List<string> NotificationURLs { get; set; }

        /// <summary>
        /// <para>The maximum number of concurrent operations that can be performed on resources.</para>
        /// <para>By default, this parameter is empty. You can set this parameter to an integer that is greater than or equal to 0.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you set this parameter to an integer that is greater than 0, the integer is used. If you set this parameter to 0 or leave this parameter empty, no limit is imposed on ROS stacks. However, the default value in Terraform is used for Terraform stacks. In most cases, the default value in Terraform is 10.</description></item>
        /// <item><description>If you set this parameter to a specific value, ROS associates the value with the stack. The value affects subsequent operations on the stack, such as an update operation.</description></item>
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
        /// <para>The parameters that are defined in the template.</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<CreateStackRequestParameters> Parameters { get; set; }
        public class CreateStackRequestParameters : TeaModel {
            /// <summary>
            /// <para>The key of parameter N that is defined in the template. If you do not specify the name and value of a parameter, ROS uses the default name and value that are specified in the template.</para>
            /// <para>Maximum value of N: 200.\
            /// The name must be 1 to 128 characters in length, and cannot contain <c>http://</c> or <c>https://</c>. It cannot start with <c>aliyun</c> or <c>acs:</c>.</para>
            /// <remarks>
            /// <para>The Parameters parameter is optional. If you specify Parameters, you must specify Parameters.N.ParameterKey and Parameters.N.ParameterValue.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>InstanceId</para>
            /// </summary>
            [NameInMap("ParameterKey")]
            [Validation(Required=false)]
            public string ParameterKey { get; set; }

            /// <summary>
            /// <para>The value of parameter N that is defined in the template.</para>
            /// <para>Maximum value of N: 200.\
            /// The value can be up to 128 characters in length, and cannot contain <c>http://</c> or <c>https://</c>. It cannot start with <c>aliyun</c> or <c>acs:</c>.</para>
            /// <remarks>
            /// <para>The Parameters parameter is optional. If you specify Parameters, you must specify Parameters.N.ParameterKey and Parameters.N.ParameterValue.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-xxxxxx</para>
            /// </summary>
            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

        /// <summary>
        /// <para>The name of the RAM role. ROS assumes the RAM role to create the stack and uses the credentials of the role to call the APIs of Alibaba Cloud services.\
        /// ROS assumes the RAM role to perform operations on the stack. If you have permissions to perform operations on the stack but do not have permissions to use the RAM role, ROS still assumes the RAM role. You must make sure that the least privileges are granted to the RAM role.</para>
        /// <para>If you do not specify this parameter, ROS assumes the existing role that is associated with the stack. If no roles are available, ROS uses a temporary credential that is generated from the credentials of your account.</para>
        /// <para>The RAM role name can be up to 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-role</para>
        /// </summary>
        [NameInMap("RamRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        /// <summary>
        /// <para>The region ID of the stack. You can call the <a href="https://help.aliyun.com/document_detail/131035.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group. If you leave this parameter empty, the stack is added to the default resource group.</para>
        /// <para>For more information about resource groups, see the &quot;Resource group&quot; section of the <a href="https://help.aliyun.com/document_detail/94475.html">What is Resource Management?</a> topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxazb4ph6aiy****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The name of the stack.\
        /// The name can be up to 255 characters in length, and can contain digits, letters, hyphens (-), and underscores (_). It must start with a letter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyStack</para>
        /// </summary>
        [NameInMap("StackName")]
        [Validation(Required=false)]
        public string StackName { get; set; }

        /// <summary>
        /// <para>The structure that contains the stack policy body. The policy body must be 1 to 16,384 bytes in length.</para>
        /// <remarks>
        /// <para>You can specify only one of StackPolicyBody and StackPolicyURL.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Statement&quot;: [{&quot;Action&quot;: &quot;Update:<em>&quot;, &quot;Resource&quot;: &quot;</em>&quot;, &quot;Effect&quot;: &quot;Allow&quot;, &quot;Principal&quot;: &quot;*&quot;}]}</para>
        /// </summary>
        [NameInMap("StackPolicyBody")]
        [Validation(Required=false)]
        public string StackPolicyBody { get; set; }

        /// <summary>
        /// <para>The URL of the file that contains the stack policy. The URL must point to a policy that is located on an HTTP or HTTPS web server or in an Object Storage Service (OSS) bucket, such as oss://ros/stack-policy/demo or oss://ros/stack-policy/demo?RegionId=cn-hangzhou. The policy file can be up to 16,384 bytes in length. If you do not specify the region ID of the OSS bucket, the value of RegionId is used.</para>
        /// <remarks>
        /// <para>You can specify only one of StackPolicyBody and StackPolicyURL.</para>
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
        /// <para>The tags that you want to add to the stack.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateStackRequestTags> Tags { get; set; }
        public class CreateStackRequestTags : TeaModel {
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
            /// <para>The tag of a stack is propagated to each resource that supports the tag feature in the stack. For more information, see <a href="https://help.aliyun.com/document_detail/201421.html">Propagate tags</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// <para>The template ID. This parameter applies to shared templates and private templates.</para>
        /// <remarks>
        /// <para>You must and can specify only one of the following parameters: TemplateBody, TemplateURL, TemplateId, and TemplateScratchId.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5ecd1e10-b0e9-4389-a565-e4c15efc****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The scenario ID.</para>
        /// <para>For more information about how to query the scenario ID, see <a href="https://help.aliyun.com/document_detail/363050.html">ListTemplateScratches</a>.</para>
        /// <remarks>
        /// <para>You must and can specify only one of the following parameters: TemplateBody, TemplateURL, TemplateId, and TemplateScratchId.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ts-aa9c62feab844a6b****</para>
        /// </summary>
        [NameInMap("TemplateScratchId")]
        [Validation(Required=false)]
        public string TemplateScratchId { get; set; }

        /// <summary>
        /// <para>The region ID of the scenario. The default value is the same as the value of RegionId.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/131035.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("TemplateScratchRegionId")]
        [Validation(Required=false)]
        public string TemplateScratchRegionId { get; set; }

        /// <summary>
        /// <para>The URL of the file that contains the template body. The URL must point to a template that is located on an HTTP or HTTPS web server or in an OSS bucket, such as oss://ros/template/demo or oss://ros/template/demo?RegionId=cn-hangzhou. The template body can be up to 524,288 bytes in length. If you do not specify the region ID of the OSS bucket, the value of RegionId is used.</para>
        /// <remarks>
        /// <para>You must and can specify only one of the following parameters: TemplateBody, TemplateURL, TemplateId, and TemplateScratchId.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>oss://ros-template/demo</para>
        /// </summary>
        [NameInMap("TemplateURL")]
        [Validation(Required=false)]
        public string TemplateURL { get; set; }

        /// <summary>
        /// <para>The version of the template. This parameter takes effect only when TemplateId is specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public string TemplateVersion { get; set; }

        /// <summary>
        /// <para>The timeout period for creating the stack.</para>
        /// <list type="bullet">
        /// <item><description>Default value: 60.</description></item>
        /// <item><description>Unit: minutes.</description></item>
        /// <item><description>Valid values: 10 to 1440.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TimeoutInMinutes")]
        [Validation(Required=false)]
        public long? TimeoutInMinutes { get; set; }

    }

}
