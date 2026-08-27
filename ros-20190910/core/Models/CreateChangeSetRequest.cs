// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class CreateChangeSetRequest : TeaModel {
        /// <summary>
        /// <para>The change set name. Maximum length: 255 characters. The name can contain digits, letters, hyphens (-), and underscores (_), and must start with a digit or letter.</para>
        /// <remarks>
        /// <para>The name of the change set must be unique within the stack.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyChangeSet</para>
        /// </summary>
        [NameInMap("ChangeSetName")]
        [Validation(Required=false)]
        public string ChangeSetName { get; set; }

        /// <summary>
        /// <para>The type of the change set. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>CREATE: creates a change set for a new stack.</para>
        /// </description></item>
        /// <item><description><para>UPDATE (default): creates a change set for an existing stack.</para>
        /// </description></item>
        /// <item><description><para>IMPORT: creates a change set for a new stack or an existing stack to import resources that are not managed by ROS.</para>
        /// </description></item>
        /// </list>
        /// <para>If you set the value of ChangeSetType to CREATE, ROS creates a new stack. The stack is in the <c>REVIEW_IN_PROGRESS</c> state until you execute the change set.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>You cannot use the UPDATE type to create a change set for a new stack or the CREATE type to create a change set for an existing stack.</para>
        /// </description></item>
        /// <item><description><para>You cannot set a stack policy for a change set of the IMPORT type. You can set a stack policy when you create or update a stack.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>UPDATE</para>
        /// </summary>
        [NameInMap("ChangeSetType")]
        [Validation(Required=false)]
        public string ChangeSetType { get; set; }

        /// <summary>
        /// <para>The client token used to ensure request idempotence. The token must be unique across requests and can be up to 64 characters in length, containing letters, digits, hyphens (-), and underscores (_). <a href="https://help.aliyun.com/document_detail/134212.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the change set. The description can be up to 1,024 bytes in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>It is a demo.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to disable rollback on stack creation failure. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: disables rollback on creation failure.</para>
        /// </description></item>
        /// <item><description><para>false (default): enables rollback on creation failure.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only when ChangeSetType is set to CREATE or IMPORT.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DisableRollback")]
        [Validation(Required=false)]
        public bool? DisableRollback { get; set; }

        /// <summary>
        /// <para>The list of webhook addresses for receiving stack event notifications.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://my-site.com/ros-notify">http://my-site.com/ros-notify</a></para>
        /// </summary>
        [NameInMap("NotificationURLs")]
        [Validation(Required=false)]
        public List<string> NotificationURLs { get; set; }

        /// <summary>
        /// <para>The maximum number of concurrent resource operations. By default, this value is empty. Once set, the value is associated with the stack and affects subsequent operations.</para>
        /// <para>This parameter takes effect only when ChangeSetType is set to CREATE or UPDATE. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If ChangeSetType is set to CREATE</para>
        /// <list type="bullet">
        /// <item><description><para>If you set this parameter to an integer that is greater than 0, the integer is used.</para>
        /// </description></item>
        /// <item><description><para>If you set this parameter to 0 or do not set this parameter, no limit is imposed on ROS stacks. For Terraform stacks, the default value of Terraform is used, which is 10.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>If ChangeSetType is set to UPDATE</para>
        /// <list type="bullet">
        /// <item><description><para>If you set this parameter to an integer that is greater than 0, the integer is used.</para>
        /// </description></item>
        /// <item><description><para>If you set this parameter to 0, no limit is imposed on ROS stacks. For Terraform stacks, the default value of Terraform is used, which is 10.</para>
        /// </description></item>
        /// <item><description><para>If you do not set this parameter, the value that you specified in the previous operation is used. If you did not set this parameter in the previous operation, no limit is imposed on ROS stacks. For Terraform stacks, the default value of Terraform is used, which is 10.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
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
        public List<CreateChangeSetRequestParameters> Parameters { get; set; }
        public class CreateChangeSetRequestParameters : TeaModel {
            /// <summary>
            /// <para>The name of the parameter that is defined in the template. If you do not specify the name and value of a parameter, ROS uses the default name and value that are specified in the template. The value of N can be up to 200.</para>
            /// <remarks>
            /// <para>The Parameters parameter is optional. If you specify Parameters, you must also specify Parameters.N.ParameterKey.</para>
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
            /// <para>The value of the parameter that is defined in the template. The value of N can be up to 200.</para>
            /// <remarks>
            /// <para>The Parameters parameter is optional. If you specify Parameters, you must also specify Parameters.N.ParameterValue.</para>
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
        /// <para>The RAM role name. ROS assumes this role to call Alibaba Cloud service APIs and always uses it for all stack operations. If you lack the required permissions, ROS assumes the role specified by RamRoleName. If unspecified, ROS uses the existing stack role. If no role is available, ROS uses a temporary credential from your account. Maximum length: 64 bytes.</para>
        /// <para><a href="https://help.aliyun.com/document_detail/2568025.html">Stack roles</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-role</para>
        /// </summary>
        [NameInMap("RamRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        /// <summary>
        /// <para>The region ID of the change set.</para>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/131035.html">DescribeRegions</a> to query available regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable replacement update when a resource property change does not support modification updates. A replacement update deletes the existing resource and creates a new one with a new physical ID. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Enabled: enables replacement update.</para>
        /// </description></item>
        /// <item><description><para>Disabled (default): disables replacement update.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Modification updates are preferentially used. This parameter takes effect only when ChangeSetType is set to UPDATE.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Disabled</para>
        /// </summary>
        [NameInMap("ReplacementOption")]
        [Validation(Required=false)]
        public string ReplacementOption { get; set; }

        /// <summary>
        /// <para>The resource group ID. If unspecified, the stack is added to the default resource group. <a href="https://help.aliyun.com/document_detail/94475.html">What is a resource group?</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxazb4ph6aiy****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The list of resources to be imported.</para>
        /// </summary>
        [NameInMap("ResourcesToImport")]
        [Validation(Required=false)]
        public List<CreateChangeSetRequestResourcesToImport> ResourcesToImport { get; set; }
        public class CreateChangeSetRequestResourcesToImport : TeaModel {
            /// <summary>
            /// <para>The logical ID of the resource. The logical ID is the resource name that is defined in the template.</para>
            /// <remarks>
            /// <para>This parameter takes effect only when ChangeSetType is set to IMPORT. The ResourcesToImport parameter is optional. If you specify ResourcesToImport, you must also specify ResourcesToImport.N.LogicalResourceId.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Vpc</para>
            /// </summary>
            [NameInMap("LogicalResourceId")]
            [Validation(Required=false)]
            public string LogicalResourceId { get; set; }

            /// <summary>
            /// <para>A key-value mapping between strings. The value is a JSON string that is used to identify the resource to be imported. The key is the identifier property of the resource, such as the VpcId of an ALIYUN::ECS::VPC resource. The value is the value of the property, such as <c>vpc-2zevx9ios****</c>.</para>
            /// <para>Call <a href="https://help.aliyun.com/document_detail/172485.html">GetTemplateSummary</a> to query resource identifier properties.</para>
            /// <remarks>
            /// <para>This parameter takes effect only when ChangeSetType is set to IMPORT. The ResourcesToImport parameter is optional. If you specify ResourcesToImport, you must also specify ResourcesToImport.N.ResourceIdentifier.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;VpcId&quot;: &quot;vpc-2zevx9ios******&quot;}</para>
            /// </summary>
            [NameInMap("ResourceIdentifier")]
            [Validation(Required=false)]
            public string ResourceIdentifier { get; set; }

            /// <summary>
            /// <para>The type of the resource. The resource type must be the same as the resource type that is defined in the template.</para>
            /// <remarks>
            /// <para>This parameter takes effect only when ChangeSetType is set to IMPORT. The ResourcesToImport parameter is optional. If you specify ResourcesToImport, you must also specify ResourcesToImport.N.ResourceType.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ALIYUN::ECS::VPC</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        /// <summary>
        /// <para>The stack ID. ROS compares the stack information with the submitted changes, such as a modified template or different parameter values, to generate the change set. Call <a href="https://help.aliyun.com/document_detail/610818.html">ListStacks</a> to query stack IDs.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when ChangeSetType is set to UPDATE or IMPORT.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</para>
        /// </summary>
        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

        /// <summary>
        /// <para>The stack name. Maximum length: 255 characters. The name can contain digits, letters, hyphens (-), and underscores (_), and must start with a digit or letter.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when ChangeSetType is set to CREATE or IMPORT.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>MyStack</para>
        /// </summary>
        [NameInMap("StackName")]
        [Validation(Required=false)]
        public string StackName { get; set; }

        /// <summary>
        /// <para>The structure of the stack policy. The policy body must be 1 to 16,384 bytes in length.</para>
        /// <para>When ChangeSetType is set to <b>CREATE</b>, you can specify only one of the StackPolicyBody and StackPolicyURL parameters.</para>
        /// <para>When ChangeSetType is set to <b>UPDATE</b>, you can specify only one of the following parameters:</para>
        /// <list type="bullet">
        /// <item><description><para>StackPolicyBody</para>
        /// </description></item>
        /// <item><description><para>StackPolicyURL</para>
        /// </description></item>
        /// <item><description><para>StackPolicyDuringUpdateBody</para>
        /// </description></item>
        /// <item><description><para>StackPolicyDuringUpdateURL</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Statement&quot;:[{&quot;Effect&quot;:&quot;Allow&quot;,&quot;Action&quot;:&quot;Update:<em>&quot;,&quot;Principal&quot;:&quot;</em>&quot;,&quot;Resource&quot;:&quot;*&quot;}]}</para>
        /// </summary>
        [NameInMap("StackPolicyBody")]
        [Validation(Required=false)]
        public string StackPolicyBody { get; set; }

        /// <summary>
        /// <para>The temporary overriding stack policy body. Length: 1 to 16,384 bytes. To update protected resources, specify a temporary overriding policy. If unspecified, the current stack policy applies. This parameter takes effect only when ChangeSetType is set to UPDATE. You can specify only one of the following parameters:</para>
        /// <list type="bullet">
        /// <item><description><para>StackPolicyBody</para>
        /// </description></item>
        /// <item><description><para>StackPolicyURL</para>
        /// </description></item>
        /// <item><description><para>StackPolicyDuringUpdateBody</para>
        /// </description></item>
        /// <item><description><para>StackPolicyDuringUpdateURL</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Statement&quot;:[{&quot;Effect&quot;:&quot;Allow&quot;,&quot;Action&quot;:&quot;Update:<em>&quot;,&quot;Principal&quot;:&quot;</em>&quot;,&quot;Resource&quot;:&quot;*&quot;}]}</para>
        /// </summary>
        [NameInMap("StackPolicyDuringUpdateBody")]
        [Validation(Required=false)]
        public string StackPolicyDuringUpdateBody { get; set; }

        /// <summary>
        /// <para>The URL of the temporary overriding stack policy file. The URL must point to a policy on a web server (HTTP or HTTPS) or in an OSS bucket, such as oss\://ros/stack-policy/demo or oss\://ros/stack-policy/demo?RegionId=cn-hangzhou. Maximum policy file size: 16,384 bytes.</para>
        /// <remarks>
        /// <para>If you do not specify the region of the OSS bucket, the value of RegionId is used.</para>
        /// </remarks>
        /// <para>Maximum URL length: 1,350 bytes. To update protected resources, specify a temporary overriding stack policy. If unspecified, the current stack policy applies. This parameter takes effect only when ChangeSetType is set to UPDATE. You can specify only one of the following parameters:</para>
        /// <list type="bullet">
        /// <item><description><para>StackPolicyBody</para>
        /// </description></item>
        /// <item><description><para>StackPolicyURL</para>
        /// </description></item>
        /// <item><description><para>StackPolicyDuringUpdateBody</para>
        /// </description></item>
        /// <item><description><para>StackPolicyDuringUpdateURL</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>oss://ros/stack-policy/demo</para>
        /// </summary>
        [NameInMap("StackPolicyDuringUpdateURL")]
        [Validation(Required=false)]
        public string StackPolicyDuringUpdateURL { get; set; }

        /// <summary>
        /// <para>The URL of the stack policy file. The URL must point to a policy on a web server (HTTP or HTTPS) or in an OSS bucket, such as oss\://ros/stack-policy/demo or oss\://ros/stack-policy/demo?RegionId=cn-hangzhou. Maximum policy file size: 16,384 bytes.</para>
        /// <para>Maximum URL length: 1,350 bytes.</para>
        /// <remarks>
        /// <para>If you do not specify the region of the OSS bucket, the value of RegionId is used.</para>
        /// </remarks>
        /// <para>When ChangeSetType is set to <b>CREATE</b>, you can specify only one of the StackPolicyBody and StackPolicyURL parameters.</para>
        /// <para>When ChangeSetType is set to <b>UPDATE</b>, you can specify only one of the following parameters:</para>
        /// <list type="bullet">
        /// <item><description><para>StackPolicyBody</para>
        /// </description></item>
        /// <item><description><para>StackPolicyURL</para>
        /// </description></item>
        /// <item><description><para>StackPolicyDuringUpdateBody</para>
        /// </description></item>
        /// <item><description><para>StackPolicyDuringUpdateURL</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>oss://ros/stack-policy/demo</para>
        /// </summary>
        [NameInMap("StackPolicyURL")]
        [Validation(Required=false)]
        public string StackPolicyURL { get; set; }

        /// <summary>
        /// <para>The tags of the change set.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateChangeSetRequestTags> Tags { get; set; }
        public class CreateChangeSetRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key of the stack.</para>
            /// <para>The value of N can be from 1 to 20.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>The Tags parameter is optional. If you specify Tags, you must also specify Tags.N.Key.</para>
            /// </description></item>
            /// <item><description><para>The tag is propagated to each stack resource that supports tags. <a href="https://help.aliyun.com/document_detail/201421.html">Propagate tags</a>.</para>
            /// </description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>usage</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the stack.</para>
            /// <para>The value of N can be from 1 to 20.</para>
            /// <remarks>
            /// <para>The tag is propagated to each stack resource that supports tags. For more information, see <a href="https://help.aliyun.com/document_detail/201421.html">Propagate tags</a>.</para>
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
        /// <para>The list of resources to be marked as dirty.</para>
        /// </summary>
        [NameInMap("TaintResources")]
        [Validation(Required=false)]
        public List<string> TaintResources { get; set; }

        /// <summary>
        /// <para>The template body. Length: 1 to 524,288 bytes. For large templates, use HTTP POST with a body parameter to avoid URL length limits.</para>
        /// <remarks>
        /// <para>You can specify only one of the TemplateBody, TemplateURL, and TemplateId parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ROSTemplateFormatVersion&quot;:&quot;2015-09-01&quot;}</para>
        /// </summary>
        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// <para>The template ID. This parameter applies to shared templates and private templates.</para>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/610842.html">ListTemplates</a> to query template IDs.</para>
        /// <remarks>
        /// <para>You can specify only one of the TemplateBody, TemplateURL, and TemplateId parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5ecd1e10-b0e9-4389-a565-e4c15efc****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The resource scenario ID, which is the resource management scenario ID.</para>
        /// <para>This parameter takes effect only when ChangeSetType is set to IMPORT. This parameter supports only the creation of new stacks for resource import.</para>
        /// <para>If you want to import resources in a resource management scenario, specify only this parameter. Do not specify parameters related to templates.</para>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/610832.html">ListTemplateScratches</a> to query scenario IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</para>
        /// </summary>
        [NameInMap("TemplateScratchId")]
        [Validation(Required=false)]
        public string TemplateScratchId { get; set; }

        /// <summary>
        /// <para>The URL of the template file. The URL must point to a template on a web server (HTTP or HTTPS) or in an OSS bucket, such as oss\://ros/template/demo or oss\://ros/template/demo?RegionId=cn-hangzhou. Maximum template body size: 524,288 bytes.</para>
        /// <remarks>
        /// <para>If you do not specify the region of the OSS bucket, the value of RegionId is used.</para>
        /// </remarks>
        /// <para>You can specify only one of the TemplateBody, TemplateURL, and TemplateId parameters.</para>
        /// <para>The URL can be up to 1,024 bytes in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://ros/template/demo</para>
        /// </summary>
        [NameInMap("TemplateURL")]
        [Validation(Required=false)]
        public string TemplateURL { get; set; }

        /// <summary>
        /// <para>The version of the template.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when TemplateId is specified.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public string TemplateVersion { get; set; }

        /// <summary>
        /// <para>The timeout period before the stack enters CREATE_FAILED or UPDATE_FAILED state. Required when ChangeSetType is CREATE. Optional when ChangeSetType is UPDATE.</para>
        /// <list type="bullet">
        /// <item><description><para>Unit: minutes.</para>
        /// </description></item>
        /// <item><description><para>Valid values: 10 to 1440.</para>
        /// </description></item>
        /// <item><description><para>Default value: 60.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("TimeoutInMinutes")]
        [Validation(Required=false)]
        public long? TimeoutInMinutes { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the values of parameters that were last used. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true</para>
        /// </description></item>
        /// <item><description><para>false (default)</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only when ChangeSetType is set to UPDATE or IMPORT.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UsePreviousParameters")]
        [Validation(Required=false)]
        public bool? UsePreviousParameters { get; set; }

    }

}
