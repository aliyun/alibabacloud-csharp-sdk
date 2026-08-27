// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class CreateStackRequest : TeaModel {
        /// <summary>
        /// <para>Ensures request idempotency. Must be client-generated and globally unique. Maximum length: 64 characters. Can contain <b>letters</b>, <b>digits</b>,<b>&#x20;hyphens (-)</b>, an&#x64;<b>&#x20;underscores (_)</b>.</para>
        /// <para><a href="https://help.aliyun.com/document_detail/134212.html">How to ensure idempotence</a></para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The post-creation behavior for the stack. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>KeepStackOnCreationComplete (default): retains the stack and resources after creation. Counts toward the stack quota.</para>
        /// </description></item>
        /// <item><description><para>AbandonStackOnCreationComplete: deletes the stack but retains resources after creation. Does not count toward the stack quota. The stack is retained if creation fails.</para>
        /// </description></item>
        /// <item><description><para>AbandonStackOnCreationRollbackComplete: deletes the stack after a creation rollback. Does not count toward the stack quota. The stack is retained in other rollback scenarios.</para>
        /// </description></item>
        /// <item><description><para>ManuallyPay: requires manual payment for subscription resources during stack creation. Supported resource types: <c>ALIYUN::ECS::InstanceGroup</c>, <c>ALIYUN::RDS::DBInstance</c>, <c>ALIYUN::SLB::LoadBalancer</c>, <c>ALIYUN::VPC::EIP</c>, and <c>ALIYUN::VPC::VpnGateway</c>.</para>
        /// </description></item>
        /// <item><description><para>RetryOnNoStock: automatically retries resource creation on insufficient inventory. Supported resource type: <c>ALIYUN::RDS::DBInstance</c>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You can specify only one of the following parameters: CreateOption or CreateOptions.</para>
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
        /// <para>Specifies whether to enable deletion protection on the stack. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Enabled: enables deletion protection.</para>
        /// </description></item>
        /// <item><description><para>Disabled (default): allows stack deletion via the ROS console or the DeleteStack API.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The deletion protection of a nested stack is the same as that of its root stack.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public string DeletionProtection { get; set; }

        /// <summary>
        /// <para>Specifies whether to disable rollback when stack creation fails.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: disables rollback.</para>
        /// </description></item>
        /// <item><description><para>false (default): enables rollback.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DisableRollback")]
        [Validation(Required=false)]
        public bool? DisableRollback { get; set; }

        /// <summary>
        /// <para>The callback URL for stack events. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>HTTP POST URL. Maximum length: 1,024 bytes.</para>
        /// </description></item>
        /// <item><description><para>EventBridge receives stack status change notifications. View events in the <a href="https://eventbridge.console.aliyun.com">EventBridge console</a>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Supported regions: China (Hangzhou), China (Shanghai), China (Beijing), China (Hong Kong), and China (Zhangjiakou).</para>
        /// </remarks>
        /// <para>Maximum value of N: 5. ROS sends notifications on stack status changes, except for IN_PROGRESS events. With rollback enabled, CREATE_ROLLBACK and ROLLBACK events replace CREATE_FAILED and UPDATE_FAILED notifications. Notifications always include Outputs. Example notification:</para>
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
        /// <para>The maximum number of concurrent operations on resources.</para>
        /// <para>Default: empty. Accepts integers greater than or equal to 0.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>If greater than 0, the specified value is used. If 0 or empty, no limit applies to ROS stacks; Terraform stacks use the Terraform default (typically 10).</para>
        /// </description></item>
        /// <item><description><para>The specified value persists with the stack and affects subsequent operations such as updates.</para>
        /// </description></item>
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
            /// <para>The name of parameter N defined in the template. If you do not specify the name and value of a parameter, ROS uses the default value in the template.</para>
            /// <para>The maximum value of N is 200. The name must be 1 to 128 characters and cannot start with <c>aliyun</c> or <c>acs:</c>. The name cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <remarks>
            /// <para>Parameters is an optional parameter. To specify Parameters, you must specify both Parameters.N.ParameterKey and Parameters.N.ParameterValue.</para>
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
            /// <para>The value of parameter N defined in the template.</para>
            /// <para>The maximum value of N is 200. The value must be 0 to 128 characters and cannot start with <c>aliyun</c> or <c>acs:</c>. The value cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <remarks>
            /// <para>Parameters is an optional parameter. To specify Parameters, you must specify both Parameters.N.ParameterKey and Parameters.N.ParameterValue.</para>
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
        /// <para>The RAM role name. ROS assumes this role for all stack API calls, even when the user has direct permissions, ensuring least-privilege access. <a href="https://help.aliyun.com/document_detail/2568025.html">Use a stack role</a>.</para>
        /// <para>If not specified, ROS uses the role associated with the stack, or a temporary credential from your account if no role exists.</para>
        /// <para>Maximum length: 64 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-role</para>
        /// </summary>
        [NameInMap("RamRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        /// <summary>
        /// <para>The region ID of the stack. Call <a href="https://help.aliyun.com/document_detail/131035.html">DescribeRegions</a> to query available regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group. If not specified, the stack is added to the default resource group.</para>
        /// <para><a href="https://help.aliyun.com/document_detail/94475.html">What is a resource group</a></para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxazb4ph6aiy****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The stack name. Maximum length: 255 characters. Must start with a <b>letter</b> and can contain <b>letters</b>, <b>digits</b>, <b>hyphens (-)</b>, and <b>underscores (_)</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyStack</para>
        /// </summary>
        [NameInMap("StackName")]
        [Validation(Required=false)]
        public string StackName { get; set; }

        /// <summary>
        /// <para>The stack policy body. Length: 1 to 16,384 bytes.</para>
        /// <remarks>
        /// <para>You can specify only one of the following parameters: StackPolicyBody or StackPolicyURL.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Statement&quot;: [{&quot;Action&quot;: &quot;Update:<em>&quot;, &quot;Resource&quot;: &quot;</em>&quot;, &quot;Effect&quot;: &quot;Allow&quot;, &quot;Principal&quot;: &quot;*&quot;}]}</para>
        /// </summary>
        [NameInMap("StackPolicyBody")]
        [Validation(Required=false)]
        public string StackPolicyBody { get; set; }

        /// <summary>
        /// <para>The URL of the stack policy file. Supports HTTP, HTTPS, and OSS URLs (for example, oss\://ros/stack-policy/demo or oss\://ros/stack-policy/demo?RegionId=cn-hangzhou). Maximum file size: 16,384 bytes. If no OSS region is specified, the RegionId value is used.</para>
        /// <remarks>
        /// <para>You can specify only one of the following parameters: StackPolicyBody or StackPolicyURL.</para>
        /// </remarks>
        /// <para>Maximum URL length: 1,350 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://ros-stack-policy/demo</para>
        /// </summary>
        [NameInMap("StackPolicyURL")]
        [Validation(Required=false)]
        public string StackPolicyURL { get; set; }

        /// <summary>
        /// <para>The tags of the stack.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateStackRequestTags> Tags { get; set; }
        public class CreateStackRequestTags : TeaModel {
            /// <summary>
            /// <para>The key of tag N of the stack.</para>
            /// <para>Valid values: 1 to 20.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>Tags is an optional parameter. To specify Tags, you must specify Tags.N.Key.</para>
            /// </description></item>
            /// <item><description><para>Stack tags propagate to each resource that supports tagging. <a href="https://help.aliyun.com/document_detail/201421.html">Tag propagation</a>.</para>
            /// </description></item>
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
            /// <para>The value of tag N of the stack.</para>
            /// <para>Valid values: 1 to 20.</para>
            /// <remarks>
            /// <para>Stack tags propagate to taggable resources. <a href="https://help.aliyun.com/document_detail/201421.html">Tag propagation</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The template body. Length: <b>1 to 524,288 bytes</b>. Use <b>HTTP POST</b> with <b>Body parameters</b> for large content to avoid URL length limits.</para>
        /// <remarks>
        /// <para>You must specify only one of the following parameters: TemplateBody, TemplateURL, TemplateId, or TemplateScratchId.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ROSTemplateFormatVersion&quot;:&quot;2015-09-01&quot;}</para>
        /// </summary>
        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// <para>The template ID. This parameter applies to shared and private templates.</para>
        /// <remarks>
        /// <para>You must specify only one of the following parameters: TemplateBody, TemplateURL, TemplateId, or TemplateScratchId.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5ecd1e10-b0e9-4389-a565-e4c15efc****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The ID of the resource scenario.</para>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/363050.html">ListTemplateScratches</a> to query resource scenario IDs.</para>
        /// <remarks>
        /// <para>You must specify only one of the following parameters: TemplateBody, TemplateURL, TemplateId, or TemplateScratchId.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ts-aa9c62feab844a6b****</para>
        /// </summary>
        [NameInMap("TemplateScratchId")]
        [Validation(Required=false)]
        public string TemplateScratchId { get; set; }

        /// <summary>
        /// <para>The region ID of the resource scenario. Default value: the value of RegionId.</para>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/131035.html">DescribeRegions</a> to query available regions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("TemplateScratchRegionId")]
        [Validation(Required=false)]
        public string TemplateScratchRegionId { get; set; }

        /// <summary>
        /// <para>The URL of the template file. Supports HTTP, HTTPS, and OSS URLs (for example, oss\://ros/stack-policy/demo or oss\://ros/stack-policy/demo?RegionId=cn-hangzhou). Maximum template size: 524,288 bytes. If no OSS region is specified, the RegionId value is used.</para>
        /// <remarks>
        /// <para>You must specify only one of the following parameters: TemplateBody, TemplateURL, TemplateId, or TemplateScratchId.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>oss://ros-template/demo</para>
        /// </summary>
        [NameInMap("TemplateURL")]
        [Validation(Required=false)]
        public string TemplateURL { get; set; }

        /// <summary>
        /// <para>The version of the template. This parameter takes effect only when you specify TemplateId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public string TemplateVersion { get; set; }

        /// <summary>
        /// <para>The stack creation timeout. Unit: minutes.</para>
        /// <list type="bullet">
        /// <item><description><para>Default value: 60.</para>
        /// </description></item>
        /// <item><description><para>Valid values: 10 to 1440.</para>
        /// </description></item>
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
